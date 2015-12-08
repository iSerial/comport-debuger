using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AndonSerial.com.andon.mao.model;
using System.IO.Ports;
using Microsoft.Win32;
using System.Collections;

namespace AndonSerial
{
    public partial class AndonForm : Form
    {

        #region 变量定义
        private bool isReceiving;
        private bool dispReceive = true;
        private int messageGet;
        private int messageSend;
        #endregion

        public AndonForm()
        {
            InitializeComponent();
        }

        #region 定时器
        private void timerComGet_Tick(object sender, EventArgs e)
        {
            ListViewSet();
        }
        #endregion

        #region 串口信息获取
        public List<Serial> COMShow()
        {
            List<string> list = SerialPortUtil.GetCom();
            List<Serial> serialList = new List<Serial>();
            if (list.Count == 0)
            {
                //MessageBox.Show("当前未连接COM口");

            }
            else
            {
                foreach (string s in list)
                {
                    SerialPort sp = new SerialPort(s);
                    Serial serial = new Serial();
                    serial.Name = s;
                    try
                    {
                        sp.Open();
                        sp.Close();
                        serial.State = "空闲";
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        serial.State = "占用中";
                    }
                    serialList.Add(serial);
                }
            }
            return serialList;
        }
        #endregion

        #region ListView窗体赋值
        public void ListViewSet()
        {
            if (lvCOMShow.Items.Count > 0)
            {
                lvCOMShow.Items.Clear();
            }
            List<Serial> list = COMShow();
            if (list.Count == 0)
            {
                ListViewItem item = new ListViewItem("请插入");
                item.SubItems.Add("无状态");
                lvCOMShow.Items.Add(item);
            }
            else
            {
                for (int i = 0; i < list.Count; i++)
                {
                    ListViewItem item = new ListViewItem(list[i].Name);
                    item.SubItems.Add(list[i].State);
                    lvCOMShow.Items.Add(item);
                }
            }
        }
        #endregion

        #region 窗口加载
        private void AndonForm_Load(object sender, EventArgs e)
        {
            #region 接口方式获取COM口添加
            /*
            List<string> list = SerialPortUtil.GetCom();
            if (list.Count == 0)
            {
                cbDK.Items.Add("请插入");
            }
            foreach (string s in list)
            {
                cbDK.Items.Add(s);
            }
            */
            #endregion
            ComCbGet(cbDK);
            ComBoxInit();
            txtSendSet.Text = "1000";

            cbSJW.Enabled = false;
            cbJYW.Enabled = false;
            cbTZW.Enabled = false;
        }
        #endregion

        #region ComBox初始化
        public void ComBoxInit()
        {
            if (cbDK.Items.Count > 0)
            {
                cbDK.SelectedIndex = 0;
            }
            cbBTL.SelectedIndex = 6;
            cbSJW.SelectedIndex = 3;
            cbJYW.SelectedIndex = 0;
            cbTZW.SelectedIndex = 0;
        }
        #endregion

        #region 打开、关闭串口按钮
        private void button1_Click(object sender, EventArgs e)
        {
            if (btnOpenOrClose.Text.Equals("打开串口"))
            {
                if (serialPort.IsOpen)
                {
                    MessageBox.Show("请先关闭已开端口");
                }
                else
                {
                    cbDK.Enabled = false;
                    cbBTL.Enabled = false;
                    
                    //接收值
                    //端口名称
                    string name = cbDK.Text.Trim();
                    //波特率
                    int baudRate = Convert.ToInt32(cbBTL.Text.Trim());
                    //数据位
                    byte byteSize = Convert.ToByte(cbSJW.Text.Trim());
                    //校验位
                    string parity = cbJYW.Text.Trim();
                    //停止位
                    byte stopBits = Convert.ToByte(cbTZW.Text.Trim());

                    bool flag = SerialOpen(name, baudRate);
                    if (flag)
                    {
                        btnOpenOrClose.Text = "关闭串口";
                    }
                }
            }
            else
            {
                ComClose();
                cbDK.Enabled = true;
                cbBTL.Enabled = true;
                //cbSJW.Enabled = true;
                //cbJYW.Enabled = true;
                //cbTZW.Enabled = true;
            }
        }
        #endregion

