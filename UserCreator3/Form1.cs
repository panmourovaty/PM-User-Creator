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


namespace UserCreator3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var proc1 = new ProcessStartInfo();
                string Command;
                proc1.UseShellExecute = true;
                Command = @"net user " + textBox1.Text + " " + textBox2.Text + " /add";
            if (checkBox1.Checked)
            {
                Command += " && " + "net localgroup " + '\u0022' + "Remote Desktop Users" + '\u0022' + " " + '\u0022' + textBox1.Text + '\u0022' + " /add";
            }
                proc1.WorkingDirectory = @"C:\Windows\System32";
                proc1.FileName = @"C:\Windows\System32\cmd.exe";
                proc1.Verb = "runas";
                proc1.Arguments = "/c " + Command;
                proc1.WindowStyle = ProcessWindowStyle.Hidden;
                Process.Start(proc1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(numericUpDown1.Value);
            int b = Convert.ToInt32(numericUpDown2.Value) + 1;
            progressBar1.Maximum = Convert.ToInt32(numericUpDown2.Value);
            for (int i = a; i < b; i++)
            {
                var proc1 = new ProcessStartInfo();
                string Command;
                proc1.UseShellExecute = true;
                if (checkBox3.Checked)
                {
                    Command = @"net user " + textBox3.Text + i + textBox6.Text + " " + " /add /logonpasswordchg:yes";
                }
                else
                {
                    Command = @"net user " + textBox3.Text + i + textBox6.Text + " " + textBox7.Text + " /add";
                }

                if (checkBox2.Checked)
                {
                    Command += " && " + "net localgroup " + '\u0022' + "Remote Desktop Users" + '\u0022' + " " + '\u0022' + textBox3.Text + i + textBox6.Text + '\u0022' + " /add";
                }
                proc1.WorkingDirectory = @"C:\Windows\System32";
                proc1.FileName = @"C:\Windows\System32\cmd.exe";
                proc1.Verb = "runas";
                proc1.Arguments = "/c " + Command;
                proc1.WindowStyle = ProcessWindowStyle.Hidden;
                Process.Start(proc1);
                progressBar1.Value += 1;
            }
            MessageBox.Show("Complete !");
            progressBar1.Value = 0;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                textBox7.Enabled = false; 
            }
            else
            {
                textBox7.Enabled = true;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label9.Text = textBox3.Text + numericUpDown1.Value + textBox6.Text + " - " + textBox3.Text + numericUpDown2.Value + textBox6.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.BackColor = colorDialog1.Color;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var proc1 = new ProcessStartInfo();
            string Command;
            proc1.UseShellExecute = true;
            Command = @"net user " + textBox4.Text + " /delete";
            proc1.WorkingDirectory = @"C:\Windows\System32";
            proc1.FileName = @"C:\Windows\System32\cmd.exe";
            proc1.Verb = "runas";
            proc1.Arguments = "/c " + Command;
            proc1.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(proc1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int c = Convert.ToInt32(numericUpDown4.Value);
            int d = Convert.ToInt32(numericUpDown3.Value) + 1;
            progressBar2.Maximum = Convert.ToInt32(numericUpDown2.Value);
            for (int i = c; i < d; i++)
            {
                var proc1 = new ProcessStartInfo();
                string Command;
                proc1.UseShellExecute = true;
                Command = @"net user " + textBox8.Text + i + textBox5.Text + " /delete";
                proc1.WorkingDirectory = @"C:\Windows\System32";
                proc1.FileName = @"C:\Windows\System32\cmd.exe";
                proc1.Verb = "runas";
                proc1.Arguments = "/c " + Command;
                proc1.WindowStyle = ProcessWindowStyle.Hidden;
                Process.Start(proc1);
                progressBar2.Value += 1;
            }
            MessageBox.Show("Complete !");
            progressBar2.Value = 0;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label17.Text = textBox8.Text + numericUpDown4.Value + textBox5.Text + " - " + textBox3.Text + numericUpDown3.Value + textBox5.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var proc1 = new ProcessStartInfo();
            string Command;
            proc1.UseShellExecute = true;
            Command = @"net user && pause";
            proc1.WorkingDirectory = @"C:\Windows\System32";
            proc1.FileName = @"C:\Windows\System32\cmd.exe";
            proc1.Verb = "runas";
            proc1.Arguments = "/c " + Command;
            proc1.WindowStyle = ProcessWindowStyle.Normal;
            Process.Start(proc1);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var proc1 = new ProcessStartInfo();
            string Command;
            proc1.UseShellExecute = true;
            Command = @"net user " + textBox9.Text + " /active:yes";
            proc1.WorkingDirectory = @"C:\Windows\System32";
            proc1.FileName = @"C:\Windows\System32\cmd.exe";
            proc1.Verb = "runas";
            proc1.Arguments = "/c " + Command;
            proc1.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(proc1);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var proc1 = new ProcessStartInfo();
            string Command;
            proc1.UseShellExecute = true;
            Command = @"net user " + textBox9.Text + " /active:no";
            proc1.WorkingDirectory = @"C:\Windows\System32";
            proc1.FileName = @"C:\Windows\System32\cmd.exe";
            proc1.Verb = "runas";
            proc1.Arguments = "/c " + Command;
            proc1.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(proc1);
        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            var proc1 = new ProcessStartInfo();
            string Command;
            proc1.UseShellExecute = true;
            Command = @"net user " + textBox10.Text + " && pause";
            proc1.WorkingDirectory = @"C:\Windows\System32";
            proc1.FileName = @"C:\Windows\System32\cmd.exe";
            proc1.Verb = "runas";
            proc1.Arguments = "/c " + Command;
            proc1.WindowStyle = ProcessWindowStyle.Normal;
            Process.Start(proc1);
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }
    }
}