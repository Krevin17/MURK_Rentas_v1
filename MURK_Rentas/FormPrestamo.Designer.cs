namespace MURK_Rentas
{
    partial class FormPrestamo
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableAdapterManager1 = new MURK_Rentas.MURKDataSetTableAdapters.TableAdapterManager();
            this.m = new System.Windows.Forms.Panel();
            this.Usuario = new System.Windows.Forms.Label();
            this.Puerto = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tituloForm = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbCosto = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbDias = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbAutorizado = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbRfid = new System.Windows.Forms.Label();
            this.btnListo = new System.Windows.Forms.Button();
            this.lbNombre = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rfid_articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbDias)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = MURK_Rentas.MURKDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // m
            // 
            this.m.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.m.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.m.Controls.Add(this.Usuario);
            this.m.Controls.Add(this.Puerto);
            this.m.Controls.Add(this.btnCancelar);
            this.m.Controls.Add(this.btnGuardar);
            this.m.Controls.Add(this.dataGridView2);
            this.m.Controls.Add(this.tituloForm);
            this.m.Controls.Add(this.panel2);
            this.m.Controls.Add(this.panel1);
            this.m.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m.Location = new System.Drawing.Point(0, 0);
            this.m.Name = "m";
            this.m.Size = new System.Drawing.Size(778, 648);
            this.m.TabIndex = 39;
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario.ForeColor = System.Drawing.Color.White;
            this.Usuario.Location = new System.Drawing.Point(306, 23);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(53, 16);
            this.Usuario.TabIndex = 34;
            this.Usuario.Text = "--User--";
            this.Usuario.Visible = false;
            // 
            // Puerto
            // 
            this.Puerto.AutoSize = true;
            this.Puerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Puerto.ForeColor = System.Drawing.Color.White;
            this.Puerto.Location = new System.Drawing.Point(192, 22);
            this.Puerto.Name = "Puerto";
            this.Puerto.Size = new System.Drawing.Size(63, 16);
            this.Puerto.TabIndex = 34;
            this.Puerto.Text = "--Puerto--";
            this.Puerto.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Silver;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(542, 604);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.TabIndex = 43;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Silver;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(652, 604);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 30);
            this.btnGuardar.TabIndex = 41;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(68)))), ((int)(((byte)(96)))));
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeight = 30;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.rfid_articulo,
            this.Nombre,
            this.Descripción,
            this.Categoria,
            this.Precio});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(68)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridView2.Location = new System.Drawing.Point(20, 294);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.Size = new System.Drawing.Size(732, 290);
            this.dataGridView2.TabIndex = 40;
            // 
            // tituloForm
            // 
            this.tituloForm.AutoSize = true;
            this.tituloForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tituloForm.Location = new System.Drawing.Point(16, 19);
            this.tituloForm.Name = "tituloForm";
            this.tituloForm.Size = new System.Drawing.Size(140, 20);
            this.tituloForm.TabIndex = 38;
            this.tituloForm.Text = "Nuevo Prestamo";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(68)))), ((int)(((byte)(96)))));
            this.panel2.Controls.Add(this.lbCosto);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lbFecha);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lbDias);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lbUsuario);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lbAutorizado);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Location = new System.Drawing.Point(374, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(382, 203);
            this.panel2.TabIndex = 37;
            // 
            // lbCosto
            // 
            this.lbCosto.AutoSize = true;
            this.lbCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCosto.ForeColor = System.Drawing.Color.White;
            this.lbCosto.Location = new System.Drawing.Point(195, 172);
            this.lbCosto.Name = "lbCosto";
            this.lbCosto.Size = new System.Drawing.Size(73, 16);
            this.lbCosto.TabIndex = 45;
            this.lbCosto.Text = "--Nombre--";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(26, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 16);
            this.label7.TabIndex = 44;
            this.label7.Text = "Costo del prestamo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(3, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 20);
            this.label6.TabIndex = 43;
            this.label6.Text = "Datos del Prestamo";
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.ForeColor = System.Drawing.Color.White;
            this.lbFecha.Location = new System.Drawing.Point(195, 147);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(73, 16);
            this.lbFecha.TabIndex = 39;
            this.lbFecha.Text = "--Nombre--";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(26, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "Fecha de entrega :";
            // 
            // lbDias
            // 
            this.lbDias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDias.Location = new System.Drawing.Point(198, 119);
            this.lbDias.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.lbDias.Name = "lbDias";
            this.lbDias.Size = new System.Drawing.Size(70, 20);
            this.lbDias.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(26, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 16);
            this.label4.TabIndex = 36;
            this.label4.Text = "Cantidad de días :";
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.ForeColor = System.Drawing.Color.White;
            this.lbUsuario.Location = new System.Drawing.Point(195, 65);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(73, 16);
            this.lbUsuario.TabIndex = 35;
            this.lbUsuario.Text = "--Nombre--";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(26, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Nombre de usuario:";
            // 
            // lbAutorizado
            // 
            this.lbAutorizado.AutoSize = true;
            this.lbAutorizado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAutorizado.ForeColor = System.Drawing.Color.White;
            this.lbAutorizado.Location = new System.Drawing.Point(195, 91);
            this.lbAutorizado.Name = "lbAutorizado";
            this.lbAutorizado.Size = new System.Drawing.Size(73, 16);
            this.lbAutorizado.TabIndex = 32;
            this.lbAutorizado.Text = "--Nombre--";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(26, 91);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(117, 16);
            this.label15.TabIndex = 31;
            this.label15.Text = "Autorizado por :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(68)))), ((int)(((byte)(96)))));
            this.panel1.Controls.Add(this.lbRfid);
            this.panel1.Controls.Add(this.btnListo);
            this.panel1.Controls.Add(this.lbNombre);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Location = new System.Drawing.Point(20, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 203);
            this.panel1.TabIndex = 36;
            // 
            // lbRfid
            // 
            this.lbRfid.AutoSize = true;
            this.lbRfid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRfid.ForeColor = System.Drawing.Color.White;
            this.lbRfid.Location = new System.Drawing.Point(172, 119);
            this.lbRfid.Name = "lbRfid";
            this.lbRfid.Size = new System.Drawing.Size(20, 16);
            this.lbRfid.TabIndex = 44;
            this.lbRfid.Text = "---";
            this.lbRfid.TextChanged += new System.EventHandler(this.lbRfid_TextChanged);
            // 
            // btnListo
            // 
            this.btnListo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            this.btnListo.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnListo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnListo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnListo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnListo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListo.ForeColor = System.Drawing.Color.Silver;
            this.btnListo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListo.Location = new System.Drawing.Point(226, 156);
            this.btnListo.Name = "btnListo";
            this.btnListo.Size = new System.Drawing.Size(100, 30);
            this.btnListo.TabIndex = 33;
            this.btnListo.Text = "Listo";
            this.btnListo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListo.UseVisualStyleBackColor = false;
            this.btnListo.Visible = false;
            this.btnListo.Click += new System.EventHandler(this.btnListo_Click);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.ForeColor = System.Drawing.Color.White;
            this.lbNombre.Location = new System.Drawing.Point(172, 56);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(73, 16);
            this.lbNombre.TabIndex = 32;
            this.lbNombre.Text = "--Nombre--";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label17.Location = new System.Drawing.Point(160, 18);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(165, 20);
            this.label17.TabIndex = 31;
            this.label17.Text = "Nombre de usuario.";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(16, 156);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(132, 26);
            this.label18.TabIndex = 7;
            this.label18.Text = "Pase su tarjeta de usuario \r\npor el lector.";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::MURK_Rentas.Properties.Resources.rfid_login;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(19, 22);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(120, 120);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM4";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Num
            // 
            this.Num.Frozen = true;
            this.Num.HeaderText = "#";
            this.Num.Name = "Num";
            this.Num.ReadOnly = true;
            this.Num.Width = 37;
            // 
            // rfid_articulo
            // 
            this.rfid_articulo.Frozen = true;
            this.rfid_articulo.HeaderText = "RFID";
            this.rfid_articulo.Name = "rfid_articulo";
            this.rfid_articulo.ReadOnly = true;
            this.rfid_articulo.Width = 58;
            // 
            // Nombre
            // 
            this.Nombre.Frozen = true;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 75;
            // 
            // Descripción
            // 
            this.Descripción.Frozen = true;
            this.Descripción.HeaderText = "Descripción";
            this.Descripción.Name = "Descripción";
            this.Descripción.ReadOnly = true;
            this.Descripción.Width = 95;
            // 
            // Categoria
            // 
            this.Categoria.Frozen = true;
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Width = 83;
            // 
            // Precio
            // 
            this.Precio.Frozen = true;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 65;
            // 
            // FormPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(778, 648);
            this.Controls.Add(this.m);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrestamo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrestamo";
            this.Load += new System.EventHandler(this.FormPrestamo_Load);
            this.m.ResumeLayout(false);
            this.m.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbDias)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MURKDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Panel m;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dataGridView2;
        public System.Windows.Forms.Label tituloForm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbFecha;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown lbDias;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbUsuario;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbAutorizado;
        public System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnListo;
        private System.Windows.Forms.Label lbNombre;
        public System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lbCosto;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort1;
        public System.Windows.Forms.Label Usuario;
        public System.Windows.Forms.Label Puerto;
        public System.Windows.Forms.Label lbRfid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn rfid_articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
    }
}