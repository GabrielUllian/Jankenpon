
namespace Jankenpon
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbPlacar = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblC = new System.Windows.Forms.Label();
            this.lblP = new System.Windows.Forms.Label();
            this.lblPlacarCPU = new System.Windows.Forms.Label();
            this.lblPlacarJogador = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pbCPU = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbEscolhaJogador = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTesoura = new System.Windows.Forms.Button();
            this.btnPapel = new System.Windows.Forms.Button();
            this.btnPedra = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gbPlacar.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCPU)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEscolhaJogador)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.gbPlacar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(619, 242);
            this.panel1.TabIndex = 0;
            // 
            // gbPlacar
            // 
            this.gbPlacar.Controls.Add(this.btnReset);
            this.gbPlacar.Controls.Add(this.lblC);
            this.gbPlacar.Controls.Add(this.lblP);
            this.gbPlacar.Controls.Add(this.lblPlacarCPU);
            this.gbPlacar.Controls.Add(this.lblPlacarJogador);
            this.gbPlacar.Controls.Add(this.label1);
            this.gbPlacar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbPlacar.Location = new System.Drawing.Point(212, 45);
            this.gbPlacar.Name = "gbPlacar";
            this.gbPlacar.Size = new System.Drawing.Size(200, 194);
            this.gbPlacar.TabIndex = 4;
            this.gbPlacar.TabStop = false;
            this.gbPlacar.Text = "Score";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Black;
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReset.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnReset.Location = new System.Drawing.Point(9, 151);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(185, 37);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.Location = new System.Drawing.Point(144, 78);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(32, 13);
            this.lblC.TabIndex = 6;
            this.lblC.Text = "CPU";
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP.Location = new System.Drawing.Point(7, 78);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(42, 13);
            this.lblP.TabIndex = 5;
            this.lblP.Text = "Player";
            // 
            // lblPlacarCPU
            // 
            this.lblPlacarCPU.AutoSize = true;
            this.lblPlacarCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlacarCPU.Location = new System.Drawing.Point(124, 94);
            this.lblPlacarCPU.Name = "lblPlacarCPU";
            this.lblPlacarCPU.Size = new System.Drawing.Size(52, 55);
            this.lblPlacarCPU.TabIndex = 4;
            this.lblPlacarCPU.Text = "0";
            // 
            // lblPlacarJogador
            // 
            this.lblPlacarJogador.AutoSize = true;
            this.lblPlacarJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlacarJogador.Location = new System.Drawing.Point(6, 94);
            this.lblPlacarJogador.Name = "lblPlacarJogador";
            this.lblPlacarJogador.Size = new System.Drawing.Size(52, 55);
            this.lblPlacarJogador.TabIndex = 3;
            this.lblPlacarJogador.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(55, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "VS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(248, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Jankenpon";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pbCPU);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(415, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(195, 155);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CPU";
            // 
            // pbCPU
            // 
            this.pbCPU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbCPU.Location = new System.Drawing.Point(7, 20);
            this.pbCPU.Name = "pbCPU";
            this.pbCPU.Size = new System.Drawing.Size(182, 129);
            this.pbCPU.TabIndex = 0;
            this.pbCPU.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbEscolhaJogador);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(10, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 155);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player";
            // 
            // pbEscolhaJogador
            // 
            this.pbEscolhaJogador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbEscolhaJogador.Location = new System.Drawing.Point(7, 20);
            this.pbEscolhaJogador.Name = "pbEscolhaJogador";
            this.pbEscolhaJogador.Size = new System.Drawing.Size(182, 129);
            this.pbEscolhaJogador.TabIndex = 0;
            this.pbEscolhaJogador.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnTesoura);
            this.panel2.Controls.Add(this.btnPapel);
            this.panel2.Controls.Add(this.btnPedra);
            this.panel2.Location = new System.Drawing.Point(2, 252);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(619, 187);
            this.panel2.TabIndex = 1;
            // 
            // btnTesoura
            // 
            this.btnTesoura.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTesoura.BackgroundImage")));
            this.btnTesoura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTesoura.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTesoura.Location = new System.Drawing.Point(410, 0);
            this.btnTesoura.Name = "btnTesoura";
            this.btnTesoura.Size = new System.Drawing.Size(205, 187);
            this.btnTesoura.TabIndex = 2;
            this.btnTesoura.UseVisualStyleBackColor = true;
            this.btnTesoura.Click += new System.EventHandler(this.btnTesoura_Click);
            // 
            // btnPapel
            // 
            this.btnPapel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPapel.BackgroundImage")));
            this.btnPapel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPapel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPapel.Location = new System.Drawing.Point(205, 0);
            this.btnPapel.Name = "btnPapel";
            this.btnPapel.Size = new System.Drawing.Size(205, 187);
            this.btnPapel.TabIndex = 1;
            this.btnPapel.UseVisualStyleBackColor = true;
            this.btnPapel.Click += new System.EventHandler(this.btnPapel_Click);
            // 
            // btnPedra
            // 
            this.btnPedra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPedra.BackgroundImage")));
            this.btnPedra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPedra.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPedra.Location = new System.Drawing.Point(0, 0);
            this.btnPedra.Name = "btnPedra";
            this.btnPedra.Size = new System.Drawing.Size(205, 187);
            this.btnPedra.TabIndex = 0;
            this.btnPedra.UseVisualStyleBackColor = true;
            this.btnPedra.Click += new System.EventHandler(this.btnPedra_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(618, 441);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Jankenpon";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbPlacar.ResumeLayout(false);
            this.gbPlacar.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCPU)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbEscolhaJogador)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTesoura;
        private System.Windows.Forms.Button btnPapel;
        private System.Windows.Forms.Button btnPedra;
        private System.Windows.Forms.PictureBox pbCPU;
        private System.Windows.Forms.PictureBox pbEscolhaJogador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbPlacar;
        private System.Windows.Forms.Label lblPlacarCPU;
        private System.Windows.Forms.Label lblPlacarJogador;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.Button btnReset;
    }
}

