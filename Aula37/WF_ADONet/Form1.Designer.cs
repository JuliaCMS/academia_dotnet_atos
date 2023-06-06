namespace WF_ADONet
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
            btnTodos = new Button();
            txtNome = new TextBox();
            dataGridView1 = new DataGridView();
            btnFiltrar = new Button();
            textBoxNome = new TextBox();
            textBoxProfissao = new TextBox();
            btnCadastrar = new Button();
            label1 = new Label();
            label2 = new Label();
            btnExcluir = new Button();
            btnAlterar = new Button();
            textBoxID = new TextBox();
            labelID = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnTodos
            // 
            btnTodos.Location = new Point(293, 254);
            btnTodos.Name = "btnTodos";
            btnTodos.Size = new Size(125, 29);
            btnTodos.TabIndex = 0;
            btnTodos.Text = "Consultar todos";
            btnTodos.TextImageRelation = TextImageRelation.ImageAboveText;
            btnTodos.UseVisualStyleBackColor = true;
            btnTodos.Click += btnTodos_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(621, 45);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(136, 27);
            txtNome.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(191, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(416, 217);
            dataGridView1.TabIndex = 2;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(663, 78);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(94, 29);
            btnFiltrar.TabIndex = 3;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(22, 45);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(148, 27);
            textBoxNome.TabIndex = 4;
            // 
            // textBoxProfissao
            // 
            textBoxProfissao.Location = new Point(22, 98);
            textBoxProfissao.Name = "textBoxProfissao";
            textBoxProfissao.Size = new Size(148, 27);
            textBoxProfissao.TabIndex = 5;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(22, 140);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(94, 29);
            btnCadastrar.TabIndex = 6;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 22);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 7;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 75);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 8;
            label2.Text = "Profissao";
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(78, 223);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(94, 29);
            btnExcluir.TabIndex = 9;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(78, 258);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(94, 29);
            btnAlterar.TabIndex = 10;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(2, 226);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(70, 27);
            textBoxID.TabIndex = 11;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(2, 254);
            labelID.Name = "labelID";
            labelID.Size = new Size(24, 20);
            labelID.TabIndex = 12;
            labelID.Text = "ID";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 316);
            Controls.Add(labelID);
            Controls.Add(textBoxID);
            Controls.Add(btnAlterar);
            Controls.Add(btnExcluir);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCadastrar);
            Controls.Add(textBoxProfissao);
            Controls.Add(textBoxNome);
            Controls.Add(btnFiltrar);
            Controls.Add(dataGridView1);
            Controls.Add(txtNome);
            Controls.Add(btnTodos);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTodos;
        private TextBox txtNome;
        private DataGridView dataGridView1;
        private Button btnFiltrar;
        private TextBox textBoxNome;
        private TextBox textBoxProfissao;
        private Button btnCadastrar;
        private Label label1;
        private Label label2;
        private Button btnExcluir;
        private Button btnAlterar;
        private TextBox textBoxID;
        private Label labelID;
    }
}