namespace Aula35
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
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            button2 = new Button();
            textBoxNome = new TextBox();
            textBoxIdade = new TextBox();
            textBoxSalario = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            buttonSerializaXML = new Button();
            buttonDesserializaXML = new Button();
            labelNomeDs = new Label();
            labelIdadeDs = new Label();
            labelSalarioDs = new Label();
            buttonDesserializaJSON = new Button();
            buttonSerializaJSON = new Button();
            buttonDesSOAP = new Button();
            buttonSerializaSOAP = new Button();
            labelMarca = new Label();
            labelModelo = new Label();
            labelAno = new Label();
            textBoxMarca = new TextBox();
            textBoxModelo = new TextBox();
            textBoxAno = new TextBox();
            buttonDesSOAPVei = new Button();
            buttonSerSOAPVei = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(143, 22);
            button1.Name = "button1";
            button1.Size = new Size(123, 29);
            button1.TabIndex = 0;
            button1.Text = "Serializando";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 61);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // button2
            // 
            button2.Location = new Point(143, 57);
            button2.Name = "button2";
            button2.Size = new Size(123, 29);
            button2.TabIndex = 3;
            button2.Text = "Desserializando";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(143, 150);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(125, 27);
            textBoxNome.TabIndex = 4;
            // 
            // textBoxIdade
            // 
            textBoxIdade.Location = new Point(143, 183);
            textBoxIdade.Name = "textBoxIdade";
            textBoxIdade.Size = new Size(125, 27);
            textBoxIdade.TabIndex = 5;
            // 
            // textBoxSalario
            // 
            textBoxSalario.Location = new Point(143, 216);
            textBoxSalario.Name = "textBoxSalario";
            textBoxSalario.Size = new Size(125, 27);
            textBoxSalario.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 153);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 7;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 190);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 8;
            label3.Text = "Idade";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 223);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 9;
            label4.Text = "Salario";
            // 
            // buttonSerializaXML
            // 
            buttonSerializaXML.Location = new Point(274, 165);
            buttonSerializaXML.Name = "buttonSerializaXML";
            buttonSerializaXML.Size = new Size(126, 29);
            buttonSerializaXML.TabIndex = 10;
            buttonSerializaXML.Text = "SerializaXML";
            buttonSerializaXML.UseVisualStyleBackColor = true;
            buttonSerializaXML.Click += buttonSerializaXML_Click;
            // 
            // buttonDesserializaXML
            // 
            buttonDesserializaXML.Location = new Point(274, 200);
            buttonDesserializaXML.Name = "buttonDesserializaXML";
            buttonDesserializaXML.Size = new Size(126, 29);
            buttonDesserializaXML.TabIndex = 11;
            buttonDesserializaXML.Text = "DesserializaXML";
            buttonDesserializaXML.UseVisualStyleBackColor = true;
            buttonDesserializaXML.Click += buttonDesserializaXML_Click;
            // 
            // labelNomeDs
            // 
            labelNomeDs.AutoSize = true;
            labelNomeDs.Location = new Point(431, 156);
            labelNomeDs.Name = "labelNomeDs";
            labelNomeDs.Size = new Size(67, 20);
            labelNomeDs.TabIndex = 12;
            labelNomeDs.Text = "NomeDs";
            // 
            // labelIdadeDs
            // 
            labelIdadeDs.AutoSize = true;
            labelIdadeDs.Location = new Point(434, 189);
            labelIdadeDs.Name = "labelIdadeDs";
            labelIdadeDs.Size = new Size(64, 20);
            labelIdadeDs.TabIndex = 13;
            labelIdadeDs.Text = "IdadeDs";
            // 
            // labelSalarioDs
            // 
            labelSalarioDs.AutoSize = true;
            labelSalarioDs.Location = new Point(431, 223);
            labelSalarioDs.Name = "labelSalarioDs";
            labelSalarioDs.Size = new Size(72, 20);
            labelSalarioDs.TabIndex = 14;
            labelSalarioDs.Text = "SalarioDs";
            // 
            // buttonDesserializaJSON
            // 
            buttonDesserializaJSON.Location = new Point(274, 303);
            buttonDesserializaJSON.Name = "buttonDesserializaJSON";
            buttonDesserializaJSON.Size = new Size(140, 29);
            buttonDesserializaJSON.TabIndex = 16;
            buttonDesserializaJSON.Text = "DesserializaJSON";
            buttonDesserializaJSON.UseVisualStyleBackColor = true;
            buttonDesserializaJSON.Click += buttonDesserializaJSON_Click;
            // 
            // buttonSerializaJSON
            // 
            buttonSerializaJSON.Location = new Point(274, 268);
            buttonSerializaJSON.Name = "buttonSerializaJSON";
            buttonSerializaJSON.Size = new Size(126, 29);
            buttonSerializaJSON.TabIndex = 15;
            buttonSerializaJSON.Text = "SerializaJSON";
            buttonSerializaJSON.UseVisualStyleBackColor = true;
            buttonSerializaJSON.Click += buttonSerializaJSON_Click;
            // 
            // buttonDesSOAP
            // 
            buttonDesSOAP.Location = new Point(458, 303);
            buttonDesSOAP.Name = "buttonDesSOAP";
            buttonDesSOAP.Size = new Size(140, 29);
            buttonDesSOAP.TabIndex = 18;
            buttonDesSOAP.Text = "DesserializaSOAP";
            buttonDesSOAP.UseVisualStyleBackColor = true;
            buttonDesSOAP.Click += buttonDesSOAP_Click;
            // 
            // buttonSerializaSOAP
            // 
            buttonSerializaSOAP.Location = new Point(458, 268);
            buttonSerializaSOAP.Name = "buttonSerializaSOAP";
            buttonSerializaSOAP.Size = new Size(126, 29);
            buttonSerializaSOAP.TabIndex = 17;
            buttonSerializaSOAP.Text = "SerializaSOAP";
            buttonSerializaSOAP.UseVisualStyleBackColor = true;
            buttonSerializaSOAP.Click += buttonSerializaSOAP_Click;
            // 
            // labelMarca
            // 
            labelMarca.AutoSize = true;
            labelMarca.Location = new Point(32, 355);
            labelMarca.Name = "labelMarca";
            labelMarca.Size = new Size(50, 20);
            labelMarca.TabIndex = 19;
            labelMarca.Text = "Marca";
            // 
            // labelModelo
            // 
            labelModelo.AutoSize = true;
            labelModelo.Location = new Point(32, 387);
            labelModelo.Name = "labelModelo";
            labelModelo.Size = new Size(61, 20);
            labelModelo.TabIndex = 20;
            labelModelo.Text = "Modelo";
            // 
            // labelAno
            // 
            labelAno.AutoSize = true;
            labelAno.Location = new Point(32, 421);
            labelAno.Name = "labelAno";
            labelAno.Size = new Size(36, 20);
            labelAno.TabIndex = 21;
            labelAno.Text = "Ano";
            // 
            // textBoxMarca
            // 
            textBoxMarca.Location = new Point(93, 352);
            textBoxMarca.Name = "textBoxMarca";
            textBoxMarca.Size = new Size(125, 27);
            textBoxMarca.TabIndex = 22;
            // 
            // textBoxModelo
            // 
            textBoxModelo.Location = new Point(93, 387);
            textBoxModelo.Name = "textBoxModelo";
            textBoxModelo.Size = new Size(125, 27);
            textBoxModelo.TabIndex = 23;
            // 
            // textBoxAno
            // 
            textBoxAno.Location = new Point(93, 418);
            textBoxAno.Name = "textBoxAno";
            textBoxAno.Size = new Size(125, 27);
            textBoxAno.TabIndex = 24;
            // 
            // buttonDesSOAPVei
            // 
            buttonDesSOAPVei.Location = new Point(249, 398);
            buttonDesSOAPVei.Name = "buttonDesSOAPVei";
            buttonDesSOAPVei.Size = new Size(188, 29);
            buttonDesSOAPVei.TabIndex = 26;
            buttonDesSOAPVei.Text = "DesserializaSOAPVeiculo";
            buttonDesSOAPVei.UseVisualStyleBackColor = true;
            buttonDesSOAPVei.Click += buttonDesSOAPVei_Click;
            // 
            // buttonSerSOAPVei
            // 
            buttonSerSOAPVei.Location = new Point(249, 363);
            buttonSerSOAPVei.Name = "buttonSerSOAPVei";
            buttonSerSOAPVei.Size = new Size(188, 29);
            buttonSerSOAPVei.TabIndex = 25;
            buttonSerSOAPVei.Text = "SerializaSOAPVeiculo";
            buttonSerSOAPVei.UseVisualStyleBackColor = true;
            buttonSerSOAPVei.Click += buttonSerSOAPVei_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDesSOAPVei);
            Controls.Add(buttonSerSOAPVei);
            Controls.Add(textBoxAno);
            Controls.Add(textBoxModelo);
            Controls.Add(textBoxMarca);
            Controls.Add(labelAno);
            Controls.Add(labelModelo);
            Controls.Add(labelMarca);
            Controls.Add(buttonDesSOAP);
            Controls.Add(buttonSerializaSOAP);
            Controls.Add(buttonDesserializaJSON);
            Controls.Add(buttonSerializaJSON);
            Controls.Add(labelSalarioDs);
            Controls.Add(labelIdadeDs);
            Controls.Add(labelNomeDs);
            Controls.Add(buttonDesserializaXML);
            Controls.Add(buttonSerializaXML);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxSalario);
            Controls.Add(textBoxIdade);
            Controls.Add(textBoxNome);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Button button2;
        private TextBox textBoxNome;
        private TextBox textBoxIdade;
        private TextBox textBoxSalario;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button buttonSerializaXML;
        private Button buttonDesserializaXML;
        private Label labelNomeDs;
        private Label labelIdadeDs;
        private Label labelSalarioDs;
        private Button buttonDesserializaJSON;
        private Button buttonSerializaJSON;
        private Button buttonDesSOAP;
        private Button buttonSerializaSOAP;
        private Label labelMarca;
        private Label labelModelo;
        private Label labelAno;
        private TextBox textBoxMarca;
        private TextBox textBoxModelo;
        private TextBox textBoxAno;
        private Button buttonDesSOAPVei;
        private Button buttonSerSOAPVei;
    }
}