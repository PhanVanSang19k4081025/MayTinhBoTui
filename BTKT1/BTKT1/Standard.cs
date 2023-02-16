using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTKT1
{
    public partial class Standard : UserControl
    {
        public double ketqua ;     
        public bool flag = true;
        public bool num = false;
        public string Pheptoan;
        public bool biendaubang = false;
        public Standard()
        {
            InitializeComponent();
        }

        private void but0_Click(object sender, EventArgs e)
        {
            if (this.txtXuat.Text == "0")
            {
                return;
            }
            
            if (this.flag == true)
            {
                this.txtXuat.Text += "0";
            }
            else
            {
                this.txtXuat.Text = "0";
            }
            this.flag = true;
            this.num = true;
        }

        private void but1_Click(object sender, EventArgs e)
        {
            if (this.txtXuat.Text == "0")
            {
                this.txtXuat.Text = "";
            }
            if (biendaubang == true)
            {
                txtXuat.Text = "";
                ketqua = 0;
                lblpheptinh.Text = "";
            }
            if (this.flag == true)
            {
               
                this.txtXuat.Text += "1";
            }
            else
            {
                this.txtXuat.Text = "1";
            }
            this.flag = true;
            this.num = true;
            this.biendaubang = false;
        }

        private void but2_Click(object sender, EventArgs e)
        {
            if (this.txtXuat.Text == "0")
            {
                this.txtXuat.Text = "";
            }
            if (biendaubang == true)
            {
                txtXuat.Text = "";
                ketqua = 0;
                lblpheptinh.Text = "";
            }     
            if (this.flag == true)
            {
                this.txtXuat.Text += "2";
            }
            else
            {
                this.txtXuat.Text = "2";
            }
            this.flag = true;
            this.num = true;
            this.biendaubang = false;
        }

        private void but3_Click(object sender, EventArgs e)
        {
            if (this.txtXuat.Text == "0")
            {
                this.txtXuat.Text = "";
            }
            if (biendaubang == true)
            {
                txtXuat.Text = "";
                ketqua = 0;
                lblpheptinh.Text = "";
            }
            if (this.flag == true)
            {
                this.txtXuat.Text += "3";
            }
            else
            {
                this.txtXuat.Text = "3";
            }
            this.flag = true;
            this.num = true;
            this.biendaubang = false;
        }

        private void but4_Click(object sender, EventArgs e)
        {
            if (this.txtXuat.Text == "0")
            {
                this.txtXuat.Text = "";
            }
            if (biendaubang == true)
            {
                txtXuat.Text = "";
                ketqua = 0;
                lblpheptinh.Text = "";
            }
            if (this.flag == true)
            {
                this.txtXuat.Text += "4";
            }
            else
            {
                this.txtXuat.Text = "4";
            }
            this.flag = true;
            this.num = true;
            this.biendaubang = false;
        }

        private void but5_Click(object sender, EventArgs e)
        {
            if (this.txtXuat.Text == "0")
            {
                this.txtXuat.Text = "";
            }
            if (biendaubang == true)
            {
                txtXuat.Text = "";
                ketqua = 0;
                lblpheptinh.Text = "";
            }
            if (this.flag == true)
            {
                this.txtXuat.Text += "5";
            }
            else
            {
                this.txtXuat.Text = "5";
            }
            this.flag = true;
            this.num = true;
            this.biendaubang = false;
        }

        private void but6_Click(object sender, EventArgs e)
        {
            if (this.txtXuat.Text == "0")
            {
                this.txtXuat.Text = "";
            }
            if (biendaubang == true)
            {
                txtXuat.Text = "";
                ketqua = 0;
                lblpheptinh.Text = "";
            }
            if (this.flag == true)
            {
                this.txtXuat.Text += "6";
            }
            else
            {
                this.txtXuat.Text = "6";
            }
            this.flag = true;
            this.num = true;
            this.biendaubang = false;
        }

        private void but7_Click(object sender, EventArgs e)
        {
            if (this.txtXuat.Text == "0")
            {
                this.txtXuat.Text = "";
            }
            if (biendaubang == true)
            {
                txtXuat.Text = "";
                ketqua = 0;
                lblpheptinh.Text = "";
            }
            if (this.flag == true)
            {
                this.txtXuat.Text += "7";
            }
            else
            {
                this.txtXuat.Text = "7";
            }
            this.flag = true;
            this.num = true;
            this.biendaubang = false;
        }

        private void but8_Click(object sender, EventArgs e)
        {
            if (this.txtXuat.Text == "0")
            {
                this.txtXuat.Text = "";
            }
            if (biendaubang == true)
            {
                txtXuat.Text = "";
                ketqua = 0;
                lblpheptinh.Text = "";
            }
            if (this.flag == true)
            {
                this.txtXuat.Text += "8";
            }
            else
            {
                this.txtXuat.Text = "8";
            }
            this.flag = true;
            this.num = true;
            this.biendaubang = false;
        }

        private void but9_Click(object sender, EventArgs e)
        {
            if (this.txtXuat.Text == "0")
            {
                this.txtXuat.Text = "";
            }
            if (biendaubang == true)
            {
                txtXuat.Text = "";
                ketqua = 0;
                lblpheptinh.Text = "";
            }
            if (this.flag == true)
            {
                this.txtXuat.Text += "9";
            }
            else
            {
                this.txtXuat.Text = "9";
            }
            this.flag = true;
            this.num = true;
            this.biendaubang = false;
        }

        private void butcong_Click(object sender, EventArgs e)
        {             
            if (num == false)
            {
                 
                this.ketqua = Convert.ToInt32(this.txtXuat.Text);             
            }
            else
            {
                this.ketqua = this.ketqua + Convert.ToInt32(this.txtXuat.Text);

            }         
            this.flag = false;          
            Pheptoan = "+";
            lblpheptinh.Text = String.Format("{0}", this.ketqua) + " " + Pheptoan;
            this.txtXuat.Text = String.Format("{0}", this.ketqua);           
            this.num = false;          
        }     
        private void buttru_Click(object sender, EventArgs e)
        {          
            if (num == false)
            {
                this.ketqua = Convert.ToInt32(this.txtXuat.Text);
              
            }
            else
            {
                this.ketqua = this.ketqua - Convert.ToInt32(this.txtXuat.Text);            
            }        
            this.flag = false;
            Pheptoan = "-";
            lblpheptinh.Text = String.Format("{0}", this.ketqua) + " " + Pheptoan;
            txtXuat.Text = String.Format("{0}", this.ketqua); 
            //txtXuat.Text = (ketqua - Convert.ToInt32(txtXuat.Text)).ToString();
            this.num = false;
            
        }

        private void butnhan_Click(object sender, EventArgs e)
        {

            if (num == false)
            {

                this.ketqua = Convert.ToInt32(this.txtXuat.Text);
            }
            else
            {
                this.ketqua = this.ketqua * Convert.ToInt32(this.txtXuat.Text);
            }
            this.flag = false;
            //this.txtXuat.Text = String.Format("{0}", this.ketqua);
            Pheptoan = "*";
            lblpheptinh.Text = String.Format("{0}", this.ketqua) + " " + Pheptoan;
            txtXuat.Text = String.Format("{0}", this.ketqua);
            this.num = false;        
        }

        private void butchia_Click(object sender, EventArgs e)
        {
            if (num == false)
            {

                this.ketqua = Convert.ToInt32(this.txtXuat.Text);
            }
            else
            {
                this.ketqua = ketqua / Convert.ToInt32(this.txtXuat.Text);
            }
            this.flag = false;
            Pheptoan = "/";
            //this.txtXuat.Text = String.Format("{0}", this.ketqua);
            lblpheptinh.Text = String.Format("{0}", this.ketqua) + " " + Pheptoan;
            txtXuat.Text = String.Format("{0}", this.ketqua);
            this.num = false;
        }

        private void butbang_Click(object sender, EventArgs e)
        {
            lblpheptinh.Text = "";
            switch (Pheptoan)
            {
                case "+":
                    lblpheptinh.Text = (ketqua + " " + Pheptoan + Convert.ToInt32(txtXuat.Text)).ToString() + " = ";
                    txtXuat.Text = (ketqua + Convert.ToInt32(txtXuat.Text)).ToString();                  
                    break;
                case "-":
                    lblpheptinh.Text = (ketqua + " " + Pheptoan + Convert.ToInt32(txtXuat.Text)).ToString() + " = ";
                    txtXuat.Text = (ketqua - Convert.ToInt32(txtXuat.Text)).ToString();
                    break;
                case "*":
                    lblpheptinh.Text = (ketqua + " " + Pheptoan + Convert.ToInt32(txtXuat.Text)).ToString() + " = ";
                    txtXuat.Text = (ketqua * Convert.ToInt32(txtXuat.Text)).ToString();
                    break;
                case "/":
                    lblpheptinh.Text = (ketqua + " " + Pheptoan + Convert.ToInt32(txtXuat.Text)).ToString() + " = ";
                    txtXuat.Text = (ketqua / Convert.ToInt32(txtXuat.Text)).ToString();
                    break;
            }
            this.num = false;
            this.biendaubang = true;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtXuat.Text = "0";
            ketqua = 0;
            lblpheptinh.Text = "";
        }

        private void btnDEL_Click(object sender, EventArgs e)
        {
            if (txtXuat.Text.Length > 1)
            {
                txtXuat.Text = txtXuat.Text.Remove(txtXuat.Text.Length - 1, 1);
            }
            else
                txtXuat.Text = "0";
            //if (txtXuat.Text == " ")
            //{
            //    txtXuat.Text = "0";
            //}
        }

        private void txtXuat_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Số 0
            //if (e.KeyChar == 48)
            //{
            //    if (this.txtXuat.Text == "0")
            //    {
            //        this.txtXuat.Text = "";
            //    }
            //    if (this.flag == true)
            //    {

            //        txtXuat.Text += "";
            //    }
            //    else
            //    {

            //        txtXuat.Text = "";
            //    }
            //    this.flag = true;

            //}
            ////Số 1
            //else if (e.KeyChar == 49)
            //{
            //    if (this.txtXuat.Text == "0")
            //    {
            //        this.txtXuat.Text = "";
            //    }
            //    if (this.flag == true)
            //    {

            //        txtXuat.Text += "";
            //    }
            //    else
            //    {

            //        txtXuat.Text = "";
            //    }
            //    this.flag = true;

            //}
            ////Số 2
            //else if (e.KeyChar == 50)
            //{

            //    if (this.txtXuat.Text == "0")
            //    {
            //        this.txtXuat.Text = "";
            //    }
            //    if (this.flag == true)
            //    {

            //        txtXuat.Text += "";
            //    }
            //    else
            //    {

            //        txtXuat.Text = "";
            //    }
            //    this.flag = true;

            //}
            ////Số 3
            //else if (e.KeyChar == 51)
            //{

            //    if (this.txtXuat.Text == "0")
            //    {
            //        this.txtXuat.Text = "";
            //    }
            //    if (this.flag == true)
            //    {

            //        txtXuat.Text += "";
            //    }
            //    else
            //    {

            //        txtXuat.Text = "";
            //    }
            //    this.flag = true;

            //}
            ////Số 4
            //else if (e.KeyChar == 52)
            //{

            //    if (this.txtXuat.Text == "0")
            //    {
            //        this.txtXuat.Text = "";
            //    }
            //    if (this.flag == true)
            //    {

            //        txtXuat.Text += "";
            //    }
            //    else
            //    {

            //        txtXuat.Text = "";
            //    }
            //    this.flag = true;

            //}
            ////Số 5
            //else if (e.KeyChar == 53)
            //{

            //    if (this.txtXuat.Text == "0")
            //    {
            //        this.txtXuat.Text = "";
            //    }
            //    if (this.flag == true)
            //    {

            //        txtXuat.Text += "";
            //    }
            //    else
            //    {

            //        txtXuat.Text = "";
            //    }
            //    this.flag = true;

            //}
            ////Số 6
            //else if (e.KeyChar == 54)
            //{

            //    if (this.txtXuat.Text == "0")
            //    {
            //        this.txtXuat.Text = "";
            //    }
            //    if (this.flag == true)
            //    {

            //        txtXuat.Text += "";
            //    }
            //    else
            //    {

            //        txtXuat.Text = "";
            //    }
            //    this.flag = true;

            //}
            ////Số 7
            //else if (e.KeyChar == 55)
            //{

            //    if (this.txtXuat.Text == "0")
            //    {
            //        this.txtXuat.Text = "";
            //    }
            //    if (this.flag == true)
            //    {

            //        txtXuat.Text += "";
            //    }
            //    else
            //    {

            //        txtXuat.Text = "";
            //    }
            //    this.flag = true;

            //}
            ////Số 8
            //else if (e.KeyChar == 56)
            //{

            //    if (this.txtXuat.Text == "0")
            //    {
            //        this.txtXuat.Text = "";
            //    }
            //    if (this.flag == true)
            //    {

            //        txtXuat.Text += "";
            //    }
            //    else
            //    {

            //        txtXuat.Text = "";
            //    }
            //    this.flag = true;

            //}
            ////Số 9
            //else if (e.KeyChar == 57)
            //{

            //    if (this.txtXuat.Text == "0")
            //    {
            //        this.txtXuat.Text = "";
            //    }
            //    if (this.flag == true)
            //    {

            //        txtXuat.Text += "";
            //    }
            //    else
            //    {

            //        txtXuat.Text = "";
            //    }
            //    this.flag = true;

            //}

            //if (!char.IsDigit(e.KeyChar) && (int)e.KeyChar != 8)
            //{
            //    e.Handled = true;
            //}
            ////Phep toan cong
            //if (e.KeyChar == 43)
            //{
            //    if (num == false)
            //    {
            //        this.ketqua = Convert.ToInt32(this.txtXuat.Text);
            //    }
            //    else
            //    {
            //        this.ketqua = this.ketqua + Convert.ToInt32(this.txtXuat.Text);

            //    }
            //    this.flag = false;
            //    Pheptoan = "+";
            //    lblpheptinh.Text = String.Format("{0}", this.ketqua) + " " + Pheptoan;
            //    this.txtXuat.Text = String.Format("{0}", this.ketqua);
            //    this.num = true;
            //}
            ////phep toan tru
            //else if (e.KeyChar == 45)
            //{
            //    if (num == false)
            //    {
            //        this.ketqua = Convert.ToInt32(this.txtXuat.Text);
            //    }
            //    else
            //    {
            //        this.ketqua = this.ketqua - Convert.ToInt32(this.txtXuat.Text);

            //    }
            //    this.flag = false;
            //    Pheptoan = "-";
            //    lblpheptinh.Text = String.Format("{0}", this.ketqua) + " " + Pheptoan;
            //    this.txtXuat.Text = String.Format("{0}", this.ketqua);
            //    this.num = true;
            //}
            ////phep toan nhan
            //else if (e.KeyChar == 42)
            //{
            //    if (num == false)
            //    {
            //        this.ketqua = Convert.ToInt32(this.txtXuat.Text);
            //    }
            //    else
            //    {
            //        this.ketqua = this.ketqua * Convert.ToInt32(this.txtXuat.Text);
            //    }
            //    this.flag = false;
            //    Pheptoan = "*";
            //    lblpheptinh.Text = String.Format("{0}", this.ketqua) + " " + Pheptoan;
            //    this.txtXuat.Text = String.Format("{0}", this.ketqua);
            //    this.num = true;
            //}
            ////phep toan chia
            //else if (e.KeyChar == 47)
            //{
            //    if (num == false)
            //    {
            //        this.ketqua = Convert.ToInt32(this.txtXuat.Text);
            //    }
            //    else
            //    {
            //        this.ketqua = this.ketqua / Convert.ToInt32(this.txtXuat.Text);

            //    }
            //    this.flag = false;
            //    Pheptoan = "/";
            //    lblpheptinh.Text = String.Format("{0}", this.ketqua) + " " + Pheptoan;
            //    this.txtXuat.Text = String.Format("{0}", this.ketqua);
            //    this.num = true;
            //}
            //if (e.KeyChar == 13)
            //{
            //    lblpheptinh.Text = "";
            //    switch (Pheptoan)
            //    {
            //        case "+":
            //            lblpheptinh.Text = (ketqua + " " + Pheptoan + Convert.ToInt32(txtXuat.Text)).ToString() + " = ";
            //            txtXuat.Text = (ketqua + Convert.ToInt32(txtXuat.Text)).ToString();
            //            break;
            //        case "-":
            //            lblpheptinh.Text = (ketqua + " " + Pheptoan + Convert.ToInt32(txtXuat.Text)).ToString() + " = ";
            //            txtXuat.Text = (ketqua - Convert.ToInt32(txtXuat.Text)).ToString();
            //            break;
            //        case "*":
            //            lblpheptinh.Text = (ketqua + " " + Pheptoan + Convert.ToInt32(txtXuat.Text)).ToString() + " = ";
            //            txtXuat.Text = (ketqua * Convert.ToInt32(txtXuat.Text)).ToString();
            //            break;
            //        case "/":
            //            lblpheptinh.Text = (ketqua + " " + Pheptoan + Convert.ToInt32(txtXuat.Text)).ToString() + " = ";
            //            txtXuat.Text = (ketqua / Convert.ToInt32(txtXuat.Text)).ToString();
            //            break;
            //    }
            //    this.num = false;
            //}

        }

        private void txtXuat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                txtXuat.Text = "0";
                ketqua = 0;
                lblpheptinh.Text = "";
            }
            if (e.KeyCode == Keys.Back)
            {
                if (txtXuat.Text.Length > 1)
                {
                    txtXuat.Text = txtXuat.Text.Remove(txtXuat.Text.Length - 1, 1);
                }
                else
                    txtXuat.Text = "0";
            }
        }

       

      

       
     
    }

      
}
