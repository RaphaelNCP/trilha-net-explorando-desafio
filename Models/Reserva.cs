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
            bool eAlocavel = Suite.Capacidade == hospedes.Count 
            if (eAlocavel)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("Capacidade menor que o número de hóspedes!");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            int quantidadeDeHospedes = Hospedes.Count;
            return quantidadeDeHospedes;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valorDiaria = DiasReservados * Suite.ValorDiaria;
            decimal valor = valorDiaria:c;
            bool eMaiorOuIgualADez = DiasReservados >= 10;
            if (eMaiorOuIgualADez)
            {
                valor = valor - (valor * 0.10);
            }

            return valor;
        }
    }
}