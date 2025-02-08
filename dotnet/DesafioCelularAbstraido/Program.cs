using DesafioCelularAbstraido.Models;

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone("123456789", "Iphone 12", "123456789", 128);
iphone.Ligar();
iphone.InstalarAplicativo("Tik Tok");

Console.WriteLine("\nSmartphone Nokia:");
Smartphone nokia = new Nokia("987654321", "Nokia 3310", "987654321", 4);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");