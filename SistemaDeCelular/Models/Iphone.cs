namespace DesafioPOO.Models
{

    public class Iphone : Smartphone
    {
        public Iphone(int numero, string modelo, int imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} em seu Iphone");
        }
    }
}