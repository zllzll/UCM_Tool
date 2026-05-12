using LogProc;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UCM_Tools
{
    public class QueueSaveData : IDisposable
    {
        private int MaxFileSize = 5 * 1024 * 1024; // 设置最大文件大小为5MB
        //private readonly string _baseFilePath = "TargetInfos_{0}.txt";
        private readonly ConcurrentQueue<string> _dataQueue = new ConcurrentQueue<string>();

        private readonly ConcurrentQueue<List<byte>> _bytesQueue = new ConcurrentQueue<List<byte>>();

        private Thread _saveThread;
        private Thread _saveBytesThread;
        private bool _isRunning = true;
        string filePath = "";
        private string _savePath = "C://";
        int fileIndex = 0;
        string FileDesp = "TargetInfos";
        string exeName = "txt";
        /// <summary>
        /// 0:以字符串形式；1：以字节数组形式
        /// </summary>
        int mode = 0;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="path">存储路径</param>
        /// <param name="Mode">0:以字符串形式；1：以字节数组形式</param>
        /// <param name="extendName">文件扩展名</param>
        /// <param name="fileSize">文件超出多少M新建文件</param>
        public QueueSaveData(string path, int Mode = 0,string extendName = "txt",int fileSize = 5,string fileDesp = "TargetInfos")
        {
            try
            {
                _savePath = path;
                fileIndex = 0;
                exeName = extendName;
                mode = Mode;
                MaxFileSize = fileSize * 1024 * 1024;
                FileDesp = fileDesp;
                filePath = $"{_savePath}//{(DateTime.Now.ToString("yyyyMMddHHmmss"))}_{FileDesp}_{fileIndex}.{exeName}";
                // 启动一个单独的线程用于处理队列中的数据
                if (Mode == 0)
                {
                    _saveThread = new Thread(SaveDataToFile);
                    _saveThread.Start();
                }
                else if (Mode == 1)
                {
                    _saveBytesThread = new Thread(SaveBytesToFile);
                    _saveBytesThread.Start();
                }
            }
            catch(Exception ex) { Log.Error($"QueueSaveData Ex\r\n{ex.ToString()}"); }
        }

        public void Dispose()
        {
            _isRunning = false;
            _saveThread?.Join(); // 等待保存线程结束
            _saveBytesThread?.Join();
        }

        /// <summary>
        /// 加入队列
        /// </summary>
        /// <param name="data"></param>
        public void AddQueue(string data)
        {
            try
            {
                if (!string.IsNullOrEmpty(data))
                    _dataQueue.Enqueue(data);
            }
            catch(Exception ex)
            {
                Log.Error($"AddQueue(string data) Ex\r\n{ex.ToString()}");
            }
        }

        /// <summary>
        /// 加入队列
        /// </summary>
        /// <param name="data"></param>
        public void AddQueue(List<byte> byteList)
        {
            try
            {
                if (byteList != null && byteList.Count > 0)
                    _bytesQueue.Enqueue(byteList);
            }
            catch(Exception ex)
            {
                Log.Error($"AddQueue(List<byte> byteList) Ex\r\n{ex.ToString()}");
            }
        }

        // 在后台线程中运行的方法，不断从队列中取出数据并写入文件
        private void SaveDataToFile()
        {
            
            long currentFileSize = 0;

            while (_isRunning)
            {
                try
                {
                    string text = string.Empty;
                    if (_dataQueue.TryDequeue(out text))
                    {
                        using (FileStream fs = new FileStream(filePath, FileMode.Append, FileAccess.Write))
                        {
                            byte[] dataBytes = Encoding.UTF8.GetBytes(text);

                            long newSize = currentFileSize + dataBytes.Length;

                            fs.Write(dataBytes, 0, dataBytes.Length);
                            if (newSize > MaxFileSize)
                            {
                                //fs.Close();
                                currentFileSize = 0;
                                fileIndex++;
                                filePath = $"{_savePath}//{(DateTime.Now.ToString("yyyyMMddHHmmss"))}_{FileDesp}_{fileIndex}.{exeName}";
                            }
                            else
                            {
                                currentFileSize = newSize;
                            }
                        }
                    }
                    else
                    {
                        Thread.Sleep(2); // 避免空循环过于频繁
                    }
                }
                catch(Exception ex)
                {
                    Log.Error($"SaveDataToFile Ex\r\n{ex.ToString()}");
                }
            }
        }

        private void SaveBytesToFile()
        {

            long currentFileSize = 0;

            while (_isRunning)
            {
                try
                {
                    List<byte> bytes = null;
                    if (_bytesQueue.TryDequeue(out bytes))
                    {
                        using (FileStream fs = new FileStream(filePath, FileMode.Append, FileAccess.Write))
                        {

                            long newSize = currentFileSize + bytes.Count;

                            fs.Write(bytes.ToArray(), 0, bytes.Count);
                            if (newSize > MaxFileSize)
                            {
                                //fs.Close();
                                currentFileSize = 0;
                                fileIndex++;
                                filePath = $"{_savePath}//{(DateTime.Now.ToString("yyyyMMddHHmmss"))}_{FileDesp}_{fileIndex}.{exeName}";
                            }
                            else
                            {
                                currentFileSize = newSize;
                            }
                        }
                    }
                    else
                    {
                        Thread.Sleep(2); // 避免空循环过于频繁
                    }
                }
                catch(Exception ex)
                {
                    Log.Error($"SaveBytesToFile Ex\r\n{ex.ToString()}");
                }
            }
        }
    }
}
