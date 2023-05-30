namespace Aula36
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
            labelMensagem = new Label();
            textBoxMensagem = new TextBox();
            buttonCripto = new Button();
            labelTitCripto = new Label();
            labelCripto = new Label();
            buttonDescript = new Button();
            labelDescript = new Label();
            labelTxtCripto = new Label();
            labelDescriptTxt = new Label();
            buttonDescriptTxt = new Button();
            buttonTxtCripto = new Button();
            buttonCriptAssi = new Button();
            textBoxMsgAssi = new TextBox();
            labelCriptoAssi = new Label();
            label2 = new Label();
            labelDescriptAssi = new Label();
            buttonDescriptAssi = new Button();
            SuspendLayout();
            // 
            // labelMensagem
            // 
            labelMensagem.AutoSize = true;
            labelMensagem.Location = new Point(12, 25);
            labelMensagem.Name = "labelMensagem";
            labelMensagem.Size = new Size(82, 20);
            labelMensagem.TabIndex = 0;
            labelMensagem.Text = "Mensagem";
            // 
            // textBoxMensagem
            // 
            textBoxMensagem.Location = new Point(100, 22);
            textBoxMensagem.Name = "textBoxMensagem";
            textBoxMensagem.Size = new Size(125, 27);
            textBoxMensagem.TabIndex = 1;
            // 
            // buttonCripto
            // 
            buttonCripto.Location = new Point(231, 22);
            buttonCripto.Name = "buttonCripto";
            buttonCripto.Size = new Size(105, 29);
            buttonCripto.TabIndex = 2;
            buttonCripto.Text = "Criptografia";
            buttonCripto.UseVisualStyleBackColor = true;
            buttonCripto.Click += buttonCripto_Click;
            // 
            // labelTitCripto
            // 
            labelTitCripto.AutoSize = true;
            labelTitCripto.Location = new Point(12, 76);
            labelTitCripto.Name = "labelTitCripto";
            labelTitCripto.Size = new Size(109, 20);
            labelTitCripto.TabIndex = 3;
            labelTitCripto.Text = "Criptografada: ";
            // 
            // labelCripto
            // 
            labelCripto.AutoSize = true;
            labelCripto.Location = new Point(142, 76);
            labelCripto.Name = "labelCripto";
            labelCripto.Size = new Size(15, 20);
            labelCripto.TabIndex = 4;
            labelCripto.Text = "_";
            // 
            // buttonDescript
            // 
            buttonDescript.Location = new Point(12, 113);
            buttonDescript.Name = "buttonDescript";
            buttonDescript.Size = new Size(126, 29);
            buttonDescript.TabIndex = 5;
            buttonDescript.Text = "Descriptografar";
            buttonDescript.UseVisualStyleBackColor = true;
            buttonDescript.Click += buttonDescript_Click;
            // 
            // labelDescript
            // 
            labelDescript.AutoSize = true;
            labelDescript.Location = new Point(144, 117);
            labelDescript.Name = "labelDescript";
            labelDescript.Size = new Size(15, 20);
            labelDescript.TabIndex = 6;
            labelDescript.Text = "_";
            // 
            // labelTxtCripto
            // 
            labelTxtCripto.AutoSize = true;
            labelTxtCripto.Location = new Point(191, 173);
            labelTxtCripto.Name = "labelTxtCripto";
            labelTxtCripto.Size = new Size(15, 20);
            labelTxtCripto.TabIndex = 7;
            labelTxtCripto.Text = "-";
            // 
            // labelDescriptTxt
            // 
            labelDescriptTxt.AutoSize = true;
            labelDescriptTxt.Location = new Point(191, 208);
            labelDescriptTxt.Name = "labelDescriptTxt";
            labelDescriptTxt.Size = new Size(15, 20);
            labelDescriptTxt.TabIndex = 10;
            labelDescriptTxt.Text = "_";
            // 
            // buttonDescriptTxt
            // 
            buttonDescriptTxt.Location = new Point(12, 204);
            buttonDescriptTxt.Name = "buttonDescriptTxt";
            buttonDescriptTxt.Size = new Size(154, 29);
            buttonDescriptTxt.TabIndex = 9;
            buttonDescriptTxt.Text = "Descriptografar TXT";
            buttonDescriptTxt.UseVisualStyleBackColor = true;
            buttonDescriptTxt.Click += buttonDescriptTxt_Click;
            // 
            // buttonTxtCripto
            // 
            buttonTxtCripto.Location = new Point(12, 169);
            buttonTxtCripto.Name = "buttonTxtCripto";
            buttonTxtCripto.Size = new Size(154, 29);
            buttonTxtCripto.TabIndex = 11;
            buttonTxtCripto.Text = "TXT Criptografado";
            buttonTxtCripto.UseVisualStyleBackColor = true;
            buttonTxtCripto.Click += buttonTxtCripto_Click;
            // 
            // buttonCriptAssi
            // 
            buttonCriptAssi.Location = new Point(12, 283);
            buttonCriptAssi.Name = "buttonCriptAssi";
            buttonCriptAssi.Size = new Size(181, 29);
            buttonCriptAssi.TabIndex = 12;
            buttonCriptAssi.Text = "Criptografia assimetrica";
            buttonCriptAssi.UseVisualStyleBackColor = true;
            buttonCriptAssi.Click += buttonCriptAssi_Click;
            // 
            // textBoxMsgAssi
            // 
            textBoxMsgAssi.Location = new Point(211, 285);
            textBoxMsgAssi.Name = "textBoxMsgAssi";
            textBoxMsgAssi.Size = new Size(125, 27);
            textBoxMsgAssi.TabIndex = 13;
            // 
            // labelCriptoAssi
            // 
            labelCriptoAssi.AutoSize = true;
            labelCriptoAssi.Location = new Point(142, 315);
            labelCriptoAssi.Name = "labelCriptoAssi";
            labelCriptoAssi.Size = new Size(15, 20);
            labelCriptoAssi.TabIndex = 15;
            labelCriptoAssi.Text = "_";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 315);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 14;
            label2.Text = "Criptografada: ";
            // 
            // labelDescriptAssi
            // 
            labelDescriptAssi.AutoSize = true;
            labelDescriptAssi.Location = new Point(144, 342);
            labelDescriptAssi.Name = "labelDescriptAssi";
            labelDescriptAssi.Size = new Size(15, 20);
            labelDescriptAssi.TabIndex = 17;
            labelDescriptAssi.Text = "_";
            // 
            // buttonDescriptAssi
            // 
            buttonDescriptAssi.Location = new Point(12, 338);
            buttonDescriptAssi.Name = "buttonDescriptAssi";
            buttonDescriptAssi.Size = new Size(126, 29);
            buttonDescriptAssi.TabIndex = 16;
            buttonDescriptAssi.Text = "Descriptografar";
            buttonDescriptAssi.UseVisualStyleBackColor = true;
            buttonDescriptAssi.Click += buttonDescriptAssi_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelDescriptAssi);
            Controls.Add(buttonDescriptAssi);
            Controls.Add(labelCriptoAssi);
            Controls.Add(label2);
            Controls.Add(textBoxMsgAssi);
            Controls.Add(buttonCriptAssi);
            Controls.Add(buttonTxtCripto);
            Controls.Add(labelDescriptTxt);
            Controls.Add(buttonDescriptTxt);
            Controls.Add(labelTxtCripto);
            Controls.Add(labelDescript);
            Controls.Add(buttonDescript);
            Controls.Add(labelCripto);
            Controls.Add(labelTitCripto);
            Controls.Add(buttonCripto);
            Controls.Add(textBoxMensagem);
            Controls.Add(labelMensagem);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMensagem;
        private TextBox textBoxMensagem;
        private Button buttonCripto;
        private Label labelTitCripto;
        private Label labelCripto;
        private Button buttonDescript;
        private Label labelDescript;
        private Label labelTxtCripto;
        private Label labelDescriptTxt;
        private Button buttonDescriptTxt;
        private Button buttonTxtCripto;
        private Button buttonCriptAssi;
        private TextBox textBoxMsgAssi;
        private Label labelCriptoAssi;
        private Label label2;
        private Label labelDescriptAssi;
        private Button buttonDescriptAssi;
    }
}