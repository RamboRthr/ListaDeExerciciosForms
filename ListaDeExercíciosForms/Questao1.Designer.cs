
namespace ListaDeExercíciosForms
{
    partial class Questao1
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
            this.txtNomePeca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQtdMinima = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQtdMaxima = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(105, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o nome da peça";
            // 
            // txtNomePeca
            // 
            this.txtNomePeca.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNomePeca.Location = new System.Drawing.Point(259, 157);
            this.txtNomePeca.Name = "txtNomePeca";
            this.txtNomePeca.Size = new System.Drawing.Size(100, 22);
            this.txtNomePeca.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(105, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantidade mínima da peça";
            // 
            // txtQtdMinima
            // 
            this.txtQtdMinima.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQtdMinima.Location = new System.Drawing.Point(294, 198);
            this.txtQtdMinima.Name = "txtQtdMinima";
            this.txtQtdMinima.Size = new System.Drawing.Size(100, 22);
            this.txtQtdMinima.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(105, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantidade máxima da peça";
            // 
            // txtQtdMaxima
            // 
            this.txtQtdMaxima.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQtdMaxima.Location = new System.Drawing.Point(298, 241);
            this.txtQtdMaxima.Name = "txtQtdMaxima";
            this.txtQtdMaxima.Size = new System.Drawing.Size(100, 22);
            this.txtQtdMaxima.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(105, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtResultado.Location = new System.Drawing.Point(207, 279);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(191, 51);
            this.txtResultado.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(105, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(273, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Quantidade média de uma peça";
            // 
            // Questao1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ListaDeExercíciosForms.Properties.Resources.white_abstract_background_design_23_2148825582;
            this.ClientSize = new System.Drawing.Size(514, 413);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtQtdMaxima);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQtdMinima);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomePeca);
            this.Controls.Add(this.label1);
            this.Name = "Questao1";
            this.Text = "Questão 1";
            this.Load += new System.EventHandler(this.Questao1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomePeca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQtdMinima;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQtdMaxima;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label txtResultado;
        private System.Windows.Forms.Label label4;
    }
}