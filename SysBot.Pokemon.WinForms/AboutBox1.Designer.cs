namespace SysBot.Pokemon.WinForms
{
    partial class AboutBox1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox1));
            tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            logoPictureBox = new System.Windows.Forms.PictureBox();
            labelProductName = new System.Windows.Forms.Label();
            labelVersion = new System.Windows.Forms.Label();
            labelCopyright = new System.Windows.Forms.Label();
            labelCompanyName = new System.Windows.Forms.Label();
            textBoxDescription = new System.Windows.Forms.TextBox();
            okButton = new System.Windows.Forms.Button();
            btn_linktree = new System.Windows.Forms.Button();
            btn_Twitch = new System.Windows.Forms.Button();
            btn_discord = new System.Windows.Forms.Button();
            tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 5;
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.1371346F));
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.2845526F));
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.7967482F));
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.6097565F));
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.7723579F));
            tableLayoutPanel.Controls.Add(logoPictureBox, 0, 0);
            tableLayoutPanel.Controls.Add(labelProductName, 1, 0);
            tableLayoutPanel.Controls.Add(labelVersion, 1, 1);
            tableLayoutPanel.Controls.Add(labelCopyright, 1, 2);
            tableLayoutPanel.Controls.Add(labelCompanyName, 1, 3);
            tableLayoutPanel.Controls.Add(textBoxDescription, 1, 4);
            tableLayoutPanel.Controls.Add(okButton, 4, 6);
            tableLayoutPanel.Controls.Add(btn_linktree, 1, 5);
            tableLayoutPanel.Controls.Add(btn_Twitch, 2, 5);
            tableLayoutPanel.Controls.Add(btn_discord, 3, 5);
            tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel.Location = new System.Drawing.Point(10, 10);
            tableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 7;
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44F));
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            tableLayoutPanel.Size = new System.Drawing.Size(615, 315);
            tableLayoutPanel.TabIndex = 0;
            // 
            // logoPictureBox
            // 
            logoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            logoPictureBox.Image = (System.Drawing.Image)resources.GetObject("logoPictureBox.Image");
            logoPictureBox.Location = new System.Drawing.Point(4, 3);
            logoPictureBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            logoPictureBox.Name = "logoPictureBox";
            tableLayoutPanel.SetRowSpan(logoPictureBox, 6);
            logoPictureBox.Size = new System.Drawing.Size(231, 269);
            logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            logoPictureBox.TabIndex = 12;
            logoPictureBox.TabStop = false;
            // 
            // labelProductName
            // 
            tableLayoutPanel.SetColumnSpan(labelProductName, 4);
            labelProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            labelProductName.Location = new System.Drawing.Point(246, 0);
            labelProductName.Margin = new System.Windows.Forms.Padding(7, 0, 4, 0);
            labelProductName.MaximumSize = new System.Drawing.Size(0, 20);
            labelProductName.Name = "labelProductName";
            labelProductName.Size = new System.Drawing.Size(365, 20);
            labelProductName.TabIndex = 19;
            labelProductName.Text = "Produktname";
            labelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelVersion
            // 
            tableLayoutPanel.SetColumnSpan(labelVersion, 4);
            labelVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            labelVersion.Location = new System.Drawing.Point(246, 25);
            labelVersion.Margin = new System.Windows.Forms.Padding(7, 0, 4, 0);
            labelVersion.MaximumSize = new System.Drawing.Size(0, 20);
            labelVersion.Name = "labelVersion";
            labelVersion.Size = new System.Drawing.Size(365, 20);
            labelVersion.TabIndex = 0;
            labelVersion.Text = "Version";
            labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCopyright
            // 
            tableLayoutPanel.SetColumnSpan(labelCopyright, 4);
            labelCopyright.Dock = System.Windows.Forms.DockStyle.Fill;
            labelCopyright.Location = new System.Drawing.Point(246, 50);
            labelCopyright.Margin = new System.Windows.Forms.Padding(7, 0, 4, 0);
            labelCopyright.MaximumSize = new System.Drawing.Size(0, 20);
            labelCopyright.Name = "labelCopyright";
            labelCopyright.Size = new System.Drawing.Size(365, 20);
            labelCopyright.TabIndex = 21;
            labelCopyright.Text = "Copyright";
            labelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCompanyName
            // 
            tableLayoutPanel.SetColumnSpan(labelCompanyName, 4);
            labelCompanyName.Dock = System.Windows.Forms.DockStyle.Fill;
            labelCompanyName.Location = new System.Drawing.Point(246, 75);
            labelCompanyName.Margin = new System.Windows.Forms.Padding(7, 0, 4, 0);
            labelCompanyName.MaximumSize = new System.Drawing.Size(0, 20);
            labelCompanyName.Name = "labelCompanyName";
            labelCompanyName.Size = new System.Drawing.Size(365, 20);
            labelCompanyName.TabIndex = 22;
            labelCompanyName.Text = "Firmenname";
            labelCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxDescription
            // 
            tableLayoutPanel.SetColumnSpan(textBoxDescription, 4);
            textBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            textBoxDescription.Location = new System.Drawing.Point(246, 103);
            textBoxDescription.Margin = new System.Windows.Forms.Padding(7, 3, 4, 3);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.ReadOnly = true;
            textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            textBoxDescription.Size = new System.Drawing.Size(365, 132);
            textBoxDescription.TabIndex = 23;
            textBoxDescription.TabStop = false;
            textBoxDescription.Text = "Beschreibung";
            // 
            // okButton
            // 
            okButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            okButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 1, true);
            okButton.Location = new System.Drawing.Point(531, 285);
            okButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(80, 27);
            okButton.TabIndex = 24;
            okButton.Text = "&OK";
            okButton.Click += okButton_Click;
            // 
            // btn_linktree
            // 
            btn_linktree.Anchor = System.Windows.Forms.AnchorStyles.Left;
            btn_linktree.Location = new System.Drawing.Point(243, 243);
            btn_linktree.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_linktree.Name = "btn_linktree";
            btn_linktree.Size = new System.Drawing.Size(80, 27);
            btn_linktree.TabIndex = 25;
            btn_linktree.Text = "&Linktree";
            btn_linktree.UseVisualStyleBackColor = true;
            btn_linktree.Click += btn_linktree_Click;
            // 
            // btn_Twitch
            // 
            btn_Twitch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            btn_Twitch.Location = new System.Drawing.Point(336, 243);
            btn_Twitch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_Twitch.Name = "btn_Twitch";
            btn_Twitch.Size = new System.Drawing.Size(80, 27);
            btn_Twitch.TabIndex = 26;
            btn_Twitch.Text = "&Twitch";
            btn_Twitch.UseVisualStyleBackColor = true;
            btn_Twitch.Click += btn_Twitch_Click;
            // 
            // btn_discord
            // 
            btn_discord.Anchor = System.Windows.Forms.AnchorStyles.Left;
            btn_discord.Location = new System.Drawing.Point(426, 243);
            btn_discord.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_discord.Name = "btn_discord";
            btn_discord.Size = new System.Drawing.Size(80, 27);
            btn_discord.TabIndex = 27;
            btn_discord.Text = "&Bot-Discord";
            btn_discord.UseVisualStyleBackColor = true;
            btn_discord.Click += btn_discord_Click;
            // 
            // AboutBox1
            // 
            AcceptButton = okButton;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(635, 335);
            Controls.Add(tableLayoutPanel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutBox1";
            Padding = new System.Windows.Forms.Padding(10);
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "AboutBox1";
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button btn_linktree;
        private System.Windows.Forms.Button btn_Twitch;
        private System.Windows.Forms.Button btn_discord;
    }
}
