using System;
using System.IO;

namespace LibreriaStringheTeam1
{
    public class MetodiStringhe
    {
        public static string LetturaFileSensibile()
        {
            string sensibile = File.ReadAllText("testo_s.txt");
            return sensibile;
        }
        public static string LetturaFileResistente()
        {
            string resistente = File.ReadAllText("testo_r.txt");
            return resistente;
        }
        public static int LunghezzaStringa()
        {

            string sensibile = LetturaFileSensibile();
            return sensibile.Length;
        }
        public static int ConfrontoStringhe()
        {
            string resistente = LetturaFileResistente();
            string sensibile = LetturaFileSensibile();

            int index;
            int x = Math.Min(resistente.Length, sensibile.Length);
            for (index = 0; index < x; index++)
                if (resistente[index] != sensibile[index])
                    break;
            return index;
        }
        public static string DNAidentico()
        {
            string resistente = LetturaFileResistente();
            string sensibile = LetturaFileSensibile();

            if (ConfrontoStringhe() == 0)
            {
                return "Varia il primo carattere";
            }
            else
            {
                int inizio = 0;
                int lunghezza = ConfrontoStringhe() - 1;
                string identica = resistente.Substring(inizio, lunghezza);
                return identica;
                
            }
            
        }
        public static int CaratteriDifferenti()
        {
            string resistente = LetturaFileResistente();
            string sensibile = LetturaFileSensibile();

            int index;
            int c = 0;
            int x = Math.Min(resistente.Length, sensibile.Length);
            for (index = 0; index < x; index++)
                if (resistente[index] != sensibile[index])
                    c++;
            return c;

        }
    }
}

