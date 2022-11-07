namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public int Numero { get; set; }
        private string Modelo { get; set; }
        private int IMEI { get; set; }
        private int Memoria { get; set; }

        public Smartphone(int numero, string modelo, int imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}