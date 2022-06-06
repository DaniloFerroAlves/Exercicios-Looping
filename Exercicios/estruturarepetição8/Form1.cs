using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estruturarepetição8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btExibir_Click(object sender, EventArgs e)
        {

            int valor = 3;
            
            
            for (int i = 0; i <= 15; i++)
            {

                lboxResult.Items.Add(Math.Pow(valor, i));

                

           
                










            }
        
        
        
        }
    
    
    
    
    
    
    
    
    }
}
