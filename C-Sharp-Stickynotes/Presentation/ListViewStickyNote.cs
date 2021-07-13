using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace C_Sharp_Stickynotes.Presentation
{
    public partial class ListViewStickyNote : UserControl
    {
        private int noteID;
        private string noteText;
        private int noteColor;

        public ListViewStickyNote()
        {
            InitializeComponent();
        }

        public ListViewStickyNote(int noteID, string noteText, int noteColor)
        {
            this.noteID = noteID;
            this.noteText = noteText;
            this.noteColor = noteColor;
        }

        private List<Control> GetAllChildControls(Control parent)
        {
            List<Control> children = new List<Control>();
            children.AddRange((IEnumerable<Control>)parent.Controls);
            foreach (Control child in parent.Controls)
            {
                children.AddRange(this.GetAllChildControls(child));
            }
            return children;
        }

        private void ListViewStickyNote_Load(object sender, EventArgs e)
        {
            Color c = Color.FromArgb(noteColor);
            List<Control> children = GetAllChildControls(StickyNote_);
            foreach (Control control in children)
            {
                switch (control)
                {
                    case RichTextBox:
                        control.Text = noteText;
                        control.BackColor = c;
                        break;
                    case Button:
                        control.BackColor = c;
                        break;
                    default:
                        break;
                }
            }

        }
    }
}
