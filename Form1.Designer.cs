﻿
namespace MoansoTarea2
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
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.listViewDatos = new System.Windows.Forms.ListView();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.labelApellido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(274, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "MOANSO TAREA 2";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(152, 115);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(162, 23);
            this.textBoxNombre.TabIndex = 1;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(152, 217);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(162, 41);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // listViewDatos
            // 
            this.listViewDatos.HideSelection = false;
            this.listViewDatos.Location = new System.Drawing.Point(152, 300);
            this.listViewDatos.Name = "listViewDatos";
            this.listViewDatos.Size = new System.Drawing.Size(566, 97);
            this.listViewDatos.TabIndex = 3;
            this.listViewDatos.UseCompatibleStateImageBehavior = false;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(152, 97);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(51, 15);
            this.labelNombre.TabIndex = 4;
            this.labelNombre.Text = "Nombre";
            this.labelNombre.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(152, 170);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(162, 23);
            this.textBoxApellido.TabIndex = 1;
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(152, 152);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(51, 15);
            this.labelApellido.TabIndex = 4;
            this.labelApellido.Text = "Apellido";
            this.labelApellido.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.listViewDatos);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ListView listViewDatos;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Label labelApellido;
    }
}
