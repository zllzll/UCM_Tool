# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## 项目概述

UCM_Tools 是一个 Windows Forms 雷达可视化与管理工具，基于 .NET Framework 4.6.1，使用 C# 开发。支持多种雷达型号（SR75、SR75(AFS721)、UCM211），通过 CAN/CANFD、TCP、串口（COM）等方式与雷达通信，实时显示 3D 点云和跟踪目标数据。

## 构建与运行

```bash
# 使用 MSBuild（必须在 Visual Studio 开发者命令行中执行）
msbuild UCM_Tools.sln /p:Configuration=Debug /p:Platform="Any CPU"

# Debug 构建实际编译为 x86（csproj 中 PlatformTarget 为 x86）
msbuild UCM_Tools.sln /p:Configuration=Release /p:Platform="Any CPU"
```

- **入口点**: `Program.cs` → `Main()`，单实例应用（通过 Mutex 保证）
- Debug 配置强制 x86 目标（因为依赖的 Activiz.NET 是 x86 版本）
- 项目引用了 `bin\Debug\` 下的本地 DLL（CommonLib.dll, NPlot.dll, log4net.dll），构建前需确保这些文件存在

## 核心架构

### 通信与协议层（策略/工厂模式）

```
IConn (抽象类)                    IProtocol (抽象类)
  ├── Conn_COM                     ├── Protocol_SR75CANFD
  ├── Conn_CANFD                   ├── Protocol_SR75CANFDToTCP
  └── Conn_TCP                     ├── Protocol_SR75TCP_Object
                                   ├── Protocol_UCM211_Bytes
                                   └── Protocol_UCM211_CAN
```

- `ProtocolManage.InitProtocol(string)` / `InitConn(string)` 通过反射根据类名字符串动态实例化
- `config.xml` 中的 `<argue key="雷达型号_通讯方式" value="协议类名" />` 决定映射关系（例如 `SR75_CAN` → `Protocol_SR75CANFD`）
- `Radar.xml` 定义支持的雷达型号及其通信方式

### 数据流

```
硬件 → IConn (接收原始数据) → OnRecvConnDataEvent
  → RadarClass.Conn_OnRecvConnDataEvent() → ConcurrentQueue<ConnData>
  → HandleRecvData 后台线程 → IProtocol.AddDataList(ConnData)
  → 协议解析后触发各类事件 (cycleDataEvent, tarAndClusterPointCloud 等)
  → MainForm 处理事件 → VTK 3D 渲染 / NPlot 2D 图表 / 数据存储
```

### VTK 3D 渲染（`MainForm.cs` + `Tools/VTKHelper.cs`）

- 使用 Activiz.NET 5.8 (VTK x86) 进行 3D 点云渲染
- 核心优化：**对象池模式**（`VTKObjectPool.cs`）复用 vtkTextActor3D/vtkTextActor，避免每帧创建/销毁，减少 GC 压力
- 支持两种文本模式：屏幕空间 2D 文本（vtkTextActor，高性能）和世界空间 3D 文本（vtkTextActor3D，高质量），通过 `UseScreenSpaceText` 配置切换
- `VtkDrawTimeInLostFocus` 参数控制失去焦点时的渲染频率，解决窗体最小化后帧率问题
- 点云颜色通过高度（Z 值）映射，高度阈值可通过配置文件调整颜色分界
- 跟踪目标轨迹通过 `Dictionary<uint, Queue<>>` 维护每个目标的历史位置

### 配置系统

- `Config/Params.config` — 所有运行时参数（通过 `CommonLib.ConfigXML` 读写），`SystemSetting.cs` 是这些参数的静态访问入口
- `Config/config.xml` — 雷达类型到协议的映射
- `Config/Radar.xml` — 支持的雷达型号定义
- `Config/Log4Net3.config` — 日志配置
- `app.config` 中 `DefaultLanguage` 键控制语言（ChineseSimplified / English），国际化文本在 `Language/` 目录下的 XML 文件中

### 其他重要模块

| 目录/文件 | 用途 |
|-----------|------|
| `Camera/` | USB 摄像头和 RTSP 视频流预览，通过 OpenCvSharp4 + AForge 实现 |
| `CAN_Conn/` | 周立功 CAN/CANFD 硬件通信封装 |
| `Tools/DataReplayer.cs` 等 | 离线数据回放（从文件读取历史雷达数据） |
| `Tools/QueueSaveData.cs` | 异步数据存储队列 |
| `Tools/NplotCls.cs` | NPlot 2D 图表封装 |
| `ExtendControls/` | 自定义 WinForms 控件（透明 Label、右键菜单渲染器） |
| `Forms/` | 所有窗体：MainForm（主界面）、TrackNplotForm（跟踪图表）、VideoPreviewForm（视频预览）、RadarUpgradeForm（升级）、SystemSetForm（设置）、RadarAliveForm（激活）等 |

## 注意事项

- 项目 Debug 编译为 x86（32位），不可改为 AnyCPU 或 x64（Activiz.NET 仅提供 x86 版本）
- VTK 在调试器附加时会跳过警告静默设置，直接运行时必须关闭 VTK 错误弹窗
- CAN 和 CANFD 目前共用同一个 `Conn_CANFD` 通信类（代码注释说明"后续有改动再说"）
- `ConnData` 统一封装不同通信方式的数据（CAN、CANFD、TCP、字节流）
- 主题切换通过 `PubClass.SetTheme()` 递归设置所有 SunnyUI 控件的样式
- UCM211 型号不支持雷达升级和激活功能（ReadMe.txt 中提到）
