
namespace Unir_Excels
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgvMuestra = new System.Windows.Forms.DataGridView();
            this.btnAgregarExcel = new System.Windows.Forms.Button();
            this.BtCrearCombinado = new System.Windows.Forms.Button();
            this.btnGuardarExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestra)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMuestra
            // 
            this.dgvMuestra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMuestra.Location = new System.Drawing.Point(34, 82);
            this.dgvMuestra.Name = "dgvMuestra";
            this.dgvMuestra.RowHeadersWidth = 51;
            this.dgvMuestra.RowTemplate.Height = 29;
            this.dgvMuestra.Size = new System.Drawing.Size(891, 265);
            this.dgvMuestra.TabIndex = 0;
            // 
            // btnAgregarExcel
            // 
            this.btnAgregarExcel.Location = new System.Drawing.Point(34, 22);
            this.btnAgregarExcel.Name = "btnAgregarExcel";
            this.btnAgregarExcel.Size = new System.Drawing.Size(367, 49);
            this.btnAgregarExcel.TabIndex = 1;
            this.btnAgregarExcel.Text = "Seleccionar Excel que Desea Agregar";
            this.btnAgregarExcel.UseVisualStyleBackColor = true;
            this.btnAgregarExcel.Click += new System.EventHandler(this.btnAgregarExcel_Click);
            // 
            // BtCrearCombinado
            // 
            this.BtCrearCombinado.Location = new System.Drawing.Point(700, 355);
            this.BtCrearCombinado.Name = "BtCrearCombinado";
            this.BtCrearCombinado.Size = new System.Drawing.Size(225, 60);
            this.BtCrearCombinado.TabIndex = 2;
            this.BtCrearCombinado.Text = "Crear Excel Conjunto";
            this.BtCrearCombinado.UseVisualStyleBackColor = true;
            this.BtCrearCombinado.Click += new System.EventHandler(this.BtCrearCombinado_Click);
            // 
            // btnGuardarExcel
            // 
            this.btnGuardarExcel.Location = new System.Drawing.Point(700, 22);
            this.btnGuardarExcel.Name = "btnGuardarExcel";
            this.btnGuardarExcel.Size = new System.Drawing.Size(225, 49);
            this.btnGuardarExcel.TabIndex = 3;
            this.btnGuardarExcel.Text = "Guardar este excel para combinarlo";
            this.btnGuardarExcel.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 427);
            this.Controls.Add(this.btnGuardarExcel);
            this.Controls.Add(this.BtCrearCombinado);
            this.Controls.Add(this.btnAgregarExcel);
            this.Controls.Add(this.dgvMuestra);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Creador de Excel Conjuntos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMuestra;
        private System.Windows.Forms.Button btnAgregarExcel;
        private System.Windows.Forms.Button BtCrearCombinado;
        private System.Windows.Forms.Button btnGuardarExcel;
    }
}

