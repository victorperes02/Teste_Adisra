
namespace AdisraBrasils
{
    partial class TelaApp
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaApp));
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Questions = new System.Windows.Forms.TabControl();
            this.Question1 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.convertDolar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Question2 = new System.Windows.Forms.TabPage();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sequencia = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Question3 = new System.Windows.Forms.TabPage();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.fazerPedido = new System.Windows.Forms.Button();
            this.ButtonLimparPedido = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listView3 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.Question4 = new System.Windows.Forms.TabPage();
            this.listView4 = new System.Windows.Forms.ListView();
            this.Goolomb = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.Questions.SuspendLayout();
            this.Question1.SuspendLayout();
            this.Question2.SuspendLayout();
            this.Question3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.Question4.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(35, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(567, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "1 - Sabendo que hoje o 1 dolar é equivalente a 5,36 reais.\r\nFazer um programa em " +
    "c#, java ou em liguagem de algoritmo que dado um valor em dolar, exiba o equival" +
    "ente em reais";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Questions
            // 
            this.Questions.Controls.Add(this.Question1);
            this.Questions.Controls.Add(this.Question2);
            this.Questions.Controls.Add(this.Question3);
            this.Questions.Controls.Add(this.Question4);
            this.Questions.Location = new System.Drawing.Point(12, 12);
            this.Questions.Name = "Questions";
            this.Questions.SelectedIndex = 0;
            this.Questions.Size = new System.Drawing.Size(806, 404);
            this.Questions.TabIndex = 3;
            // 
            // Question1
            // 
            this.Question1.Controls.Add(this.listView1);
            this.Question1.Controls.Add(this.convertDolar);
            this.Question1.Controls.Add(this.textBox1);
            this.Question1.Controls.Add(this.label2);
            this.Question1.Controls.Add(this.label1);
            this.Question1.Location = new System.Drawing.Point(4, 22);
            this.Question1.Name = "Question1";
            this.Question1.Padding = new System.Windows.Forms.Padding(3);
            this.Question1.Size = new System.Drawing.Size(798, 378);
            this.Question1.TabIndex = 0;
            this.Question1.Text = "Question1";
            this.Question1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(35, 160);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(375, 207);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Reais";
            this.columnHeader2.Width = 92;
            // 
            // convertDolar
            // 
            this.convertDolar.Location = new System.Drawing.Point(150, 90);
            this.convertDolar.Name = "convertDolar";
            this.convertDolar.Size = new System.Drawing.Size(75, 23);
            this.convertDolar.TabIndex = 4;
            this.convertDolar.Text = "Converter";
            this.convertDolar.UseVisualStyleBackColor = true;
            this.convertDolar.Click += new System.EventHandler(this.convertDolar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor em Dolar $";
            // 
            // Question2
            // 
            this.Question2.Controls.Add(this.listView2);
            this.Question2.Controls.Add(this.sequencia);
            this.Question2.Controls.Add(this.textBox2);
            this.Question2.Controls.Add(this.label3);
            this.Question2.Controls.Add(this.label4);
            this.Question2.Location = new System.Drawing.Point(4, 22);
            this.Question2.Name = "Question2";
            this.Question2.Padding = new System.Windows.Forms.Padding(3);
            this.Question2.Size = new System.Drawing.Size(798, 378);
            this.Question2.TabIndex = 1;
            this.Question2.Text = "Question2";
            this.Question2.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(36, 159);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(375, 207);
            this.listView2.TabIndex = 10;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Números Duplicados";
            this.columnHeader3.Width = 368;
            // 
            // sequencia
            // 
            this.sequencia.Location = new System.Drawing.Point(151, 89);
            this.sequencia.Name = "sequencia";
            this.sequencia.Size = new System.Drawing.Size(114, 23);
            this.sequencia.TabIndex = 9;
            this.sequencia.Text = "Contar Duplicados";
            this.sequencia.UseVisualStyleBackColor = true;
            this.sequencia.Click += new System.EventHandler(this.sequencia_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(36, 92);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Digite a sequência númerica";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(682, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = resources.GetString("label4.Text");
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Question3
            // 
            this.Question3.Controls.Add(this.numericUpDown6);
            this.Question3.Controls.Add(this.numericUpDown5);
            this.Question3.Controls.Add(this.numericUpDown4);
            this.Question3.Controls.Add(this.numericUpDown3);
            this.Question3.Controls.Add(this.numericUpDown2);
            this.Question3.Controls.Add(this.numericUpDown1);
            this.Question3.Controls.Add(this.fazerPedido);
            this.Question3.Controls.Add(this.ButtonLimparPedido);
            this.Question3.Controls.Add(this.label13);
            this.Question3.Controls.Add(this.label14);
            this.Question3.Controls.Add(this.label12);
            this.Question3.Controls.Add(this.label11);
            this.Question3.Controls.Add(this.label10);
            this.Question3.Controls.Add(this.label5);
            this.Question3.Controls.Add(this.label8);
            this.Question3.Controls.Add(this.label9);
            this.Question3.Controls.Add(this.label17);
            this.Question3.Controls.Add(this.label7);
            this.Question3.Controls.Add(this.listView3);
            this.Question3.Controls.Add(this.label6);
            this.Question3.Location = new System.Drawing.Point(4, 22);
            this.Question3.Name = "Question3";
            this.Question3.Padding = new System.Windows.Forms.Padding(3);
            this.Question3.Size = new System.Drawing.Size(798, 378);
            this.Question3.TabIndex = 2;
            this.Question3.Text = "Question3";
            this.Question3.UseVisualStyleBackColor = true;
            this.Question3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Location = new System.Drawing.Point(656, 172);
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(42, 20);
            this.numericUpDown6.TabIndex = 27;
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(656, 127);
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(42, 20);
            this.numericUpDown5.TabIndex = 26;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(656, 84);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(42, 20);
            this.numericUpDown4.TabIndex = 25;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(418, 84);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(42, 20);
            this.numericUpDown3.TabIndex = 24;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(190, 132);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(42, 20);
            this.numericUpDown2.TabIndex = 23;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(190, 91);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(42, 20);
            this.numericUpDown1.TabIndex = 22;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // fazerPedido
            // 
            this.fazerPedido.Location = new System.Drawing.Point(9, 193);
            this.fazerPedido.Name = "fazerPedido";
            this.fazerPedido.Size = new System.Drawing.Size(110, 23);
            this.fazerPedido.TabIndex = 21;
            this.fazerPedido.Text = "Fazer Pedido";
            this.fazerPedido.UseVisualStyleBackColor = true;
            this.fazerPedido.Click += new System.EventHandler(this.fazerPedido_Click);
            // 
            // ButtonLimparPedido
            // 
            this.ButtonLimparPedido.Location = new System.Drawing.Point(137, 193);
            this.ButtonLimparPedido.Name = "ButtonLimparPedido";
            this.ButtonLimparPedido.Size = new System.Drawing.Size(110, 23);
            this.ButtonLimparPedido.TabIndex = 19;
            this.ButtonLimparPedido.Text = "Limpar Pedido";
            this.ButtonLimparPedido.UseVisualStyleBackColor = true;
            this.ButtonLimparPedido.Click += new System.EventHandler(this.button9_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(536, 174);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "6 - Maionese R$ 1,00";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(536, 86);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "4 - Batata Frita R$ 6,00";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(536, 129);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "5 - Salada R$ 2,00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(294, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "3- Refrigerante R$ 4,00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(178, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "2 - Hamburguer de Frango R$ 16,00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "1 - Hamburguer de Carne R$ 20,00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(555, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Acompanhamentos";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(342, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Refrigerantes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Lanches";
            // 
            // listView3
            // 
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView3.HideSelection = false;
            this.listView3.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.listView3.Location = new System.Drawing.Point(9, 241);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(728, 126);
            this.listView3.TabIndex = 15;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            this.listView3.SelectedIndexChanged += new System.EventHandler(this.listView3_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Total do Pedido";
            this.columnHeader1.Width = 147;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(682, 26);
            this.label6.TabIndex = 12;
            this.label6.Text = resources.GetString("label6.Text");
            // 
            // Question4
            // 
            this.Question4.Controls.Add(this.listView4);
            this.Question4.Controls.Add(this.button3);
            this.Question4.Controls.Add(this.textBox3);
            this.Question4.Controls.Add(this.label15);
            this.Question4.Controls.Add(this.label16);
            this.Question4.Location = new System.Drawing.Point(4, 22);
            this.Question4.Name = "Question4";
            this.Question4.Padding = new System.Windows.Forms.Padding(3);
            this.Question4.Size = new System.Drawing.Size(798, 378);
            this.Question4.TabIndex = 3;
            this.Question4.Text = "Question4";
            this.Question4.UseVisualStyleBackColor = true;
            // 
            // listView4
            // 
            this.listView4.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Goolomb});
            this.listView4.HideSelection = false;
            this.listView4.Location = new System.Drawing.Point(20, 156);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(375, 207);
            this.listView4.TabIndex = 15;
            this.listView4.UseCompatibleStateImageBehavior = false;
            this.listView4.View = System.Windows.Forms.View.Details;
            this.listView4.SelectedIndexChanged += new System.EventHandler(this.listView4_SelectedIndexChanged);
            // 
            // Goolomb
            // 
            this.Goolomb.Text = "Goolomb";
            this.Goolomb.Width = 368;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(135, 86);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Goolomb";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(20, 89);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 11;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 63);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(115, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "Digite o valor do indice";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(17, 13);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(726, 13);
            this.label16.TabIndex = 12;
            this.label16.Text = "5 - Criar um programa para mostrar a sequência de Golomb. Dado um valor númerico " +
    "n de entrada mostre os n primeiros valores da sequencia de Golomb";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 177);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(126, 13);
            this.label17.TabIndex = 17;
            this.label17.Text = "Para Calcular Clique Aqui";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 449);
            this.Controls.Add(this.Questions);
            this.Name = "Form1";
            this.Text = "Aplicativo Adisra Brasil";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Questions.ResumeLayout(false);
            this.Question1.ResumeLayout(false);
            this.Question1.PerformLayout();
            this.Question2.ResumeLayout(false);
            this.Question2.PerformLayout();
            this.Question3.ResumeLayout(false);
            this.Question3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.Question4.ResumeLayout(false);
            this.Question4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl Questions;
        private System.Windows.Forms.TabPage Question1;
        private System.Windows.Forms.TabPage Question2;
        private System.Windows.Forms.Button convertDolar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button sequencia;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage Question3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ButtonLimparPedido;
        private System.Windows.Forms.TabPage Question4;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button fazerPedido;
        private System.Windows.Forms.ColumnHeader Goolomb;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label17;
    }
}

