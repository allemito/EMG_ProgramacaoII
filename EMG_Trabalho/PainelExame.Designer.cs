﻿namespace EMG_Trabalho
{
    partial class PainelExame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PainelExame));
            this.panelExame = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelExame
            // 
            this.panelExame.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelExame.Location = new System.Drawing.Point(0, 0);
            this.panelExame.Name = "panelExame";
            this.panelExame.Size = new System.Drawing.Size(827, 611);
            this.panelExame.TabIndex = 0;
            // 
            // PainelExame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(827, 611);
            this.Controls.Add(this.panelExame);
            this.Name = "PainelExame";
            this.Text = "PainelExame";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelExame;
    }
}