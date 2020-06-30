namespace Quiz
{
    partial class Quiz
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quiz));
            this.lblFrage = new System.Windows.Forms.Label();
            this.btnEins = new System.Windows.Forms.Button();
            this.btnZwei = new System.Windows.Forms.Button();
            this.btnDrei = new System.Windows.Forms.Button();
            this.btnVier = new System.Windows.Forms.Button();
            this.üicAbwaegen = new System.Windows.Forms.PictureBox();
            this.pciInfo = new System.Windows.Forms.PictureBox();
            this.Lblrichtig = new System.Windows.Forms.Label();
            this.LblFalsch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.üicAbwaegen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pciInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFrage
            // 
            this.lblFrage.AutoSize = true;
            this.lblFrage.BackColor = System.Drawing.Color.Transparent;
            this.lblFrage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblFrage.ForeColor = System.Drawing.Color.White;
            this.lblFrage.Location = new System.Drawing.Point(160, 63);
            this.lblFrage.Name = "lblFrage";
            this.lblFrage.Size = new System.Drawing.Size(70, 25);
            this.lblFrage.TabIndex = 0;
            this.lblFrage.Text = "label1";
            this.lblFrage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEins
            // 
            this.btnEins.Location = new System.Drawing.Point(26, 364);
            this.btnEins.Name = "btnEins";
            this.btnEins.Size = new System.Drawing.Size(336, 61);
            this.btnEins.TabIndex = 1;
            this.btnEins.Text = "button1";
            this.btnEins.UseVisualStyleBackColor = true;
            this.btnEins.Click += new System.EventHandler(this.btnEins_Click);
            // 
            // btnZwei
            // 
            this.btnZwei.Location = new System.Drawing.Point(416, 365);
            this.btnZwei.Name = "btnZwei";
            this.btnZwei.Size = new System.Drawing.Size(318, 60);
            this.btnZwei.TabIndex = 2;
            this.btnZwei.Text = "button2";
            this.btnZwei.UseVisualStyleBackColor = true;
            this.btnZwei.Click += new System.EventHandler(this.btnZwei_Click);
            // 
            // btnDrei
            // 
            this.btnDrei.Location = new System.Drawing.Point(26, 466);
            this.btnDrei.Name = "btnDrei";
            this.btnDrei.Size = new System.Drawing.Size(331, 66);
            this.btnDrei.TabIndex = 3;
            this.btnDrei.Text = "button3";
            this.btnDrei.UseVisualStyleBackColor = true;
            this.btnDrei.Click += new System.EventHandler(this.btnDrei_Click);
            // 
            // btnVier
            // 
            this.btnVier.Location = new System.Drawing.Point(416, 466);
            this.btnVier.Name = "btnVier";
            this.btnVier.Size = new System.Drawing.Size(318, 66);
            this.btnVier.TabIndex = 4;
            this.btnVier.Text = "button4";
            this.btnVier.UseVisualStyleBackColor = true;
            this.btnVier.Click += new System.EventHandler(this.btnVier_Click);
            // 
            // üicAbwaegen
            // 
            this.üicAbwaegen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.üicAbwaegen.BackColor = System.Drawing.Color.Transparent;
            this.üicAbwaegen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("üicAbwaegen.BackgroundImage")));
            this.üicAbwaegen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.üicAbwaegen.InitialImage = ((System.Drawing.Image)(resources.GetObject("üicAbwaegen.InitialImage")));
            this.üicAbwaegen.Location = new System.Drawing.Point(278, 168);
            this.üicAbwaegen.Name = "üicAbwaegen";
            this.üicAbwaegen.Size = new System.Drawing.Size(222, 190);
            this.üicAbwaegen.TabIndex = 5;
            this.üicAbwaegen.TabStop = false;
            // 
            // pciInfo
            // 
            this.pciInfo.BackColor = System.Drawing.Color.Transparent;
            this.pciInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pciInfo.BackgroundImage")));
            this.pciInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pciInfo.Location = new System.Drawing.Point(722, 12);
            this.pciInfo.Name = "pciInfo";
            this.pciInfo.Size = new System.Drawing.Size(50, 50);
            this.pciInfo.TabIndex = 7;
            this.pciInfo.TabStop = false;
            this.pciInfo.Click += new System.EventHandler(this.pciInfo_Click);
            // 
            // Lblrichtig
            // 
            this.Lblrichtig.AutoSize = true;
            this.Lblrichtig.BackColor = System.Drawing.Color.Transparent;
            this.Lblrichtig.ForeColor = System.Drawing.Color.White;
            this.Lblrichtig.Location = new System.Drawing.Point(295, 140);
            this.Lblrichtig.Name = "Lblrichtig";
            this.Lblrichtig.Size = new System.Drawing.Size(78, 25);
            this.Lblrichtig.TabIndex = 10;
            this.Lblrichtig.Text = "Richtig";
            this.Lblrichtig.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LblFalsch
            // 
            this.LblFalsch.AutoSize = true;
            this.LblFalsch.BackColor = System.Drawing.Color.Transparent;
            this.LblFalsch.ForeColor = System.Drawing.Color.White;
            this.LblFalsch.Location = new System.Drawing.Point(442, 140);
            this.LblFalsch.Name = "LblFalsch";
            this.LblFalsch.Size = new System.Drawing.Size(76, 25);
            this.LblFalsch.TabIndex = 11;
            this.LblFalsch.Text = "Falsch";
            this.LblFalsch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.LblFalsch);
            this.Controls.Add(this.Lblrichtig);
            this.Controls.Add(this.pciInfo);
            this.Controls.Add(this.üicAbwaegen);
            this.Controls.Add(this.btnVier);
            this.Controls.Add(this.btnDrei);
            this.Controls.Add(this.btnZwei);
            this.Controls.Add(this.btnEins);
            this.Controls.Add(this.lblFrage);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Quiz";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz Dich durch!";
            this.Load += new System.EventHandler(this.Quiz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.üicAbwaegen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pciInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFrage;
        private System.Windows.Forms.Button btnEins;
        private System.Windows.Forms.Button btnZwei;
        private System.Windows.Forms.Button btnDrei;
        private System.Windows.Forms.Button btnVier;
        private System.Windows.Forms.PictureBox üicAbwaegen;
        private System.Windows.Forms.PictureBox pciInfo;
        private System.Windows.Forms.Label Lblrichtig;
        private System.Windows.Forms.Label LblFalsch;
    }
}

