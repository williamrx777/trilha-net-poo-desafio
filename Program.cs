using DesafioPOO.Models;

// Testando Nokia
Nokia nokia = new Nokia(numero: "123456", modelo: "Model 1", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

// Testando iPhone
Iphone iphone = new Iphone(numero: "4987555", modelo: "Model 2", imei: "222222222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");

