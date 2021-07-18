using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using StickyNotesLibrary;
using C_Sharp_Stickynotes.Presentation;

namespace C_Sharp_Stickynotes.Presentation
{
    public partial class frmStickyNoteList : Form
    {
        public frmStickyNoteList()
        {
            InitializeComponent();
        }

        private List<StickyNoteModel> stickyNoteModels = new List<StickyNoteModel>();

        // constant Declarations, importing attributs and static int/bools for moving the sticky note
        // TODO: Move to own Class
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        // Move form that doesn't have a boarder to click and drag.
        private void frmStickyNoteList_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        // Loads existing sticky notes from the local sqlite database.
        private void frmStickyNoteList_Load(object sender, EventArgs e) => LoadNotes();

        // Closes the form
        private void btnClose_Click(object sender, EventArgs e) => Close();

        // Creates new a new stickynote form on a seperate threat.
        private void BtnNewStickynote_Click(object sender, EventArgs e)
        {
            var newNote = new Thread(() => Application.Run(new frmStickyNote()));
            newNote.Start();
        }

        // If the user deletes a note from the list, the list updates using Load Notes.
        internal void DeleteNoteEvent(object sender, EventArgs e)
        {
            LoadNotes();
        }

        // Clear the list of notes from the Table Layout Panel then repopulate it with existing notes.
        void LoadNotes()
        {
            tblPanelStickyNoteList.Controls.Clear();
            tblPanelStickyNoteList.RowCount = 1;
            SQLiteStickyNoteAccess sqliteStickyNoteAccess = new SQLiteStickyNoteAccess();
            stickyNoteModels = sqliteStickyNoteAccess.GetStickyNotes();
            
            foreach (var item in stickyNoteModels)
            {
                ucStickyNoteView noteView = new ucStickyNoteView(item);
                tblPanelStickyNoteList.RowCount++;
                tblPanelStickyNoteList.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                tblPanelStickyNoteList.Controls.Add(noteView);
                noteView.DeleteNote += DeleteNoteEvent;
            }
            
            
        }


    }
}
