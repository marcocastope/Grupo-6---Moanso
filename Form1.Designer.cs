
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
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEdad = new System.Windows.Forms.TextBox();

            this.lblNombre = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.cmbSexo = new System.Windows.Forms.ComboBox();

            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(152, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "MOANSO TAREA 2";
            // 
            // textBoxNombre
            // 

            this.textBoxNombre.Location = new System.Drawing.Point(152, 107);

            this.textBoxNombre.Location = new System.Drawing.Point(98, 83);

            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(162, 23);
            this.textBoxNombre.TabIndex = 1;
            // 
            // btnRegistrar
            // 

            this.btnRegistrar.Location = new System.Drawing.Point(151, 254);

            this.btnRegistrar.Location = new System.Drawing.Point(364, 115);

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

            this.listViewDatos.Location = new System.Drawing.Point(152, 322);

            this.listViewDatos.Location = new System.Drawing.Point(26, 273);

            this.listViewDatos.Name = "listViewDatos";
            this.listViewDatos.Size = new System.Drawing.Size(566, 97);
            this.listViewDatos.TabIndex = 3;
            this.listViewDatos.UseCompatibleStateImageBehavior = false;

            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(152, 83);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(51, 15);
            this.labelNombre.TabIndex = 4;
            this.labelNombre.Text = "Nombre";
            this.labelNombre.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(152, 163);

            this.listViewDatos.SelectedIndexChanged += new System.EventHandler(this.listViewDatos_SelectedIndexChanged);
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(98, 125);

            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(162, 23);
            this.textBoxApellido.TabIndex = 1;
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;

            this.labelApellido.Location = new System.Drawing.Point(152, 144);

            this.labelApellido.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelApellido.Location = new System.Drawing.Point(26, 128);

            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(56, 17);
            this.labelApellido.TabIndex = 4;
            this.labelApellido.Text = "Apellido";
            this.labelApellido.Click += new System.EventHandler(this.label2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;

            this.label2.Location = new System.Drawing.Point(152, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);

            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(26, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);

            this.label2.TabIndex = 5;
            this.label2.Text = "Edad";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // textBoxEdad
            // 

            this.textBoxEdad.Location = new System.Drawing.Point(152, 213);

            this.textBoxEdad.Location = new System.Drawing.Point(98, 166);

            this.textBoxEdad.Name = "textBoxEdad";
            this.textBoxEdad.Size = new System.Drawing.Size(162, 23);
            this.textBoxEdad.TabIndex = 6;
            // 

            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(26, 90);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(57, 17);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSexo.Location = new System.Drawing.Point(26, 210);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(36, 17);
            this.lblSexo.TabIndex = 8;
            this.lblSexo.Text = "Sexo";
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Location = new System.Drawing.Point(98, 209);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(121, 23);
            this.cmbSexo.TabIndex = 9;
            this.cmbSexo.Text = "Seleccione";
            // 

            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize = new System.Drawing.Size(800, 450);

            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(628, 450);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblNombre);

            this.Controls.Add(this.textBoxEdad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelApellido);
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
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEdad;

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.ComboBox cmbSexo;
    }
}

