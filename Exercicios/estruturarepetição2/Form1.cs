using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace somatoriamedia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {

            int soma = 0;
            
            for (int i = 1; i <= 500; i+= 2)
            {
                
                soma += i;
                lboxResultado.Items.Clear();
                lboxResultado.Items.Add(soma);
                lboxResultado.Items.Add(soma / 250);


              
           
            }




        }

        private void button1_Click(object sender, EventArgs e)
        {
            int soma = 0;
            
            for (int p = 0; p <= 500; p += 2)
            {
                soma += p;
                lboxResultado.Items.Clear();
                lboxResultado.Items.Add(soma);
                lboxResultado.Items.Add(soma / 250);


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int soma = 0;

            for (int i = 1; i <= 500; i++)
            {
                soma += i;
                lboxResultado.Items.Clear();
                lboxResultado.Items.Add(soma);
                lboxResultado.Items.Add(soma / 500);



            }
        }
    }
}
