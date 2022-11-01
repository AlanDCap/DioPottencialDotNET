namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (hospedes.Count() < Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception ("A quantidade de hóspedes é superior à capacidade da suíte");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            int qtdHospedes = Hospedes.Count();           
            return qtdHospedes;
        }

        public decimal CalcularValorDiaria()
        {
            decimal custoEstadia = DiasReservados * Suite.ValorDiaria;
            
            if (DiasReservados >= 10)
            {
                custoEstadia *= 0.90M;
            }
            return custoEstadia;
        }
    }
}