using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using clases;

namespace clases
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            clase_escribir cl = new clase_escribir();
            string temp=cl.funcion_info_escribir();
            MessageBox.Show(temp);
        }
    }
}
