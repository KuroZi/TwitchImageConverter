namespace RedimensionarImagen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnRutaInicial = new System.Windows.Forms.Button();
            this.txtRutaFinal = new System.Windows.Forms.TextBox();
            this.btnRutaFinal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.cBoxTamaños = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.btnLimpiarLista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ruta Inicial";
            // 
            // btnRutaInicial
            // 
            this.btnRutaInicial.Location = new System.Drawing.Point(155, 18);
            this.btnRutaInicial.Name = "btnRutaInicial";
            this.btnRutaInicial.Size = new System.Drawing.Size(75, 23);
            this.btnRutaInicial.TabIndex = 1;
            this.btnRutaInicial.Text = "Examinar";
            this.btnRutaInicial.UseVisualStyleBackColor = true;
            this.btnRutaInicial.Click += new System.EventHandler(this.btnImagenInicial_Click);
            // 
            // txtRutaFinal
            // 
            this.txtRutaFinal.Location = new System.Drawing.Point(21, 407);
            this.txtRutaFinal.Name = "txtRutaFinal";
            this.txtRutaFinal.ReadOnly = true;
            this.txtRutaFinal.Size = new System.Drawing.Size(329, 20);
            this.txtRutaFinal.TabIndex = 5;
            // 
            // btnRutaFinal
            // 
            this.btnRutaFinal.Location = new System.Drawing.Point(155, 371);
            this.btnRutaFinal.Name = "btnRutaFinal";
            this.btnRutaFinal.Size = new System.Drawing.Size(75, 23);
            this.btnRutaFinal.TabIndex = 4;
            this.btnRutaFinal.Text = "Examinar";
            this.btnRutaFinal.UseVisualStyleBackColor = true;
            this.btnRutaFinal.Click += new System.EventHandler(this.btnRutaFinal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ruta Final";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(21, 522);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(329, 23);
            this.btnGenerar.TabIndex = 6;
            this.btnGenerar.Text = "Generar Emoticon Twitch";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // cBoxTamaños
            // 
            this.cBoxTamaños.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxTamaños.FormattingEnabled = true;
            this.cBoxTamaños.Location = new System.Drawing.Point(21, 475);
            this.cBoxTamaños.Name = "cBoxTamaños";
            this.cBoxTamaños.Size = new System.Drawing.Size(329, 21);
            this.cBoxTamaños.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(18, 444);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tipo de Emoticono";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(21, 55);
            this.listBox.Name = "listBox";
            this.listBox.ScrollAlwaysVisible = true;
            this.listBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox.Size = new System.Drawing.Size(329, 290);
            this.listBox.TabIndex = 11;
            // 
            // btnLimpiarLista
            // 
            this.btnLimpiarLista.Location = new System.Drawing.Point(275, 19);
            this.btnLimpiarLista.Name = "btnLimpiarLista";
            this.btnLimpiarLista.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarLista.TabIndex = 12;
            this.btnLimpiarLista.Text = "Limpiar Lista";
            this.btnLimpiarLista.UseVisualStyleBackColor = true;
            this.btnLimpiarLista.Click += new System.EventHandler(this.btnLimpiarLista_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(372, 564);
            this.Controls.Add(this.btnLimpiarLista);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cBoxTamaños);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtRutaFinal);
            this.Controls.Add(this.btnRutaFinal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRutaInicial);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "AkiMori Changer Image Size";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRutaInicial;
        private System.Windows.Forms.TextBox txtRutaFinal;
        private System.Windows.Forms.Button btnRutaFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.ComboBox cBoxTamaños;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button btnLimpiarLista;
    }
}

