using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AndonSerial.com.andon.mao.model
{
    /// <summary>
    /// 串口实体类
    /// </summary>
    public class Serial
    {
        //COM口的名称
        private string name;
        //波特率
        public int baudRate;
        //数据位
        private byte byteSize;
        //校验位
        private byte parity;
        //停止位
        private byte stopBits;
        //COM口的状态
        private string state;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string State
        {
            get { return state; }
            set { state = value; }
        }

        public byte ByteSize
        {
            get { return byteSize; }
            set { byteSize = value; }
        }
        public byte Parity
        {
            get { return parity; }
            set { parity = value; }
        }
        public byte StopBits
        {
            get { return stopBits; }
            set { stopBits = value; }
        }

    }
}
