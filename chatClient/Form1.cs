
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;

namespace chatClient
{
    public partial class roomForm : Form
    {
        chatSocket client;
        StringHandler msgHandler;

        List<String> clientIDList = new List<string>();
        Label[] IDLabels = new Label[9];
        PictureBox[] IDPictures = new PictureBox[9];

        public roomForm()
        {
            InitializeComponent();

            msgHandler = updateMessage;
        }

        // actions ~
        private void myName_KeyPress(object sender, KeyPressEventArgs e)
        { // register a name
            if (e.KeyChar == '\r')
                sendMessage();
        }

        private void sendMessage_Click(object sender, EventArgs e)
        { // send message
            if (myName.Enabled)
                MessageBox.Show("Register your name first");
            else
                sendMessage();
        }

        private void textMessage_KeyPress(object sender, KeyPressEventArgs e)
        { // send message
            if (e.KeyChar == '\r' && !myName.Enabled)
            {
                if (myName.Enabled)
                    MessageBox.Show("Register your name first");
                else
                    sendMessage();
            }
        }

        private void myPhoto_Click(object sender, EventArgs e)
        { // change myPhoto and myIDPhoto, to all connected users
            if (myName.Enabled)
            {
                MessageBox.Show("Register your name first");
                return;
            }
            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(fd.FileName);
                this.myPhoto.BackgroundImage = image;
                client.sendMessage("sendPic:" + myID.Text);
                client.socket.SendFile(fd.FileName);
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Image image = myPhoto.Image;
            Label[] labels;
        }

        public void sendMessage()
        {
            if (myName.Enabled)
            {
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

                        // set the label
                        IDLabels[rowCount - 2] = new Label();
                        IDLabels[rowCount - 2].Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
                        IDLabels[rowCount - 2].AutoSize = true;
                        IDLabels[rowCount - 2].Location = new System.Drawing.Point(43, 50);
                        IDLabels[rowCount - 2].Name = "IDLabels" + rowCount;
                        IDLabels[rowCount - 2].Size = new System.Drawing.Size(154, 20);
                        IDLabels[rowCount - 2].TabIndex = 2;
                        IDLabels[rowCount - 2].TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        IDLabels[rowCount - 2].Text = word;

                        // set the picturebox
                        IDPictures[rowCount - 2] = new PictureBox();
                        IDPictures[rowCount - 2].BackColor = System.Drawing.Color.Transparent;
                        IDPictures[rowCount - 2].BackgroundImage = (Image)this.myIDPhoto.BackgroundImage;
                        IDPictures[rowCount - 2].BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                        IDPictures[rowCount - 2].Location = new System.Drawing.Point(0, 40);
                        IDPictures[rowCount - 2].Margin = new System.Windows.Forms.Padding(0);
                        IDPictures[rowCount - 2].Name = "IDPictures" + rowCount;
                        IDPictures[rowCount - 2].Size = new System.Drawing.Size(40, 40);
                        IDPictures[rowCount - 2].TabStop = false;

                        // put label and picturebox on tabellayoutpanel
                        this.tableLayoutPanel1.RowCount = rowCount;
                        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
                        this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 40 * rowCount);
                        this.tableLayoutPanel1.Controls.Add(IDLabels[rowCount - 2], 1, rowCount - 1);
                        this.tableLayoutPanel1.Controls.Add(IDPictures[rowCount - 2], 0, rowCount - 1);

                        clientIDList.Add(word);
                    }
                }
                return "";
            }

            if (msg.IndexOf("sendPic:") == 0)
            {
                Byte[] buffer = new Byte[131072];
                client.socket.Receive(buffer);
                String fileName = "tempFile" + client.GetHashCode();
                File.WriteAllBytes("tempFile", buffer);
                /*Image image = Image.FromFile(fileName);
                this.testPic.BackgroundImage = (Image)image.Clone();
                image = null;*/
                using (FileStream fs = new FileStream("tempFile", FileMode.Open, FileAccess.Read))
                {
                    this.testPic.BackgroundImage = Image.FromStream(fs);
                }
                client.sendMessage(myName.Text.Trim() + " : " + textMessage.Text);
                return "";
            }

            showMessage.AppendText(msg + '\n');
            return "";
        }

    }
}
