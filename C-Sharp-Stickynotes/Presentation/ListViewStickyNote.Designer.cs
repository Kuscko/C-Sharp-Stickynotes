
namespace C_Sharp_Stickynotes.Presentation
{
    partial class ListViewStickyNote
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
            this.StickyNote_ = new System.Windows.Forms.Panel();
            this.rtbNoteText = new System.Windows.Forms.RichTextBox();
            this.btnDeleteNote = new System.Windows.Forms.Button();
            this.StickyNote_.SuspendLayout();
            this.SuspendLayout();
            // 
            // StickyNote_
            // 
            this.StickyNote_.BackColor = System.Drawing.Color.Yellow;
            this.StickyNote_.Controls.Add(this.rtbNoteText);
            this.StickyNote_.Controls.Add(this.btnDeleteNote);
            this.StickyNote_.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StickyNote_.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StickyNote_.Location = new System.Drawing.Point(0, 0);
            this.StickyNote_.Margin = new System.Windows.Forms.Padding(0);
            this.StickyNote_.MinimumSize = new System.Drawing.Size(560, 92);
            this.StickyNote_.Name = "StickyNote_";
            this.StickyNote_.Size = new System.Drawing.Size(560, 92);
            this.StickyNote_.TabIndex = 3;
            // 
            // rtbNoteText
            // 
            this.rtbNoteText.BackColor = System.Drawing.Color.Yellow;
            this.rtbNoteText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbNoteText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtbNoteText.Location = new System.Drawing.Point(0, 25);
            this.rtbNoteText.Margin = new System.Windows.Forms.Padding(0);
            this.rtbNoteText.MinimumSize = new System.Drawing.Size(560, 67);
            this.rtbNoteText.Name = "rtbNoteText";
            this.rtbNoteText.Size = new System.Drawing.Size(560, 67);
            this.rtbNoteText.TabIndex = 2;
            this.rtbNoteText.Text = "";
            // 
            // btnDeleteNote
            // 
            this.btnDeleteNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteNote.AutoSize = true;
            this.btnDeleteNote.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteNote.FlatAppearance.BorderSize = 0;
            this.btnDeleteNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteNote.Location = new System.Drawing.Point(523, 0);
            this.btnDeleteNote.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeleteNote.Name = "btnDeleteNote";
            this.btnDeleteNote.Size = new System.Drawing.Size(37, 27);
            this.btnDeleteNote.TabIndex = 1;
            this.btnDeleteNote.TabStop = false;
            this.btnDeleteNote.Text = "X";
            this.btnDeleteNote.UseVisualStyleBackColor = false;
            // 
            // ListViewStickyNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StickyNote_);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ListViewStickyNote";
            this.Size = new System.Drawing.Size(560, 92);
            this.Load += new System.EventHandler(this.ListViewStickyNote_Load);
            this.Click += new System.EventHandler(this.ListViewStickyNote_Load);
            this.StickyNote_.ResumeLayout(false);
            this.StickyNote_.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel StickyNote_;
        private System.Windows.Forms.RichTextBox rtbNoteText;
        private System.Windows.Forms.Button btnDeleteNote;
    }
}
