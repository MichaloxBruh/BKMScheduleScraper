// See https://aka.ms/new-console-template for more information
string response_01;
string response_02;
string line_BKM;

Console.WriteLine("Scrape a BKM or WE schedule?");
response_01 = Console.ReadLine();

//i'm sooooo stupid...
if (response_01 == "BKM");
{
    Console.WriteLine("Line Number");
    line_BKM = Console.ReadLine();
}
if (response_01 == "WE") ;
{
    Console.WriteLine("Wschód Express doesn't work currently, sorry!");
}