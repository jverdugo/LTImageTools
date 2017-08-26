namespace LTImageTools
{
    partial class MainMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encodeSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encodeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decodeSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decodeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxDecodedView = new System.Windows.Forms.PictureBox();
            this.GridViewImages = new System.Windows.Forms.DataGridView();
            this.ImageFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDecodedView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewImages)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.BackColor = System.Drawing.Color.SteelBlue;
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(1087, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAllToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.loadToolStripMenuItem.Text = "Load from folder";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encodeSelectedToolStripMenuItem,
            this.encodeAllToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.saveToolStripMenuItem.Text = "Encode";
            // 
            // encodeSelectedToolStripMenuItem
            // 
            this.encodeSelectedToolStripMenuItem.Name = "encodeSelectedToolStripMenuItem";
            this.encodeSelectedToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.encodeSelectedToolStripMenuItem.Text = "Encode Selected";
            this.encodeSelectedToolStripMenuItem.Click += new System.EventHandler(this.encodeSelectedToolStripMenuItem_Click);
            // 
            // encodeAllToolStripMenuItem
            // 
            this.encodeAllToolStripMenuItem.Name = "encodeAllToolStripMenuItem";
            this.encodeAllToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.encodeAllToolStripMenuItem.Text = "Encode All";
            this.encodeAllToolStripMenuItem.Click += new System.EventHandler(this.encodeAllToolStripMenuItem_Click);
            // 
            // saveAllToolStripMenuItem
            // 
            this.saveAllToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.decodeSelectedToolStripMenuItem,
            this.decodeAllToolStripMenuItem});
            this.saveAllToolStripMenuItem.Name = "saveAllToolStripMenuItem";
            this.saveAllToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.saveAllToolStripMenuItem.Text = "Decode";
            // 
            // decodeSelectedToolStripMenuItem
            // 
            this.decodeSelectedToolStripMenuItem.Name = "decodeSelectedToolStripMenuItem";
            this.decodeSelectedToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.decodeSelectedToolStripMenuItem.Text = "Decode Selected";
            this.decodeSelectedToolStripMenuItem.Click += new System.EventHandler(this.decodeSelectedToolStripMenuItem_Click);
            // 
            // decodeAllToolStripMenuItem
            // 
            this.decodeAllToolStripMenuItem.Name = "decodeAllToolStripMenuItem";
            this.decodeAllToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.decodeAllToolStripMenuItem.Text = "Decode All";
            this.decodeAllToolStripMenuItem.Click += new System.EventHandler(this.decodeAllToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem1});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.optionsToolStripMenuItem.Text = "Tools";
            // 
            // optionsToolStripMenuItem1
            // 
            this.optionsToolStripMenuItem1.Name = "optionsToolStripMenuItem1";
            this.optionsToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.optionsToolStripMenuItem1.Text = "Options";
            // 
            // pictureBoxDecodedView
            // 
            this.pictureBoxDecodedView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxDecodedView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxDecodedView.Location = new System.Drawing.Point(647, 41);
            this.pictureBoxDecodedView.Name = "pictureBoxDecodedView";
            this.pictureBoxDecodedView.Size = new System.Drawing.Size(428, 410);
            this.pictureBoxDecodedView.TabIndex = 1;
            this.pictureBoxDecodedView.TabStop = false;
            // 
            // GridViewImages
            // 
            this.GridViewImages.AllowUserToAddRows = false;
            this.GridViewImages.AllowUserToDeleteRows = false;
            this.GridViewImages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridViewImages.BackgroundColor = System.Drawing.Color.White;
            this.GridViewImages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewImages.GridColor = System.Drawing.Color.DodgerBlue;
            this.GridViewImages.Location = new System.Drawing.Point(12, 41);
            this.GridViewImages.Name = "GridViewImages";
            this.GridViewImages.Size = new System.Drawing.Size(615, 410);
            this.GridViewImages.TabIndex = 2;
            this.GridViewImages.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.GridViewImages_CellBeginEdit);
            this.GridViewImages.SelectionChanged += new System.EventHandler(this.GridViewImages_SelectionChanged);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 470);
            this.Controls.Add(this.GridViewImages);
            this.Controls.Add(this.pictureBoxDecodedView);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainMenu";
            this.Text = "Lost Technology Tools";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDecodedView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewImages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBoxDecodedView;
        private System.Windows.Forms.DataGridView GridViewImages;
        private System.Windows.Forms.FolderBrowserDialog ImageFolderDialog;
        private System.Windows.Forms.ToolStripMenuItem saveAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encodeSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encodeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decodeSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decodeAllToolStripMenuItem;
    }
}

