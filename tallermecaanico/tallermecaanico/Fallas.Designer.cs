namespace tallermecaanico
{
    partial class frmFallas
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnMostrarFallas = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblcolor = new System.Windows.Forms.Label();
            this.lblaño = new System.Windows.Forms.Label();
            this.lblmarca = new System.Windows.Forms.Label();
            this.lblmodelo = new System.Windows.Forms.Label();
            this.lblnumser = new System.Windows.Forms.Label();
            this.txtGarantia = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtIDDepartamento = new System.Windows.Forms.TextBox();
            this.txtIDFalla = new System.Windows.Forms.TextBox();
            this.btnMostrarDep = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 32);
            this.button1.TabIndex = 29;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMostrarFallas
            // 
            this.btnMostrarFallas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnMostrarFallas.FlatAppearance.BorderSize = 0;
            this.btnMostrarFallas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnMostrarFallas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMostrarFallas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarFallas.ForeColor = System.Drawing.Color.LightGray;
            this.btnMostrarFallas.Location = new System.Drawing.Point(470, 430);
            this.btnMostrarFallas.Margin = new System.Windows.Forms.Padding(4);
            this.btnMostrarFallas.Name = "btnMostrarFallas";
            this.btnMostrarFallas.Size = new System.Drawing.Size(104, 76);
            this.btnMostrarFallas.TabIndex = 51;
            this.btnMostrarFallas.Text = "Mostrar Fallas";
            this.btnMostrarFallas.UseVisualStyleBackColor = false;
            this.btnMostrarFallas.Click += new System.EventHandler(this.btnMostrarFallas_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid.Location = new System.Drawing.Point(636, 96);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 30;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(1013, 642);
            this.dataGrid.TabIndex = 47;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnSeleccionar.FlatAppearance.BorderSize = 0;
            this.btnSeleccionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnSeleccionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.ForeColor = System.Drawing.Color.LightGray;
            this.btnSeleccionar.Location = new System.Drawing.Point(265, 398);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(123, 43);
            this.btnSeleccionar.TabIndex = 46;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.LightGray;
            this.btnEliminar.Location = new System.Drawing.Point(189, 475);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(121, 43);
            this.btnEliminar.TabIndex = 45;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.LightGray;
            this.btnGuardar.Location = new System.Drawing.Point(100, 398);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(123, 43);
            this.btnGuardar.TabIndex = 44;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblcolor
            // 
            this.lblcolor.AutoSize = true;
            this.lblcolor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcolor.ForeColor = System.Drawing.SystemColors.Control;
            this.lblcolor.Location = new System.Drawing.Point(95, 318);
            this.lblcolor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcolor.Name = "lblcolor";
            this.lblcolor.Size = new System.Drawing.Size(101, 25);
            this.lblcolor.TabIndex = 39;
            this.lblcolor.Text = "Garantía:";
            // 
            // lblaño
            // 
            this.lblaño.AutoSize = true;
            this.lblaño.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaño.ForeColor = System.Drawing.SystemColors.Control;
            this.lblaño.Location = new System.Drawing.Point(103, 265);
            this.lblaño.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblaño.Name = "lblaño";
            this.lblaño.Size = new System.Drawing.Size(80, 25);
            this.lblaño.TabIndex = 40;
            this.lblaño.Text = "Precio:";
            // 
            // lblmarca
            // 
            this.lblmarca.AutoSize = true;
            this.lblmarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmarca.ForeColor = System.Drawing.SystemColors.Control;
            this.lblmarca.Location = new System.Drawing.Point(67, 144);
            this.lblmarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmarca.Name = "lblmarca";
            this.lblmarca.Size = new System.Drawing.Size(132, 25);
            this.lblmarca.TabIndex = 41;
            this.lblmarca.Text = "Descripción:";
            // 
            // lblmodelo
            // 
            this.lblmodelo.AutoSize = true;
            this.lblmodelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmodelo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblmodelo.Location = new System.Drawing.Point(15, 209);
            this.lblmodelo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmodelo.Name = "lblmodelo";
            this.lblmodelo.Size = new System.Drawing.Size(181, 25);
            this.lblmodelo.TabIndex = 42;
            this.lblmodelo.Text = "ID Departamento:";
            // 
            // lblnumser
            // 
            this.lblnumser.AutoSize = true;
            this.lblnumser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumser.ForeColor = System.Drawing.SystemColors.Control;
            this.lblnumser.Location = new System.Drawing.Point(103, 96);
            this.lblnumser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnumser.Name = "lblnumser";
            this.lblnumser.Size = new System.Drawing.Size(93, 25);
            this.lblnumser.TabIndex = 43;
            this.lblnumser.Text = "ID Falla:";
            // 
            // txtGarantia
            // 
            this.txtGarantia.Location = new System.Drawing.Point(227, 322);
            this.txtGarantia.Margin = new System.Windows.Forms.Padding(4);
            this.txtGarantia.Name = "txtGarantia";
            this.txtGarantia.Size = new System.Drawing.Size(205, 22);
            this.txtGarantia.TabIndex = 34;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(227, 269);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(103, 22);
            this.txtPrecio.TabIndex = 35;
            this.txtPrecio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrecio_KeyDown);
            // 
            // txtIDDepartamento
            // 
            this.txtIDDepartamento.Location = new System.Drawing.Point(227, 212);
            this.txtIDDepartamento.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDDepartamento.Name = "txtIDDepartamento";
            this.txtIDDepartamento.Size = new System.Drawing.Size(103, 22);
            this.txtIDDepartamento.TabIndex = 36;
            this.txtIDDepartamento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDepartamento_KeyDown);
            // 
            // txtIDFalla
            // 
            this.txtIDFalla.Location = new System.Drawing.Point(227, 96);
            this.txtIDFalla.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDFalla.Name = "txtIDFalla";
            this.txtIDFalla.Size = new System.Drawing.Size(205, 22);
            this.txtIDFalla.TabIndex = 38;
            // 
            // btnMostrarDep
            // 
            this.btnMostrarDep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnMostrarDep.FlatAppearance.BorderSize = 0;
            this.btnMostrarDep.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnMostrarDep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMostrarDep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarDep.ForeColor = System.Drawing.Color.LightGray;
            this.btnMostrarDep.Location = new System.Drawing.Point(390, 209);
            this.btnMostrarDep.Margin = new System.Windows.Forms.Padding(4);
            this.btnMostrarDep.Name = "btnMostrarDep";
            this.btnMostrarDep.Size = new System.Drawing.Size(123, 43);
            this.btnMostrarDep.TabIndex = 52;
            this.btnMostrarDep.Text = "Ver departamentos";
            this.btnMostrarDep.UseVisualStyleBackColor = false;
            this.btnMostrarDep.Click += new System.EventHandler(this.btnMostrarDep_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(227, 144);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(384, 22);
            this.txtDescripcion.TabIndex = 37;
            this.txtDescripcion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescripcion_KeyDown);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.LightGray;
            this.button3.Location = new System.Drawing.Point(482, 61);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 57);
            this.button3.TabIndex = 54;
            this.button3.Text = "Limpiar Campos";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.LightGray;
            this.button4.Location = new System.Drawing.Point(309, 13);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 50);
            this.button4.TabIndex = 55;
            this.button4.Text = "Modificar Fallas";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // frmFallas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1675, 772);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnMostrarDep);
            this.Controls.Add(this.btnMostrarFallas);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblcolor);
            this.Controls.Add(this.lblaño);
            this.Controls.Add(this.lblmarca);
            this.Controls.Add(this.lblmodelo);
            this.Controls.Add(this.lblnumser);
            this.Controls.Add(this.txtGarantia);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtIDDepartamento);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtIDFalla);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "frmFallas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fallas";
            this.Load += new System.EventHandler(this.frmFallas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMostrarFallas;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblcolor;
        private System.Windows.Forms.Label lblaño;
        private System.Windows.Forms.Label lblmarca;
        private System.Windows.Forms.Label lblmodelo;
        private System.Windows.Forms.Label lblnumser;
        private System.Windows.Forms.TextBox txtGarantia;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtIDDepartamento;
        private System.Windows.Forms.TextBox txtIDFalla;
        private System.Windows.Forms.Button btnMostrarDep;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}