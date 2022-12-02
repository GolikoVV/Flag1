using System;

while (true)
{
Console.WriteLine("Введите месяц на английском: ");

int month = int.Parse(Console.ReadLine());

Console.WriteLine((season)month + ": " + whatSeason((season)month));
}
string whatSeason(season month)
{
if (month <= (season)2 || month == (season)12) return "Winter";
if (month <= (season)5) return "Spring";
if (month <= (season)8) return "Summer";
if (month <= (season)11) return "Autumn";
else return "No";
}

enum season
{
    January = 1,
    February,
    March,
    April,
    May,
    June,
    July,
    August,
    September,
    October,
    November,
    December
}