namespace C_Sharp_Stickynotes.Presentation
{
    partial class frmStickyNoteList
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
            this.panelStickyNoteList = new System.Windows.Forms.Panel();
            this.tblPanelStickyNoteList = new System.Windows.Forms.TableLayoutPanel();
            this.panelStickyNoteControls.SuspendLayout();
            this.panelStickyNoteList.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelStickyNoteControls
            // 
            this.panelStickyNoteControls.BackColor = System.Drawing.Color.LightGray;
            this.panelStickyNoteControls.Controls.Add(this.btnClose);
            this.panelStickyNoteControls.Controls.Add(this.btnCurrentNoteSettings);
            this.panelStickyNoteControls.Controls.Add(this.btnNewStickynote);
            this.panelStickyNoteControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStickyNoteControls.Location = new System.Drawing.Point(0, 0);
            this.panelStickyNoteControls.Margin = new System.Windows.Forms.Padding(0);
            this.panelStickyNoteControls.Name = "panelStickyNoteControls";
            this.panelStickyNoteControls.Size = new System.Drawing.Size(559, 36);
            this.panelStickyNoteControls.TabIndex = 1;
            this.panelStickyNoteControls.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmStickyNoteList_MouseDown);
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
            this.btnClose.Location = new System.Drawing.Point(524, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 35);
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
            this.btnCurrentNoteSettings.Location = new System.Drawing.Point(482, 0);
            this.btnCurrentNoteSettings.Margin = new System.Windows.Forms.Padding(0);
            this.btnCurrentNoteSettings.Name = "btnCurrentNoteSettings";
            this.btnCurrentNoteSettings.Size = new System.Drawing.Size(35, 35);
            this.btnCurrentNoteSettings.TabIndex = 1;
            this.btnCurrentNoteSettings.Text = "=";
            this.btnCurrentNoteSettings.UseVisualStyleBackColor = false;
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
            this.btnNewStickynote.Size = new System.Drawing.Size(35, 35);
            this.btnNewStickynote.TabIndex = 0;
            this.btnNewStickynote.Text = "+";
            this.btnNewStickynote.UseVisualStyleBackColor = false;
            this.btnNewStickynote.Click += new System.EventHandler(this.BtnNewStickynote_Click);
            // 
            // panelStickyNoteList
            // 
            this.panelStickyNoteList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelStickyNoteList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelStickyNoteList.Controls.Add(this.tblPanelStickyNoteList);
            this.panelStickyNoteList.Location = new System.Drawing.Point(0, 37);
            this.panelStickyNoteList.Margin = new System.Windows.Forms.Padding(0);
            this.panelStickyNoteList.Name = "panelStickyNoteList";
            this.panelStickyNoteList.Size = new System.Drawing.Size(560, 477);
            this.panelStickyNoteList.TabIndex = 2;
            // 
            // tblPanelStickyNoteList
            // 
            this.tblPanelStickyNoteList.AutoScroll = true;
            this.tblPanelStickyNoteList.ColumnCount = 1;
            this.tblPanelStickyNoteList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPanelStickyNoteList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPanelStickyNoteList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tblPanelStickyNoteList.Location = new System.Drawing.Point(0, 0);
            this.tblPanelStickyNoteList.Margin = new System.Windows.Forms.Padding(0);
            this.tblPanelStickyNoteList.Name = "tblPanelStickyNoteList";
            this.tblPanelStickyNoteList.RowCount = 1;
            this.tblPanelStickyNoteList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPanelStickyNoteList.Size = new System.Drawing.Size(560, 477);
            this.tblPanelStickyNoteList.TabIndex = 3;
            this.tblPanelStickyNoteList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmStickyNoteList_MouseDown);
            // 
            // frmStickyNoteList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 512);
            this.ControlBox = false;
            this.Controls.Add(this.panelStickyNoteList);
            this.Controls.Add(this.panelStickyNoteControls);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmStickyNoteList";
            this.Load += new System.EventHandler(this.frmStickyNoteList_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmStickyNoteList_MouseDown);
            this.panelStickyNoteControls.ResumeLayout(false);
            this.panelStickyNoteControls.PerformLayout();
            this.panelStickyNoteList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelStickyNoteControls;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCurrentNoteSettings;
        private System.Windows.Forms.Button btnNewStickynote;
        private System.Windows.Forms.Panel panelStickyNoteList;
        public System.Windows.Forms.TableLayoutPanel tblPanelStickyNoteList;
    }
}