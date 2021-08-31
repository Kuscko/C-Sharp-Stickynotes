namespace StickyNotesLibrary
{
    public class StickyNoteModel
    {
        // encapsulated
        private int noteID;
        private string noteText;
        private int noteColor;
        public int NoteID { get { return noteID; } set { noteID = value;} }
        public string NoteText { get { return noteText; } set { noteText = value; } }
        public int NoteColor { get { return noteColor; } set { noteColor = value; } }
    }
}
