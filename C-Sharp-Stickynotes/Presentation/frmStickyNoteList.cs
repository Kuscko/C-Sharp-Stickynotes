using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
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

        // constant Declarations, importing attributs and static int/bools for moving the sticky note
        // TODO: Move to own Class
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        // Move form that doesn't have a boarder to click and drag.
        private void frmStickyNote_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        private List<StickyNoteModel> stickyNoteModels = new List<StickyNoteModel>();


        // It isn't updated the tablelayout control, figure this out. TODO:
        private void frmStickyNoteList_Load(object sender, EventArgs e)
        {
            LoadNotes();
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

        void LoadNotes()
        {
            tblPanelStickyNoteList.RowCount = 1;
            SQLiteStickyNoteAccess sqliteStickyNoteAccess = new SQLiteStickyNoteAccess();
            stickyNoteModels = sqliteStickyNoteAccess.GetStickyNotes();
            foreach (var item in stickyNoteModels)
            {
                tblPanelStickyNoteList.RowCount++;
                tblPanelStickyNoteList.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                tblPanelStickyNoteList.Controls.Add(new ucStickyNoteView(item));
            }
        }


    }
}
