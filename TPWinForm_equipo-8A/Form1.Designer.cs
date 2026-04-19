namespace TPWinForm_equipo_8A
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
            this.btnMarcas = new System.Windows.Forms.Button();
            this.btnArticulos = new System.Windows.Forms.Button();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMarcas
            // 
            this.btnMarcas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMarcas.Location = new System.Drawing.Point(80, 209);
            this.btnMarcas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMarcas.Name = "btnMarcas";
            this.btnMarcas.Size = new System.Drawing.Size(224, 90);
            this.btnMarcas.TabIndex = 0;
            this.btnMarcas.Text = "MARCAS";
            this.btnMarcas.UseVisualStyleBackColor = false;
            this.btnMarcas.Click += new System.EventHandler(this.btnMarcas_Click);
            // 
            // btnArticulos
            // 
            this.btnArticulos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnArticulos.Location = new System.Drawing.Point(383, 62);
            this.btnArticulos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnArticulos.Name = "btnArticulos";
            this.btnArticulos.Size = new System.Drawing.Size(224, 90);
            this.btnArticulos.TabIndex = 1;
            this.btnArticulos.Text = "ARTICULOS";
            this.btnArticulos.UseVisualStyleBackColor = false;
            this.btnArticulos.Click += new System.EventHandler(this.btnArticulos_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCategorias.Location = new System.Drawing.Point(683, 209);
            this.btnCategorias.Margin = new System.Windows.Forms.Padding(4);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(224, 90);
            this.btnCategorias.TabIndex = 2;
            this.btnCategorias.Text = "CATEGORIAS";
            this.btnCategorias.UseVisualStyleBackColor = false;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 535);
            this.Controls.Add(this.btnCategorias);
            this.Controls.Add(this.btnArticulos);
            this.Controls.Add(this.btnMarcas);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMarcas;
        private System.Windows.Forms.Button btnArticulos;
        private System.Windows.Forms.Button btnCategorias;
    }
}

