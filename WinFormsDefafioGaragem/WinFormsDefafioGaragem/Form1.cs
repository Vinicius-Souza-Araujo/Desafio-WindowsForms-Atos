using System;
using System.Globalization;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using System.Collections;
using System.Xml.Linq;


namespace WinFormsDefafioGaragem
{
    public partial class Form1 : Form
    {
        private string nomeArquivoEntrada = "veiculosEntrada.dat";
        private string nomeArquivoSaida = "veiculosSaida.dat";
        private int cont;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEntrada_Click(object sender, EventArgs e)
        {
            maskedTextBoxHoraEntrada.Enabled = true;

            maskedTextBoxHoraSaida.Enabled = false;
            maskedTextBoxHoraSaida.Text = string.Empty;
            textBoxDataEntrada.Text = DateTime.Now.ToString("dd/MM/yyyy");
            textBoxDataSaida.Text = string.Empty;
        }

        private void buttonSaida_Click(object sender, EventArgs e)
        {
            maskedTextBoxHoraEntrada.Enabled = false;
            maskedTextBoxHoraSaida.Enabled = true;
            maskedTextBoxHoraEntrada.Text = string.Empty;
            textBoxDataSaida.Text = DateTime.Now.ToString("dd/MM/yyyy");
            textBoxDataEntrada.Text = string.Empty;
        }

