namespace WinFormsApp1
{
    partial class FormPrincipal
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
            buttonGerarEmail = new Button();
            textBoxNome = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxSobrenome = new TextBox();
            textBoxEmail = new TextBox();
            label3 = new Label();
            textBoxListaEmails = new TextBox();
            SuspendLayout();
            // 
            // buttonGerarEmail
            // 
            buttonGerarEmail.Location = new Point(35, 234);
            buttonGerarEmail.Name = "buttonGerarEmail";
            buttonGerarEmail.Size = new Size(240, 29);
            buttonGerarEmail.TabIndex = 0;
            buttonGerarEmail.Text = "Gerar E-mail";
            buttonGerarEmail.UseVisualStyleBackColor = true;
            buttonGerarEmail.Click += buttonGerarEmail_Click;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(35, 69);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(275, 27);
            textBoxNome.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 46);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 2;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 111);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 3;
            label2.Text = "Sobrenome";
            // 
            // textBoxSobrenome
            // 
            textBoxSobrenome.Location = new Point(35, 134);
            textBoxSobrenome.Name = "textBoxSobrenome";
            textBoxSobrenome.Size = new Size(275, 27);
            textBoxSobrenome.TabIndex = 4;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(35, 187);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.ReadOnly = true;
            textBoxEmail.Size = new Size(275, 27);
            textBoxEmail.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 164);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 6;
            label3.Text = "E-mail";
            // 
            // textBoxListaEmails
            // 
            textBoxListaEmails.Location = new Point(383, 69);
            textBoxListaEmails.Multiline = true;
            textBoxListaEmails.Name = "textBoxListaEmails";
            textBoxListaEmails.ReadOnly = true;
            textBoxListaEmails.ScrollBars = ScrollBars.Vertical;
            textBoxListaEmails.Size = new Size(273, 194);
            textBoxListaEmails.TabIndex = 7;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 415);
            Controls.Add(textBoxListaEmails);
            Controls.Add(label3);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxSobrenome);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxNome);
            Controls.Add(buttonGerarEmail);
            Name = "FormPrincipal";
            Text = "Titulo do Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonGerarEmail;
        private TextBox textBoxNome;
        private Label label1;
        private Label label2;
        private TextBox textBoxSobrenome;
        private TextBox textBoxEmail;
        private Label label3;
        private TextBox textBoxListaEmails;
    }
}