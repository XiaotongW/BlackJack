using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Partie
{
   class BlackJack
   {
      static void Main(string[] args)
      {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
			NetClient Client = new NetClient();
			Application.Run(mainForm: new MenuPartie());
			
      }
   }
}
