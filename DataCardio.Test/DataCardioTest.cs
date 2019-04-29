using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataCardio.Test
{
    [TestClass]
    public class DataCardioTest
    {
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //Test con la variabile "Uomo"
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Età inserita uguale a 0
        /// Frequenza a riposo bradicardica
        /// Sesso: uomo
        /// Tempo impiegato uguale a 0
        /// Peso corporeo uguale a 0
        /// Km percorsi uguali a 0
        /// Frequenza giornaliera con almeno un valore uguale a 0
        /// frequenza dei battiti uguale a 0
        /// altezza uguale a 0
        /// </summary>
        [TestMethod]
        public void Frequenza_CardiacaUomo1()
        {
            //Inizializzo le variabili:
            string msg = "";                                                             //Variabile che ci servirà per eseguire dei controlli sui valori inseriti    
            double x = 0;                                                                //Variabile che conterrà l'età inserita dl cliente.
            double fMax = 0;                                                             //Variabile che conterrà il valore della frequenza massima raggiungibile dal cliente;
            double fMaxA = 0;                                                            //Variabile che conterrà il valore della frequenza massima raggiungibile per un buon allenamento;
            double fMinA = 0;                                                            //Variabile che conterrà il valore della frequenza minima raggiungibile per un buon allenamento;
            double frequenzaRiposo = 55;                                                 //Frequenza cardiaca a riposo;
            string tipoF = "";                                                           //Variabile che conterrà il tipo di frequenza che il cliente ha;
            string sesso = "Uomo";                                                       //Vaiabile che contiene il sesso del cliente e ch determinerà i calcoli da eseguire per calcolarne le calorie bruciate;
            double C = 0;                                                                //Variabile che conterrà il valore delle calorie bruciate l'allenamento, espresso in KCal;
            double F = 176;                                                              //Variabile che contiene il valore della frequenza cardiaca media durante l'allenamento;
            double P = 0;                                                                //Variabile contenente il peso del cliente espresso in Kg;
            double A = Convert.ToDouble(x);                                              //Variabile che conterrà l'età del cliente ed avrà lo stesso valore della variabile "x". Si usa questa variabile per il calcolo delle calorie bruciate;
            double T = 0;                                                                //Variabile che conterrà il valore pari alla durata dell'allenamento espresso in minuti;
            double spesaEnergeticaCorsa = 0;                                             //Variabile che contiene il valore dell'energia spesa correndo
            double spesaEnergeticaCamminata = 0;                                         //Variabile che contiene il valore dell'energia spesa camminando
            double kmPercorsi = 0;                                                       //Variabile che contiene il numero dei km percorsi dal cliente
            double[] frequenzeGiornaliere = new double[] { 68, 74, 79, 0, 65, 93, 78 };  //Variabile che contiene i valori delle frequenze minime registrate in 7 giorni
            double mGiornaliera = 0;                                                     //Variabile che conterrà il valore pari alla media giornalieradei battiti/battito cardiaco a riposo
            double frequenzaB = 0;                                                       //Variabile che conterrà il valore della frequenza dei battiti al minuto
            string variabilità = "";                                                     //Variabile contnente la variabilità del battito cardiaco
            string altezza = "0";                                                          //Variabile che conterrà l'altezza del cliente (espressa in metri)
            string tipoPeso = "";                                                        //Variabile che conterrà il tipo di peso del cliente

            //Chiamo il metodo che mi calcola i valori della "frequenza massima consigliata", della "frequenza massima per un buon allenamento" e la "frequenza minima per un buon allenamento"
            CardioAnalisiLibrary.DataCardio.FrequenzaCardiaca(x, ref fMax, ref fMaxA, ref fMinA);

            Assert.AreEqual(fMax, 220);
            Assert.AreEqual(fMaxA, 198);
            Assert.AreEqual(fMinA, 154);

            //Chiamo il metodo che definisce il tipo di frequenza.
            CardioAnalisiLibrary.DataCardio.TipoFrequenza(frequenzaRiposo, ref tipoF);

            Assert.AreEqual(tipoF, "Bradicardia");

            //Chiamo il metodo per calcolare quante calorie sono state bruciate in un allenamento.
            CardioAnalisiLibrary.DataCardio.CalcoloCalorieBruciate(sesso, ref C, F, P, A, T);

            Assert.AreEqual(C, "0");

            //Chiamo il metodo per calcolare le calorie bruciate in camminata e in corsa
            CardioAnalisiLibrary.DataCardio.CalcoloCalorieSpese(ref spesaEnergeticaCorsa, ref spesaEnergeticaCamminata, kmPercorsi, P);

            Assert.AreEqual(spesaEnergeticaCorsa, "0");
            Assert.AreEqual(spesaEnergeticaCamminata, "0");

            //Chiamo il metodo per il calcolo della "frequenza cardiaca media", il "battito cardiaco a riposo", la "variabilità del battito cardiaco" e l'ordine crescente dei battiti durante la giornata
            CardioAnalisiLibrary.DataCardio.MultiFunzione(ref msg, ref frequenzeGiornaliere, ref mGiornaliera, frequenzaB, ref variabilità);

            Assert.AreEqual(mGiornaliera, 0);
            Assert.AreEqual(msg, "Attenzione!! Sono stati inseriti valori negativi o uguali a 0: REINSERIRLI. Attenzione!! Il valore inserito è negativo o uguale a 0: REINSERIRLO.");
            Assert.AreEqual(variabilità, "");
            //Assert.AreEqual(frequenzeGiornaliere, );

            msg = "";

            //Chiamo il metodo per definire il tipo di peso del cliente
            CardioAnalisiLibrary.DataCardio.TipoDiPeso(ref msg, P, altezza, ref tipoPeso);
            Assert.AreEqual(tipoPeso, "");
            Assert.AreEqual(msg, "Attenzione!! I valori non sono stati inseriti correttamente: REINSERIRLI.");
        }

        /// <summary>
        /// Età inserita positiva
        /// Frequenza a riposo normale
        /// Sesso: uomo
        /// Tempo impiegato positivo
        /// Peso corporeo positivo
        /// Km percorsi positivi
        /// Frequenza giornaliera con ogni valore positivo
        /// frequenza dei battiti positiva
        /// altezza con valore positivo
        /// </summary>

        [TestMethod]
        public void Frequenza_CardiacaUomo2()
        {
            //Inizializzo le variabili:
            string msg = "";                                                              //Variabile che ci servirà per eseguire dei controlli sui valori inseriti 
            double x = 30;                                                                //Variabile che conterrà l'età inserita dl cliente.
            double fMax = 0;                                                              //Variabile che conterrà il valore della frequenza massima raggiungibile dal cliente;
            double fMaxA = 0;                                                             //Variabile che conterrà il valore della frequenza massima raggiungibile per un buon allenamento;
            double fMinA = 0;                                                             //Variabile che conterrà il valore della frequenza minima raggiungibile per un buon allenamento;
            double frequenzaRiposo = 75;                                                  //Frequenza cardiaca a riposo;
            string tipoF = "";                                                            //Variabile che conterrà il tipo di frequenza che il cliente ha;
            string sesso = "Uomo";                                                        //Vaiabile che contiene il sesso del cliente e ch determinerà i calcoli da eseguire per calcolarne le calorie bruciate;
            double C = 0;                                                                 //Variabile che conterrà il valore delle calorie bruciate l'allenamento, espresso in KCal;
            double F = 176;                                                               //Variabile che contiene il valore della frequenza cardiaca media durante l'allenamento;
            double P = 70;                                                                //Variabile contenente il peso del cliente espresso in Kg;
            double A = Convert.ToDouble(x);                                               //Variabile che conterrà l'età del cliente ed avrà lo stesso valore della variabile "x". Si usa questa variabile per il calcolo delle calorie bruciate;
            double T = 40;                                                                //Variabile che conterrà il valore pari alla durata dell'allenamento espresso in minuti;
            double spesaEnergeticaCorsa = 0;                                              //Variabile che contiene il valore dell'energia spesa correndo
            double spesaEnergeticaCamminata = 0;                                          //Variabile che contiene il valore dell'energia spesa camminando
            double kmPercorsi = 10;                                                       //Variabile che contiene il numero dei km percorsi dal cliente
            double[] frequenzeGiornaliere = new double[] { 68, 74, 79, 86, 65, 93, 78 };  //Variabile che contiene i valori delle frequenze minime registrate in 7 giorni
            double mGiornaliera = 0;                                                      //Variabile che conterrà il valore pari alla media giornalieradei battiti/battito cardiaco a riposo
            double frequenzaB = 0.20;                                                     //Variabile che conterrà il valore della frequenza dei battiti al minuto
            string variabilità = "";                                                      //Variabile contnente la variabilità del battito cardiaco
            string altezza = "1.70";                                                        //Variabile che conterrà l'altezza del cliente (espressa in metri)
            string tipoPeso = "";                                                         //Variabile che conterrà il tipo di peso del cliente

            //Chiamo il metodo che mi calcola i valori della "frequenza massima consigliata", della "frequenza massima per un buon allenamento" e la "frequenza minima per un buon allenamento"
            CardioAnalisiLibrary.DataCardio.FrequenzaCardiaca(x, ref fMax, ref fMaxA, ref fMinA);

            Assert.AreEqual(fMax, 190);
            Assert.AreEqual(fMaxA, 171);
            Assert.AreEqual(fMinA, 133);

            //Chiamo il metodo che definisce il tipo di frequenza.
            CardioAnalisiLibrary.DataCardio.TipoFrequenza(frequenzaRiposo, ref tipoF);

            Assert.AreEqual(tipoF, "Normale");

            //Chiamo il metodo per calcolare quante calorie sono state bruciate in un allenamento.
            CardioAnalisiLibrary.DataCardio.CalcoloCalorieBruciate(sesso, ref C, F, P, A, T);

            Assert.AreEqual(C, "725.8365200765");

            //Chiamo il metodo per calcolare le calorie bruciate in camminata e in corsa
            CardioAnalisiLibrary.DataCardio.CalcoloCalorieSpese(ref spesaEnergeticaCorsa, ref spesaEnergeticaCamminata, kmPercorsi, P);

            Assert.AreEqual(spesaEnergeticaCorsa, "630");
            Assert.AreEqual(spesaEnergeticaCamminata, "350");

            //Chiamo il metodo per il calcolo della "frequenza cardiaca media", il "battito cardiaco a riposo", la "variabilità del battito cardiaco" e l'ordine crescente dei battiti durante la giornata
            CardioAnalisiLibrary.DataCardio.MultiFunzione(ref msg, ref frequenzeGiornaliere, ref mGiornaliera, frequenzaB, ref variabilità);

            Assert.AreEqual(mGiornaliera, 77.5714285714);
            Assert.AreEqual(msg, "");
            Assert.AreEqual(variabilità, "HF");
            //Assert.AreEqual(frequenzeGiornaliere, );

            msg = "";

            //Chiamo il metodo per definire il tipo di peso del cliente
            CardioAnalisiLibrary.DataCardio.TipoDiPeso(ref msg, P, altezza, ref tipoPeso);
            Assert.AreEqual(tipoPeso, "In linea");
            Assert.AreEqual(msg, "");
        }

        /// <summary>
        /// Età inserita negativa
        /// Frequenza a riposo tachicardica
        /// Sesso: uomo
        /// Tempo impiegato negativo
        /// Peso corporeo negativo
        /// Km percorsi negativi
        /// Frequenza giornaliera con almeno un valore negativo
        /// frequenza dei battiti negativa
        /// altezza con valore negativo
        /// </summary>

        [TestMethod]
        public void Frequenza_CardiacaUomo3()
        {
            //Inizializzo le variabili:
            string msg = "";                                                               //Variabile che ci servirà per eseguire dei controlli sui valori inseriti 
            double x = -40;                                                                //Variabile che conterrà l'età inserita dl cliente.
            double fMax = 0;                                                               //Variabile che conterrà il valore della frequenza massima raggiungibile dal cliente;
            double fMaxA = 0;                                                              //Variabile che conterrà il valore della frequenza massima raggiungibile per un buon allenamento;
            double fMinA = 0;                                                              //Variabile che conterrà il valore della frequenza minima raggiungibile per un buon allenamento;
            double frequenzaRiposo = 115;                                                  //Frequenza cardiaca a riposo;
            string tipoF = "";                                                             //Variabile che conterrà il tipo di frequenza che il cliente ha;
            string sesso = "Uomo";                                                         //Vaiabile che contiene il sesso del cliente e ch determinerà i calcoli da eseguire per calcolarne le calorie bruciate;
            double C = 0;                                                                  //Variabile che conterrà il valore delle calorie bruciate l'allenamento, espresso in KCal;
            double F = 176;                                                                //Variabile che contiene il valore della frequenza cardiaca media durante l'allenamento;
            double P = -70;                                                                //Variabile contenente il peso del cliente espresso in Kg;
            double A = x;                                                                  //Variabile che conterrà l'età del cliente ed avrà lo stesso valore della variabile "x". Si usa questa variabile per il calcolo delle calorie bruciate;
            double T = -30;                                                                //Variabile che conterrà il valore pari alla durata dell'allenamento espresso in minuti;
            double spesaEnergeticaCorsa = 0;                                               //Variabile che contiene il valore dell'energia spesa correndo
            double spesaEnergeticaCamminata = 0;                                           //Variabile che contiene il valore dell'energia spesa camminando
            double kmPercorsi = -10;                                                       //Variabile che contiene il numero dei km percorsi dal cliente
            double[] frequenzeGiornaliere = new double[] { 68, 74, -79, 86, 65, 93, 78 };  //Variabile che contiene i valori delle frequenze minime registrate in 7 giorni
            double mGiornaliera = -0.60;                                                   //Variabile che conterrà il valore pari alla media giornalieradei battiti/battito cardiaco a riposo
            double frequenzaB = 0;                                                         //Variabile che conterrà il valore della frequenza dei battiti al minuto
            string variabilità = "";                                                       //Variabile contnente la variabilità del battito cardiaco
            string altezza = "-1.70";                                                        //Variabile che conterrà l'altezza del cliente (espressa in metri)
            string tipoPeso = "";                                                          //Variabile che conterrà il tipo di peso del cliente

            //Chiamo il metodo che mi calcola i valori della "frequenza massima consigliata", della "frequenza massima per un buon allenamento" e la "frequenza minima per un buon allenamento"
            CardioAnalisiLibrary.DataCardio.FrequenzaCardiaca(x, ref fMax, ref fMaxA, ref fMinA);

            Assert.AreEqual(fMax, 260);
            Assert.AreEqual(fMaxA, 234);
            Assert.AreEqual(fMinA, 182);

            //Chiamo il metodo che definisce il tipo di frequenza.
            CardioAnalisiLibrary.DataCardio.TipoFrequenza(frequenzaRiposo, ref tipoF);

            Assert.AreEqual(tipoF, "Tachicardia");

            //Chiamo il metodo per calcolare quante calorie sono state bruciate in un allenamento.
            CardioAnalisiLibrary.DataCardio.CalcoloCalorieBruciate(sesso, ref C, F, P, A, T);

            Assert.AreEqual(C, "-701.0623804971 (Errore: i valori sono stati inseriti NEGATIVI.)");

            //Chiamo il metodo per calcolare le calorie bruciate in camminata e in corsa
            CardioAnalisiLibrary.DataCardio.CalcoloCalorieSpese(ref spesaEnergeticaCorsa, ref spesaEnergeticaCamminata, kmPercorsi, P);

            Assert.AreEqual(spesaEnergeticaCorsa, "630");
            Assert.AreEqual(spesaEnergeticaCamminata, "350");

            //Chiamo il metodo per il calcolo della "frequenza cardiaca media", il "battito cardiaco a riposo", la "variabilità del battito cardiaco" e l'ordine crescente dei battiti durante la giornata
            CardioAnalisiLibrary.DataCardio.MultiFunzione(ref msg, ref frequenzeGiornaliere, ref mGiornaliera, frequenzaB, ref variabilità);

            Assert.AreEqual(mGiornaliera, 0);
            Assert.AreEqual(msg, "Attenzione!! Sono stati inseriti valori negativi o uguali a 0: REINSERIRLI. Attenzione!! Il valore inserito è negativo o uguale a 0: REINSERIRLO.");
            Assert.AreEqual(variabilità, "");
            //Assert.AreEqual(frequenzeGiornaliere, );

            msg = "";

            //Chiamo il metodo per definire il tipo di peso del cliente
            CardioAnalisiLibrary.DataCardio.TipoDiPeso(ref msg, P, altezza, ref tipoPeso);
            Assert.AreEqual(tipoPeso, "");
            Assert.AreEqual(msg, "Attenzione!! I valori non sono stati inseriti correttamente: REINSERIRLI.");
        }




        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //Test con la variabile "Donna"
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        /// <summary>
        /// Età inserita uguale a 0
        /// Frequenza a riposo bradicardica
        /// Sesso: donna
        /// Tempo impiegato uguale a 0
        /// Peso corporeo uguale a 0
        /// Km percorsi uguali a 0
        /// Frequenza giornaliera con almeno un valore uguale a 0
        /// frequenza dei battiti uguale a 0
        /// altezza uguale a 0
        /// </summary>

        [TestMethod]
        public void Frequenza_CardiacaDonna1()
        {
            //Inizializzo le variabili:
            string msg = "";                                                             //Variabile che ci servirà per eseguire dei controlli sui valori inseriti 
            double x = 0;                                                                //Variabile che conterrà l'età inserita dl cliente.
            double fMax = 0;                                                             //Variabile che conterrà il valore della frequenza massima raggiungibile dal cliente;
            double fMaxA = 0;                                                            //Variabile che conterrà il valore della frequenza massima raggiungibile per un buon allenamento;
            double fMinA = 0;                                                            //Variabile che conterrà il valore della frequenza minima raggiungibile per un buon allenamento;
            double frequenzaRiposo = 55;                                                 //Frequenza cardiaca a riposo;
            string tipoF = "";                                                           //Variabile che conterrà il tipo di frequenza che il cliente ha;
            string sesso = "Donna";                                                      //Vaiabile che contiene il sesso del cliente e ch determinerà i calcoli da eseguire per calcolarne le calorie bruciate;
            double C = 0;                                                                //Variabile che conterrà il valore delle calorie bruciate l'allenamento, espresso in KCal;
            double F = 176;                                                              //Variabile che contiene il valore della frequenza cardiaca media durante l'allenamento;
            double P = 70;                                                               //Variabile contenente il peso del cliente espresso in Kg;
            double A = x;                                                                //Variabile che conterrà l'età del cliente ed avrà lo stesso valore della variabile "x". Si usa questa variabile per il calcolo delle calorie bruciate;
            double T = 30;                                                               //Variabile che conterrà il valore pari alla durata dell'allenamento espresso in minuti;
            double spesaEnergeticaCorsa = 0;                                             //Variabile che contiene il valore dell'energia spesa correndo
            double spesaEnergeticaCamminata = 0;                                         //Variabile che contiene il valore dell'energia spesa camminando
            double kmPercorsi = 10;                                                      //Variabile che contiene il numero dei km percorsi dal cliente
            double[] frequenzeGiornaliere = new double[] { 68, 74, 79, 0, 65, 93, 78 };  //Variabile che contiene i valori delle frequenze minime registrate in 7 giorni
            double mGiornaliera = 0;                                                     //Variabile che conterrà il valore pari alla media giornalieradei battiti/battito cardiaco a riposo
            double frequenzaB = 0;                                                       //Variabile che conterrà il valore della frequenza dei battiti al minuto
            string variabilità = "";                                                     //Variabile contnente la variabilità del battito cardiaco
            string altezza = "0";                                                          //Variabile che conterrà l'altezza del cliente (espressa in metri)
            string tipoPeso = "";                                                        //Variabile che conterrà il tipo di peso del cliente

            //Chiamo il metodo che mi calcola i valori della "frequenza massima consigliata", della "frequenza massima per un buon allenamento" e la "frequenza minima per un buon allenamento"
            CardioAnalisiLibrary.DataCardio.FrequenzaCardiaca(x, ref fMax, ref fMaxA, ref fMinA);

            Assert.AreEqual(fMax, 220);
            Assert.AreEqual(fMaxA, 198);
            Assert.AreEqual(fMinA, 154);

            //Chiamo il metodo che definisce il tipo di frequenza.
            CardioAnalisiLibrary.DataCardio.TipoFrequenza(frequenzaRiposo, ref tipoF);

            Assert.AreEqual(tipoF, "Bradicardia");

            //Chiamo il metodo per calcolare quante calorie sono state bruciate in un allenamento.
            CardioAnalisiLibrary.DataCardio.CalcoloCalorieBruciate(sesso, ref C, F, P, A, T);

            Assert.AreEqual(C, "0");

            //Chiamo il metodo per calcolare le calorie bruciate in camminata e in corsa
            CardioAnalisiLibrary.DataCardio.CalcoloCalorieSpese(ref spesaEnergeticaCorsa, ref spesaEnergeticaCamminata, kmPercorsi, P);

            Assert.AreEqual(spesaEnergeticaCorsa, "0");
            Assert.AreEqual(spesaEnergeticaCamminata, "0");

            //Chiamo il metodo per il calcolo della "frequenza cardiaca media", il "battito cardiaco a riposo", la "variabilità del battito cardiaco" e l'ordine crescente dei battiti durante la giornata
            CardioAnalisiLibrary.DataCardio.MultiFunzione(ref msg, ref frequenzeGiornaliere, ref mGiornaliera, frequenzaB, ref variabilità);

            Assert.AreEqual(mGiornaliera, 0);
            Assert.AreEqual(msg, "Attenzione!! Sono stati inseriti valori negativi o uguali a 0: REINSERIRLI. Attenzione!! Il valore inserito è negativo o uguale a 0: REINSERIRLO.");
            Assert.AreEqual(variabilità, "");
            //Assert.AreEqual(frequenzeGiornaliere, );

            msg = "";

            //Chiamo il metodo per definire il tipo di peso del cliente
            CardioAnalisiLibrary.DataCardio.TipoDiPeso(ref msg, P, altezza, ref tipoPeso);
            Assert.AreEqual(tipoPeso, "");
            Assert.AreEqual(msg, "Attenzione!! I valori non sono stati inseriti correttamente: REINSERIRLI.");
        }

        /// <summary>
        /// Età inserita positiva
        /// Frequenza a riposo normale
        /// Sesso: donna
        /// Tempo impiegato positivo
        /// Peso corporeo positivo
        /// Km percorsi positivi
        /// Frequenza giornaliera con tutti i valori positivi
        /// frequenza dei battiti positiva
        /// altezza con valore positivo
        /// </summary>

        [TestMethod]
        public void Frequenza_CardiacaDonna2()
        {
            //Inizializzo le variabili:
            string msg = "";                                                              //Variabile che ci servirà per eseguire dei controlli sui valori inseriti 
            double x = 30;                                                                //Variabile che conterrà l'età inserita dl cliente.
            double fMax = 0;                                                              //Variabile che conterrà il valore della frequenza massima raggiungibile dal cliente;
            double fMaxA = 0;                                                             //Variabile che conterrà il valore della frequenza massima raggiungibile per un buon allenamento;
            double fMinA = 0;                                                             //Variabile che conterrà il valore della frequenza minima raggiungibile per un buon allenamento;
            double frequenzaRiposo = 70;                                                  //Frequenza cardiaca a riposo;
            string tipoF = "";                                                            //Variabile che conterrà il tipo di frequenza che il cliente ha;
            string sesso = "Donna";                                                       //Vaiabile che contiene il sesso del cliente e ch determinerà i calcoli da eseguire per calcolarne le calorie bruciate;
            double C = 0;                                                                 //Variabile che conterrà il valore delle calorie bruciate l'allenamento, espresso in KCal;
            double F = 176;                                                               //Variabile che contiene il valore della frequenza cardiaca media durante l'allenamento;
            double P = 70;                                                                //Variabile contenente il peso del cliente espresso in Kg;
            double A = Convert.ToDouble(x);                                               //Variabile che conterrà l'età del cliente ed avrà lo stesso valore della variabile "x". Si usa questa variabile per il calcolo delle calorie bruciate;
            double T = 30;                                                                //Variabile che conterrà il valore pari alla durata dell'allenamento espresso in minuti;
            double spesaEnergeticaCorsa = 0;                                              //Variabile che contiene il valore dell'energia spesa correndo
            double spesaEnergeticaCamminata = 0;                                          //Variabile che contiene il valore dell'energia spesa camminando
            double kmPercorsi = 10;                                                       //Variabile che contiene il numero dei km percorsi dal cliente
            double[] frequenzeGiornaliere = new double[] { 68, 74, 79, 86, 65, 93, 78 };  //Variabile che contiene i valori delle frequenze minime registrate in 7 giorni
            double mGiornaliera = 0;                                                      //Variabile che conterrà il valore pari alla media giornalieradei battiti/battito cardiaco a riposo
            double frequenzaB = 0.10;                                                     //Variabile che conterrà il valore della frequenza dei battiti al minuto
            string variabilità = "";                                                      //Variabile contnente la variabilità del battito cardiaco
            string altezza = "1.60";                                                        //Variabile che conterrà l'altezza del cliente (espressa in metri)
            string tipoPeso = "";                                                         //Variabile che conterrà il tipo di peso del cliente

            //Chiamo il metodo che mi calcola i valori della "frequenza massima consigliata", della "frequenza massima per un buon allenamento" e la "frequenza minima per un buon allenamento"
            CardioAnalisiLibrary.DataCardio.FrequenzaCardiaca(x, ref fMax, ref fMaxA, ref fMinA);

            Assert.AreEqual(fMax, 190);
            Assert.AreEqual(fMaxA, 171);
            Assert.AreEqual(fMinA, 133);

            //Chiamo il metodo che definisce il tipo di frequenza.
            CardioAnalisiLibrary.DataCardio.TipoFrequenza(frequenzaRiposo, ref tipoF);

            Assert.AreEqual(tipoF, "Normale");

            //Chiamo il metodo per calcolare quante calorie sono state bruciate in un allenamento.
            CardioAnalisiLibrary.DataCardio.CalcoloCalorieBruciate(sesso, ref C, F, P, A, T);

            Assert.AreEqual(C, "494.3116634799");

            //Chiamo il metodo per calcolare le calorie bruciate in camminata e in corsa
            CardioAnalisiLibrary.DataCardio.CalcoloCalorieSpese(ref spesaEnergeticaCorsa, ref spesaEnergeticaCamminata, kmPercorsi, P);

            Assert.AreEqual(spesaEnergeticaCorsa, "630");
            Assert.AreEqual(spesaEnergeticaCamminata, "350");

            //Chiamo il metodo per il calcolo della "frequenza cardiaca media", il "battito cardiaco a riposo", la "variabilità del battito cardiaco" e l'ordine crescente dei battiti durante la giornata
            CardioAnalisiLibrary.DataCardio.MultiFunzione(ref msg, ref frequenzeGiornaliere, ref mGiornaliera, frequenzaB, ref variabilità);

            Assert.AreEqual(mGiornaliera, 77.5714285714);
            Assert.AreEqual(msg, "");
            Assert.AreEqual(variabilità, "LF");
            //Assert.AreEqual(frequenzeGiornaliere, );

            msg = "";

            //Chiamo il metodo per definire il tipo di peso del cliente
            CardioAnalisiLibrary.DataCardio.TipoDiPeso(ref msg, P, altezza, ref tipoPeso);
            Assert.AreEqual(tipoPeso, "Sovrappeso");
            Assert.AreEqual(msg, "");
        }

        /// <summary>
        /// Età inserita negativa
        /// Frequenza a riposo tachicardica
        /// Sesso: donna
        /// Tempo impiegato negativo
        /// Peso corporeo negativo
        /// Km percorsi negativi
        /// Frequenza giornaliera con almeno un valore negativo
        /// frequenza dei battiti negativa
        /// altezza con valore negativo
        /// </summary>

        [TestMethod]
        public void Frequenza_CardiacaDonna3()
        {
            //Inizializzo le variabili:
            string msg = "";                                                               //Variabile che ci servirà per eseguire dei controlli sui valori inseriti 
            double x = -40;                                                                //Variabile che conterrà l'età inserita dl cliente.
            double fMax = 0;                                                               //Variabile che conterrà il valore della frequenza massima raggiungibile dal cliente;
            double fMaxA = 0;                                                              //Variabile che conterrà il valore della frequenza massima raggiungibile per un buon allenamento;
            double fMinA = 0;                                                              //Variabile che conterrà il valore della frequenza minima raggiungibile per un buon allenamento;
            double frequenzaRiposo = 125;                                                  //Frequenza cardiaca a riposo;
            string tipoF = "";                                                             //Variabile che conterrà il tipo di frequenza che il cliente ha;
            string sesso = "Donna";                                                        //Vaiabile che contiene il sesso del cliente e ch determinerà i calcoli da eseguire per calcolarne le calorie bruciate;
            double C = 0;                                                                  //Variabile che conterrà il valore delle calorie bruciate l'allenamento, espresso in KCal;
            double F = 176;                                                                //Variabile che contiene il valore della frequenza cardiaca media durante l'allenamento;
            double P = -70;                                                                //Variabile contenente il peso del cliente espresso in Kg;
            double A = Convert.ToDouble(x);                                                //Variabile che conterrà l'età del cliente ed avrà lo stesso valore della variabile "x". Si usa questa variabile per il calcolo delle calorie bruciate;
            double T = -30;                                                                //Variabile che conterrà il valore pari alla durata dell'allenamento espresso in minuti;
            double spesaEnergeticaCorsa = 0;                                               //Variabile che contiene il valore dell'energia spesa correndo
            double spesaEnergeticaCamminata = 0;                                           //Variabile che contiene il valore dell'energia spesa camminando
            double kmPercorsi = -10;                                                       //Variabile che contiene il numero dei km percorsi dal cliente
            double[] frequenzeGiornaliere = new double[] { 68, 74, -79, 86, 65, 93, 78 };  //Variabile che contiene i valori delle frequenze minime registrate in 7 giorni
            double mGiornaliera = -0.60;                                                   //Variabile che conterrà il valore pari alla media giornalieradei battiti/battito cardiaco a riposo
            double frequenzaB = 0;                                                         //Variabile che conterrà il valore della frequenza dei battiti al minuto
            string variabilità = "";                                                       //Variabile contnente la variabilità del battito cardiaco
            string altezza = "-1.70";                                                        //Variabile che conterrà l'altezza del cliente (espressa in metri)
            string tipoPeso = "";                                                          //Variabile che conterrà il tipo di peso del cliente

            //Chiamo il metodo che mi calcola i valori della "frequenza massima consigliata", della "frequenza massima per un buon allenamento" e la "frequenza minima per un buon allenamento"
            CardioAnalisiLibrary.DataCardio.FrequenzaCardiaca(x, ref fMax, ref fMaxA, ref fMinA);

            Assert.AreEqual(fMax, 220);
            Assert.AreEqual(fMaxA, 225);
            Assert.AreEqual(fMinA, 175);
            Assert.AreEqual(fMinA, 175);

            //Chiamo il metodo che definisce il tipo di frequenza.
            CardioAnalisiLibrary.DataCardio.TipoFrequenza(frequenzaRiposo, ref tipoF);

            Assert.AreEqual(tipoF, "Tachicardica");

            //Chiamo il metodo per calcolare quante calorie sono state bruciate in un allenamento.
            CardioAnalisiLibrary.DataCardio.CalcoloCalorieBruciate(sesso, ref C, F, P, A, T);


            Assert.AreEqual(C, "-989.1849904398 (Errore: i valori sono stati inseriti NEGATIVI.)");

            //Chiamo il metodo per calcolare le calorie bruciate in camminata e in corsa
            CardioAnalisiLibrary.DataCardio.CalcoloCalorieSpese(ref spesaEnergeticaCorsa, ref spesaEnergeticaCamminata, kmPercorsi, P);

            Assert.AreEqual(spesaEnergeticaCorsa, "630");
            Assert.AreEqual(spesaEnergeticaCamminata, "350");

            //Chiamo il metodo per il calcolo della "frequenza cardiaca media", il "battito cardiaco a riposo", la "variabilità del battito cardiaco" e l'ordine crescente dei battiti durante la giornata
            CardioAnalisiLibrary.DataCardio.MultiFunzione(ref msg, ref frequenzeGiornaliere, ref mGiornaliera, frequenzaB, ref variabilità);

            Assert.AreEqual(mGiornaliera, 0);
            Assert.AreEqual(msg, "Attenzione!! Sono stati inseriti valori negativi o uguali a 0: REINSERIRLI. Attenzione!! Il valore inserito è negativo o uguale a 0: REINSERIRLO.");
            Assert.AreEqual(variabilità, "");
            //Assert.AreEqual(frequenzeGiornaliere, );

            msg = "";

            //Chiamo il metodo per definire il tipo di peso del cliente
            CardioAnalisiLibrary.DataCardio.TipoDiPeso(ref msg, P, altezza, ref tipoPeso);
            Assert.AreEqual(tipoPeso, "");
            Assert.AreEqual(msg, "Attenzione!! I valori non sono stati inseriti correttamente: REINSERIRLI.");
        }
    }
}
