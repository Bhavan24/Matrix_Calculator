using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Matrix
{
    public partial class Main : Form
    {
        Thread th;
        public Main()
        {
            InitializeComponent();            
        }
        private void opennewform1(object obj)
        {
            Application.Run(new Matrix3X3());
        }        

        private void opennewform2(object obj)
        {
            Application.Run(new Matrix2X2());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform1);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform2);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
