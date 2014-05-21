namespace GeckoFX
{
    partial class Window
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.Content = new Gecko.GeckoWebBrowser();
            this.IconBar = new System.Windows.Forms.ToolStrip();
            this.GoBack = new System.Windows.Forms.ToolStripButton();
            this.GoForward = new System.Windows.Forms.ToolStripButton();
            this.GoRefresh = new System.Windows.Forms.ToolStripButton();
            this.GoHome = new System.Windows.Forms.ToolStripButton();
            this.Url = new System.Windows.Forms.ToolStripComboBox();
            this.GoOptions = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.IconBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.Content);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(984, 536);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(984, 561);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.IconBar);
            // 
            // Content
            // 
            this.Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Content.Location = new System.Drawing.Point(0, 0);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(984, 536);
            this.Content.TabIndex = 0;
            this.Content.UseHttpActivityObserver = false;
            this.Content.DocumentCompleted += new System.EventHandler<Gecko.Events.GeckoDocumentCompletedEventArgs>(this.Content_DocumentCompleted);
            this.Content.CreateWindow2 += new System.EventHandler<Gecko.GeckoCreateWindow2EventArgs>(this.Content_CreateWindow2);
            this.Content.DocumentTitleChanged += new System.EventHandler(this.Content_DocumentTitleChanged);
            // 
            // IconBar
            // 
            this.IconBar.AutoSize = false;
            this.IconBar.CanOverflow = false;
            this.IconBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.IconBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GoBack,
            this.GoForward,
            this.GoRefresh,
            this.GoHome,
            this.Url,
            this.GoOptions});
            this.IconBar.Location = new System.Drawing.Point(3, 0);
            this.IconBar.Name = "IconBar";
            this.IconBar.Size = new System.Drawing.Size(981, 25);
            this.IconBar.TabIndex = 0;
            // 
            // GoBack
            // 
            this.GoBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.GoBack.Enabled = false;
            this.GoBack.Image = ((System.Drawing.Image)(resources.GetObject("GoBack.Image")));
            this.GoBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GoBack.Name = "GoBack";
            this.GoBack.Size = new System.Drawing.Size(23, 22);
            this.GoBack.Text = "Back";
            this.GoBack.Click += new System.EventHandler(this.GoBack_Click);
            // 
            // GoForward
            // 
            this.GoForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.GoForward.Enabled = false;
            this.GoForward.Image = ((System.Drawing.Image)(resources.GetObject("GoForward.Image")));
            this.GoForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GoForward.Name = "GoForward";
            this.GoForward.Size = new System.Drawing.Size(23, 22);
            this.GoForward.Text = "Forward";
            this.GoForward.Click += new System.EventHandler(this.GoForward_Click);
            // 
            // GoRefresh
            // 
            this.GoRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.GoRefresh.Image = ((System.Drawing.Image)(resources.GetObject("GoRefresh.Image")));
            this.GoRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GoRefresh.Name = "GoRefresh";
            this.GoRefresh.Size = new System.Drawing.Size(23, 22);
            this.GoRefresh.Text = "Refresh";
            this.GoRefresh.Click += new System.EventHandler(this.GoRefresh_Click);
            // 
            // GoHome
            // 
            this.GoHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.GoHome.Image = ((System.Drawing.Image)(resources.GetObject("GoHome.Image")));
            this.GoHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GoHome.Name = "GoHome";
            this.GoHome.Size = new System.Drawing.Size(23, 22);
            this.GoHome.Text = "Home";
            this.GoHome.Click += new System.EventHandler(this.GoHome_Click);
            // 
            // Url
            // 
            this.Url.AutoSize = false;
            this.Url.Name = "Url";
            this.Url.Size = new System.Drawing.Size(862, 25);
            this.Url.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Url_KeyPress);
            // 
            // GoOptions
            // 
            this.GoOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.GoOptions.Image = ((System.Drawing.Image)(resources.GetObject("GoOptions.Image")));
            this.GoOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GoOptions.Name = "GoOptions";
            this.GoOptions.Size = new System.Drawing.Size(23, 22);
            this.GoOptions.Text = "Options";
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.toolStripContainer1);
            this.MinimumSize = new System.Drawing.Size(300, 200);
            this.Name = "Window";
            this.Text = "GeckoFX";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.IconBar.ResumeLayout(false);
            this.IconBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private Gecko.GeckoWebBrowser Content;
        private System.Windows.Forms.ToolStrip IconBar;
        private System.Windows.Forms.ToolStripButton GoBack;
        private System.Windows.Forms.ToolStripButton GoForward;
        private System.Windows.Forms.ToolStripButton GoRefresh;
        private System.Windows.Forms.ToolStripButton GoHome;
        private System.Windows.Forms.ToolStripComboBox Url;
        private System.Windows.Forms.ToolStripButton GoOptions;
    }
}

