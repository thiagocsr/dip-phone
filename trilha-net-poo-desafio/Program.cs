using DesafioPOO.Models;

Nokia nokia = new Nokia("123456", "ModelX", "IMEI1", 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Youtube");


Iphone iphone = new Iphone("654321", "ModelY", "IMEI2", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Youtube");