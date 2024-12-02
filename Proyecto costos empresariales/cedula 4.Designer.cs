namespace Proyecto_costos_empresariales
{
    partial class cedula_4
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
            label1 = new Label();
            label2 = new Label();
            txtGranTotal = new TextBox();
            btnCalcular = new Button();
            txtMostrarInventarioFinal = new TextBox();
            txtMostrarProduccionTerminada = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnSalir = new Button();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(252, 258);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 10;
            label1.Text = "Gran Total";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(225, 26);
            label2.Name = "label2";
            label2.Size = new Size(114, 30);
            label2.TabIndex = 11;
            label2.Text = "Gran Total";
            // 
            // txtGranTotal
            // 
            txtGranTotal.Location = new Point(195, 276);
            txtGranTotal.Name = "txtGranTotal";
            txtGranTotal.Size = new Size(167, 23);
            txtGranTotal.TabIndex = 12;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(160, 349);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(243, 50);
            btnCalcular.TabIndex = 13;
            btnCalcular.Text = "Calcular";
            btnCalcular.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtMostrarInventarioFinal
            // 
            txtMostrarInventarioFinal.Location = new Point(195, 157);
            txtMostrarInventarioFinal.Name = "txtMostrarInventarioFinal";
            txtMostrarInventarioFinal.Size = new Size(167, 23);
            txtMostrarInventarioFinal.TabIndex = 14;
            // 
            // txtMostrarProduccionTerminada
            // 
            txtMostrarProduccionTerminada.Location = new Point(195, 99);
            txtMostrarProduccionTerminada.Name = "txtMostrarProduccionTerminada";
            txtMostrarProduccionTerminada.Size = new Size(167, 23);
            txtMostrarProduccionTerminada.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(195, 81);
            label3.Name = "label3";
            label3.Size = new Size(160, 15);
            label3.TabIndex = 17;
            label3.Text = "Costo Producción Terminada";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(195, 139);
            label4.Name = "label4";
            label4.Size = new Size(122, 15);
            label4.TabIndex = 18;
            label4.Text = "Costo Inventario Final";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(128, 128, 255);
            btnSalir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(466, 12);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(90, 44);
            btnSalir.TabIndex = 19;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // cedula_4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(568, 411);
            Controls.Add(btnSalir);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtMostrarProduccionTerminada);
            Controls.Add(txtMostrarInventarioFinal);
            Controls.Add(btnCalcular);
            Controls.Add(txtGranTotal);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRegresar);
            Name = "cedula_4";
            Text = "cedula_4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegresar;
        private Label label1;
        private Label label2;
        private TextBox txtGranTotal;
        private Button btnCalcular;
        private TextBox txtMostrarInventarioFinal;
        private TextBox txtMostrarProduccionTerminada;
        private Label label3;
        private Label label4;
        private Button btnSalir;
    }
}