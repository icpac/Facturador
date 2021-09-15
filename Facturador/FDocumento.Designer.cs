
namespace Facturador
{
    partial class FDocumento
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label serieLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FDocumento));
            System.Windows.Forms.Label clienteIdLabel;
            this.documentoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.documentoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.serieTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.itemsDocumentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsDocumentoDataGridView = new System.Windows.Forms.DataGridView();
            this.documentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteIdComboBox = new System.Windows.Forms.ComboBox();
            idLabel = new System.Windows.Forms.Label();
            serieLabel = new System.Windows.Forms.Label();
            clienteIdLabel = new System.Windows.Forms.Label();
            this.panelDown.SuspendLayout();
            this.panelBtns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentoBindingNavigator)).BeginInit();
            this.documentoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serieTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDocumentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDocumentoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(clienteIdLabel);
            this.splitContainer1.Panel2.Controls.Add(this.clienteIdComboBox);
            this.splitContainer1.Panel2.Controls.Add(this.itemsDocumentoDataGridView);
            this.splitContainer1.Panel2.Controls.Add(idLabel);
            this.splitContainer1.Panel2.Controls.Add(this.idSpinEdit);
            this.splitContainer1.Panel2.Controls.Add(serieLabel);
            this.splitContainer1.Panel2.Controls.Add(this.serieTextEdit);
            this.splitContainer1.Size = new System.Drawing.Size(800, 400);
            this.splitContainer1.SplitterDistance = 69;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(36, 32);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 0;
            idLabel.Text = "Id:";
            // 
            // serieLabel
            // 
            serieLabel.AutoSize = true;
            serieLabel.Location = new System.Drawing.Point(36, 58);
            serieLabel.Name = "serieLabel";
            serieLabel.Size = new System.Drawing.Size(34, 13);
            serieLabel.TabIndex = 2;
            serieLabel.Text = "Serie:";
            // 
            // documentoBindingNavigator
            // 
            this.documentoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.documentoBindingNavigator.BindingSource = this.documentoBindingSource;
            this.documentoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.documentoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.documentoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.documentoBindingNavigatorSaveItem});
            this.documentoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.documentoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.documentoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.documentoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.documentoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.documentoBindingNavigator.Name = "documentoBindingNavigator";
            this.documentoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.documentoBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.documentoBindingNavigator.TabIndex = 4;
            this.documentoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // documentoBindingNavigatorSaveItem
            // 
            this.documentoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.documentoBindingNavigatorSaveItem.Enabled = false;
            this.documentoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("documentoBindingNavigatorSaveItem.Image")));
            this.documentoBindingNavigatorSaveItem.Name = "documentoBindingNavigatorSaveItem";
            this.documentoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.documentoBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // idSpinEdit
            // 
            this.idSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.documentoBindingSource, "Id", true));
            this.idSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.idSpinEdit.Location = new System.Drawing.Point(76, 29);
            this.idSpinEdit.Name = "idSpinEdit";
            this.idSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.idSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.idSpinEdit.TabIndex = 1;
            // 
            // serieTextEdit
            // 
            this.serieTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.documentoBindingSource, "Serie", true));
            this.serieTextEdit.Location = new System.Drawing.Point(76, 55);
            this.serieTextEdit.Name = "serieTextEdit";
            this.serieTextEdit.Size = new System.Drawing.Size(100, 20);
            this.serieTextEdit.TabIndex = 3;
            // 
            // itemsDocumentoBindingSource
            // 
            this.itemsDocumentoBindingSource.DataMember = "ItemsDocumento";
            this.itemsDocumentoBindingSource.DataSource = this.documentoBindingSource;
            // 
            // itemsDocumentoDataGridView
            // 
            this.itemsDocumentoDataGridView.AutoGenerateColumns = false;
            this.itemsDocumentoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsDocumentoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.itemsDocumentoDataGridView.DataSource = this.itemsDocumentoBindingSource;
            this.itemsDocumentoDataGridView.Location = new System.Drawing.Point(39, 113);
            this.itemsDocumentoDataGridView.Name = "itemsDocumentoDataGridView";
            this.itemsDocumentoDataGridView.Size = new System.Drawing.Size(657, 212);
            this.itemsDocumentoDataGridView.TabIndex = 5;
            // 
            // documentoBindingSource
            // 
            this.documentoBindingSource.DataSource = typeof(Facturador.Module.BusinessObjects.Documento);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Cantidad";
            this.dataGridViewTextBoxColumn2.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DocumentoId";
            this.dataGridViewTextBoxColumn3.HeaderText = "DocumentoId";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Documento";
            this.dataGridViewTextBoxColumn4.HeaderText = "Documento";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // clienteIdLabel
            // 
            clienteIdLabel.AutoSize = true;
            clienteIdLabel.Location = new System.Drawing.Point(36, 89);
            clienteIdLabel.Name = "clienteIdLabel";
            clienteIdLabel.Size = new System.Drawing.Size(54, 13);
            clienteIdLabel.TabIndex = 5;
            clienteIdLabel.Text = "Cliente Id:";
            // 
            // clienteIdComboBox
            // 
            this.clienteIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.documentoBindingSource, "ClienteId", true));
            this.clienteIdComboBox.FormattingEnabled = true;
            this.clienteIdComboBox.Location = new System.Drawing.Point(96, 86);
            this.clienteIdComboBox.Name = "clienteIdComboBox";
            this.clienteIdComboBox.Size = new System.Drawing.Size(121, 21);
            this.clienteIdComboBox.TabIndex = 6;
            // 
            // FDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.documentoBindingNavigator);
            this.Name = "FDocumento";
            this.Controls.SetChildIndex(this.panelDown, 0);
            this.Controls.SetChildIndex(this.splitContainer1, 0);
            this.Controls.SetChildIndex(this.documentoBindingNavigator, 0);
            this.panelDown.ResumeLayout(false);
            this.panelBtns.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentoBindingNavigator)).EndInit();
            this.documentoBindingNavigator.ResumeLayout(false);
            this.documentoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serieTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDocumentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDocumentoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SpinEdit idSpinEdit;
        private System.Windows.Forms.BindingSource documentoBindingSource;
        private DevExpress.XtraEditors.TextEdit serieTextEdit;
        private System.Windows.Forms.BindingNavigator documentoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton documentoBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView itemsDocumentoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource itemsDocumentoBindingSource;
        private System.Windows.Forms.ComboBox clienteIdComboBox;
    }
}
