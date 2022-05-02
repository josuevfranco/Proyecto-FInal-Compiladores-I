using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

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

        AnalizadorLexico csLexer = new AnalizadorLexico();
        bool load;
        List<string> palabrasReservadas;


        private void Form1_Load(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader(@"..\..\AnalizadorLexico.cs"))
            {
                //tbxCode.Text = sr.ReadToEnd();

                csLexer.AddTokenRule(@"\s+", "ESPACIO", true);
                csLexer.AddTokenRule(@"\b[_a-zA-Z][\w]*\b", "IDENTIFICADOR");
                csLexer.AddTokenRule("\".*?\"", "CADENA");
                csLexer.AddTokenRule(@"'\\.'|'[^\\]'", "CARACTER");
                csLexer.AddTokenRule("//[^\r\n]*", "COMENTARIO1");
                csLexer.AddTokenRule("/[*].*?[*]/", "COMENTARIO2");
                csLexer.AddTokenRule(@"\d*\.?\d+", "NUMERO");
                csLexer.AddTokenRule(@"[\(\)\{\}\[\];,]", "DELIMITADOR");
                csLexer.AddTokenRule(@"[\.=\+\-/*%]", "OPERADOR");
                csLexer.AddTokenRule(@">|<|==|>=|<=|!", "COMPARADOR");

                palabrasReservadas = new List<string>() { "abstract", "as", "async", "await",
                "checked", "const", "continue", "default", "delegate", "base", "break", "case",
                "do", "else", "enum", "event", "explicit", "extern", "false", "finally",
                "fixed", "for", "foreach", "goto", "if", "implicit", "in", "interface",
                "internal", "is", "lock", "new", "null", "operator","catch",
                "out", "override", "params", "private", "protected", "public", "readonly",
                "ref", "return", "sealed", "sizeof", "stackalloc", "static",
                "switch", "this", "throw", "true", "try", "typeof", "namespace",
                "unchecked", "unsafe", "virtual", "void", "while", "float", "int", "long", "object",
                "get", "set", "new", "partial", "yield", "add", "remove", "value", "alias", "ascending",
                "descending", "from", "group", "into", "orderby", "select", "where",
                "join", "equals", "using","bool", "byte", "char", "decimal", "double", "dynamic",
                "sbyte", "short", "string", "uint", "ulong", "ushort", "var", "class", "struct" };

                csLexer.Compile(RegexOptions.Compiled | RegexOptions.Singleline | RegexOptions.ExplicitCapture);

                load = true;
                AnalizeCode();
                tbxCode.Focus();
            }
        }
        private void WindowLoaded(object sender/*, RoutedEventArgs e*/)
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
            tbxCode.Text = "";
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
                tbxCode.Text = streamReader.ReadToEnd();

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
                sw.Write(tbxCode.Text);
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
                sr.Write(tbxCode.Text);
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
            tbxCode.Copy();
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbxCode.Paste();
        }

        private void colorDeFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Nuevo color de fondo 
            ColorDialog cd = new ColorDialog();

            //Si selecciono que sí
            if (cd.ShowDialog() == DialogResult.OK)
            {
                //definir color de fondo al text box
                tbxCode.BackColor = cd.Color;
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
                tbxCode.ForeColor = cd.Color;
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
                tbxCode.Font = cd.Font;
            }
        }

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbxCode.Cut();
        }

        private void seleccionarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbxCode.SelectAll();
        }

        private void copiarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tbxCode.Copy();
        }

        private void cortarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tbxCode.Cut();
        }

        private void pegarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tbxCode.Paste();
        }

        private void seleccionarTodoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            tbxCode.SelectAll();
        }

        private void copiarToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            tbxCode.Copy();
        }

        private void pegarToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            tbxCode.Paste();
        }

        private void cortarToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            tbxCode.Cut();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbxCode.ShowFindDialog();
        }

        private void irAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbxCode.ShowGoToDialog();
        }

        private void reemplazarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbxCode.ShowReplaceDialog();
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void AnalizeCod()
        {
            //dGVLexico.Rows.Clear();

            int n = 0, e = 0;

            DataTable dt = new DataTable();

            dt.Columns.Add("Token");
            dt.Columns.Add("Lexema");
            dt.Columns.Add("Linea");
            dt.Columns.Add("Columna");
            dt.Columns.Add("Indice");

            foreach (var tk in csLexer.GetTokens(tbxCode.Text))
            {
                if (tk.Name == "ERROR") e++;

                dt.Rows.Add(tk.Name, tk.Lexema, tk.Linea, tk.Columna, tk.Index);

                dGVLexico2.DataSource = dt;
                n++;
            }

            //this.Title = string.Format("Analizador Lexico - {0} tokens {1} errores", n, e);
        }
        private void AnalizeCode()
        {
            //dGVLexico.Rows.Clear();

            int n = 0, e = 0;

            DataTable dt = new DataTable();
            DataTable errores = new DataTable();

            errores.Columns.Add("Token");
            errores.Columns.Add("Lexema");
            errores.Columns.Add("Linea");
            errores.Columns.Add("Columna");
            errores.Columns.Add("Indice");

            dt.Columns.Add("Token");
            dt.Columns.Add("Lexema");
            dt.Columns.Add("Linea");
            dt.Columns.Add("Columna");
            dt.Columns.Add("Indice");

            foreach (var tk in csLexer.GetTokens(tbxCode.Text))
            {
                if (tk.Name == "ERROR")
                {
                    e++;
                    errores.Rows.Add(tk.Name, tk.Lexema, tk.Linea, tk.Columna, tk.Index);
                }

                if (tk.Name == "IDENTIFICADOR")
                    if (palabrasReservadas.Contains(tk.Lexema))
                        tk.Name = "RESERVADO";

                dt.Rows.Add(tk.Name, tk.Lexema, tk.Linea, tk.Columna, tk.Index);
               

                dGVLexico.DataSource = dt;
                dGVLexico2.DataSource = errores;
                n++;
            }


            //this.Title = string.Format("Analizador Lexico - {0} tokens {1} errores", n, e);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tbxCode_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            if (load)
                AnalizeCode();


        }
    }
}
