using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            prenotazioni prenotazione = new prenotazioni();
            prenotazione.numeroprogressivo = 1;
            prenotazione.anno = 2023;
            Clienti cliente = new Clienti();    
            cliente.cognome = "Ragazzi";
            cliente.nome = "Rebecca";
            prenotazione.dataprenotazione = new DateTime(2023, 3, 11, 0, 0, 0);
            Console.WriteLine("La prenotazione numero {0}, dell'anno {1}, del cliente {2} {3}, del giorno {4}",
                prenotazione.numeroprogressivo, prenotazione.anno,cliente.cognome, cliente.nome, prenotazione.dataprenotazione);

            prenotazione.caparra = 200;
            prenotazione.tariffa = 400;
            Servizi servizio = new Servizi();
            servizio.prezzo = 30;
            servizio.descrizione = "Colazione in camera";
            servizio.quantità = 2;
            Console.WriteLine("La prenotazione numero {0} deve pagare una caparra di {1} , il stabilito è {2}, il prezzo aggiuntivo per i servizi di {3} per {4} persone  è {5}, il prezzo totale è {6}",
                prenotazione.numeroprogressivo, prenotazione.caparra, prenotazione.tariffa,servizio.descrizione,servizio.quantità, servizio.prezzo, prenotazione.caparra + prenotazione.tariffa + servizio.prezzo);
            Console.ReadLine(); 
        }
    }
}
