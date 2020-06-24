using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace MagredadV30
{
    public partial class Form1 : Form
    {
        private string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+"/canales.txt";
        //private string ruta = AppDomain.CurrentDomain.BaseDirectory+ "/canales.txt";
        DateTime hora = DateTime.Today;
        private Canal[] canal = new Canal[] { };
        
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
            lblhora.Text = DateTime.Now.ToLongTimeString();
            
        }
 

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                //openFileDialog1.FileName;
                StreamReader reader = new StreamReader(openFileDialog1.FileName);
                string contenido = null;
                string []contenidoTemp = null;
                contenido = reader.ReadLine();
                dgvDatos.Rows.Clear();
                while (contenido != null)
                {
                    contenidoTemp = contenido.Split(',');
                    dgvDatos.Rows.Add(contenidoTemp);
                    contenido = reader.ReadLine();
                }
                reader.Close();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog()== DialogResult.OK)
            {
                //saveFileDialog1.FileName;
                StreamWriter writer = new StreamWriter(saveFileDialog1.FileName, false);
                string contenido = null;
                for (int i = 0; i < dgvDatos.Rows.Count - 1; i++)
                {
                    contenido = string.Format("{0},{1},{2}", dgvDatos.Rows[i].Cells[0].Value, dgvDatos.Rows[i].Cells[1].Value, dgvDatos.Rows[i].Cells[2].Value);
                    writer.WriteLine(contenido);
                }
                writer.Close();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter(ruta,false);
            string contenido = null;
            for (int i = 0; i < dgvDatos.Rows.Count-1; i++)
            {
                contenido = string.Format("{0},{1},{2}", dgvDatos.Rows[i].Cells[0].Value, dgvDatos.Rows[i].Cells[1].Value, dgvDatos.Rows[i].Cells[2].Value);
                writer.WriteLine(contenido);
            }
            writer.Close();
            int contador = int.Parse(txtConsecutivo.Text) + 1;
            if (chkAutomatico.Checked)
            {
                txtConsecutivo.Text = contador.ToString();
            }
        }

        private void chkAutomatico_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAutomatico.Checked)
            {
                txtConsecutivo.Enabled = false;
            }
            else
            {
                txtConsecutivo.Enabled = true;
            }
            
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvDatos.ReadOnly = true;
        }

        private void dgvDatos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvDatos.ReadOnly = true;
        }

        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvDatos.ReadOnly = true;
        }

        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvDatos.ReadOnly = true;
        }

        private void txtConsecutivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if(!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números");
            }
        }
    }
}
