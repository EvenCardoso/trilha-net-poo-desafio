using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "0111647496", modelo: "Modelo 9", imei: "0011506465", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("spotify");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone: ");
Smartphone iphone = new Iphone(numero: "121113", modelo: "Modelo 8", imei: "971374326", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Amazon Music");