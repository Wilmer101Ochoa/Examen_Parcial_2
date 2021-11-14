
namespace SoporteTecnico.Vista
{
    partial class TiposView
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
            this.groupBoxtipo = new System.Windows.Forms.GroupBox();
            this.comboBoxtipo = new System.Windows.Forms.ComboBox();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxCel = new System.Windows.Forms.GroupBox();
            this.rdb_mantenimiento = new System.Windows.Forms.RadioButton();
            this.rdb_reparacionCel = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Nombrecliente = new System.Windows.Forms.TextBox();
            this.groupBoxtipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBoxCel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxtipo
            // 
            this.groupBoxtipo.Controls.Add(this.comboBoxtipo);
            this.groupBoxtipo.Enabled = false;
            this.groupBoxtipo.Location = new System.Drawing.Point(37, 101);
            this.groupBoxtipo.Name = "groupBoxtipo";
            this.groupBoxtipo.Size = new System.Drawing.Size(269, 80);
            this.groupBoxtipo.TabIndex = 8;
            this.groupBoxtipo.TabStop = false;
            this.groupBoxtipo.Text = "Tipos De Soporte";
            // 
            // comboBoxtipo
            // 
            this.comboBoxtipo.FormattingEnabled = true;
            this.comboBoxtipo.Items.AddRange(new object[] {
            "Celular ",
            "Computo"});
            this.comboBoxtipo.Location = new System.Drawing.Point(6, 34);
            this.comboBoxtipo.Name = "comboBoxtipo";
            this.comboBoxtipo.Size = new System.Drawing.Size(227, 28);
            this.comboBoxtipo.TabIndex = 0;
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Location = new System.Drawing.Point(47, 301);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(86, 30);
            this.btn_nuevo.TabIndex = 9;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = true;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Enabled = false;
            this.btn_guardar.Location = new System.Drawing.Point(139, 301);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(83, 30);
            this.btn_guardar.TabIndex = 11;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Enabled = false;
            this.btn_cancelar.Location = new System.Drawing.Point(229, 301);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(85, 30);
            this.btn_cancelar.TabIndex = 13;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBoxCel
            // 
            this.groupBoxCel.Controls.Add(this.rdb_mantenimiento);
            this.groupBoxCel.Controls.Add(this.rdb_reparacionCel);
            this.groupBoxCel.Enabled = false;
            this.groupBoxCel.Location = new System.Drawing.Point(37, 199);
            this.groupBoxCel.Name = "groupBoxCel";
            this.groupBoxCel.Size = new System.Drawing.Size(277, 80);
            this.groupBoxCel.TabIndex = 14;
            this.groupBoxCel.TabStop = false;
            this.groupBoxCel.Text = "trabajos para ambas Ramas";
            // 
            // rdb_mantenimiento
            // 
            this.rdb_mantenimiento.AutoSize = true;
            this.rdb_mantenimiento.Location = new System.Drawing.Point(135, 34);
            this.rdb_mantenimiento.Name = "rdb_mantenimiento";
            this.rdb_mantenimiento.Size = new System.Drawing.Size(132, 24);
            this.rdb_mantenimiento.TabIndex = 1;
            this.rdb_mantenimiento.TabStop = true;
            this.rdb_mantenimiento.Text = "Mantenimiento";
            this.rdb_mantenimiento.UseVisualStyleBackColor = true;
            // 
            // rdb_reparacionCel
            // 
            this.rdb_reparacionCel.AutoSize = true;
            this.rdb_reparacionCel.Location = new System.Drawing.Point(10, 34);
            this.rdb_reparacionCel.Name = "rdb_reparacionCel";
            this.rdb_reparacionCel.Size = new System.Drawing.Size(109, 24);
            this.rdb_reparacionCel.TabIndex = 0;
            this.rdb_reparacionCel.TabStop = true;
            this.rdb_reparacionCel.Text = "Reparacion";
            this.rdb_reparacionCel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nombre CLiente:";
            // 
            // txt_Nombrecliente
            // 
            this.txt_Nombrecliente.Location = new System.Drawing.Point(167, 26);
            this.txt_Nombrecliente.Name = "txt_Nombrecliente";
            this.txt_Nombrecliente.Size = new System.Drawing.Size(210, 26);
            this.txt_Nombrecliente.TabIndex = 16;
            // 
            // TiposView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(543, 369);
            this.Controls.Add(this.txt_Nombrecliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxCel);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.groupBoxtipo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TiposView";
            this.Text = "Tipos";
            this.groupBoxtipo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBoxCel.ResumeLayout(false);
            this.groupBoxCel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.GroupBox groupBoxtipo;
        public System.Windows.Forms.Button btn_nuevo;
        public System.Windows.Forms.Button btn_guardar;
        public System.Windows.Forms.Button btn_cancelar;
        public System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.ComboBox comboBoxtipo;
        public System.Windows.Forms.GroupBox groupBoxCel;
        public System.Windows.Forms.RadioButton rdb_mantenimiento;
        public System.Windows.Forms.RadioButton rdb_reparacionCel;
        public System.Windows.Forms.TextBox txt_Nombrecliente;
        private System.Windows.Forms.Label label1;
    }
}