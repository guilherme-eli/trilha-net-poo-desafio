using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
class Program 
{
    static void Main(string[] args)
    {
        // Criar instâncias de Nokia e Iphone
        Smartphone meuNokia = new Nokia("123456", "Nokia 3310", "111111111111111", 64);
        Smartphone meuIphone = new Iphone("654321", "iPhone X", "222222222222222", 256);

        // Usar os métodos das instâncias
        meuNokia.Ligar();
        meuNokia.InstalarAplicativo("WhatsApp");

        meuIphone.ReceberLigacao();
        meuIphone.InstalarAplicativo("Instagram");
    }
}



