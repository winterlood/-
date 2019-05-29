using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        string systemPath = @"c:\Windows\System32\";
        public Form1()
        {
            InitializeComponent();
        }
        public void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(systemPath + "calc.exe");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string ChromePath = @"c:\ProgramData\Microsoft\Windows\Start Menu\Programs\Chrome";
            Process.Start(ChromePath);
        }
        private void button3_Click(object sender,  EventArgs e)
        {
            string vspath = @"c:\ProgramData\Microsoft\Windows\Start Menu\Programs\Visual Studio 2017";
            Process.Start(vspath);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string melonpath = @"c:\ProgramData\Microsoft\Windows\Start Menu\Programs\Melon\Melon";
            Process.Start(melonpath);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string kakaopath = @"c:\ProgramData\Microsoft\Windows\Start Menu\카카오톡";
            Process.Start(kakaopath);
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string memopath = @"c:\Windows\System32\notepad.exe";
            Process.Start(memopath);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //System.Windows.Forms.MessageBox.Show("바보가 맞다.");
        }
    }
}
