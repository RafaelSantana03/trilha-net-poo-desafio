namespace DesafioPOO.Models;


public class Iphone : Smartphone
{
    //Constrtutor 
    public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
    {
    }

    //Sobrescrevendo o método "InstalarAplicativo"
    public override void InstalarAplicativo(string nomeApp)
    {
        Console.WriteLine($"Instalando o aplicativo \"{nomeApp}\" no Iphone ");
    }
}