using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrix
{
    public partial class Matrix2X2 : Form
    {
        public Matrix2X2()
        {
            InitializeComponent();
        }

        private void btn_det_Click(object sender, EventArgs e)
        {
            TextBox[] array = new TextBox[4];
            array[0] = D1;
            array[1] = D2;
            array[2] = D3;
            array[3] = D4;
            if (array[0].Text != "" && array[1].Text != "" && array[2].Text != "" && array[3].Text != "" )
            {
                Int64 x = ((Int64.Parse(D1.Text) * Int64.Parse(D4.Text)) - (Int64.Parse(D2.Text) * Int64.Parse(D3.Text)));
                D5.Text = x.ToString();
            }
            else
            {
                MessageBox.Show("Please fill all boxes", "Error");
            }

        }

        private void btn_tran_Click(object sender, EventArgs e)
        {
            TextBox[] array = new TextBox[4];
            array[0] = T1;
            array[1] = T2;
            array[2] = T3;
            array[3] = T4;
            if (array[0].Text != "" && array[1].Text != "" && array[2].Text != "" && array[3].Text != "")
            {
                T5.Text = T1.Text.ToString();
                T6.Text = T3.Text.ToString();
                T7.Text = T2.Text.ToString();
                T8.Text = T4.Text.ToString();
            }
            else
            {
                MessageBox.Show("Please fill all boxes", "Error");
            }
        }

        private void btn_adj_Click(object sender, EventArgs e)
        {
            TextBox[] array = new TextBox[4];
            array[0] = Ad1;
            array[1] = Ad2;
            array[2] = Ad3;
            array[3] = Ad4;
            if (array[0].Text != "" && array[1].Text != "" && array[2].Text != "" && array[3].Text != "")
            {
                Ad5.Text = Ad4.Text.ToString();
                Int64 x = Int64.Parse(Ad2.Text);
                Ad6.Text = (-x).ToString();
                Int64 y = Int64.Parse(Ad3.Text);
                Ad7.Text = (-y).ToString();
                Ad8.Text = Ad1.Text.ToString();
            }
            else
            {
                MessageBox.Show("Please fill all boxes", "Error");
            }
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            TextBox[] array = new TextBox[4];
            array[0] = I1;
            array[1] = I2;
            array[2] = I3;
            array[3] = I4;
            if (array[0].Text != "" && array[1].Text != "" && array[2].Text != "" && array[3].Text != "")
            {
                //determination
                Int64 x = ((Int64.Parse(I1.Text) * Int64.Parse(I4.Text)) - (Int64.Parse(I2.Text) * Int64.Parse(I3.Text)));
                I13.Text = x.ToString();
                //adjointing
                I9.Text = I4.Text.ToString();
                Int64 x1 = Int64.Parse(I2.Text);
                I10.Text = (-x1).ToString();
                Int64 y = Int64.Parse(I3.Text);
                I11.Text = (-y).ToString();
                I12.Text = I1.Text.ToString();
                //inversing
                Int64 det = (Int64.Parse(I13.Text));
                Int64 a1 = (Int64.Parse(I9.Text));
                Int64 a2 = (Int64.Parse(I10.Text));
                Int64 a3 = (Int64.Parse(I11.Text));
                Int64 a4 = (Int64.Parse(I12.Text));
                I5.Text = a1.ToString() + "/" + det.ToString();
                I6.Text = a2.ToString() + "/" + det.ToString();
                I7.Text = a3.ToString() + "/" + det.ToString();
                I8.Text = a4.ToString() + "/" + det.ToString();

            }
            else
            {
                MessageBox.Show("Please fill all boxes", "Error");
            }
            
        }

        private void btn_X_Click(object sender, EventArgs e)
        {
            TextBox[] array = new TextBox[8];
            array[0] = M1;
            array[1] = M2;
            array[2] = M3;
            array[3] = M4;
            array[4] = M5;
            array[5] = M6;
            array[6] = M7;
            array[7] = M8;
            if (array[0].Text != "" && array[1].Text != "" && array[2].Text != "" && array[3].Text != "" && array[4].Text != "" && array[5].Text != "" && array[6].Text != "" && array[7].Text != "")
            {
                Int64 x1 = ((Int64.Parse(M1.Text) * Int64.Parse(M5.Text)) + (Int64.Parse(M2.Text) * Int64.Parse(M7.Text)));
                Int64 x2 = ((Int64.Parse(M1.Text) * Int64.Parse(M6.Text)) + (Int64.Parse(M2.Text) * Int64.Parse(M8.Text)));
                Int64 x3 = ((Int64.Parse(M3.Text) * Int64.Parse(M5.Text)) + (Int64.Parse(M4.Text) * Int64.Parse(M7.Text)));
                Int64 x4 = ((Int64.Parse(M3.Text) * Int64.Parse(M6.Text)) + (Int64.Parse(M4.Text) * Int64.Parse(M8.Text)));
                M9.Text = x1.ToString();
                M10.Text = x2.ToString();
                M11.Text = x3.ToString();
                M12.Text = x4.ToString();
            }
            else
            {
                MessageBox.Show("Please fill all boxes", "Error");
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            TextBox[] array = new TextBox[8];
            array[0] = A1;
            array[1] = A2;
            array[2] = A3;
            array[3] = A4;
            array[4] = A5;
            array[5] = A6;
            array[6] = A7;
            array[7] = A8;
            if (array[0].Text != "" && array[1].Text != "" && array[2].Text != "" && array[3].Text != "" && array[4].Text != "" && array[5].Text != "" && array[6].Text != "" && array[7].Text != "")
            {
                Int64 y1 = Int64.Parse(A1.Text) + Int64.Parse(A5.Text);
                Int64 y2 = Int64.Parse(A2.Text) + Int64.Parse(A6.Text);
                Int64 y3 = Int64.Parse(A3.Text) + Int64.Parse(A7.Text);
                Int64 y4 = Int64.Parse(A4.Text) + Int64.Parse(A8.Text);
                A9.Text = y1.ToString();
                A10.Text = y2.ToString();
                A11.Text = y3.ToString();
                A12.Text = y4.ToString();
            }
            else
            {
                MessageBox.Show("Please fill all boxes", "Error");
            }
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            TextBox[] array = new TextBox[8];
            array[0] = S1;
            array[1] = S2;
            array[2] = S3;
            array[3] = S4;
            array[4] = S5;
            array[5] = S6;
            array[6] = S7;
            array[7] = S8;
            if (array[0].Text != "" && array[1].Text != "" && array[2].Text != "" && array[3].Text != "" && array[4].Text != "" && array[5].Text != "" && array[6].Text != "" && array[7].Text != "")
            {
                Int64 y1 = Int64.Parse(S1.Text) - Int64.Parse(S5.Text);
                Int64 y2 = Int64.Parse(S2.Text) - Int64.Parse(S6.Text);
                Int64 y3 = Int64.Parse(S3.Text) - Int64.Parse(S7.Text);
                Int64 y4 = Int64.Parse(S4.Text) - Int64.Parse(S8.Text);
                S9.Text = y1.ToString();
                S10.Text = y2.ToString();
                S11.Text = y3.ToString();
                S12.Text = y4.ToString();
            }
            else
            {
                MessageBox.Show("Please fill all boxes", "Error");
            }
        }
    }
}
