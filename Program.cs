using DesafioPOO.Models;
Console.WriteLine("Celular Nokia");
Nokia n = new Nokia("1234", "winphone", "1321321312", 8);
n.Ligar();
n.InstalarAplicativo("Instagram");


Console.WriteLine("\n");

Console.WriteLine("Iphone");
Iphone i = new Iphone("434223", "Iphone 11", "132135654312", 8);
i.ReceberLigacao();
i.InstalarAplicativo("Youtube");

// TODO: Realizar os testes com as classes Nokia e Iphone