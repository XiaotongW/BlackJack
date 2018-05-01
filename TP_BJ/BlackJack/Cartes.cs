using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie
{
   public class Cartes
   {
      string sorte;
      int type;
      int valeur;
      public Cartes(string sorte, int type)
      {
         this.sorte = sorte;
         this.type = type;
         valeur = calcValeur();
      }

      public string imgCarte
      {
         get { return string.Format("{0}_{1}", type, sorte); }
      }

      public int Valeur
      {
         get { return valeur; }
      }

      public static int operator +(Cartes carte1, Cartes carte2)
      {
         return (carte1.valeur + carte2.valeur);
      }

      public static int operator -(Cartes carte1, Cartes carte2)
      {
         return (carte1.valeur - carte2.valeur);
      }

      private int calcValeur()
      {
         // Retourne la valeur de la carte selons sont type
         if (type > 10)
         {
            return 10;
         }
         else if (type == 1)
         {
            return 11;
         }
         return type;
      }
   }
}
