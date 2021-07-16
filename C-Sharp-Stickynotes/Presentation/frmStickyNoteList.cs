using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using StickyNotesLibrary;

namespace C_Sharp_Stickynotes.Presentation
{
    public partial class frmStickyNoteList : Form
    {
        public frmStickyNoteList()
        {
            InitializeComponent();
        }

        private List<StickyNoteModel> stickyNoteModels = new List<StickyNoteModel>();


        // It isn't updated the tablelayout control, figure this out. TODO:
        private void frmStickyNoteList_Load(object sender, EventArgs e)
        {
            SQLiteStickyNoteAccess sqliteStickyNoteAccess = new SQLiteStickyNoteAccess();
            stickyNoteModels = sqliteStickyNoteAccess.GetStickyNotes();
            foreach (var v in stickyNoteModels)
            {
                tblPanelStickyNoteList.RowCount++;
                tblPanelStickyNoteList.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
                //tblPanelStickyNoteList.Controls.Add(new ListViewStickyNote(stickyNoteModels[i].NoteID, stickyNoteModels[i].NoteText, stickyNoteModels[i].NoteColor), 0, tblPanelStickyNoteList.RowCount--);
                tblPanelStickyNoteList.Controls.Add(new ListViewStickyNote() { Text = v.NoteText, BackColor = Color.FromArgb(v.NoteColor) });
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNewStickynote_Click(object sender, EventArgs e)
        {
            var newNote = new Thread(() => Application.Run(new frmStickyNote()));
            newNote.Start();
        }

        
    }
}
