![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)

# Desafio-WindowsForms-Atos

=================================================================

Construir um sistema em Visual Studio, C# e com Windows Form para entrada, saídas de veículos e as devidas cobranças.

A dinâmica de funcionamento da garagem é:

1) das 7h às 20h, todos os dias;
2) há 50 vagas para veículos (carros, caminhonetes e motos). Assim, quando a garagem lotar, só entra próximo
   veículo se outro sair;
3) o valor da hora é R$ 5,00. Neste desafio, não será realizado/processado nada caso o veículo não seja retirado
   até às 20h. Se o veículo passar 1 minuto da hora, é cobrado a hora cheia. Por exemplo, tempo de 
   permanência 123 minutos (2h e 3min), o sistema deverá cobrar por 3 horas;
4) há uma interface gráfica para o porteiro lançar a PLACA do veículo e indicar se é uma ENTRADA ou SAÍDA.
   Neste sistema, é o porteiro que indica a hora de entrada e a hora de saida. A data é capturada automaticamente;
5) na interface gráfica, há um label para a data e outro para hora (para que o porteiro possa informar-se)
6) na interface gráfica, há duas regiões (textBox de múltiplas linhas ou outro componenete que desear), 
   uma para a lista dos veículos que estão na garagem, e outra para a lista dos veículos que saíram da garagem.
7) na interface gráfica, a lista de veículos que estão na garagem deve conter:
    placa - dataEntrada - horaEntrada
8) na interface gráfica, a lista de veículos que saíram da garagem deve conter:
    placa - tempoPermanencia - valorCobrado

    O tempo de permanencia deve ser em minutos

9) toda vez que o porteiro lançar a placa como ENTRADA de veículo, o sistema deve adicionar a placa do veículo, dataEntrada e horaEntrada na lista de veículos de entrada (List, textBox e arquivo). 

10) toda vez que o porteiro lançar a placa como SAÍDA de veículo, o sistema deve calcular o valor e mostrar isso em uma MessageBox (MessageBox.Show()) e adicionar a placa, tempoPermanencia e valor cobrado na lista de 
veículos de saída (List, textBox e arquivo);

Para persistência dos dados vamos utilizar:
1) Veículos que estão na garagem: TextBox (multiplas linhas) + List<Veiculos> + arquivo (veiculosEntrada.dat)
   O conteúdo do arquivo veiculosEntrada.dat deve conter os dados organizados:
   placa;dataEntrada;horaEntrada

   Por exemplo, 
   IPL7154;09/06/2022;19:52


2) Veículos que saíram da garagem: TextBox (multiplas linhas) + List<Veiculos> + arquivo (veiculosSaida.dat)
   O conteúdo do arquivo veiculosSaida.dat deve conter os dados organizados:
   placa;dataEntrada;horaEntrada;tempoPermanecia;valorCobrado

   Por exemplo, placa; 62 minutos ou 2 horas; 10 reais
   IPL7154;11/06/2022;12:34;62;10

Para o Classe Veiculo:
atributos: placaVeiculo, dataEntrada, horaEntrada, tempoPermanencia, valorCobrado
métodos: construtor só com placaVeiculo, dataEntrada, horaEntrada; getters e setters

Para a Classe de Persistencia:
métodos de classe: l
    erArquivoVeiculosEntrada(); lerArquivoVeiculosSaida(); 
    gravarArquivoVeiculosEntrada(); gravarArquivoVeiculosSaida();
