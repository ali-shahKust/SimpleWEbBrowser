using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listItem
{

    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void item_TextChanged(object sender, EventArgs e)
        {
        }

      
        private void myList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void phone_TextChanged(object sender, EventArgs e)
        {

        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            String str = item.Text;
            String str2 = phone.Text;

            myList.Items.Add(str + " : " + str2);

            item.Text = "";
            phone.Text ="";
        }

        private void Name_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sysinfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void getInfoBtn_Click(object sender, EventArgs e)
        {
            foreach(var Drives in Environment.GetLogicalDrives())
            {
                System.IO.DriveInfo drinfo = new System.IO.DriveInfo(Drives);
                {
                    if (drinfo.IsReady == true)
                    {
                        sysinfo.Items.Add("Name :" + drinfo.Name);
                        sysinfo.Items.Add("Total Size: " + drinfo.TotalSize/1024);
                        sysinfo.Items.Add("Format :" + drinfo.DriveFormat);
                        sysinfo.Items.Add("Free Space " + drinfo.TotalFreeSpace);
                        sysinfo.Items.Add(" ");

                    }
                }
            }
        }
    }
}
