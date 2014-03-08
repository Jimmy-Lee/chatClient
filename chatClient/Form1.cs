
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace chatClient
{
    public partial class roomForm : Form
    {
        chatSocket client;
        StringHandler msgHandler;
        List<String> clientIDList = new List<string>();

        public roomForm()
        {
            InitializeComponent();

            msgHandler = updateMessage;
        }

        // actions ~
        private void myName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                sendMessage();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (myName.Enabled)
                MessageBox.Show("Register your name first");
            else
                sendMessage();
        }

        private void textMessage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r' && !myName.Enabled)
            {
                if (myName.Enabled)
                    MessageBox.Show("Register your name first");
                else
                    sendMessage();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int rowCount = this.tableLayoutPanel1.RowCount + 1;
            Label testLabel = new Label();
            testLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            testLabel.AutoSize = true;
            testLabel.Location = new System.Drawing.Point(43, 50);
            testLabel.Name = "testLabel";
            testLabel.Size = new System.Drawing.Size(154, 20);
            testLabel.TabIndex = 2;
            testLabel.Text = "TESTLABEL" + rowCount.ToString();
            testLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.tableLayoutPanel1.RowCount = rowCount;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 40*rowCount);
            this.tableLayoutPanel1.Controls.Add(testLabel, 1, rowCount-1);

        }

        public void sendMessage()
        {
            if (myName.Enabled)
            {
                //myName.Text = msg;
                if (!myName.Text.Trim().Equals(""))
                {
                    client = chatSocket.connect();
                    client.newListener(processMessage);
                    client.sendMessage("Welcome: " + myName.Text.Trim());
                }
                else
                    MessageBox.Show("Register your name first");
            }
            else if(textMessage.Text != "")
            {
                client.sendMessage(myName.Text.Trim() + " : " + textMessage.Text);
                textMessage.Text = "";
            }
        }

        public String processMessage(String msg)
        {
            this.Invoke(msgHandler, new Object[] { msg });
            return "";
        }

        public String updateMessage(String msg)
        {
            if (msg.IndexOf("Welcome: ") == 0 && msg.Substring(msg.IndexOf(' ') + 1) == myName.Text.Trim())
            {
                showMessage.AppendText(msg + '\n');
                myName.Text = myName.Text.Trim();
                myID.Text = myName.Text;
                myName.Enabled = false;
                clientIDList.Add(myID.Text);
                return "";
            }
            if(msg.IndexOf("IDListUpdate: ") == 0)
            {
                char[] del = { ':' };
                String[] words = msg.Substring(msg.IndexOf(' ') + 1).Split(del);
                foreach(String word in words)
                {
                    if (!clientIDList.Contains(word))
                    {
                        int rowCount = this.tableLayoutPanel1.RowCount + 1;
                        Label testLabel = new Label();
                        testLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
                        testLabel.AutoSize = true;
                        testLabel.Location = new System.Drawing.Point(43, 50);
                        testLabel.Name = "testLabel";
                        testLabel.Size = new System.Drawing.Size(154, 20);
                        testLabel.TabIndex = 2;
                        testLabel.Text = word;
                        testLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

                        this.tableLayoutPanel1.RowCount = rowCount;
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
                        this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 40 * rowCount);
                        this.tableLayoutPanel1.Controls.Add(testLabel, 1, rowCount - 1);

                        clientIDList.Add(word);
                    }
                }
                return "";
            }
            showMessage.AppendText(msg + '\n');
            return "";
        }

    }
}
