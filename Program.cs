// Counter
for (var i = 0; i < 10; i++)
{
  Console.WriteLine(i);
}
Console.WriteLine("\n");

for (var i = 0; i <= 10; i++)
{
  Console.WriteLine(i);
}
Console.WriteLine("\n");

for (var i = 1; i <= 10; i++)
{
  Console.WriteLine(i);
}
Console.WriteLine("\n");

string[] bestOrchestra = ["HOWASOM", "MUSON", "ELSH"];
// to iterate through using the conventional method
for(var i = 0; i < bestOrchestra.Length; i++)
{
  Console.WriteLine(bestOrchestra[i]);
}
Console.WriteLine("\n");
// Another way to iterate is using foreach
foreach (var item in bestOrchestra)
{
  Console.WriteLine(item);
}
Console.WriteLine("\n");
// A better way to iterate is using LINQ
bestOrchestra.ToList().ForEach((i) => {
  Console.WriteLine("ForEach through: " + i);
});
Console.WriteLine("\n");

// Another way that will actually act on Array
Array.ForEach(bestOrchestra, e => Console.WriteLine("Array.ForEach: " + e));