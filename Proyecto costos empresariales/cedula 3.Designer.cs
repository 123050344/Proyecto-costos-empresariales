namespace Proyecto_costos_empresariales
{
    partial class cedula_3
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
            btnCalcular = new Button();
            lblCostoInventario = new Label();
            txtCostoInventarioFinal = new TextBox();
            lbl = new Label();
            btnSiguiente = new Button();
            txtCostoTotalMPInventario = new TextBox();
            txtCostoTotalMOInventario = new TextBox();
            txtCostoTotalCIInventario = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
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
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(212, 355);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(245, 50);
            btnCalcular.TabIndex = 10;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblCostoInventario
            // 
            lblCostoInventario.AutoSize = true;
            lblCostoInventario.Location = new Point(437, 185);
            lblCostoInventario.Name = "lblCostoInventario";
            lblCostoInventario.Size = new Size(132, 15);
            lblCostoInventario.TabIndex = 12;
            lblCostoInventario.Text = "Total de Inventario Final";
            // 
            // txtCostoInventarioFinal
            // 
            txtCostoInventarioFinal.Location = new Point(437, 203);
            txtCostoInventarioFinal.Name = "txtCostoInventarioFinal";
            txtCostoInventarioFinal.Size = new Size(175, 23);
            txtCostoInventarioFinal.TabIndex = 15;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl.Location = new Point(238, 26);
            lbl.Name = "lbl";
            lbl.Size = new Size(196, 30);
            lbl.TabIndex = 16;
            lbl.Text = "Inventarios Finales";
            // 
            // btnSiguiente
            // 
            btnSiguiente.BackColor = Color.FromArgb(128, 128, 255);
            btnSiguiente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSiguiente.Location = new Point(540, 363);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(131, 42);
            btnSiguiente.TabIndex = 17;
            btnSiguiente.Text = "SIGUIENTE";
            btnSiguiente.UseVisualStyleBackColor = false;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // txtCostoTotalMPInventario
            // 
            txtCostoTotalMPInventario.Location = new Point(84, 122);
            txtCostoTotalMPInventario.Name = "txtCostoTotalMPInventario";
            txtCostoTotalMPInventario.Size = new Size(175, 23);
            txtCostoTotalMPInventario.TabIndex = 18;
            // 
            // txtCostoTotalMOInventario
            // 
            txtCostoTotalMOInventario.Location = new Point(84, 203);
            txtCostoTotalMOInventario.Name = "txtCostoTotalMOInventario";
            txtCostoTotalMOInventario.Size = new Size(175, 23);
            txtCostoTotalMOInventario.TabIndex = 19;
            // 
            // txtCostoTotalCIInventario
            // 
            txtCostoTotalCIInventario.Location = new Point(84, 283);
            txtCostoTotalCIInventario.Name = "txtCostoTotalCIInventario";
            txtCostoTotalCIInventario.Size = new Size(175, 23);
            txtCostoTotalCIInventario.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 104);
            label1.Name = "label1";
            label1.Size = new Size(143, 15);
            label1.TabIndex = 21;
            label1.Text = "Costo Total Materia Prima";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 185);
            label2.Name = "label2";
            label2.Size = new Size(145, 15);
            label2.TabIndex = 22;
            label2.Text = "Costo Total Mano de Obra";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(84, 265);
            label3.Name = "label3";
            label3.Size = new Size(160, 15);
            label3.TabIndex = 23;
            label3.Text = "Costo Total Costos Indirectos";
            // 
            // cedula_3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(683, 417);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCostoTotalCIInventario);
            Controls.Add(txtCostoTotalMOInventario);
            Controls.Add(txtCostoTotalMPInventario);
            Controls.Add(btnSiguiente);
            Controls.Add(lbl);
            Controls.Add(txtCostoInventarioFinal);
            Controls.Add(lblCostoInventario);
            Controls.Add(btnCalcular);
            Controls.Add(btnRegresar);
            Name = "cedula_3";
            Text = "cedula_3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegresar;
        private Button btnCalcular;
        private Label lblCostoInventario;
        private TextBox txtCostoInventarioFinal;
        private Label lbl;
        private Button btnSiguiente;
        private TextBox txtCostoTotalMPInventario;
        private TextBox txtCostoTotalMOInventario;
        private TextBox txtCostoTotalCIInventario;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}