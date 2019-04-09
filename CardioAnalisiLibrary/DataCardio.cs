using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardioAnalisiLibrary
{
    public class DataCardio
    {
        public static void FrequenzaCardiaca(string msg, ref double fMax, ref double fMaxA, ref double fMinA)
        {
            fMaxA = fMax * 0.9; //Calcolo la frequenza cardiaca massima per un buon allenamento
            fMinA = fMax * 0.7; //Calcolo la frequenza cardiaca minima per un buon allenamento
        }
    }
}
