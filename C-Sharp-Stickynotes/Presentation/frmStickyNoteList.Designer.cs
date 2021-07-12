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
            this.panelStickyNoteControls.Size = new System.Drawing.Size(479, 31);
            this.panelStickyNoteControls.TabIndex = 1;
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
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(449, 0);
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
            this.btnCurrentNoteSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurrentNoteSettings.Location = new System.Drawing.Point(413, 0);
            this.btnCurrentNoteSettings.Margin = new System.Windows.Forms.Padding(0);
            this.btnCurrentNoteSettings.Name = "btnCurrentNoteSettings";
            this.btnCurrentNoteSettings.Size = new System.Drawing.Size(30, 30);
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
            this.btnNewStickynote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewStickynote.Location = new System.Drawing.Point(0, 0);
            this.btnNewStickynote.Margin = new System.Windows.Forms.Padding(0);
            this.btnNewStickynote.Name = "btnNewStickynote";
            this.btnNewStickynote.Size = new System.Drawing.Size(30, 30);
            this.btnNewStickynote.TabIndex = 0;
            this.btnNewStickynote.Text = "+";
            this.btnNewStickynote.UseVisualStyleBackColor = false;
            this.btnNewStickynote.Click += new System.EventHandler(this.btnNewStickynote_Click);
            // 
            // panelStickyNoteList
            // 
            this.panelStickyNoteList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelStickyNoteList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelStickyNoteList.Controls.Add(this.tblPanelStickyNoteList);
            this.panelStickyNoteList.Location = new System.Drawing.Point(0, 32);
            this.panelStickyNoteList.Margin = new System.Windows.Forms.Padding(0);
            this.panelStickyNoteList.Name = "panelStickyNoteList";
            this.panelStickyNoteList.Size = new System.Drawing.Size(480, 413);
            this.panelStickyNoteList.TabIndex = 2;
            // 
            // tblPanelStickyNoteList
            // 
            this.tblPanelStickyNoteList.ColumnCount = 1;
            this.tblPanelStickyNoteList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPanelStickyNoteList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPanelStickyNoteList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblPanelStickyNoteList.Location = new System.Drawing.Point(0, 0);
            this.tblPanelStickyNoteList.Margin = new System.Windows.Forms.Padding(0);
            this.tblPanelStickyNoteList.Name = "tblPanelStickyNoteList";
            this.tblPanelStickyNoteList.RowCount = 1;
            this.tblPanelStickyNoteList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tblPanelStickyNoteList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblPanelStickyNoteList.Size = new System.Drawing.Size(480, 413);
            this.tblPanelStickyNoteList.TabIndex = 3;
            // 
            // frmStickyNoteList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 444);
            this.ControlBox = false;
            this.Controls.Add(this.panelStickyNoteList);
            this.Controls.Add(this.panelStickyNoteControls);
            this.Name = "frmStickyNoteList";
            this.Load += new System.EventHandler(this.frmStickyNoteList_Load);
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
        private System.Windows.Forms.TableLayoutPanel tblPanelStickyNoteList;
    }
}