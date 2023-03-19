namespace TP_7_Julian_B_Ortega
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblEmpleados = new System.Windows.Forms.Label();
            this.dgEmpleados = new System.Windows.Forms.DataGridView();
            this.inputNombre = new System.Windows.Forms.TextBox();
            this.lblNuevoEmpleado = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.inputDNI = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.inputEdad = new System.Windows.Forms.TextBox();
            this.lblCasado = new System.Windows.Forms.Label();
            this.inputSalario = new System.Windows.Forms.TextBox();
            this.chkCasado = new System.Windows.Forms.CheckBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Casado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmpleados
            // 
            this.lblEmpleados.AutoSize = true;
            this.lblEmpleados.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleados.ForeColor = System.Drawing.Color.White;
            this.lblEmpleados.Location = new System.Drawing.Point(13, 13);
            this.lblEmpleados.Name = "lblEmpleados";
            this.lblEmpleados.Size = new System.Drawing.Size(130, 30);
            this.lblEmpleados.TabIndex = 0;
            this.lblEmpleados.Text = "Empleados";
            // 
            // dgEmpleados
            // 
            this.dgEmpleados.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgEmpleados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgEmpleados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.DNI,
            this.Edad,
            this.Casado,
            this.Salario});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgEmpleados.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgEmpleados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.dgEmpleados.Location = new System.Drawing.Point(18, 58);
            this.dgEmpleados.Name = "dgEmpleados";
            this.dgEmpleados.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgEmpleados.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgEmpleados.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgEmpleados.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Empty;
            this.dgEmpleados.Size = new System.Drawing.Size(572, 246);
            this.dgEmpleados.TabIndex = 1;
            // 
            // inputNombre
            // 
            this.inputNombre.Location = new System.Drawing.Point(141, 360);
            this.inputNombre.Name = "inputNombre";
            this.inputNombre.Size = new System.Drawing.Size(100, 22);
            this.inputNombre.TabIndex = 2;
            // 
            // lblNuevoEmpleado
            // 
            this.lblNuevoEmpleado.AutoSize = true;
            this.lblNuevoEmpleado.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoEmpleado.ForeColor = System.Drawing.Color.White;
            this.lblNuevoEmpleado.Location = new System.Drawing.Point(13, 318);
            this.lblNuevoEmpleado.Name = "lblNuevoEmpleado";
            this.lblNuevoEmpleado.Size = new System.Drawing.Size(196, 30);
            this.lblNuevoEmpleado.TabIndex = 3;
            this.lblNuevoEmpleado.Text = "Nuevo empleado";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(36, 363);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(99, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre completo";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.ForeColor = System.Drawing.Color.White;
            this.lblDNI.Location = new System.Drawing.Point(109, 391);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(26, 13);
            this.lblDNI.TabIndex = 6;
            this.lblDNI.Text = "DNI";
            // 
            // inputDNI
            // 
            this.inputDNI.Location = new System.Drawing.Point(141, 388);
            this.inputDNI.Name = "inputDNI";
            this.inputDNI.Size = new System.Drawing.Size(100, 22);
            this.inputDNI.TabIndex = 5;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.ForeColor = System.Drawing.Color.White;
            this.lblEdad.Location = new System.Drawing.Point(265, 363);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(33, 13);
            this.lblEdad.TabIndex = 8;
            this.lblEdad.Text = "Edad";
            // 
            // inputEdad
            // 
            this.inputEdad.Location = new System.Drawing.Point(304, 360);
            this.inputEdad.Name = "inputEdad";
            this.inputEdad.Size = new System.Drawing.Size(100, 22);
            this.inputEdad.TabIndex = 7;
            // 
            // lblCasado
            // 
            this.lblCasado.AutoSize = true;
            this.lblCasado.ForeColor = System.Drawing.Color.White;
            this.lblCasado.Location = new System.Drawing.Point(253, 391);
            this.lblCasado.Name = "lblCasado";
            this.lblCasado.Size = new System.Drawing.Size(42, 13);
            this.lblCasado.TabIndex = 10;
            this.lblCasado.Text = "Salario";
            // 
            // inputSalario
            // 
            this.inputSalario.Location = new System.Drawing.Point(304, 388);
            this.inputSalario.Name = "inputSalario";
            this.inputSalario.Size = new System.Drawing.Size(100, 22);
            this.inputSalario.TabIndex = 9;
            // 
            // chkCasado
            // 
            this.chkCasado.AutoSize = true;
            this.chkCasado.ForeColor = System.Drawing.Color.White;
            this.chkCasado.Location = new System.Drawing.Point(441, 362);
            this.chkCasado.Name = "chkCasado";
            this.chkCasado.Size = new System.Drawing.Size(64, 17);
            this.chkCasado.TabIndex = 11;
            this.chkCasado.Text = "Casado";
            this.chkCasado.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(441, 385);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(124, 23);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar empleado";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(215, 331);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 13;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            this.Nombre.DefaultCellStyle = dataGridViewCellStyle3;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nombre.Width = 179;
            // 
            // DNI
            // 
            this.DNI.DataPropertyName = "DNI";
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            this.DNI.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Edad
            // 
            this.Edad.DataPropertyName = "Edad";
            this.Edad.HeaderText = "Edad";
            this.Edad.Name = "Edad";
            this.Edad.ReadOnly = true;
            this.Edad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Edad.Width = 50;
            // 
            // Casado
            // 
            this.Casado.DataPropertyName = "Casado";
            this.Casado.HeaderText = "Casado";
            this.Casado.Name = "Casado";
            this.Casado.ReadOnly = true;
            this.Casado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Salario
            // 
            this.Salario.DataPropertyName = "Salario";
            this.Salario.HeaderText = "Salario";
            this.Salario.Name = "Salario";
            this.Salario.ReadOnly = true;
            this.Salario.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(611, 432);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.chkCasado);
            this.Controls.Add(this.lblCasado);
            this.Controls.Add(this.inputSalario);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.inputEdad);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.inputDNI);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblNuevoEmpleado);
            this.Controls.Add(this.inputNombre);
            this.Controls.Add(this.dgEmpleados);
            this.Controls.Add(this.lblEmpleados);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(627, 471);
            this.MinimumSize = new System.Drawing.Size(627, 471);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpleados;
        private System.Windows.Forms.DataGridView dgEmpleados;
        private System.Windows.Forms.TextBox inputNombre;
        private System.Windows.Forms.Label lblNuevoEmpleado;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox inputDNI;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox inputEdad;
        private System.Windows.Forms.Label lblCasado;
        private System.Windows.Forms.TextBox inputSalario;
        private System.Windows.Forms.CheckBox chkCasado;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Casado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salario;
    }
}

