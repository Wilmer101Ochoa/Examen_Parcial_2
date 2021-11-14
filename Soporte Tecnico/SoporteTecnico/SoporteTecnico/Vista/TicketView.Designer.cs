
namespace SoporteTecnico.Vista
{
    partial class TicketView
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nomClienteTicked = new System.Windows.Forms.TextBox();
            this.btn_generar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.txt_tipo_soporteTicked = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_generado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Cliente:";
            // 
            // txt_nomClienteTicked
            // 
            this.txt_nomClienteTicked.Location = new System.Drawing.Point(31, 49);
            this.txt_nomClienteTicked.Name = "txt_nomClienteTicked";
            this.txt_nomClienteTicked.ReadOnly = true;
            this.txt_nomClienteTicked.Size = new System.Drawing.Size(123, 20);
            this.txt_nomClienteTicked.TabIndex = 1;
            // 
            // btn_generar
            // 
            this.btn_generar.Location = new System.Drawing.Point(114, 211);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(75, 23);
            this.btn_generar.TabIndex = 4;
            this.btn_generar.Text = "Generar";
            this.btn_generar.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(195, 211);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 6;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // txt_tipo_soporteTicked
            // 
            this.txt_tipo_soporteTicked.Location = new System.Drawing.Point(236, 49);
            this.txt_tipo_soporteTicked.Name = "txt_tipo_soporteTicked";
            this.txt_tipo_soporteTicked.ReadOnly = true;
            this.txt_tipo_soporteTicked.Size = new System.Drawing.Size(123, 20);
            this.txt_tipo_soporteTicked.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tipo de Soporte :";
            // 
            // txt_generado
            // 
            this.txt_generado.Location = new System.Drawing.Point(160, 141);
            this.txt_generado.Name = "txt_generado";
            this.txt_generado.ReadOnly = true;
            this.txt_generado.Size = new System.Drawing.Size(100, 20);
            this.txt_generado.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ticked Generado:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // TicketView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(508, 273);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_generado);
            this.Controls.Add(this.txt_tipo_soporteTicked);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_generar);
            this.Controls.Add(this.txt_nomClienteTicked);
            this.Controls.Add(this.label1);
            this.Name = "TicketView";
            this.Text = "TicketView";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_nomClienteTicked;
        public System.Windows.Forms.Button btn_generar;
        public System.Windows.Forms.Button btn_cancelar;
        public System.Windows.Forms.TextBox txt_tipo_soporteTicked;
        public System.Windows.Forms.TextBox txt_generado;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ErrorProvider errorProvider1;
    }
}