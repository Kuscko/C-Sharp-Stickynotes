
namespace C_Sharp_Stickynotes.Presentation
{
    partial class ucStickyNoteView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelNoteView = new System.Windows.Forms.Panel();
            this.rtbNoteText = new System.Windows.Forms.RichTextBox();
            this.btnDeleteNote = new System.Windows.Forms.Button();
            this.panelNoteView.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNoteView
            // 
            this.panelNoteView.AutoSize = true;
            this.panelNoteView.Controls.Add(this.rtbNoteText);
            this.panelNoteView.Controls.Add(this.btnDeleteNote);
            this.panelNoteView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNoteView.Location = new System.Drawing.Point(0, 0);
            this.panelNoteView.Name = "panelNoteView";
            this.panelNoteView.Size = new System.Drawing.Size(452, 115);
            this.panelNoteView.TabIndex = 2;
            this.panelNoteView.Click += new System.EventHandler(this.panelNoteView_Click);
            // 
            // rtbNoteText
            // 
            this.rtbNoteText.BackColor = System.Drawing.Color.Yellow;
            this.rtbNoteText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbNoteText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtbNoteText.Location = new System.Drawing.Point(0, 15);
            this.rtbNoteText.Name = "rtbNoteText";
            this.rtbNoteText.ReadOnly = true;
            this.rtbNoteText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbNoteText.Size = new System.Drawing.Size(426, 100);
            this.rtbNoteText.TabIndex = 3;
            this.rtbNoteText.TabStop = false;
            this.rtbNoteText.Text = "";
            this.rtbNoteText.Click += new System.EventHandler(this.panelNoteView_Click);
            // 
            // btnDeleteNote
            // 
            this.btnDeleteNote.AutoSize = true;
            this.btnDeleteNote.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteNote.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDeleteNote.FlatAppearance.BorderSize = 0;
            this.btnDeleteNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteNote.Location = new System.Drawing.Point(426, 0);
            this.btnDeleteNote.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeleteNote.Name = "btnDeleteNote";
            this.btnDeleteNote.Size = new System.Drawing.Size(26, 115);
            this.btnDeleteNote.TabIndex = 2;
            this.btnDeleteNote.Text = "X";
            this.btnDeleteNote.UseVisualStyleBackColor = false;
            this.btnDeleteNote.Click += new System.EventHandler(this.btnDeleteNote_Click);
            // 
            // ucStickyNoteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.Controls.Add(this.panelNoteView);
            this.Name = "ucStickyNoteView";
            this.Size = new System.Drawing.Size(452, 115);
            this.Load += new System.EventHandler(this.ucStickyNoteView_Load);
            this.panelNoteView.ResumeLayout(false);
            this.panelNoteView.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelNoteView;
        private System.Windows.Forms.RichTextBox rtbNoteText;
        private System.Windows.Forms.Button btnDeleteNote;
    }
}
