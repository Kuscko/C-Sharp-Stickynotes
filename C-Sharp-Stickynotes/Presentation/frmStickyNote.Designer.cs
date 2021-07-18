
namespace C_Sharp_Stickynotes.Presentation
{
    partial class frmStickyNote
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
            this.panelStickyNoteControls = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCurrentNoteSettings = new System.Windows.Forms.Button();
            this.btnNewStickynote = new System.Windows.Forms.Button();
            this.panelRichTextBox = new System.Windows.Forms.Panel();
            this.rtbNotes = new System.Windows.Forms.RichTextBox();
            this.flowNoteSettings = new System.Windows.Forms.FlowLayoutPanel();
            this.mnuStripSettingsControls = new System.Windows.Forms.MenuStrip();
            this.tStripViewNoteList = new System.Windows.Forms.ToolStripMenuItem();
            this.tStripDeleteNoteItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tStripSaveNoteItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelStickyNoteControls.SuspendLayout();
            this.panelRichTextBox.SuspendLayout();
            this.flowNoteSettings.SuspendLayout();
            this.mnuStripSettingsControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelStickyNoteControls
            // 
            this.panelStickyNoteControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelStickyNoteControls.BackColor = System.Drawing.Color.Khaki;
            this.panelStickyNoteControls.Controls.Add(this.btnClose);
            this.panelStickyNoteControls.Controls.Add(this.btnCurrentNoteSettings);
            this.panelStickyNoteControls.Controls.Add(this.btnNewStickynote);
            this.panelStickyNoteControls.Location = new System.Drawing.Point(0, 0);
            this.panelStickyNoteControls.Margin = new System.Windows.Forms.Padding(0);
            this.panelStickyNoteControls.Name = "panelStickyNoteControls";
            this.panelStickyNoteControls.Size = new System.Drawing.Size(375, 31);
            this.panelStickyNoteControls.TabIndex = 0;
            this.panelStickyNoteControls.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmStickyNote_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.AutoSize = true;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(343, 2);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCurrentNoteSettings
            // 
            this.btnCurrentNoteSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCurrentNoteSettings.AutoSize = true;
            this.btnCurrentNoteSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnCurrentNoteSettings.FlatAppearance.BorderSize = 0;
            this.btnCurrentNoteSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurrentNoteSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCurrentNoteSettings.Location = new System.Drawing.Point(313, 2);
            this.btnCurrentNoteSettings.Margin = new System.Windows.Forms.Padding(0);
            this.btnCurrentNoteSettings.Name = "btnCurrentNoteSettings";
            this.btnCurrentNoteSettings.Size = new System.Drawing.Size(30, 30);
            this.btnCurrentNoteSettings.TabIndex = 1;
            this.btnCurrentNoteSettings.Text = "=";
            this.btnCurrentNoteSettings.UseVisualStyleBackColor = false;
            this.btnCurrentNoteSettings.Click += new System.EventHandler(this.btnCurrentNoteSettings_Click);
            // 
            // btnNewStickynote
            // 
            this.btnNewStickynote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNewStickynote.AutoSize = true;
            this.btnNewStickynote.BackColor = System.Drawing.Color.Transparent;
            this.btnNewStickynote.FlatAppearance.BorderSize = 0;
            this.btnNewStickynote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewStickynote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNewStickynote.Location = new System.Drawing.Point(0, 0);
            this.btnNewStickynote.Margin = new System.Windows.Forms.Padding(0);
            this.btnNewStickynote.Name = "btnNewStickynote";
            this.btnNewStickynote.Size = new System.Drawing.Size(30, 30);
            this.btnNewStickynote.TabIndex = 0;
            this.btnNewStickynote.Text = "+";
            this.btnNewStickynote.UseVisualStyleBackColor = false;
            this.btnNewStickynote.Click += new System.EventHandler(this.btnNewStickynote_Click);
            // 
            // panelRichTextBox
            // 
            this.panelRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRichTextBox.Controls.Add(this.rtbNotes);
            this.panelRichTextBox.Location = new System.Drawing.Point(0, 32);
            this.panelRichTextBox.Name = "panelRichTextBox";
            this.panelRichTextBox.Size = new System.Drawing.Size(375, 251);
            this.panelRichTextBox.TabIndex = 1;
            // 
            // rtbNotes
            // 
            this.rtbNotes.BackColor = System.Drawing.Color.Yellow;
            this.rtbNotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbNotes.Location = new System.Drawing.Point(0, 0);
            this.rtbNotes.Name = "rtbNotes";
            this.rtbNotes.Size = new System.Drawing.Size(375, 251);
            this.rtbNotes.TabIndex = 0;
            this.rtbNotes.Text = "";
            // 
            // flowNoteSettings
            // 
            this.flowNoteSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowNoteSettings.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flowNoteSettings.Controls.Add(this.mnuStripSettingsControls);
            this.flowNoteSettings.Location = new System.Drawing.Point(0, 0);
            this.flowNoteSettings.Margin = new System.Windows.Forms.Padding(0);
            this.flowNoteSettings.Name = "flowNoteSettings";
            this.flowNoteSettings.Size = new System.Drawing.Size(375, 40);
            this.flowNoteSettings.TabIndex = 1;
            this.flowNoteSettings.Visible = false;
            this.flowNoteSettings.Leave += new System.EventHandler(this.flowNoteSettings_Leave);
            // 
            // mnuStripSettingsControls
            // 
            this.mnuStripSettingsControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mnuStripSettingsControls.AutoSize = false;
            this.mnuStripSettingsControls.Dock = System.Windows.Forms.DockStyle.None;
            this.mnuStripSettingsControls.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mnuStripSettingsControls.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tStripViewNoteList,
            this.tStripDeleteNoteItem,
            this.tStripSaveNoteItem});
            this.mnuStripSettingsControls.Location = new System.Drawing.Point(0, 0);
            this.mnuStripSettingsControls.Name = "mnuStripSettingsControls";
            this.mnuStripSettingsControls.Padding = new System.Windows.Forms.Padding(0);
            this.mnuStripSettingsControls.Size = new System.Drawing.Size(375, 40);
            this.mnuStripSettingsControls.TabIndex = 0;
            // 
            // tStripViewNoteList
            // 
            this.tStripViewNoteList.Name = "tStripViewNoteList";
            this.tStripViewNoteList.Padding = new System.Windows.Forms.Padding(0, 0, 43, 0);
            this.tStripViewNoteList.Size = new System.Drawing.Size(172, 40);
            this.tStripViewNoteList.Text = "= View Note List";
            this.tStripViewNoteList.Click += new System.EventHandler(this.tStripViewNoteList_Click);
            // 
            // tStripDeleteNoteItem
            // 
            this.tStripDeleteNoteItem.Name = "tStripDeleteNoteItem";
            this.tStripDeleteNoteItem.Padding = new System.Windows.Forms.Padding(0);
            this.tStripDeleteNoteItem.Size = new System.Drawing.Size(96, 40);
            this.tStripDeleteNoteItem.Text = "Delete Note";
            this.tStripDeleteNoteItem.Click += new System.EventHandler(this.tStripDeleteNoteItem_Click);
            // 
            // tStripSaveNoteItem
            // 
            this.tStripSaveNoteItem.Name = "tStripSaveNoteItem";
            this.tStripSaveNoteItem.Size = new System.Drawing.Size(93, 40);
            this.tStripSaveNoteItem.Text = "Save Note";
            this.tStripSaveNoteItem.Click += new System.EventHandler(this.tStripSaveNoteItem_Click);
            // 
            // frmStickyNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(375, 284);
            this.ControlBox = false;
            this.Controls.Add(this.flowNoteSettings);
            this.Controls.Add(this.panelStickyNoteControls);
            this.Controls.Add(this.panelRichTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(391, 100);
            this.Name = "frmStickyNote";
            this.Load += new System.EventHandler(this.frmStickyNote_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmStickyNote_MouseDown);
            this.panelStickyNoteControls.ResumeLayout(false);
            this.panelStickyNoteControls.PerformLayout();
            this.panelRichTextBox.ResumeLayout(false);
            this.flowNoteSettings.ResumeLayout(false);
            this.mnuStripSettingsControls.ResumeLayout(false);
            this.mnuStripSettingsControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelStickyNoteControls;
        private System.Windows.Forms.Panel panelRichTextBox;
        private System.Windows.Forms.RichTextBox rtbNotes;
        private System.Windows.Forms.FlowLayoutPanel flowNoteSettings;
        private System.Windows.Forms.MenuStrip mnuStripSettingsControls;
        private System.Windows.Forms.ToolStripMenuItem tStripViewNoteList;
        private System.Windows.Forms.ToolStripMenuItem tStripDeleteNoteItem;
        private System.Windows.Forms.Button btnNewStickynote;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCurrentNoteSettings;
        private System.Windows.Forms.ToolStripMenuItem tStripSaveNoteItem;
    }
}

