namespace ProyectoAJ
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.activoC = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.montoAC = new System.Windows.Forms.MaskedTextBox();
            this.agregarAC = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.agregarAF = new System.Windows.Forms.Button();
            this.montoAF = new System.Windows.Forms.MaskedTextBox();
            this.activoF = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.data1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.montoAO = new System.Windows.Forms.MaskedTextBox();
            this.agregarAO = new System.Windows.Forms.Button();
            this.activoO = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.montoPC = new System.Windows.Forms.MaskedTextBox();
            this.agregarPC = new System.Windows.Forms.Button();
            this.PasivoC = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.montoC = new System.Windows.Forms.MaskedTextBox();
            this.agregarC = new System.Windows.Forms.Button();
            this.capital = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data2)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(460, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ACTIVOS";
            // 
            // activoC
            // 
            this.activoC.FormattingEnabled = true;
            this.activoC.Items.AddRange(new object[] {
            "Caja",
            "Bancos",
            "Clientes",
            "Mercancias"});
            this.activoC.Location = new System.Drawing.Point(15, 45);
            this.activoC.Name = "activoC";
            this.activoC.Size = new System.Drawing.Size(121, 23);
            this.activoC.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.montoAC);
            this.groupBox2.Controls.Add(this.agregarAC);
            this.groupBox2.Controls.Add(this.activoC);
            this.groupBox2.Location = new System.Drawing.Point(35, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 158);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Activos Circulantes";
            // 
            // montoAC
            // 
            this.montoAC.Location = new System.Drawing.Point(159, 45);
            this.montoAC.Name = "montoAC";
            this.montoAC.Size = new System.Drawing.Size(100, 23);
            this.montoAC.TabIndex = 8;
            // 
            // agregarAC
            // 
            this.agregarAC.Location = new System.Drawing.Point(15, 97);
            this.agregarAC.Name = "agregarAC";
            this.agregarAC.Size = new System.Drawing.Size(244, 32);
            this.agregarAC.TabIndex = 9;
            this.agregarAC.Text = "Agregar Activos Circulantes";
            this.agregarAC.UseVisualStyleBackColor = true;
            this.agregarAC.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.agregarAF);
            this.groupBox3.Controls.Add(this.montoAF);
            this.groupBox3.Controls.Add(this.activoF);
            this.groupBox3.Location = new System.Drawing.Point(343, 193);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(283, 158);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Activos Fijos";
            // 
            // agregarAF
            // 
            this.agregarAF.Location = new System.Drawing.Point(15, 97);
            this.agregarAF.Name = "agregarAF";
            this.agregarAF.Size = new System.Drawing.Size(244, 32);
            this.agregarAF.TabIndex = 10;
            this.agregarAF.Text = "Agregar Activos Fijos";
            this.agregarAF.UseVisualStyleBackColor = true;
            this.agregarAF.Click += new System.EventHandler(this.agregarAF_Click);
            // 
            // montoAF
            // 
            this.montoAF.Location = new System.Drawing.Point(159, 45);
            this.montoAF.Name = "montoAF";
            this.montoAF.Size = new System.Drawing.Size(100, 23);
            this.montoAF.TabIndex = 8;
            // 
            // activoF
            // 
            this.activoF.FormattingEnabled = true;
            this.activoF.Items.AddRange(new object[] {
            "Terreno",
            "Edificio",
            "Mobiliario y Eq."});
            this.activoF.Location = new System.Drawing.Point(15, 45);
            this.activoF.Name = "activoF";
            this.activoF.Size = new System.Drawing.Size(121, 23);
            this.activoF.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(194, 505);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "PASIVOS";
            // 
            // data1
            // 
            this.data1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.data1.Location = new System.Drawing.Point(203, 367);
            this.data1.Name = "data1";
            this.data1.RowTemplate.Height = 25;
            this.data1.Size = new System.Drawing.Size(541, 116);
            this.data1.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Cuenta";
            this.Column1.Name = "Column1";
            this.Column1.Width = 250;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Total";
            this.Column2.Name = "Column2";
            this.Column2.Width = 250;
            // 
            // data2
            // 
            this.data2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.data2.Location = new System.Drawing.Point(203, 700);
            this.data2.Name = "data2";
            this.data2.RowTemplate.Height = 25;
            this.data2.Size = new System.Drawing.Size(541, 121);
            this.data2.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Cuenta";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 250;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Total";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.montoAO);
            this.groupBox4.Controls.Add(this.agregarAO);
            this.groupBox4.Controls.Add(this.activoO);
            this.groupBox4.Location = new System.Drawing.Point(662, 193);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(283, 158);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Otros Activos";
            // 
            // montoAO
            // 
            this.montoAO.Location = new System.Drawing.Point(159, 45);
            this.montoAO.Name = "montoAO";
            this.montoAO.Size = new System.Drawing.Size(100, 23);
            this.montoAO.TabIndex = 8;
            // 
            // agregarAO
            // 
            this.agregarAO.Location = new System.Drawing.Point(15, 97);
            this.agregarAO.Name = "agregarAO";
            this.agregarAO.Size = new System.Drawing.Size(244, 32);
            this.agregarAO.TabIndex = 9;
            this.agregarAO.Text = "Agregar Otros Activos";
            this.agregarAO.UseVisualStyleBackColor = true;
            this.agregarAO.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // activoO
            // 
            this.activoO.FormattingEnabled = true;
            this.activoO.Items.AddRange(new object[] {
            "Salarios",
            "Impuestos a alcaldia",
            "Propaganda y Publi.",
            "Gastos de Adm.",
            "Gastos de Venta"});
            this.activoO.Location = new System.Drawing.Point(15, 45);
            this.activoO.Name = "activoO";
            this.activoO.Size = new System.Drawing.Size(121, 23);
            this.activoO.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(355, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 39);
            this.label2.TabIndex = 16;
            this.label2.Text = "BALANCE GENERAL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(373, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Fecha Actual";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(373, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Hora Actual";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblFecha.Location = new System.Drawing.Point(521, 61);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(38, 15);
            this.lblFecha.TabIndex = 19;
            this.lblFecha.Text = "label5";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblHora.Location = new System.Drawing.Point(521, 100);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(38, 15);
            this.lblHora.TabIndex = 20;
            this.lblHora.Text = "label6";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.montoPC);
            this.groupBox1.Controls.Add(this.agregarPC);
            this.groupBox1.Controls.Add(this.PasivoC);
            this.groupBox1.Location = new System.Drawing.Point(76, 523);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 158);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pasivos Circulantes";
            // 
            // montoPC
            // 
            this.montoPC.Location = new System.Drawing.Point(159, 45);
            this.montoPC.Name = "montoPC";
            this.montoPC.Size = new System.Drawing.Size(100, 23);
            this.montoPC.TabIndex = 8;
            // 
            // agregarPC
            // 
            this.agregarPC.Location = new System.Drawing.Point(15, 97);
            this.agregarPC.Name = "agregarPC";
            this.agregarPC.Size = new System.Drawing.Size(244, 32);
            this.agregarPC.TabIndex = 9;
            this.agregarPC.Text = "Agregar Pasivos Circulantes";
            this.agregarPC.UseVisualStyleBackColor = true;
            this.agregarPC.Click += new System.EventHandler(this.agregarPC_Click);
            // 
            // PasivoC
            // 
            this.PasivoC.FormattingEnabled = true;
            this.PasivoC.Items.AddRange(new object[] {
            "Documentos por Pagar",
            "Cuentas por Pagar"});
            this.PasivoC.Location = new System.Drawing.Point(15, 45);
            this.PasivoC.Name = "PasivoC";
            this.PasivoC.Size = new System.Drawing.Size(121, 23);
            this.PasivoC.TabIndex = 6;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.montoC);
            this.groupBox5.Controls.Add(this.agregarC);
            this.groupBox5.Controls.Add(this.capital);
            this.groupBox5.Location = new System.Drawing.Point(560, 523);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(283, 158);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Capital";
            // 
            // montoC
            // 
            this.montoC.Location = new System.Drawing.Point(159, 45);
            this.montoC.Name = "montoC";
            this.montoC.Size = new System.Drawing.Size(100, 23);
            this.montoC.TabIndex = 8;
            // 
            // agregarC
            // 
            this.agregarC.Location = new System.Drawing.Point(15, 97);
            this.agregarC.Name = "agregarC";
            this.agregarC.Size = new System.Drawing.Size(244, 32);
            this.agregarC.TabIndex = 9;
            this.agregarC.Text = "Agregar Capital";
            this.agregarC.UseVisualStyleBackColor = true;
            this.agregarC.Click += new System.EventHandler(this.agregarC_Click);
            // 
            // capital
            // 
            this.capital.FormattingEnabled = true;
            this.capital.Items.AddRange(new object[] {
            "Capital Social",
            "Capital Contribuido"});
            this.capital.Location = new System.Drawing.Point(15, 45);
            this.capital.Name = "capital";
            this.capital.Size = new System.Drawing.Size(121, 23);
            this.capital.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(677, 505);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "CAPITAL";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Location = new System.Drawing.Point(845, 776);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 45);
            this.button1.TabIndex = 24;
            this.button1.Text = "SALIR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(997, 833);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.data2);
            this.Controls.Add(this.data1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox activoC;
        private GroupBox groupBox2;
        private MaskedTextBox montoAC;
        private GroupBox groupBox3;
        private MaskedTextBox montoAF;
        private ComboBox activoF;
        private Label label9;
        private Button agregarAC;
        private DataGridView data1;
        private DataGridView data2;
        private Button agregarAF;
        private GroupBox groupBox4;
        private MaskedTextBox montoAO;
        private Button agregarAO;
        private ComboBox activoO;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblFecha;
        private Label lblHora;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private GroupBox groupBox1;
        private MaskedTextBox montoPC;
        private Button agregarPC;
        private ComboBox PasivoC;
        private GroupBox groupBox5;
        private MaskedTextBox montoC;
        private Button agregarC;
        private ComboBox capital;
        private Label label5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private Button button1;
    }
}