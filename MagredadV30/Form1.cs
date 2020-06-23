using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagredadV30
{
    public partial class Form1 : Form
    {
        DateTime hora = DateTime.Today;
        
        public Form1()
        {
            InitializeComponent();
            //Console.WriteLine(hora.ToShortTimeString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //para obtener el registro de hora en la computadora
        private void tmrHora_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToShortTimeString();
            
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                //openFileDialog1.FileName;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog()== DialogResult.OK)
            {
                //saveFileDialog1.FileName;
            }
        }
    }
}
