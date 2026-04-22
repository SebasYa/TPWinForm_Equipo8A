namespace TPWinForm_equipo_8A
{
    partial class frmAltaImagen
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblUrlImagen = new System.Windows.Forms.Label();
            this.txtUrlAltaImagen = new System.Windows.Forms.TextBox();
            this.btnAdjuntarAltaImagen = new System.Windows.Forms.Button();
            this.dgvAltaImagen = new System.Windows.Forms.DataGridView();
            this.pbxAltaImagen = new System.Windows.Forms.PictureBox();
            this.btnAceptarAltaImagen = new System.Windows.Forms.Button();
            this.btnAgregarAltaImagen = new System.Windows.Forms.Button();
            this.btnModificarAltaImagen = new System.Windows.Forms.Button();
            this.btnEliminarAltaImagen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAltaImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAltaImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(678, 397);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblUrlImagen
            // 
            this.lblUrlImagen.AutoSize = true;
            this.lblUrlImagen.Location = new System.Drawing.Point(23, 45);
            this.lblUrlImagen.Name = "lblUrlImagen";
            this.lblUrlImagen.Size = new System.Drawing.Size(61, 13);
            this.lblUrlImagen.TabIndex = 1;
            this.lblUrlImagen.Text = "Url Imagen:";
            // 
            // txtUrlAltaImagen
            // 
            this.txtUrlAltaImagen.Location = new System.Drawing.Point(82, 41);
            this.txtUrlAltaImagen.Name = "txtUrlAltaImagen";
            this.txtUrlAltaImagen.Size = new System.Drawing.Size(265, 20);
            this.txtUrlAltaImagen.TabIndex = 2;
            this.txtUrlAltaImagen.Leave += new System.EventHandler(this.txtUrlAltaImagen_Leave);
            // 
            // btnAdjuntarAltaImagen
            // 
            this.btnAdjuntarAltaImagen.Location = new System.Drawing.Point(353, 41);
            this.btnAdjuntarAltaImagen.Name = "btnAdjuntarAltaImagen";
            this.btnAdjuntarAltaImagen.Size = new System.Drawing.Size(24, 23);
            this.btnAdjuntarAltaImagen.TabIndex = 3;
            this.btnAdjuntarAltaImagen.Text = "...";
            this.btnAdjuntarAltaImagen.UseVisualStyleBackColor = true;
            // 
            // dgvAltaImagen
            // 
            this.dgvAltaImagen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAltaImagen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAltaImagen.Location = new System.Drawing.Point(26, 82);
            this.dgvAltaImagen.Name = "dgvAltaImagen";
            this.dgvAltaImagen.Size = new System.Drawing.Size(351, 252);
            this.dgvAltaImagen.TabIndex = 4;
            this.dgvAltaImagen.SelectionChanged += new System.EventHandler(this.dgvAltaImagen_SelectionChanged);
            // 
            // pbxAltaImagen
            // 
            this.pbxAltaImagen.Location = new System.Drawing.Point(500, 24);
            this.pbxAltaImagen.Name = "pbxAltaImagen";
            this.pbxAltaImagen.Size = new System.Drawing.Size(253, 310);
            this.pbxAltaImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAltaImagen.TabIndex = 5;
            this.pbxAltaImagen.TabStop = false;
            // 
            // btnAceptarAltaImagen
            // 
            this.btnAceptarAltaImagen.Location = new System.Drawing.Point(576, 397);
            this.btnAceptarAltaImagen.Name = "btnAceptarAltaImagen";
            this.btnAceptarAltaImagen.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarAltaImagen.TabIndex = 6;
            this.btnAceptarAltaImagen.Text = "Aceptar";
            this.btnAceptarAltaImagen.UseVisualStyleBackColor = true;
            this.btnAceptarAltaImagen.Click += new System.EventHandler(this.btnAceptarAltaImagen_Click);
            // 
            // btnAgregarAltaImagen
            // 
            this.btnAgregarAltaImagen.Location = new System.Drawing.Point(396, 148);
            this.btnAgregarAltaImagen.Name = "btnAgregarAltaImagen";
            this.btnAgregarAltaImagen.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarAltaImagen.TabIndex = 7;
            this.btnAgregarAltaImagen.Text = "Agregar";
            this.btnAgregarAltaImagen.UseVisualStyleBackColor = true;
            this.btnAgregarAltaImagen.Click += new System.EventHandler(this.btnAgregarAltaImagen_Click);
            // 
            // btnModificarAltaImagen
            // 
            this.btnModificarAltaImagen.Location = new System.Drawing.Point(396, 196);
            this.btnModificarAltaImagen.Name = "btnModificarAltaImagen";
            this.btnModificarAltaImagen.Size = new System.Drawing.Size(75, 23);
            this.btnModificarAltaImagen.TabIndex = 8;
            this.btnModificarAltaImagen.Text = "Modificar";
            this.btnModificarAltaImagen.UseVisualStyleBackColor = true;
            this.btnModificarAltaImagen.Click += new System.EventHandler(this.btnModificarAltaImagen_Click);
            // 
            // btnEliminarAltaImagen
            // 
            this.btnEliminarAltaImagen.Location = new System.Drawing.Point(396, 244);
            this.btnEliminarAltaImagen.Name = "btnEliminarAltaImagen";
            this.btnEliminarAltaImagen.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarAltaImagen.TabIndex = 9;
            this.btnEliminarAltaImagen.Text = "Eliminar";
            this.btnEliminarAltaImagen.UseVisualStyleBackColor = true;
            this.btnEliminarAltaImagen.Click += new System.EventHandler(this.btnEliminarAltaImagen_Click);
            // 
            // frmAltaImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminarAltaImagen);
            this.Controls.Add(this.btnModificarAltaImagen);
            this.Controls.Add(this.btnAgregarAltaImagen);
            this.Controls.Add(this.btnAceptarAltaImagen);
            this.Controls.Add(this.pbxAltaImagen);
            this.Controls.Add(this.dgvAltaImagen);
            this.Controls.Add(this.btnAdjuntarAltaImagen);
            this.Controls.Add(this.txtUrlAltaImagen);
            this.Controls.Add(this.lblUrlImagen);
            this.Controls.Add(this.btnCancelar);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "frmAltaImagen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAltaImagen";
            this.Load += new System.EventHandler(this.frmAltaImagen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAltaImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAltaImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblUrlImagen;
        private System.Windows.Forms.TextBox txtUrlAltaImagen;
        private System.Windows.Forms.Button btnAdjuntarAltaImagen;
        private System.Windows.Forms.DataGridView dgvAltaImagen;
        private System.Windows.Forms.PictureBox pbxAltaImagen;
        private System.Windows.Forms.Button btnAceptarAltaImagen;
        private System.Windows.Forms.Button btnAgregarAltaImagen;
        private System.Windows.Forms.Button btnModificarAltaImagen;
        private System.Windows.Forms.Button btnEliminarAltaImagen;
    }
}