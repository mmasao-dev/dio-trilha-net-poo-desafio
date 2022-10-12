using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

using static System.Console;


WriteLine("Smartphone Nokia:");
var n = new Nokia("999999999", "Modelo2020", "244466666", 256);
n.Ligar();
n.InstalarAplicativo("Whatsapp");

WriteLine();

WriteLine("Smartphone Iphone:");
var i = new Iphone("888888888", "versao2020 ", "987654321", 128);
i.ReceberLigacao();
i.InstalarAplicativo("Whatsapp");