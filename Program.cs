using DesafioPOO.Models;
Console.WriteLine("---------------- SmartPhone Nokia -------------");
Smartphone nokia = new Nokia("123456", "Modelo 1", "111111111111", 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n\n");

Console.WriteLine("---------------- SmartPhone Iphone -------------");
Smartphone iphone = new Iphone("654321", "Modelo 2", "22222222222", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");

// TODO: Realizar os testes com as classes Nokia e Iphone