﻿namespace MagredadV30
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
            this.components = new System.ComponentModel.Container();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tmrHora = new System.Windows.Forms.Timer(this.components);
            this.lblhora = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.columsConsecutivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnsMagredad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnsGrasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConsecutivo = new System.Windows.Forms.TextBox();
            this.txtMagredad = new System.Windows.Forms.TextBox();
            this.txtGrasa = new System.Windows.Forms.TextBox();
            this.chkIncremento = new System.Windows.Forms.CheckBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.lbldesarrollo = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tmrHora
            // 
            this.tmrHora.Enabled = true;
            this.tmrHora.Tick += new System.EventHandler(this.tmrHora_Tick);
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.Location = new System.Drawing.Point(12, 89);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(28, 13);
            this.lblhora.TabIndex = 0;
            this.lblhora.Text = "hora";
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columsConsecutivo,
            this.columnsMagredad,
            this.columnsGrasa});
            this.dgvDatos.Location = new System.Drawing.Point(109, 27);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(346, 349);
            this.dgvDatos.TabIndex = 1;
            // 
            // columsConsecutivo
            // 
            this.columsConsecutivo.HeaderText = "Consecutivo";
            this.columsConsecutivo.Name = "columsConsecutivo";
            // 
            // columnsMagredad
            // 
            this.columnsMagredad.HeaderText = "Magredad";
            this.columnsMagredad.Name = "columnsMagredad";
            // 
            // columnsGrasa
            // 
            this.columnsGrasa.HeaderText = "Grasa";
            this.columnsGrasa.Name = "columnsGrasa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(473, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Consecutivo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(473, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Magredad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(473, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Grasa";
            // 
            // txtConsecutivo
            // 
            this.txtConsecutivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsecutivo.Location = new System.Drawing.Point(476, 27);
            this.txtConsecutivo.Name = "txtConsecutivo";
            this.txtConsecutivo.Size = new System.Drawing.Size(223, 158);
            this.txtConsecutivo.TabIndex = 5;
            // 
            // txtMagredad
            // 
            this.txtMagredad.Font = new System.Drawing.Font("Microsoft Sans Serif", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMagredad.Location = new System.Drawing.Point(476, 425);
            this.txtMagredad.Name = "txtMagredad";
            this.txtMagredad.Size = new System.Drawing.Size(223, 158);
            this.txtMagredad.TabIndex = 6;
            // 
            // txtGrasa
            // 
            this.txtGrasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrasa.Location = new System.Drawing.Point(476, 218);
            this.txtGrasa.Name = "txtGrasa";
            this.txtGrasa.Size = new System.Drawing.Size(223, 158);
            this.txtGrasa.TabIndex = 7;
            // 
            // chkIncremento
            // 
            this.chkIncremento.AutoSize = true;
            this.chkIncremento.Location = new System.Drawing.Point(620, 5);
            this.chkIncremento.Name = "chkIncremento";
            this.chkIncremento.Size = new System.Drawing.Size(79, 17);
            this.chkIncremento.TabIndex = 8;
            this.chkIncremento.Text = "Incremento";
            this.chkIncremento.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(192, 425);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(160, 61);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(12, 27);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 23);
            this.btnAbrir.TabIndex = 12;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // lbldesarrollo
            // 
            this.lbldesarrollo.AutoSize = true;
            this.lbldesarrollo.Location = new System.Drawing.Point(9, 573);
            this.lbldesarrollo.Name = "lbldesarrollo";
            this.lbldesarrollo.Size = new System.Drawing.Size(178, 13);
            this.lbldesarrollo.TabIndex = 13;
            this.lbldesarrollo.Text = "Desarrollado por: Leonel Pérez Díaz";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(12, 56);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 595);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lbldesarrollo);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.chkIncremento);
            this.Controls.Add(this.txtGrasa);
            this.Controls.Add(this.txtMagredad);
            this.Controls.Add(this.txtConsecutivo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.lblhora);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Magredad Canales";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer tmrHora;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn columsConsecutivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnsMagredad;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnsGrasa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConsecutivo;
        private System.Windows.Forms.TextBox txtMagredad;
        private System.Windows.Forms.TextBox txtGrasa;
        private System.Windows.Forms.CheckBox chkIncremento;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Label lbldesarrollo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

