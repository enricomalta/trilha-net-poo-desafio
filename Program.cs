using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        Smartphone nokia = new Nokia(numero: "11999999999", modelo: "Nokia 3310", imei: "123456789", memoria: 32);
        Smartphone iphone = new Iphone(numero: "11988888888", modelo: "iPhone 13", imei: "987654321", memoria: 128);

        nokia.Ligar();
        nokia.InstalarAplicativo("WhatsApp");

        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}