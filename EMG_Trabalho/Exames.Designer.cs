namespace EMG_Trabalho
{
    partial class Exames
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exames));
            this.dataGridViewExames = new System.Windows.Forms.DataGridView();
            this.buttonApagarExame = new System.Windows.Forms.Button();
            this.buttonNovoExame = new System.Windows.Forms.Button();
            this.buttonEmparelhar = new System.Windows.Forms.Button();
            this.buttonAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExames)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewExames
            // 
            this.dataGridViewExames.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewExames.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewExames.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridViewExames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExames.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewExames.Location = new System.Drawing.Point(59, 97);
            this.dataGridViewExames.Name = "dataGridViewExames";
            this.dataGridViewExames.RowTemplate.Height = 33;
            this.dataGridViewExames.Size = new System.Drawing.Size(709, 416);
            this.dataGridViewExames.TabIndex = 1;
            // 
            // buttonApagarExame
            // 
            this.buttonApagarExame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonApagarExame.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonApagarExame.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonApagarExame.Location = new System.Drawing.Point(649, 49);
            this.buttonApagarExame.Name = "buttonApagarExame";
            this.buttonApagarExame.Size = new System.Drawing.Size(119, 42);
            this.buttonApagarExame.TabIndex = 3;
            this.buttonApagarExame.Text = "Apagar";
            this.buttonApagarExame.UseVisualStyleBackColor = false;
            this.buttonApagarExame.Click += new System.EventHandler(this.buttonApagarExame_Click);
            // 
            // buttonNovoExame
            // 
            this.buttonNovoExame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNovoExame.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonNovoExame.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonNovoExame.Location = new System.Drawing.Point(477, 49);
            this.buttonNovoExame.Name = "buttonNovoExame";
            this.buttonNovoExame.Size = new System.Drawing.Size(166, 42);
            this.buttonNovoExame.TabIndex = 4;
            this.buttonNovoExame.Text = "Novo Exame";
            this.buttonNovoExame.UseVisualStyleBackColor = false;
            this.buttonNovoExame.Click += new System.EventHandler(this.buttonNovoExame_Click);
            // 
            // buttonEmparelhar
            // 
            this.buttonEmparelhar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEmparelhar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonEmparelhar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonEmparelhar.Location = new System.Drawing.Point(236, 49);
            this.buttonEmparelhar.Name = "buttonEmparelhar";
            this.buttonEmparelhar.Size = new System.Drawing.Size(235, 42);
            this.buttonEmparelhar.TabIndex = 5;
            this.buttonEmparelhar.Text = "Emparelhar Bitalino";
            this.buttonEmparelhar.UseVisualStyleBackColor = false;
            this.buttonEmparelhar.Click += new System.EventHandler(this.buttonEmparelhar_Click);
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonAtualizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAtualizar.Location = new System.Drawing.Point(59, 49);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(117, 42);
            this.buttonAtualizar.TabIndex = 6;
            this.buttonAtualizar.Text = "Atualizar";
            this.buttonAtualizar.UseVisualStyleBackColor = false;
            this.buttonAtualizar.Click += new System.EventHandler(this.buttonAtualizar_Click);
            // 
            // Exames
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(827, 611);
            this.Controls.Add(this.buttonAtualizar);
            this.Controls.Add(this.buttonEmparelhar);
            this.Controls.Add(this.buttonNovoExame);
            this.Controls.Add(this.buttonApagarExame);
            this.Controls.Add(this.dataGridViewExames);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Exames";
            this.Text = "Lista de Exames";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExames)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView dataGridViewExames;
        private System.Windows.Forms.Button buttonApagarExame;
        private System.Windows.Forms.Button buttonNovoExame;
        private System.Windows.Forms.Button buttonEmparelhar;
        private System.Windows.Forms.Button buttonAtualizar;
    }
}