using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace WindowsFormsApplicationDB
{
    class ClassDB
    {
        private static ClassDB db = null; // referinta catre unica instanta db
        private string strConexiune;

        public string CONEXIUNE
        {
            get { return this.strConexiune; }
            set { this.strConexiune = value; }
        }

        private ClassDB() 
        {
        }

        // pattern singleton pentru a da acces la unica instanta a clasei
        public static ClassDB DB
        {
            get
            {
                if (db == null)
                    db = new ClassDB();
                return db;
            }
        }

        // returneaza un obiect de tip OleDbConnection
        public System.Data.OleDb.OleDbConnection getConexiune()
        {
            if (strConexiune != null)
                return new System.Data.OleDb.OleDbConnection(strConexiune);
            else
                return null;
        }
    }
}
