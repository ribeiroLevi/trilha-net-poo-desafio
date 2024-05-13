using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123", modelo: "A", imei: "111111111111", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("WPP");

Console.WriteLine("///////////////////////////////////////");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "456", modelo: "B", imei: "22222222222222222", memoria: 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
