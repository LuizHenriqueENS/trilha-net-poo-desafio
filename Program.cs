using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "12345678", modelo: "Modelo 1", imei: "11111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

System.Console.WriteLine();

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "87654321", modelo: "Modelo Plus X10", imei: "2222222222", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");