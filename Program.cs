using System;

namespace UnicamMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questo programma calcola l'ipotenusa e gli angoli interni fornendo la lunghezza di due cateti");

            //Chiedo di inserire la lunghezza dei cateti e la salvo nelle stringhe che poi converto in double
            Console.Write("Inserisci la lunghezza del primo cateto: ");
            string cateto1Testuale = Console.ReadLine();
            double cateto1Numerico = double.Parse(cateto1Testuale);

            Console.Write("Inserisci la lunghezza del secondo cateto: ");
            string cateto2Testuale = Console.ReadLine();
            double cateto2Numerico = double.Parse(cateto2Testuale);

            //Per calcolare l'ipotenusa uso il teorema di Pitagora
            double ipotenusaNumerico = (double) Math.Sqrt(Math.Pow(cateto1Numerico,2) + Math.Pow(cateto2Numerico,2));

            //Approssimo l'ipotenusa in modo da avere solo 2 cifre decimali
            String ipotenusaDecimale = ipotenusaNumerico.ToString("N2");

            //Per calcolare il seno degli angoli uso le formule trigonometriche dei triangoli rettangoli
            double senoAngolo2 = (double) (cateto1Numerico / ipotenusaNumerico);
            double senoAngolo3 = (double) (cateto2Numerico / ipotenusaNumerico);

            double angolo1InGradi = 90;

            //Per calcolare gli angoli uso la funzione Asin (arcseno) --> mi ritorna l'angolo in radianti
            double angolo2InRadianti = (double)(Math.Asin(senoAngolo2));
            double angolo3InRadianti = (double)(Math.Asin(senoAngolo3));

            //Converto i radianti in gradi
            double angolo2InGradi = (double) (angolo2InRadianti*180/Math.PI);
            double angolo3InGradi = (double)(angolo3InRadianti*180/Math.PI);

            //Approssimo gli angoli in modo da avere solo 2 cifre decimali
            string angolo2Decimale = angolo2InGradi.ToString("N2");
            string angolo3Decimale = angolo3InGradi.ToString("N2");

            //Scrivo su console i risultati ottenuti
            Console.WriteLine($"L'ipotenusa misura {ipotenusaDecimale}");
            Console.WriteLine($"I tre angoli interni misurano {angolo1InGradi} gradi, {angolo2Decimale} gradi e {angolo3Decimale} gradi.");

            Console.ReadKey();
        }
    }
}
