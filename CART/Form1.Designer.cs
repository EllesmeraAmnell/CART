namespace CART
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSource = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonSource = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabResult = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numLevels = new System.Windows.Forms.NumericUpDown();
            this.buttonBuild = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabSource.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabResult.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLevels)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(791, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.openToolStripMenuItem.Text = "Load dataset...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.buttonSource_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(213, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.toolStripSeparator2,
            this.viewHelpToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(220, 30);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSource);
            this.tabControl1.Controls.Add(this.tabResult);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(791, 395);
            this.tabControl1.TabIndex = 1;
            // 
            // tabSource
            // 
            this.tabSource.Controls.Add(this.label2);
            this.tabSource.Controls.Add(this.textBox1);
            this.tabSource.Controls.Add(this.buttonSource);
            this.tabSource.Controls.Add(this.dataGridView1);
            this.helpProvider1.SetHelpKeyword(this.tabSource, "Select");
            this.tabSource.Location = new System.Drawing.Point(4, 25);
            this.tabSource.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSource.Name = "tabSource";
            this.tabSource.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.helpProvider1.SetShowHelp(this.tabSource, false);
            this.tabSource.Size = new System.Drawing.Size(783, 366);
            this.tabSource.TabIndex = 0;
            this.tabSource.Text = "Dataset";
            this.tabSource.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(705, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Edit or delete rows if needed. Note: first line of data should contain column nam" +
    "es, one of them must be \'class\'.";
            // 
            // textBox1
            // 
            this.helpProvider1.SetHelpKeyword(this.textBox1, "1000.html");
            this.helpProvider1.SetHelpNavigator(this.textBox1, System.Windows.Forms.HelpNavigator.Topic);
            this.textBox1.Location = new System.Drawing.Point(110, 7);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.textBox1, true);
            this.textBox1.Size = new System.Drawing.Size(667, 22);
            this.textBox1.TabIndex = 2;
            // 
            // buttonSource
            // 
            this.helpProvider1.SetHelpKeyword(this.buttonSource, "1000.html");
            this.helpProvider1.SetHelpNavigator(this.buttonSource, System.Windows.Forms.HelpNavigator.Topic);
            this.helpProvider1.SetHelpString(this.buttonSource, "");
            this.buttonSource.Location = new System.Drawing.Point(7, 5);
            this.buttonSource.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSource.Name = "buttonSource";
            this.helpProvider1.SetShowHelp(this.buttonSource, true);
            this.buttonSource.Size = new System.Drawing.Size(98, 26);
            this.buttonSource.TabIndex = 1;
            this.buttonSource.Text = "Browse...";
            this.buttonSource.UseVisualStyleBackColor = true;
            this.buttonSource.Click += new System.EventHandler(this.buttonSource_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.helpProvider1.SetHelpKeyword(this.dataGridView1, "1001.html");
            this.helpProvider1.SetHelpNavigator(this.dataGridView1, System.Windows.Forms.HelpNavigator.Topic);
            this.helpProvider1.SetHelpString(this.dataGridView1, "");
            this.dataGridView1.Location = new System.Drawing.Point(5, 36);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.helpProvider1.SetShowHelp(this.dataGridView1, true);
            this.dataGridView1.Size = new System.Drawing.Size(772, 304);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabResult
            // 
            this.tabResult.Controls.Add(this.groupBox1);
            this.tabResult.Controls.Add(this.buttonBuild);
            this.tabResult.Controls.Add(this.treeView1);
            this.helpProvider1.SetHelpKeyword(this.tabResult, "1002.html");
            this.helpProvider1.SetHelpNavigator(this.tabResult, System.Windows.Forms.HelpNavigator.Topic);
            this.tabResult.Location = new System.Drawing.Point(4, 25);
            this.tabResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabResult.Name = "tabResult";
            this.tabResult.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.helpProvider1.SetShowHelp(this.tabResult, true);
            this.tabResult.Size = new System.Drawing.Size(783, 366);
            this.tabResult.TabIndex = 1;
            this.tabResult.Text = "Tree";
            this.tabResult.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numLevels);
            this.helpProvider1.SetHelpKeyword(this.groupBox1, "1003.html");
            this.helpProvider1.SetHelpNavigator(this.groupBox1, System.Windows.Forms.HelpNavigator.Topic);
            this.groupBox1.Location = new System.Drawing.Point(7, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.helpProvider1.SetShowHelp(this.groupBox1, true);
            this.groupBox1.Size = new System.Drawing.Size(236, 59);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Levels count";
            // 
            // numLevels
            // 
            this.numLevels.Location = new System.Drawing.Point(130, 26);
            this.numLevels.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numLevels.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLevels.Name = "numLevels";
            this.numLevels.Size = new System.Drawing.Size(101, 22);
            this.numLevels.TabIndex = 2;
            this.numLevels.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonBuild
            // 
            this.buttonBuild.Location = new System.Drawing.Point(622, 10);
            this.buttonBuild.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBuild.Name = "buttonBuild";
            this.buttonBuild.Size = new System.Drawing.Size(153, 50);
            this.buttonBuild.TabIndex = 1;
            this.buttonBuild.Text = "Build tree";
            this.buttonBuild.UseVisualStyleBackColor = true;
            this.buttonBuild.Click += new System.EventHandler(this.buttonBuild_Click);
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.Location = new System.Drawing.Point(5, 74);
            this.treeView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(772, 289);
            this.treeView1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.button1);
            this.helpProvider1.SetHelpKeyword(this.tabPage1, "1004.html");
            this.helpProvider1.SetHelpNavigator(this.tabPage1, System.Windows.Forms.HelpNavigator.Topic);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.helpProvider1.SetShowHelp(this.tabPage1, true);
            this.tabPage1.Size = new System.Drawing.Size(783, 366);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Test";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(7, 338);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 24);
            this.button2.TabIndex = 6;
            this.button2.Text = "Test";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Test result";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(7, 35);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(772, 298);
            this.dataGridView2.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(110, 7);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(667, 22);
            this.textBox2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 5);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "Browse...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Data files|*.data;*.csv;*.txt";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewHelpToolStripMenuItem.Image")));
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.viewHelpToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(220, 30);
            this.viewHelpToolStripMenuItem.Text = "View Help...";
            this.viewHelpToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.viewHelpToolStripMenuItem.Click += new System.EventHandler(this.viewHelpToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(217, 6);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\Ellesmera\\Documents\\Сем 9\\Анализ Данных\\CART\\CART\\bin\\Debug\\HelpFile.chm" +
    "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 423);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "CART";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabSource.ResumeLayout(false);
            this.tabSource.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabResult.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLevels)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabResult;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonSource;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numLevels;
        private System.Windows.Forms.Button buttonBuild;
        public System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}

