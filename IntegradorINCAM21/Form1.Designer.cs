namespace IntegradorINCAM21
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cTipoTornillo = new ComboBox();
            bGuardar = new Button();
            bVerDatos = new Button();
            tVerDatos = new TextBox();
            label1 = new Label();
            label2 = new Label();
            cOpciones = new ComboBox();
            label3 = new Label();
            tLargo = new TextBox();
            tAncho = new TextBox();
            label4 = new Label();
            label5 = new Label();
            tGrosor = new TextBox();
            tDiametro = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // cTipoTornillo
            // 
            cTipoTornillo.BackColor = SystemColors.Info;
            cTipoTornillo.FormattingEnabled = true;
            cTipoTornillo.Items.AddRange(new object[] { "Madera", "Concreto", "Metal" });
            cTipoTornillo.Location = new Point(150, 246);
            cTipoTornillo.Name = "cTipoTornillo";
            cTipoTornillo.Size = new Size(206, 24);
            cTipoTornillo.TabIndex = 0;
            cTipoTornillo.SelectedIndexChanged += cTipoTornillo_SelectedIndexChanged;
            // 
            // bGuardar
            // 
            bGuardar.Location = new Point(150, 368);
            bGuardar.Name = "bGuardar";
            bGuardar.Size = new Size(86, 24);
            bGuardar.TabIndex = 1;
            bGuardar.Text = "Guardar";
            bGuardar.UseVisualStyleBackColor = true;
            bGuardar.Click += bGuardar_Click;
            // 
            // bVerDatos
            // 
            bVerDatos.Location = new Point(584, 368);
            bVerDatos.Name = "bVerDatos";
            bVerDatos.Size = new Size(86, 24);
            bVerDatos.TabIndex = 2;
            bVerDatos.Text = "Ver Datos";
            bVerDatos.UseVisualStyleBackColor = true;
            bVerDatos.Click += bVerDatos_Click;
            // 
            // tVerDatos
            // 
            tVerDatos.BackColor = SystemColors.ScrollBar;
            tVerDatos.Location = new Point(369, 2);
            tVerDatos.Margin = new Padding(2, 3, 2, 3);
            tVerDatos.Multiline = true;
            tVerDatos.Name = "tVerDatos";
            tVerDatos.ReadOnly = true;
            tVerDatos.Size = new Size(534, 343);
            tVerDatos.TabIndex = 3;
            tVerDatos.TextChanged += tVerDatos_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 254);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(135, 16);
            label1.TabIndex = 4;
            label1.Text = "Tipo de Tornillo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 20);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(103, 16);
            label2.TabIndex = 5;
            label2.Text = "Herramientas";
            // 
            // cOpciones
            // 
            cOpciones.BackColor = SystemColors.Info;
            cOpciones.FormattingEnabled = true;
            cOpciones.Items.AddRange(new object[] { "Vernier", "Micrometro", "Flexometro" });
            cOpciones.Location = new Point(150, 17);
            cOpciones.Margin = new Padding(2, 3, 2, 3);
            cOpciones.Name = "cOpciones";
            cOpciones.Size = new Size(206, 24);
            cOpciones.TabIndex = 6;
            cOpciones.SelectedIndexChanged += cOpciones_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 60);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(47, 16);
            label3.TabIndex = 7;
            label3.Text = "Largo";
            // 
            // tLargo
            // 
            tLargo.BackColor = SystemColors.GradientInactiveCaption;
            tLargo.Location = new Point(150, 61);
            tLargo.Margin = new Padding(2, 3, 2, 3);
            tLargo.Name = "tLargo";
            tLargo.Size = new Size(206, 26);
            tLargo.TabIndex = 8;
            tLargo.TextChanged += tLargo_TextChanged;
            // 
            // tAncho
            // 
            tAncho.BackColor = SystemColors.GradientInactiveCaption;
            tAncho.Location = new Point(150, 108);
            tAncho.Margin = new Padding(2, 3, 2, 3);
            tAncho.Name = "tAncho";
            tAncho.Size = new Size(206, 26);
            tAncho.TabIndex = 9;
            tAncho.TextChanged += tAncho_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 107);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(47, 16);
            label4.TabIndex = 10;
            label4.Text = "Ancho";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 148);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(55, 16);
            label5.TabIndex = 11;
            label5.Text = "Grosor";
            // 
            // tGrosor
            // 
            tGrosor.BackColor = SystemColors.GradientInactiveCaption;
            tGrosor.Location = new Point(150, 150);
            tGrosor.Margin = new Padding(2, 3, 2, 3);
            tGrosor.Name = "tGrosor";
            tGrosor.Size = new Size(206, 26);
            tGrosor.TabIndex = 12;
            tGrosor.TextChanged += tGrosor_TextChanged;
            // 
            // tDiametro
            // 
            tDiametro.BackColor = SystemColors.GradientInactiveCaption;
            tDiametro.Location = new Point(150, 201);
            tDiametro.Margin = new Padding(2, 3, 2, 3);
            tDiametro.Name = "tDiametro";
            tDiametro.Size = new Size(206, 26);
            tDiametro.TabIndex = 13;
            tDiametro.TextChanged += tDiametro_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 200);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(71, 16);
            label6.TabIndex = 14;
            label6.Text = "Diametro";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(914, 418);
            Controls.Add(label6);
            Controls.Add(tDiametro);
            Controls.Add(tGrosor);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(tAncho);
            Controls.Add(tLargo);
            Controls.Add(label3);
            Controls.Add(cOpciones);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tVerDatos);
            Controls.Add(bVerDatos);
            Controls.Add(bGuardar);
            Controls.Add(cTipoTornillo);
            Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            HelpButton = true;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Proyecto INCAM21";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cTipoTornillo;
        private Button bGuardar;
        private Button bVerDatos;
        private TextBox tVerDatos;
        private Label label1;
        private Label label2;
        private ComboBox cOpciones;
        private Label label3;
        private TextBox tLargo;
        private TextBox tAncho;
        private Label label4;
        private Label label5;
        private TextBox tGrosor;
        private TextBox tDiametro;
        private Label label6;
    }
}
