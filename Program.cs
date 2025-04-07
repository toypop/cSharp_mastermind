using System;
using game;

public class Program
{
    public static void Main(string[] args)
    {
        int tent;             //contatore per numero di tentativi..max 10
        bool vittoria;        //vinci se vittoria = 1

        Mastermind myMastermind = new Mastermind();
        do 
        {
            tent=0;
            vittoria=false;
            myMastermind.Intro();
            while(tent<10 && !vittoria)
            {
                myMastermind.Init();
                myMastermind.RichiestaNumero();
                vittoria=myMastermind.LoopGame();
                myMastermind.StampaRis();
                tent+=1;
            }      
            myMastermind.Uscita(vittoria);
        } while (myMastermind.GiocaAncora());
    }
}
