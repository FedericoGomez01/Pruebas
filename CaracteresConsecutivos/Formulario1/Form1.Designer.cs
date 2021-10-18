
namespace Formulario1
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
            this.txtString = new System.Windows.Forms.TextBox();
            this.cmbCantidad = new System.Windows.Forms.ComboBox();
            this.lblString = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtConvertido = new System.Windows.Forms.TextBox();
            this.lblConvertido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtString
            // 
            this.txtString.Location = new System.Drawing.Point(249, 56);
            this.txtString.Name = "txtString";
            this.txtString.Size = new System.Drawing.Size(369, 27);
            this.txtString.TabIndex = 0;
            // 
            // cmbCantidad
            // 
            this.cmbCantidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCantidad.FormattingEnabled = true;
            this.cmbCantidad.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbCantidad.Location = new System.Drawing.Point(249, 112);
            this.cmbCantidad.Name = "cmbCantidad";
            this.cmbCantidad.Size = new System.Drawing.Size(100, 28);
            this.cmbCantidad.TabIndex = 1;
            // 
            // lblString
            // 
            this.lblString.AutoSize = true;
            this.lblString.Location = new System.Drawing.Point(12, 59);
            this.lblString.Name = "lblString";
            this.lblString.Size = new System.Drawing.Size(208, 20);
            this.lblString.TabIndex = 2;
            this.lblString.Text = "Ingrese una palabra o numero";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(46, 120);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(142, 20);
            this.lblCantidad.TabIndex = 3;
            this.lblCantidad.Text = "Seleccione cantidad";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(249, 182);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(149, 38);
            this.btnEnviar.TabIndex = 4;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtConvertido
            // 
            this.txtConvertido.Location = new System.Drawing.Point(249, 259);
            this.txtConvertido.Name = "txtConvertido";
            this.txtConvertido.ReadOnly = true;
            this.txtConvertido.Size = new System.Drawing.Size(369, 27);
            this.txtConvertido.TabIndex = 5;
            // 
            // lblConvertido
            // 
            this.lblConvertido.AutoSize = true;
            this.lblConvertido.Location = new System.Drawing.Point(56, 262);
            this.lblConvertido.Name = "lblConvertido";
            this.lblConvertido.Size = new System.Drawing.Size(122, 20);
            this.lblConvertido.TabIndex = 6;
            this.lblConvertido.Text = "Texto Convertido";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.lblConvertido);
            this.Controls.Add(this.txtConvertido);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblString);
            this.Controls.Add(this.cmbCantidad);
            this.Controls.Add(this.txtString);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtString;
        private System.Windows.Forms.ComboBox cmbCantidad;
        private System.Windows.Forms.Label lblString;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtConvertido;
        private System.Windows.Forms.Label lblConvertido;
    }
}

