namespace GeckoExample
{
    partial class FormBrowser
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
            this.geckoWebBrowser = new Gecko.GeckoWebBrowser();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.buttonAvancar = new System.Windows.Forms.Button();
            this.buttonRecarregar = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // geckoWebBrowser
            // 
            this.geckoWebBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.geckoWebBrowser.FrameEventsPropagateToMainWindow = false;
            this.geckoWebBrowser.Location = new System.Drawing.Point(12, 41);
            this.geckoWebBrowser.Name = "geckoWebBrowser";
            this.geckoWebBrowser.Size = new System.Drawing.Size(776, 397);
            this.geckoWebBrowser.TabIndex = 0;
            this.geckoWebBrowser.UseHttpActivityObserver = false;
            this.geckoWebBrowser.DocumentCompleted += new System.EventHandler<Gecko.Events.GeckoDocumentCompletedEventArgs>(this.geckoWebBrowser_DocumentCompleted);
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(10, 12);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(24, 23);
            this.buttonVoltar.TabIndex = 1;
            this.buttonVoltar.Text = "<";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // buttonAvancar
            // 
            this.buttonAvancar.Location = new System.Drawing.Point(40, 12);
            this.buttonAvancar.Name = "buttonAvancar";
            this.buttonAvancar.Size = new System.Drawing.Size(24, 23);
            this.buttonAvancar.TabIndex = 2;
            this.buttonAvancar.Text = ">";
            this.buttonAvancar.UseVisualStyleBackColor = true;
            this.buttonAvancar.Click += new System.EventHandler(this.buttonAvancar_Click);
            // 
            // buttonRecarregar
            // 
            this.buttonRecarregar.Location = new System.Drawing.Point(70, 12);
            this.buttonRecarregar.Name = "buttonRecarregar";
            this.buttonRecarregar.Size = new System.Drawing.Size(24, 23);
            this.buttonRecarregar.TabIndex = 3;
            this.buttonRecarregar.Text = "R";
            this.buttonRecarregar.UseVisualStyleBackColor = true;
            this.buttonRecarregar.Click += new System.EventHandler(this.buttonRecarregar_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.Location = new System.Drawing.Point(100, 12);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(24, 23);
            this.buttonHome.TabIndex = 4;
            this.buttonHome.Text = "H";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUrl.Location = new System.Drawing.Point(130, 14);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(658, 20);
            this.textBoxUrl.TabIndex = 5;
            this.textBoxUrl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxUrl_KeyDown);
            // 
            // FormBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxUrl);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.buttonRecarregar);
            this.Controls.Add(this.buttonAvancar);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.geckoWebBrowser);
            this.Name = "FormBrowser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBrowser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormBrowser_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Gecko.GeckoWebBrowser geckoWebBrowser;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Button buttonAvancar;
        private System.Windows.Forms.Button buttonRecarregar;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.TextBox textBoxUrl;
    }
}

