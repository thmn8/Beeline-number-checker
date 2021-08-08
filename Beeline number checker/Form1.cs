using System;
using System.Net;
using System.Windows.Forms;

namespace Beeline_number_checker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Chec_button_Click(object sender, EventArgs e)
        {
            //храним введенный телефон
            string phone = textBox1.Text;

            //стройка запроса
            Uri url = new($"https://beeline.ru/menu/loginmodel/?CTN={phone}");

            //запрос
            string res = new WebClient().DownloadString(url);

            if (textBox1.Text == "")
            {
                toolStripStatusLabel1.Text = "Номер не введен";
            }
            else
            {
                if (res.Contains("firstTimeLogin\":true"))
                {
                    toolStripStatusLabel1.Text = "Номер существует";
                }
                else
                {
                    res.Contains("firstTimeLogin\":string.Empty");
                    toolStripStatusLabel1.Text = "Номер не существует";
                }
            }
        }
    }
}