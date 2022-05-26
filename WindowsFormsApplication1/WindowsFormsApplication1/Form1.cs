using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private char _islem;
        private bool _temizle;
        int _ilksayi;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_temizle)
            {
                label1.Text = "";
                _temizle = false;
            } 
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_temizle)
            {
                label1.Text = "";
                _temizle = false;
            } 
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
              if (_temizle)
            {
                label1.Text = "";
                _temizle = false;
            } 
              if (label1.Text == "0") label1.Text = "";
            label1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_temizle)
            {
                label1.Text = "";
                _temizle = false;
            } 
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (_temizle)
            {
                label1.Text = "";
                _temizle = false;
            } 
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (_temizle)
            {
                label1.Text = "";
                _temizle = false;
            } 
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (_temizle)
            {
                label1.Text = "";
                _temizle = false;
            } 
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "7"; 

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (_temizle)
            {
                label1.Text = "";
                _temizle = false;
            } 
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (_temizle)
            {
                label1.Text = "";
                _temizle = false;
            } 
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "9";
        }

        private void rc_Click(object sender, EventArgs e)
        {
            label1.Text="";
            
        }

        private void rartı_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _temizle = true;
            _ilksayi = Convert.ToInt32(label1.Text);

        }

        private void eksi_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _temizle = true;
            _ilksayi = Convert.ToInt32(label1.Text);
        }

        private void carpı_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _temizle = true;
            _ilksayi = Convert.ToInt32(label1.Text);
        }

        private void bolu_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _temizle = true;
            _ilksayi = Convert.ToInt32(label1.Text);
        }

        private void esittir_Click(object sender, EventArgs e)
        {
            int ikincisayi = Convert.ToInt32(label1.Text);
            int sonuc;
            switch (_islem)
            {
                case '+':
                sonuc = _ilksayi+ikincisayi;
                 break;
                case '-':
                sonuc = _ilksayi-ikincisayi;

                 break;
                case '*':
                sonuc = _ilksayi*ikincisayi;
                 break;
                case '/':
                sonuc = _ilksayi/ikincisayi;
                 break;
                default:
                    sonuc = 0;
                    break;
            }
            label1.Text = Convert.ToString(sonuc);
        }

        private void r0_Click(object sender, EventArgs e)
        {
            if (_temizle)
            {
                label1.Text = "";
                _temizle = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "0";
        }

        
    }
}
