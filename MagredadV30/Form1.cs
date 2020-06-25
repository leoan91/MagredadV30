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
        System.IO.Ports.SerialPort Port;
        bool Isclosed = false;
        private string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+"/canales.txt";
        DateTime hora = DateTime.Today;
        private Canal[] canal = new Canal[] { };
        
        public Form1()
        {
            InitializeComponent();
            //Console.WriteLine(hora.ToShortTimeString());
            Port = new System.IO.Ports.SerialPort();
            Port.PortName = "COM21";
            Port.BaudRate = 4800;
            Port.Parity = System.IO.Ports.Parity.Even;
            Port.StopBits = System.IO.Ports.StopBits.Two;
            Port.DataBits = 7;
            Port.ReadTimeout = 10000;
            try
            {

                Port.Open();
            }
            catch
            {
                Console.WriteLine("No se logró abrir el puerto");

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread Hilo = new Thread(escucharPuerto);
            Hilo.Start();
        }
        private void escucharPuerto()
        {
            try
            {
                while (!Isclosed)
                {
                    
                    string cadena = Port.ReadLine();

                    lblMagredad.Invoke(new MethodInvoker(
                        delegate
                        {
                            lblMagredad.Text = cadena;
                        }));

                }

            }
            catch
            {
                Console.WriteLine("buscando datos");

            }
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
                ruta = openFileDialog1.FileName;
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
                ruta = saveFileDialog1.FileName; 
                string contenido = null;
                for (int i = 0; i < dgvDatos.Rows.Count - 1; i++)
                {
                    contenido = string.Format("{0},{1},{2}", dgvDatos.Rows[i].Cells[0].Value, dgvDatos.Rows[i].Cells[1].Value, dgvDatos.Rows[i].Cells[2].Value);
                    writer.WriteLine(contenido);
                }
                writer.Close();
            }
        }
        /*
         Aquí se trabaja en el botón agregar.
        -------------------------------------
        -------------------------------------
        -------------------------------------
        -------------------------------------
         */
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //se revisa si existen datos y si son diferentes. Para escribir el nuevo string.
            StreamWriter writer2 = new StreamWriter(ruta,false);
            string contenido = null;
            for (int i = 0; i < dgvDatos.Rows.Count-1; i++)
            {
                contenido = string.Format("{0},{1},{2}", dgvDatos.Rows[i].Cells[0].Value, dgvDatos.Rows[i].Cells[1].Value, dgvDatos.Rows[i].Cells[2].Value);
                writer2.WriteLine(contenido);
            }
            

            if(txtConsecutivo.TextLength > 0)
            {
                int contador = int.Parse(txtConsecutivo.Text) + 1;
                if (chkAutomatico.Checked)
                {
                    txtConsecutivo.Text = contador.ToString();
                }
            }

            writer2.Close();
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

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Isclosed)
            {
                Port.Close();
            }

        }

        private void dgvDatos_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (!e.Row.IsNewRow)
            {
                DialogResult response = MessageBox.Show("Quieres eliminar estos datos?","Está seguro?", MessageBoxButtons.YesNo) ;

                if (response == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    //saveFileDialog1.FileName;
                    //StreamWriter writer = new StreamWriter(ruta, false);
                    //string contenido = null;
                    //string tempContenido = null;
                    //for (int i = 0; i < dgvDatos.Rows.Count - 1; i++)
                    //{
                    //    contenido = string.Format("{0},{1},{2}", dgvDatos.Rows[i].Cells[0].Value, dgvDatos.Rows[i].Cells[1].Value, dgvDatos.Rows[i].Cells[2].Value);
                    //    //Console.WriteLine(con)
                    //    writer.WriteLine(contenido);
                    //    tempContenido = tempContenido + contenido +"\n";
                    //}
                    //Console.WriteLine(tempContenido);
                    //writer.Close();
                }
                
                    
            }
        }

        private void dgvDatos_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            StreamWriter writer = new StreamWriter(ruta, false);
            string contenido = null;
            string tempContenido = null;
            for (int i = 0; i < dgvDatos.Rows.Count - 1; i++)
            {
                contenido = string.Format("{0},{1},{2}", dgvDatos.Rows[i].Cells[0].Value, dgvDatos.Rows[i].Cells[1].Value, dgvDatos.Rows[i].Cells[2].Value);
                //Console.WriteLine(con)
                writer.WriteLine(contenido);
                tempContenido = tempContenido + contenido + "\n";
            }
            Console.WriteLine(tempContenido);
            writer.Close();
        }
    }
}
