using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estruturarepetição3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {

            int fatorial = 1;

            for (int i = 1; i <= 10; i ++)
            {


                fatorial *= i;
                

                if (i % 2 == 0)
                {
                    

                }
                else
                {

                    lboxResultado.Items.Add(fatorial);
                }
 
                    

                    



                



            }



        }







    }
}
