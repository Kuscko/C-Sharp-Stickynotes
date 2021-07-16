using StickyNotesLibrary;
using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace C_Sharp_Stickynotes.Presentation
{
    public partial class frmStickyNote : Form
    {
        // constant Declarations, importing attributs and static int/bools for moving the sticky note
        // TODO: Move to own Class
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

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

        // Close the Sticky Note Form
        // TODO: ON FORM CLOSE - If Richtextbox is not empty, save stickynote text and data.
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (rtbNotes.Text != "")
            {
                SQLiteStickyNoteAccess sqliteStickyNoteAccess = new SQLiteStickyNoteAccess();
                sqliteStickyNoteAccess.SaveStickyNoteAsync(rtbNotes.Text, DefaultBackColor.ToArgb()).Wait();
            }
            Close();
        }

        // Create new sticky note form object on new thread
        private void btnNewStickynote_Click(object sender, EventArgs e)
        {
            var newNote = new Thread(() => Application.Run(new frmStickyNote()));
            newNote.Start();

        }

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

        private void flowNoteSettings_Leave(object sender, EventArgs e)
        {
            flowNoteSettings.Visible = false;
        }

        private void tStripViewNoteList_Click(object sender, EventArgs e)
        {
            var newNoteList = new Thread(() => Application.Run(new frmStickyNoteList()));
            newNoteList.Start();
        }
    }
}
