using System.Windows.Forms;

namespace AntiIdle
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
            this.AntiIdleIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.statusToolStripMenuItem = new System.Windows.Forms.ToolStripLabel();
            this.separator = new System.Windows.Forms.ToolStripSeparator();
            this.actionAfterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fiveMinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tenMinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twentyMinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thirtyMinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oneHourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twoHoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.threeHoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fourHoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eightHoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizedTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.nowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // AntiIdleIcon
            // 
            this.AntiIdleIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("AntiIdleIcon.Icon")));
            this.AntiIdleIcon.Text = "AntiIdleIcon";
            this.AntiIdleIcon.Visible = true;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusToolStripMenuItem,
            this.separator,
            this.actionAfterToolStripMenuItem,
            this.customizedTimeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(227, 116);
            // 
            // statusToolStripMenuItem
            // 
            this.statusToolStripMenuItem.Name = "statusToolStripMenuItem";
            this.statusToolStripMenuItem.Size = new System.Drawing.Size(87, 15);
            this.statusToolStripMenuItem.Text = "Status: Enabled";
            // 
            // separator
            // 
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(223, 6);
            // 
            // actionAfterToolStripMenuItem
            // 
            this.actionAfterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowToolStripMenuItem,
            this.fiveMinsToolStripMenuItem,
            this.tenMinsToolStripMenuItem,
            this.twentyMinsToolStripMenuItem,
            this.thirtyMinsToolStripMenuItem,
            this.oneHourToolStripMenuItem,
            this.twoHoursToolStripMenuItem,
            this.threeHoursToolStripMenuItem,
            this.fourHoursToolStripMenuItem,
            this.eightHoursToolStripMenuItem,
            this.neverToolStripMenuItem,
            this.customizedToolStripMenuItem});
            this.actionAfterToolStripMenuItem.Name = "actionAfterToolStripMenuItem";
            this.actionAfterToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.actionAfterToolStripMenuItem.Text = "Pause After";
            // 
            // fiveMinsToolStripMenuItem
            // 
            this.fiveMinsToolStripMenuItem.Name = "fiveMinsToolStripMenuItem";
            this.fiveMinsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fiveMinsToolStripMenuItem.Text = "5 minutes";
            this.fiveMinsToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem_Click);
            // 
            // tenMinsToolStripMenuItem
            // 
            this.tenMinsToolStripMenuItem.Name = "tenMinsToolStripMenuItem";
            this.tenMinsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tenMinsToolStripMenuItem.Text = "10 minutes";
            this.tenMinsToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem_Click);
            // 
            // twentyMinsToolStripMenuItem
            // 
            this.twentyMinsToolStripMenuItem.Name = "twentyMinsToolStripMenuItem";
            this.twentyMinsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.twentyMinsToolStripMenuItem.Text = "20 minutes";
            this.twentyMinsToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem_Click);
            // 
            // thirtyMinsToolStripMenuItem
            // 
            this.thirtyMinsToolStripMenuItem.Name = "thirtyMinsToolStripMenuItem";
            this.thirtyMinsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.thirtyMinsToolStripMenuItem.Text = "30 minutes";
            this.thirtyMinsToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem_Click);
            // 
            // oneHourToolStripMenuItem
            // 
            this.oneHourToolStripMenuItem.Name = "oneHourToolStripMenuItem";
            this.oneHourToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.oneHourToolStripMenuItem.Text = "1 hour";
            this.oneHourToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem_Click);
            // 
            // twoHoursToolStripMenuItem
            // 
            this.twoHoursToolStripMenuItem.Name = "twoHoursToolStripMenuItem";
            this.twoHoursToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.twoHoursToolStripMenuItem.Text = "2 hours";
            this.twoHoursToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem_Click);
            // 
            // threeHoursToolStripMenuItem
            // 
            this.threeHoursToolStripMenuItem.Name = "threeHoursToolStripMenuItem";
            this.threeHoursToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.threeHoursToolStripMenuItem.Text = "3 hours";
            this.threeHoursToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem_Click);
            // 
            // fourHoursToolStripMenuItem
            // 
            this.fourHoursToolStripMenuItem.Name = "fourHoursToolStripMenuItem";
            this.fourHoursToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fourHoursToolStripMenuItem.Text = "4 hours";
            this.fourHoursToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem_Click);
            // 
            // eightHoursToolStripMenuItem
            // 
            this.eightHoursToolStripMenuItem.Name = "eightHoursToolStripMenuItem";
            this.eightHoursToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.eightHoursToolStripMenuItem.Text = "8 hours";
            this.eightHoursToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem_Click);
            // 
            // neverToolStripMenuItem
            // 
            this.neverToolStripMenuItem.Name = "neverToolStripMenuItem";
            this.neverToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.neverToolStripMenuItem.Text = "Never";
            this.neverToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem_Click);
            // 
            // customizedToolStripMenuItem
            // 
            this.customizedToolStripMenuItem.Name = "customizedToolStripMenuItem";
            this.customizedToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.customizedToolStripMenuItem.Text = "Customized";
            this.customizedToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem_Click);
            // 
            // customizedTimeToolStripMenuItem
            // 
            this.customizedTimeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox});
            this.customizedTimeToolStripMenuItem.Name = "customizedTimeToolStripMenuItem";
            this.customizedTimeToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.customizedTimeToolStripMenuItem.Text = "Customized Time in Minutes";
            // 
            // toolStripTextBox
            // 
            this.toolStripTextBox.Name = "toolStripTextBox";
            this.toolStripTextBox.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox.Text = "60";
            this.toolStripTextBox.TextChanged += new System.EventHandler(this.toolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.TimerOnTick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // nowToolStripMenuItem
            // 
            this.nowToolStripMenuItem.Name = "nowToolStripMenuItem";
            this.nowToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nowToolStripMenuItem.Text = "Now";
            this.nowToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Name = "Form1";
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private NotifyIcon AntiIdleIcon;
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripLabel statusToolStripMenuItem;
        private ToolStripMenuItem actionAfterToolStripMenuItem;
        private ToolStripMenuItem fiveMinsToolStripMenuItem;
        private ToolStripMenuItem tenMinsToolStripMenuItem;
        private ToolStripMenuItem twentyMinsToolStripMenuItem;
        private ToolStripMenuItem thirtyMinsToolStripMenuItem;
        private ToolStripMenuItem oneHourToolStripMenuItem;
        private ToolStripMenuItem twoHoursToolStripMenuItem;
        private ToolStripMenuItem threeHoursToolStripMenuItem;
        private ToolStripMenuItem fourHoursToolStripMenuItem;
        private ToolStripMenuItem eightHoursToolStripMenuItem;
        private ToolStripMenuItem neverToolStripMenuItem;
        private Timer timer;
        private ToolStripMenuItem customizedToolStripMenuItem;
        private ToolStripMenuItem customizedTimeToolStripMenuItem;
        private ToolStripTextBox toolStripTextBox;
        private Timer timer1;
        private ToolStripSeparator separator;
        private ToolStripMenuItem nowToolStripMenuItem;
    }
}

