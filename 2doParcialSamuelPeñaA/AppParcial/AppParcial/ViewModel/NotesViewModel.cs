using AppParcial.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppParcial.NotasViewModel
{
    class NotesViewModel
    {
        private SQLiteConnection conec;
        private static NotesViewModel instance;
        public static NotesViewModel Instance
        {
            get
            {
                if (instance == null) { throw new Exception("Falta inicializar"); }
                return instance;
            }
        }

        public static void Inicializador(String filename) 
        {
            if (filename == null) { throw new ArgumentException(); }
            if (instance != null) { instance.conec.Close(); }
            instance = new NotesViewModel(filename);
        }

        private NotesViewModel(String DbPath)
        {
            conec = new SQLiteConnection(DbPath);
            conec.CreateTable<Notes>();
        }
        public String EstadoMensaje;

        public int AddNew(string contents)
        {
            int result = 0;

            try
            {
                result = conec.Insert(new Notes()
                {
                    Contents = contents
                });
                EstadoMensaje = string.Format("Se ingresó exitosamente la Nota"); 
            }
            catch (Exception e)
            {
                EstadoMensaje = e.Message;
            }

            return result;
        }

        public IEnumerable<Notes> GetAll()
        {
            try
            {
                return conec.Table<Notes>();
            }
            catch (Exception e)
            {
                EstadoMensaje = e.Message;
            }
            return Enumerable.Empty<Notes>();
        }


    }
}
