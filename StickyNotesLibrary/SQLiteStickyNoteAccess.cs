using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StickyNotesLibrary
{
    public class SQLiteStickyNoteAccess
    {
        public List<StickyNoteModel> GetStickyNotes()
        {
            // use 'using' to reliable close connections to the database.
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                var note = conn.Query<StickyNoteModel>("SELECT * FROM StickyNotes");
                return note.ToList();
            }
        }

        // think whether save and update are necessary or simply one. How logic would look, update tomorrow TODO::
        public async Task SaveStickyNoteAsync(String text, int color)
        {
            string sql = "INSERT INTO StickyNotes " +
                         "(NoteText, NoteColor) " +
                         "VALUES (@noteText, @noteColor) ";
            // use 'using' to reliable close connections to the database.
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                var affectedRows = await conn.ExecuteAsync(sql, new { noteText = text, noteColor = color });
            }
        }

        public void DeleteStickyNote(string text, StickyNoteModel sticky)
        {
            // use 'using' to reliable close connections to the database.
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {

            }
        }

        public void UpdateStickyNote(StickyNoteModel sticky)
        {
            // use 'using' to reliable close connections to the database.
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {

            }
        }

        // gets the connectionstring labeled["Default"] from the App.config inside the executable 
        private static string LoadConnectionString(string id = "Default")
        {
            ConnectionStringSettings c = ConfigurationManager.ConnectionStrings[id];
            string fixedConnectionString = c.ConnectionString.Replace("{AppDir}", AppDomain.CurrentDomain.BaseDirectory);
            return fixedConnectionString;
        }
    }
}
