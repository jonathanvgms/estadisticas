﻿namespace EstadisticasEscuelaFrontEnd.Materias
{
    partial class frmMateriaBuscar
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMateriaBuscar));
            this.FiltroDeBusqueda = new System.Windows.Forms.GroupBox();
            this.cmbMateriaBuscarEspecialidad = new System.Windows.Forms.ComboBox();
            this.lblMateriaBuscarEspecialidad = new System.Windows.Forms.Label();
            this.cmbMateriaBuscarTurno = new System.Windows.Forms.ComboBox();
            this.lblMateriaBuscarTurno = new System.Windows.Forms.Label();
            this.lblMateriaBuscarMateriaError = new System.Windows.Forms.Label();
            this.txtMateriaBuscarMateria = new System.Windows.Forms.TextBox();
            this.lblMateriaBucarMateria = new System.Windows.Forms.Label();
            this.btnMateriaBuscarLimpiar = new System.Windows.Forms.Button();
            this.btnMateriaBuscarBuscar = new System.Windows.Forms.Button();
            this.btnMateriaBucarCancelar = new System.Windows.Forms.Button();
            this.dgvMateriaBuscar = new System.Windows.Forms.DataGridView();
            this.FiltroDeBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriaBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // FiltroDeBusqueda
            // 
            this.FiltroDeBusqueda.Controls.Add(this.cmbMateriaBuscarEspecialidad);
            this.FiltroDeBusqueda.Controls.Add(this.lblMateriaBuscarEspecialidad);
            this.FiltroDeBusqueda.Controls.Add(this.cmbMateriaBuscarTurno);
            this.FiltroDeBusqueda.Controls.Add(this.lblMateriaBuscarTurno);
            this.FiltroDeBusqueda.Controls.Add(this.lblMateriaBuscarMateriaError);
            this.FiltroDeBusqueda.Controls.Add(this.txtMateriaBuscarMateria);
            this.FiltroDeBusqueda.Controls.Add(this.lblMateriaBucarMateria);
            this.FiltroDeBusqueda.Location = new System.Drawing.Point(12, 12);
            this.FiltroDeBusqueda.Name = "FiltroDeBusqueda";
            this.FiltroDeBusqueda.Size = new System.Drawing.Size(682, 140);
            this.FiltroDeBusqueda.TabIndex = 0;
            this.FiltroDeBusqueda.TabStop = false;
            this.FiltroDeBusqueda.Text = "Filtro de Busqueda";
            // 
            // cmbMateriaBuscarEspecialidad
            // 
            this.cmbMateriaBuscarEspecialidad.FormattingEnabled = true;
            this.cmbMateriaBuscarEspecialidad.Location = new System.Drawing.Point(135, 103);
            this.cmbMateriaBuscarEspecialidad.Name = "cmbMateriaBuscarEspecialidad";
            this.cmbMateriaBuscarEspecialidad.Size = new System.Drawing.Size(169, 21);
            this.cmbMateriaBuscarEspecialidad.TabIndex = 6;
            // 
            // lblMateriaBuscarEspecialidad
            // 
            this.lblMateriaBuscarEspecialidad.AutoSize = true;
            this.lblMateriaBuscarEspecialidad.Location = new System.Drawing.Point(47, 111);
            this.lblMateriaBuscarEspecialidad.Name = "lblMateriaBuscarEspecialidad";
            this.lblMateriaBuscarEspecialidad.Size = new System.Drawing.Size(67, 13);
            this.lblMateriaBuscarEspecialidad.TabIndex = 5;
            this.lblMateriaBuscarEspecialidad.Text = "Especialidad";
            // 
            // cmbMateriaBuscarTurno
            // 
            this.cmbMateriaBuscarTurno.FormattingEnabled = true;
            this.cmbMateriaBuscarTurno.Location = new System.Drawing.Point(135, 65);
            this.cmbMateriaBuscarTurno.Name = "cmbMateriaBuscarTurno";
            this.cmbMateriaBuscarTurno.Size = new System.Drawing.Size(169, 21);
            this.cmbMateriaBuscarTurno.TabIndex = 4;
            // 
            // lblMateriaBuscarTurno
            // 
            this.lblMateriaBuscarTurno.AutoSize = true;
            this.lblMateriaBuscarTurno.Location = new System.Drawing.Point(47, 73);
            this.lblMateriaBuscarTurno.Name = "lblMateriaBuscarTurno";
            this.lblMateriaBuscarTurno.Size = new System.Drawing.Size(35, 13);
            this.lblMateriaBuscarTurno.TabIndex = 3;
            this.lblMateriaBuscarTurno.Text = "Turno";
            // 
            // lblMateriaBuscarMateriaError
            // 
            this.lblMateriaBuscarMateriaError.AutoSize = true;
            this.lblMateriaBuscarMateriaError.Location = new System.Drawing.Point(331, 56);
            this.lblMateriaBuscarMateriaError.Name = "lblMateriaBuscarMateriaError";
            this.lblMateriaBuscarMateriaError.Size = new System.Drawing.Size(0, 13);
            this.lblMateriaBuscarMateriaError.TabIndex = 2;
            // 
            // txtMateriaBuscarMateria
            // 
            this.txtMateriaBuscarMateria.Location = new System.Drawing.Point(135, 27);
            this.txtMateriaBuscarMateria.Name = "txtMateriaBuscarMateria";
            this.txtMateriaBuscarMateria.Size = new System.Drawing.Size(169, 20);
            this.txtMateriaBuscarMateria.TabIndex = 1;
            // 
            // lblMateriaBucarMateria
            // 
            this.lblMateriaBucarMateria.AutoSize = true;
            this.lblMateriaBucarMateria.Location = new System.Drawing.Point(47, 34);
            this.lblMateriaBucarMateria.Name = "lblMateriaBucarMateria";
            this.lblMateriaBucarMateria.Size = new System.Drawing.Size(42, 13);
            this.lblMateriaBucarMateria.TabIndex = 0;
            this.lblMateriaBucarMateria.Text = "Materia";
            // 
            // btnMateriaBuscarLimpiar
            // 
            this.btnMateriaBuscarLimpiar.Location = new System.Drawing.Point(12, 158);
            this.btnMateriaBuscarLimpiar.Name = "btnMateriaBuscarLimpiar";
            this.btnMateriaBuscarLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnMateriaBuscarLimpiar.TabIndex = 1;
            this.btnMateriaBuscarLimpiar.Text = "Limpiar";
            this.btnMateriaBuscarLimpiar.UseVisualStyleBackColor = true;
            this.btnMateriaBuscarLimpiar.Click += new System.EventHandler(this.btnMateriaBuscarLimpiar_Click);
            // 
            // btnMateriaBuscarBuscar
            // 
            this.btnMateriaBuscarBuscar.Location = new System.Drawing.Point(619, 158);
            this.btnMateriaBuscarBuscar.Name = "btnMateriaBuscarBuscar";
            this.btnMateriaBuscarBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnMateriaBuscarBuscar.TabIndex = 2;
            this.btnMateriaBuscarBuscar.Text = "Buscar";
            this.btnMateriaBuscarBuscar.UseVisualStyleBackColor = true;
            this.btnMateriaBuscarBuscar.Click += new System.EventHandler(this.btnMateriaBuscarBuscar_Click);
            // 
            // btnMateriaBucarCancelar
            // 
            this.btnMateriaBucarCancelar.Location = new System.Drawing.Point(619, 529);
            this.btnMateriaBucarCancelar.Name = "btnMateriaBucarCancelar";
            this.btnMateriaBucarCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnMateriaBucarCancelar.TabIndex = 3;
            this.btnMateriaBucarCancelar.Text = "Cancelar";
            this.btnMateriaBucarCancelar.UseVisualStyleBackColor = true;
            this.btnMateriaBucarCancelar.Click += new System.EventHandler(this.btnMateriaBucarCancelar_Click);
            // 
            // dgvMateriaBuscar
            // 
            this.dgvMateriaBuscar.AllowUserToAddRows = false;
            this.dgvMateriaBuscar.AllowUserToDeleteRows = false;
            this.dgvMateriaBuscar.AllowUserToResizeColumns = false;
            this.dgvMateriaBuscar.AllowUserToResizeRows = false;
            this.dgvMateriaBuscar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvMateriaBuscar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvMateriaBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMateriaBuscar.Location = new System.Drawing.Point(12, 187);
            this.dgvMateriaBuscar.Name = "dgvMateriaBuscar";
            this.dgvMateriaBuscar.Size = new System.Drawing.Size(681, 336);
            this.dgvMateriaBuscar.TabIndex = 4;
            // 
            // frmMateriaBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 564);
            this.Controls.Add(this.dgvMateriaBuscar);
            this.Controls.Add(this.btnMateriaBucarCancelar);
            this.Controls.Add(this.btnMateriaBuscarBuscar);
            this.Controls.Add(this.btnMateriaBuscarLimpiar);
            this.Controls.Add(this.FiltroDeBusqueda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMateriaBuscar";
            this.Text = "Buscar Materia";
            this.Load += new System.EventHandler(this.frmMateriaBuscar_Load);
            this.FiltroDeBusqueda.ResumeLayout(false);
            this.FiltroDeBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriaBuscar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox FiltroDeBusqueda;
        private System.Windows.Forms.TextBox txtMateriaBuscarMateria;
        private System.Windows.Forms.Label lblMateriaBucarMateria;
        private System.Windows.Forms.Button btnMateriaBuscarLimpiar;
        private System.Windows.Forms.Button btnMateriaBuscarBuscar;
        private System.Windows.Forms.Button btnMateriaBucarCancelar;
        private System.Windows.Forms.DataGridView dgvMateriaBuscar;
        private System.Windows.Forms.Label lblMateriaBuscarMateriaError;
        private System.Windows.Forms.ComboBox cmbMateriaBuscarEspecialidad;
        private System.Windows.Forms.Label lblMateriaBuscarEspecialidad;
        private System.Windows.Forms.ComboBox cmbMateriaBuscarTurno;
        private System.Windows.Forms.Label lblMateriaBuscarTurno;
    }
}