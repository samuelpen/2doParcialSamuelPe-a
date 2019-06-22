using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace AppParcial.Model
{
    public class Notes
    {
        [PrimaryKey, AutoIncrement]
        public int NotesId { get; set; }
        public string Contents { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public Notes()
        {
            this.CreatedDate = DateTime.Now;
            this.ModifiedDate = DateTime.Now;
        }
    
    }
}
