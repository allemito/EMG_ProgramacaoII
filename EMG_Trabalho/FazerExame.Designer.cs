namespace EMG_Trabalho
{
    partial class FazerExame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FazerExame));
            this.buttonIniciar = new System.Windows.Forms.Button();
            this.textBoxExame = new System.Windows.Forms.TextBox();
            this.buttonParar = new System.Windows.Forms.Button();
            this.textBoxTipoExame = new System.Windows.Forms.TextBox();
            this.buttonGravar = new System.Windows.Forms.Button();
            this.labelTipoExame = new System.Windows.Forms.Label();
            this.buttonCalcularExame = new System.Windows.Forms.Button();
            this.listBoxExame = new System.Windows.Forms.ListBox();
            this.textBoxMedia = new System.Windows.Forms.TextBox();
            this.labelMedia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonIniciar
            // 
            this.buttonIniciar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonIniciar.Location = new System.Drawing.Point(43, 181);
            this.buttonIniciar.Name = "buttonIniciar";
            this.buttonIniciar.Size = new System.Drawing.Size(119, 42);
            this.buttonIniciar.TabIndex = 0;
            this.buttonIniciar.Text = "Iniciar";
            this.buttonIniciar.UseVisualStyleBackColor = false;
            this.buttonIniciar.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBoxExame
            // 
            this.textBoxExame.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxExame.Location = new System.Drawing.Point(43, 229);
            this.textBoxExame.Multiline = true;
            this.textBoxExame.Name = "textBoxExame";
            this.textBoxExame.Size = new System.Drawing.Size(555, 354);
            this.textBoxExame.TabIndex = 1;
            // 
            // buttonParar
            // 
            this.buttonParar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonParar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonParar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonParar.Location = new System.Drawing.Point(168, 181);
            this.buttonParar.Name = "buttonParar";
            this.buttonParar.Size = new System.Drawing.Size(119, 42);
            this.buttonParar.TabIndex = 4;
            this.buttonParar.Text = "Parar";
            this.buttonParar.UseVisualStyleBackColor = false;
            this.buttonParar.Click += new System.EventHandler(this.buttonParar_Click);
            // 
            // textBoxTipoExame
            // 
            this.textBoxTipoExame.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxTipoExame.Location = new System.Drawing.Point(268, 17);
            this.textBoxTipoExame.Multiline = true;
            this.textBoxTipoExame.Name = "textBoxTipoExame";
            this.textBoxTipoExame.Size = new System.Drawing.Size(459, 33);
            this.textBoxTipoExame.TabIndex = 5;
            // 
            // buttonGravar
            // 
            this.buttonGravar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonGravar.Location = new System.Drawing.Point(681, 554);
            this.buttonGravar.Name = "buttonGravar";
            this.buttonGravar.Size = new System.Drawing.Size(134, 45);
            this.buttonGravar.TabIndex = 6;
            this.buttonGravar.Text = "Gravar";
            this.buttonGravar.UseVisualStyleBackColor = false;
            this.buttonGravar.Click += new System.EventHandler(this.buttonGravar_Click);
            // 
            // labelTipoExame
            // 
            this.labelTipoExame.AutoSize = true;
            this.labelTipoExame.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelTipoExame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoExame.Location = new System.Drawing.Point(12, 17);
            this.labelTipoExame.Name = "labelTipoExame";
            this.labelTipoExame.Size = new System.Drawing.Size(219, 33);
            this.labelTipoExame.TabIndex = 7;
            this.labelTipoExame.Text = "Tipo de Exame:";
            // 
            // buttonCalcularExame
            // 
            this.buttonCalcularExame.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonCalcularExame.Location = new System.Drawing.Point(293, 181);
            this.buttonCalcularExame.Name = "buttonCalcularExame";
            this.buttonCalcularExame.Size = new System.Drawing.Size(305, 42);
            this.buttonCalcularExame.TabIndex = 8;
            this.buttonCalcularExame.Text = "Calcular Média do Exame";
            this.buttonCalcularExame.UseVisualStyleBackColor = false;
            this.buttonCalcularExame.Click += new System.EventHandler(this.buttonVerExame_Click);
            // 
            // listBoxExame
            // 
            this.listBoxExame.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listBoxExame.FormattingEnabled = true;
            this.listBoxExame.ItemHeight = 25;
            this.listBoxExame.Location = new System.Drawing.Point(681, 444);
            this.listBoxExame.Name = "listBoxExame";
            this.listBoxExame.Size = new System.Drawing.Size(134, 104);
            this.listBoxExame.TabIndex = 9;
            this.listBoxExame.Visible = false;
            // 
            // textBoxMedia
            // 
            this.textBoxMedia.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxMedia.Location = new System.Drawing.Point(268, 61);
            this.textBoxMedia.Multiline = true;
            this.textBoxMedia.Name = "textBoxMedia";
            this.textBoxMedia.ReadOnly = true;
            this.textBoxMedia.Size = new System.Drawing.Size(132, 33);
            this.textBoxMedia.TabIndex = 10;
            // 
            // labelMedia
            // 
            this.labelMedia.AutoSize = true;
            this.labelMedia.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMedia.Location = new System.Drawing.Point(12, 61);
            this.labelMedia.Name = "labelMedia";
            this.labelMedia.Size = new System.Drawing.Size(178, 33);
            this.labelMedia.TabIndex = 11;
            this.labelMedia.Text = "Valor Médio:";
            // 
            // FazerExame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(827, 611);
            this.Controls.Add(this.labelMedia);
            this.Controls.Add(this.textBoxMedia);
            this.Controls.Add(this.listBoxExame);
            this.Controls.Add(this.buttonCalcularExame);
            this.Controls.Add(this.labelTipoExame);
            this.Controls.Add(this.buttonGravar);
            this.Controls.Add(this.textBoxTipoExame);
            this.Controls.Add(this.buttonParar);
            this.Controls.Add(this.textBoxExame);
            this.Controls.Add(this.buttonIniciar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FazerExame";
            this.Text = " Novo Exame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonIniciar;
        private System.Windows.Forms.TextBox textBoxExame;
        private System.Windows.Forms.Button buttonParar;
        private System.Windows.Forms.TextBox textBoxTipoExame;
        private System.Windows.Forms.Button buttonGravar;
        private System.Windows.Forms.Label labelTipoExame;
        private System.Windows.Forms.Button buttonCalcularExame;
        public System.Windows.Forms.ListBox listBoxExame;
        private System.Windows.Forms.TextBox textBoxMedia;
        private System.Windows.Forms.Label labelMedia;
    }
}