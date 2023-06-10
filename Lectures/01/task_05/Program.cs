Console.WriteLine ("Введите своё имя");
string name = Console.ReadLine();
if (name.ToLower() == "юра")
{
    Console.WriteLine($"Приветствую повелитель тьмы, {name}");
}
else
{
    Console.WriteLine($"Падай в ниц, {name}");
}