using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsDefafioGaragem
{
    public class Caminhonete : Veiculo
    {
        private String Veiculo { get; set; }

        public Caminhonete(String veiculo, String placa, String horaEntrada, String dataEntrada) : base(placa, horaEntrada, dataEntrada)
        {
            Veiculo = veiculo;
        }

        public Caminhonete(String veiculo, String placa, String tempoPermanencia, double valorCobrado) : base(placa, tempoPermanencia, valorCobrado)
        {
            Veiculo = veiculo;
        }

        public override String dadosEntrada()
        {
            {
                String dados = Veiculo + ";" + Placa + ";" + HoraEntrada + ";" + DataEntrada;
                return dados;
            }
        }

        public override String dadosSaida()
        {
            {
                String dados = Veiculo + ";" + Placa + ";" + TempoPermanencia +"minutos"+ ";" + ValorCobrado;
                return dados;
            }
        }
    }
}
