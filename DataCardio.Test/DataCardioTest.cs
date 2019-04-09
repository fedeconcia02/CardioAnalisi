using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataCardio.Test
{
    [TestClass]
    public class DataCardioTest
    {
        /// <summary>
        /// Test con età inserita uguale a 0
        /// </summary>
        
        [TestMethod]
        public void Frequenza_Cardiaca1()
        {
            //Inizializzo le variabili
            string x = "0";     //Variabile che conterrà l'età inserita dl cliente
            double fMax = 0;  //Variabile che conterrà il valore della frequenza massima raggiungibile dal cliente
            double fMaxA = 0; //Variabile che conterrà il valore della frequenza massima raggiungibile per un buon allenamento
            double fMinA = 0; //Variabile che conterrà il valore della frequenza minima raggiungibile per un buon allenamento
            string msg = "";    //Variabile che conterrà il messaggio da ridare all'utente in caso di dati inseriti errati

            //Faccio un ciclo "do-while" nel caso in cui desse errore, faccio reinserire il valore al cliente
            do
            {
                //x = Console.ReadLine();

                try //Realizzo un comando try/catch in modo che se fossero riscontrati dei problemi di tipo/valore, il programma non vada in crash
                {
                    fMax = 220 - Convert.ToDouble(x);

                    if (fMax >= 220) //Realizzo un controllo per prevenire l'inserimento errato dell'età in quanto a valore
                    {
                        if (fMax > 220)
                        {
                            //Console.WriteLine("ATTENZIONE!! L'età inserita è negativa: REINSERIRLA.");
                        }
                        else
                        {
                            //Console.WriteLine("ATTENZIONE!! L'età inserità è uguale a 0: REINSERIRLA.");
                        }
                    }
                }
                catch
                {
                    msg = "ATTENZIONE!! Il valore inserito NON è un numero: REINSERIRLO.";
                }
            }
            while (fMax == 0);

            CardioAnalisiLibrary.DataCardio.FrequenzaCardiaca(msg, ref fMax, ref fMaxA, ref fMinA);

            Assert.AreEqual(fMax, 220);
            Assert.AreEqual(fMaxA, 225);
            Assert.AreEqual(fMinA, 175);
        }

        /// <summary>
        /// Test con età inserita positiva
        /// </summary>
        
        [TestMethod]
        public void Frequenza_Cardiaca2()
        {
            //Inizializzo le variabili
            string x = "30";     //Variabile che conterrà l'età inserita dl cliente
            double fMax = 0;  //Variabile che conterrà il valore della frequenza massima raggiungibile dal cliente
            double fMaxA = 0; //Variabile che conterrà il valore della frequenza massima raggiungibile per un buon allenamento
            double fMinA = 0; //Variabile che conterrà il valore della frequenza minima raggiungibile per un buon allenamento
            string msg = "";    //Variabile che conterrà il messaggio da ridare all'utente in caso di dati inseriti errati

            //Faccio un ciclo "do-while" nel caso in cui desse errore, faccio reinserire il valore al cliente
            do
            {
                //x = Console.ReadLine();

                try //Realizzo un comando try/catch in modo che se fossero riscontrati dei problemi di tipo/valore, il programma non vada in crash
                {
                    fMax = 220 - Convert.ToDouble(x);

                    if (fMax >= 220) //Realizzo un controllo per prevenire l'inserimento errato dell'età in quanto a valore
                    {
                        if (fMax > 220)
                        {
                            //Console.WriteLine("ATTENZIONE!! L'età inserita è negativa: REINSERIRLA.");
                        }
                        else
                        {
                            //Console.WriteLine("ATTENZIONE!! L'età inserità è uguale a 0: REINSERIRLA.");
                        }
                    }
                }
                catch
                {
                    msg = "ATTENZIONE!! Il valore inserito NON è un numero: REINSERIRLO.";
                }
            }
            while (fMax == 0);

            CardioAnalisiLibrary.DataCardio.FrequenzaCardiaca(msg, ref fMax, ref fMaxA, ref fMinA);

            Assert.AreEqual(fMax, 220);
            Assert.AreEqual(fMaxA, 225);
            Assert.AreEqual(fMinA, 175);
        }

        /// <summary>
        /// Test con età inserita negativa
        /// </summary>
        
        [TestMethod]
        public void Frequenza_Cardiaca3()
        {
            //Inizializzo le variabili
            string x = "-30";     //Variabile che conterrà l'età inserita dl cliente
            double fMax = 0;    //Variabile che conterrà il valore della frequenza massima raggiungibile dal cliente
            double fMaxA = 0;   //Variabile che conterrà il valore della frequenza massima raggiungibile per un buon allenamento
            double fMinA = 0;   //Variabile che conterrà il valore della frequenza minima raggiungibile per un buon allenamento
            string msg = "";    //Variabile che conterrà il messaggio da ridare all'utente in caso di dati inseriti errati

            //Faccio un ciclo "do-while" nel caso in cui desse errore, faccio reinserire il valore al cliente
            do
            {
                //x = Console.ReadLine();

                try //Realizzo un comando try/catch in modo che se fossero riscontrati dei problemi di tipo/valore, il programma non vada in crash
                {
                    fMax = 220 - Convert.ToDouble(x);

                    if (fMax >= 220) //Realizzo un controllo per prevenire l'inserimento errato dell'età in quanto a valore
                    {
                        if (fMax > 220)
                        {
                            //Console.WriteLine("ATTENZIONE!! L'età inserita è negativa: REINSERIRLA.");
                        }
                        else
                        {
                            //Console.WriteLine("ATTENZIONE!! L'età inserità è uguale a 0: REINSERIRLA.");
                        }
                    }
                }
                catch
                {
                    msg = "ATTENZIONE!! Il valore inserito NON è un numero: REINSERIRLO.";
                }
            }
            while (fMax == 0);

            CardioAnalisiLibrary.DataCardio.FrequenzaCardiaca(msg, ref fMax, ref fMaxA, ref fMinA);

            Assert.AreEqual(fMax, 220);
            Assert.AreEqual(fMaxA, 225);
            Assert.AreEqual(fMinA, 175);
        }

        /// <summary>
        /// Test con età inserita negativa
        /// </summary>

        [TestMethod]
        public void Frequenza_Cardiaca4()
        {
            //Inizializzo le variabili
            string x = "-4g";     //Variabile che conterrà l'età inserita dl cliente
            double fMax = 0;    //Variabile che conterrà il valore della frequenza massima raggiungibile dal cliente
            double fMaxA = 0;   //Variabile che conterrà il valore della frequenza massima raggiungibile per un buon allenamento
            double fMinA = 0;   //Variabile che conterrà il valore della frequenza minima raggiungibile per un buon allenamento
            string msg = "";    //Variabile che conterrà il messaggio da ridare all'utente in caso di dati inseriti errati

            //Faccio un ciclo "do-while" nel caso in cui desse errore, faccio reinserire il valore al cliente
            do
            {
                //x = Console.ReadLine();

                try //Realizzo un comando try/catch in modo che se fossero riscontrati dei problemi di tipo/valore, il programma non vada in crash
                {
                    fMax = 220 - Convert.ToDouble(x);

                    if (fMax >= 220) //Realizzo un controllo per prevenire l'inserimento errato dell'età in quanto a valore
                    {
                        if (fMax > 220)
                        {
                            //Console.WriteLine("ATTENZIONE!! L'età inserita è negativa: REINSERIRLA.");
                        }
                        else
                        {
                            //Console.WriteLine("ATTENZIONE!! L'età inserità è uguale a 0: REINSERIRLA.");
                        }
                    }
                }
                catch
                {
                    msg = "ATTENZIONE!! Il valore inserito NON è un numero: REINSERIRLO.";
                }
            }
            while (fMax == 0);

            CardioAnalisiLibrary.DataCardio.FrequenzaCardiaca(msg, ref fMax, ref fMaxA, ref fMinA);

            Assert.AreEqual(fMax, 220);
            Assert.AreEqual(fMaxA, 225);
            Assert.AreEqual(fMinA, 175);
        }
    }
}
