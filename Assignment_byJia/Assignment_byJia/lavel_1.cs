using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_byJia
{
    public partial class lavel_1 : UserControl
    {
       
        public lavel_1()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string rand_str1,rand_str2;
            int rand_num1,rand_num2;

            Random random = new Random();

            rand_num1 = random.Next(1, 7);
            rand_num2 = random.Next(1, 7);
            rand_str1=rand_num1.ToString();
            rand_str2 = rand_num2.ToString();

            output_1.Text = rand_str1;
            output_2.Text = rand_str2;
            if (rand_num1 > rand_num2)
            {
                result_textbox1.Text = "winner";
                result_textbox2.Text = "loser";
                if (bloodbar2.Value >= 0)
                {
                    if (bloodbar2.Value- ((rand_num1 - rand_num2) * 10) < 0){
                        output_2.Text = "game over";
                    }
                    else
                    {
                        bloodbar2.Value -= ((rand_num1 - rand_num2) * 10);
                    }
                    
                }

            }
            else if (rand_num1 < rand_num2)
            {
                result_textbox1.Text = "loser";
                result_textbox2.Text = "winner";
                if (bloodbar1.Value >= 0)
                {
                    if (bloodbar1.Value - ((rand_num2 - rand_num1) * 10) < 0)
                    {
                        output_1.Text = "over";
                    }
                    else
                    {
                        bloodbar1.Value -= ((rand_num2 - rand_num1) * 10);
                    }
                    
                }
              
            }
            else
            {
                result_textbox1.Text = "平手";
                result_textbox2 .Text= "平手";
                if (bloodbar1 .Value<bloodbar1.Maximum-20)
                {
                    bloodbar1.Value += 20;
                }

                if (bloodbar2.Value < bloodbar2.Maximum-20)
                {
                    bloodbar2.Value += 20;
                }
                
            }

        }

        private void MaskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Output_1_TextChanged(object sender, EventArgs e)
        {
    
        }

        private void Result_textbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {
            
        }

        private void Bloodbar1_Click(object sender, EventArgs e)
        {

        }
    }
}
