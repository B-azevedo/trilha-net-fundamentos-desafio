namespace DesafioFundamentos.Models
{
    internal class Veiculo
    {
        private string Placa;

        public Veiculo(string placa)
        {
            Placa = placa;

        }
        public override string ToString()
        {
            return Placa;
        }
    }
}