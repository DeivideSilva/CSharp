namespace Estaciomamento
{
    partial class Controle_Saida
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
            this.txtdataEntrada = new System.Windows.Forms.TextBox();
            this.txtdatasaida = new System.Windows.Forms.TextBox();
            this.btnfinalizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txthoraEntrada = new System.Windows.Forms.TextBox();
            this.txthoraSaida = new System.Windows.Forms.TextBox();
            this.mskplaca = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtdataEntrada
            // 
            this.txtdataEntrada.Location = new System.Drawing.Point(202, 86);
            this.txtdataEntrada.Name = "txtdataEntrada";
            this.txtdataEntrada.Size = new System.Drawing.Size(75, 20);
            this.txtdataEntrada.TabIndex = 2;
            // 
            // txtdatasaida
            // 
            this.txtdatasaida.Location = new System.Drawing.Point(202, 123);
            this.txtdatasaida.Name = "txtdatasaida";
            this.txtdatasaida.Size = new System.Drawing.Size(75, 20);
            this.txtdatasaida.TabIndex = 2;
            this.txtdatasaida.TextChanged += new System.EventHandler(this.txtdatasaida_TextChanged);
            // 
            // btnfinalizar
            // 
            this.btnfinalizar.Location = new System.Drawing.Point(427, 236);
            this.btnfinalizar.Name = "btnfinalizar";
            this.btnfinalizar.Size = new System.Drawing.Size(75, 23);
            this.btnfinalizar.TabIndex = 3;
            this.btnfinalizar.Text = "Finalizar";
            this.btnfinalizar.UseVisualStyleBackColor = true;
            this.btnfinalizar.Click += new System.EventHandler(this.btnfinalizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Informe a Placa do veiculo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Data/Entrada:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data/Saida:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hora/Entrada:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hora/Saida:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Valor a ser Pago:";
            // 
            // txthoraEntrada
            // 
            this.txthoraEntrada.Location = new System.Drawing.Point(202, 156);
            this.txthoraEntrada.Name = "txthoraEntrada";
            this.txthoraEntrada.Size = new System.Drawing.Size(75, 20);
            this.txthoraEntrada.TabIndex = 11;
            // 
            // txthoraSaida
            // 
            this.txthoraSaida.Location = new System.Drawing.Point(202, 186);
            this.txthoraSaida.Name = "txthoraSaida";
            this.txthoraSaida.Size = new System.Drawing.Size(75, 20);
            this.txthoraSaida.TabIndex = 12;
            // 
            // mskplaca
            // 
            this.mskplaca.Location = new System.Drawing.Point(202, 44);
            this.mskplaca.Mask = "LLL-0000";
            this.mskplaca.Name = "mskplaca";
            this.mskplaca.Size = new System.Drawing.Size(66, 20);
            this.mskplaca.TabIndex = 0;
            this.mskplaca.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(202, 227);
            this.maskedTextBox2.Mask = "$  ";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(75, 20);
            this.maskedTextBox2.TabIndex = 14;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(351, 40);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 15;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // Controle_Saida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 274);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.mskplaca);
            this.Controls.Add(this.txthoraSaida);
            this.Controls.Add(this.txthoraEntrada);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnfinalizar);
            this.Controls.Add(this.txtdatasaida);
            this.Controls.Add(this.txtdataEntrada);
            this.Name = "Controle_Saida";
            this.Text = "Controle_Saida";
            this.Load += new System.EventHandler(this.Controle_Saida_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtdataEntrada;
        private System.Windows.Forms.TextBox txtdatasaida;
        private System.Windows.Forms.Button btnfinalizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txthoraEntrada;
        private System.Windows.Forms.TextBox txthoraSaida;
        private System.Windows.Forms.MaskedTextBox mskplaca;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Button btnPesquisar;
    }
}