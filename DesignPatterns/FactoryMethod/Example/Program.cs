using Example;

var documents = new List<Document>()
{
    new Frontend(),
    new Backend()
};

foreach (var doc in documents)
{
    Console.WriteLine($"{doc.GetType().Name}: \r");
    foreach (var page in doc.Pages)
    {
        Console.WriteLine($"{page.GetType().Name}\r");
    }
    Console.WriteLine("\n");
}