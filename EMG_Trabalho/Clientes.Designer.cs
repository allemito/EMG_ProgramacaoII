namespace EMG_Trabalho
{
    partial class Clientes
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
        /// 

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonExportar = new System.Windows.Forms.Button();
            this.buttonAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClientes.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewClientes.Location = new System.Drawing.Point(61, 101);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.RowTemplate.Height = 33;
            this.dataGridViewClientes.Size = new System.Drawing.Size(709, 416);
            this.dataGridViewClientes.TabIndex = 0;
            this.dataGridViewClientes.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewClientes_CellMouseDoubleClick);
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdicionar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonAdicionar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAdicionar.Location = new System.Drawing.Point(695, 53);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(75, 42);
            this.buttonAdicionar.TabIndex = 1;
            this.buttonAdicionar.Text = "+";
            this.buttonAdicionar.UseVisualStyleBackColor = false;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // buttonApagar
            // 
            this.buttonApagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonApagar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonApagar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonApagar.Location = new System.Drawing.Point(514, 53);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(91, 42);
            this.buttonApagar.TabIndex = 2;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = false;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonEditar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonEditar.Location = new System.Drawing.Point(611, 53);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(78, 42);
            this.buttonEditar.TabIndex = 3;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = false;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonExportar
            // 
            this.buttonExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExportar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonExportar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonExportar.Location = new System.Drawing.Point(404, 53);
            this.buttonExportar.Name = "buttonExportar";
            this.buttonExportar.Size = new System.Drawing.Size(104, 42);
            this.buttonExportar.TabIndex = 4;
            this.buttonExportar.Text = "Exportar";
            this.buttonExportar.UseVisualStyleBackColor = false;
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonAtualizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAtualizar.Location = new System.Drawing.Point(61, 53);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(104, 42);
            this.buttonAtualizar.TabIndex = 5;
            this.buttonAtualizar.Text = "Atualizar";
            this.buttonAtualizar.UseVisualStyleBackColor = false;
            this.buttonAtualizar.Click += new System.EventHandler(this.buttonAtualizar_Click);
            // 
            // Clientes
            // 
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(827, 611);
            this.Controls.Add(this.buttonAtualizar);
            this.Controls.Add(this.buttonExportar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.dataGridViewClientes);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Clientes";
            this.Text = " Lista de Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Button buttonApagar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonExportar;
        private System.Windows.Forms.Button buttonAtualizar;
        public System.Windows.Forms.DataGridView dataGridViewClientes;
    }
}

