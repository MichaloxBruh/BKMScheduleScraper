// See https://aka.ms/new-console-template for more information
using static System.Net.WebRequestMethods;

string response_01;
string response_02;
string line_BKM;
string stopid_BKM;
string link_BKM = "";

//https://komunikacja.bialystok.pl/?page=przystanek&nrl=14&nrp=115&k=0&rozklad=

Console.WriteLine("Scrape a BKM or WE schedule?");
response_01 = Console.ReadLine();

//i'm sooooo stupid...
if (response_01 == "BKM");
{
    Console.WriteLine("Line Number");
    line_BKM = Console.ReadLine();

    Console.WriteLine("Stop ID");
    stopid_BKM = Console.ReadLine();
}
if (response_01 == "WE") ;
{
    Console.WriteLine("Wschód Express doesn't work currently, sorry!");
}


static void WebScrape(string line, string stop_id, string service_operator)
{


}