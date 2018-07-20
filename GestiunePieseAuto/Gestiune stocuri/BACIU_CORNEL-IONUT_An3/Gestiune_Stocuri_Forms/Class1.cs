using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestiune_Stocuri_Forms
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

          public static ClassDB DB
        {
            get
            {
                if (db == null)
                    db = new ClassDB();
                return db;
            }
        }
        public System.Data.OleDb.OleDbConnection getConexiune()
        {
            if (strConexiune != null)
                return new System.Data.OleDb.OleDbConnection(strConexiune);
            else
                return null;
        }
    }
}
