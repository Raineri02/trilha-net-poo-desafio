using System.ComponentModel;
using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo1", imei: "111111", memoria: 64);
nokia.Ligar();

Console.WriteLine("/n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "4987", modelo: "Modelo2", imei:"2222222", memoria:128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");