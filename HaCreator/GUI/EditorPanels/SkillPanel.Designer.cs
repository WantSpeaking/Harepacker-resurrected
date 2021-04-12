using HaCreator.CustomControls;

namespace HaCreator.GUI.EditorPanels
{
    partial class SkillPanel
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
        private void InitializeComponent ()
        {
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.skillSetListBox = new System.Windows.Forms.ListBox();
            this.objImagesContainer = new HaCreator.CustomControls.ThumbnailTableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.skillSetListBox);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.objImagesContainer);
            this.splitContainer3.Size = new System.Drawing.Size(284, 658);
            this.splitContainer3.SplitterDistance = 189;
            this.splitContainer3.TabIndex = 2;
            // 
            // skillSetListBox
            // 
            this.skillSetListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skillSetListBox.FormattingEnabled = true;
            this.skillSetListBox.Location = new System.Drawing.Point(0, 0);
            this.skillSetListBox.Name = "skillSetListBox";
            this.skillSetListBox.Size = new System.Drawing.Size(284, 189);
            this.skillSetListBox.TabIndex = 0;
            this.skillSetListBox.SelectedIndexChanged += new System.EventHandler(this.objSetListBox_SelectedIndexChanged);
            // 
            // objImagesContainer
            // 
            this.objImagesContainer.ColumnCount = 2;
            this.objImagesContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.objImagesContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.objImagesContainer.Location = new System.Drawing.Point(0, 0);
            this.objImagesContainer.Name = "objImagesContainer";
            this.objImagesContainer.RowCount = 2;
            this.objImagesContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.objImagesContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.objImagesContainer.Size = new System.Drawing.Size(281, 462);
            this.objImagesContainer.TabIndex = 0;
            // 
            // SkillPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.splitContainer3);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Name = "SkillPanel";
            this.Size = new System.Drawing.Size(284, 658);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.ListBox skillSetListBox;
        private ThumbnailTableLayoutPanel objImagesContainer;
    }
}