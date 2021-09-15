
namespace Facturador
{
    partial class FCliente
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
            this.bindingSourceClnt = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rfcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelCrreo = new System.Windows.Forms.Label();
            this.textBoxCrro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNmbr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRfc = new System.Windows.Forms.TextBox();
            this.panelDown.SuspendLayout();
            this.panelBtns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceClnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDown
            // 
            this.panelDown.Location = new System.Drawing.Point(0, 290);
            this.panelDown.Size = new System.Drawing.Size(795, 50);
            // 
            // panelBtns
            // 
            this.panelBtns.Location = new System.Drawing.Point(376, 0);
            // 
            // buttonSave
            // 
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
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
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(10);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.labelCrreo);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxNmbr);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxCrro);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxRfc);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(10);
            this.splitContainer1.Size = new System.Drawing.Size(795, 290);
            this.splitContainer1.SplitterDistance = 342;
            // 
            // bindingSourceClnt
            // 
            this.bindingSourceClnt.DataSource = typeof(Facturador.Module.BusinessObjects.Cliente);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rfcDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.Correo});
            this.dataGridView1.DataSource = this.bindingSourceClnt;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(10, 10);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(322, 270);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // rfcDataGridViewTextBoxColumn
            // 
            this.rfcDataGridViewTextBoxColumn.DataPropertyName = "Rfc";
            this.rfcDataGridViewTextBoxColumn.HeaderText = "Rfc";
            this.rfcDataGridViewTextBoxColumn.Name = "rfcDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // Correo
            // 
            this.Correo.DataPropertyName = "Correo";
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            // 
            // labelCrreo
            // 
            this.labelCrreo.AutoSize = true;
            this.labelCrreo.Location = new System.Drawing.Point(23, 86);
            this.labelCrreo.Name = "labelCrreo";
            this.labelCrreo.Size = new System.Drawing.Size(38, 13);
            this.labelCrreo.TabIndex = 3;
            this.labelCrreo.Text = "Correo";
            // 
            // textBoxCrro
            // 
            this.textBoxCrro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceClnt, "Correo", true));
            this.textBoxCrro.Location = new System.Drawing.Point(68, 79);
            this.textBoxCrro.Name = "textBoxCrro";
            this.textBoxCrro.Size = new System.Drawing.Size(314, 20);
            this.textBoxCrro.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // textBoxNmbr
            // 
            this.textBoxNmbr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceClnt, "Nombre", true));
            this.textBoxNmbr.Location = new System.Drawing.Point(68, 55);
            this.textBoxNmbr.Name = "textBoxNmbr";
            this.textBoxNmbr.Size = new System.Drawing.Size(314, 20);
            this.textBoxNmbr.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "RFC";
            // 
            // textBoxRfc
            // 
            this.textBoxRfc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceClnt, "Rfc", true));
            this.textBoxRfc.Location = new System.Drawing.Point(68, 33);
            this.textBoxRfc.Name = "textBoxRfc";
            this.textBoxRfc.Size = new System.Drawing.Size(130, 20);
            this.textBoxRfc.TabIndex = 0;
            // 
            // FCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 340);
            this.Name = "FCliente";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FCliente_Load);
            this.panelDown.ResumeLayout(false);
            this.panelBtns.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceClnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSourceClnt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRfc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNmbr;
        private System.Windows.Forms.Label labelCrreo;
        private System.Windows.Forms.TextBox textBoxCrro;
        private System.Windows.Forms.DataGridViewTextBoxColumn rfcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
    }
}