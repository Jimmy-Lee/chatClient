using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chatClient
{
    public partial class roomForm : Form
    {
        public roomForm()
        {
            InitializeComponent();
        }

        public void sendMessage()
        {
            if (myName.Text.Trim().Length == 0) {
                MessageBox.Show("你還沒輸入你的名字");
                return;
            }
            /*
             * if (名字被別人取過了)
             *     Messagebox.show("名字被取過了，跪求換一個");
             * if (新使用者)
             *     註冊到server
            */
            if (textMessage.Text.Length > 0)
            {
                myName.Enabled = false;
                myID.Text = myName.Text;
                // send message to server
                textMessage.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sendMessage();
        }

        private void textMessage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                sendMessage();
        }
    }
}
