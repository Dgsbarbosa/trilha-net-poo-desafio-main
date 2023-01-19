using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");

//Console.WriteLine();
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "1111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");
Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone: ");
Smartphone iphone = new Iphone(numero: "123456", modelo: "Modelo 2", imei: "1111111111", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");
