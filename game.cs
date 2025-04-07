using System;
using System.Security.Cryptography;

namespace game
{
    /// <summary>
    /// Classe mastermind
    /// </summary>
    public class Mastermind
    {
        public char[] cpu = new char[5];
        public char[] gio = new char[5];
        public char[] ris = new char[5];
        public int[] posC = new int[5];        
        public int[] posG = new int[5];        
        Random randomN=new Random();
        /// <summary>
        /// Intro del gioco 
        /// </summary>
        public void Intro()
        {
            Console.WriteLine("GIOCO MASTERMIND");            
            Console.WriteLine("Hai 10 tentativi a disposizione per indovinare il numero di 5 cifre");
            for (int i=0;i<5;i++)
            {
                cpu[i]=Convert.ToChar(randomN.Next()%10+48);
                Console.Write($"{cpu[i]} ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// richiesta input
        /// </summary>
        public void RichiestaNumero()
        {
            bool rep=false;
            string app;
            do 
            {
                if (rep) 
                    Console.WriteLine("La stringa deve essere lunga 5");
                Console.WriteLine("Numeri da indovinare:");
                app=Console.ReadLine()!;
                rep=true;
                    
            }while(app.Length!=5);
            for (int c=0;c<5;c++)
            {
                gio[c]=app[c];
            }

        }

        /// <summary>
        /// inizializza vettori 
        /// </summary>
        public void Init()
        {
            for (int c=0;c<5;c++) 
            {
                ris[c]=' ';
                posC[c]=0;
                posG[c]=0;
            }
        }
        /// <summary>
        /// loop principale
        /// </summary>
        /// <returns></returns>
        public bool LoopGame()
        {
            int r=0;
            int c,g;
            bool trov; 

            for ( c=0;c<5;c++){
                if (gio[c]==cpu[c]){
                    ris[r++]='o';
                    posC[c]=1;              //poosizione del numero indovinato
                    posG[c]=1;
                }
            }            
            if (r!=5) {    //se non vinto
                for (g=0;g<5;g++){
                    if (posG[g]!=1){
                        c=0;
                        trov=false;
                        while (c<5 && !trov){
                            if (gio[g]==cpu[c] && posC[c]!=1){
                                trov=true;
                                ris[r++]='x';
                                posC[c]=1;
                            }
                            c++;
                        }//while
                    }   //posO
                }//for
                return false;
            }
            else return true;
        }
        /// <summary>
        /// metodo di stampa
        /// </summary>
        public void StampaRis()
        {
            for (int c=0;c<5;c++)
            {
                Console.Write(ris[c]);
            }
            Console.WriteLine();
        }
        /// <summary>
        /// metodo di uscita
        /// </summary>
        /// <param name="vittoria"></param>
        public void Uscita(bool vittoria)
        {
            if (vittoria)
            {
                Console.WriteLine("Hai vinto!");
            } else 
            {
                Console.WriteLine("Hai perso");
            }
        }
        /// <summary>
        /// metoto richiesta se giocare ancora
        /// </summary>
        /// <returns></returns>
        public bool GiocaAncora()
        {
            string ret;
            Console.WriteLine("Giochi ancora? S=si o premi altro");
            ret =Console.ReadLine()!;
            return ret=="S";
        }
    }
}
