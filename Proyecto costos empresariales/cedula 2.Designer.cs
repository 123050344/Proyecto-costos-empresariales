namespace Proyecto_costos_empresariales
{
    partial class cedula_2
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
            btnRegresar = new Button();
            lblProduccionTerminada = new Label();
            txtCostoProduccionTerminada = new TextBox();
            label3 = new Label();
            btnCalcular = new Button();
            btnSiguiente = new Button();
            txtCostoTotalMP = new TextBox();
            txtCostoTotalMO = new TextBox();
            txtCostoTotalCI = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.FromArgb(128, 128, 255);
            btnRegresar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresar.Location = new Point(12, 12);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(90, 44);
            btnRegresar.TabIndex = 9;
            btnRegresar.Text = "INICIO";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // lblProduccionTerminada
            // 
            lblProduccionTerminada.AutoSize = true;
            lblProduccionTerminada.Location = new Point(420, 180);
            lblProduccionTerminada.Name = "lblProduccionTerminada";
            lblProduccionTerminada.Size = new Size(170, 15);
            lblProduccionTerminada.TabIndex = 10;
            lblProduccionTerminada.Text = "Total de Producción Terminada";
            // 
            // txtCostoProduccionTerminada
            // 
            txtCostoProduccionTerminada.Location = new Point(420, 198);
            txtCostoProduccionTerminada.Name = "txtCostoProduccionTerminada";
            txtCostoProduccionTerminada.Size = new Size(175, 23);
            txtCostoProduccionTerminada.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(239, 26);
            label3.Name = "label3";
            label3.Size = new Size(233, 30);
            label3.TabIndex = 14;
            label3.Text = "Producción Terminada";
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(233, 357);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(239, 52);
            btnCalcular.TabIndex = 15;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.BackColor = Color.FromArgb(128, 128, 255);
            btnSiguiente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSiguiente.Location = new Point(542, 367);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(131, 42);
            btnSiguiente.TabIndex = 16;
            btnSiguiente.Text = "SIGUIENTE";
            btnSiguiente.UseVisualStyleBackColor = false;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // txtCostoTotalMP
            // 
            txtCostoTotalMP.Location = new Point(83, 124);
            txtCostoTotalMP.Name = "txtCostoTotalMP";
            txtCostoTotalMP.Size = new Size(175, 23);
            txtCostoTotalMP.TabIndex = 17;
            // 
            // txtCostoTotalMO
            // 
            txtCostoTotalMO.Location = new Point(83, 198);
            txtCostoTotalMO.Name = "txtCostoTotalMO";
            txtCostoTotalMO.Size = new Size(175, 23);
            txtCostoTotalMO.TabIndex = 18;
            // 
            // txtCostoTotalCI
            // 
            txtCostoTotalCI.Location = new Point(83, 269);
            txtCostoTotalCI.Name = "txtCostoTotalCI";
            txtCostoTotalCI.Size = new Size(175, 23);
            txtCostoTotalCI.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 106);
            label1.Name = "label1";
            label1.Size = new Size(143, 15);
            label1.TabIndex = 20;
            label1.Text = "Costo Total Materia Prima";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 180);
            label2.Name = "label2";
            label2.Size = new Size(145, 15);
            label2.TabIndex = 21;
            label2.Text = "Costo Total Mano de Obra";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(83, 251);
            label4.Name = "label4";
            label4.Size = new Size(160, 15);
            label4.TabIndex = 22;
            label4.Text = "Costo Total Costos Indirectos";
            // 
            // cedula_2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(685, 421);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCostoTotalCI);
            Controls.Add(txtCostoTotalMO);
            Controls.Add(txtCostoTotalMP);
            Controls.Add(btnSiguiente);
            Controls.Add(btnCalcular);
            Controls.Add(label3);
            Controls.Add(txtCostoProduccionTerminada);
            Controls.Add(lblProduccionTerminada);
            Controls.Add(btnRegresar);
            Name = "cedula_2";
            Text = "cedula_2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegresar;
        private Label lblProduccionTerminada;
        private TextBox txtCostoProduccionTerminada;
        private Label label3;
        private Button btnCalcular;
        private Button btnSiguiente;
        private TextBox txtCostoTotalMP;
        private TextBox txtCostoTotalMO;
        private TextBox txtCostoTotalCI;
        private Label label1;
        private Label label2;
        private Label label4;
    }
}