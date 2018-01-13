namespace EMG_Trabalho
{
    partial class AdicionarClientes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionarClientes));
            this.labelNome = new System.Windows.Forms.Label();
            this.labelAltura = new System.Windows.Forms.Label();
            this.labelIdade = new System.Windows.Forms.Label();
            this.labelGenero = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelPeso = new System.Windows.Forms.Label();
            this.radioButtonMasculino = new System.Windows.Forms.RadioButton();
            this.radioButtonFeminino = new System.Windows.Forms.RadioButton();
            this.textBoxAltura = new System.Windows.Forms.TextBox();
            this.textBoxPeso = new System.Windows.Forms.TextBox();
            this.numericUpDownIdade = new System.Windows.Forms.NumericUpDown();
            this.toolTipIMC = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxIMC = new System.Windows.Forms.TextBox();
            this.textBoxIMCResultado = new System.Windows.Forms.TextBox();
            this.labelDesporto = new System.Windows.Forms.Label();
            this.radioButtonSim = new System.Windows.Forms.RadioButton();
            this.radioButtonNao = new System.Windows.Forms.RadioButton();
            this.buttonGravar = new System.Windows.Forms.Button();
            this.buttonGravarAlteracoes = new System.Windows.Forms.Button();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.groupBoxGenero = new System.Windows.Forms.GroupBox();
            this.groupBoxDesporto = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIdade)).BeginInit();
            this.groupBoxGenero.SuspendLayout();
            this.groupBoxDesporto.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelNome.AutoSize = true;
            this.labelNome.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(12, 27);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(101, 33);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome:";
            // 
            // labelAltura
            // 
            this.labelAltura.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelAltura.AutoSize = true;
            this.labelAltura.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAltura.Location = new System.Drawing.Point(12, 251);
            this.labelAltura.Name = "labelAltura";
            this.labelAltura.Size = new System.Drawing.Size(99, 33);
            this.labelAltura.TabIndex = 2;
            this.labelAltura.Text = "Altura:";
            // 
            // labelIdade
            // 
            this.labelIdade.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelIdade.AutoSize = true;
            this.labelIdade.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdade.Location = new System.Drawing.Point(12, 101);
            this.labelIdade.Name = "labelIdade";
            this.labelIdade.Size = new System.Drawing.Size(95, 33);
            this.labelIdade.TabIndex = 3;
            this.labelIdade.Text = "Idade:";
            // 
            // labelGenero
            // 
            this.labelGenero.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelGenero.AutoSize = true;
            this.labelGenero.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenero.Location = new System.Drawing.Point(12, 180);
            this.labelGenero.Name = "labelGenero";
            this.labelGenero.Size = new System.Drawing.Size(120, 33);
            this.labelGenero.TabIndex = 4;
            this.labelGenero.Text = "Genero:";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNome.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNome.Location = new System.Drawing.Point(171, 27);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(520, 38);
            this.textBoxNome.TabIndex = 5;
            // 
            // labelPeso
            // 
            this.labelPeso.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelPeso.AutoSize = true;
            this.labelPeso.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPeso.Location = new System.Drawing.Point(12, 318);
            this.labelPeso.Name = "labelPeso";
            this.labelPeso.Size = new System.Drawing.Size(89, 33);
            this.labelPeso.TabIndex = 7;
            this.labelPeso.Text = "Peso:";
            // 
            // radioButtonMasculino
            // 
            this.radioButtonMasculino.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonMasculino.AutoSize = true;
            this.radioButtonMasculino.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.radioButtonMasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMasculino.Location = new System.Drawing.Point(0, 0);
            this.radioButtonMasculino.Name = "radioButtonMasculino";
            this.radioButtonMasculino.Size = new System.Drawing.Size(167, 35);
            this.radioButtonMasculino.TabIndex = 8;
            this.radioButtonMasculino.TabStop = true;
            this.radioButtonMasculino.Text = "Masculino";
            this.radioButtonMasculino.UseVisualStyleBackColor = false;
            // 
            // radioButtonFeminino
            // 
            this.radioButtonFeminino.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.radioButtonFeminino.AutoSize = true;
            this.radioButtonFeminino.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.radioButtonFeminino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFeminino.Location = new System.Drawing.Point(364, 0);
            this.radioButtonFeminino.Name = "radioButtonFeminino";
            this.radioButtonFeminino.Size = new System.Drawing.Size(156, 35);
            this.radioButtonFeminino.TabIndex = 9;
            this.radioButtonFeminino.TabStop = true;
            this.radioButtonFeminino.Text = "Feminino";
            this.radioButtonFeminino.UseVisualStyleBackColor = false;
            // 
            // textBoxAltura
            // 
            this.textBoxAltura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAltura.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAltura.Location = new System.Drawing.Point(171, 246);
            this.textBoxAltura.Name = "textBoxAltura";
            this.textBoxAltura.Size = new System.Drawing.Size(167, 38);
            this.textBoxAltura.TabIndex = 10;
            this.toolTipIMC.SetToolTip(this.textBoxAltura, "Alerta:\r\nAltura em Metros (m).\r\nApresente 2 casas decimais separadas por uma virg" +
        "ula.");
            // 
            // textBoxPeso
            // 
            this.textBoxPeso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPeso.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPeso.Location = new System.Drawing.Point(171, 318);
            this.textBoxPeso.Name = "textBoxPeso";
            this.textBoxPeso.Size = new System.Drawing.Size(167, 38);
            this.textBoxPeso.TabIndex = 11;
            this.toolTipIMC.SetToolTip(this.textBoxPeso, "Alerta:\r\nPeso em Quilogramas (Kg).\r\nApresente 3 casas decimais separadas por uma " +
        "virgula.\r\n");
            // 
            // numericUpDownIdade
            // 
            this.numericUpDownIdade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownIdade.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.numericUpDownIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownIdade.Location = new System.Drawing.Point(171, 101);
            this.numericUpDownIdade.Name = "numericUpDownIdade";
            this.numericUpDownIdade.Size = new System.Drawing.Size(167, 38);
            this.numericUpDownIdade.TabIndex = 13;
            // 
            // textBoxIMC
            // 
            this.textBoxIMC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIMC.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxIMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIMC.Location = new System.Drawing.Point(228, 469);
            this.textBoxIMC.Name = "textBoxIMC";
            this.textBoxIMC.ReadOnly = true;
            this.textBoxIMC.Size = new System.Drawing.Size(167, 38);
            this.textBoxIMC.TabIndex = 20;
            this.toolTipIMC.SetToolTip(this.textBoxIMC, "Alerta:\r\nAltura em Metros (m).\r\nApresente 2 casas decimais separadas por uma virg" +
        "ula.");
            // 
            // textBoxIMCResultado
            // 
            this.textBoxIMCResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIMCResultado.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxIMCResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIMCResultado.Location = new System.Drawing.Point(228, 513);
            this.textBoxIMCResultado.Name = "textBoxIMCResultado";
            this.textBoxIMCResultado.ReadOnly = true;
            this.textBoxIMCResultado.Size = new System.Drawing.Size(167, 38);
            this.textBoxIMCResultado.TabIndex = 21;
            this.toolTipIMC.SetToolTip(this.textBoxIMCResultado, "Alerta:\r\nAltura em Metros (m).\r\nApresente 2 casas decimais separadas por uma virg" +
        "ula.");
            // 
            // labelDesporto
            // 
            this.labelDesporto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelDesporto.AutoSize = true;
            this.labelDesporto.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelDesporto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDesporto.Location = new System.Drawing.Point(12, 399);
            this.labelDesporto.Name = "labelDesporto";
            this.labelDesporto.Size = new System.Drawing.Size(243, 33);
            this.labelDesporto.TabIndex = 14;
            this.labelDesporto.Text = "Pratica desporto?";
            // 
            // radioButtonSim
            // 
            this.radioButtonSim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonSim.AutoSize = true;
            this.radioButtonSim.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.radioButtonSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSim.Location = new System.Drawing.Point(0, 0);
            this.radioButtonSim.Name = "radioButtonSim";
            this.radioButtonSim.Size = new System.Drawing.Size(91, 35);
            this.radioButtonSim.TabIndex = 15;
            this.radioButtonSim.TabStop = true;
            this.radioButtonSim.Text = "Sim";
            this.radioButtonSim.UseVisualStyleBackColor = false;
            // 
            // radioButtonNao
            // 
            this.radioButtonNao.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.radioButtonNao.AutoSize = true;
            this.radioButtonNao.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.radioButtonNao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNao.Location = new System.Drawing.Point(285, -2);
            this.radioButtonNao.Name = "radioButtonNao";
            this.radioButtonNao.Size = new System.Drawing.Size(95, 35);
            this.radioButtonNao.TabIndex = 16;
            this.radioButtonNao.TabStop = true;
            this.radioButtonNao.Text = "Não";
            this.radioButtonNao.UseVisualStyleBackColor = false;
            // 
            // buttonGravar
            // 
            this.buttonGravar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGravar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonGravar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonGravar.Location = new System.Drawing.Point(698, 552);
            this.buttonGravar.Name = "buttonGravar";
            this.buttonGravar.Size = new System.Drawing.Size(117, 47);
            this.buttonGravar.TabIndex = 17;
            this.buttonGravar.Text = "Gravar";
            this.buttonGravar.UseVisualStyleBackColor = false;
            this.buttonGravar.Click += new System.EventHandler(this.buttonGravar_Click);
            // 
            // buttonGravarAlteracoes
            // 
            this.buttonGravarAlteracoes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGravarAlteracoes.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonGravarAlteracoes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonGravarAlteracoes.Location = new System.Drawing.Point(484, 552);
            this.buttonGravarAlteracoes.Name = "buttonGravarAlteracoes";
            this.buttonGravarAlteracoes.Size = new System.Drawing.Size(207, 47);
            this.buttonGravarAlteracoes.TabIndex = 18;
            this.buttonGravarAlteracoes.Text = "Gravar Alterações";
            this.buttonGravarAlteracoes.UseVisualStyleBackColor = false;
            this.buttonGravarAlteracoes.Click += new System.EventHandler(this.buttonGravaralteracoes_Click);
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonCalcular.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonCalcular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCalcular.Location = new System.Drawing.Point(12, 469);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(150, 38);
            this.buttonCalcular.TabIndex = 19;
            this.buttonCalcular.Text = "Calcular IMC";
            this.buttonCalcular.UseVisualStyleBackColor = false;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // groupBoxGenero
            // 
            this.groupBoxGenero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxGenero.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBoxGenero.Controls.Add(this.radioButtonFeminino);
            this.groupBoxGenero.Controls.Add(this.radioButtonMasculino);
            this.groupBoxGenero.Location = new System.Drawing.Point(171, 175);
            this.groupBoxGenero.Name = "groupBoxGenero";
            this.groupBoxGenero.Size = new System.Drawing.Size(520, 38);
            this.groupBoxGenero.TabIndex = 22;
            this.groupBoxGenero.TabStop = false;
            // 
            // groupBoxDesporto
            // 
            this.groupBoxDesporto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDesporto.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBoxDesporto.Controls.Add(this.radioButtonSim);
            this.groupBoxDesporto.Controls.Add(this.radioButtonNao);
            this.groupBoxDesporto.Location = new System.Drawing.Point(311, 399);
            this.groupBoxDesporto.Name = "groupBoxDesporto";
            this.groupBoxDesporto.Size = new System.Drawing.Size(380, 38);
            this.groupBoxDesporto.TabIndex = 23;
            this.groupBoxDesporto.TabStop = false;
            // 
            // AdicionarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(827, 611);
            this.Controls.Add(this.groupBoxDesporto);
            this.Controls.Add(this.groupBoxGenero);
            this.Controls.Add(this.textBoxIMCResultado);
            this.Controls.Add(this.textBoxIMC);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.buttonGravarAlteracoes);
            this.Controls.Add(this.buttonGravar);
            this.Controls.Add(this.labelDesporto);
            this.Controls.Add(this.numericUpDownIdade);
            this.Controls.Add(this.textBoxPeso);
            this.Controls.Add(this.textBoxAltura);
            this.Controls.Add(this.labelPeso);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelGenero);
            this.Controls.Add(this.labelIdade);
            this.Controls.Add(this.labelAltura);
            this.Controls.Add(this.labelNome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdicionarClientes";
            this.Text = " Adicionar Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIdade)).EndInit();
            this.groupBoxGenero.ResumeLayout(false);
            this.groupBoxGenero.PerformLayout();
            this.groupBoxDesporto.ResumeLayout(false);
            this.groupBoxDesporto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelAltura;
        private System.Windows.Forms.Label labelIdade;
        private System.Windows.Forms.Label labelGenero;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelPeso;
        private System.Windows.Forms.RadioButton radioButtonMasculino;
        private System.Windows.Forms.RadioButton radioButtonFeminino;
        private System.Windows.Forms.TextBox textBoxAltura;
        private System.Windows.Forms.TextBox textBoxPeso;
        private System.Windows.Forms.NumericUpDown numericUpDownIdade;
        private System.Windows.Forms.ToolTip toolTipIMC;
        private System.Windows.Forms.Label labelDesporto;
        private System.Windows.Forms.RadioButton radioButtonSim;
        private System.Windows.Forms.RadioButton radioButtonNao;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.TextBox textBoxIMC;
        private System.Windows.Forms.TextBox textBoxIMCResultado;
        private System.Windows.Forms.GroupBox groupBoxGenero;
        private System.Windows.Forms.GroupBox groupBoxDesporto;
        public System.Windows.Forms.Button buttonGravar;
        public System.Windows.Forms.Button buttonGravarAlteracoes;
    }
}