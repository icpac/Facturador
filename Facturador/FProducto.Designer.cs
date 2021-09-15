
namespace Facturador
{
    partial class FProducto
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.claveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelCve = new System.Windows.Forms.Label();
            this.textBoxCve = new System.Windows.Forms.TextBox();
            this.labelDscr = new System.Windows.Forms.Label();
            this.textBoxDscr = new System.Windows.Forms.TextBox();
            this.labelPrc = new System.Windows.Forms.Label();
            this.textBoxPrc = new System.Windows.Forms.TextBox();
            this.panelDown.SuspendLayout();
            this.panelBtns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBoxPrc);
            this.splitContainer1.Panel2.Controls.Add(this.labelPrc);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxDscr);
            this.splitContainer1.Panel2.Controls.Add(this.labelDscr);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxCve);
            this.splitContainer1.Panel2.Controls.Add(this.labelCve);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxId);
            this.splitContainer1.Panel2.Controls.Add(this.labelId);
            this.splitContainer1.Size = new System.Drawing.Size(800, 400);
            this.splitContainer1.SplitterDistance = 333;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.claveDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productoBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(10, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(313, 380);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // claveDataGridViewTextBoxColumn
            // 
            this.claveDataGridViewTextBoxColumn.DataPropertyName = "Clave";
            this.claveDataGridViewTextBoxColumn.HeaderText = "Clave";
            this.claveDataGridViewTextBoxColumn.Name = "claveDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataSource = typeof(Facturador.Module.BusinessObjects.Producto);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(13, 13);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(16, 13);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "Id";
            // 
            // textBoxId
            // 
            this.textBoxId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Id", true));
            this.textBoxId.Location = new System.Drawing.Point(82, 10);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 1;
            // 
            // labelCve
            // 
            this.labelCve.AutoSize = true;
            this.labelCve.Location = new System.Drawing.Point(13, 36);
            this.labelCve.Name = "labelCve";
            this.labelCve.Size = new System.Drawing.Size(34, 13);
            this.labelCve.TabIndex = 0;
            this.labelCve.Text = "Clave";
            // 
            // textBoxCve
            // 
            this.textBoxCve.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Clave", true));
            this.textBoxCve.Location = new System.Drawing.Point(82, 33);
            this.textBoxCve.Name = "textBoxCve";
            this.textBoxCve.Size = new System.Drawing.Size(100, 20);
            this.textBoxCve.TabIndex = 1;
            // 
            // labelDscr
            // 
            this.labelDscr.AutoSize = true;
            this.labelDscr.Location = new System.Drawing.Point(13, 62);
            this.labelDscr.Name = "labelDscr";
            this.labelDscr.Size = new System.Drawing.Size(63, 13);
            this.labelDscr.TabIndex = 0;
            this.labelDscr.Text = "Descripción";
            // 
            // textBoxDscr
            // 
            this.textBoxDscr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Descripcion", true));
            this.textBoxDscr.Location = new System.Drawing.Point(82, 59);
            this.textBoxDscr.Name = "textBoxDscr";
            this.textBoxDscr.Size = new System.Drawing.Size(100, 20);
            this.textBoxDscr.TabIndex = 1;
            // 
            // labelPrc
            // 
            this.labelPrc.AutoSize = true;
            this.labelPrc.Location = new System.Drawing.Point(13, 88);
            this.labelPrc.Name = "labelPrc";
            this.labelPrc.Size = new System.Drawing.Size(37, 13);
            this.labelPrc.TabIndex = 0;
            this.labelPrc.Text = "Precio";
            // 
            // textBoxPrc
            // 
            this.textBoxPrc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Precio", true));
            this.textBoxPrc.Location = new System.Drawing.Point(82, 85);
            this.textBoxPrc.Name = "textBoxPrc";
            this.textBoxPrc.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrc.TabIndex = 1;
            // 
            // FProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "FProducto";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.FProducto_Load);
            this.panelDown.ResumeLayout(false);
            this.panelBtns.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn claveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private System.Windows.Forms.TextBox textBoxPrc;
        private System.Windows.Forms.Label labelPrc;
        private System.Windows.Forms.TextBox textBoxDscr;
        private System.Windows.Forms.Label labelDscr;
        private System.Windows.Forms.TextBox textBoxCve;
        private System.Windows.Forms.Label labelCve;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelId;
    }
}
