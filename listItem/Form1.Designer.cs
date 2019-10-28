namespace listItem
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.myList = new System.Windows.Forms.ListBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.item = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.mname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sysinfo = new System.Windows.Forms.ListBox();
            this.getInfoBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // myList
            // 
            this.myList.FormattingEnabled = true;
            this.myList.Location = new System.Drawing.Point(367, 50);
            this.myList.Name = "myList";
            this.myList.Size = new System.Drawing.Size(144, 173);
            this.myList.TabIndex = 0;
            this.myList.SelectedIndexChanged += new System.EventHandler(this.myList_SelectedIndexChanged);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(368, 229);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(68, 23);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // item
            // 
            this.item.Location = new System.Drawing.Point(367, 21);
            this.item.Name = "item";
            this.item.Size = new System.Drawing.Size(55, 20);
            this.item.TabIndex = 2;
            this.item.TextChanged += new System.EventHandler(this.item_TextChanged);
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(429, 20);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(82, 20);
            this.phone.TabIndex = 3;
            this.phone.TextChanged += new System.EventHandler(this.phone_TextChanged);
            // 
            // mname
            // 
            this.mname.AutoSize = true;
            this.mname.Location = new System.Drawing.Point(326, 21);
            this.mname.Name = "mname";
            this.mname.Size = new System.Drawing.Size(35, 13);
            this.mname.TabIndex = 4;
            this.mname.Text = "Name";
            this.mname.Click += new System.EventHandler(this.Name_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(429, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Phone Number";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // sysinfo
            // 
            this.sysinfo.FormattingEnabled = true;
            this.sysinfo.Location = new System.Drawing.Point(13, 50);
            this.sysinfo.Name = "sysinfo";
            this.sysinfo.Size = new System.Drawing.Size(249, 225);
            this.sysinfo.TabIndex = 6;
            this.sysinfo.SelectedIndexChanged += new System.EventHandler(this.sysinfo_SelectedIndexChanged);
            // 
            // getInfoBtn
            // 
            this.getInfoBtn.Location = new System.Drawing.Point(13, 295);
            this.getInfoBtn.Name = "getInfoBtn";
            this.getInfoBtn.Size = new System.Drawing.Size(75, 23);
            this.getInfoBtn.TabIndex = 7;
            this.getInfoBtn.Text = "GetInfo";
            this.getInfoBtn.UseVisualStyleBackColor = true;
            this.getInfoBtn.Click += new System.EventHandler(this.getInfoBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.getInfoBtn);
            this.Controls.Add(this.sysinfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mname);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.item);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.myList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox myList;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox item;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label mname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox sysinfo;
        private System.Windows.Forms.Button getInfoBtn;
    }
}

