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
    public partial class Matrix3X3 : Form
    {
        public Matrix3X3()
        {
            InitializeComponent();
        }

        private void btn_det_Click(object sender, EventArgs e)
        {
            TextBox[] array = new TextBox[9];
            array[0] = D1;
            array[1] = D2;
            array[2] = D3;
            array[3] = D4;
            array[4] = D5;
            array[5] = D6;
            array[6] = D7;
            array[7] = D8;
            array[8] = D9;
            if (array[0].Text != "" && array[1].Text != "" && array[2].Text != "" && array[3].Text != "" && array[4].Text != "" && array[5].Text != "" && array[6].Text != "" && array[7].Text != "" && array[8].Text != "")
            {
                Int64 a = Int64.Parse(D1.Text);
                Int64 b = Int64.Parse(D2.Text);
                Int64 c = Int64.Parse(D3.Text);
                Int64 d = a * ((Int64.Parse(D5.Text) * Int64.Parse(D9.Text)) - (Int64.Parse(D6.Text) * Int64.Parse(D8.Text))) - b * ((Int64.Parse(D4.Text) * Int64.Parse(D9.Text)) - (Int64.Parse(D7.Text) * Int64.Parse(D6.Text))) + c * ((Int64.Parse(D4.Text) * Int64.Parse(D8.Text)) - (Int64.Parse(D5.Text) * Int64.Parse(D7.Text)));

                D10.Text = d.ToString();
            }
            else
            {
                MessageBox.Show("Please fill all boxes", "Error");
            }
        }

        private void btn_tran_Click(object sender, EventArgs e)
        {
            TextBox[] array = new TextBox[9];
            array[0] = T1;
            array[1] = T2;
            array[2] = T3;
            array[3] = T4;
            array[4] = T5;
            array[5] = T6;
            array[6] = T7;
            array[7] = T8;
            array[8] = T9;
            if (array[0].Text != "" && array[1].Text != "" && array[2].Text != "" && array[3].Text != "" && array[4].Text != "" && array[5].Text != "" && array[6].Text != "" && array[7].Text != "" && array[8].Text != "")
            {
                T10.Text = T1.Text.ToString();
                T13.Text = T2.Text.ToString();
                T16.Text = T3.Text.ToString();

                T11.Text = T4.Text.ToString();
                T14.Text = T5.Text.ToString();
                T17.Text = T6.Text.ToString();

                T12.Text = T7.Text.ToString();
                T15.Text = T8.Text.ToString();
                T18.Text = T9.Text.ToString();
            }
            else
            {
                MessageBox.Show("Please fill all boxes", "Error");
            }
        }

        private void btn_adj_Click(object sender, EventArgs e)
        {
            TextBox[] array = new TextBox[9];
            array[0] = Ad1;
            array[1] = Ad2;
            array[2] = Ad3;
            array[3] = Ad4;
            array[4] = Ad5;
            array[5] = Ad6;
            array[6] = Ad7;
            array[7] = Ad8;
            array[8] = Ad9;
            if (array[0].Text != "" && array[1].Text != "" && array[2].Text != "" && array[3].Text != "" && array[4].Text != "" && array[5].Text != "" && array[6].Text != "" && array[7].Text != "" && array[8].Text != "")
            {
                Int64 a = Int64.Parse(Ad1.Text);
                Int64 b = Int64.Parse(Ad2.Text);
                Int64 c = Int64.Parse(Ad3.Text);
                Int64 d = ((Int64.Parse(Ad5.Text) * Int64.Parse(Ad9.Text)) - (Int64.Parse(Ad6.Text) * Int64.Parse(Ad8.Text)));
                Int64 e0 = -1 * ((Int64.Parse(Ad4.Text) * Int64.Parse(Ad9.Text)) - (Int64.Parse(Ad6.Text) * Int64.Parse(Ad7.Text)));
                Int64 e1 = ((Int64.Parse(Ad4.Text) * Int64.Parse(Ad8.Text)) - (Int64.Parse(Ad5.Text) * Int64.Parse(Ad7.Text)));
                Int64 e2 = -1 * ((Int64.Parse(Ad2.Text) * Int64.Parse(Ad9.Text)) - (Int64.Parse(Ad3.Text) * Int64.Parse(Ad8.Text)));
                Int64 e3 = ((Int64.Parse(Ad1.Text) * Int64.Parse(Ad9.Text)) - (Int64.Parse(Ad3.Text) * Int64.Parse(Ad7.Text)));
                Int64 e4 = -1 * ((Int64.Parse(Ad1.Text) * Int64.Parse(Ad8.Text)) - (Int64.Parse(Ad2.Text) * Int64.Parse(Ad7.Text)));
                Int64 e5 = ((Int64.Parse(Ad2.Text) * Int64.Parse(Ad6.Text)) - (Int64.Parse(Ad3.Text) * Int64.Parse(Ad5.Text)));
                Int64 e6 = -1 * ((Int64.Parse(Ad1.Text) * Int64.Parse(Ad6.Text)) - (Int64.Parse(Ad3.Text) * Int64.Parse(Ad4.Text)));
                Int64 e7 = ((Int64.Parse(Ad1.Text) * Int64.Parse(Ad5.Text)) - (Int64.Parse(Ad2.Text) * Int64.Parse(Ad4.Text)));
                Ad10.Text = d.ToString();
                Ad11.Text = e0.ToString();
                Ad12.Text = e1.ToString();
                Ad13.Text = e2.ToString();
                Ad14.Text = e3.ToString();
                Ad15.Text = e4.ToString();
                Ad16.Text = e5.ToString();
                Ad17.Text = e6.ToString();
                Ad18.Text = e7.ToString();

                Ad10.Text = d.ToString();
                Ad11.Text = e2.ToString();
                Ad12.Text = e5.ToString();

                Ad13.Text = e0.ToString();
                Ad14.Text = e3.ToString();
                Ad15.Text = e6.ToString();

                Ad16.Text = e1.ToString();
                Ad17.Text = e4.ToString();
                Ad18.Text = e7.ToString();
            }
            else
            {
                MessageBox.Show("Please fill all boxes", "Error");
            }
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            TextBox[] array = new TextBox[9];
            array[0] = I1;
            array[1] = I2;
            array[2] = I3;
            array[3] = I4;
            array[4] = I5;
            array[5] = I6;
            array[6] = I7;
            array[7] = I8;
            array[8] = I9;
            if (array[0].Text != "" && array[1].Text != "" && array[2].Text != "" && array[3].Text != "" && array[4].Text != "" && array[5].Text != "" && array[6].Text != "" && array[7].Text != "" && array[8].Text != "")
            {
                Int64 a = Int64.Parse(I1.Text);
                Int64 b = Int64.Parse(I2.Text);
                Int64 c = Int64.Parse(I3.Text);
                Int64 d = ((Int64.Parse(I5.Text) * Int64.Parse(I9.Text)) - (Int64.Parse(I6.Text) * Int64.Parse(I8.Text)));
                Int64 e0 = -1 * ((Int64.Parse(I4.Text) * Int64.Parse(I9.Text)) - (Int64.Parse(I6.Text) * Int64.Parse(I7.Text)));
                Int64 e1 = ((Int64.Parse(I4.Text) * Int64.Parse(I8.Text)) - (Int64.Parse(I5.Text) * Int64.Parse(I7.Text)));
                Int64 e2 = -1 * ((Int64.Parse(I2.Text) * Int64.Parse(I9.Text)) - (Int64.Parse(I3.Text) * Int64.Parse(I8.Text)));
                Int64 e3 = ((Int64.Parse(I1.Text) * Int64.Parse(I9.Text)) - (Int64.Parse(I3.Text) * Int64.Parse(I7.Text)));
                Int64 e4 = -1 * ((Int64.Parse(I1.Text) * Int64.Parse(I8.Text)) - (Int64.Parse(I2.Text) * Int64.Parse(I7.Text)));
                Int64 e5 = ((Int64.Parse(I2.Text) * Int64.Parse(I6.Text)) - (Int64.Parse(I3.Text) * Int64.Parse(I5.Text)));
                Int64 e6 = -1 * ((Int64.Parse(I1.Text) * Int64.Parse(I6.Text)) - (Int64.Parse(I3.Text) * Int64.Parse(I4.Text)));
                Int64 e7 = ((Int64.Parse(I1.Text) * Int64.Parse(I5.Text)) - (Int64.Parse(I2.Text) * Int64.Parse(I4.Text)));
                I19.Text = d.ToString();
                I20.Text = e0.ToString();
                I21.Text = e1.ToString();
                I22.Text = e2.ToString();
                I23.Text = e3.ToString();
                I24.Text = e4.ToString();
                I25.Text = e5.ToString();
                I26.Text = e6.ToString();
                I27.Text = e7.ToString();
                I19.Text = d.ToString();
                I20.Text = e2.ToString();
                I21.Text = e5.ToString();
                I22.Text = e0.ToString();
                I23.Text = e3.ToString();
                I24.Text = e6.ToString();
                I25.Text = e1.ToString();
                I26.Text = e4.ToString();
                I27.Text = e7.ToString();
                Int64 aa = Int64.Parse(I1.Text);
                Int64 bb = Int64.Parse(I2.Text);
                Int64 cc = Int64.Parse(I3.Text);
                Int64 dd = aa * ((Int64.Parse(I5.Text) * Int64.Parse(I9.Text)) - (Int64.Parse(I6.Text) * Int64.Parse(I8.Text))) - bb * ((Int64.Parse(I4.Text) * Int64.Parse(I9.Text)) - (Int64.Parse(I7.Text) * Int64.Parse(I6.Text))) + cc * ((Int64.Parse(I4.Text) * Int64.Parse(I8.Text)) - (Int64.Parse(I5.Text) * Int64.Parse(I7.Text)));
                I28.Text = dd.ToString();
                Int64 a1 = Int64.Parse(I19.Text);
                Int64 a2 = Int64.Parse(I28.Text);
                Int64 a3 = Int64.Parse(I20.Text);
                Int64 a4 = Int64.Parse(I21.Text);
                Int64 a5 = Int64.Parse(I22.Text);
                Int64 a6 = Int64.Parse(I23.Text);
                Int64 a7 = Int64.Parse(I24.Text);
                Int64 a8 = Int64.Parse(I25.Text);
                Int64 a9 = Int64.Parse(I26.Text);
                Int64 a10 = Int64.Parse(I27.Text);
                I10.Text = a1.ToString() + "/" + a2.ToString();
                I11.Text = a3.ToString() + "/" + a2.ToString();
                I12.Text = a4.ToString() + "/" + a2.ToString();
                I13.Text = a5.ToString() + "/" + a2.ToString();
                I14.Text = a6.ToString() + "/" + a2.ToString();
                I15.Text = a7.ToString() + "/" + a2.ToString();
                I16.Text = a8.ToString() + "/" + a2.ToString();
                I17.Text = a9.ToString() + "/" + a2.ToString();
                I18.Text = a10.ToString() + "/" + a2.ToString();
            }
            else
            {
                MessageBox.Show("Please fill all boxes", "Error");
            }
        }

        private void btn_X_Click(object sender, EventArgs e)
        {
            TextBox[] array = new TextBox[18];
            array[0] = M1;
            array[1] = M2;
            array[2] = M3;
            array[3] = M4;
            array[4] = M5;
            array[5] = M6;
            array[6] = M7;
            array[7] = M8;
            array[8] = M9;
            array[9] = M10;
            array[10] = M11;
            array[11] = M12;
            array[12] = M13;
            array[13] = M14;
            array[14] = M15;
            array[15] = M16;
            array[16] = M17;
            array[17] = M18;
            if (array[0].Text != "" && array[1].Text != "" && array[2].Text != "" && array[3].Text != "" && array[4].Text != "" && array[5].Text != "" && array[6].Text != "" && array[7].Text != "" && array[8].Text != "" && array[9].Text != "" && array[10].Text != "" && array[11].Text != "" && array[12].Text != "" && array[13].Text != "" && array[14].Text != "" && array[15].Text != "" && array[16].Text != "" && array[17].Text != "")
            {
                Int64 x1 = ((Int64.Parse(M1.Text) * Int64.Parse(M10.Text)) + (Int64.Parse(M2.Text) * Int64.Parse(M13.Text)) + (Int64.Parse(M3.Text) * Int64.Parse(M16.Text)));
                Int64 x2 = ((Int64.Parse(M1.Text) * Int64.Parse(M11.Text)) + (Int64.Parse(M2.Text) * Int64.Parse(M14.Text)) + (Int64.Parse(M3.Text) * Int64.Parse(M17.Text)));
                Int64 x3 = ((Int64.Parse(M1.Text) * Int64.Parse(M12.Text)) + (Int64.Parse(M2.Text) * Int64.Parse(M15.Text)) + (Int64.Parse(M3.Text) * Int64.Parse(M18.Text)));
                Int64 x4 = ((Int64.Parse(M4.Text) * Int64.Parse(M10.Text)) + (Int64.Parse(M5.Text) * Int64.Parse(M13.Text)) + (Int64.Parse(M6.Text) * Int64.Parse(M16.Text)));
                Int64 x5 = ((Int64.Parse(M4.Text) * Int64.Parse(M11.Text)) + (Int64.Parse(M5.Text) * Int64.Parse(M14.Text)) + (Int64.Parse(M6.Text) * Int64.Parse(M17.Text)));
                Int64 x6 = ((Int64.Parse(M4.Text) * Int64.Parse(M12.Text)) + (Int64.Parse(M5.Text) * Int64.Parse(M15.Text)) + (Int64.Parse(M6.Text) * Int64.Parse(M18.Text)));
                Int64 x7 = ((Int64.Parse(M7.Text) * Int64.Parse(M10.Text)) + (Int64.Parse(M8.Text) * Int64.Parse(M13.Text)) + (Int64.Parse(M9.Text) * Int64.Parse(M16.Text)));
                Int64 x8 = ((Int64.Parse(M7.Text) * Int64.Parse(M11.Text)) + (Int64.Parse(M8.Text) * Int64.Parse(M14.Text)) + (Int64.Parse(M9.Text) * Int64.Parse(M17.Text)));
                Int64 x9 = ((Int64.Parse(M7.Text) * Int64.Parse(M12.Text)) + (Int64.Parse(M8.Text) * Int64.Parse(M15.Text)) + (Int64.Parse(M9.Text) * Int64.Parse(M18.Text)));
                M19.Text = x1.ToString();
                M20.Text = x2.ToString();
                M21.Text = x3.ToString();
                M22.Text = x4.ToString();
                M23.Text = x5.ToString();
                M24.Text = x6.ToString();
                M25.Text = x7.ToString();
                M26.Text = x8.ToString();
                M27.Text = x9.ToString();
            }
            else
            {
                MessageBox.Show("Please fill all boxes", "Error");
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            TextBox[] array = new TextBox[18];
            array[0] = A1;
            array[1] = A2;
            array[2] = A3;
            array[3] = A4;
            array[4] = A5;
            array[5] = A6;
            array[6] = A7;
            array[7] = A8;
            array[8] = A9;
            array[9] = A10;
            array[10] = A11;
            array[11] = A12;
            array[12] = A13;
            array[13] = A14;
            array[14] = A15;
            array[15] = A16;
            array[16] = A17;
            array[17] = A18;
            if (array[0].Text != "" && array[1].Text != "" && array[2].Text != "" && array[3].Text != "" && array[4].Text != "" && array[5].Text != "" && array[6].Text != "" && array[7].Text != "" && array[8].Text != "" && array[9].Text != "" && array[10].Text != "" && array[11].Text != "" && array[12].Text != "" && array[13].Text != "" && array[14].Text != "" && array[15].Text != "" && array[16].Text != "" && array[17].Text != "")
            {
                Int64 y1 = Int64.Parse(A1.Text) + Int64.Parse(A10.Text);
                Int64 y2 = Int64.Parse(A2.Text) + Int64.Parse(A11.Text);
                Int64 y3 = Int64.Parse(A3.Text) + Int64.Parse(A12.Text);
                Int64 y4 = Int64.Parse(A4.Text) + Int64.Parse(A13.Text);
                Int64 y5 = Int64.Parse(A5.Text) + Int64.Parse(A14.Text);
                Int64 y6 = Int64.Parse(A6.Text) + Int64.Parse(A15.Text);
                Int64 y7 = Int64.Parse(A7.Text) + Int64.Parse(A16.Text);
                Int64 y8 = Int64.Parse(A8.Text) + Int64.Parse(A17.Text);
                Int64 y9 = Int64.Parse(A9.Text) + Int64.Parse(A18.Text);
                A19.Text = y1.ToString();
                A20.Text = y2.ToString();
                A21.Text = y3.ToString();
                A22.Text = y4.ToString();
                A23.Text = y5.ToString();
                A24.Text = y6.ToString();
                A25.Text = y7.ToString();
                A26.Text = y8.ToString();
                A27.Text = y9.ToString();

            }
            else
            {
                MessageBox.Show("Please fill all boxes", "Error");
            }
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            TextBox[] array = new TextBox[18];
            array[0] = S1;
            array[1] = S2;
            array[2] = S3;
            array[3] = S4;
            array[4] = S5;
            array[5] = S6;
            array[6] = S7;
            array[7] = S8;
            array[8] = S9;
            array[9] = S10;
            array[10] = S11;
            array[11] = S12;
            array[12] = S13;
            array[13] = S14;
            array[14] = S15;
            array[15] = S16;
            array[16] = S17;
            array[17] = S18;
            if (array[0].Text != "" && array[1].Text != "" && array[2].Text != "" && array[3].Text != "" && array[4].Text != "" && array[5].Text != "" && array[6].Text != "" && array[7].Text != "" && array[8].Text != "" && array[9].Text != "" && array[10].Text != "" && array[11].Text != "" && array[12].Text != "" && array[13].Text != "" && array[14].Text != "" && array[15].Text != "" && array[16].Text != "" && array[17].Text != "")
            {
                Int64 y1 = Int64.Parse(S1.Text) - Int64.Parse(S10.Text);
                Int64 y2 = Int64.Parse(S2.Text) - Int64.Parse(S11.Text);
                Int64 y3 = Int64.Parse(S3.Text) - Int64.Parse(S12.Text);
                Int64 y4 = Int64.Parse(S4.Text) - Int64.Parse(S13.Text);
                Int64 y5 = Int64.Parse(S5.Text) - Int64.Parse(S14.Text);
                Int64 y6 = Int64.Parse(S6.Text) - Int64.Parse(S15.Text);
                Int64 y7 = Int64.Parse(S7.Text) - Int64.Parse(S16.Text);
                Int64 y8 = Int64.Parse(S8.Text) - Int64.Parse(S17.Text);
                Int64 y9 = Int64.Parse(S9.Text) - Int64.Parse(S18.Text);
                S19.Text = y1.ToString();
                S20.Text = y2.ToString();
                S21.Text = y3.ToString();
                S22.Text = y4.ToString();
                S23.Text = y5.ToString();
                S24.Text = y6.ToString();
                S25.Text = y7.ToString();
                S26.Text = y8.ToString();
                S27.Text = y9.ToString();
            }
            else
            {
                MessageBox.Show("Please fill all boxes", "Error");
            }
        }
    }
}