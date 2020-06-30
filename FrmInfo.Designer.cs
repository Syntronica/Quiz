namespace Quiz
{
    partial class FrmInfo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInfo));
            this.picSteampunk = new System.Windows.Forms.PictureBox();
            this.picWebseite = new System.Windows.Forms.PictureBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picSteampunk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWebseite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // picSteampunk
            // 
            this.picSteampunk.BackColor = System.Drawing.Color.Transparent;
            this.picSteampunk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picSteampunk.BackgroundImage")));
            this.picSteampunk.Location = new System.Drawing.Point(12, 12);
            this.picSteampunk.Name = "picSteampunk";
            this.picSteampunk.Size = new System.Drawing.Size(250, 250);
            this.picSteampunk.TabIndex = 0;
            this.picSteampunk.TabStop = false;
            this.toolTip.SetToolTip(this.picSteampunk, "Bild des Programmierers");
            // 
            // picWebseite
            // 
            this.picWebseite.BackColor = System.Drawing.Color.Transparent;
            this.picWebseite.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picWebseite.BackgroundImage")));
            this.picWebseite.Location = new System.Drawing.Point(12, 268);
            this.picWebseite.Name = "picWebseite";
            this.picWebseite.Size = new System.Drawing.Size(200, 200);
            this.picWebseite.TabIndex = 1;
            this.picWebseite.TabStop = false;
            this.toolTip.SetToolTip(this.picWebseite, "Zur Webseite gehen ...");
            this.picWebseite.Click += new System.EventHandler(this.picWebseite_Click);
            // 
            // picExit
            // 
            this.picExit.BackColor = System.Drawing.Color.Transparent;
            this.picExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picExit.BackgroundImage")));
            this.picExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picExit.Location = new System.Drawing.Point(212, 418);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(50, 50);
            this.picExit.TabIndex = 2;
            this.picExit.TabStop = false;
            this.toolTip.SetToolTip(this.picExit, "Dieses Fenster schließen!");
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // FrmInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(276, 480);
            this.ControlBox = false;
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.picWebseite);
            this.Controls.Add(this.picSteampunk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInfo";
            this.Load += new System.EventHandler(this.FrmInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSteampunk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWebseite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picSteampunk;
        private System.Windows.Forms.PictureBox picWebseite;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.ToolTip toolTip;
    }
}