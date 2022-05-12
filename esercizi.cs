namespace SecondoGiorno
{

    public static class esercizi_secondogiorno
    {
        public static int PrimoEsercizio(int iPrimoNumero, int iSecondoNumero)
        {
            int iSomma;

            iSomma = iPrimoNumero + iSecondoNumero;

            return iSomma;
        }

        public static void RaddoppiaNumero(int iNumeroDaRaddoppiare)
        {
            iNumeroDaRaddoppiare = iNumeroDaRaddoppiare * 2;           
        }


        public static void RaddoppiaNumero(ref int iNumeroDaRaddoppiare)
        {
            iNumeroDaRaddoppiare = iNumeroDaRaddoppiare * 2;
            
        }



        public static void ModificaStringa(ref string sStringaDaModificare)
        {
            sStringaDaModificare = sStringaDaModificare + "abc";
        }


        public static float CalcolaMedia(int[] vVettoreInteri)
        {
            int iNumElementi = vVettoreInteri.Length;
            float fSomma = 0;
            for(int i=0;i<iNumElementi;i++)
            {
                fSomma = fSomma + vVettoreInteri[i];
            }
            fSomma = fSomma / (float)iNumElementi;
            return fSomma;
        }
    }
}

