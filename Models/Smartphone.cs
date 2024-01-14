namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama

        public string Modelo { get; private set; }
        public string Imei { get; private set; }
        public int Memoria { get; private set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        protected Smartphone(string numero)
        {
            Numero = numero;
        }

        public void Ligar()
        {
            Console.WriteLine($"Ligando para o contato {Numero}.");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine($"Recebendo ligação do contato {Numero}.");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}