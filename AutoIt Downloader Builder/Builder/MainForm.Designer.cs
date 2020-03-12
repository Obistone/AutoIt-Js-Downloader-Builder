namespace Builder
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TitleLabel = new LuminosityLoader.Theme.StrafeHeader();
            this.s = new System.Windows.Forms.Label();
            this.MainSeperator = new LuminosityLoader.Theme.StrafeSeparator();
            this.DirectLinkTextBox = new LuminosityLoader.Theme.TxtBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FoldernameTextBox = new LuminosityLoader.Theme.TxtBox();
            this.CompileButton = new LuminosityLoader.Theme.StrafeButton();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.Location = new System.Drawing.Point(12, 12);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(72, 32);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Builder";
            // 
            // s
            // 
            this.s.AutoSize = true;
            this.s.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(82)))), ((int)(((byte)(96)))));
            this.s.Location = new System.Drawing.Point(13, 48);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(269, 17);
            this.s.TabIndex = 1;
            this.s.Text = "Configure and compile your .js downloader";
            // 
            // MainSeperator
            // 
            this.MainSeperator.Location = new System.Drawing.Point(15, 67);
            this.MainSeperator.Name = "MainSeperator";
            this.MainSeperator.Size = new System.Drawing.Size(369, 6);
            this.MainSeperator.TabIndex = 2;
            // 
            // DirectLinkTextBox
            // 
            this.DirectLinkTextBox.BackColor = System.Drawing.Color.White;
            this.DirectLinkTextBox.Image = null;
            this.DirectLinkTextBox.Location = new System.Drawing.Point(15, 118);
            this.DirectLinkTextBox.MaxLength = 32767;
            this.DirectLinkTextBox.Name = "DirectLinkTextBox";
            this.DirectLinkTextBox.NoRounding = false;
            this.DirectLinkTextBox.Size = new System.Drawing.Size(369, 31);
            this.DirectLinkTextBox.TabIndex = 3;
            this.DirectLinkTextBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.DirectLinkTextBox.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(82)))), ((int)(((byte)(96)))));
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Direct Link:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(82)))), ((int)(((byte)(96)))));
            this.label1.Location = new System.Drawing.Point(13, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Folder Name:";
            // 
            // FoldernameTextBox
            // 
            this.FoldernameTextBox.BackColor = System.Drawing.Color.White;
            this.FoldernameTextBox.Image = null;
            this.FoldernameTextBox.Location = new System.Drawing.Point(15, 186);
            this.FoldernameTextBox.MaxLength = 32767;
            this.FoldernameTextBox.Name = "FoldernameTextBox";
            this.FoldernameTextBox.NoRounding = false;
            this.FoldernameTextBox.Size = new System.Drawing.Size(369, 31);
            this.FoldernameTextBox.TabIndex = 5;
            this.FoldernameTextBox.Text = "flaw";
            this.FoldernameTextBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.FoldernameTextBox.UseSystemPasswordChar = false;
            // 
            // CompileButton
            // 
            this.CompileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CompileButton.EnabledCalc = true;
            this.CompileButton.Location = new System.Drawing.Point(16, 285);
            this.CompileButton.Name = "CompileButton";
            this.CompileButton.Size = new System.Drawing.Size(368, 38);
            this.CompileButton.TabIndex = 7;
            this.CompileButton.Text = "Compile";
            this.CompileButton.Click += new LuminosityLoader.Theme.Base.ButtonBase.ClickEventHandler(this.CompileButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(396, 335);
            this.Controls.Add(this.CompileButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FoldernameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DirectLinkTextBox);
            this.Controls.Add(this.MainSeperator);
            this.Controls.Add(this.s);
            this.Controls.Add(this.TitleLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(82)))), ((int)(((byte)(96)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoIt Downloader Builder";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LuminosityLoader.Theme.StrafeHeader TitleLabel;
        private System.Windows.Forms.Label s;
        private LuminosityLoader.Theme.StrafeSeparator MainSeperator;
        private LuminosityLoader.Theme.TxtBox DirectLinkTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private LuminosityLoader.Theme.TxtBox FoldernameTextBox;
        private LuminosityLoader.Theme.StrafeButton CompileButton;
    }
}

