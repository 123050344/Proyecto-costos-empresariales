namespace Proyecto_costos_empresariales
{
    partial class cedula_1
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
            lblCostoUnitarioMP = new Label();
            lblCostoUnitarioMO = new Label();
            lblCostoUnitarioCI = new Label();
            txtCostoMP = new TextBox();
            txtCostoMO = new TextBox();
            txtCostoCI = new TextBox();
            btnCalcular = new Button();
            label4 = new Label();
            btnRegresar = new Button();
            btnSiguiente = new Button();
            txtTotalMP = new TextBox();
            txtTotalMO = new TextBox();
            txtTotalCI = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // lblCostoUnitarioMP
            // 
            lblCostoUnitarioMP.AutoSize = true;
            lblCostoUnitarioMP.Location = new Point(111, 99);
            lblCostoUnitarioMP.Name = "lblCostoUnitarioMP";
            lblCostoUnitarioMP.Size = new Size(160, 15);
            lblCostoUnitarioMP.TabIndex = 0;
            lblCostoUnitarioMP.Text = "Costo Unitario Materia Prima";
            // 
            // lblCostoUnitarioMO
            // 
            lblCostoUnitarioMO.AutoSize = true;
            lblCostoUnitarioMO.Location = new Point(109, 180);
            lblCostoUnitarioMO.Name = "lblCostoUnitarioMO";
            lblCostoUnitarioMO.Size = new Size(162, 15);
            lblCostoUnitarioMO.TabIndex = 1;
            lblCostoUnitarioMO.Text = "Costo Unitario Mano de Obra";
            // 
            // lblCostoUnitarioCI
            // 
            lblCostoUnitarioCI.AutoSize = true;
            lblCostoUnitarioCI.Location = new Point(111, 266);
            lblCostoUnitarioCI.Name = "lblCostoUnitarioCI";
            lblCostoUnitarioCI.Size = new Size(177, 15);
            lblCostoUnitarioCI.TabIndex = 2;
            lblCostoUnitarioCI.Text = "Costo Unitario Costos Indirectos";
            // 
            // txtCostoMP
            // 
            txtCostoMP.Location = new Point(111, 117);
            txtCostoMP.Name = "txtCostoMP";
            txtCostoMP.Size = new Size(176, 23);
            txtCostoMP.TabIndex = 3;
            // 
            // txtCostoMO
            // 
            txtCostoMO.Location = new Point(111, 198);
            txtCostoMO.Name = "txtCostoMO";
            txtCostoMO.Size = new Size(176, 23);
            txtCostoMO.TabIndex = 4;
            // 
            // txtCostoCI
            // 
            txtCostoCI.Location = new Point(111, 284);
            txtCostoCI.Name = "txtCostoCI";
            txtCostoCI.Size = new Size(176, 23);
            txtCostoCI.TabIndex = 5;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(265, 365);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(234, 53);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(269, 26);
            label4.Name = "label4";
            label4.Size = new Size(230, 30);
            label4.TabIndex = 7;
            label4.Text = "Producción Procesada";
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.FromArgb(128, 128, 255);
            btnRegresar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresar.Location = new Point(12, 12);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(90, 44);
            btnRegresar.TabIndex = 8;
            btnRegresar.Text = "INICIO";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.BackColor = Color.FromArgb(128, 128, 255);
            btnSiguiente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSiguiente.Location = new Point(657, 396);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(131, 42);
            btnSiguiente.TabIndex = 9;
            btnSiguiente.Text = "SIGUIENTE";
            btnSiguiente.UseVisualStyleBackColor = false;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // txtTotalMP
            // 
            txtTotalMP.Location = new Point(482, 117);
            txtTotalMP.Name = "txtTotalMP";
            txtTotalMP.Size = new Size(176, 23);
            txtTotalMP.TabIndex = 10;
            // 
            // txtTotalMO
            // 
            txtTotalMO.Location = new Point(482, 198);
            txtTotalMO.Name = "txtTotalMO";
            txtTotalMO.Size = new Size(176, 23);
            txtTotalMO.TabIndex = 11;
            // 
            // txtTotalCI
            // 
            txtTotalCI.Location = new Point(482, 284);
            txtTotalCI.Name = "txtTotalCI";
            txtTotalCI.Size = new Size(176, 23);
            txtTotalCI.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(482, 180);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 13;
            label1.Text = "Costo Total MO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(482, 266);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 14;
            label2.Text = "Costo Total CI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(482, 99);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 15;
            label3.Text = "Costo Total MP";
            // 
            // cedula_1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTotalCI);
            Controls.Add(txtTotalMO);
            Controls.Add(txtTotalMP);
            Controls.Add(btnSiguiente);
            Controls.Add(btnRegresar);
            Controls.Add(label4);
            Controls.Add(btnCalcular);
            Controls.Add(txtCostoCI);
            Controls.Add(txtCostoMO);
            Controls.Add(txtCostoMP);
            Controls.Add(lblCostoUnitarioCI);
            Controls.Add(lblCostoUnitarioMO);
            Controls.Add(lblCostoUnitarioMP);
            Name = "cedula_1";
            Text = "cedula_1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCostoUnitarioMP;
        private Label lblCostoUnitarioMO;
        private Label lblCostoUnitarioCI;
        private TextBox txtCostoMP;
        private TextBox txtCostoMO;
        private TextBox txtCostoCI;
        private Button btnCalcular;
        private Label label4;
        private Button btnRegresar;
        private Button btnSiguiente;
        private TextBox txtTotalMP;
        private TextBox txtTotalMO;
        private TextBox txtTotalCI;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}