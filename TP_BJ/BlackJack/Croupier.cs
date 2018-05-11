using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
   public class Croupier
   {
        public bool RecevoirValCartes(int valCartes)
        {
            if (valCartes >= 18)
            {
                return false; // Le croupier Stand
            }
            else {
                return true; // Le croupier hit
            }
        }

        //Assembly CroupierAssembly = Assembly.LoadForm(@"../../Croupier.dll");
        //Type myType = CroupierAssembly.GetTypes()[0];
        //MethodInfo Method = myType.GetMethod("RecevoirValCartes");
        //objet myInstance = Activator.CreateInstance(myType);
        //object[] parametersArry = new object[] { valeur };
        //bool Hit = (bool)(Method.Invoke(myInstance, parametersArray));
   }
}
