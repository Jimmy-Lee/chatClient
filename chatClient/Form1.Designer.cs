namespace chatClient
{
    partial class roomForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button sendMessage;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(roomForm));
            this.messageBlock = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.showMessage = new System.Windows.Forms.RichTextBox();
            this.leftBlock = new System.Windows.Forms.Panel();
            this.myName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.myPhoto = new System.Windows.Forms.PictureBox();
            this.IDBlock = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.myID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sendBlock = new System.Windows.Forms.Panel();
            this.textMessage = new System.Windows.Forms.TextBox();
            sendMessage = new System.Windows.Forms.Button();
            this.messageBlock.SuspendLayout();
            this.leftBlock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myPhoto)).BeginInit();
            this.IDBlock.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.sendBlock.SuspendLayout();
            this.SuspendLayout();
            // 
            // sendMessage
            // 
            sendMessage.Dock = System.Windows.Forms.DockStyle.Right;
            sendMessage.Location = new System.Drawing.Point(527, 0);
            sendMessage.Name = "sendMessage";
            sendMessage.Size = new System.Drawing.Size(57, 40);
            sendMessage.TabIndex = 0;
            sendMessage.Text = "send";
            sendMessage.UseVisualStyleBackColor = true;
            sendMessage.Click += new System.EventHandler(this.button1_Click);
            // 
            // messageBlock
            // 
            this.messageBlock.Controls.Add(this.button1);
            this.messageBlock.Controls.Add(this.showMessage);
            this.messageBlock.Location = new System.Drawing.Point(200, 0);
            this.messageBlock.Margin = new System.Windows.Forms.Padding(0);
            this.messageBlock.Name = "messageBlock";
            this.messageBlock.Size = new System.Drawing.Size(384, 522);
            this.messageBlock.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(236, 485);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // showMessage
            // 
            this.showMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showMessage.Location = new System.Drawing.Point(0, 0);
            this.showMessage.Margin = new System.Windows.Forms.Padding(0);
            this.showMessage.Name = "showMessage";
            this.showMessage.Size = new System.Drawing.Size(384, 522);
            this.showMessage.TabIndex = 0;
            this.showMessage.Text = "";
            // 
            // leftBlock
            // 
            this.leftBlock.Controls.Add(this.myName);
            this.leftBlock.Controls.Add(this.label1);
            this.leftBlock.Controls.Add(this.myPhoto);
            this.leftBlock.Controls.Add(this.IDBlock);
            this.leftBlock.Location = new System.Drawing.Point(0, 0);
            this.leftBlock.Margin = new System.Windows.Forms.Padding(0);
            this.leftBlock.Name = "leftBlock";
            this.leftBlock.Size = new System.Drawing.Size(200, 522);
            this.leftBlock.TabIndex = 1;
            // 
            // myName
            // 
            this.myName.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.myName.Location = new System.Drawing.Point(99, 50);
            this.myName.Name = "myName";
            this.myName.Size = new System.Drawing.Size(101, 39);
            this.myName.TabIndex = 3;
            this.myName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.myName_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(95, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "我是";
            // 
            // myPhoto
            // 
            this.myPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.myPhoto.BackColor = System.Drawing.SystemColors.Control;
            this.myPhoto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("myPhoto.BackgroundImage")));
            this.myPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myPhoto.Location = new System.Drawing.Point(9, 9);
            this.myPhoto.Margin = new System.Windows.Forms.Padding(0);
            this.myPhoto.Name = "myPhoto";
            this.myPhoto.Size = new System.Drawing.Size(80, 80);
            this.myPhoto.TabIndex = 1;
            this.myPhoto.TabStop = false;
            // 
            // IDBlock
            // 
            this.IDBlock.Controls.Add(this.tableLayoutPanel1);
            this.IDBlock.Location = new System.Drawing.Point(0, 122);
            this.IDBlock.Margin = new System.Windows.Forms.Padding(0);
            this.IDBlock.Name = "IDBlock";
            this.IDBlock.Size = new System.Drawing.Size(200, 400);
            this.IDBlock.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.myID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 40);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // myID
            // 
            this.myID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.myID.AutoSize = true;
            this.myID.Location = new System.Drawing.Point(43, 10);
            this.myID.Name = "myID";
            this.myID.Size = new System.Drawing.Size(154, 20);
            this.myID.TabIndex = 0;
            this.myID.Text = "你還沒輸入你的名字";
            this.myID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // sendBlock
            // 
            this.sendBlock.Controls.Add(this.textMessage);
            this.sendBlock.Controls.Add(sendMessage);
            this.sendBlock.Location = new System.Drawing.Point(0, 522);
            this.sendBlock.Margin = new System.Windows.Forms.Padding(0);
            this.sendBlock.Name = "sendBlock";
            this.sendBlock.Size = new System.Drawing.Size(584, 40);
            this.sendBlock.TabIndex = 2;
            // 
            // textMessage
            // 
            this.textMessage.Location = new System.Drawing.Point(9, 5);
            this.textMessage.Margin = new System.Windows.Forms.Padding(0);
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(515, 29);
            this.textMessage.TabIndex = 1;
            this.textMessage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textMessage_KeyPress);
            // 
            // roomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 562);
            this.Controls.Add(this.sendBlock);
            this.Controls.Add(this.leftBlock);
            this.Controls.Add(this.messageBlock);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "roomForm";
            this.Text = "Title here";
            this.messageBlock.ResumeLayout(false);
            this.leftBlock.ResumeLayout(false);
            this.leftBlock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myPhoto)).EndInit();
            this.IDBlock.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.sendBlock.ResumeLayout(false);
            this.sendBlock.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel messageBlock;
        private System.Windows.Forms.Panel leftBlock;
        private System.Windows.Forms.PictureBox myPhoto;
        private System.Windows.Forms.Panel IDBlock;
        private System.Windows.Forms.Panel sendBlock;
        private System.Windows.Forms.TextBox myName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox showMessage;
        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label myID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;

    }
}

