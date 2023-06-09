namespace TPFinalNivel2_Pelozo
{
    partial class Form2
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
            this.labelCodigo = new System.Windows.Forms.Label();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.labelIdMarca = new System.Windows.Forms.Label();
            this.labelIdCategoria = new System.Windows.Forms.Label();
            this.labelImagenUrl = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.textBoxImagenUrl = new System.Windows.Forms.TextBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.labelMarca = new System.Windows.Forms.Label();
            this.comboBoxMarcaDescripcion = new System.Windows.Forms.ComboBox();
            this.comboBoxIdMarca = new System.Windows.Forms.ComboBox();
            this.comboBoxIdCategoria = new System.Windows.Forms.ComboBox();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.comboBoxCategoriaDescripcion = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelCodigo
            // 
            this.labelCodigo.BackColor = System.Drawing.Color.Honeydew;
            this.labelCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCodigo.Location = new System.Drawing.Point(41, 9);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(100, 23);
            this.labelCodigo.TabIndex = 0;
            this.labelCodigo.Text = "Codigo";
            this.labelCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxCodigo.Location = new System.Drawing.Point(147, 12);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(253, 22);
            this.textBoxCodigo.TabIndex = 1;
            this.textBoxCodigo.TextChanged += new System.EventHandler(this.textBoxCodigo_TextChanged);
            // 
            // labelNombre
            // 
            this.labelNombre.BackColor = System.Drawing.Color.Honeydew;
            this.labelNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNombre.Location = new System.Drawing.Point(41, 55);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(100, 23);
            this.labelNombre.TabIndex = 2;
            this.labelNombre.Text = "Nombre";
            this.labelNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxNombre.Location = new System.Drawing.Point(147, 56);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(253, 22);
            this.textBoxNombre.TabIndex = 3;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.BackColor = System.Drawing.Color.Honeydew;
            this.labelDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDescripcion.Location = new System.Drawing.Point(42, 101);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(100, 23);
            this.labelDescripcion.TabIndex = 4;
            this.labelDescripcion.Text = "Descripcion";
            this.labelDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxDescripcion.Location = new System.Drawing.Point(147, 101);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(253, 22);
            this.textBoxDescripcion.TabIndex = 5;
            this.textBoxDescripcion.TextChanged += new System.EventHandler(this.textBoxDescripcion_TextChanged);
            // 
            // labelIdMarca
            // 
            this.labelIdMarca.BackColor = System.Drawing.Color.Honeydew;
            this.labelIdMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelIdMarca.Location = new System.Drawing.Point(42, 195);
            this.labelIdMarca.Name = "labelIdMarca";
            this.labelIdMarca.Size = new System.Drawing.Size(100, 23);
            this.labelIdMarca.TabIndex = 6;
            this.labelIdMarca.Text = "IdMarca";
            this.labelIdMarca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelIdCategoria
            // 
            this.labelIdCategoria.BackColor = System.Drawing.Color.Honeydew;
            this.labelIdCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelIdCategoria.Location = new System.Drawing.Point(42, 287);
            this.labelIdCategoria.Name = "labelIdCategoria";
            this.labelIdCategoria.Size = new System.Drawing.Size(100, 23);
            this.labelIdCategoria.TabIndex = 8;
            this.labelIdCategoria.Text = "IdCategoria";
            this.labelIdCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelImagenUrl
            // 
            this.labelImagenUrl.BackColor = System.Drawing.Color.Honeydew;
            this.labelImagenUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelImagenUrl.Location = new System.Drawing.Point(42, 333);
            this.labelImagenUrl.Name = "labelImagenUrl";
            this.labelImagenUrl.Size = new System.Drawing.Size(100, 22);
            this.labelImagenUrl.TabIndex = 10;
            this.labelImagenUrl.Text = "ImagenUrl";
            this.labelImagenUrl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPrecio
            // 
            this.labelPrecio.BackColor = System.Drawing.Color.Honeydew;
            this.labelPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPrecio.Location = new System.Drawing.Point(41, 378);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(100, 23);
            this.labelPrecio.TabIndex = 11;
            this.labelPrecio.Text = "Precio";
            this.labelPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxImagenUrl
            // 
            this.textBoxImagenUrl.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxImagenUrl.Location = new System.Drawing.Point(146, 334);
            this.textBoxImagenUrl.Name = "textBoxImagenUrl";
            this.textBoxImagenUrl.Size = new System.Drawing.Size(253, 22);
            this.textBoxImagenUrl.TabIndex = 12;
            this.textBoxImagenUrl.TextChanged += new System.EventHandler(this.textBoxImagenUrl_TextChanged);
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxPrecio.Location = new System.Drawing.Point(146, 378);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(253, 22);
            this.textBoxPrecio.TabIndex = 13;
            this.textBoxPrecio.TextChanged += new System.EventHandler(this.textBoxPrecio_TextChanged);
            this.textBoxPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrecio_KeyPress);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonAceptar.Location = new System.Drawing.Point(147, 424);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(100, 31);
            this.buttonAceptar.TabIndex = 14;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = false;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonCancelar.Location = new System.Drawing.Point(403, 424);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(100, 31);
            this.buttonCancelar.TabIndex = 15;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            // 
            // labelMarca
            // 
            this.labelMarca.BackColor = System.Drawing.Color.Honeydew;
            this.labelMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMarca.Location = new System.Drawing.Point(41, 149);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(100, 23);
            this.labelMarca.TabIndex = 17;
            this.labelMarca.Text = "Marca";
            this.labelMarca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxMarcaDescripcion
            // 
            this.comboBoxMarcaDescripcion.FormattingEnabled = true;
            this.comboBoxMarcaDescripcion.Location = new System.Drawing.Point(147, 148);
            this.comboBoxMarcaDescripcion.Name = "comboBoxMarcaDescripcion";
            this.comboBoxMarcaDescripcion.Size = new System.Drawing.Size(252, 24);
            this.comboBoxMarcaDescripcion.TabIndex = 18;
            // 
            // comboBoxIdMarca
            // 
            this.comboBoxIdMarca.FormattingEnabled = true;
            this.comboBoxIdMarca.Location = new System.Drawing.Point(147, 194);
            this.comboBoxIdMarca.Name = "comboBoxIdMarca";
            this.comboBoxIdMarca.Size = new System.Drawing.Size(252, 24);
            this.comboBoxIdMarca.TabIndex = 19;
            // 
            // comboBoxIdCategoria
            // 
            this.comboBoxIdCategoria.FormattingEnabled = true;
            this.comboBoxIdCategoria.Location = new System.Drawing.Point(148, 287);
            this.comboBoxIdCategoria.Name = "comboBoxIdCategoria";
            this.comboBoxIdCategoria.Size = new System.Drawing.Size(254, 24);
            this.comboBoxIdCategoria.TabIndex = 20;
            // 
            // labelCategoria
            // 
            this.labelCategoria.BackColor = System.Drawing.Color.Honeydew;
            this.labelCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCategoria.Location = new System.Drawing.Point(41, 242);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(100, 23);
            this.labelCategoria.TabIndex = 21;
            this.labelCategoria.Text = "Categoria";
            this.labelCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxCategoriaDescripcion
            // 
            this.comboBoxCategoriaDescripcion.FormattingEnabled = true;
            this.comboBoxCategoriaDescripcion.Location = new System.Drawing.Point(148, 241);
            this.comboBoxCategoriaDescripcion.Name = "comboBoxCategoriaDescripcion";
            this.comboBoxCategoriaDescripcion.Size = new System.Drawing.Size(254, 24);
            this.comboBoxCategoriaDescripcion.TabIndex = 22;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(800, 467);
            this.Controls.Add(this.comboBoxCategoriaDescripcion);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.comboBoxIdCategoria);
            this.Controls.Add(this.comboBoxIdMarca);
            this.Controls.Add(this.comboBoxMarcaDescripcion);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.textBoxImagenUrl);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.labelImagenUrl);
            this.Controls.Add(this.labelIdCategoria);
            this.Controls.Add(this.labelIdMarca);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.labelCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Label labelIdMarca;
        private System.Windows.Forms.Label labelIdCategoria;
        private System.Windows.Forms.Label labelImagenUrl;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.TextBox textBoxImagenUrl;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.Button buttonAceptar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.ComboBox comboBoxMarcaDescripcion;
        private System.Windows.Forms.ComboBox comboBoxIdMarca;
        private System.Windows.Forms.ComboBox comboBoxIdCategoria;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.ComboBox comboBoxCategoriaDescripcion;
    }
}