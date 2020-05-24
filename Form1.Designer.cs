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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadModToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.path = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.selectColor = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cntError = new System.Windows.Forms.Label();
            this.tagError = new System.Windows.Forms.Label();
            this.tempCountry = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.capital = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.primaryCulture = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.religion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.techGroup = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.govName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.countryName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.countryTag = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
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
            this.loadModToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.loadModToolStripMenuItem.Text = "Load Mod...";
            this.loadModToolStripMenuItem.Click += new System.EventHandler(this.loadModToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
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
            this.groupBox1.Controls.Add(this.selectColor);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cntError);
            this.groupBox1.Controls.Add(this.tagError);
            this.groupBox1.Controls.Add(this.tempCountry);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.capital);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.primaryCulture);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.religion);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.techGroup);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.govName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.countryName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.countryTag);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(0, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 337);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // selectColor
            // 
            this.selectColor.Location = new System.Drawing.Point(156, 221);
            this.selectColor.Name = "selectColor";
            this.selectColor.Size = new System.Drawing.Size(100, 21);
            this.selectColor.TabIndex = 9;
            this.selectColor.Text = "Select Color";
            this.selectColor.UseVisualStyleBackColor = true;
            this.selectColor.Click += new System.EventHandler(this.selectColor_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(289, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
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
            // tempCountry
            // 
            this.tempCountry.Location = new System.Drawing.Point(156, 195);
            this.tempCountry.Name = "tempCountry";
            this.tempCountry.Size = new System.Drawing.Size(100, 20);
            this.tempCountry.TabIndex = 8;
            this.tempCountry.TextChanged += new System.EventHandler(this.countryName_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 224);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "Color:";
            // 
            // capital
            // 
            this.capital.Location = new System.Drawing.Point(156, 169);
            this.capital.Name = "capital";
            this.capital.Size = new System.Drawing.Size(100, 20);
            this.capital.TabIndex = 7;
            this.capital.TextChanged += new System.EventHandler(this.countryName_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 198);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Template Country:";
            // 
            // primaryCulture
            // 
            this.primaryCulture.Location = new System.Drawing.Point(156, 143);
            this.primaryCulture.Name = "primaryCulture";
            this.primaryCulture.Size = new System.Drawing.Size(100, 20);
            this.primaryCulture.TabIndex = 6;
            this.primaryCulture.TextChanged += new System.EventHandler(this.countryName_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 172);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Capital:";
            // 
            // religion
            // 
            this.religion.Location = new System.Drawing.Point(156, 117);
            this.religion.Name = "religion";
            this.religion.Size = new System.Drawing.Size(100, 20);
            this.religion.TabIndex = 5;
            this.religion.TextChanged += new System.EventHandler(this.countryName_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Primary Culture:";
            // 
            // techGroup
            // 
            this.techGroup.Location = new System.Drawing.Point(156, 91);
            this.techGroup.Name = "techGroup";
            this.techGroup.Size = new System.Drawing.Size(100, 20);
            this.techGroup.TabIndex = 4;
            this.techGroup.TextChanged += new System.EventHandler(this.countryName_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Religion:";
            // 
            // govName
            // 
            this.govName.Location = new System.Drawing.Point(156, 65);
            this.govName.Name = "govName";
            this.govName.Size = new System.Drawing.Size(100, 20);
            this.govName.TabIndex = 3;
            this.govName.TextChanged += new System.EventHandler(this.countryName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Technology Group:";
            // 
            // countryName
            // 
            this.countryName.Location = new System.Drawing.Point(156, 39);
            this.countryName.Name = "countryName";
            this.countryName.Size = new System.Drawing.Size(100, 20);
            this.countryName.TabIndex = 2;
            this.countryName.TextChanged += new System.EventHandler(this.countryName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Government:";
            // 
            // countryTag
            // 
            this.countryTag.Location = new System.Drawing.Point(156, 13);
            this.countryTag.Name = "countryTag";
            this.countryTag.Size = new System.Drawing.Size(100, 20);
            this.countryTag.TabIndex = 1;
            this.countryTag.TextChanged += new System.EventHandler(this.countryTag_TextChanged_1);
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
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 363);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.path);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.TextBox countryName;
        private System.Windows.Forms.TextBox countryTag;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cntError;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox capital;
        private System.Windows.Forms.TextBox primaryCulture;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox religion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox techGroup;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox govName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tempCountry;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button selectColor;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Timer timer1;
    }
}

