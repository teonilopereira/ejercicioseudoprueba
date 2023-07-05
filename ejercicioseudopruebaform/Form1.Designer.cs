namespace ejercicioseudopruebaform
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
            BTNRESULTADO = new Button();
            BTNCANCELAR = new Button();
            BTNSALIR = new Button();
            textradio = new Label();
            textvolumen = new Label();
            boxradio = new TextBox();
            Boxaltura = new TextBox();
            SuspendLayout();
            // 
            // BTNRESULTADO
            // 
            BTNRESULTADO.Location = new Point(238, 193);
            BTNRESULTADO.Name = "BTNRESULTADO";
            BTNRESULTADO.Size = new Size(167, 103);
            BTNRESULTADO.TabIndex = 0;
            BTNRESULTADO.Text = "RESULTADO   (AREA,VOLUMEN)";
            BTNRESULTADO.UseVisualStyleBackColor = true;
            BTNRESULTADO.Click += BTNRESULTADO_Click;
            // 
            // BTNCANCELAR
            // 
            BTNCANCELAR.Location = new Point(444, 66);
            BTNCANCELAR.Name = "BTNCANCELAR";
            BTNCANCELAR.Size = new Size(145, 34);
            BTNCANCELAR.TabIndex = 1;
            BTNCANCELAR.Text = "CANCELAR";
            BTNCANCELAR.UseVisualStyleBackColor = true;
            BTNCANCELAR.Click += BTNCANCELAR_Click;
            // 
            // BTNSALIR
            // 
            BTNSALIR.Location = new Point(664, 404);
            BTNSALIR.Name = "BTNSALIR";
            BTNSALIR.Size = new Size(112, 34);
            BTNSALIR.TabIndex = 2;
            BTNSALIR.Text = "SALIR";
            BTNSALIR.UseVisualStyleBackColor = true;
            BTNSALIR.Click += BTNSALIR_Click;
            // 
            // textradio
            // 
            textradio.AutoSize = true;
            textradio.Location = new Point(54, 44);
            textradio.Name = "textradio";
            textradio.Size = new Size(143, 25);
            textradio.TabIndex = 3;
            textradio.Text = "Ingrese el radio :";
            // 
            // textvolumen
            // 
            textvolumen.AutoSize = true;
            textvolumen.Location = new Point(54, 114);
            textvolumen.Name = "textvolumen";
            textvolumen.Size = new Size(146, 25);
            textvolumen.TabIndex = 4;
            textvolumen.Text = "Ingrese el altura :";
            // 
            // boxradio
            // 
            boxradio.Location = new Point(238, 41);
            boxradio.Name = "boxradio";
            boxradio.Size = new Size(150, 31);
            boxradio.TabIndex = 5;
            // 
            // Boxaltura
            // 
            Boxaltura.Location = new Point(238, 111);
            Boxaltura.Name = "Boxaltura";
            Boxaltura.Size = new Size(150, 31);
            Boxaltura.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Boxaltura);
            Controls.Add(boxradio);
            Controls.Add(textvolumen);
            Controls.Add(textradio);
            Controls.Add(BTNSALIR);
            Controls.Add(BTNCANCELAR);
            Controls.Add(BTNRESULTADO);
            Name = "Form1";
            Text = "CALCULAR: AREA,VOLUMEN";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTNRESULTADO;
        private Button BTNCANCELAR;
        private Button BTNSALIR;
        private Label textradio;
        private Label textvolumen;
        private TextBox boxradio;
        private TextBox Boxaltura;
    }
}