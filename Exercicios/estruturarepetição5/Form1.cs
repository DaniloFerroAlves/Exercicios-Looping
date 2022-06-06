using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estruturarepetição5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btExibir_Click(object sender, EventArgs e)
        {

            int soma = 0;
            
            
            for(int i = 1; i <= 1000;i++)
            {

                
                
                
                if (i % 3 == 0)
                {
                    
                }
                else
                {
                    
                    soma += i;
                    if (i == 1000)
                    {
                        


                        MessageBox.Show(" Essa é a soma de 1 a 1000 pulando os multiplos de 3 =" + soma.ToString(), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        continue;
                    }

                       
                    
                }

                
                
                

            }
        }
    }
}
