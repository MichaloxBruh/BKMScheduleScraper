// See https://aka.ms/new-console-template for more information
using static System.Net.WebRequestMethods;
using HtmlAgilityPack;
using System.Reflection.Metadata;
using WebScrape;

string response_01;
string response_02;
string line_BKM = "";
string stopid_BKM = "";
//string link_BKM = "";
bool WE = false;
bool BKM = false;
var web = new HtmlWeb();
string url_BKM = String.Format("https://komunikacja.bialystok.pl/?page=przystanek&nrl=", line_BKM, "&nrp=", stopid_BKM, "&k=0&rozklad=");
var document_BKM = web.Load("https://komunikacja.bialystok.pl/?page=przystanek&nrl=line_BKM&nrp=stopid_BKM&k=0&rozklad="); //make the link thing!!!!
var nodes = document_BKM.DocumentNode.SelectNodes("/html/body/div/div[2]/div[1]/div[2]/div/table[2]/tbody/tr[position() >= 1 and position() <= 20]\r\n");    
//https://komunikacja.bialystok.pl/?page=przystanek&nrl=14&nrp=115&k=0&rozklad=

Console.WriteLine("Scrape a BKM or WE schedule?");
response_01 = Console.ReadLine();

//i'm sooooo stupid...
if (response_01 == "BKM");
{
    BKM = true;
    Console.WriteLine("Line Number");
    line_BKM = Console.ReadLine();

    Console.WriteLine("Stop ID");
    stopid_BKM = Console.ReadLine();
}
if (response_01 == "WE") ;
{
    Console.WriteLine("Wschód Express doesn't work currently, sorry!");
}


void WebScrape(string line, string stop_id, string service_operator)
{
    if (BKM == true) ;
    {
        List<Departure> episodes = new List<Departure>();
        foreach (var node in nodes)
        {
            // add a new Episode instance to
            // to the list of scraped data
            episodes.Add(new Departure()
            {
                OverallNumber = HtmlEntity.DeEntitize(node.SelectSingleNode("th[1]").InnerText)

            });

        }
    }    
}