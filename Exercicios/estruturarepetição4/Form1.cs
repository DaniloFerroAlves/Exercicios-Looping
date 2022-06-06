using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estruturarepetição4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btMostrar_Click(object sender, EventArgs e)
        {
            for (int i = 3; i < 101; i+= 3)
            {
                lboxResultado.Items.Add(i);
            }
        
        
        
        
        
        }
    }
}
