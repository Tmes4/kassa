// See https://aka.ms/new-console-template for more information

using System;
using System.Net;
using System.Text;
using System.Security.Cryptography.X509Certificates;

Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("========== PyReg ===========");
Console.WriteLine("\"Welkom bij PyReg, het Python KassaSysteem voor en door DeveloperLand!");
Console.WriteLine("Tel de kassa, en geef op hoeveel er nu in zit");

Console.Write("Bedrag in Kassa? ");
float bedragInKassa = float.Parse(Console.ReadLine());

string keuze = "0";
double dagTotaal = 0;
int aantalBonnen = 1;
double dagTotaalTerug = 0;
double inKassa = 0;

while (keuze != "9")
{
    Console.Clear();
    Console.WriteLine("======== HOOFDMENU =========");
    Console.WriteLine("1. Nieuwe bon");
    Console.WriteLine("2. Retour");
    Console.WriteLine("3. Toon kassatotaal");
    Console.WriteLine("9. Afsluiten");
    Console.WriteLine("============================");

    Console.Write("Maak uw keuze en druk op <ENTER>.");
    keuze = Console.ReadLine();

    if (keuze == "1")
    {
        string bestelKeuze = "0";
        double bonTotaal = 0;
        string bonString = "";

        while (keuze != "9")
        {

            Console.Clear();
            Console.WriteLine("========= BON MENU =========");
            Console.WriteLine("Bon " + aantalBonnen);
            Console.WriteLine("1. Volwassen                      € 19,-");
            Console.WriteLine("2. Kinderen tot 12jr              € 9,-");
            Console.WriteLine("4. DeveloperLand-kaart            € 4,50");
            Console.WriteLine("3. Familiepas (2x volw. 3x kind)  € 49,-");
            Console.WriteLine("5. Kinderwagen/bolderkar (1 dag)  € 6,-");
            Console.WriteLine("6. Parkeerdagkaart                € 9,-");
            Console.WriteLine("9. Afronden bon");
            Console.WriteLine("Z. Bon annuleren");
            Console.WriteLine("============================");
            Console.Write("Maak uw keuze en druk op <ENTER>.\n");
            bestelKeuze = Console.ReadLine();

            if (bestelKeuze == "1")
            {
                bonTotaal = bonTotaal + 19;
                bonString = bonString + "1x Volwassen                  € 19\r\n";
            }

            else if (bestelKeuze == "2")
            {
                bonTotaal = bonTotaal + 9;
                bonString = bonString + "1x kind (tot 12jr)             € 9\r\n";
            }

            else if (bestelKeuze == "3")
            {
                bonTotaal = bonTotaal + 49;
                bonString = bonString + "1x Familiepas                  € 49\r\n";
            }

            else if (bestelKeuze == "4")
            {
                bonTotaal = bonTotaal + 4; //fix dit//
                bonString = bonString + "1x Parkkaart                  € 4,50\r\n";
            }
            
            else if (bestelKeuze == "5")
            {
                bonTotaal = bonTotaal + 6;
                bonString = bonString + "1x kinderwagen/bolderkarhuur   € 6\r\n";
            }

            else if (bestelKeuze == "6")
            {
                bonTotaal = bonTotaal + 9;
                bonString = bonString + "1x Parkeerdagkaart             € 9\r\n";
            }

            else if (bestelKeuze == "9")
            {
                aantalBonnen = aantalBonnen + 1;
                dagTotaal = dagTotaal + bonTotaal;
                Console.WriteLine(bonString);
                Console.WriteLine("\"======== BON TOTAAL ========");
                Console.WriteLine("Te betalen: " + bonTotaal);
                Console.Write("Betaald:  ");
                double betaald = float.Parse(Console.ReadLine());
                Console.WriteLine(betaald);
                double terug = betaald - bonTotaal;
                Console.WriteLine("Terug:   " + terug);
                Console.WriteLine("Druk op <ENTER> om door te gaan.");
                Console.ReadLine();
                Console.WriteLine("Hoeveel zit er nu in de kassa?");
                inKassa = float.Parse(Console.ReadLine());
            }
            
            else if (bestelKeuze == "z" || bestelKeuze == "Z")
            {
                bonTotaal = 0;
                bonString = "";
                break;
            }
        }

    }

    else if (keuze == "2")
    {
        Console.WriteLine("Uitvoeren terugbetaling");
        Console.Write("Bedrag originele bon:");
        double terugGeven = double.Parse(Console.ReadLine());
        Console.Write("Reden retour: ");
        string reden = Console.ReadLine();
        dagTotaalTerug = terugGeven;
    }

    else if (keuze == "3")
    {
        Console.WriteLine("======= DAG TOTALEN ========");
        Console.WriteLine("In kassa begin: " + bedragInKassa);
        Console.WriteLine("verkocht: " + dagTotaal);
        Console.WriteLine("Retour: " + dagTotaalTerug);
        Console.WriteLine("In Kassa: " + (bedragInKassa + dagTotaal + dagTotaalTerug));
        Console.WriteLine("Druk op <ENTER> om door te gaan.");
        Console.ReadLine();
        


        while (!(inKassa == (bedragInKassa + dagTotaal + dagTotaalTerug)))
        {
            Console.WriteLine("Je hebt een kassaverschil! Tel de kassa opnieuw");
            Console.WriteLine("Hoeveel zit er nu in de kassa?");
            inKassa = double.Parse(Console.ReadLine());
        }
        Console.Clear();

        Console.WriteLine("Kassa klpot, programma wordt afgesloten.");
        Console.WriteLine("======== DAGTOTALEN ========");
        Console.WriteLine("Aantal bonnen:   " + aantalBonnen);
        Console.WriteLine("Verkocht:    " + dagTotaal);
        Console.WriteLine("Totaal retour: " + dagTotaalTerug);
        Console.WriteLine("In kassa:    " + inKassa);
        Console.WriteLine("============================");


    }


    



    }







