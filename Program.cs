using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia = new Nokia("13996830085", "Nokia 2", "00131239012", "64");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");

Iphone iphone = new Iphone("13996830085", "Nokia 2", "00131239012", "64");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Skype");
