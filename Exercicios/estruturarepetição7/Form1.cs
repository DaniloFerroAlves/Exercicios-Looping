using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estruturarepetição7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btExibir_Click(object sender, EventArgs e)
        {
            for (int i = 4; i < 200; i+= 4)
            {
                lboxResult.Items.Add(i);
            }
        
        
        
        
        }
    
    
    
    
    
    
    
    
    }
}
