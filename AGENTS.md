# AGENTS.md

本文件用于指导后续自动化代理在本项目中工作。除非用户明确要求，优先遵循这里记录的项目约定。

## 项目概览

- 项目名：`UCM_Tools`
- 类型：Windows Forms 桌面程序
- 语言/框架：C#，.NET Framework 4.6.1
- 解决方案：`UCM_Tools.sln`
- 主工程：`UCM_Tools.csproj`
- 程序入口：`Program.cs`，启动 `Forms.MainForm`

该项目主要围绕雷达通信、协议解析、目标显示、录像/视频预览、数据回放和升级/激活等功能组织代码。

## 目录说明

- `Forms/`：WinForms 界面窗体与 Designer 文件，主窗体为 `MainForm`。
- `Radar/`：雷达领域逻辑、通信抽象、协议管理和协议解析实现。
- `Radar/Communication/`：串口、TCP、CANFD 等连接实现。
- `Radar/Protocols/`：不同雷达/通信格式的数据协议实现。
- `Tools/`：VTK 绘制、文本管理、数据回放、保存队列、公共工具等。
- `Config/`：配置读写逻辑和运行配置文件。
- `Camera/`：USB 摄像头、OpenCV 视频源和浮动预览相关代码。
- `Language/`：中英文界面文本资源。
- `CANFD/`、`DLL/`：外部硬件/业务 DLL，属于运行和构建依赖。
- `packages/`：旧式 NuGet `packages.config` 本地依赖目录。
- `bin/Debug/`：当前工程部分引用依赖来自此目录，例如 `CommonLib.dll`、`NPlot.dll`、`log4net.dll`。

## 构建与验证

常用构建命令：

```powershell
dotnet build UCM_Tools.sln --no-restore
```

当前环境下该命令可以构建成功，并输出 `bin\Debug\UCM_Tools.exe`。项目目前存在若干历史警告，包括：

- `log4net` 1.2.13.0 与 2.0.8.0 版本冲突。
- 多个 .NET Framework facade 程序集建议增加 binding redirect。
- 少量未使用变量、未使用字段，以及无 `await` 的 `async` 方法警告。

除非任务目标就是清理这些警告，不要在无关修改中顺手重构或大范围消除历史警告。

## 依赖注意事项

- 这是旧式 `.NET Framework` 项目，不是 SDK-style 项目。
- 依赖来自 `packages.config`、`packages/`、`DLL/` 和部分 `bin/Debug/` 文件。
- 修改引用、目标框架、平台目标或输出路径前要谨慎，因为项目依赖 x86 VTK、CANFD DLL、LibVLC、OpenCV 等本地组件。
- Debug 配置当前 `PlatformTarget` 为 `x86` 且 `Prefer32Bit=true`；Release 为 `AnyCPU`。
- CANFD 相关 DLL 位于 `CANFD/CX2_11/`，项目说明中提到创芯 CANFD 盒子支持 V2.11 以上版本。

## 修改规范

- 保持现有 WinForms 结构：窗体逻辑放在 `.cs`，控件布局由 `.Designer.cs` 管理。
- 不要手工大规模改写 Designer 文件；需要改界面时尽量做最小、可审查的变更。
- 协议解析和通信变更优先沿用 `IProtocol`、`IConn`、`ProtocolManage` 等现有抽象。
- 涉及雷达数据解析时，注意大小端、帧头帧尾、校验和、目标坐标和速度/RCS 计算的现有约定。
- 涉及 VTK 绘制、目标文本、轨迹和累计帧时，优先复用现有对象池和文本管理逻辑，避免恢复为每帧大量创建/销毁对象的方式。
- 配置文件修改后确认 `UCM_Tools.csproj` 中是否需要 `CopyToOutputDirectory`。
- 保持中文用户可读文本与 `Language/ChineseSimplified.xml`、英文文本与 `Language/English.xml` 的结构一致。

## 代码风格

- 现有代码以 C# 传统 WinForms 风格为主，优先保持局部一致性。
- 变量和方法命名尽量贴近周围代码，不引入不必要的新框架或大型抽象。
- 新增注释应解释业务协议、硬件约束或非显然的线程/绘制原因，不写重复代码含义的注释。
- 修改共享路径如 `Forms/MainForm.cs`、`Tools/VTKHelper.cs`、`Radar/Protocols/*` 时，优先缩小改动范围并做构建验证。

## 运行注意事项

- 应用是桌面 GUI 程序，完整运行可能依赖本机硬件、串口/CANFD 设备、摄像头、RTSP 地址或外部 DLL。
- 自动化验证通常以构建为主；涉及硬件或 GUI 交互的功能，需要用户在目标设备环境中复测。
- 当前目录不是 Git 仓库，无法依赖 `git status` 判断用户改动；编辑前应直接查看相关文件内容。


