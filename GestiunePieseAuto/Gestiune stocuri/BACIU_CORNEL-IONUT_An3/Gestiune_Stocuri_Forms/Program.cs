using Gestiune_Stocuri_Forms;
using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestiuneStocuri
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //  Application.Run(new Gestiune_Stocuri_Forms.Logare());
            Application.Run(new Logare());      
        }
    }
}
