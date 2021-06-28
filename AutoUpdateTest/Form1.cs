using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoUpdateTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(string[] args)
        {
            InitializeComponent();

            cmdArgs.Text = "Args:";
            foreach (var str in args)
            {
                cmdArgs.Text += " ";
                cmdArgs.Text += _Esc(str);
            }
            vers.Text = Assembly.GetEntryAssembly().GetName().Version.ToString();
        }

        static string _Esc(string arg)
        {
            return string.Concat("\"", arg.Replace("\"", "\"\""), "\"");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
