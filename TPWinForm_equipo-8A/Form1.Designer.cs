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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMarcas
            // 
            this.btnMarcas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMarcas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarcas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarcas.Location = new System.Drawing.Point(103, 109);
            this.btnMarcas.Name = "btnMarcas";
            this.btnMarcas.Size = new System.Drawing.Size(168, 73);
            this.btnMarcas.TabIndex = 0;
            this.btnMarcas.Text = "GESTIÓN DE MARCAS";
            this.btnMarcas.UseVisualStyleBackColor = false;
            this.btnMarcas.Click += new System.EventHandler(this.btnMarcas_Click);
            // 
            // btnArticulos
            // 
            this.btnArticulos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnArticulos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArticulos.Location = new System.Drawing.Point(344, 22);
            this.btnArticulos.Name = "btnArticulos";
            this.btnArticulos.Size = new System.Drawing.Size(168, 73);
            this.btnArticulos.TabIndex = 1;
            this.btnArticulos.Text = "GESTIÓN DE ARTICULOS";
            this.btnArticulos.UseVisualStyleBackColor = false;
            this.btnArticulos.Click += new System.EventHandler(this.btnArticulos_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorias.Location = new System.Drawing.Point(586, 109);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(168, 73);
            this.btnCategorias.TabIndex = 2;
            this.btnCategorias.Text = "GESTIÓN DE CATEGORIAS";
            this.btnCategorias.UseVisualStyleBackColor = false;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // lklblSY
            // 
            this.lklblSY.AutoSize = true;
            this.lklblSY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklblSY.Location = new System.Drawing.Point(729, 52);
            this.lklblSY.Name = "lklblSY";
            this.lklblSY.Size = new System.Drawing.Size(111, 17);
            this.lklblSY.TabIndex = 7;
            this.lklblSY.TabStop = true;
            this.lklblSY.Text = "Sebastian Yanni";
            this.lklblSY.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklblSY_LinkClicked);
            // 
            // lklblMB
            // 
            this.lklblMB.AutoSize = true;
            this.lklblMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklblMB.Location = new System.Drawing.Point(12, 52);
            this.lklblMB.Name = "lklblMB";
            this.lklblMB.Size = new System.Drawing.Size(130, 17);
            this.lklblMB.TabIndex = 8;
            this.lklblMB.TabStop = true;
            this.lklblMB.Text = "Maximiliano Bianchi";
            this.lklblMB.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklblMB_LinkClicked);
            // 
            // lklblMRB
            // 
            this.lklblMRB.AutoSize = true;
            this.lklblMRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklblMRB.Location = new System.Drawing.Point(342, 52);
            this.lklblMRB.Name = "lklblMRB";
            this.lklblMRB.Size = new System.Drawing.Size(159, 17);
            this.lklblMRB.TabIndex = 9;
            this.lklblMRB.TabStop = true;
            this.lklblMRB.Text = "Marcelo Rearte Becerra";
            this.lklblMRB.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklblMRB_LinkClicked);
            // 
            // lklblRepo
            // 
            this.lklblRepo.AutoSize = true;
            this.lklblRepo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklblRepo.Location = new System.Drawing.Point(12, 245);
            this.lklblRepo.Name = "lklblRepo";
            this.lklblRepo.Size = new System.Drawing.Size(163, 17);
            this.lklblRepo.TabIndex = 10;
            this.lklblRepo.TabStop = true;
            this.lklblRepo.Text = "Repositorio del Proyecto";
            this.lklblRepo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklblRepo_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lklblSY);
            this.panel1.Controls.Add(this.lklblMRB);
            this.panel1.Controls.Add(this.lklblMB);
            this.panel1.Location = new System.Drawing.Point(0, 277);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 83);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(318, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Desarrollado por Equipo 8A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "EQUIPO 8A";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(867, 360);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lklblRepo);
            this.Controls.Add(this.btnCategorias);
            this.Controls.Add(this.btnArticulos);
            this.Controls.Add(this.btnMarcas);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

