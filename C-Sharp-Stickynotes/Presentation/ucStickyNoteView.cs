using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp_Stickynotes.Presentation
{
    public partial class ucStickyNoteView : UserControl
    {
        private StickyNotesLibrary.StickyNoteModel Item;
        public ucStickyNoteView(StickyNotesLibrary.StickyNoteModel item)
        {
            Item = item;
            InitializeComponent();
        }

        private List<Control> GetAllChildControls(Control parent)
        {
            List<Control> children = new List<Control>();
            children.AddRange(parent.Controls.Cast<Control>());
            foreach (Control child in parent.Controls)
            {
                children.AddRange(this.GetAllChildControls(child));
            }
            return children;
        }

        private void ucStickyNoteView_Load(object sender, EventArgs e)
        {
            Color c = Color.FromArgb(Item.NoteColor);
            List<Control> children = GetAllChildControls(btnDeleteNote.Parent);
            foreach (Control control in children)
            {
                switch (control)
                {
                    case RichTextBox:
                        control.Text = Item.NoteText;
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
      


        /*
            TODO: Initialization and creating new objects for each row works. however
         */
        /*private void ListViewStickyNote_Load(object sender, EventArgs e)
        {
            Color c = Color.FromArgb(noteColor);
            List<Control> children = GetAllChildControls(StickyNote_);
            foreach (Control control in children)
            {
                switch (control)
                {
                    case RichTextBox:
                        control.Text = noteText;
                        //control.BackColor = c;
                        break;
                    case Button:
                        //control.BackColor = c;
                        break;
                    default:
                        break;
                }
            }
        }*/
    }
}
