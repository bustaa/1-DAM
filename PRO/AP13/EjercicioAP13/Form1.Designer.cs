namespace EjercicioAP13
{
    partial class Form1
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.grbSeguros = new System.Windows.Forms.GroupBox();
            this.radTodoRiesgo = new System.Windows.Forms.RadioButton();
            this.radTerceros = new System.Windows.Forms.RadioButton();
            this.radBasico = new System.Windows.Forms.RadioButton();
            this.grbEquipamiento = new System.Windows.Forms.GroupBox();
            this.chkSistemaAudio = new System.Windows.Forms.CheckBox();
            this.chkAireAcondicionado = new System.Windows.Forms.CheckBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtSalida = new System.Windows.Forms.TextBox();
            this.grbSeguros.SuspendLayout();
            this.grbEquipamiento.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(36, 29);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(94, 25);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(136, 29);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(190, 30);
            this.txtNombre.TabIndex = 1;
            // 
            // grbSeguros
            // 
            this.grbSeguros.Controls.Add(this.radTodoRiesgo);
            this.grbSeguros.Controls.Add(this.radTerceros);
            this.grbSeguros.Controls.Add(this.radBasico);
            this.grbSeguros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSeguros.Location = new System.Drawing.Point(52, 89);
            this.grbSeguros.Name = "grbSeguros";
            this.grbSeguros.Size = new System.Drawing.Size(274, 159);
            this.grbSeguros.TabIndex = 2;
            this.grbSeguros.TabStop = false;
            this.grbSeguros.Text = "Seguros";
            // 
            // radTodoRiesgo
            // 
            this.radTodoRiesgo.AutoSize = true;
            this.radTodoRiesgo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTodoRiesgo.Location = new System.Drawing.Point(42, 112);
            this.radTodoRiesgo.Name = "radTodoRiesgo";
            this.radTodoRiesgo.Size = new System.Drawing.Size(144, 29);
            this.radTodoRiesgo.TabIndex = 3;
            this.radTodoRiesgo.TabStop = true;
            this.radTodoRiesgo.Text = "Todo Riesgo";
            this.radTodoRiesgo.UseVisualStyleBackColor = true;
            // 
            // radTerceros
            // 
            this.radTerceros.AutoSize = true;
            this.radTerceros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTerceros.Location = new System.Drawing.Point(42, 77);
            this.radTerceros.Name = "radTerceros";
            this.radTerceros.Size = new System.Drawing.Size(130, 29);
            this.radTerceros.TabIndex = 3;
            this.radTerceros.TabStop = true;
            this.radTerceros.Text = "A Terceros";
            this.radTerceros.UseVisualStyleBackColor = true;
            // 
            // radBasico
            // 
            this.radBasico.AutoSize = true;
            this.radBasico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBasico.Location = new System.Drawing.Point(42, 42);
            this.radBasico.Name = "radBasico";
            this.radBasico.Size = new System.Drawing.Size(92, 29);
            this.radBasico.TabIndex = 3;
            this.radBasico.TabStop = true;
            this.radBasico.Text = "Básico";
            this.radBasico.UseVisualStyleBackColor = true;
            // 
            // grbEquipamiento
            // 
            this.grbEquipamiento.Controls.Add(this.chkSistemaAudio);
            this.grbEquipamiento.Controls.Add(this.chkAireAcondicionado);
            this.grbEquipamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEquipamiento.Location = new System.Drawing.Point(397, 89);
            this.grbEquipamiento.Name = "grbEquipamiento";
            this.grbEquipamiento.Size = new System.Drawing.Size(260, 159);
            this.grbEquipamiento.TabIndex = 3;
            this.grbEquipamiento.TabStop = false;
            this.grbEquipamiento.Text = "Equipamiento";
            // 
            // chkSistemaAudio
            // 
            this.chkSistemaAudio.AutoSize = true;
            this.chkSistemaAudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSistemaAudio.Location = new System.Drawing.Point(27, 78);
            this.chkSistemaAudio.Name = "chkSistemaAudio";
            this.chkSistemaAudio.Size = new System.Drawing.Size(188, 29);
            this.chkSistemaAudio.TabIndex = 1;
            this.chkSistemaAudio.Text = "Sistema de Audio";
            this.chkSistemaAudio.UseVisualStyleBackColor = true;
            // 
            // chkAireAcondicionado
            // 
            this.chkAireAcondicionado.AutoSize = true;
            this.chkAireAcondicionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAireAcondicionado.Location = new System.Drawing.Point(27, 43);
            this.chkAireAcondicionado.Name = "chkAireAcondicionado";
            this.chkAireAcondicionado.Size = new System.Drawing.Size(204, 29);
            this.chkAireAcondicionado.TabIndex = 0;
            this.chkAireAcondicionado.Text = "Aire Acondicionado";
            this.chkAireAcondicionado.UseVisualStyleBackColor = true;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(47, 276);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(160, 25);
            this.lblValor.TabIndex = 4;
            this.lblValor.Text = "Valor Vehiculo:";
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(213, 276);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(125, 30);
            this.txtValor.TabIndex = 5;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(545, 262);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(112, 39);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtSalida
            // 
            this.txtSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalida.Location = new System.Drawing.Point(52, 337);
            this.txtSalida.Multiline = true;
            this.txtSalida.Name = "txtSalida";
            this.txtSalida.Size = new System.Drawing.Size(605, 146);
            this.txtSalida.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 512);
            this.Controls.Add(this.txtSalida);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.grbEquipamiento);
            this.Controls.Add(this.grbSeguros);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbSeguros.ResumeLayout(false);
            this.grbSeguros.PerformLayout();
            this.grbEquipamiento.ResumeLayout(false);
            this.grbEquipamiento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox grbSeguros;
        private System.Windows.Forms.RadioButton radBasico;
        private System.Windows.Forms.RadioButton radTodoRiesgo;
        private System.Windows.Forms.RadioButton radTerceros;
        private System.Windows.Forms.GroupBox grbEquipamiento;
        private System.Windows.Forms.CheckBox chkSistemaAudio;
        private System.Windows.Forms.CheckBox chkAireAcondicionado;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtSalida;
    }
}

