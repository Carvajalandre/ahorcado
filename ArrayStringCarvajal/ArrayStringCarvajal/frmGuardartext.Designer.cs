namespace ArrayStringCarvajal
{
    partial class frmGuardartext
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
            this.lblDatos = new System.Windows.Forms.Label();
            this.txtGuardado = new System.Windows.Forms.TextBox();
            this.btnGuardartxt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGuardar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCargarArchivo = new System.Windows.Forms.Button();
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.Location = new System.Drawing.Point(545, 12);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(142, 15);
            this.lblDatos.TabIndex = 13;
            this.lblDatos.Text = "Datos Guardados en:";
            // 
            // txtGuardado
            // 
            this.txtGuardado.Location = new System.Drawing.Point(565, 44);
            this.txtGuardado.Multiline = true;
            this.txtGuardado.Name = "txtGuardado";
            this.txtGuardado.ReadOnly = true;
            this.txtGuardado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGuardado.Size = new System.Drawing.Size(223, 394);
            this.txtGuardado.TabIndex = 12;
            // 
            // btnGuardartxt
            // 
            this.btnGuardartxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardartxt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardartxt.Location = new System.Drawing.Point(456, 361);
            this.btnGuardartxt.Name = "btnGuardartxt";
            this.btnGuardartxt.Size = new System.Drawing.Size(74, 27);
            this.btnGuardartxt.TabIndex = 9;
            this.btnGuardartxt.Text = "Guardar";
            this.btnGuardartxt.UseVisualStyleBackColor = true;
            this.btnGuardartxt.Click += new System.EventHandler(this.btnGuardartxt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(432, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ingrese palabra o frace a aguardar en el archivo de texto";
            // 
            // txtGuardar
            // 
            this.txtGuardar.Location = new System.Drawing.Point(21, 306);
            this.txtGuardar.Multiline = true;
            this.txtGuardar.Name = "txtGuardar";
            this.txtGuardar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGuardar.Size = new System.Drawing.Size(429, 132);
            this.txtGuardar.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCargarArchivo);
            this.groupBox1.Controls.Add(this.txtArchivo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 74);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione La ruta donde se guardara el archivo de texto";
            // 
            // btnCargarArchivo
            // 
            this.btnCargarArchivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarArchivo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarArchivo.Location = new System.Drawing.Point(479, 32);
            this.btnCargarArchivo.Name = "btnCargarArchivo";
            this.btnCargarArchivo.Size = new System.Drawing.Size(39, 23);
            this.btnCargarArchivo.TabIndex = 2;
            this.btnCargarArchivo.Text = "...";
            this.btnCargarArchivo.UseVisualStyleBackColor = true;
            this.btnCargarArchivo.Click += new System.EventHandler(this.btnCargarArchivo_Click);
            // 
            // txtArchivo
            // 
            this.txtArchivo.Location = new System.Drawing.Point(6, 37);
            this.txtArchivo.Multiline = true;
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.Size = new System.Drawing.Size(467, 18);
            this.txtArchivo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del archivo seleccionado";
            // 
            // frmGuardartext
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.txtGuardado);
            this.Controls.Add(this.btnGuardartxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGuardar);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmGuardartext";
            this.Text = "frmGuardartext";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.TextBox txtGuardado;
        private System.Windows.Forms.Button btnGuardartxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGuardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCargarArchivo;
        private System.Windows.Forms.TextBox txtArchivo;
        private System.Windows.Forms.Label label1;
    }
}