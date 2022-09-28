using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;


namespace ProyectoFinalCompiladoresI_ISCUAA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        T_SimbolosM Tsimbolos = new T_SimbolosM();
        AnalizadorLexico csLexer = new AnalizadorLexico();
        bool load;
        List<string> palabrasReservadas;
        public DataTable table { get; set; }

 
        private void Form1_Load(object sender, EventArgs e)
        {


            table = new DataTable();
            table.Columns.Add("Indice");
            table.Columns.Add("Token");
            table.Columns.Add("Linea");
            table.Columns.Add("Lexema");
            table.Columns.Add("Regla");
            table.Columns.Add("Descripcion");
          
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
                csLexer.AddTokenRule(@"[\(\)\{\}\[\]]", "DELIMITADOR");
                csLexer.AddTokenRule(@"[%]", "OPERADOR");
                csLexer.AddTokenRule(@">", "MAYORQUE");
                csLexer.AddTokenRule("==[^*]", "COMPARACION");
                csLexer.AddTokenRule("!=[^*]", "DIFERENTEDE");
                csLexer.AddTokenRule(@">=[^*]", "MAYOROIGUALQUE");
                csLexer.AddTokenRule(@"<", "MENORQUE");
                csLexer.AddTokenRule(@",", "COMA");
                csLexer.AddTokenRule(@"[+]", "SUMA");
                csLexer.AddTokenRule(@"[-]", "RESTA");
                csLexer.AddTokenRule(@"[*]", "MULTIPLICACION");
                csLexer.AddTokenRule(@"[/]", "DIVISION");
                csLexer.AddTokenRule(@"[.]", "PUNTO");
                csLexer.AddTokenRule(@"[']", "COMILLA");
                csLexer.AddTokenRule(@"[;]", "PUNTOYCOMA");
                csLexer.AddTokenRule(@"[{^}]", "EXPONENCIAL");
                csLexer.AddTokenRule(@"[{=}]", "ASIGNACION");


                palabrasReservadas = new List<string>() { "abstract", "as", "async", "await",
                "checked", "const", "continue", "default", "delegate", "base", "break", "case",
                "do", "else", "enum", "event", "explicit", "extern", "false", "finally","read",
                "fixed", "for", "foreach", "goto", "if", "implicit", "in", "interface","until",
                "internal", "is", "lock", "new", "null", "operator","catch","program",
                "out", "override", "params", "private", "protected", "public", "readonly",
                "ref", "return", "sealed", "sizeof", "stackalloc", "static","write","not","and", "or",
                "switch", "this", "throw", "true", "try", "typeof", "namespace","fi",
                "unchecked", "unsafe", "virtual", "void", "while", "float", "int", "long", "object",
                "get", "set", "new", "partial", "yield", "add", "remove", "value", "alias", "ascending",
                "descending", "from", "group", "into", "orderby", "select", "where","program",
                "join", "equals", "using","bool", "byte", "char", "decimal", "double", "dynamic",
                "sbyte", "short", "string", "uint", "ulong", "ushort", "var", "class", "struct", "write" };

                csLexer.Compile(RegexOptions.Compiled | RegexOptions.Singleline | RegexOptions.ExplicitCapture);

                load = true;
                Tsimbolos.Tokens();
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
            ofd.Filter = "Text File|*.txt|C#|*.cs|*.cpp|";

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
            errores.Columns.Add("Tipo de Error");

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
                    errores.Rows.Add(tk.Name, tk.Lexema, tk.Linea, tk.Columna, tk.Index,"Error Lexico");
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

        public void ImprimirToken(string token, int i, string linea)
        {

            Tsimbolos.datos.Clear();
            List<Complete> datos = new List<Complete>();
            datos = Tsimbolos.BuscarToken(token, i, linea);
            foreach (var x in datos)
            {
                Console.Write(x);
                table.Rows.Add(x.IdTk, x.Token, x.Linea, x.Tipo, x.Regla1, x.Descripcion1);
            }

            dGVSintactico.DataSource = table;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }


        private void tbxCode_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            if (load)
            {
                AnalizeCode();
                AnalizadorSintactico();
            }
        }

        public void AnalizadorSintactico()
        {
            table = new DataTable();
            table.Columns.Add("Indice");
            table.Columns.Add("Token");
            table.Columns.Add("Linea");
            table.Columns.Add("Lexema");
            table.Columns.Add("Regla");
            table.Columns.Add("Descripcion");
            string[] linea = new string[tbxCode.LinesCount];
            if (tbxCode.Text != null)
            {
                for (int i = 0; i < linea.Length; i++)
                {

                    linea[i] = tbxCode.GetLineText(i);
                    if (linea[i] != null)
                    {
                        if (Regex.IsMatch(linea[i], @"^int\s+\w+(\s+=\s+\d)*;(|\s)$"))
                        {
                            ImprimirToken("int", i, linea[i].ToString());
                        }

                        else if (Regex.IsMatch(linea[i], @"^int\s+\w+(\s+=\s+\d)*(|\s)$"))
                        {
                            ImprimirToken("error", i, linea[i].ToString());
                        }

                        else if (Regex.IsMatch(linea[i], @"^int\s+\w+(\s+=)$"))
                        {
                            ImprimirToken("error", i, linea[i].ToString());
                        }

                        else if (Regex.IsMatch(linea[i], @"^int\s+\w$"))
                        {
                            ImprimirToken("error", i, linea[i].ToString());
                        }

                        else if (Regex.IsMatch(linea[i], @"^float\s+\w+(\s+=\s+\d+\.+\d)*;(|\s)$"))
                        {
                            ImprimirToken("float", i, linea[i].ToString());
                        }

                        else if (Regex.IsMatch(linea[i], @"^float\s+\w+(\s+=\s+\d+\.+\d)*(|\s)$"))
                        {
                            ImprimirToken("error", i, linea[i].ToString());
                        }


                        else if (Regex.IsMatch(linea[i], @"^float\s+\w+(\s+=\s+\d)$"))
                        {
                            ImprimirToken("error", i, linea[i].ToString());
                        }

                        else if (Regex.IsMatch(linea[i], @"^float\s+\w+(\s+=\s)$"))
                        {
                            ImprimirToken("error", i, linea[i].ToString());
                        }

                        else if (Regex.IsMatch(linea[i], @"^float\s+\w+(\s+=)$"))
                        {
                            ImprimirToken("error", i, linea[i].ToString());
                        }

                        else if (Regex.IsMatch(linea[i], @"^string\s+[a-z](1,15)(\s+=\s+[a-z](1,15)')*;$"))
                        {
                            ImprimirToken("string", i, linea[i].ToString());
                        }
                        
                        else if (Regex.IsMatch(linea[i], @"^bool\s+\w+(\s+=\s+(true|false))*;$"))
                        {
                            ImprimirToken("bool", i, linea[i].ToString());
                        }

                        else if (Regex.IsMatch(linea[i], @"^bool\s+\w+(\s+=\s+(true|false))*$"))
                        {
                            ImprimirToken("error", i, linea[i].ToString());
                        }

                        else if (Regex.IsMatch(linea[i], @"^bool\s+\w+(\s+=\s)*;$"))
                        {
                            ImprimirToken("error", i, linea[i].ToString());
                        }

                        else if (Regex.IsMatch(linea[i], @"^bool\s+\w+(\s)*;$"))
                        {
                            ImprimirToken("error", i, linea[i].ToString());
                        }


                        else if (Regex.IsMatch(linea[i], @"//[^\r\n]*"))
                        {
                            ImprimirToken("//", i, linea[i].ToString());
                        }
                        
                        /*if (Regex.IsMatch(linea[i], @"[a-z]\s+=+\s[a-z]|(\w)*\s\+\s(\w)*|\d(0,32000)*;+[\r\n]$"))
                        {
                            ImprimirToken("=", i, linea[i].ToString());
                        }*/
                       
                        else if (Regex.IsMatch(linea[i], @"^{$"))
                        {
                            ImprimirToken("{", i, linea[i].ToString());
                        }

                        else if (Regex.IsMatch(linea[i], @"^{{{{|{{$"))
                        {
                            ImprimirToken("error", i, linea[i].ToString());
                        }

                        else if (Regex.IsMatch(linea[i], @"^}$"))
                        {
                            ImprimirToken("}", i, linea[i].ToString());
                        }

                        else if (Regex.IsMatch(linea[i], @"^}}}|}}$"))
                        {
                            ImprimirToken("error", i, linea[i].ToString());
                        }

                        else if (Regex.IsMatch(linea[i], @"if\(\w+\s(<|>|<=|>=|==|!=)\s+\w+\)\s\{$"))
                        {
                            ImprimirToken("if", i, linea[i].ToString());
                            ImprimirToken("{", i, linea[i].ToString());
                            ImprimirToken("(", i, linea[i].ToString());
                            ImprimirToken(")", i, linea[i].ToString());
                        }

                        else if (Regex.IsMatch(linea[i], @"if\(\w+\s+\w+\)\s\{$"))
                        {
                            ImprimirToken("error", i, linea[i].ToString());
                        }

                        else if (Regex.IsMatch(linea[i], @"if\(\w+\s(<|>|<=|>=|==|!=)\s+\w+\)$"))
                        {
                            ImprimirToken("error", i, linea[i].ToString());
                        }

                        else if (Regex.IsMatch(linea[i], @"if\(\w+\s+\w+\)$"))
                        {
                            ImprimirToken("error", i, linea[i].ToString());
                        }

                        else if (Regex.IsMatch(linea[i], @"else\s*\{$"))
                        {
                            ImprimirToken("else", i, linea[i].ToString());
                            ImprimirToken("{", i, linea[i].ToString());
                        }

                        else if (Regex.IsMatch(linea[i], @"else\s$"))
                        {
                            ImprimirToken("error", i, linea[i].ToString());
                        }

                        else if (Regex.IsMatch(linea[i], @"write\s+.*?\;$"))
                        {
                            ImprimirToken("write", i, linea[i].ToString());
                        }
                        
                        else if (Regex.IsMatch(linea[i], @"write\s+.*?$"))
                        {
                            ImprimirToken("error", i, linea[i].ToString());
                        }

                        else if (Regex.IsMatch(linea[i], @"write\s$"))
                        {
                            ImprimirToken("error", i, linea[i].ToString());
                        }

                        else if (Regex.IsMatch(linea[i], @"program\s\{$"))
                        {
                            ImprimirToken("program", i, linea[i].ToString());
                            ImprimirToken("{", i, linea[i].ToString());
                        }

                        else if (Regex.IsMatch(linea[i], @"program\s$"))
                        {
                            ImprimirToken("error", i, linea[i].ToString());
                        }

                        else if (Regex.IsMatch(linea[i], @"func\s+\w+\s\(+(\s?|\w)+\)\{$"))
                        {
                            ImprimirToken("func", i, linea[i].ToString());
                            ImprimirToken("(", i, linea[i].ToString());
                            ImprimirToken(")", i, linea[i].ToString());
                        }

                        else if (Regex.IsMatch(linea[i], @"read\s+.*?\;$"))
                        {
                            ImprimirToken("read", i, linea[i].ToString());
                        }

                        else if (Regex.IsMatch(linea[i], @"read\s+.*?$"))
                        {
                            ImprimirToken("error", i, linea[i].ToString());
                        }

                        else if (Regex.IsMatch(linea[i], @"read\s$"))
                        {
                            ImprimirToken("error", i, linea[i].ToString());
                        }

                        else if (Regex.IsMatch(linea[i], @"^int\s+\w+,+\w(\s+=\s+\d)*;(|\s)$"))
                        {
                            ImprimirToken("int", i, linea[i].ToString());
                        }

                        else if (Regex.IsMatch(linea[i], @"if\(\w+\s(<|>|<=|>=|==|!=)\s+\w+\)\s+then+\s+\{+"))
                        {
                            ImprimirToken("if", i, linea[i].ToString());
                            ImprimirToken("{", i, linea[i].ToString());
                            ImprimirToken("(", i, linea[i].ToString());
                            ImprimirToken(")", i, linea[i].ToString());
                            ImprimirToken("then", i, linea[i].ToString());
                        }


                        else if (Regex.IsMatch(linea[i], @"fi"))
                        {
                            ImprimirToken("fi", i, linea[i].ToString());
                        }

                        else if (Regex.IsMatch(linea[i], @"while\(\w+\s(<|>|<=|>=|==|!=)\s+\w+\)\s\{$"))
                        {
                            ImprimirToken("while", i, linea[i].ToString());
                            ImprimirToken("{", i, linea[i].ToString());
                            ImprimirToken("(", i, linea[i].ToString());
                            ImprimirToken(")", i, linea[i].ToString());
                        }


                        else if (Regex.IsMatch(linea[i], @"while\(\w+\s(<|>|<=|>=|==|!=)\s+\w+\)\s$"))
                        {
                            ImprimirToken("error", i, linea[i].ToString());
                        }



                        else if (Regex.IsMatch(linea[i], @"while\(\w+\s+\w+\)\s$"))
                        {
                            ImprimirToken("error", i, linea[i].ToString());
                        }

                        else if (Regex.IsMatch(linea[i], @"while\(\w+\s+\w+\)\s\{$"))
                        {
                            ImprimirToken("error", i, linea[i].ToString());
                        }

                        else if (Regex.IsMatch(linea[i], @"do\{$"))
                        {
                            ImprimirToken("do", i, linea[i].ToString());
                            ImprimirToken("{", i, linea[i].ToString());
                        }

                        else if (Regex.IsMatch(linea[i], @"do$"))
                        {
                            ImprimirToken("error", i, linea[i].ToString());
                        }

                        else if (Regex.IsMatch(linea[i], @"until\(\w+\s(<|>|<=|>=|==|!=)\s+\w+\)+\;$"))
                        {
                            ImprimirToken("until", i, linea[i].ToString());
                            ImprimirToken("{", i, linea[i].ToString());
                            ImprimirToken("(", i, linea[i].ToString());
                            ImprimirToken(")", i, linea[i].ToString());
                        }


                    }
                }
            }
            else
            {
                //TokensData.Items.Clear();
            }
        }

        private void tbxCode_Load(object sender, EventArgs e)
        {

        }

        private void dGVLexico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
