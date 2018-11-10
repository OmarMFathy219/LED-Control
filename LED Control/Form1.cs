using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Runtime.InteropServices;

namespace LED_Control
{
    
   
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        class PortInterop
        {
            [DllImport("inpout32.dll", EntryPoint = "out32")]
            public static extern void Output(int address, int value);

            [DllImport("inpout32.dll", EntryPoint = "Inp32")]
            public static extern void Input(int address);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int output = 0;

            if (cbx1.Checked)
                output += 1;

            if (cbx2.Checked)
                output += 2;

            if (cbx3.Checked)
                output += 4;

            if (cbx4.Checked)
                output += 8;

            if (cbx5.Checked)
                output += 16;

            if (cbx6.Checked)
                output += 32;

            if (cbx7.Checked)
                output += 64;

            if (cbx8.Checked)
                output += 128;

            PortInterop.Output(888,output);
        }
    }
}
