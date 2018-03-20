namespace Estaciomamento
{
    partial class Controle_de_Entrada
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txthora = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtdata = new System.Windows.Forms.TextBox();
            this.mskplaca = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe a placa do veiculo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data de Entrada:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hora/Entrada:";
            // 
            // txthora
            // 
            this.txthora.Location = new System.Drawing.Point(186, 168);
            this.txthora.Name = "txthora";
            this.txthora.Size = new System.Drawing.Size(70, 20);
            this.txthora.TabIndex = 5;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(406, 229);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Salvar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtdata
            // 
            this.txtdata.Location = new System.Drawing.Point(186, 110);
            this.txtdata.Name = "txtdata";
            this.txtdata.Size = new System.Drawing.Size(104, 20);
            this.txtdata.TabIndex = 8;
            this.txtdata.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // mskplaca
            // 
            this.mskplaca.Location = new System.Drawing.Point(187, 53);
            this.mskplaca.Mask = "LLL-0000";
            this.mskplaca.Name = "mskplaca";
            this.mskplaca.Size = new System.Drawing.Size(69, 20);
            this.mskplaca.TabIndex = 0;
            // 
            // Controle_de_Entrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 276);
            this.Controls.Add(this.mskplaca);
            this.Controls.Add(this.txtdata);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txthora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Controle_de_Entrada";
            this.Text = "Controle de Entrada";
            this.Load += new System.EventHandler(this.Controle_de_Entrada_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txthora;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtdata;
        private System.Windows.Forms.MaskedTextBox mskplaca;
    }
}