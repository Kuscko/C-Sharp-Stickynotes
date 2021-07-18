using StickyNotesLibrary;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace C_Sharp_Stickynotes.Presentation
{
    public partial class frmStickyNote : Form
    {
        // private declarations for StickyNoteModel holding this note's saved info, and if it's saved from NoteList form.
        private StickyNoteModel StickyNote;
        private bool Saved = false;

        // private declarationis for sticky note text
        private int ID;
        private string NoteText;
        private Color ColorCode;

        // constant Declarations, importing attributs and static int/bools for moving the sticky note
        // TODO: Move to own Class
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public frmStickyNote(StickyNoteModel stickyNote, bool saved = false)
        {
            StickyNote = stickyNote;
            Saved = saved;
            InitializeComponent();
        }

        public frmStickyNote()
        {
            InitializeComponent();
        }

        // Move Sticky Note form that doesn't have a boarder to click and drag.
        private void frmStickyNote_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        // Save sticky note if rich text box is not empty on close.
        private void btnClose_Click(object sender, EventArgs e)
        {
            if(Saved != false && rtbNotes.Text != StickyNote.NoteText)
            {
                Update();
                Close();
            }
            else if(Saved == false && rtbNotes.Text != "")
            {
                Save();
                Close();
            }
            else
            {
                Close();
            }
            
        }

        // Create new sticky note form object on new thread
        private void btnNewStickynote_Click(object sender, EventArgs e)
        {
            var newNote = new Thread(() => Application.Run(new frmStickyNote()));
            newNote.Start();

        }

        // View Settings for sticky note(s)
        private void btnCurrentNoteSettings_Click(object sender, EventArgs e)
        {
            switch (flowNoteSettings.Visible)
            {
                case false:
                    flowNoteSettings.Visible = true;
                    flowNoteSettings.Focus();
                    break;
                default:
                    break;
            }
        }

        // hide settings when no longer focused.
        private void flowNoteSettings_Leave(object sender, EventArgs e)
        {
            flowNoteSettings.Visible = false;
        }

        // View sticky note settings
        private void tStripViewNoteList_Click(object sender, EventArgs e)
        {
            var newNoteList = new Thread(() => Application.Run(new frmStickyNoteList()));
            newNoteList.Start();
        }

        private void tStripDeleteNoteItem_Click(object sender, EventArgs e)
        {
            if (Saved != false) {
                SQLiteStickyNoteAccess sqliteStickyNoteAccess = new SQLiteStickyNoteAccess();
                sqliteStickyNoteAccess.DeleteStickyNote(StickyNote.NoteID);
            }
        }

        private void tStripSaveNoteItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        // Save sticky note if rich text box is not empty on close.
        void Save()
        {
            if (rtbNotes.Text != "")
            {
                SQLiteStickyNoteAccess sqliteStickyNoteAccess = new SQLiteStickyNoteAccess();
                sqliteStickyNoteAccess.SaveStickyNoteAsync(rtbNotes.Text, this.BackColor.ToArgb()).Wait();
            }
        }

        new void Update()
        {
            if(rtbNotes.Text != "")
            {
                SQLiteStickyNoteAccess sqliteStickyNOteAccess = new SQLiteStickyNoteAccess();
                sqliteStickyNOteAccess.UpdateStickyNote(rtbNotes.Text, this.BackColor.ToArgb(), StickyNote.NoteID);
            }
        }

        private void frmStickyNote_Load(object sender, EventArgs e)
        {
            if(Saved != false)
            {
                ID = StickyNote.NoteID;
                ColorCode = Color.FromArgb(StickyNote.NoteColor);
                NoteText = StickyNote.NoteText;
                rtbNotes.Text = NoteText;
                rtbNotes.BackColor = ColorCode;
                this.BackColor = ColorCode;
            }
        }
    }
}