        #region 打开串口
        public bool SerialOpen(string comName, int baudRate)
        {
            if (comName.Equals(""))
            {
                MessageBox.Show("请插入串口");
            }
            else
            {
                serialPort.PortName = comName;
                serialPort.BaudRate = baudRate;
                serialPort.ReceivedBytesThreshold = 1;
                serialPort.WriteTimeout = 1000;
                serialPort.ReadTimeout = 1000;//读超时
                serialPort.NewLine = "\r\n";
                serialPort.DataReceived += comm_DataReceived;//注册
                try
                {
                    serialPort.Open();//打开串口
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return serialPort.IsOpen;
        }
        #endregion

        #region 关闭串口
        public void ComClose()
        {
            serialPort.DataReceived += comm_DataReceived;
            //最大延迟两秒
            int i = Environment.TickCount;
            while (Environment.TickCount - i < 2000 && isReceiving) Application.DoEvents();
            this.btnOpenOrClose.Text = "打开串口";
            serialPort.Close();
        }
        #endregion

        #region 注册
        public void comm_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //开始读
            isReceiving = true;
            //缓存你的数据，注意，最好在Invoke之外缓存数据，只有更新UI的才需要Invoke 
            int count = serialPort.BytesToRead;
            if (count < 1) return;
            byte[] tmpBuf = new byte[count];
            serialPort.Read(tmpBuf, 0, count);
            //分析数据
            StringBuilder str = new StringBuilder();
            if (cbDispHex.Checked)
            {
                for (int i = 0; i < tmpBuf.Count(); i++)
                {
                    str.Append(string.Format("{0:X2} ", tmpBuf.ElementAt(i)));
                }
            }
            else
            {
                str.Append(System.Text.Encoding.ASCII.GetString(tmpBuf, 0, tmpBuf.Count()));
            }

            //匿名委托，用于this.Invoke调用。 
            EventHandler DelUpdate = delegate
            {
                //赋值
                //MessageBox.Show(str.ToString());
                txtMessageGet.AppendText(str.ToString());
                //文本区域自动清空
                if ((cbClear.Checked) && (txtMessageGet.Text.Length >= 100))
                {
                    txtMessageGet.Clear();
                }
                //接收字符
                messageGet = messageGet + count;
                labGet.Text = messageGet.ToString();
            };
            if (dispReceive)
                this.Invoke(DelUpdate);

            //结束读取
            isReceiving = false;

        }
        #endregion

        #region 使用注册表的方式添加下拉
        public void ComCbGet(ComboBox combobox)
        {
            ///定义注册表子Path
            string strRegPath = @"Hardware\\DeviceMap\\SerialComm";
            RegistryKey regRootKey;
            RegistryKey regSubKey;
            ///定义Root指向注册表HKEY_LOCAL_MACHINE节点
            regRootKey = Registry.LocalMachine;
            regSubKey = regRootKey.OpenSubKey(strRegPath);
            string[] strCommList = regSubKey.GetValueNames();
            foreach (string VName in strCommList)
            {
                //向listbox1中添加字符串的名称和数据，数据是从rk对象中的GetValue(it)方法中得来的
                combobox.Items.Add(regSubKey.GetValue(VName));
            }
            if (combobox.Items.Count > 0)
            {
                combobox.SelectedIndex = 0;
            }
            ///关闭
            regSubKey.Close();
            regRootKey.Close();
        }
        #endregion

        #region 发送
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen)
            {
                timerSendSet.Enabled = false;
                btnSendSet.Text = "自动发送";
                MessageBox.Show("请先打开串口");
                txtSendSet.Enabled = true;
            }
            else
            {
                //接收发送区域的值
                byte[] data = Encoding.Unicode.GetBytes(txtMessageSend.Text);
                string str = txtMessageSend.Text;
                if (cbReturn.Checked)
                    str += "\n";
                //没有选择十六进制
                if (!cbSend.Checked)
                {
                    serialPort.Write(str);
                    messageSend = messageSend + str.Length;
                }
                else
                {
                    //十六进制
                    str = str.Replace(" ", "");//去除所有空格
                    ArrayList SendCharList = new ArrayList();
                    int len = str.Length / 2;
                    string sstr;
                    Byte byt;
                    for (int i = 0; i < len; i++)
                    {
                        //每次取出两个字符，转成十六进制数，加到ArrayList中
                        sstr = str.Substring(2 * i, 2);
                        //加入容错处理
                        try
                        {
                            byt = Convert.ToByte(sstr, 16);
                            messageSend = messageSend + len;
                        }
                        catch
                        {
                            MessageBox.Show("发送数据中的有无法转成16进制数的字节：" + sstr, "系统提示");
                            return;
                        }
                        SendCharList.Add(byt);
                    }
                    Byte[] values = (Byte[])SendCharList.ToArray(typeof(Byte));//返回ArrayList
                    serialPort.Write(values, 0, len);
                }
                labSend.Text = messageSend.ToString();
            }
        }
        #endregion

        #region 发送的定时器
        private void timerSendSet_Tick(object sender, EventArgs e)
        {
            btnSend_Click(sender, e);
        }
        #endregion

        #region 自动发送按钮
        private void btnSendSet_Click(object sender, EventArgs e)
        {
            int timeInt = 0;
            string timeStr = txtSendSet.Text;
            bool flag = true;

            if (btnSendSet.Text.Equals("自动发送"))
            {
                if (timeStr.Equals(""))
                {
                    MessageBox.Show("自动发送时间为空");
                    flag = false;
                }
                else
                {
                    try
                    {
                        timeInt = Convert.ToInt32(timeStr);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        flag = false;
                    }
                    if (flag)
                    {
                        timerSendSet.Interval = timeInt;
                        timerSendSet.Enabled = true;
                        txtSendSet.Enabled = false;
                        btnSendSet.Text = "停止发送";
                    }
                }
            }
            else
            {
                timerSendSet.Enabled = false;
                txtSendSet.Enabled = true;
                btnSendSet.Text = "自动发送";
            }
        }
        #endregion

        #region 清空接收
        private void btnMessageGetClear_Click(object sender, EventArgs e)
        {
            txtMessageGet.Clear();
        }
        #endregion

        #region 清空计数
        private void btnNumClear_Click(object sender, EventArgs e)
        {
            messageGet = 0;
            messageSend = 0;
            labGet.Text = "----";
            labSend.Text = "----";
        }
        #endregion
    }
}
