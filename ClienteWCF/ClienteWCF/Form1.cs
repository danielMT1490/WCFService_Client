using ClienteWCF.ReferenciaWeb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteWCF
{
    public partial class Form1 : Form
    {
        private int Opction { get; set; }
        private Service1Client svc;
        private string Protocol { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void SumaOption_Click(object sender, EventArgs e)
        {
            SumaOption.Checked = true;
            RestaOption.Checked = false;
            MultiplicacionOption.Checked = false;
            DivisionOption.Checked = false;
            this.Opction = 1;
        }

        private void RestaOption_Click(object sender, EventArgs e)
        {
            SumaOption.Checked = false;
            RestaOption.Checked = true;
            MultiplicacionOption.Checked = false;
            DivisionOption.Checked = false;
            this.Opction = 2;
        }

        private void MultiplicacionOption_Click(object sender, EventArgs e)
        {
            SumaOption.Checked = false;
            RestaOption.Checked = false;
            MultiplicacionOption.Checked = true;
            DivisionOption.Checked = false;
            this.Opction = 3;
        }

        private void DivisionOption_Click(object sender, EventArgs e)
        {
            SumaOption.Checked = false;
            RestaOption.Checked = false;
            MultiplicacionOption.Checked = false;
            DivisionOption.Checked = true;
            this.Opction = 4;
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
          

            switch (this.Opction)
            {
                case 1:
                    ResultadoText.Text= this.svc.Suma(Convert.ToInt32(Num1Text.Text),Convert.ToInt32(Num2Text.Text)).ToString();
                    break;
                case 2:
                    ResultadoText.Text = this.svc.Resta(Convert.ToInt32(Num1Text.Text), Convert.ToInt32(Num2Text.Text)).ToString();
                    break;
                case 3:
                    ResultadoText.Text = this.svc.Multiplicacion(Convert.ToInt32(Num1Text.Text), Convert.ToInt32(Num2Text.Text)).ToString();
                    break;
                case 4:
                    ResultadoText.Text = this.svc.Division(Convert.ToInt32(Num1Text.Text), Convert.ToInt32(Num2Text.Text)).ToString();
                    break;

                default:
                    break;
            }
        }

        private void HTTPOption_Click(object sender, EventArgs e)
        {

            this.svc = svc = new Service1Client("Http");
            HTTPOption.Checked = true;
            TCPOption.Checked = false;
        }

        private void TCPOption_Click(object sender, EventArgs e)
        {
            this.svc = svc = new Service1Client("Tcp");
            HTTPOption.Checked = false;
            TCPOption.Checked = true;
        }
    }
}
