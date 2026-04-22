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
            this.lklblSY = new System.Windows.Forms.LinkLabel();
            this.lklblMB = new System.Windows.Forms.LinkLabel();
            this.lklblMRB = new System.Windows.Forms.LinkLabel();
            this.lklblRepo = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnMarcas
            // 
            this.btnMarcas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMarcas.Location = new System.Drawing.Point(102, 159);
            this.btnMarcas.Name = "btnMarcas";
            this.btnMarcas.Size = new System.Drawing.Size(168, 73);
            this.btnMarcas.TabIndex = 0;
            this.btnMarcas.Text = "MARCAS";
            this.btnMarcas.UseVisualStyleBackColor = false;
            this.btnMarcas.Click += new System.EventHandler(this.btnMarcas_Click);
            // 
            // btnArticulos
            // 
            this.btnArticulos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnArticulos.Location = new System.Drawing.Point(350, 27);
            this.btnArticulos.Name = "btnArticulos";
            this.btnArticulos.Size = new System.Drawing.Size(168, 73);
            this.btnArticulos.TabIndex = 1;
            this.btnArticulos.Text = "ARTICULOS";
            this.btnArticulos.UseVisualStyleBackColor = false;
            this.btnArticulos.Click += new System.EventHandler(this.btnArticulos_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCategorias.Location = new System.Drawing.Point(598, 159);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(168, 73);
            this.btnCategorias.TabIndex = 2;
            this.btnCategorias.Text = "CATEGORIAS";
            this.btnCategorias.UseVisualStyleBackColor = false;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // lklblSY
            // 
            this.lklblSY.AutoSize = true;
            this.lklblSY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklblSY.Location = new System.Drawing.Point(729, 265);
            this.lklblSY.Name = "lklblSY";
            this.lklblSY.Size = new System.Drawing.Size(126, 20);
            this.lklblSY.TabIndex = 7;
            this.lklblSY.TabStop = true;
            this.lklblSY.Text = "Sebastian Yanni";
            this.lklblSY.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklblSY_LinkClicked);
            // 
            // lklblMB
            // 
            this.lklblMB.AutoSize = true;
            this.lklblMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklblMB.Location = new System.Drawing.Point(709, 298);
            this.lklblMB.Name = "lklblMB";
            this.lklblMB.Size = new System.Drawing.Size(146, 20);
            this.lklblMB.TabIndex = 8;
            this.lklblMB.TabStop = true;
            this.lklblMB.Text = "Maximiliano Bianchi";
            this.lklblMB.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklblMB_LinkClicked);
            // 
            // lklblMRB
            // 
            this.lklblMRB.AutoSize = true;
            this.lklblMRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklblMRB.Location = new System.Drawing.Point(668, 331);
            this.lklblMRB.Name = "lklblMRB";
            this.lklblMRB.Size = new System.Drawing.Size(187, 20);
            this.lklblMRB.TabIndex = 9;
            this.lklblMRB.TabStop = true;
            this.lklblMRB.Text = "Marecelo Rearte Becerra";
            this.lklblMRB.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklblMRB_LinkClicked);
            // 
            // lklblRepo
            // 
            this.lklblRepo.AutoSize = true;
            this.lklblRepo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklblRepo.Location = new System.Drawing.Point(23, 331);
            this.lklblRepo.Name = "lklblRepo";
            this.lklblRepo.Size = new System.Drawing.Size(90, 20);
            this.lklblRepo.TabIndex = 10;
            this.lklblRepo.TabStop = true;
            this.lklblRepo.Text = "Repositorio";
            this.lklblRepo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklblRepo_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(867, 360);
            this.Controls.Add(this.lklblRepo);
            this.Controls.Add(this.lklblMRB);
            this.Controls.Add(this.lklblMB);
            this.Controls.Add(this.lklblSY);
            this.Controls.Add(this.btnCategorias);
            this.Controls.Add(this.btnArticulos);
            this.Controls.Add(this.btnMarcas);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMarcas;
        private System.Windows.Forms.Button btnArticulos;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.LinkLabel lklblSY;
        private System.Windows.Forms.LinkLabel lklblMB;
        private System.Windows.Forms.LinkLabel lklblMRB;
        private System.Windows.Forms.LinkLabel lklblRepo;
    }
}

