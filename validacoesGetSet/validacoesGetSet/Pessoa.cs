namespace validacoesGetSet
{
    internal class Pessoa
    {
        private string? _nome;
        private int _idade;
        public string Nome
        {
            get => _nome;

            set
            {
                if (value == null || value == "")
                {
                    throw new ArgumentNullException("O nome não pode ser vazio");
                }
                _nome = value.ToUpper();
            }
        }
        public int Idade
        {
            get => _idade;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que zero");
                }
                _idade = value;
            }
        }
    }
}
