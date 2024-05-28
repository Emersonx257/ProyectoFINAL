namespace ProyectoFINAL
{
    partial class FormularioSolicitud
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
            panel1 = new Panel();
            panel3 = new Panel();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            txtInfoPrecio = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            numericBomba = new NumericUpDown();
            txtPrecio = new TextBox();
            txtLitros = new TextBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericBomba).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(467, 370);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 245);
            panel3.Name = "panel3";
            panel3.Size = new Size(467, 125);
            panel3.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(213, 52);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(323, 52);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(467, 370);
            panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtInfoPrecio);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(numericBomba);
            groupBox1.Controls.Add(txtPrecio);
            groupBox1.Controls.Add(txtLitros);
            groupBox1.Location = new Point(12, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(443, 209);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Formulario";
            // 
            // txtInfoPrecio
            // 
            txtInfoPrecio.Enabled = false;
            txtInfoPrecio.Location = new Point(120, 169);
            txtInfoPrecio.Name = "txtInfoPrecio";
            txtInfoPrecio.ReadOnly = true;
            txtInfoPrecio.Size = new Size(151, 27);
            txtInfoPrecio.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 172);
            label4.Name = "label4";
            label4.Size = new Size(101, 20);
            label4.TabIndex = 6;
            label4.Text = "Precio - Litro: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(142, 94);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 5;
            label3.Text = "Cantidad Precio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(150, 127);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 4;
            label2.Text = "Cantidad litros:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 56);
            label1.Name = "label1";
            label1.Size = new Size(139, 20);
            label1.TabIndex = 3;
            label1.Text = "Número de bomba:";
            // 
            // numericBomba
            // 
            numericBomba.Location = new Point(295, 54);
            numericBomba.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            numericBomba.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericBomba.Name = "numericBomba";
            numericBomba.Size = new Size(125, 27);
            numericBomba.TabIndex = 2;
            numericBomba.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericBomba.ValueChanged += numericBomba_ValueChanged;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(295, 94);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(125, 27);
            txtPrecio.TabIndex = 1;
            txtPrecio.TextChanged += txtPrecio_TextChanged;
            // 
            // txtLitros
            // 
            txtLitros.Location = new Point(295, 127);
            txtLitros.Name = "txtLitros";
            txtLitros.Size = new Size(125, 27);
            txtLitros.TabIndex = 0;
            txtLitros.TextChanged += txtLitros_TextChanged;
            // 
            // FormularioSolicitud
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 370);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MaximizeBox = false;
            MaximumSize = new Size(485, 417);
            MinimizeBox = false;
            MinimumSize = new Size(485, 417);
            Name = "FormularioSolicitud";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Solicitud";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericBomba).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Button button2;
        private Button button1;
        private Panel panel2;
        private GroupBox groupBox1;
        private NumericUpDown numericBomba;
        private TextBox txtPrecio;
        private TextBox txtLitros;
        private TextBox txtInfoPrecio;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}