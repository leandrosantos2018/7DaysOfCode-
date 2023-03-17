namespace CatAsServices
{
    partial class BuscarRacaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarRacaForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            cmb_selecaoRaca = new ComboBox();
            lb_temperamento = new Label();
            lb_origem = new Label();
            lb_Descricao = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(291, 24);
            label1.TabIndex = 0;
            label1.Text = "Encontre sua Raça Favorita";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 47);
            label2.MaximumSize = new Size(350, 100);
            label2.Name = "label2";
            label2.Size = new Size(298, 28);
            label2.TabIndex = 1;
            label2.Text = "selecionar uma raça e visualizar os resultados da busca de características e descobrir qual raça favorita";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(98, 92);
            label3.Name = "label3";
            label3.Size = new Size(80, 14);
            label3.TabIndex = 2;
            label3.Text = "Raça do Gato:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(83, 128);
            label4.Name = "label4";
            label4.Size = new Size(95, 14);
            label4.TabIndex = 3;
            label4.Text = "Temperamento:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(127, 163);
            label5.Name = "label5";
            label5.Size = new Size(51, 14);
            label5.TabIndex = 4;
            label5.Text = "Origem:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(114, 202);
            label6.Name = "label6";
            label6.Size = new Size(64, 14);
            label6.TabIndex = 5;
            label6.Text = "Descrição:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(181, 230);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(385, 196);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // cmb_selecaoRaca
            // 
            cmb_selecaoRaca.FormattingEnabled = true;
            cmb_selecaoRaca.Items.AddRange(new object[] { "Selecione uma Raça" });
            cmb_selecaoRaca.Location = new Point(181, 88);
            cmb_selecaoRaca.Name = "cmb_selecaoRaca";
            cmb_selecaoRaca.Size = new Size(145, 23);
            cmb_selecaoRaca.TabIndex = 7;
            cmb_selecaoRaca.SelectedIndexChanged += cmb_selecaoRaca_SelectedIndexChanged;
            // 
            // lb_temperamento
            // 
            lb_temperamento.AutoSize = true;
            lb_temperamento.Location = new Point(179, 129);
            lb_temperamento.Name = "lb_temperamento";
            lb_temperamento.Size = new Size(59, 15);
            lb_temperamento.TabIndex = 8;
            lb_temperamento.Text = "Resultado";
            // 
            // lb_origem
            // 
            lb_origem.AutoSize = true;
            lb_origem.Location = new Point(181, 163);
            lb_origem.Name = "lb_origem";
            lb_origem.Size = new Size(59, 15);
            lb_origem.TabIndex = 9;
            lb_origem.Text = "Resultado";
            // 
            // lb_Descricao
            // 
            lb_Descricao.AutoSize = true;
            lb_Descricao.Location = new Point(179, 202);
            lb_Descricao.Name = "lb_Descricao";
            lb_Descricao.Size = new Size(59, 15);
            lb_Descricao.TabIndex = 10;
            lb_Descricao.Text = "Resultado";
            // 
            // BuscarRacaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 438);
            Controls.Add(lb_Descricao);
            Controls.Add(lb_origem);
            Controls.Add(lb_temperamento);
            Controls.Add(cmb_selecaoRaca);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "BuscarRacaForm";
            Text = "Buscar Raças";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox1;
        private ComboBox cmb_selecaoRaca;
        private Label lb_temperamento;
        private Label lb_origem;
        private Label lb_Descricao;
    }
}