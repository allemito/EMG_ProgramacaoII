namespace EMG_Trabalho
{
    partial class EmparelharBitalino
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmparelharBitalino));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.listBoxDevices = new System.Windows.Forms.ListBox();
            this.buttonProcurarDispositivo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(0, 1);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(827, 503);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // listBoxDevices
            // 
            this.listBoxDevices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxDevices.BackColor = System.Drawing.SystemColors.Control;
            this.listBoxDevices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxDevices.FormattingEnabled = true;
            this.listBoxDevices.ItemHeight = 25;
            this.listBoxDevices.Location = new System.Drawing.Point(228, 421);
            this.listBoxDevices.Margin = new System.Windows.Forms.Padding(6);
            this.listBoxDevices.Name = "listBoxDevices";
            this.listBoxDevices.Size = new System.Drawing.Size(418, 175);
            this.listBoxDevices.TabIndex = 2;
            this.listBoxDevices.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxDevices_MouseDoubleClick_1);
            // 
            // buttonProcurarDispositivo
            // 
            this.buttonProcurarDispositivo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProcurarDispositivo.Location = new System.Drawing.Point(296, 57);
            this.buttonProcurarDispositivo.Name = "buttonProcurarDispositivo";
            this.buttonProcurarDispositivo.Size = new System.Drawing.Size(302, 41);
            this.buttonProcurarDispositivo.TabIndex = 3;
            this.buttonProcurarDispositivo.Text = "Procurar Dispositivo";
            this.buttonProcurarDispositivo.UseVisualStyleBackColor = true;
            this.buttonProcurarDispositivo.Click += new System.EventHandler(this.buttonProcurarDispositivo_Click);
            // 
            // EmparelharBitalino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(827, 611);
            this.Controls.Add(this.buttonProcurarDispositivo);
            this.Controls.Add(this.listBoxDevices);
            this.Controls.Add(this.pictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmparelharBitalino";
            this.Text = " Emparelhar Bitalino";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ListBox listBoxDevices;
        private System.Windows.Forms.Button buttonProcurarDispositivo;
    }
}