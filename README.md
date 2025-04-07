# Mastermind (Console Application)

Questo è un semplice gioco di Mastermind implementato in C# per la console.

## Come Giocare

L'obiettivo del gioco è indovinare una sequenza segreta di numeri generata dal computer.

1.  **Intro:** All'avvio, il programma visualizzerà un messaggio di benvenuto e spiegherà brevemente le regole.
2.  **Generazione del Codice Segreto:** Il computer genererà un codice segreto composto da una sequenza di numeri (la lunghezza e l'intervallo dei numeri sono definiti all'interno della classe `Mastermind`).
3.  **Tentativi:** Hai un massimo di 10 tentativi per indovinare il codice segreto.
4.  **Inserimento del Tentativo:** A ogni tentativo, ti verrà richiesto di inserire una sequenza di numeri separati da spazi.
5.  **Feedback:** Dopo ogni tentativo, il programma ti fornirà un feedback basato sul tuo tentativo:
    * **Punti Neri (neri):** Indicano il numero di cifre che hai indovinato correttamente sia nel valore che nella posizione.
    * **Punti Bianchi (bianchi):** Indicano il numero di cifre che hai indovinato correttamente nel valore, ma che si trovano in una posizione errata.
6.  **Vittoria:** Se indovini l'intera sequenza segreta entro i 10 tentativi, vinci la partita.
7.  **Sconfitta:** Se esaurisci i 10 tentativi senza indovinare il codice, il gioco termina e il codice segreto ti verrà rivelato.
8.  **Gioca Ancora:** Al termine di una partita (vittoria o sconfitta), ti verrà chiesto se desideri giocare ancora.

## Struttura del Programma

Il programma è composto principalmente da due classi:

* **`Program`:** Contiene il punto di ingresso principale (`Main` method) dell'applicazione. Gestisce il ciclo di gioco principale, inclusa l'introduzione,
* il loop dei tentativi e la gestione della fine della partita e della possibilità di rigiocare.
* **`Mastermind` ( definita nel namespace `game`):** Questa classe contiene la logica di gioco vera e propria, inclusi:
    * La generazione del codice segreto.
    * La richiesta dell'input dell'utente.
    * Il confronto del tentativo dell'utente con il codice segreto.
    * Il calcolo e la stampa del feedback (punti neri e bianchi).
    * La verifica della condizione di vittoria.
    * La gestione dell'introduzione e dell'uscita dal gioco.
    * La gestione della possibilità di giocare ancora.

## Requisiti

* .NET SDK (Software Development Kit) installato sul tuo sistema per compilare ed eseguire l'applicazione C#.

## Come Eseguire

1.  **Salva i file:** Assicurati di aver salvato il codice fornito (il file `Program.cs`) e il file contenente la classe `Mastermind`
2.  (`Mastermind.cs` all'interno di una cartella `game`) nella stessa directory o in una struttura di directory conforme al namespace.
3.  **Apri il terminale o la riga di comando:** Naviga fino alla directory contenente i file del progetto.
4.  **Compila il progetto:** Esegui il seguente comando per compilare l'applicazione:
    ```bash
    dotnet build
    ```
5.  **Esegui l'applicazione:** Dopo la compilazione riuscita, esegui l'applicazione con il comando:
    ```bash
    dotnet run
    ```
6.  Segui le istruzioni visualizzate nella console per giocare.

## Note

* Questo è un'implementazione di base del gioco Mastermind in console.
* La logica specifica per la generazione del codice segreto, la richiesta del numero, il confronto e la stampa dei risultati si trova all'interno della classe `Mastermind`.
* Il numero di cifre nel codice segreto e l'intervallo dei numeri possono essere configurati modificando la classe `Mastermind`.

Buon divertimento!
