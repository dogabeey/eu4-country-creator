namespace Quick_Country_Creator
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadModToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.path = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cntError = new System.Windows.Forms.Label();
            this.tagError = new System.Windows.Forms.Label();
            this.historyContent = new System.Windows.Forms.RichTextBox();
            this.countryContent = new System.Windows.Forms.RichTextBox();
            this.countryName = new System.Windows.Forms.TextBox();
            this.countryTag = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(376, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadModToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadModToolStripMenuItem
            // 
            this.loadModToolStripMenuItem.Name = "loadModToolStripMenuItem";
            this.loadModToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadModToolStripMenuItem.Text = "Load Mod...";
            this.loadModToolStripMenuItem.Click += new System.EventHandler(this.loadModToolStripMenuItem_Click);
            // 
            // openFile
            // 
            this.openFile.Filter = ".mod Files|*.mod";
            this.openFile.FileOk += new System.ComponentModel.CancelEventHandler(this.openFile_FileOk);
            // 
            // path
            // 
            this.path.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.path.Location = new System.Drawing.Point(54, 0);
            this.path.Multiline = true;
            this.path.Name = "path";
            this.path.ReadOnly = true;
            this.path.Size = new System.Drawing.Size(322, 24);
            this.path.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cntError);
            this.groupBox1.Controls.Add(this.tagError);
            this.groupBox1.Controls.Add(this.historyContent);
            this.groupBox1.Controls.Add(this.countryContent);
            this.groupBox1.Controls.Add(this.countryName);
            this.groupBox1.Controls.Add(this.countryTag);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(0, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 565);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(289, 536);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Create!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cntError
            // 
            this.cntError.AutoSize = true;
            this.cntError.Location = new System.Drawing.Point(263, 45);
            this.cntError.Name = "cntError";
            this.cntError.Size = new System.Drawing.Size(0, 13);
            this.cntError.TabIndex = 18;
            // 
            // tagError
            // 
            this.tagError.AutoSize = true;
            this.tagError.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tagError.ForeColor = System.Drawing.Color.Maroon;
            this.tagError.Location = new System.Drawing.Point(262, 16);
            this.tagError.Name = "tagError";
            this.tagError.Size = new System.Drawing.Size(0, 12);
            this.tagError.TabIndex = 17;
            // 
            // historyContent
            // 
            this.historyContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.historyContent.Location = new System.Drawing.Point(9, 330);
            this.historyContent.Name = "historyContent";
            this.historyContent.Size = new System.Drawing.Size(247, 200);
            this.historyContent.TabIndex = 15;
            this.historyContent.Text = "";
            // 
            // countryContent
            // 
            this.countryContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.countryContent.Location = new System.Drawing.Point(9, 91);
            this.countryContent.Name = "countryContent";
            this.countryContent.Size = new System.Drawing.Size(247, 200);
            this.countryContent.TabIndex = 16;
            this.countryContent.Text = "";
            // 
            // countryName
            // 
            this.countryName.Location = new System.Drawing.Point(156, 39);
            this.countryName.Name = "countryName";
            this.countryName.Size = new System.Drawing.Size(100, 20);
            this.countryName.TabIndex = 14;
            this.countryName.TextChanged += new System.EventHandler(this.countryName_TextChanged);
            // 
            // countryTag
            // 
            this.countryTag.Location = new System.Drawing.Point(156, 13);
            this.countryTag.Name = "countryTag";
            this.countryTag.Size = new System.Drawing.Size(100, 20);
            this.countryTag.TabIndex = 13;
            this.countryTag.TextChanged += new System.EventHandler(this.countryTag_TextChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Country History Content:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Country File Content:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Country Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Country Tag:";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 604);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.path);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "EU4 Quick Country Maker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadModToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.TextBox path;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label tagError;
        private System.Windows.Forms.RichTextBox historyContent;
        private System.Windows.Forms.RichTextBox countryContent;
        private System.Windows.Forms.TextBox countryName;
        private System.Windows.Forms.TextBox countryTag;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cntError;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

