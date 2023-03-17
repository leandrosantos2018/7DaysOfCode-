namespace CatAsServices
{
    partial class FormFavorito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFavorito));
            label1 = new Label();
            label2 = new Label();
            listViewGAtinho = new ListView();
            btn_Excluir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(52, 37);
            label1.Name = "label1";
            label1.Size = new Size(144, 23);
            label1.TabIndex = 0;
            label1.Text = "Meus Favoritos";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(52, 72);
            label2.Name = "label2";
            label2.Size = new Size(321, 19);
            label2.TabIndex = 1;
            label2.Text = "Aqui você encontra a lista de gatos favoritos";
            // 
            // listViewGAtinho
            // 
            listViewGAtinho.Location = new Point(52, 128);
            listViewGAtinho.Name = "listViewGAtinho";
            listViewGAtinho.Size = new Size(386, 186);
            listViewGAtinho.TabIndex = 2;
            listViewGAtinho.UseCompatibleStateImageBehavior = false;
            listViewGAtinho.SelectedIndexChanged += listViewGAtinho_SelectedIndexChanged;
            // 
            // btn_Excluir
            // 
            btn_Excluir.Location = new Point(323, 342);
            btn_Excluir.Name = "btn_Excluir";
            btn_Excluir.Size = new Size(115, 23);
            btn_Excluir.TabIndex = 3;
            btn_Excluir.Text = "Excluir Favorito";
            btn_Excluir.UseVisualStyleBackColor = true;
            // 
            // FormFavorito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(534, 415);
            Controls.Add(btn_Excluir);
            Controls.Add(listViewGAtinho);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormFavorito";
            Text = "Buscar Raças Favoritas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListView listViewGAtinho;
        private Button btn_Excluir;
    }
}