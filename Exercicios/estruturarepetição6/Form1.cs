using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estruturarepetição6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btExibir_Click(object sender, EventArgs e)
        {
            for(int i = 3; i <= 30; i++)
            {
                if (i % 3 == 0)
                {
                    lboxResult.Items.Add(i);
                }
                else if (i % 4 == 0)
                {

                    lboxResult.Items.Add(i);
                }
            }
        
        
        
        }
   
    
    
    
    
    
    
    }
}
