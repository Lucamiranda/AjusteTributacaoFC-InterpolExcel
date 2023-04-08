namespace AjusteProdutos
{
    partial class Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.lbCaminho = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbAmbos = new System.Windows.Forms.RadioButton();
            this.rbDrogaria = new System.Windows.Forms.RadioButton();
            this.rbRevenda = new System.Windows.Forms.RadioButton();
            this.btn_LocalizarPlanilha = new System.Windows.Forms.Button();
            this.btn_Pesquisar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            this.txtCaminhoImport = new System.Windows.Forms.TextBox();
            this.dgConsultaProd = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbAmbosNCM = new System.Windows.Forms.RadioButton();
            this.rbDrogariaNCM = new System.Windows.Forms.RadioButton();
            this.rbRevendaNCM = new System.Windows.Forms.RadioButton();
            this.btnCarregarPlanNCM = new System.Windows.Forms.Button();
            this.btnBuscarNCM = new System.Windows.Forms.Button();
            this.btnExportarNCM = new System.Windows.Forms.Button();
            this.btnImportarNCM = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgConsultaNCM = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNovo = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbSubAmbos = new System.Windows.Forms.RadioButton();
            this.rbDroSubNMC = new System.Windows.Forms.RadioButton();
            this.rbRevSubNCM = new System.Windows.Forms.RadioButton();
            this.btnProdNcm = new System.Windows.Forms.Button();
            this.btnAlterarNCM = new System.Windows.Forms.Button();
            this.txtAntigo = new System.Windows.Forms.TextBox();
            this.dgAlteraNCM = new System.Windows.Forms.DataGridView();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgConsultaProd)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgConsultaNCM)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlteraNCM)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCaminho
            // 
            this.lbCaminho.AutoSize = true;
            this.lbCaminho.Location = new System.Drawing.Point(-227, 258);
            this.lbCaminho.Name = "lbCaminho";
            this.lbCaminho.Size = new System.Drawing.Size(54, 13);
            this.lbCaminho.TabIndex = 13;
            this.lbCaminho.Text = "Caminho :";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1221, 696);
            this.tabControl1.TabIndex = 25;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btn_LocalizarPlanilha);
            this.tabPage1.Controls.Add(this.btn_Pesquisar);
            this.tabPage1.Controls.Add(this.btnExportar);
            this.tabPage1.Controls.Add(this.btnImportar);
            this.tabPage1.Controls.Add(this.txtCaminhoImport);
            this.tabPage1.Controls.Add(this.dgConsultaProd);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1213, 670);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Por Produtos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbAmbos);
            this.groupBox1.Controls.Add(this.rbDrogaria);
            this.groupBox1.Controls.Add(this.rbRevenda);
            this.groupBox1.Location = new System.Drawing.Point(227, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 68);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grupo de Produtos";
            // 
            // rbAmbos
            // 
            this.rbAmbos.AutoSize = true;
            this.rbAmbos.Location = new System.Drawing.Point(278, 29);
            this.rbAmbos.Name = "rbAmbos";
            this.rbAmbos.Size = new System.Drawing.Size(57, 17);
            this.rbAmbos.TabIndex = 2;
            this.rbAmbos.TabStop = true;
            this.rbAmbos.Text = "Ambos";
            this.rbAmbos.UseVisualStyleBackColor = true;
            // 
            // rbDrogaria
            // 
            this.rbDrogaria.AutoSize = true;
            this.rbDrogaria.Location = new System.Drawing.Point(147, 29);
            this.rbDrogaria.Name = "rbDrogaria";
            this.rbDrogaria.Size = new System.Drawing.Size(65, 17);
            this.rbDrogaria.TabIndex = 1;
            this.rbDrogaria.TabStop = true;
            this.rbDrogaria.Text = "Drogaria";
            this.rbDrogaria.UseVisualStyleBackColor = true;
            // 
            // rbRevenda
            // 
            this.rbRevenda.AutoSize = true;
            this.rbRevenda.Location = new System.Drawing.Point(26, 29);
            this.rbRevenda.Name = "rbRevenda";
            this.rbRevenda.Size = new System.Drawing.Size(69, 17);
            this.rbRevenda.TabIndex = 0;
            this.rbRevenda.TabStop = true;
            this.rbRevenda.Text = "Revenda";
            this.rbRevenda.UseVisualStyleBackColor = true;
            // 
            // btn_LocalizarPlanilha
            // 
            this.btn_LocalizarPlanilha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_LocalizarPlanilha.Location = new System.Drawing.Point(971, 6);
            this.btn_LocalizarPlanilha.Name = "btn_LocalizarPlanilha";
            this.btn_LocalizarPlanilha.Size = new System.Drawing.Size(39, 23);
            this.btn_LocalizarPlanilha.TabIndex = 29;
            this.btn_LocalizarPlanilha.Text = "...";
            this.btn_LocalizarPlanilha.UseVisualStyleBackColor = true;
            this.btn_LocalizarPlanilha.Click += new System.EventHandler(this.btn_LocalizarPlanilha_Click_1);
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.Location = new System.Drawing.Point(1, 47);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(191, 25);
            this.btn_Pesquisar.TabIndex = 28;
            this.btn_Pesquisar.Text = "Buscar Produtos";
            this.btn_Pesquisar.UseVisualStyleBackColor = true;
            this.btn_Pesquisar.Click += new System.EventHandler(this.btn_Pesquisar_Click_1);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(1, 87);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(191, 23);
            this.btnExportar.TabIndex = 25;
            this.btnExportar.Text = "Exportar para Excel";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click_1);
            // 
            // btnImportar
            // 
            this.btnImportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImportar.Location = new System.Drawing.Point(1016, 6);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(191, 23);
            this.btnImportar.TabIndex = 27;
            this.btnImportar.Text = "Importar Planilha";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click_1);
            // 
            // txtCaminhoImport
            // 
            this.txtCaminhoImport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCaminhoImport.Location = new System.Drawing.Point(1, 6);
            this.txtCaminhoImport.Name = "txtCaminhoImport";
            this.txtCaminhoImport.Size = new System.Drawing.Size(964, 20);
            this.txtCaminhoImport.TabIndex = 26;
            // 
            // dgConsultaProd
            // 
            this.dgConsultaProd.AllowUserToAddRows = false;
            this.dgConsultaProd.AllowUserToDeleteRows = false;
            this.dgConsultaProd.AllowUserToResizeColumns = false;
            this.dgConsultaProd.AllowUserToResizeRows = false;
            this.dgConsultaProd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgConsultaProd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgConsultaProd.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgConsultaProd.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgConsultaProd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgConsultaProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgConsultaProd.Location = new System.Drawing.Point(0, 132);
            this.dgConsultaProd.Name = "dgConsultaProd";
            this.dgConsultaProd.ReadOnly = true;
            this.dgConsultaProd.Size = new System.Drawing.Size(1213, 538);
            this.dgConsultaProd.TabIndex = 18;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.btnCarregarPlanNCM);
            this.tabPage2.Controls.Add(this.btnBuscarNCM);
            this.tabPage2.Controls.Add(this.btnExportarNCM);
            this.tabPage2.Controls.Add(this.btnImportarNCM);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.dgConsultaNCM);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1213, 670);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Por NCM";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbAmbosNCM);
            this.groupBox2.Controls.Add(this.rbDrogariaNCM);
            this.groupBox2.Controls.Add(this.rbRevendaNCM);
            this.groupBox2.Location = new System.Drawing.Point(227, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 68);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grupo de Produtos";
            // 
            // rbAmbosNCM
            // 
            this.rbAmbosNCM.AutoSize = true;
            this.rbAmbosNCM.Location = new System.Drawing.Point(278, 29);
            this.rbAmbosNCM.Name = "rbAmbosNCM";
            this.rbAmbosNCM.Size = new System.Drawing.Size(57, 17);
            this.rbAmbosNCM.TabIndex = 2;
            this.rbAmbosNCM.TabStop = true;
            this.rbAmbosNCM.Text = "Ambos";
            this.rbAmbosNCM.UseVisualStyleBackColor = true;
            // 
            // rbDrogariaNCM
            // 
            this.rbDrogariaNCM.AutoSize = true;
            this.rbDrogariaNCM.Location = new System.Drawing.Point(147, 29);
            this.rbDrogariaNCM.Name = "rbDrogariaNCM";
            this.rbDrogariaNCM.Size = new System.Drawing.Size(65, 17);
            this.rbDrogariaNCM.TabIndex = 1;
            this.rbDrogariaNCM.TabStop = true;
            this.rbDrogariaNCM.Text = "Drogaria";
            this.rbDrogariaNCM.UseVisualStyleBackColor = true;
            // 
            // rbRevendaNCM
            // 
            this.rbRevendaNCM.AutoSize = true;
            this.rbRevendaNCM.Location = new System.Drawing.Point(26, 29);
            this.rbRevendaNCM.Name = "rbRevendaNCM";
            this.rbRevendaNCM.Size = new System.Drawing.Size(69, 17);
            this.rbRevendaNCM.TabIndex = 0;
            this.rbRevendaNCM.TabStop = true;
            this.rbRevendaNCM.Text = "Revenda";
            this.rbRevendaNCM.UseVisualStyleBackColor = true;
            // 
            // btnCarregarPlanNCM
            // 
            this.btnCarregarPlanNCM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCarregarPlanNCM.Location = new System.Drawing.Point(971, 6);
            this.btnCarregarPlanNCM.Name = "btnCarregarPlanNCM";
            this.btnCarregarPlanNCM.Size = new System.Drawing.Size(39, 23);
            this.btnCarregarPlanNCM.TabIndex = 36;
            this.btnCarregarPlanNCM.Text = "...";
            this.btnCarregarPlanNCM.UseVisualStyleBackColor = true;
            this.btnCarregarPlanNCM.Click += new System.EventHandler(this.btnCarregarPlanNCM_Click);
            // 
            // btnBuscarNCM
            // 
            this.btnBuscarNCM.Location = new System.Drawing.Point(1, 47);
            this.btnBuscarNCM.Name = "btnBuscarNCM";
            this.btnBuscarNCM.Size = new System.Drawing.Size(191, 25);
            this.btnBuscarNCM.TabIndex = 35;
            this.btnBuscarNCM.Text = "Buscar Por NCM";
            this.btnBuscarNCM.UseVisualStyleBackColor = true;
            this.btnBuscarNCM.Click += new System.EventHandler(this.btnBuscarNCM_Click);
            // 
            // btnExportarNCM
            // 
            this.btnExportarNCM.Location = new System.Drawing.Point(1, 87);
            this.btnExportarNCM.Name = "btnExportarNCM";
            this.btnExportarNCM.Size = new System.Drawing.Size(191, 23);
            this.btnExportarNCM.TabIndex = 32;
            this.btnExportarNCM.Text = "Exportar para Excel";
            this.btnExportarNCM.UseVisualStyleBackColor = true;
            this.btnExportarNCM.Click += new System.EventHandler(this.btnExportarNCM_Click);
            // 
            // btnImportarNCM
            // 
            this.btnImportarNCM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImportarNCM.Location = new System.Drawing.Point(1016, 6);
            this.btnImportarNCM.Name = "btnImportarNCM";
            this.btnImportarNCM.Size = new System.Drawing.Size(191, 23);
            this.btnImportarNCM.TabIndex = 34;
            this.btnImportarNCM.Text = "Importar Planilha";
            this.btnImportarNCM.UseVisualStyleBackColor = true;
            this.btnImportarNCM.Click += new System.EventHandler(this.btnImportarNCM_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(1, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(964, 20);
            this.textBox1.TabIndex = 33;
            // 
            // dgConsultaNCM
            // 
            this.dgConsultaNCM.AllowUserToAddRows = false;
            this.dgConsultaNCM.AllowUserToDeleteRows = false;
            this.dgConsultaNCM.AllowUserToResizeColumns = false;
            this.dgConsultaNCM.AllowUserToResizeRows = false;
            this.dgConsultaNCM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgConsultaNCM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgConsultaNCM.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgConsultaNCM.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgConsultaNCM.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgConsultaNCM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgConsultaNCM.Location = new System.Drawing.Point(0, 132);
            this.dgConsultaNCM.Name = "dgConsultaNCM";
            this.dgConsultaNCM.ReadOnly = true;
            this.dgConsultaNCM.Size = new System.Drawing.Size(1213, 538);
            this.dgConsultaNCM.TabIndex = 31;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.txtNovo);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.btnProdNcm);
            this.tabPage3.Controls.Add(this.btnAlterarNCM);
            this.tabPage3.Controls.Add(this.txtAntigo);
            this.tabPage3.Controls.Add(this.dgAlteraNCM);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1213, 670);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Substituição de NCM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "NCM NOVO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "NCM ANTIGO";
            // 
            // txtNovo
            // 
            this.txtNovo.Location = new System.Drawing.Point(186, 54);
            this.txtNovo.MaxLength = 8;
            this.txtNovo.Name = "txtNovo";
            this.txtNovo.Size = new System.Drawing.Size(128, 20);
            this.txtNovo.TabIndex = 38;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbSubAmbos);
            this.groupBox3.Controls.Add(this.rbDroSubNMC);
            this.groupBox3.Controls.Add(this.rbRevSubNCM);
            this.groupBox3.Location = new System.Drawing.Point(330, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(122, 133);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Grupo de Produtos";
            // 
            // rbSubAmbos
            // 
            this.rbSubAmbos.AutoSize = true;
            this.rbSubAmbos.Location = new System.Drawing.Point(26, 97);
            this.rbSubAmbos.Name = "rbSubAmbos";
            this.rbSubAmbos.Size = new System.Drawing.Size(57, 17);
            this.rbSubAmbos.TabIndex = 2;
            this.rbSubAmbos.TabStop = true;
            this.rbSubAmbos.Text = "Ambos";
            this.rbSubAmbos.UseVisualStyleBackColor = true;
            // 
            // rbDroSubNMC
            // 
            this.rbDroSubNMC.AutoSize = true;
            this.rbDroSubNMC.Location = new System.Drawing.Point(26, 64);
            this.rbDroSubNMC.Name = "rbDroSubNMC";
            this.rbDroSubNMC.Size = new System.Drawing.Size(65, 17);
            this.rbDroSubNMC.TabIndex = 1;
            this.rbDroSubNMC.TabStop = true;
            this.rbDroSubNMC.Text = "Drogaria";
            this.rbDroSubNMC.UseVisualStyleBackColor = true;
            // 
            // rbRevSubNCM
            // 
            this.rbRevSubNCM.AutoSize = true;
            this.rbRevSubNCM.Location = new System.Drawing.Point(26, 29);
            this.rbRevSubNCM.Name = "rbRevSubNCM";
            this.rbRevSubNCM.Size = new System.Drawing.Size(69, 17);
            this.rbRevSubNCM.TabIndex = 0;
            this.rbRevSubNCM.TabStop = true;
            this.rbRevSubNCM.Text = "Revenda";
            this.rbRevSubNCM.UseVisualStyleBackColor = true;
            // 
            // btnProdNcm
            // 
            this.btnProdNcm.Location = new System.Drawing.Point(24, 94);
            this.btnProdNcm.Name = "btnProdNcm";
            this.btnProdNcm.Size = new System.Drawing.Size(191, 25);
            this.btnProdNcm.TabIndex = 35;
            this.btnProdNcm.Text = "Buscar Produtos";
            this.btnProdNcm.UseVisualStyleBackColor = true;
            this.btnProdNcm.Click += new System.EventHandler(this.btnProdNcm_Click);
            // 
            // btnAlterarNCM
            // 
            this.btnAlterarNCM.Location = new System.Drawing.Point(24, 135);
            this.btnAlterarNCM.Name = "btnAlterarNCM";
            this.btnAlterarNCM.Size = new System.Drawing.Size(191, 23);
            this.btnAlterarNCM.TabIndex = 32;
            this.btnAlterarNCM.Text = "Aplicar Alteração";
            this.btnAlterarNCM.UseVisualStyleBackColor = true;
            this.btnAlterarNCM.Click += new System.EventHandler(this.btnAlterarNCM_Click);
            // 
            // txtAntigo
            // 
            this.txtAntigo.Location = new System.Drawing.Point(24, 54);
            this.txtAntigo.MaxLength = 8;
            this.txtAntigo.Name = "txtAntigo";
            this.txtAntigo.Size = new System.Drawing.Size(128, 20);
            this.txtAntigo.TabIndex = 33;
            // 
            // dgAlteraNCM
            // 
            this.dgAlteraNCM.AllowUserToAddRows = false;
            this.dgAlteraNCM.AllowUserToDeleteRows = false;
            this.dgAlteraNCM.AllowUserToResizeColumns = false;
            this.dgAlteraNCM.AllowUserToResizeRows = false;
            this.dgAlteraNCM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgAlteraNCM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAlteraNCM.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgAlteraNCM.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgAlteraNCM.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgAlteraNCM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAlteraNCM.Location = new System.Drawing.Point(6, 177);
            this.dgAlteraNCM.Name = "dgAlteraNCM";
            this.dgAlteraNCM.Size = new System.Drawing.Size(1213, 497);
            this.dgAlteraNCM.TabIndex = 31;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(12, 714);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1220, 23);
            this.progressBar1.TabIndex = 19;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(0, 17);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 753);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(1241, 22);
            this.statusStrip1.TabIndex = 21;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 775);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lbCaminho);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajuste Tributário - Produtos";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgConsultaProd)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgConsultaNCM)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlteraNCM)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCaminho;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgConsultaProd;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbAmbos;
        private System.Windows.Forms.RadioButton rbDrogaria;
        private System.Windows.Forms.RadioButton rbRevenda;
        private System.Windows.Forms.Button btn_LocalizarPlanilha;
        private System.Windows.Forms.Button btn_Pesquisar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.TextBox txtCaminhoImport;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbSubAmbos;
        private System.Windows.Forms.RadioButton rbDroSubNMC;
        private System.Windows.Forms.RadioButton rbRevSubNCM;
        private System.Windows.Forms.Button btnProdNcm;
        private System.Windows.Forms.TextBox txtAntigo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbAmbosNCM;
        private System.Windows.Forms.RadioButton rbDrogariaNCM;
        private System.Windows.Forms.RadioButton rbRevendaNCM;
        private System.Windows.Forms.Button btnCarregarPlanNCM;
        private System.Windows.Forms.Button btnBuscarNCM;
        private System.Windows.Forms.Button btnExportarNCM;
        private System.Windows.Forms.Button btnImportarNCM;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgConsultaNCM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNovo;
        private System.Windows.Forms.Button btnAlterarNCM;
        private System.Windows.Forms.DataGridView dgAlteraNCM;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}