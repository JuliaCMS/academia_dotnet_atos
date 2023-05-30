namespace Cadastro
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
            labelUsuario = new Label();
            labelSenha = new Label();
            textBoxUsuario = new TextBox();
            textBoxSenha = new TextBox();
            buttonEnviar = new Button();
            label1 = new Label();
            buttonVerificar = new Button();
            SuspendLayout();
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Location = new Point(27, 97);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(66, 20);
            labelUsuario.TabIndex = 0;
            labelUsuario.Text = "Usuário: ";
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.Location = new Point(27, 135);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(56, 20);
            labelSenha.TabIndex = 1;
            labelSenha.Text = "Senha: ";
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(90, 94);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(125, 27);
            textBoxUsuario.TabIndex = 2;
            // 
            // textBoxSenha
            // 
            textBoxSenha.Location = new Point(89, 132);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new Size(125, 27);
            textBoxSenha.TabIndex = 3;
            // 
            // buttonEnviar
            // 
            buttonEnviar.Location = new Point(27, 173);
            buttonEnviar.Name = "buttonEnviar";
            buttonEnviar.Size = new Size(188, 29);
            buttonEnviar.TabIndex = 4;
            buttonEnviar.Text = "Enviar";
            buttonEnviar.UseVisualStyleBackColor = true;
            buttonEnviar.Click += buttonEnviar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(265, 41);
            label1.TabIndex = 5;
            label1.Text = "Cadastrar usuário";
            // 
            // buttonVerificar
            // 
            buttonVerificar.Location = new Point(26, 271);
            buttonVerificar.Name = "buttonVerificar";
            buttonVerificar.Size = new Size(188, 29);
            buttonVerificar.TabIndex = 6;
            buttonVerificar.Text = "Verificar Usuário";
            buttonVerificar.UseVisualStyleBackColor = true;
            buttonVerificar.Click += buttonVerificar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonVerificar);
            Controls.Add(label1);
            Controls.Add(buttonEnviar);
            Controls.Add(textBoxSenha);
            Controls.Add(textBoxUsuario);
            Controls.Add(labelSenha);
            Controls.Add(labelUsuario);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelUsuario;
        private Label labelSenha;
        private TextBox textBoxUsuario;
        private TextBox textBoxSenha;
        private Button buttonEnviar;
        private Label label1;
        private Button buttonVerificar;
    }
}