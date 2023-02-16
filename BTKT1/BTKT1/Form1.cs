using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTKT1
{
    
    public partial class Form1 : Form
    {
        Standard sd = new Standard();
        Scientific stf = new Scientific();
        Programmer pgm = new Programmer();
        public Form1()
        {
            InitializeComponent();                                               
        }
      
        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pntHome.Controls.Clear();                  
            pntHome.Controls.Add(sd);
            pntHome.Show();
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pntHome.Controls.Clear();         
            pntHome.Controls.Add(stf);
            pntHome.Show();
           
        }

        private void programmerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pntHome.Controls.Clear();        
            pntHome.Controls.Add(pgm);
            pntHome.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            standardToolStripMenuItem_Click(sender, e);                 
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 48)
            {
                if (sd.txtXuat.Text == "0")
                {
                    sd.txtXuat.Text = "";
                }
                if (sd.biendaubang == true)
                {
                    sd.txtXuat.Text = "";
                    sd.ketqua = 0;
                    sd.lblpheptinh.Text = "";
                }
                if (sd.flag == true)
                {

                    sd.txtXuat.Text += "";
                }
                else
                {

                   sd.txtXuat.Text = "";
                }
                sd.flag = true;
                sd.num = true;
                sd.biendaubang = false;

            }
            //Số 1
            else if (e.KeyChar == 49)
            {
                if (sd.txtXuat.Text == "0")
                {
                    sd.txtXuat.Text = "";
                }
                if (sd.biendaubang == true)
                {
                    sd.txtXuat.Text = "";
                    sd.ketqua = 0;
                    sd.lblpheptinh.Text = "";
                }
                if (sd.flag == true)
                {

                    sd.txtXuat.Text += "";
                }
                else
                {

                    sd.txtXuat.Text = "";
                }
                sd.flag = true;
                sd.num = true;
                sd.biendaubang = false;

            }
            //Số 2
            else if (e.KeyChar == 50)
            {

                if (sd.txtXuat.Text == "0")
                {
                    sd.txtXuat.Text = "";
                }
                if (sd.biendaubang == true)
                {
                    sd.txtXuat.Text = "";
                    sd.ketqua = 0;
                    sd.lblpheptinh.Text = "";
                }
                if (sd.flag == true)
                {

                    sd.txtXuat.Text += "";
                }
                else
                {

                    sd.txtXuat.Text = "";
                }
                sd.flag = true;
                sd.num = true;
                sd.biendaubang = false;

            }
            //Số 3
            else if (e.KeyChar == 51)
            {

                if (sd.txtXuat.Text == "0")
                {
                    sd.txtXuat.Text = "";
                }
                if (sd.biendaubang == true)
                {
                    sd.txtXuat.Text = "";
                    sd.ketqua = 0;
                    sd.lblpheptinh.Text = "";
                }
                if (sd.flag == true)
                {

                    sd.txtXuat.Text += "";
                }
                else
                {

                    sd.txtXuat.Text = "";
                }
                sd.flag = true;
                sd.num = true;
                sd.biendaubang = false;

            }
            //Số 4
            else if (e.KeyChar == 52)
            {

                if (sd.txtXuat.Text == "0")
                {
                    sd.txtXuat.Text = "";
                }
                if (sd.biendaubang == true)
                {
                    sd.txtXuat.Text = "";
                    sd.ketqua = 0;
                    sd.lblpheptinh.Text = "";
                }
                if (sd.flag == true)
                {

                    sd.txtXuat.Text += "";
                }
                else
                {

                    sd.txtXuat.Text = "";
                }
                sd.flag = true;
                sd.num = true;
                sd.biendaubang = false;

            }
            //Số 5
            else if (e.KeyChar == 53)
            {

                if (sd.txtXuat.Text == "0")
                {
                    sd.txtXuat.Text = "";
                }
                if (sd.biendaubang == true)
                {
                    sd.txtXuat.Text = "";
                    sd.ketqua = 0;
                    sd.lblpheptinh.Text = "";
                }
                if (sd.flag == true)
                {

                    sd.txtXuat.Text += "";
                }
                else
                {

                    sd.txtXuat.Text = "";
                }
                sd.flag = true;
                sd.num = true;
                sd.biendaubang = false;

            }
            //Số 6
            else if (e.KeyChar == 54)
            {

                if (sd.txtXuat.Text == "0")
                {
                    sd.txtXuat.Text = "";
                }
                if (sd.biendaubang == true)
                {
                    sd.txtXuat.Text = "";
                    sd.ketqua = 0;
                    sd.lblpheptinh.Text = "";
                }
                if (sd.flag == true)
                {

                    sd.txtXuat.Text += "";
                }
                else
                {

                    sd.txtXuat.Text = "";
                }
                sd.flag = true;
                sd.num = true;
                sd.biendaubang = false;

            }
            //Số 7
            else if (e.KeyChar == 55)
            {

                if (sd.txtXuat.Text == "0")
                {
                    sd.txtXuat.Text = "";
                }
                if (sd.biendaubang == true)
                {
                    sd.txtXuat.Text = "";
                    sd.ketqua = 0;
                    sd.lblpheptinh.Text = "";
                }
                if (sd.flag == true)
                {

                    sd.txtXuat.Text += "";
                }
                else
                {

                    sd.txtXuat.Text = "";
                }
                sd.flag = true;
                sd.num = true;
                sd.biendaubang = false;

            }
            //Số 8
            else if (e.KeyChar == 56)
            {

                if (sd.txtXuat.Text == "0")
                {
                    sd.txtXuat.Text = "";
                }
                if (sd.biendaubang == true)
                {
                    sd.txtXuat.Text = "";
                    sd.ketqua = 0;
                    sd.lblpheptinh.Text = "";
                }
                if (sd.flag == true)
                {

                    sd.txtXuat.Text += "";
                }
                else
                {

                    sd.txtXuat.Text = "";
                }
                sd.flag = true;
                sd.num = true;
                sd.biendaubang = false;

            }
            //Số 9
            else if (e.KeyChar == 57)
            {

                if (sd.txtXuat.Text == "0")
                {
                    sd.txtXuat.Text = "";
                }
                if (sd.biendaubang == true)
                {
                    sd.txtXuat.Text = "";
                    sd.ketqua = 0;
                    sd.lblpheptinh.Text = "";
                }
                if (sd.flag == true)
                {

                    sd.txtXuat.Text += "";
                }
                else
                {

                    sd.txtXuat.Text = "";
                }
                sd.flag = true;
                sd.num = true;
                sd.biendaubang = false;

            }

            if (!char.IsDigit(e.KeyChar) && (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
            //Phep toan cong
            if (e.KeyChar == 43)
            {
                if (sd.num == false)
                {
                    sd.ketqua = Convert.ToInt32(sd.txtXuat.Text);
                }
                else
                {
                    sd.ketqua = sd.ketqua + Convert.ToInt32(sd.txtXuat.Text);

                }
                sd.flag = false;
                sd.Pheptoan = "+";
                sd.lblpheptinh.Text = String.Format("{0}", sd.ketqua) + " " + sd.Pheptoan;
                sd.txtXuat.Text = String.Format("{0}", sd.ketqua);
                sd.num = false;
            }
            //phep toan tru
            else if (e.KeyChar == 45)
            {
                if (sd.num == false)
                {
                    sd.ketqua = Convert.ToInt32(sd.txtXuat.Text);
                }
                else
                {
                    sd.ketqua = sd.ketqua - Convert.ToInt32(sd.txtXuat.Text);

                }
                sd.flag = false;
                sd.Pheptoan = "-";
                sd.lblpheptinh.Text = String.Format("{0}", sd.ketqua) + " " + sd.Pheptoan;
                sd.txtXuat.Text = String.Format("{0}", sd.ketqua);
                sd.num = false;
            }
            //phep toan nhan
            else if (e.KeyChar == 42)
            {
                if (sd.num == false)
                {
                    sd.ketqua = Convert.ToInt32(sd.txtXuat.Text);
                }
                else
                {
                    sd.ketqua = sd.ketqua * Convert.ToInt32(sd.txtXuat.Text);
                }
                sd.flag = false;
                sd.Pheptoan = "*";
                sd.lblpheptinh.Text = String.Format("{0}", sd.ketqua) + " " + sd.Pheptoan;
                sd.txtXuat.Text = String.Format("{0}", sd.ketqua);
                sd.num = false;
            }
            //phep toan chia
            else if (e.KeyChar == 47)
            {
                if (sd.num == false)
                {
                    sd.ketqua = Convert.ToInt32(sd.txtXuat.Text);
                }
                else
                {
                    sd.ketqua = sd.ketqua / Convert.ToInt32(sd.txtXuat.Text);

                }
                sd.flag = false;
                sd.Pheptoan = "/";
                sd.lblpheptinh.Text = String.Format("{0}", sd.ketqua) + " " + sd.Pheptoan;
                sd.txtXuat.Text = String.Format("{0}", sd.ketqua);
                sd.num = false;
            }
            if (e.KeyChar == 13)
            {
                sd.lblpheptinh.Text = "";
                switch (sd.Pheptoan)
                {
                    case "+":
                        sd.lblpheptinh.Text = (sd.ketqua + " " + sd.Pheptoan + Convert.ToInt32(sd.txtXuat.Text)).ToString() + " = ";
                        sd.txtXuat.Text = (sd.ketqua + Convert.ToInt32(sd.txtXuat.Text)).ToString();
                        break;
                    case "-":
                        sd.lblpheptinh.Text = (sd.ketqua + " " + sd.Pheptoan + Convert.ToInt32(sd.txtXuat.Text)).ToString() + " = ";
                        sd.txtXuat.Text = (sd.ketqua - Convert.ToInt32(sd.txtXuat.Text)).ToString();
                        break;
                    case "*":
                        sd.lblpheptinh.Text = (sd.ketqua + " " + sd.Pheptoan + Convert.ToInt32(sd.txtXuat.Text)).ToString() + " = ";
                        sd.txtXuat.Text = (sd.ketqua * Convert.ToInt32(sd.txtXuat.Text)).ToString();
                        break;
                    case "/":
                        sd.lblpheptinh.Text = (sd.ketqua + " " + sd.Pheptoan + Convert.ToInt32(sd.txtXuat.Text)).ToString() + " = ";
                        sd.txtXuat.Text = (sd.ketqua / Convert.ToInt32(sd.txtXuat.Text)).ToString();
                        break;
                }
                sd.num = false;
                sd.biendaubang = true;
            }
        }

       
       
       
    
    }
}
