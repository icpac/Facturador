
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelRfc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceClnt)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSourceClnt
            // 
            this.bindingSourceClnt.DataSource = typeof(Facturador.Module.BusinessObjects.Cliente);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceClnt, "Rfc", true));
            this.textBox1.Location = new System.Drawing.Point(88, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // labelRfc
            // 
            this.labelRfc.AutoSize = true;
            this.labelRfc.Location = new System.Drawing.Point(27, 34);
            this.labelRfc.Name = "labelRfc";
            this.labelRfc.Size = new System.Drawing.Size(24, 13);
            this.labelRfc.TabIndex = 1;
            this.labelRfc.Text = "Rfc";
            // 
            // FCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelRfc);
            this.Controls.Add(this.textBox1);
            this.Name = "FCliente";
            this.Text = "FormCliente";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceClnt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSourceClnt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelRfc;
    }
}