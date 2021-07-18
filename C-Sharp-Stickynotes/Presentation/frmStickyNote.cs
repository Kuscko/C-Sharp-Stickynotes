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

        // Individual frmStickyNote Loads for saved sticky notes and new sticky notes.
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
            if (Saved != false && rtbNotes.Text != StickyNote.NoteText)
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

        // Creates new a new stickynote form on a seperate threat.
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

        // View sticky note settings
        private void tStripViewNoteList_Click(object sender, EventArgs e)
        {
            var newNoteList = new Thread(() => Application.Run(new frmStickyNoteList()));
            newNoteList.Start();
        }

        // hide settings when no longer focused.
        private void flowNoteSettings_Leave(object sender, EventArgs e)
        {
            flowNoteSettings.Visible = false;
        }

        // Deletes the this.frmStickyNote if it has been saved in the database already.
        private void tStripDeleteNoteItem_Click(object sender, EventArgs e) { 
            DialogResult dialogConfirmation = MessageBox.Show("Are you sure you want to delete this sticky note?", "Delete Confirmation", 
                                                               MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            
            switch (dialogConfirmation)
            {
                case DialogResult.Yes:
                    Delete();
                    break;
                default:
                    break;
            }
        }


        // Saves the this.frmStickyNote.
        private void tStripSaveNoteItem_Click(object sender, EventArgs e) 
        {
            if (Saved != false && rtbNotes.Text != StickyNote.NoteText)
            {
                Update();
            }
            else if (Saved == false && rtbNotes.Text != "")
            {

                Save();
            }
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

        // Deletes Sticky Note if it has been saved in the database already.
        void Delete()
        {
            if (Saved != false)
            {
                SQLiteStickyNoteAccess sqliteStickyNoteAccess = new SQLiteStickyNoteAccess();
                sqliteStickyNoteAccess.DeleteStickyNote(StickyNote.NoteID).Wait();
            }
        }

        // Updates the Sticky note whenever the sticky note is closed or the save button is pressed.
        new void Update()
        {
            if(rtbNotes.Text != "")
            {
                SQLiteStickyNoteAccess sqliteStickyNOteAccess = new SQLiteStickyNoteAccess();
                sqliteStickyNOteAccess.UpdateStickyNote(rtbNotes.Text, this.BackColor.ToArgb(), StickyNote.NoteID).Wait();
            }
        }

        // If the Stickynote is located in the SQLite database then the sticky note text is popluated and arguments are assigned.
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
