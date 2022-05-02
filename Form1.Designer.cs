namespace ProyectoFinalCompiladoresI_ISCUAA
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cortarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pegarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.irAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reemplazarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDeFondoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compilarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.correrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compilarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbxCode = new FastColoredTextBoxNS.FastColoredTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.seleccionarTodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pegarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cortarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dGVLexico = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.errores = new System.Windows.Forms.TabPage();
            this.dGVLexico2 = new System.Windows.Forms.DataGridView();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbxCode)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVLexico)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.errores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVLexico2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código a Compilar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.formatoToolStripMenuItem,
            this.compilarToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1398, 30);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.guardarComoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            this.archivoToolStripMenuItem.Click += new System.EventHandler(this.archivoToolStripMenuItem_Click);
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevoToolStripMenuItem.Image")));
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("abrirToolStripMenuItem.Image")));
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("guardarToolStripMenuItem.Image")));
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("guardarComoToolStripMenuItem.Image")));
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.guardarComoToolStripMenuItem.Text = "Guardar como...";
            this.guardarComoToolStripMenuItem.Click += new System.EventHandler(this.guardarComoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cortarToolStripMenuItem,
            this.copiarToolStripMenuItem,
            this.pegarToolStripMenuItem,
            this.toolStripMenuItem1,
            this.buscarToolStripMenuItem,
            this.irAToolStripMenuItem,
            this.reemplazarToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // cortarToolStripMenuItem
            // 
            this.cortarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cortarToolStripMenuItem.Image")));
            this.cortarToolStripMenuItem.Name = "cortarToolStripMenuItem";
            this.cortarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cortarToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.cortarToolStripMenuItem.Text = "Cortar";
            this.cortarToolStripMenuItem.Click += new System.EventHandler(this.cortarToolStripMenuItem_Click);
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copiarToolStripMenuItem.Image")));
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.copiarToolStripMenuItem.Text = "Copiar";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // pegarToolStripMenuItem
            // 
            this.pegarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pegarToolStripMenuItem.Image")));
            this.pegarToolStripMenuItem.Name = "pegarToolStripMenuItem";
            this.pegarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pegarToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.pegarToolStripMenuItem.Text = "Pegar";
            this.pegarToolStripMenuItem.Click += new System.EventHandler(this.pegarToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(184, 6);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("buscarToolStripMenuItem.Image")));
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.buscarToolStripMenuItem.Text = "Buscar";
            this.buscarToolStripMenuItem.Click += new System.EventHandler(this.buscarToolStripMenuItem_Click);
            // 
            // irAToolStripMenuItem
            // 
            this.irAToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("irAToolStripMenuItem.Image")));
            this.irAToolStripMenuItem.Name = "irAToolStripMenuItem";
            this.irAToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.irAToolStripMenuItem.Text = "Ir a ";
            this.irAToolStripMenuItem.Click += new System.EventHandler(this.irAToolStripMenuItem_Click);
            // 
            // reemplazarToolStripMenuItem
            // 
            this.reemplazarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reemplazarToolStripMenuItem.Image")));
            this.reemplazarToolStripMenuItem.Name = "reemplazarToolStripMenuItem";
            this.reemplazarToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.reemplazarToolStripMenuItem.Text = "Reemplazar";
            this.reemplazarToolStripMenuItem.Click += new System.EventHandler(this.reemplazarToolStripMenuItem_Click);
            // 
            // formatoToolStripMenuItem
            // 
            this.formatoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorDeFondoToolStripMenuItem,
            this.textoToolStripMenuItem,
            this.fuenteToolStripMenuItem});
            this.formatoToolStripMenuItem.Name = "formatoToolStripMenuItem";
            this.formatoToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.formatoToolStripMenuItem.Text = "Formato";
            // 
            // colorDeFondoToolStripMenuItem
            // 
            this.colorDeFondoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("colorDeFondoToolStripMenuItem.Image")));
            this.colorDeFondoToolStripMenuItem.Name = "colorDeFondoToolStripMenuItem";
            this.colorDeFondoToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.colorDeFondoToolStripMenuItem.Text = "Color de fondo";
            this.colorDeFondoToolStripMenuItem.Click += new System.EventHandler(this.colorDeFondoToolStripMenuItem_Click);
            // 
            // textoToolStripMenuItem
            // 
            this.textoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("textoToolStripMenuItem.Image")));
            this.textoToolStripMenuItem.Name = "textoToolStripMenuItem";
            this.textoToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.textoToolStripMenuItem.Text = "Texto";
            this.textoToolStripMenuItem.Click += new System.EventHandler(this.textoToolStripMenuItem_Click);
            // 
            // fuenteToolStripMenuItem
            // 
            this.fuenteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fuenteToolStripMenuItem.Image")));
            this.fuenteToolStripMenuItem.Name = "fuenteToolStripMenuItem";
            this.fuenteToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.fuenteToolStripMenuItem.Text = "Fuente";
            this.fuenteToolStripMenuItem.Click += new System.EventHandler(this.fuenteToolStripMenuItem_Click);
            // 
            // compilarToolStripMenuItem
            // 
            this.compilarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.correrToolStripMenuItem,
            this.compilarToolStripMenuItem1});
            this.compilarToolStripMenuItem.Name = "compilarToolStripMenuItem";
            this.compilarToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.compilarToolStripMenuItem.Text = "Compilar";
            // 
            // correrToolStripMenuItem
            // 
            this.correrToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("correrToolStripMenuItem.Image")));
            this.correrToolStripMenuItem.Name = "correrToolStripMenuItem";
            this.correrToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.correrToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.correrToolStripMenuItem.Text = "Correr";
            // 
            // compilarToolStripMenuItem1
            // 
            this.compilarToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("compilarToolStripMenuItem1.Image")));
            this.compilarToolStripMenuItem1.Name = "compilarToolStripMenuItem1";
            this.compilarToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.J)));
            this.compilarToolStripMenuItem1.Size = new System.Drawing.Size(200, 26);
            this.compilarToolStripMenuItem1.Text = "Compilar";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // tbxCode
            // 
            this.tbxCode.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.tbxCode.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n^\\s*(case|default)\\s*[^:]" +
    "*(?<range>:)\\s*(?<range>[^;]+);\r\n";
            this.tbxCode.AutoScrollMinSize = new System.Drawing.Size(0, 18);
            this.tbxCode.BackBrush = null;
            this.tbxCode.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.tbxCode.CharHeight = 18;
            this.tbxCode.CharWidth = 10;
            this.tbxCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxCode.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.tbxCode.IsReplaceMode = false;
            this.tbxCode.Language = FastColoredTextBoxNS.Language.CSharp;
            this.tbxCode.LeftBracket = '(';
            this.tbxCode.LeftBracket2 = '{';
            this.tbxCode.LineNumberColor = System.Drawing.Color.Navy;
            this.tbxCode.Location = new System.Drawing.Point(26, 98);
            this.tbxCode.Name = "tbxCode";
            this.tbxCode.Paddings = new System.Windows.Forms.Padding(0);
            this.tbxCode.RightBracket = ')';
            this.tbxCode.RightBracket2 = '}';
            this.tbxCode.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.tbxCode.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("tbxCode.ServiceColors")));
            this.tbxCode.Size = new System.Drawing.Size(851, 434);
            this.tbxCode.TabIndex = 3;
            this.tbxCode.WordWrap = true;
            this.tbxCode.Zoom = 100;
            this.tbxCode.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.tbxCode_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seleccionarTodoToolStripMenuItem,
            this.copiarToolStripMenuItem1,
            this.pegarToolStripMenuItem1,
            this.cortarToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(191, 100);
            // 
            // seleccionarTodoToolStripMenuItem
            // 
            this.seleccionarTodoToolStripMenuItem.Name = "seleccionarTodoToolStripMenuItem";
            this.seleccionarTodoToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.seleccionarTodoToolStripMenuItem.Text = "Seleccionar todo";
            this.seleccionarTodoToolStripMenuItem.Click += new System.EventHandler(this.seleccionarTodoToolStripMenuItem_Click_1);
            // 
            // copiarToolStripMenuItem1
            // 
            this.copiarToolStripMenuItem1.Name = "copiarToolStripMenuItem1";
            this.copiarToolStripMenuItem1.Size = new System.Drawing.Size(190, 24);
            this.copiarToolStripMenuItem1.Text = "Copiar";
            this.copiarToolStripMenuItem1.Click += new System.EventHandler(this.copiarToolStripMenuItem1_Click_1);
            // 
            // pegarToolStripMenuItem1
            // 
            this.pegarToolStripMenuItem1.Name = "pegarToolStripMenuItem1";
            this.pegarToolStripMenuItem1.Size = new System.Drawing.Size(190, 24);
            this.pegarToolStripMenuItem1.Text = "Pegar";
            this.pegarToolStripMenuItem1.Click += new System.EventHandler(this.pegarToolStripMenuItem1_Click_1);
            // 
            // cortarToolStripMenuItem1
            // 
            this.cortarToolStripMenuItem1.Name = "cortarToolStripMenuItem1";
            this.cortarToolStripMenuItem1.Size = new System.Drawing.Size(190, 24);
            this.cortarToolStripMenuItem1.Text = "Cortar";
            this.cortarToolStripMenuItem1.Click += new System.EventHandler(this.cortarToolStripMenuItem1_Click_1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(918, 98);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(442, 434);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dGVLexico);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(434, 405);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Léxico";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dGVLexico
            // 
            this.dGVLexico.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dGVLexico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVLexico.Location = new System.Drawing.Point(3, 0);
            this.dGVLexico.Name = "dGVLexico";
            this.dGVLexico.RowHeadersWidth = 51;
            this.dGVLexico.RowTemplate.Height = 24;
            this.dGVLexico.Size = new System.Drawing.Size(425, 399);
            this.dGVLexico.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(434, 405);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sintáctico";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(434, 405);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Semántico";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(434, 405);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Código Intermedio";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.errores);
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Location = new System.Drawing.Point(26, 559);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1334, 147);
            this.tabControl2.TabIndex = 6;
            // 
            // errores
            // 
            this.errores.Controls.Add(this.dGVLexico2);
            this.errores.Location = new System.Drawing.Point(4, 25);
            this.errores.Name = "errores";
            this.errores.Padding = new System.Windows.Forms.Padding(3);
            this.errores.Size = new System.Drawing.Size(1326, 118);
            this.errores.TabIndex = 0;
            this.errores.Text = "Errores";
            this.errores.UseVisualStyleBackColor = true;
            // 
            // dGVLexico2
            // 
            this.dGVLexico2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dGVLexico2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVLexico2.Location = new System.Drawing.Point(0, 0);
            this.dGVLexico2.Name = "dGVLexico2";
            this.dGVLexico2.RowHeadersWidth = 51;
            this.dGVLexico2.RowTemplate.Height = 24;
            this.dGVLexico2.Size = new System.Drawing.Size(1368, 195);
            this.dGVLexico2.TabIndex = 0;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 25);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(1326, 118);
            this.tabPage7.TabIndex = 1;
            this.tabPage7.Text = "Resultados";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(1398, 729);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tbxCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "LupiJos Code Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbxCode)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVLexico)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.errores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVLexico2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cortarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pegarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorDeFondoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fuenteToolStripMenuItem;
        private FastColoredTextBoxNS.FastColoredTextBox tbxCode;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem seleccionarTodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pegarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cortarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem irAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reemplazarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compilarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem correrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compilarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage errores;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.DataGridView dGVLexico;
        private System.Windows.Forms.DataGridView dGVLexico2;
    }
}

