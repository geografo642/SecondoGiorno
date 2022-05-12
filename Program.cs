namespace SecondoGiorno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Qui c'è il codice sorgente
            //esercizi_secondogiorno.PrimoEsercizio(32, 44);

            /*
            int iNumDaRaddoppiare = 9;
            esercizi_secondogiorno.RaddoppiaNumero(iNumDaRaddoppiare);
            Console.WriteLine("Il numero vale {0}", iNumDaRaddoppiare);
            
            string sAppo = "paperino";
            esercizi_secondogiorno.ModificaStringa(ref sAppo);
            Console.WriteLine("La stringa vale {0}", sAppo);
            */


            int[] ArrayDiNumeri;
            ArrayDiNumeri = new int[100];
            Console.WriteLine("Immetti numeri per fare la media e premi invio quando hai finito:");
            string sAppo;
            sAppo = Console.ReadLine();
            int iNumNumeriInseriti = 0;
            while((sAppo.Length>0) && (iNumNumeriInseriti < 100))
            {
                ArrayDiNumeri[iNumNumeriInseriti] = Int32.Parse(sAppo);
                iNumNumeriInseriti = iNumNumeriInseriti + 1;
                
                sAppo = Console.ReadLine();
               
            }

            "34;820;45;"


            //Da console chiedi quanti elementi vuole mettere (es. 10)
            
            //Salvi dentro una stringa e converti in numero 






            /*
            int iNumElementiVettore = 58;

            int iAppo = 0;
            string sAppo = "ciao";
            bool bRetValue;
            bRetValue = Int32.TryParse(sAppo,out iAppo);


            int[] ArrayDiNumeri;
            ArrayDiNumeri = new int[iNumElementiVettore];



            ArrayDiNumeri[0] = 28;
            ArrayDiNumeri[1] = 88;
            ArrayDiNumeri[2] = 546;
            float fMedia;
            fMedia = esercizi_secondogiorno.CalcolaMedia(ArrayDiNumeri);
            */
            /*
            string[] ArrayDiStringhe;
            ArrayDiStringhe = new string[10];
            ArrayDiStringhe[3] = "paperino";
            Console.WriteLine("Il quinto carattere è {0}", ArrayDiStringhe[3][4]);//Stampa la r
            */
        }
    }
}