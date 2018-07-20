using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;


namespace WindowsFormsApplicationDB
{
    class ClassDB
    {
        private static ClassDB db = null; 
        private string strConexiune;

        public string CONEXIUNE
        {
            get { return this.strConexiune; }
            set { this.strConexiune = value; }
        }

        private ClassDB() 
        {
        }

        public static ClassDB DB
        {
            get
            {
                if (db == null)
                    db = new ClassDB();
                return db;
            }
        }
        
        public OleDbConnection getConexiune()
        {
            if (strConexiune != null)
                return new OleDbConnection(strConexiune);
            else
                return null;
        }
    }
}
