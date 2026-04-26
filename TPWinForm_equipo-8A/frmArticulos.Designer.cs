namespace TPWinForm_equipo_8A
{
    partial class frmArticulos
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
            this.dgvListaArticulos = new System.Windows.Forms.DataGridView();
            this.pbxImagen = new System.Windows.Forms.PictureBox();
            this.lblFiltroRapido = new System.Windows.Forms.Label();
            this.txtFiltroRapido = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnFiltroAvanzado = new System.Windows.Forms.Button();
            this.pnlFiltroAvanzado = new System.Windows.Forms.Panel();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.lblCampo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblErrorImagen = new System.Windows.Forms.Label();
            this.btnAnteriorImagen = new System.Windows.Forms.Button();
            this.btnSiguienteImagen = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblQImagenes = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.labelCriterio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            this.pnlFiltroAvanzado.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListaArticulos
            // 
            this.dgvListaArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListaArticulos.Location = new System.Drawing.Point(61, 86);
            this.dgvListaArticulos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvListaArticulos.MultiSelect = false;
            this.dgvListaArticulos.Name = "dgvListaArticulos";
            this.dgvListaArticulos.ReadOnly = true;
            this.dgvListaArticulos.RowHeadersWidth = 51;
            this.dgvListaArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaArticulos.Size = new System.Drawing.Size(775, 288);
            this.dgvListaArticulos.TabIndex = 0;
            this.dgvListaArticulos.SelectionChanged += new System.EventHandler(this.dgvListaArticulos_SelectionChanged);
            // 
            // pbxImagen
            // 
            this.pbxImagen.Location = new System.Drawing.Point(844, 86);
            this.pbxImagen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.Size = new System.Drawing.Size(363, 288);
            this.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagen.TabIndex = 1;
            this.pbxImagen.TabStop = false;
            // 
            // lblFiltroRapido
            // 
            this.lblFiltroRapido.AutoSize = true;
            this.lblFiltroRapido.Location = new System.Drawing.Point(61, 53);
            this.lblFiltroRapido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltroRapido.Name = "lblFiltroRapido";
            this.lblFiltroRapido.Size = new System.Drawing.Size(36, 16);
            this.lblFiltroRapido.TabIndex = 2;
            this.lblFiltroRapido.Text = "Filtro";
            // 
            // txtFiltroRapido
            // 
            this.txtFiltroRapido.Location = new System.Drawing.Point(129, 48);
            this.txtFiltroRapido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFiltroRapido.Name = "txtFiltroRapido";
            this.txtFiltroRapido.Size = new System.Drawing.Size(235, 22);
            this.txtFiltroRapido.TabIndex = 3;
            this.txtFiltroRapido.TextChanged += new System.EventHandler(this.txtFiltroRapido_TextChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(480, 401);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 28);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(603, 401);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 28);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(736, 401);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 28);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnFiltroAvanzado
            // 
            this.btnFiltroAvanzado.Location = new System.Drawing.Point(61, 425);
            this.btnFiltroAvanzado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFiltroAvanzado.Name = "btnFiltroAvanzado";
            this.btnFiltroAvanzado.Size = new System.Drawing.Size(135, 28);
            this.btnFiltroAvanzado.TabIndex = 7;
            this.btnFiltroAvanzado.Text = "Filtro Avanzado";
            this.btnFiltroAvanzado.UseVisualStyleBackColor = true;
            this.btnFiltroAvanzado.Click += new System.EventHandler(this.btnFiltroAvanzado_Click);
            // 
            // pnlFiltroAvanzado
            // 
            this.pnlFiltroAvanzado.Controls.Add(this.labelCriterio);
            this.pnlFiltroAvanzado.Controls.Add(this.btnLimpiar);
            this.pnlFiltroAvanzado.Controls.Add(this.cboCriterio);
            this.pnlFiltroAvanzado.Controls.Add(this.cboCampo);
            this.pnlFiltroAvanzado.Controls.Add(this.btnBuscar);
            this.pnlFiltroAvanzado.Controls.Add(this.textBoxBuscar);
            this.pnlFiltroAvanzado.Controls.Add(this.lblCriterio);
            this.pnlFiltroAvanzado.Controls.Add(this.lblCampo);
            this.pnlFiltroAvanzado.Location = new System.Drawing.Point(61, 460);
            this.pnlFiltroAvanzado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlFiltroAvanzado.Name = "pnlFiltroAvanzado";
            this.pnlFiltroAvanzado.Size = new System.Drawing.Size(1145, 108);
            this.pnlFiltroAvanzado.TabIndex = 8;
            // 
            // cboCriterio
            // 
            this.cboCriterio.BackColor = System.Drawing.SystemColors.Window;
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(419, 41);
            this.cboCriterio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(160, 24);
            this.cboCriterio.TabIndex = 8;
            // 
            // cboCampo
            // 
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(127, 39);
            this.cboCampo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(160, 24);
            this.cboCampo.TabIndex = 7;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampo_SelectedIndexChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(847, 40);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 28);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(649, 41);
            this.textBoxBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(184, 22);
            this.textBoxBuscar.TabIndex = 4;
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(354, 46);
            this.lblCriterio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(49, 16);
            this.lblCriterio.TabIndex = 2;
            this.lblCriterio.Text = "Criterio";
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(61, 44);
            this.lblCampo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(51, 16);
            this.lblCampo.TabIndex = 0;
            this.lblCampo.Text = "Campo";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(1001, 11);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(192, 36);
            this.lblMarca.TabIndex = 9;
            this.lblMarca.Text = "ARTICULOS";
            // 
            // lblErrorImagen
            // 
            this.lblErrorImagen.AutoSize = true;
            this.lblErrorImagen.ForeColor = System.Drawing.Color.Brown;
            this.lblErrorImagen.Location = new System.Drawing.Point(844, 63);
            this.lblErrorImagen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErrorImagen.Name = "lblErrorImagen";
            this.lblErrorImagen.Size = new System.Drawing.Size(0, 16);
            this.lblErrorImagen.TabIndex = 10;
            // 
            // btnAnteriorImagen
            // 
            this.btnAnteriorImagen.Location = new System.Drawing.Point(999, 401);
            this.btnAnteriorImagen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnteriorImagen.Name = "btnAnteriorImagen";
            this.btnAnteriorImagen.Size = new System.Drawing.Size(100, 28);
            this.btnAnteriorImagen.TabIndex = 11;
            this.btnAnteriorImagen.Text = "Anterior";
            this.btnAnteriorImagen.UseVisualStyleBackColor = true;
            this.btnAnteriorImagen.Click += new System.EventHandler(this.btnAnteriorImagen_Click);
            // 
            // btnSiguienteImagen
            // 
            this.btnSiguienteImagen.Location = new System.Drawing.Point(1107, 401);
            this.btnSiguienteImagen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSiguienteImagen.Name = "btnSiguienteImagen";
            this.btnSiguienteImagen.Size = new System.Drawing.Size(100, 28);
            this.btnSiguienteImagen.TabIndex = 12;
            this.btnSiguienteImagen.Text = "Siguiente";
            this.btnSiguienteImagen.UseVisualStyleBackColor = true;
            this.btnSiguienteImagen.Click += new System.EventHandler(this.btnSiguienteImagen_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(844, 378);
            this.lbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(179, 18);
            this.lbl1.TabIndex = 13;
            this.lbl1.Text = "Cantidad de Imagenes:";
            // 
            // lblQImagenes
            // 
            this.lblQImagenes.AutoSize = true;
            this.lblQImagenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQImagenes.Location = new System.Drawing.Point(1060, 379);
            this.lblQImagenes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQImagenes.Name = "lblQImagenes";
            this.lblQImagenes.Size = new System.Drawing.Size(0, 18);
            this.lblQImagenes.TabIndex = 14;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(955, 40);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 28);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // labelCriterio
            // 
            this.labelCriterio.AutoSize = true;
            this.labelCriterio.Location = new System.Drawing.Point(416, 69);
            this.labelCriterio.Name = "labelCriterio";
            this.labelCriterio.Size = new System.Drawing.Size(177, 16);
            this.labelCriterio.TabIndex = 10;
            this.labelCriterio.Text = "*Falta seleccionar un Criterio";
            this.labelCriterio.Visible = false;
            // 
            // frmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1219, 566);
            this.Controls.Add(this.lblQImagenes);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnSiguienteImagen);
            this.Controls.Add(this.btnAnteriorImagen);
            this.Controls.Add(this.lblErrorImagen);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.pnlFiltroAvanzado);
            this.Controls.Add(this.btnFiltroAvanzado);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtFiltroRapido);
            this.Controls.Add(this.lblFiltroRapido);
            this.Controls.Add(this.pbxImagen);
            this.Controls.Add(this.dgvListaArticulos);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1237, 615);
            this.MinimumSize = new System.Drawing.Size(1237, 615);
            this.Name = "frmArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.frmArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
            this.pnlFiltroAvanzado.ResumeLayout(false);
            this.pnlFiltroAvanzado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaArticulos;
        private System.Windows.Forms.PictureBox pbxImagen;
        private System.Windows.Forms.Label lblFiltroRapido;
        private System.Windows.Forms.TextBox txtFiltroRapido;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnFiltroAvanzado;
        private System.Windows.Forms.Panel pnlFiltroAvanzado;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.ComboBox cboCriterio;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblErrorImagen;
        private System.Windows.Forms.Button btnAnteriorImagen;
        private System.Windows.Forms.Button btnSiguienteImagen;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblQImagenes;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label labelCriterio;
    }
}