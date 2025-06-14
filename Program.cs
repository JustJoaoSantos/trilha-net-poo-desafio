using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Nokia nokia = new Nokia("(71)92244-4422", "Galaxy 2", "2222222", 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\nSmartphone Iphone");
Iphone iphone = new Iphone("(71)91122-2211", "Iphone 4", "3333333", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");