namespace PooFinal
{
    partial class formMain
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
            this.btnFuncionarioFerramenta = new System.Windows.Forms.Button();
            this.btnYoutuberVideo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFuncionarioFerramenta
            // 
            this.btnFuncionarioFerramenta.Location = new System.Drawing.Point(12, 12);
            this.btnFuncionarioFerramenta.Name = "btnFuncionarioFerramenta";
            this.btnFuncionarioFerramenta.Size = new System.Drawing.Size(176, 50);
            this.btnFuncionarioFerramenta.TabIndex = 0;
            this.btnFuncionarioFerramenta.Text = "1 - Funcionário | Ferramenta";
            this.btnFuncionarioFerramenta.UseVisualStyleBackColor = true;
            this.btnFuncionarioFerramenta.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnYoutuberVideo
            // 
            this.btnYoutuberVideo.Location = new System.Drawing.Point(194, 12);
            this.btnYoutuberVideo.Name = "btnYoutuberVideo";
            this.btnYoutuberVideo.Size = new System.Drawing.Size(176, 50);
            this.btnYoutuberVideo.TabIndex = 1;
            this.btnYoutuberVideo.Text = "2 - YouTuber | Vídeo";
            this.btnYoutuberVideo.UseVisualStyleBackColor = true;
            this.btnYoutuberVideo.Click += new System.EventHandler(this.btnYoutuberVideo_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnYoutuberVideo);
            this.Controls.Add(this.btnFuncionarioFerramenta);
            this.Name = "formMain";
            this.Text = "POO - Final";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFuncionarioFerramenta;
        private System.Windows.Forms.Button btnYoutuberVideo;
    }
}

