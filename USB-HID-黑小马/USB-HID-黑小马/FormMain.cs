using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using HID;
using USB_HID_黑小马;

namespace HIDTester
{
    public partial class FormMain : Form
    {
        private Hid myHid = new Hid();
        private IntPtr myHidPtr = new IntPtr();

        public FormMain()
        {
            InitializeComponent();
            myHid.DataReceived += new EventHandler<HID.report>(myhid_DataReceived); //订阅DataRec事件
            myHid.DeviceRemoved += new EventHandler(myhid_DeviceRemoved);
            
        }

        Byte[] RecDataBuffer = new byte[90];
        private void GetVendorAndProductIDsFromTextBoxes(ref UInt16 myVendorID, ref UInt16 myProductID)
        {
            try
            {
                myVendorID = UInt16.Parse(txtVendorID.Text, NumberStyles.AllowHexSpecifier);
                myProductID = UInt16.Parse(txtProductID.Text, NumberStyles.AllowHexSpecifier);
            }
            catch
            {
                throw;
            }
        }      
        private void FrmMain_Load(object sender, EventArgs e)
        {
            outputListBox.Items.Clear();
        }

        private void cmdOpenDevice_Click(object sender, EventArgs e)
        {
            if (myHid.Opened == false)
            {
                UInt16 myVendorID = Convert.ToUInt16(txtVendorID.Text, 16);
                UInt16 myProductID = Convert.ToUInt16(txtProductID.Text, 16);
                //myHidPtr = new IntPtr();
                if ((int)(myHidPtr = myHid.OpenDevice(myVendorID, myProductID)) != -1)
                {
                    MessageBox.Show("open drive success");
                    stateLabel.Text = "设备打开";
                    stateLabel.BackColor = this.stateLabel.BackColor = System.Drawing.Color.Green;
                }
                else
                {
                    MessageBox.Show("open drive Failed");
                    stateLabel.Text = "连接失败";
                    stateLabel.BackColor = this.stateLabel.BackColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                stateLabel.Text = "设备已打开";
            }
        }
        //数据到达事件
        protected void myhid_DataReceived(object sender, report e)
        {
            //RecDataBuffer = e.reportBuff;
            //string receiveData = new ASCIIEncoding().GetString(RecDataBuffer);
            Byte[] a = e.reportBuff;
            string temp = null;
            for (int i = 0; i < a.Length; i++)
            {
                temp += a[i].ToString("X2") + " ";
            }
            Msg.msg = temp;
            outputListBox.Items.Add(temp);

        }
       //设备移除事件
        protected void myhid_DeviceRemoved(object sender, EventArgs e)
        {
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            outputListBox.Items.Clear();
        }
 
        private void cmdCloseDevice_Click(object sender, EventArgs e)
        {
            myHid.CloseDevice(myHidPtr);
            stateLabel.Text = "设备关闭";
            this.stateLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void aboutMenu_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://heixiaoma.top");
        }

        private void outputListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sendMsg("00mc");   
        }

        public void sendMsg(string cmd) {
            Byte[] data = Encoding.UTF8.GetBytes(cmd);
            report r = new report(0, data);
            myHid.Write(r);

        }



        private void button2_Click(object sender, EventArgs e)
        {
            Msg.fmian = this;
            new WebSocketServers().main();
        }
    }
}
