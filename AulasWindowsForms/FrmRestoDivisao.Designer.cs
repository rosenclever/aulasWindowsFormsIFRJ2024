namespace AulasWindowsForms
{
    partial class FrmRestoDivisao
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
            LblDividendo = new Label();
            TxtDividendo = new TextBox();
            LblDivisor = new Label();
            TxtDivisor = new TextBox();
            BtnRestoDaDivisao = new Button();
            LblResto = new Label();
            TxtResto = new TextBox();
            SuspendLayout();
            // 
            // LblDividendo
            // 
            LblDividendo.AutoSize = true;
            LblDividendo.Location = new Point(44, 25);
            LblDividendo.Name = "LblDividendo";
            LblDividendo.Size = new Size(64, 15);
            LblDividendo.TabIndex = 0;
            LblDividendo.Text = "Dividendo:";
            // 
            // TxtDividendo
            // 
            TxtDividendo.Location = new Point(114, 22);
            TxtDividendo.Name = "TxtDividendo";
            TxtDividendo.Size = new Size(100, 23);
            TxtDividendo.TabIndex = 0;
            // 
            // LblDivisor
            // 
            LblDivisor.AutoSize = true;
            LblDivisor.Location = new Point(236, 25);
            LblDivisor.Name = "LblDivisor";
            LblDivisor.Size = new Size(46, 15);
            LblDivisor.TabIndex = 2;
            LblDivisor.Text = "Divisor:";
            // 
            // TxtDivisor
            // 
            TxtDivisor.Location = new Point(288, 22);
            TxtDivisor.Name = "TxtDivisor";
            TxtDivisor.Size = new Size(100, 23);
            TxtDivisor.TabIndex = 1;
            // 
            // BtnRestoDaDivisao
            // 
            BtnRestoDaDivisao.Location = new Point(44, 67);
            BtnRestoDaDivisao.Name = "BtnRestoDaDivisao";
            BtnRestoDaDivisao.Size = new Size(170, 23);
            BtnRestoDaDivisao.TabIndex = 2;
            BtnRestoDaDivisao.Text = "Resto da Divisão";
            BtnRestoDaDivisao.UseVisualStyleBackColor = true;
            BtnRestoDaDivisao.Click += BtnRestoDaDivisao_Click;
            // 
            // LblResto
            // 
            LblResto.AutoSize = true;
            LblResto.Location = new Point(243, 67);
            LblResto.Name = "LblResto";
            LblResto.Size = new Size(39, 15);
            LblResto.TabIndex = 5;
            LblResto.Text = "Resto:";
            // 
            // TxtResto
            // 
            TxtResto.Enabled = false;
            TxtResto.Location = new Point(288, 64);
            TxtResto.Name = "TxtResto";
            TxtResto.ReadOnly = true;
            TxtResto.Size = new Size(100, 23);
            TxtResto.TabIndex = 6;
            TxtResto.TabStop = false;
            // 
            // FrmRestoDivisao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 110);
            Controls.Add(TxtResto);
            Controls.Add(LblResto);
            Controls.Add(BtnRestoDaDivisao);
            Controls.Add(TxtDivisor);
            Controls.Add(LblDivisor);
            Controls.Add(TxtDividendo);
            Controls.Add(LblDividendo);
            MaximizeBox = false;
            Name = "FrmRestoDivisao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Resto da Divisão";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblDividendo;
        private TextBox TxtDividendo;
        private Label LblDivisor;
        private TextBox TxtDivisor;
        private Button BtnRestoDaDivisao;
        private Label LblResto;
        private TextBox TxtResto;
    }
}