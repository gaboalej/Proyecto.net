namespace TPFinalNivel2_Pelozo
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxFiltro = new System.Windows.Forms.TextBox();
            this.labelFiltroRapido = new System.Windows.Forms.Label();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.pictureBoxArticulos = new System.Windows.Forms.PictureBox();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.labelCampo = new System.Windows.Forms.Label();
            this.comboBoxCampo = new System.Windows.Forms.ComboBox();
            this.labelCriterio = new System.Windows.Forms.Label();
            this.comboBoxCriterio = new System.Windows.Forms.ComboBox();
            this.labelFiltroAvanzado = new System.Windows.Forms.Label();
            this.textBoxFiltroAvanzado = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonDetalles = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(37, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(993, 365);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // textBoxFiltro
            // 
            this.textBoxFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxFiltro.Location = new System.Drawing.Point(155, 17);
            this.textBoxFiltro.Name = "textBoxFiltro";
            this.textBoxFiltro.Size = new System.Drawing.Size(483, 22);
            this.textBoxFiltro.TabIndex = 1;
            this.textBoxFiltro.TextChanged += new System.EventHandler(this.textBoxFiltro_TextChanged);
            // 
            // labelFiltroRapido
            // 
            this.labelFiltroRapido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFiltroRapido.Location = new System.Drawing.Point(37, 13);
            this.labelFiltroRapido.Name = "labelFiltroRapido";
            this.labelFiltroRapido.Size = new System.Drawing.Size(112, 31);
            this.labelFiltroRapido.TabIndex = 2;
            this.labelFiltroRapido.Text = "Filtro Nombre";
            this.labelFiltroRapido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(729, 438);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(100, 32);
            this.buttonAgregar.TabIndex = 3;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // pictureBoxArticulos
            // 
            this.pictureBoxArticulos.Location = new System.Drawing.Point(1046, 12);
            this.pictureBoxArticulos.Name = "pictureBoxArticulos";
            this.pictureBoxArticulos.Size = new System.Drawing.Size(394, 420);
            this.pictureBoxArticulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxArticulos.TabIndex = 4;
            this.pictureBoxArticulos.TabStop = false;
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(851, 438);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(100, 32);
            this.buttonModificar.TabIndex = 5;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(978, 438);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(100, 32);
            this.buttonEliminar.TabIndex = 6;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // labelCampo
            // 
            this.labelCampo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCampo.Location = new System.Drawing.Point(12, 491);
            this.labelCampo.Name = "labelCampo";
            this.labelCampo.Size = new System.Drawing.Size(100, 31);
            this.labelCampo.TabIndex = 7;
            this.labelCampo.Text = "Campo";
            this.labelCampo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxCampo
            // 
            this.comboBoxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCampo.FormattingEnabled = true;
            this.comboBoxCampo.Location = new System.Drawing.Point(118, 495);
            this.comboBoxCampo.Name = "comboBoxCampo";
            this.comboBoxCampo.Size = new System.Drawing.Size(188, 24);
            this.comboBoxCampo.TabIndex = 8;
            this.comboBoxCampo.SelectedIndexChanged += new System.EventHandler(this.comboBoxCampo_SelectedIndexChanged);
            // 
            // labelCriterio
            // 
            this.labelCriterio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCriterio.Location = new System.Drawing.Point(321, 491);
            this.labelCriterio.Name = "labelCriterio";
            this.labelCriterio.Size = new System.Drawing.Size(100, 31);
            this.labelCriterio.TabIndex = 9;
            this.labelCriterio.Text = "Criterio";
            this.labelCriterio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxCriterio
            // 
            this.comboBoxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCriterio.FormattingEnabled = true;
            this.comboBoxCriterio.Location = new System.Drawing.Point(440, 495);
            this.comboBoxCriterio.Name = "comboBoxCriterio";
            this.comboBoxCriterio.Size = new System.Drawing.Size(188, 24);
            this.comboBoxCriterio.TabIndex = 10;
            // 
            // labelFiltroAvanzado
            // 
            this.labelFiltroAvanzado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFiltroAvanzado.Location = new System.Drawing.Point(644, 491);
            this.labelFiltroAvanzado.Name = "labelFiltroAvanzado";
            this.labelFiltroAvanzado.Size = new System.Drawing.Size(118, 31);
            this.labelFiltroAvanzado.TabIndex = 11;
            this.labelFiltroAvanzado.Text = "Filtro Avanzado";
            this.labelFiltroAvanzado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxFiltroAvanzado
            // 
            this.textBoxFiltroAvanzado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxFiltroAvanzado.Location = new System.Drawing.Point(768, 497);
            this.textBoxFiltroAvanzado.Name = "textBoxFiltroAvanzado";
            this.textBoxFiltroAvanzado.Size = new System.Drawing.Size(220, 22);
            this.textBoxFiltroAvanzado.TabIndex = 12;
            this.textBoxFiltroAvanzado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFiltroAvanzado_KeyPress);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(994, 492);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(100, 32);
            this.buttonBuscar.TabIndex = 13;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonDetalles
            // 
            this.buttonDetalles.Location = new System.Drawing.Point(611, 438);
            this.buttonDetalles.Name = "buttonDetalles";
            this.buttonDetalles.Size = new System.Drawing.Size(100, 32);
            this.buttonDetalles.TabIndex = 14;
            this.buttonDetalles.Text = "Ver Detalles";
            this.buttonDetalles.UseVisualStyleBackColor = true;
            this.buttonDetalles.Click += new System.EventHandler(this.buttonDetalles_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1478, 699);
            this.Controls.Add(this.buttonDetalles);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBoxFiltroAvanzado);
            this.Controls.Add(this.labelFiltroAvanzado);
            this.Controls.Add(this.comboBoxCriterio);
            this.Controls.Add(this.labelCriterio);
            this.Controls.Add(this.comboBoxCampo);
            this.Controls.Add(this.labelCampo);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.pictureBoxArticulos);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.labelFiltroRapido);
            this.Controls.Add(this.textBoxFiltro);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".NetAppComercio";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxFiltro;
        private System.Windows.Forms.Label labelFiltroRapido;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.PictureBox pictureBoxArticulos;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Label labelCampo;
        private System.Windows.Forms.ComboBox comboBoxCampo;
        private System.Windows.Forms.Label labelCriterio;
        private System.Windows.Forms.ComboBox comboBoxCriterio;
        private System.Windows.Forms.Label labelFiltroAvanzado;
        private System.Windows.Forms.TextBox textBoxFiltroAvanzado;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonDetalles;
    }
}

