using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBroswer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void myWebView_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {

            myWebView.Navigate(myUrl.Text);

        }

        private void myUrl_TextChanged(object sender, EventArgs e)
        {
            myWebView.Navigate(myUrl.Text);

        }

        private void ForwardBtn_Click(object sender, EventArgs e)
        {
            myWebView.GoForward();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            myWebView.GoBack();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            myWebView.Refresh();
        }
    }
}
