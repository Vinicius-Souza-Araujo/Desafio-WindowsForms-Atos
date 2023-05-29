using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text;

namespace WinFormsDefafioGaragem
{
    internal class Persistencia
    {

        public static void gravarArquivoVeiculosEntrada(List<Veiculo> lista, string nomeArquivo)
        {
            try
            {
                StreamWriter escritor = new StreamWriter(nomeArquivo); 

                foreach (var item in lista)
                {
                    escritor.WriteLine(item.dadosEntrada());
                    escritor.Flush();
                }
                escritor.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Problemas com arquivo");
            }
        }

        public static List<Veiculo> lerArquivoEntrada(string nomeArquivo)
        {
            try
            {
                StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8);
                string[] vetorLinha;
                string linha;
                List<Veiculo> listaVeiculos = new List<Veiculo>();
                do
                {
                    linha = leitor.ReadLine();

                    if (string.IsNullOrEmpty(linha))
                    {
                        continue; 
                    }
                    vetorLinha = linha.Split(";");


                    if(vetorLinha[0] == "moto") {
                        Moto moto = new Moto(vetorLinha[0], vetorLinha[1], vetorLinha[2], vetorLinha[3]);
                        listaVeiculos.Add(moto);
                    }

                    else if (vetorLinha[0] == "carro")
                    {
                        Carro carro = new Carro(vetorLinha[0], vetorLinha[1], vetorLinha[2], vetorLinha[3]);
                        listaVeiculos.Add(carro);
                    }
                    else
                    {
                        Caminhonete caminhonete = new Caminhonete(vetorLinha[0], vetorLinha[1], vetorLinha[2], vetorLinha[3]);
                        listaVeiculos.Add(caminhonete);
                    }

                } while (!leitor.EndOfStream);
                leitor.Close();

                return listaVeiculos;
            }
            catch (Exception)
            {
                Console.WriteLine("Problemas com arquivo");
                return null;
            }
        }


        public static void gravarArquivoVeiculosSaida(List<Veiculo> lista, string nomeArquivo)
        {
            try
            {
                StreamWriter escritor = new StreamWriter(nomeArquivo);

                foreach (var item in lista)
                {
                    escritor.WriteLine(item.dadosSaida());
                    escritor.Flush();
                }
                escritor.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Problemas com arquivo");
            }
        }


       

        public static List<Veiculo> lerArquivoSaida(string nomeArquivo)
        {
            try
            {
                StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8);
                string[] vetorLinha;
                string linha;
                List<Veiculo> listaVeiculos = new List<Veiculo>();
                do
                {
                    linha = leitor.ReadLine();

                    if (string.IsNullOrEmpty(linha))
                    {
                        continue;
                    }
                    vetorLinha = linha.Split(";");


                    if (vetorLinha[0] == "moto")
                    {
                        Moto moto = new Moto(vetorLinha[0], vetorLinha[1], vetorLinha[2], Double.Parse(vetorLinha[3]));
                        listaVeiculos.Add(moto);
                    }

                    else if (vetorLinha[0] == "carro")
                    {
                        Carro carro = new Carro(vetorLinha[0], vetorLinha[1], vetorLinha[2], Double.Parse(vetorLinha[3]));
                        listaVeiculos.Add(carro);
                    }
                    else
                    {
                        Caminhonete caminhonete = new Caminhonete(vetorLinha[0], vetorLinha[1], vetorLinha[2], Double.Parse(vetorLinha[3]));
                        listaVeiculos.Add(caminhonete);
                    }

                } while (!leitor.EndOfStream);
                leitor.Close();

                return listaVeiculos;
            }
            catch (Exception)
            {
                Console.WriteLine("Problemas com arquivo");
                return null;
            }
        }
    }
}
