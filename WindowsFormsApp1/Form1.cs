using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = txtbox_url.Text.Trim();
            string tsname = txtbox_tsname.Text.Trim();
            string tsnamefrom = txtbox_tsnamefrom.Text.Trim();
            string tsnameto = txtbox_tsnameto.Text.Trim();
            string tsnameend;
            string cache = "";
            string q = "";

            if (url == "" || tsname == "" || tsnamefrom == "" || tsnameto == "")
            {
                MessageBox.Show("文本框不能为空！");
            }
            else
            {
                richtxtbox_downloadurl.Text = "";

                int startlen = tsnamefrom.Length;

                try
                {
                    for (int i = Convert.ToInt32(tsnamefrom); i < Convert.ToInt32(tsnameto) + 1; i++)
                    {
                        tsnameend = "";
                        for (int j = 0; j < startlen - i.ToString().Length; j++)
                        {
                            tsnameend += "0";
                        }
                        //cache = richtxtbox_downloadurl.Text;
                        cache = cache + url + tsname + tsnameend + i.ToString() + ".ts\n";
                        //MessageBox.Show(cache);
                        //richtxtbox_downloadurl.Text = richtxtbox_downloadurl.Text + url + tsname + tsnameend + i.ToString() + ".ts\n";
                    }
                    //MessageBox.Show("下载链接生成成功！");
                    richtxtbox_downloadurl.Text = cache;
                    richtxtbox_downloadurl.Focus();
                    richtxtbox_downloadurl.SelectAll();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}