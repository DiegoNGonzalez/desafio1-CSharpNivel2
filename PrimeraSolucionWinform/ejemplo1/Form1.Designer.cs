﻿namespace ejemplo1
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
            this.btnSaludar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSaludar
            // 
            this.btnSaludar.AccessibleDescription = "";
            this.btnSaludar.AccessibleName = "";
            this.btnSaludar.Location = new System.Drawing.Point(211, 129);
            this.btnSaludar.Name = "btnSaludar";
            this.btnSaludar.Size = new System.Drawing.Size(110, 51);
            this.btnSaludar.TabIndex = 0;
            this.btnSaludar.Text = "Lucho Putete";
            this.btnSaludar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 319);
            this.Controls.Add(this.btnSaludar);
            this.Name = "Form1";
            this.Text = "Primera App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSaludar;
    }
}
