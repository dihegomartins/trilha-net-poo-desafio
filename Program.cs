using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "1234", modelo: "Modelo 1", imei: "11111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "5678", modelo: "Modelo 2", imei: "22222", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");