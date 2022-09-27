namespace RepasoParcial
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtFechaNacimiento = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.btPersona = new System.Windows.Forms.Button();
            this.btEdad = new System.Windows.Forms.Button();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblMostrarEdad = new System.Windows.Forms.Label();
            this.lblPersona = new System.Windows.Forms.Label();
            this.lblDatosPersona = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(253, 71);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 23);
            this.txtNombre.TabIndex = 0;
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Location = new System.Drawing.Point(253, 179);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(100, 23);
            this.txtFechaNacimiento.TabIndex = 1;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(253, 123);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(100, 23);
            this.txtDNI.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(59, 69);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(59, 131);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(27, 15);
            this.lblDni.TabIndex = 4;
            this.lblDni.Text = "DNI";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(59, 187);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(103, 15);
            this.lblFechaNacimiento.TabIndex = 5;
            this.lblFechaNacimiento.Text = "Fecha Nacimiento";
            // 
            // btPersona
            // 
            this.btPersona.Location = new System.Drawing.Point(422, 72);
            this.btPersona.Name = "btPersona";
            this.btPersona.Size = new System.Drawing.Size(75, 23);
            this.btPersona.TabIndex = 6;
            this.btPersona.Text = "Cargar";
            this.btPersona.UseVisualStyleBackColor = true;
            this.btPersona.Click += new System.EventHandler(this.btPersona_Click);
            // 
            // btEdad
            // 
            this.btEdad.Location = new System.Drawing.Point(422, 178);
            this.btEdad.Name = "btEdad";
            this.btEdad.Size = new System.Drawing.Size(75, 23);
            this.btEdad.TabIndex = 7;
            this.btEdad.Text = "Edad";
            this.btEdad.UseVisualStyleBackColor = true;
            this.btEdad.Click += new System.EventHandler(this.btEdad_Click);
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(59, 332);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(36, 15);
            this.lblEdad.TabIndex = 8;
            this.lblEdad.Text = "Edad:";
            // 
            // lblMostrarEdad
            // 
            this.lblMostrarEdad.AutoSize = true;
            this.lblMostrarEdad.Location = new System.Drawing.Point(353, 332);
            this.lblMostrarEdad.Name = "lblMostrarEdad";
            this.lblMostrarEdad.Size = new System.Drawing.Size(0, 15);
            this.lblMostrarEdad.TabIndex = 9;
            // 
            // lblPersona
            // 
            this.lblPersona.AutoSize = true;
            this.lblPersona.Location = new System.Drawing.Point(59, 398);
            this.lblPersona.Name = "lblPersona";
            this.lblPersona.Size = new System.Drawing.Size(52, 15);
            this.lblPersona.TabIndex = 10;
            this.lblPersona.Text = "Persona:";
            // 
            // lblDatosPersona
            // 
            this.lblDatosPersona.AutoSize = true;
            this.lblDatosPersona.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDatosPersona.Location = new System.Drawing.Point(301, 398);
            this.lblDatosPersona.Name = "lblDatosPersona";
            this.lblDatosPersona.Size = new System.Drawing.Size(2, 17);
            this.lblDatosPersona.TabIndex = 11;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 449);
            this.Controls.Add(this.lblDatosPersona);
            this.Controls.Add(this.lblPersona);
            this.Controls.Add(this.lblMostrarEdad);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.btEdad);
            this.Controls.Add(this.btPersona);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.txtFechaNacimiento);
            this.Controls.Add(this.txtNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtFechaNacimiento;
        private TextBox txtDNI;
        private Label lblNombre;
        private Label lblDni;
        private Label lblFechaNacimiento;
        private Button btPersona;
        private Button btEdad;
        private Label lblEdad;
        private Label lblMostrarEdad;
        private Label lblPersona;
        private Label lblDatosPersona;
        private ErrorProvider errorProvider1;
    }
}