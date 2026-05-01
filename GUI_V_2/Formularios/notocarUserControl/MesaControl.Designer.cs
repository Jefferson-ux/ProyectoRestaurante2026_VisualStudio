namespace GUI_V_2.Formularios
{
    partial class MesaControl
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnPDFExport = new System.Windows.Forms.Button();
            this.btnXLSExport = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewMesa = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMesa)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Location = new System.Drawing.Point(25, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 63);
            this.panel1.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(836, 225);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 60);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "GUARDAR";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(836, 291);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(180, 60);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "MODIFICAR";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(836, 357);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(180, 60);
            this.btnQuit.TabIndex = 6;
            this.btnQuit.Text = "QUITAR";
            this.btnQuit.UseVisualStyleBackColor = true;
            // 
            // btnPDFExport
            // 
            this.btnPDFExport.Location = new System.Drawing.Point(836, 458);
            this.btnPDFExport.Name = "btnPDFExport";
            this.btnPDFExport.Size = new System.Drawing.Size(180, 60);
            this.btnPDFExport.TabIndex = 7;
            this.btnPDFExport.Text = "EXPORTAR PDF";
            this.btnPDFExport.UseVisualStyleBackColor = true;
            // 
            // btnXLSExport
            // 
            this.btnXLSExport.Location = new System.Drawing.Point(836, 524);
            this.btnXLSExport.Name = "btnXLSExport";
            this.btnXLSExport.Size = new System.Drawing.Size(180, 60);
            this.btnXLSExport.TabIndex = 8;
            this.btnXLSExport.Text = "EXPORTAR XLSXX";
            this.btnXLSExport.UseVisualStyleBackColor = true;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(836, 90);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(180, 60);
            this.btnListar.TabIndex = 9;
            this.btnListar.Text = "VER MESAS";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(264, 18);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(364, 29);
            this.txtBuscar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(129, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "BUSCAR: ";
            // 
            // dataGridViewMesa
            // 
            this.dataGridViewMesa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMesa.Location = new System.Drawing.Point(25, 159);
            this.dataGridViewMesa.Name = "dataGridViewMesa";
            this.dataGridViewMesa.RowHeadersWidth = 51;
            this.dataGridViewMesa.RowTemplate.Height = 24;
            this.dataGridViewMesa.Size = new System.Drawing.Size(773, 425);
            this.dataGridViewMesa.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(363, 14);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(455, 48);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "REGISTRO DE MESAS";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(836, 159);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(180, 60);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "AÑADIR";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // MesaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnXLSExport);
            this.Controls.Add(this.btnPDFExport);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dataGridViewMesa);
            this.Name = "MesaControl";
            this.Size = new System.Drawing.Size(1050, 605);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMesa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnPDFExport;
        private System.Windows.Forms.Button btnXLSExport;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridView dataGridViewMesa;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAdd;
    }
}