        private void buttonEnviar_Click(object sender, EventArgs e)
        {

            TimeSpan limiteMinimo = TimeSpan.Parse("07:00");
            TimeSpan limiteMaximo = TimeSpan.Parse("20:00");


            ////////////////////////////////////////////////////Validando dados - inicio//////////////////////////////////////////////////////////////////////////
            if ((!maskedTextBoxHoraEntrada.MaskCompleted && !maskedTextBoxHoraSaida.MaskCompleted) || textBoxPlaca.Text == string.Empty || comboBoxVeiculo.Text == string.Empty)
            {
                MessageBox.Show("Termine de preencher os dados!");
                return;

            }


            if (maskedTextBoxHoraEntrada.Enabled)
            {
                if (DateTime.TryParseExact(maskedTextBoxHoraEntrada.Text, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime horaEntrada))
                {
                    if (horaEntrada.TimeOfDay < limiteMinimo || horaEntrada.TimeOfDay > limiteMaximo)
                    {
                        MessageBox.Show("A hora está fora do intervalo permitido (das 7h às 20h, todos os dias).");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Hora de entrada inválida. Digite no formato adequado!");
                    return;
                }

            }

            else if (maskedTextBoxHoraSaida.Enabled)
            {
                if (DateTime.TryParseExact(maskedTextBoxHoraSaida.Text, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime horaSaida))
                {
                    if (horaSaida.TimeOfDay < limiteMinimo || horaSaida.TimeOfDay > limiteMaximo)
                    {
                        MessageBox.Show("A hora está fora do intervalo permitido (das 7h às 20h, todos os dias).");
                        return;
                    }


                }
                else
                {
                    MessageBox.Show("Hora de saída inválida. Digite no formato adequado!");
                    return;
                }


            }


            ////////////////////////////////////////////////////Enviando dados de entrada //////////////////////////////////////////////////////////////////////////

            string[] linhasTextBoxHoraEntrada = textBoxMultiploEntrada.Text.Replace("\r\n", "\n").Split('\n');

            if (maskedTextBoxHoraEntrada.Enabled)
            {
                if (cont >= 50)
                {
                    MessageBox.Show("Garagem cheia! Não é possivel adicionar um novo veiculo!");
                    return;
                }


                List<string> placas = new List<string>();

                foreach (string linha in linhasTextBoxHoraEntrada)
                {
                    string linhaLimpa = linha.Trim();
                    string[] dados = linhaLimpa.Split(';');

                    if (dados.Length >= 2)
                    {
                        string placa = dados[1];
                        placas.Add(placa);

                    }

                }


                if (placas.Contains(textBoxPlaca.Text))
                {
                    MessageBox.Show("A placa informada já está cadastrada e por isso o veiculo não pode ser cadastrado!");
                    return;
                }


                List<string> listaLinhas = new List<string>(linhasTextBoxHoraEntrada);
                List<Veiculo> listaVeiculos = new List<Veiculo>();


                if (listaLinhas.Count > 0)
                {
                    foreach (string linha in listaLinhas)
                    {
                        string[] dados = linha.Split(';');

                        if (dados.Length >= 4)
                        {

                            string tipoVeiculo = dados[0];
                            string placa = dados[1];
                            string horaEntrada = dados[2];
                            string dataEntrada = dados[3];


                            if (tipoVeiculo == "carro")
                            {
                                Carro carro = new Carro(tipoVeiculo, placa, horaEntrada, dataEntrada);
                                listaVeiculos.Add(carro);
                            }
                            else if (tipoVeiculo == "caminhonete")
                            {
                                Caminhonete caminhonete = new Caminhonete(tipoVeiculo, placa, horaEntrada, dataEntrada);
                                listaVeiculos.Add(caminhonete);
                            }
                            else if (tipoVeiculo == "moto")
                            {
                                Moto moto = new Moto(tipoVeiculo, placa, horaEntrada, dataEntrada);
                                listaVeiculos.Add(moto);
                            }
                        }


                    }
                }



                if (comboBoxVeiculo.SelectedItem == "moto")
                {
                    Moto moto = new Moto(comboBoxVeiculo.SelectedItem.ToString(), textBoxPlaca.Text, maskedTextBoxHoraEntrada.Text, textBoxDataEntrada.Text);
                    listaVeiculos.Add(moto);
                    Persistencia.gravarArquivoVeiculosEntrada(listaVeiculos, nomeArquivoEntrada);


                    textBoxMultiploEntrada.AppendText(moto.dadosEntrada() + "\r\n");
                    cont++;
                    labelQuantidadeVagas.Text = cont.ToString();



                }
                else if (comboBoxVeiculo.SelectedItem == "carro")
                {
                    Carro carro = new Carro(comboBoxVeiculo.SelectedItem.ToString(), textBoxPlaca.Text, maskedTextBoxHoraEntrada.Text, textBoxDataEntrada.Text);
                    listaVeiculos.Add(carro);
                    Persistencia.gravarArquivoVeiculosEntrada(listaVeiculos, nomeArquivoEntrada);


                    textBoxMultiploEntrada.AppendText(carro.dadosEntrada() + "\r\n");
                    cont++;
                    labelQuantidadeVagas.Text = cont.ToString();
                }

                else
                {
                    Caminhonete caminhonete = new Caminhonete(comboBoxVeiculo.SelectedItem.ToString(), textBoxPlaca.Text, maskedTextBoxHoraEntrada.Text, textBoxDataEntrada.Text);
                    listaVeiculos.Add(caminhonete);
                    Persistencia.gravarArquivoVeiculosEntrada(listaVeiculos, nomeArquivoEntrada);


                    textBoxMultiploEntrada.AppendText(caminhonete.dadosEntrada() + "\r\n");
                    cont++;
                    labelQuantidadeVagas.Text = cont.ToString();
                }

            }

            ////////////////////////////////////////////////////Enviando dados de saida //////////////////////////////////////////////////////////////////////////

            if (maskedTextBoxHoraSaida.Enabled)
            {

                List<string> placas = new List<string>();
                List<string> tipoVeiculos = new List<string>();

                foreach (string linha in linhasTextBoxHoraEntrada)
                {
                    string linhaLimpa = linha.Trim();
                    string[] dados = linhaLimpa.Split(';');

                    if (dados.Length >= 2)
                    {
                        string tipoVeiculo = dados[0];
                        string placa = dados[1];
                        placas.Add(placa);
                        tipoVeiculos.Add(tipoVeiculo);
                    }

                }

                int placaPosicao;
                if (!placas.Contains(textBoxPlaca.Text))
                {
                    MessageBox.Show("Veiculo informado não se encontra cadastrado na garagem!");
                    return;
                }
                else
                {
                    placaPosicao = placas.IndexOf(textBoxPlaca.Text);
                }

                if (placas.Contains(textBoxPlaca.Text) && comboBoxVeiculo.SelectedItem.ToString() != tipoVeiculos[placaPosicao])
                {
                    MessageBox.Show("O tipo de veiculo está incorreto!");
                    return;
                }

                List<Veiculo> listaVeiculos = new List<Veiculo>();


                foreach (string linha in linhasTextBoxHoraEntrada)
                {
                    string linhaLimpa = linha.Trim();
                    string[] dados = linhaLimpa.Split(';');


                    if (dados.Length >= 4)
                    {

                        string veiculo = dados[0];
                        string placa = dados[1];
                        string horaEntrada = dados[2];
                        string dataEntrada = dados[3];

                        if (veiculo == "moto")
                        {
                            Moto Objveiculo = new Moto(veiculo, placa, horaEntrada, dataEntrada);
                            listaVeiculos.Add(Objveiculo);
                        }
                        else if (veiculo == "carro")
                        {
                            Carro Objveiculo = new Carro(veiculo, placa, horaEntrada, dataEntrada);
                            listaVeiculos.Add(Objveiculo);
                        }
                        else
                        {
                            Caminhonete Objveiculo = new Caminhonete(veiculo, placa, horaEntrada, dataEntrada);
                            listaVeiculos.Add(Objveiculo);

                        }
                    }

                }

                Veiculo veiculoEncontrado = null;


                for (int i = listaVeiculos.Count - 1; i >= 0; i--)
                {
                    Veiculo veiculo = listaVeiculos[i];
                    if (veiculo.Placa == textBoxPlaca.Text)
                    {

                        veiculoEncontrado = veiculo;
                        listaVeiculos.RemoveAt(i);
                        break;
                    }
                }


                if (veiculoEncontrado.DataEntrada == textBoxDataSaida.Text && DateTime.Parse(maskedTextBoxHoraSaida.Text) < DateTime.Parse(veiculoEncontrado.HoraEntrada))
                {
                    MessageBox.Show("A hora de saída não pode ser menor que a hora de entrada no mesmo dia.");
                    return;
                }


                Persistencia.gravarArquivoVeiculosEntrada(listaVeiculos, nomeArquivoEntrada);
                cont--;
                labelQuantidadeVagas.Text = cont.ToString();
                textBoxMultiploEntrada.Text = string.Empty;

                foreach (var veiculo in listaVeiculos)
                {
                    textBoxMultiploEntrada.AppendText(veiculo.dadosEntrada() + "\r\n");

                }


                veiculoEncontrado.HoraSaida = maskedTextBoxHoraSaida.Text;
                veiculoEncontrado.DataSaida = textBoxDataSaida.Text;



                veiculoEncontrado.CalcularValorAPagar();

                string[] linhasTextBoxHoraSaida = textBoxMultiploSaida.Text.Replace("\r\n", "\n").Split('\n');

                textBoxMultiploSaida.AppendText(veiculoEncontrado.dadosSaida() + "\r\n");
                List<string> listaLinhas = new List<string>(linhasTextBoxHoraSaida);


                List<Veiculo> listaVeiculos2 = new List<Veiculo>();


                if (listaLinhas.Count > 0)
                {
                    foreach (string linha in listaLinhas)
                    {
                        string[] dados = linha.Split(';');

                        if (dados.Length >= 4)
                        {

                            string tipoVeiculo = dados[0];
                            string placa = dados[1];
                            string tempoPermanencia = dados[2];
                            double valorCobrado = Double.Parse(dados[3]);


                            if (tipoVeiculo == "carro")
                            {
                                Carro carro = new Carro(tipoVeiculo, placa, tempoPermanencia, valorCobrado);
                                listaVeiculos2.Add(carro);
                            }
                            else if (tipoVeiculo == "caminhonete")
                            {
                                Caminhonete caminhonete = new Caminhonete(tipoVeiculo, placa, tempoPermanencia, valorCobrado);
                                listaVeiculos2.Add(caminhonete);
                            }
                            else if (tipoVeiculo == "moto")
                            {
                                Moto moto = new Moto(tipoVeiculo, placa, tempoPermanencia, valorCobrado);
                                listaVeiculos2.Add(moto);
                            }
                        }


                    }
                }

                listaVeiculos2.Add(veiculoEncontrado);
                MessageBox.Show("Veículo da placa: " + veiculoEncontrado.Placa + " permaneceu " + veiculoEncontrado.TempoPermanencia
                    + " minutos e deve pagar R$" + veiculoEncontrado.ValorCobrado);
                Persistencia.gravarArquivoVeiculosSaida(listaVeiculos2, nomeArquivoSaida);





            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            if (!File.Exists(nomeArquivoEntrada))
            {
                File.Create(nomeArquivoEntrada).Close();
            }

            if (!File.Exists(nomeArquivoSaida))
            {
                File.Create(nomeArquivoSaida).Close();
            }

            List<Veiculo> listaVeiculos = Persistencia.lerArquivoEntrada(nomeArquivoEntrada);

            if (listaVeiculos != null)
            {
                foreach (var veiculo in listaVeiculos)
                {
                    textBoxMultiploEntrada.AppendText(veiculo.dadosEntrada() + "\r\n");
                    cont++;
                    labelQuantidadeVagas.Text = cont.ToString();
                }
            }

            List<Veiculo> listaVeiculos2 = Persistencia.lerArquivoSaida(nomeArquivoSaida);

            if (listaVeiculos2 != null)
            {
                foreach (var veiculo in listaVeiculos2)
                {
                    textBoxMultiploSaida.AppendText(veiculo.dadosSaida() + "\r\n");

                }
            }

        }

        private void labelQuantidadeVagas_Click(object sender, EventArgs e)
        {

        }

        private void labelQuantidadeMax_Click(object sender, EventArgs e)
        {

        }
    }
}