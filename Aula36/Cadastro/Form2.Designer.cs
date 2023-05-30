namespace Cadastro
{
    partial class Form2
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
            label1 = new Label();
            buttonVerificar = new Button();
            textBoxSenhaVerificar = new TextBox();
            textBoxUsuarioVerificar = new TextBox();
            labelSenha = new Label();
            labelUsuario = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(29, 42);
            label1.Name = "label1";
            label1.Size = new Size(277, 41);
            label1.TabIndex = 11;
            label1.Text = "Tela de verificação";
            // 
            // buttonVerificar
            // 
            buttonVerificar.Location = new Point(44, 190);
            buttonVerificar.Name = "buttonVerificar";
            buttonVerificar.Size = new Size(188, 29);
            buttonVerificar.TabIndex = 10;
            buttonVerificar.Text = "Verificar";
            buttonVerificar.UseVisualStyleBackColor = true;
            buttonVerificar.Click += buttonVerificar_Click;
            // 
            // textBoxSenhaVerificar
            // 
            textBoxSenhaVerificar.Location = new Point(106, 149);
            textBoxSenhaVerificar.Name = "textBoxSenhaVerificar";
            textBoxSenhaVerificar.Size = new Size(125, 27);
            textBoxSenhaVerificar.TabIndex = 9;
            // 
            // textBoxUsuarioVerificar
            // 
            textBoxUsuarioVerificar.Location = new Point(107, 111);
            textBoxUsuarioVerificar.Name = "textBoxUsuarioVerificar";
            textBoxUsuarioVerificar.Size = new Size(125, 27);
            textBoxUsuarioVerificar.TabIndex = 8;
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.Location = new Point(44, 152);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(56, 20);
            labelSenha.TabIndex = 7;
            labelSenha.Text = "Senha: ";
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Location = new Point(44, 114);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(66, 20);
            labelUsuario.TabIndex = 6;
            labelUsuario.Text = "Usuário: ";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(buttonVerificar);
            Controls.Add(textBoxSenhaVerificar);
            Controls.Add(textBoxUsuarioVerificar);
            Controls.Add(labelSenha);
            Controls.Add(labelUsuario);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonVerificar;
        private TextBox textBoxSenhaVerificar;
        private TextBox textBoxUsuarioVerificar;
        private Label labelSenha;
        private Label labelUsuario;
    }
}