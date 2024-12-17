namespace WindowsForms.Virus
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
            btnBaixar = new Button();
            pbDownload = new ProgressBar();
            lblTitulo = new Label();
            linkGithub = new LinkLabel();
            lblDownloadConcluido = new Label();
            lblGit = new Label();
            SuspendLayout();
            // 
            // btnBaixar
            // 
            btnBaixar.Font = new Font("Segoe UI", 14F);
            btnBaixar.Location = new Point(261, 58);
            btnBaixar.Name = "btnBaixar";
            btnBaixar.Size = new Size(80, 33);
            btnBaixar.TabIndex = 0;
            btnBaixar.Text = "Baixar";
            btnBaixar.UseVisualStyleBackColor = true;
            btnBaixar.Click += btnBaixar_Click;
            // 
            // pbDownload
            // 
            pbDownload.BackColor = SystemColors.ButtonHighlight;
            pbDownload.Location = new Point(20, 58);
            pbDownload.Name = "pbDownload";
            pbDownload.Size = new Size(235, 33);
            pbDownload.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 25F);
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(256, 46);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Virus Download";
            // 
            // linkGithub
            // 
            linkGithub.AutoSize = true;
            linkGithub.Font = new Font("Segoe UI", 11F);
            linkGithub.LinkBehavior = LinkBehavior.HoverUnderline;
            linkGithub.LinkVisited = true;
            linkGithub.Location = new Point(64, 176);
            linkGithub.Name = "linkGithub";
            linkGithub.Size = new Size(238, 20);
            linkGithub.TabIndex = 3;
            linkGithub.TabStop = true;
            linkGithub.Tag = "";
            linkGithub.Text = "https://github.com/BernardoSoder";
            linkGithub.LinkClicked += linkGithub_LinkClicked;
            // 
            // lblDownloadConcluido
            // 
            lblDownloadConcluido.AutoSize = true;
            lblDownloadConcluido.Font = new Font("Segoe UI", 21F);
            lblDownloadConcluido.ForeColor = Color.Red;
            lblDownloadConcluido.Location = new Point(20, 104);
            lblDownloadConcluido.Name = "lblDownloadConcluido";
            lblDownloadConcluido.Size = new Size(282, 38);
            lblDownloadConcluido.TabIndex = 4;
            lblDownloadConcluido.Text = "Download Concluído!";
            lblDownloadConcluido.Visible = false;
            // 
            // lblGit
            // 
            lblGit.AutoSize = true;
            lblGit.Font = new Font("Segoe UI", 11F);
            lblGit.Location = new Point(2, 176);
            lblGit.Name = "lblGit";
            lblGit.Size = new Size(56, 20);
            lblGit.TabIndex = 5;
            lblGit.Text = "Github:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 212);
            Controls.Add(lblGit);
            Controls.Add(lblDownloadConcluido);
            Controls.Add(linkGithub);
            Controls.Add(lblTitulo);
            Controls.Add(pbDownload);
            Controls.Add(btnBaixar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBaixar;
        private ProgressBar pbDownload;
        private Label lblTitulo;
        private LinkLabel linkGithub;
        private Label lblDownloadConcluido;
        private Label lblGit;
    }
}
