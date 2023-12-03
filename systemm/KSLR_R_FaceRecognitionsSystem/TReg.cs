using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KSLR_R_FaceRecognitionsSystem
{
    public partial class TReg : Form
    {
        public TReg()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if ((int)numericUpDown1.Value < 1)
            {
                numericUpDown1.Value = 1;
            }

            if ((int)numericUpDown1.Value > 3)
            {
                numericUpDown1.Value = 3;
            }
            if ((int)numericUpDown1.Value == 1)
            {
                guna2TextBox4.Visible = false;
                numericUpDown4.Visible = false;
                numericUpDown5.Visible = false;

                guna2TextBox5.Visible = false;
                numericUpDown6.Visible = false;
                numericUpDown7.Visible = false;
            }

            if ((int)numericUpDown1.Value == 2)
            {
                guna2TextBox4.Visible = true;
                numericUpDown4.Visible = true;
                numericUpDown5.Visible = true;

                guna2TextBox5.Visible = false;
                numericUpDown6.Visible = false;
                numericUpDown7.Visible = false;
            }

            if ((int)numericUpDown1.Value == 3)
            {
                guna2TextBox4.Visible = true;
                numericUpDown4.Visible = true;
                numericUpDown5.Visible = true;
                guna2TextBox5.Visible = true;
                numericUpDown6.Visible = true;
                numericUpDown7.Visible = true;
            }

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void TReg_Load(object sender, EventArgs e)
        {
            timer1.Start();
            guna2TextBox4.Visible = false;
            guna2TextBox5.Visible = false;
            numericUpDown4.Visible = false;
            numericUpDown5.Visible = false;
            numericUpDown6.Visible = false;
            numericUpDown7.Visible = false;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if ((int)numericUpDown2.Value > 24)
            {
                numericUpDown2.Value = 1;
            }

            var a = numericUpDown2.Value + ":" + numericUpDown3.Value;
            label1.Text = a + "";
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            if ((int)numericUpDown4.Value > 24)
            {
                numericUpDown4.Value = 1;
            }
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            if ((int)numericUpDown6.Value > 24)
            {
                numericUpDown6.Value = 1;
            }
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            if ((int)numericUpDown3.Value == 60)
            {
                numericUpDown3.Value = 0;
            }
            var a = numericUpDown2.Value + ":" + numericUpDown3.Value;
            label1.Text = a + "";
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            if ((int)numericUpDown5.Value == 60)
            {
                numericUpDown5.Value = 0;
            }
        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {
            if ((int)numericUpDown7.Value == 60)
            {
                numericUpDown7.Value = 0;
            }
        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string inputTime = now.ToString("hh:mm tt");

            // Parse to DateTime
            DateTime dt;
            if (DateTime.TryParseExact(inputTime, "h:mm tt", null,
                                       DateTimeStyles.None, out dt))
            {
                // Get current date
                

                // Subtract 12 hours if PM
                if (dt.Hour < 12)
                {
                    dt = dt.AddHours(12);
                }

                // Calculate time difference    
                TimeSpan diff = dt - now;

                // Add difference to current datetime
                DateTime realTime = now + diff;

                int hours = dt.Hour;

                // Get minutes
                int minutes = dt.Minute;

                // Output real time
                label4.Text = realTime.ToString("HH:mm");
                label5.Text = hours.ToString();
                label6.Text = minutes.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string inputTime = now.ToString("hh:mm tt");

            // Parse to DateTime
            DateTime dt;
            if (DateTime.TryParseExact(inputTime, "hh:mm tt", null,
                                       DateTimeStyles.None, out dt))
            {
                // Get current date


                // Subtract 12 hours if PM
                if (dt.Hour < 12)
                {
                    dt = dt.AddHours(12);
                }

                // Calculate time difference    
                TimeSpan diff = dt - now;

                // Add difference to current datetime
                DateTime realTime = now + diff;

                int hours = dt.Hour;

                // Get minutes
                int minutes = dt.Minute;

                // Output real time
                label4.Text = realTime.ToString("HH:mm");
                label5.Text = hours.ToString();
                label6.Text = minutes.ToString();

                var j = minutes - numericUpDown3.Value;

                if (numericUpDown2.Value < hours)
                {
                    MessageBox.Show("Late");
                }
                else if (numericUpDown2.Value == hours)
                {
                    if (j < 5)
                    {
                        MessageBox.Show("Present");
                    }
                    
                    else
                    {
                        MessageBox.Show("Late");
                    }
                }
               
                else
                {
                    MessageBox.Show("Too Early");
                }
            }
        }
    }
}
