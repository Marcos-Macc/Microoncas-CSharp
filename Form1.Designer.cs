namespace MicroOndas
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
            this.components = new System.ComponentModel.Container();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnInicioRapido = new System.Windows.Forms.Button();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbProgramas = new System.Windows.Forms.ListBox();
            this.edtEntrada = new System.Windows.Forms.TextBox();
            this.timerAquecendo = new System.Windows.Forms.Timer(this.components);
            this.spnTempo = new System.Windows.Forms.NumericUpDown();
            this.spnPotencia = new System.Windows.Forms.NumericUpDown();
            this.edtInstrucoes = new System.Windows.Forms.TextBox();
            this.lblInstrucoes = new System.Windows.Forms.Label();
            this.edtSaida = new System.Windows.Forms.TextBox();
            this.lblAquecida = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.spnTempo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnPotencia)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInicio
            // 
            this.btnInicio.Location = new System.Drawing.Point(36, 169);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(75, 23);
            this.btnInicio.TabIndex = 0;
            this.btnInicio.Text = "Iniciar";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnInicioRapido
            // 
            this.btnInicioRapido.Location = new System.Drawing.Point(114, 169);
            this.btnInicioRapido.Name = "btnInicioRapido";
            this.btnInicioRapido.Size = new System.Drawing.Size(81, 23);
            this.btnInicioRapido.TabIndex = 1;
            this.btnInicioRapido.Text = "Início rápido";
            this.btnInicioRapido.UseVisualStyleBackColor = true;
            this.btnInicioRapido.Click += new System.EventHandler(this.btnInicioRapido_Click);
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Location = new System.Drawing.Point(36, 38);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(53, 15);
            this.lblEntrada.TabIndex = 2;
            this.lblEntrada.Text = "Entrada: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tempo: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Potência: ";
            // 
            // lbProgramas
            // 
            this.lbProgramas.FormattingEnabled = true;
            this.lbProgramas.ItemHeight = 15;
            this.lbProgramas.Items.AddRange(new object[] {
            "Customizado",
            "Frango",
            "Carne",
            "Peixe",
            "Feijão",
            "Pipoca"});
            this.lbProgramas.Location = new System.Drawing.Point(221, 30);
            this.lbProgramas.Name = "lbProgramas";
            this.lbProgramas.Size = new System.Drawing.Size(120, 94);
            this.lbProgramas.TabIndex = 5;
            this.lbProgramas.SelectedIndexChanged += new System.EventHandler(this.lbProgramas_SelectedIndexChanged);
            // 
            // edtEntrada
            // 
            this.edtEntrada.Location = new System.Drawing.Point(96, 35);
            this.edtEntrada.Name = "edtEntrada";
            this.edtEntrada.Size = new System.Drawing.Size(100, 23);
            this.edtEntrada.TabIndex = 6;
            // 
            // timerAquecendo
            // 
            this.timerAquecendo.Interval = 1000;
            this.timerAquecendo.Tick += new System.EventHandler(this.timerAquecendo_Tick);
            // 
            // spnTempo
            // 
            this.spnTempo.Location = new System.Drawing.Point(96, 61);
            this.spnTempo.Maximum = new decimal(new int[] {
            240,
            0,
            0,
            0});
            this.spnTempo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spnTempo.Name = "spnTempo";
            this.spnTempo.Size = new System.Drawing.Size(100, 23);
            this.spnTempo.TabIndex = 7;
            this.spnTempo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // spnPotencia
            // 
            this.spnPotencia.Location = new System.Drawing.Point(96, 90);
            this.spnPotencia.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.spnPotencia.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spnPotencia.Name = "spnPotencia";
            this.spnPotencia.Size = new System.Drawing.Size(100, 23);
            this.spnPotencia.TabIndex = 8;
            this.spnPotencia.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // edtInstrucoes
            // 
            this.edtInstrucoes.Location = new System.Drawing.Point(96, 119);
            this.edtInstrucoes.Name = "edtInstrucoes";
            this.edtInstrucoes.Size = new System.Drawing.Size(100, 23);
            this.edtInstrucoes.TabIndex = 9;
            // 
            // lblInstrucoes
            // 
            this.lblInstrucoes.AutoSize = true;
            this.lblInstrucoes.Location = new System.Drawing.Point(36, 122);
            this.lblInstrucoes.Name = "lblInstrucoes";
            this.lblInstrucoes.Size = new System.Drawing.Size(67, 15);
            this.lblInstrucoes.TabIndex = 10;
            this.lblInstrucoes.Text = "Instruções: ";
            // 
            // edtSaida
            // 
            this.edtSaida.Location = new System.Drawing.Point(36, 210);
            this.edtSaida.Name = "edtSaida";
            this.edtSaida.Size = new System.Drawing.Size(160, 23);
            this.edtSaida.TabIndex = 11;
            // 
            // lblAquecida
            // 
            this.lblAquecida.AutoSize = true;
            this.lblAquecida.Location = new System.Drawing.Point(87, 246);
            this.lblAquecida.Name = "lblAquecida";
            this.lblAquecida.Size = new System.Drawing.Size(68, 15);
            this.lblAquecida.TabIndex = 12;
            this.lblAquecida.Text = "AQUECIDA!";
            this.lblAquecida.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 281);
            this.Controls.Add(this.lblAquecida);
            this.Controls.Add(this.edtSaida);
            this.Controls.Add(this.lblInstrucoes);
            this.Controls.Add(this.edtInstrucoes);
            this.Controls.Add(this.spnPotencia);
            this.Controls.Add(this.spnTempo);
            this.Controls.Add(this.edtEntrada);
            this.Controls.Add(this.lbProgramas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblEntrada);
            this.Controls.Add(this.btnInicioRapido);
            this.Controls.Add(this.btnInicio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.spnTempo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnPotencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnInicio;
        private Button btnInicioRapido;
        private Label lblEntrada;
        private Label label2;
        private Label label3;
        private ListBox lbProgramas;
        private TextBox edtEntrada;
        private System.Windows.Forms.Timer timerAquecendo;
        private NumericUpDown spnTempo;
        private NumericUpDown spnPotencia;
        private TextBox edtInstrucoes;
        private Label lblInstrucoes;
        private TextBox edtSaida;
        private Label lblAquecida;
    }
}