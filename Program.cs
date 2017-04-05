using System;

namespace UnicamMath
{
    class Program
    {
        public static double ChiediCatetoAllUtente (String messaggio) {
                    //Ciclo infinito per chiedere un valore corretto di cateto1
                while (true)
                {
                    Console.WriteLine(messaggio);
                    String catetoString = Console.ReadLine();
                    if (double.TryParse(catetoString, out double cateto))
                        return cateto;
                    else
                    {
                        Console.WriteLine($"{catetoString} non è un valore corretto");
                        continue;
                    }
                }
                }
        static void Main(string[] args)
        {
            while (true)
            {
                //Pulisco la Console
                Console.Clear();
                
                Console.WriteLine("Questo programma calcola l'ipotenusa e gli angoli interni fornendo la lunghezza di due cateti");
                double angoloRetto = 90;
                double angolo1Radianti = 0;
                double angolo2Radianti = 0;
                double angolo1Gradi = 0;
                double angolo2Gradi = 0;
                double cateto1 = 0;
                double cateto2 = 0;
                double ipotenusa = 0;
                string cateto1Stringa = "";
                string cateto2Stringa = "";

                cateto1 = ChiediCatetoAllUtente("Inserisci la lunghezza del primo cateto:");
                cateto2 = ChiediCatetoAllUtente("Inserisci la lunghezza del secondo cateto");

                //Calcolo il valore dell'ipotenusa
                ipotenusa = Math.Sqrt(Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2));
                //Calcolo gli angoli
                double senoAngolo1 = cateto1 / ipotenusa;
                double senoAngolo2 = cateto2 / ipotenusa;
                angolo1Radianti = Math.Asin(senoAngolo1);
                angolo2Radianti = Math.Asin(senoAngolo2);
                angolo1Gradi = (angolo1Radianti * 180) / Math.PI;
                angolo2Gradi = (angolo2Radianti * 180) / Math.PI;

                //Creo due variabili string per arrotondare a due cifre decimali i valori degli angoli
                string angolo1String = angolo1Gradi.ToString("N2");
                string angolo2String = angolo2Gradi.ToString("N2");
                string ipotenusaString = ipotenusa.ToString("N2");

                //Scrivo su console i risultati ottenuti
                Console.WriteLine($"Cateto1 = {cateto1}; Cateto2 = {cateto2}; Ipotenusa = {ipotenusaString}");
                Console.WriteLine($"AngoloRetto = {angoloRetto}; Angolo1 = {angolo1String}; Angolo2 = {angolo2String}");

                //Aspetto che qualcuno prema invio per terminare il programma
                Console.WriteLine("Scrivi s per inserire nuovi dati oppure un tasto qualsiasi per terminare");
                string risposta = Console.ReadLine();
                if (!risposta.Equals("s"))
                    break;
            }
        }
    }
}
