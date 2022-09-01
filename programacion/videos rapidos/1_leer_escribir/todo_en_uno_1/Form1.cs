using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace todo_en_uno_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_procesar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("nombre: "+txt_nombre.Text + "\nedad: "+txt_edad.Text+"\npais: "+txt_pais.Text+"\nsueldo: "+txt_sueldo.Text);
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {

        }
    }
}
