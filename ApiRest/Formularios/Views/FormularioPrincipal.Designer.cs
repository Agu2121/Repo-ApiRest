namespace Formularios.Views
{
    partial class FormularioPrincipal
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
            btnGetPersonajes = new Button();
            dtgDatos = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Genero = new DataGridViewTextBoxColumn();
            Especie = new DataGridViewTextBoxColumn();
            Origen = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgDatos).BeginInit();
            SuspendLayout();
            // 
            // btnGetPersonajes
            // 
            btnGetPersonajes.Location = new Point(328, 415);
            btnGetPersonajes.Name = "btnGetPersonajes";
            btnGetPersonajes.Size = new Size(153, 23);
            btnGetPersonajes.TabIndex = 0;
            btnGetPersonajes.Text = "Obtener personajes";
            btnGetPersonajes.UseVisualStyleBackColor = true;
            btnGetPersonajes.Click += btnGetPersonajes_Click;
            // 
            // dtgDatos
            // 
            dtgDatos.AllowUserToAddRows = false;
            dtgDatos.AllowUserToDeleteRows = false;
            dtgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDatos.Columns.AddRange(new DataGridViewColumn[] { Nombre, Genero, Especie, Origen });
            dtgDatos.Location = new Point(22, 12);
            dtgDatos.Name = "dtgDatos";
            dtgDatos.ReadOnly = true;
            dtgDatos.Size = new Size(754, 386);
            dtgDatos.TabIndex = 1;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 250;
            // 
            // Genero
            // 
            Genero.HeaderText = "Genero";
            Genero.Name = "Genero";
            Genero.ReadOnly = true;
            Genero.Width = 140;
            // 
            // Especie
            // 
            Especie.HeaderText = "Especie";
            Especie.Name = "Especie";
            Especie.ReadOnly = true;
            Especie.Width = 140;
            // 
            // Origen
            // 
            Origen.HeaderText = "Origen";
            Origen.Name = "Origen";
            Origen.ReadOnly = true;
            Origen.Width = 180;
            // 
            // FormularioPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtgDatos);
            Controls.Add(btnGetPersonajes);
            Name = "FormularioPrincipal";
            Text = "FormularioPrincipal";
            ((System.ComponentModel.ISupportInitialize)dtgDatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnGetPersonajes;
        private DataGridView dtgDatos;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Genero;
        private DataGridViewTextBoxColumn Especie;
        private DataGridViewTextBoxColumn Origen;
    }
}