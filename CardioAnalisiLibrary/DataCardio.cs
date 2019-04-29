using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardioAnalisiLibrary
{
    public class DataCardio
    {
        //Metodo per calcolare le frequenze massime e quella minima del cliente:
        public static void FrequenzaCardiaca(double x, ref double fMax, ref double fMaxA, ref double fMinA)
        {
            fMax = 220 - x; //Calcolo la frequenza massima

            fMaxA = fMax * 0.9; //Calcolo la frequenza cardiaca massima per un buon allenamento
            fMinA = fMax * 0.7; //Calcolo la frequenza cardiaca minima per un buon allenamento
        }

        //Metodo per dichiarare il tipo di frequenza del cliente:
        public static void TipoFrequenza(double frequenzaRiposo, ref string tipoF)
        {
            //Verifico se la frequenza è di tipo tachicardica
            if (frequenzaRiposo > 100)
            {
                tipoF = "Tachicardia";
            }
            //Verifico se la frequenza è di tipo bradicardica
            else if (Convert.ToInt32(frequenzaRiposo) < 60)
            {
                tipoF = "Bradicardia";
            }
            //Verifico se la frequenza è normale
            else
            {
                tipoF = "Normale";
            }
        }

        //Metodo per calcolare quante calorie ha bruciato il cliente, in un allenamento:
        public static void CalcoloCalorieBruciate(string sesso, ref double C, double F, double P, double A, double T)
        {
            //Se il sesso del cliente è maschio, allora utilizzo una certa formula:
            if (sesso == "uomo")
            {
                C = ((A * 0.2017) + (P * 0.199) + (F * 0.6309) - 55.0969) * (T / 4.184);
            }
            //Se il sesso del cliente è donna, allora utilizzo una certa formula:
            if (sesso == "donna")
            {
                C = ((A * 0.074) - (P * 0.126) + (F * 0.4472) - 20.4022) * (T / 4.184);
            }
        }

        //Metodo per calcolare le calorie bruciate dopo aver svolto una determinata azione
        public static void CalcoloCalorieSpese (ref double spesaEnergeticaCorsa, ref double spesaEnergeticaCamminata, double kmPercorsi, double P)
        {
            spesaEnergeticaCorsa = 0.9 * kmPercorsi * P;

            spesaEnergeticaCamminata = 0.5 * kmPercorsi * P;
        }

        //Metodo che permette di calcolare la "frequenza cardiaca media", il "battito cardiaco a riposo", la "variabilità del battito cardiaco" e l'ordine crescente dei battiti durante la giornata
        public static void MultiFunzione(ref string msg, ref double[] frequenzeGiornaliere, ref double mGiornaliera, double frequenzaB, ref string variabilità)
        {
            double somma = 0;                    //Variabile che utilizzeremo per sommare i valori delle frequenze giornaliere per poi farne la media
            int cErrori = 0;                     //Variabile che ci servirà per contare gli errori trovati
            int n = frequenzeGiornaliere.Length; //Variabile che conterrà il valore pari al numero di elementi contenuti nell'Array "frequenzeGiornaliere"

            foreach (double i in frequenzeGiornaliere)
            {
                if (n>0)
                {
                    somma = somma + n;
                }
                else if (n<0 || n==0)
                {
                    msg = "Attenzione!! Sono stati inseriti valori negativi o uguali a 0: REINSERIRLI.";
                    cErrori++;
                }
            }

            if (cErrori==0)
            {
                mGiornaliera = somma / frequenzeGiornaliere.Length;
            }

            if (frequenzaB>0)
            {
                if (frequenzaB >= 0.0033 && frequenzaB < 0.03)
                {
                    variabilità = "VLF"; //"Very Low Frequency"
                }
                else if (frequenzaB >= 0.03 && frequenzaB < 0.15)
                {
                    variabilità = "LF"; //"Low Frequency"
                }
                else if (frequenzaB >= 0.15 && frequenzaB < 0.40)
                {
                    variabilità = "HF"; //"High Frequency"
                }
            }
            else
            {
                msg += " Attenzione!! Il valore inserito è negativo o uguale a 0: REINSERIRLO.";
            }

            //Ordino il vettore dei numeri con il metodo "Selection Sort"

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (frequenzeGiornaliere[j] < frequenzeGiornaliere[i])
                    {
                        double temp = frequenzeGiornaliere[i];
                        frequenzeGiornaliere[i] = frequenzeGiornaliere[j];
                        frequenzeGiornaliere[j] = temp;
                    }
                }
            }
        }

        public static void TipoDiPeso(ref string msg, double P, string altezza, ref string tipoPeso)
        {
            if (P > 0 && Convert.ToDouble(altezza) > 0)
            {
                if (Convert.ToDouble(altezza.Substring(2, 2)) > P)
                {
                    tipoPeso = "Sovrappeso";
                }
                else if (Convert.ToDouble(altezza.Substring(2, 2)) < P)
                {
                    tipoPeso = "Sottopeso";
                }
                else
                {
                    tipoPeso = "In linea";
                }
            }
            else
            {
                msg = "Attenzione!! I valori non sono stati inseriti correttamente: REINSERIRLI.";
            }
        }
    }
}