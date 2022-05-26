namespace WinFormsApp4
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_progbar = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btn_progBar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tBar_red = new System.Windows.Forms.TrackBar();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.tBar_green = new System.Windows.Forms.TrackBar();
            this.tBar_blue = new System.Windows.Forms.TrackBar();
            this.lbl_red = new System.Windows.Forms.Label();
            this.lbl_green = new System.Windows.Forms.Label();
            this.lbl_blue = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lbl_updown = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repositoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refleshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBar_red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBar_green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBar_blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // lbl_progbar
            // 
            this.lbl_progbar.AutoSize = true;
            this.lbl_progbar.Location = new System.Drawing.Point(892, 25);
            this.lbl_progbar.Name = "lbl_progbar";
            this.lbl_progbar.Size = new System.Drawing.Size(78, 32);
            this.lbl_progbar.TabIndex = 0;
            this.lbl_progbar.Text = "label1";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(797, 70);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(278, 43);
            this.progressBar1.TabIndex = 1;
            this.toolTip1.SetToolTip(this.progressBar1, "Loading");
            this.progressBar1.Value = 50;
            // 
            // btn_progBar
            // 
            this.btn_progBar.AutoSize = true;
            this.btn_progBar.BackColor = System.Drawing.Color.Blue;
            this.btn_progBar.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btn_progBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_progBar.ForeColor = System.Drawing.Color.White;
            this.btn_progBar.Location = new System.Drawing.Point(830, 119);
            this.btn_progBar.Name = "btn_progBar";
            this.btn_progBar.Size = new System.Drawing.Size(208, 44);
            this.btn_progBar.TabIndex = 2;
            this.btn_progBar.Text = "Load ProgressBar";
            this.btn_progBar.UseVisualStyleBackColor = true;
            this.btn_progBar.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "ProgressBar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinFormsApp4.Properties.Resources.C__logo;
            this.pictureBox1.Location = new System.Drawing.Point(475, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // tBar_red
            // 
            this.tBar_red.Location = new System.Drawing.Point(73, 64);
            this.tBar_red.Maximum = 255;
            this.tBar_red.Name = "tBar_red";
            this.tBar_red.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tBar_red.Size = new System.Drawing.Size(45, 330);
            this.tBar_red.SmallChange = 5;
            this.tBar_red.TabIndex = 4;
            this.tBar_red.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tBar_red.Value = 155;
            this.tBar_red.Scroll += new System.EventHandler(this.tBar_Color_Scroll);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.Location = new System.Drawing.Point(1150, 0);
            this.vScrollBar1.Maximum = 600;
            this.vScrollBar1.Minimum = 25;
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 735);
            this.vScrollBar1.TabIndex = 5;
            this.vScrollBar1.Value = 25;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ScrollBar1_Scroll);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hScrollBar1.Location = new System.Drawing.Point(0, 718);
            this.hScrollBar1.Maximum = 1000;
            this.hScrollBar1.Minimum = 72;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(1150, 17);
            this.hScrollBar1.TabIndex = 6;
            this.hScrollBar1.Value = 100;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ScrollBar1_Scroll);
            // 
            // tBar_green
            // 
            this.tBar_green.Location = new System.Drawing.Point(124, 64);
            this.tBar_green.Maximum = 255;
            this.tBar_green.Name = "tBar_green";
            this.tBar_green.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tBar_green.Size = new System.Drawing.Size(45, 330);
            this.tBar_green.SmallChange = 5;
            this.tBar_green.TabIndex = 7;
            this.tBar_green.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tBar_green.Value = 155;
            this.tBar_green.Scroll += new System.EventHandler(this.tBar_Color_Scroll);
            // 
            // tBar_blue
            // 
            this.tBar_blue.Location = new System.Drawing.Point(175, 64);
            this.tBar_blue.Maximum = 255;
            this.tBar_blue.Name = "tBar_blue";
            this.tBar_blue.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tBar_blue.Size = new System.Drawing.Size(45, 330);
            this.tBar_blue.SmallChange = 5;
            this.tBar_blue.TabIndex = 8;
            this.tBar_blue.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tBar_blue.Value = 155;
            this.tBar_blue.Scroll += new System.EventHandler(this.tBar_Color_Scroll);
            // 
            // lbl_red
            // 
            this.lbl_red.AutoSize = true;
            this.lbl_red.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_red.Location = new System.Drawing.Point(61, 397);
            this.lbl_red.Name = "lbl_red";
            this.lbl_red.Size = new System.Drawing.Size(37, 21);
            this.lbl_red.TabIndex = 9;
            this.lbl_red.Text = "Red";
            // 
            // lbl_green
            // 
            this.lbl_green.AutoSize = true;
            this.lbl_green.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_green.Location = new System.Drawing.Point(104, 397);
            this.lbl_green.Name = "lbl_green";
            this.lbl_green.Size = new System.Drawing.Size(52, 21);
            this.lbl_green.TabIndex = 10;
            this.lbl_green.Text = "Green";
            // 
            // lbl_blue
            // 
            this.lbl_blue.AutoSize = true;
            this.lbl_blue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_blue.Location = new System.Drawing.Point(162, 397);
            this.lbl_blue.Name = "lbl_blue";
            this.lbl_blue.Size = new System.Drawing.Size(40, 21);
            this.lbl_blue.TabIndex = 11;
            this.lbl_blue.Text = "Blue";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Location = new System.Drawing.Point(495, 355);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(120, 39);
            this.numericUpDown1.TabIndex = 12;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.ThousandsSeparator = true;
            this.numericUpDown1.Value = new decimal(new int[] {
            155,
            0,
            0,
            65536});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // lbl_updown
            // 
            this.lbl_updown.AutoSize = true;
            this.lbl_updown.Location = new System.Drawing.Point(516, 411);
            this.lbl_updown.Name = "lbl_updown";
            this.lbl_updown.Size = new System.Drawing.Size(78, 32);
            this.lbl_updown.TabIndex = 13;
            this.lbl_updown.Text = "label1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 696);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1150, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stripStatusLabel1
            // 
            this.stripStatusLabel1.Name = "stripStatusLabel1";
            this.stripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.stripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.gitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1150, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectToolStripMenuItem,
            this.repositoryToolStripMenuItem,
            this.fileToolStripMenuItem1});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.projectToolStripMenuItem.Text = "Project";
            // 
            // repositoryToolStripMenuItem
            // 
            this.repositoryToolStripMenuItem.Name = "repositoryToolStripMenuItem";
            this.repositoryToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.repositoryToolStripMenuItem.Text = "Repository";
            this.repositoryToolStripMenuItem.Click += new System.EventHandler(this.repositoryToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(130, 22);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // gitToolStripMenuItem
            // 
            this.gitToolStripMenuItem.Name = "gitToolStripMenuItem";
            this.gitToolStripMenuItem.Size = new System.Drawing.Size(34, 20);
            this.gitToolStripMenuItem.Text = "Git";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refleshToolStripMenuItem,
            this.openToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(113, 48);
            // 
            // refleshToolStripMenuItem
            // 
            this.refleshToolStripMenuItem.Name = "refleshToolStripMenuItem";
            this.refleshToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.refleshToolStripMenuItem.Text = "Reflesh";
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.openToolStripMenuItem1.Text = "Open";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 735);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lbl_updown);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lbl_blue);
            this.Controls.Add(this.lbl_green);
            this.Controls.Add(this.lbl_red);
            this.Controls.Add(this.tBar_blue);
            this.Controls.Add(this.tBar_green);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.tBar_red);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_progBar);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lbl_progbar);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBar_red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBar_green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBar_blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label lbl_progbar;
        private ProgressBar progressBar1;
        private Button btn_progBar;
        private ToolTip toolTip1;
        private PictureBox pictureBox1;
        private TrackBar tBar_red;
        private VScrollBar vScrollBar1;
        private HScrollBar hScrollBar1;
        private TrackBar tBar_green;
        private TrackBar tBar_blue;
        private Label lbl_red;
        private Label lbl_green;
        private Label lbl_blue;
        private NumericUpDown numericUpDown1;
        private Label lbl_updown;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel stripStatusLabel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem projectToolStripMenuItem;
        private ToolStripMenuItem repositoryToolStripMenuItem;
        private ToolStripMenuItem fileToolStripMenuItem1;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem gitToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem refleshToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem1;
    }
}