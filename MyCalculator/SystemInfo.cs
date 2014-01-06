using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace MyCalculator
{
    public class SystemInfo
    {
        public SystemInfo()
        {
        }

        /// <summary>
        /// 获取系统信息
        /// </summary>
        public static string GetSystemInfo()
        {
            string result = string.Empty;

            //获取系统信息
            //get systeminfo
            Process cmd = new Process();
            //获得系统信息，使用"systeminfo.exe"
            cmd.StartInfo.FileName = "systeminfo.exe";
            //将cmd的标准输入和输出全部重定向到.Net程序中
            cmd.StartInfo.UseShellExecute = false;//必须为false
            //标准输入
            cmd.StartInfo.RedirectStandardInput = true;
            //标准输出
            cmd.StartInfo.RedirectStandardOutput = true;
            //不显示命令窗口界面
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            //启动cmd进程
            cmd.Start();
            //获取输出
            //说明：此处开始获取systeminfo内容，只有等进程退出后才能真正拿到
            string systeminfo = cmd.StandardOutput.ReadToEnd();

            //将得到的系统信息放到字符串数组中
            string[] arrSplit = { "\r\n" };
            string[] arrSysteminfo = systeminfo.Split(arrSplit, StringSplitOptions.RemoveEmptyEntries);

            //只取前30行
            for (int i = 0; i < 30; i++)
            {
                result += arrSysteminfo[i] + "\r\n";
            }

            return result;
        }
    }
}
