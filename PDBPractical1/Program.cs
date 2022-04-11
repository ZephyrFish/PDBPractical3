using PDBPractical1.ObserverViaEvents;
using PDBPractical1.StrategyViaDelegates;

Console.WriteLine("Задание 1: стратегия.");
var arr = new[,]
{
    { 1, 1, 4, 9 },
    { 10, 4, 2, 0 },
    { 8, 5, 14, 2 }
};
Console.WriteLine("\nМассив в исходном виде: ");
arr.Print();

// Сортировка по убыванию минимального элемента.
arr = arr.SortRows((x, y) => x < y, 
    (x, y) => x < y ? x : y);

Console.WriteLine("\nМассив после сортировки: ");
arr.Print();

Console.ReadKey();
Console.Clear();

Console.WriteLine("Задание 2: наблюдатель.");

Countdown timer = new();

var sub1 = new Subscriber(timer, "Rufus");
var sub2 = new Subscriber(timer, "Bisya");

Console.WriteLine("Something happens...");
timer.ItHappens(1000);
