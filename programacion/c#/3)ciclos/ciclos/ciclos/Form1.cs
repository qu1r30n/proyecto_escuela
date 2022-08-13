using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ciclos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_iniciar_repeticiones_Click(object sender, EventArgs e)
        {
            double cantidat = Convert.ToDouble(txt_num_repeticiones.Text);
            for (int i = 1; i <= cantidat; i++)
            {
                MessageBox.Show("" + i);
            }
        }
    }
}
