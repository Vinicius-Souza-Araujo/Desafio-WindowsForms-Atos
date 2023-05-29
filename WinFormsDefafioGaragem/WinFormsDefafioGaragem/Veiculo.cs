using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsDefafioGaragem
{
    public abstract class Veiculo
    {
        protected String _placa;
        protected String _horaEntrada;
        protected String _dataEntrada;
        protected String _horaSaida;
        protected String _dataSaida;

        protected String _tempoPermanencia;
        protected double _valorCobrado;

        public String Placa
        {
            get { return _placa; }
            set { _placa = value; }
        }

        public String HoraEntrada
        {
            get { return _horaEntrada; }
            set { _horaEntrada = value; }
        }

        public String DataEntrada
        {
            get { return _dataEntrada; }
            set { _dataEntrada = value; }
        }

        public String HoraSaida
        {
            get { return _horaSaida; }
            set { _horaSaida = value; }
        }

        public String DataSaida
        {
            get { return _dataSaida; }
            set { _dataSaida = value; }
        }

        public String TempoPermanencia
        {
            get { return _tempoPermanencia; }
            set { _tempoPermanencia = value; }
        }

        public double ValorCobrado
        {
            get { return _valorCobrado; }
            set { _valorCobrado = value; }
        }

        public Veiculo(String placa, String horaEntrada, String dataEntrada)
        {
            Placa = placa;
            HoraEntrada = horaEntrada;
            DataEntrada = dataEntrada;

           
        }

        public Veiculo(String placa,  String tempoPermanencia, double valorCobrado )
        {
            Placa = placa;
            TempoPermanencia = tempoPermanencia;
            ValorCobrado = valorCobrado;

        }

        public void CalcularValorAPagar()
        {
            DateTime entrada = DateTime.Parse($"{DataEntrada} {HoraEntrada}");
            DateTime saida = DateTime.Parse($"{DataSaida} {HoraSaida}");

            TimeSpan duracao = saida - entrada;
            int minutosEstacionado = (int)Math.Ceiling(duracao.TotalMinutes);
            int horasArredondadas = (int)Math.Ceiling(minutosEstacionado / 60.0);

            TempoPermanencia = minutosEstacionado.ToString();
            ValorCobrado = horasArredondadas * 5;



        }

        public abstract string dadosEntrada();
        public abstract string dadosSaida();



    }
}
