using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Para archivos (read, write)
using System.IO;


namespace ProyectoFinalCompiladoresI_ISCUAA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Limpia el texto contenido en la caja de texto. 
            fastColoredTextBox1.Text = "";
        }

        //Método para abrir el archivo
        private void openDlg() { 
        
            //Crea un nuevo abrir archivo de diálogo 
            OpenFileDialog ofd = new OpenFileDialog();

            //Filtros para archivos a abrit
            ofd.Filter = "Text File|*.txt|C#|*.cs";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //Abrir archiv
                StreamReader streamReader = new StreamReader(ofd.FileName);

                //Asignar texto al espacio
                fastColoredTextBox1.Text = streamReader.ReadToEnd();

                //Cerrar archiv
                streamReader.Close();


                //Path del archivo abierto
                this.Text = ofd.FileName;
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openDlg();  
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter(this.Text);
                sw.Write(fastColoredTextBox1.Text);
                sw.Close();
            }catch
            {
                openDlg();
            }

        }

        //Guardar archivos 
        private void SaveDlg()
        {
            //Nuevo archivo a guardar
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Text File|*.txt|C#|*.cs";

            if (sf.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sr = new StreamWriter(sf.FileName);
                sr.Write(fastColoredTextBox1.Text);
                sr.Close();
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveDlg();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cierra la aplicación
            Application.Exit(); 
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Copy();
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Paste();
        }

        private void colorDeFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Nuevo color de fondo 
            ColorDialog cd = new ColorDialog();

            //Si selecciono que sí
            if (cd.ShowDialog() == DialogResult.OK)
            {
                //definir color de fondo al text box
                fastColoredTextBox1.BackColor = cd.Color;
            }
        }

        private void textoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Nuevo color de texto
            ColorDialog cd = new ColorDialog();

            //Si selecciono que sí
            if (cd.ShowDialog() == DialogResult.OK)
            {
                //definir color de texto al text box
                fastColoredTextBox1.ForeColor = cd.Color;
            }
        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Nuevo estilo de fuente de texto
            FontDialog cd = new FontDialog();

            //Si selecciono que sí
            if (cd.ShowDialog() == DialogResult.OK)
            {
                //definir color de texto al text box
                fastColoredTextBox1.Font = cd.Font;
            }
        }

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Cut();
        }

        private void seleccionarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.SelectAll();
        }

        private void copiarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Copy();
        }

        private void cortarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Cut();
        }

        private void pegarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Paste();
        }

        private void seleccionarTodoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            fastColoredTextBox1.SelectAll();
        }

        private void copiarToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            fastColoredTextBox1.Copy();
        }

        private void pegarToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            fastColoredTextBox1.Paste();
        }

        private void cortarToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            fastColoredTextBox1.Cut();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.ShowFindDialog();
        }

        private void irAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.ShowGoToDialog();
        }

        private void reemplazarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.ShowReplaceDialog();
        }
    }
}
