
namespace SoporteTecnico.Vista
{
    partial class DetalleView
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
            this.btn_visualizar = new System.Windows.Forms.Button();
            this.dataGridViewVisual = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisual)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_visualizar
            // 
            this.btn_visualizar.Location = new System.Drawing.Point(12, 274);
            this.btn_visualizar.Name = "btn_visualizar";
            this.btn_visualizar.Size = new System.Drawing.Size(75, 23);
            this.btn_visualizar.TabIndex = 0;
            this.btn_visualizar.Text = "Visualizar";
            this.btn_visualizar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewVisual
            // 
            this.dataGridViewVisual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewVisual.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dataGridViewVisual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVisual.Location = new System.Drawing.Point(2, 1);
            this.dataGridViewVisual.Name = "dataGridViewVisual";
            this.dataGridViewVisual.Size = new System.Drawing.Size(709, 267);
            this.dataGridViewVisual.TabIndex = 1;
            // 
            // DetalleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(709, 319);
            this.Controls.Add(this.dataGridViewVisual);
            this.Controls.Add(this.btn_visualizar);
            this.Name = "DetalleView";
            this.Text = "Detalle";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisual)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btn_visualizar;
        public System.Windows.Forms.DataGridView dataGridViewVisual;
    }
}