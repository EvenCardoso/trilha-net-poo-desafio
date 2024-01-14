namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
       public Nokia(string numero, string modelo, string imei, int memoria) : base(numero)
    }

      {
            Console.WriteLine($"Instalando aplicativo {nomeApp} no Nokia.");
        }
}