
namespace SoporteTecnico.Vista
{
    partial class EstadosView
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxestadoSolicitud = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_cancelar_estado = new System.Windows.Forms.Button();
            this.btn_guardar_estado = new System.Windows.Forms.Button();
            this.btn_nuevo_estado = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nombreCliente = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(129, 46);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha Solicitud :";
            // 
            // comboBoxestadoSolicitud
            // 
            this.comboBoxestadoSolicitud.FormattingEnabled = true;
            this.comboBoxestadoSolicitud.Items.AddRange(new object[] {
            "Sin Resolver",
            "Abierto ",
            "En Espera ",
            "Cerrado "});
            this.comboBoxestadoSolicitud.Location = new System.Drawing.Point(129, 94);
            this.comboBoxestadoSolicitud.Name = "comboBoxestadoSolicitud";
            this.comboBoxestadoSolicitud.Size = new System.Drawing.Size(200, 21);
            this.comboBoxestadoSolicitud.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Estado Solicitud:";
            // 
            // btn_cancelar_estado
            // 
            this.btn_cancelar_estado.Enabled = false;
            this.btn_cancelar_estado.Location = new System.Drawing.Point(310, 146);
            this.btn_cancelar_estado.Name = "btn_cancelar_estado";
            this.btn_cancelar_estado.Size = new System.Drawing.Size(85, 30);
            this.btn_cancelar_estado.TabIndex = 16;
            this.btn_cancelar_estado.Text = "Cancelar";
            this.btn_cancelar_estado.UseVisualStyleBackColor = true;
            // 
            // btn_guardar_estado
            // 
            this.btn_guardar_estado.Enabled = false;
            this.btn_guardar_estado.Location = new System.Drawing.Point(221, 146);
            this.btn_guardar_estado.Name = "btn_guardar_estado";
            this.btn_guardar_estado.Size = new System.Drawing.Size(83, 30);
            this.btn_guardar_estado.TabIndex = 15;
            this.btn_guardar_estado.Text = "Guardar";
            this.btn_guardar_estado.UseVisualStyleBackColor = true;
            // 
            // btn_nuevo_estado
            // 
            this.btn_nuevo_estado.Location = new System.Drawing.Point(129, 146);
            this.btn_nuevo_estado.Name = "btn_nuevo_estado";
            this.btn_nuevo_estado.Size = new System.Drawing.Size(86, 30);
            this.btn_nuevo_estado.TabIndex = 14;
            this.btn_nuevo_estado.Text = "Nuevo";
            this.btn_nuevo_estado.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nombre Cliente :";
            // 
            // txt_nombreCliente
            // 
            this.txt_nombreCliente.Location = new System.Drawing.Point(129, 6);
            this.txt_nombreCliente.Name = "txt_nombreCliente";
            this.txt_nombreCliente.Size = new System.Drawing.Size(200, 20);
            this.txt_nombreCliente.TabIndex = 19;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EstadosView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(524, 197);
            this.Controls.Add(this.txt_nombreCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_cancelar_estado);
            this.Controls.Add(this.btn_guardar_estado);
            this.Controls.Add(this.btn_nuevo_estado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxestadoSolicitud);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "EstadosView";
            this.Text = "Estados";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.ComboBox comboBoxestadoSolicitud;
        public System.Windows.Forms.Button btn_cancelar_estado;
        public System.Windows.Forms.Button btn_guardar_estado;
        public System.Windows.Forms.Button btn_nuevo_estado;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_nombreCliente;
        public System.Windows.Forms.ErrorProvider errorProvider1;
    }
}