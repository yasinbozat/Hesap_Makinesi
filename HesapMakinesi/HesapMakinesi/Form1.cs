using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
         
        }

        private void btn2_Click(object sender, EventArgs e)
        {

        }

        private void btn3_Click(object sender, EventArgs e)
        {
         
        }

        private void btn4_Click(object sender, EventArgs e)
        {
         
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            
        }

        private void btn6_Click(object sender, EventArgs e)
        {
          
        }

        private void btn7_Click(object sender, EventArgs e)
        {
          
        }

        private void btn8_Click(object sender, EventArgs e)
        {
           
        }

        private void btn9_Click(object sender, EventArgs e)
        {
           
        }

        private void btn0_Click(object sender, EventArgs e)
        {
 
        }

        private void rakamTiklama(object sender, EventArgs e) {

            sayiPaneli.Text += ((Button)sender).Text;
        }
        private void islemTiklama(object sender, EventArgs e) {

            label2.Text = ((Button)sender).Text;
            label3.Text = sayiPaneli.Text;
            sayiPaneli.Text = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnEsit_Click(object sender, EventArgs e)
        {
            switch (label2.Text)
            {
                case "+":
                    sayiPaneli.Text = (Convert.ToDouble(label3.Text) + Convert.ToDouble(sayiPaneli.Text)).ToString();
                    break;
                case "*":
                    sayiPaneli.Text = (Convert.ToDouble(label3.Text) * Convert.ToDouble(sayiPaneli.Text)).ToString();
                    break;
                case "-":
                    sayiPaneli.Text = (Convert.ToDouble(label3.Text)- Convert.ToDouble(sayiPaneli.Text)).ToString();
                    break;
                case "/":
                    sayiPaneli.Text = (Convert.ToDouble(label3.Text) / Convert.ToDouble(sayiPaneli.Text)).ToString();
                    break;
                default:
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sayiPaneli.Text = "";
            label2.Text = "0";
            label3.Text = "0";
        }
    }
}
