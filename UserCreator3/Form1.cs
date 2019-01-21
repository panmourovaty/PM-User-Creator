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
                proc1.WindowStyle = ProcessWindowStyle.Minimized;
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
                proc1.WindowStyle = ProcessWindowStyle.Minimized;
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
    }
}