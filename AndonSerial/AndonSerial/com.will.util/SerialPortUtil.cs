using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic.Devices;

namespace AndonSerial
{
    /// <summary>
    /// 串口工具类
    /// </summary>
    class SerialPortUtil
    {
        private static Computer pc;//用于查看现有COM连接

        #region 查询现有的COM连接
        /// <summary>
        /// 返回现有COM连接列表
        /// </summary>
        /// <returns></returns>
        public static List<string> GetCom()
        {
            List<string> list = new List<string>();
            pc = new Computer();
            foreach (string s in pc.Ports.SerialPortNames)
            {
                list.Add(s);
            }
            return list;
        }
        #endregion
    }
}
