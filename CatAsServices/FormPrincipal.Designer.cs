namespace CatAsServices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            menuStrip1 = new MenuStrip();
            buscarRaçasToolStripMenuItem = new ToolStripMenuItem();
            meusFavoritosToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { buscarRaçasToolStripMenuItem, meusFavoritosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(622, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // buscarRaçasToolStripMenuItem
            // 
            buscarRaçasToolStripMenuItem.Name = "buscarRaçasToolStripMenuItem";
            buscarRaçasToolStripMenuItem.Size = new Size(87, 20);
            buscarRaçasToolStripMenuItem.Text = "Buscar Raças";
            buscarRaçasToolStripMenuItem.Click += buscarRaçasToolStripMenuItem_Click;
            // 
            // meusFavoritosToolStripMenuItem
            // 
            meusFavoritosToolStripMenuItem.Name = "meusFavoritosToolStripMenuItem";
            meusFavoritosToolStripMenuItem.Size = new Size(99, 20);
            meusFavoritosToolStripMenuItem.Text = "Meus Favoritos";
            meusFavoritosToolStripMenuItem.Click += meusFavoritosToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(622, 398);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(149, 203);
            label1.Name = "label1";
            label1.Size = new Size(302, 24);
            label1.TabIndex = 1;
            label1.Text = "Bem vindo ao Cat as Service";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(247, 64);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 117);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 428);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormPrincipal";
            Text = "Bem Vindo ao Cat As Service";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem buscarRaçasToolStripMenuItem;
        private ToolStripMenuItem meusFavoritosToolStripMenuItem;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
    }
}