﻿namespace P4Code
{
    partial class FormMain
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
            this.PreferencesBox = new System.Windows.Forms.ToolStripMenuItem();
            this.issueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requirementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.designToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countByAssigneeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listByAssigneeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countByArtifactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listByArtifactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countByDateRangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listByDateRangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trendByDateRangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PreferencesBox,
            this.issueToolStripMenuItem,
            this.requirementToolStripMenuItem,
            this.designToolStripMenuItem,
            this.textToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // PreferencesBox
            // 
            this.PreferencesBox.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectProjectToolStripMenuItem,
            this.createProjectToolStripMenuItem,
            this.modifyProjectToolStripMenuItem,
            this.removeProjectToolStripMenuItem});
            this.PreferencesBox.Name = "PreferencesBox";
            this.PreferencesBox.Size = new System.Drawing.Size(80, 20);
            this.PreferencesBox.Text = "Preferences";
            this.PreferencesBox.Click += new System.EventHandler(this.PreferencesBox_Click);
            // 
            // issueToolStripMenuItem
            // 
            this.issueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.recordToolStripMenuItem,
            this.modifyToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.issueToolStripMenuItem.Name = "issueToolStripMenuItem";
            this.issueToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.issueToolStripMenuItem.Text = "Issue";
            // 
            // requirementToolStripMenuItem
            // 
            this.requirementToolStripMenuItem.Name = "requirementToolStripMenuItem";
            this.requirementToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.requirementToolStripMenuItem.Text = "Requirement";
            // 
            // designToolStripMenuItem
            // 
            this.designToolStripMenuItem.Name = "designToolStripMenuItem";
            this.designToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.designToolStripMenuItem.Text = "Design";
            // 
            // textToolStripMenuItem
            // 
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            this.textToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.textToolStripMenuItem.Text = "Text";
            // 
            // selectProjectToolStripMenuItem
            // 
            this.selectProjectToolStripMenuItem.Name = "selectProjectToolStripMenuItem";
            this.selectProjectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.selectProjectToolStripMenuItem.Text = "Select Project";
            this.selectProjectToolStripMenuItem.Click += new System.EventHandler(this.selectProjectToolStripMenuItem_Click);
            // 
            // createProjectToolStripMenuItem
            // 
            this.createProjectToolStripMenuItem.Name = "createProjectToolStripMenuItem";
            this.createProjectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createProjectToolStripMenuItem.Text = "Create Project";
            // 
            // modifyProjectToolStripMenuItem
            // 
            this.modifyProjectToolStripMenuItem.Name = "modifyProjectToolStripMenuItem";
            this.modifyProjectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modifyProjectToolStripMenuItem.Text = "Modify Project";
            // 
            // removeProjectToolStripMenuItem
            // 
            this.removeProjectToolStripMenuItem.Name = "removeProjectToolStripMenuItem";
            this.removeProjectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeProjectToolStripMenuItem.Text = "Remove Project";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // recordToolStripMenuItem
            // 
            this.recordToolStripMenuItem.Name = "recordToolStripMenuItem";
            this.recordToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.recordToolStripMenuItem.Text = "Record";
            this.recordToolStripMenuItem.Click += new System.EventHandler(this.recordToolStripMenuItem_Click);
            // 
            // modifyToolStripMenuItem
            // 
            this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            this.modifyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modifyToolStripMenuItem.Text = "Modify";
            this.modifyToolStripMenuItem.Click += new System.EventHandler(this.modifyToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.countByAssigneeToolStripMenuItem,
            this.listByAssigneeToolStripMenuItem,
            this.countByArtifactToolStripMenuItem,
            this.listByArtifactToolStripMenuItem,
            this.countByDateRangeToolStripMenuItem,
            this.listByDateRangeToolStripMenuItem,
            this.trendByDateRangeToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reportToolStripMenuItem.Text = "Report";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // countByAssigneeToolStripMenuItem
            // 
            this.countByAssigneeToolStripMenuItem.Name = "countByAssigneeToolStripMenuItem";
            this.countByAssigneeToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.countByAssigneeToolStripMenuItem.Text = "Count by Assignee";
            this.countByAssigneeToolStripMenuItem.Click += new System.EventHandler(this.countByAssigneeToolStripMenuItem_Click);
            // 
            // listByAssigneeToolStripMenuItem
            // 
            this.listByAssigneeToolStripMenuItem.Name = "listByAssigneeToolStripMenuItem";
            this.listByAssigneeToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.listByAssigneeToolStripMenuItem.Text = "List by Assignee";
            this.listByAssigneeToolStripMenuItem.Click += new System.EventHandler(this.listByAssigneeToolStripMenuItem_Click);
            // 
            // countByArtifactToolStripMenuItem
            // 
            this.countByArtifactToolStripMenuItem.Name = "countByArtifactToolStripMenuItem";
            this.countByArtifactToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.countByArtifactToolStripMenuItem.Text = "Count by Artifact";
            this.countByArtifactToolStripMenuItem.Click += new System.EventHandler(this.countByArtifactToolStripMenuItem_Click);
            // 
            // listByArtifactToolStripMenuItem
            // 
            this.listByArtifactToolStripMenuItem.Name = "listByArtifactToolStripMenuItem";
            this.listByArtifactToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.listByArtifactToolStripMenuItem.Text = "List by Artifact";
            this.listByArtifactToolStripMenuItem.Click += new System.EventHandler(this.listByArtifactToolStripMenuItem_Click);
            // 
            // countByDateRangeToolStripMenuItem
            // 
            this.countByDateRangeToolStripMenuItem.Name = "countByDateRangeToolStripMenuItem";
            this.countByDateRangeToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.countByDateRangeToolStripMenuItem.Text = "Count by Date Range";
            this.countByDateRangeToolStripMenuItem.Click += new System.EventHandler(this.countByDateRangeToolStripMenuItem_Click);
            // 
            // listByDateRangeToolStripMenuItem
            // 
            this.listByDateRangeToolStripMenuItem.Name = "listByDateRangeToolStripMenuItem";
            this.listByDateRangeToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.listByDateRangeToolStripMenuItem.Text = "List by Date Range";
            this.listByDateRangeToolStripMenuItem.Click += new System.EventHandler(this.listByDateRangeToolStripMenuItem_Click);
            // 
            // trendByDateRangeToolStripMenuItem
            // 
            this.trendByDateRangeToolStripMenuItem.Name = "trendByDateRangeToolStripMenuItem";
            this.trendByDateRangeToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.trendByDateRangeToolStripMenuItem.Text = "Trend by Date Range";
            this.trendByDateRangeToolStripMenuItem.Click += new System.EventHandler(this.trendByDateRangeToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem PreferencesBox;
        private System.Windows.Forms.ToolStripMenuItem selectProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countByAssigneeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listByAssigneeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countByArtifactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listByArtifactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countByDateRangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listByDateRangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trendByDateRangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requirementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem designToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem;
    }
}