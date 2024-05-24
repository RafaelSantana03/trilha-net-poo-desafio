using DesafioPOO.Models;

//Realizando os testes das classes
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("\n## Smartphone Nokia ##");
Console.ResetColor();
Smartphone nokia = new Nokia("123456", "Nokia Lumia", "644214278257768", 64);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");

Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("\n## Smartphone Iphone ##");
Console.ResetColor();
Smartphone iphone = new Iphone("987654", "Iphone 13", "460968337021560", 128);

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");