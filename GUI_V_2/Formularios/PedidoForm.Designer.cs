namespace GUI_V_2.Formularios
{
    partial class PedidoForm
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewPedidos = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnXLSExport = new System.Windows.Forms.Button();
            this.btnPDFExport = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(832, 137);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(180, 60);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "AÑADIR";
            this.btnAdd.UseVisualStyleBackColor = true;
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
            // dataGridViewPedidos
            // 
            this.dataGridViewPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPedidos.Location = new System.Drawing.Point(21, 137);
            this.dataGridViewPedidos.Name = "dataGridViewPedidos";
            this.dataGridViewPedidos.RowHeadersWidth = 51;
            this.dataGridViewPedidos.RowTemplate.Height = 24;
            this.dataGridViewPedidos.Size = new System.Drawing.Size(773, 425);
            this.dataGridViewPedidos.TabIndex = 20;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(294, -3);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(500, 48);
            this.lblTitulo.TabIndex = 22;
            this.lblTitulo.Text = "REGISTRO DE PEDIDOS";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(264, 18);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(364, 29);
            this.txtBuscar.TabIndex = 0;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(832, 68);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(180, 60);
            this.btnListar.TabIndex = 29;
            this.btnListar.Text = "VER MESAS";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // btnXLSExport
            // 
            this.btnXLSExport.Location = new System.Drawing.Point(832, 502);
            this.btnXLSExport.Name = "btnXLSExport";
            this.btnXLSExport.Size = new System.Drawing.Size(180, 60);
            this.btnXLSExport.TabIndex = 28;
            this.btnXLSExport.Text = "EXPORTAR XLSXX";
            this.btnXLSExport.UseVisualStyleBackColor = true;
            // 
            // btnPDFExport
            // 
            this.btnPDFExport.Location = new System.Drawing.Point(832, 436);
            this.btnPDFExport.Name = "btnPDFExport";
            this.btnPDFExport.Size = new System.Drawing.Size(180, 60);
            this.btnPDFExport.TabIndex = 27;
            this.btnPDFExport.Text = "EXPORTAR PDF";
            this.btnPDFExport.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(832, 335);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(180, 60);
            this.btnQuit.TabIndex = 26;
            this.btnQuit.Text = "QUITAR";
            this.btnQuit.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(832, 269);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(180, 60);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "MODIFICAR";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(832, 203);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 60);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "GUARDAR";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Location = new System.Drawing.Point(21, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 63);
            this.panel1.TabIndex = 23;
            // 
            // PedidoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 558);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridViewPedidos);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnXLSExport);
            this.Controls.Add(this.btnPDFExport);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel1);
            this.Name = "PedidoForm";
            this.Text = "PedidoForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewPedidos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnXLSExport;
        private System.Windows.Forms.Button btnPDFExport;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
    }
}