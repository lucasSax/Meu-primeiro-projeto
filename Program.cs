//  Conversor de moedas
//  Objetivo do programa: Fazer a conversão da moeda e do valor monetário solicitada pelo úsuario para moeda Real
// Moedas - Dólar, Euro, Real, Libra Esterlina e Real.
// Ler o tipo de conversão a escolha do Usuário ( moeda X para Real).
// Ler a cotação da moeda
// Ler o valor do montante que deseja converter.
// Fazer o calculo
// Exibir o resultado


using ExerConsole.Models;


string[] opcoesDeConversao = ["0- Encerrar", "1- Dólar/Real", " 2- Euro/Real", " 3- Libra/Real"];
Dictionary<string, string> nomeDasMoedasSeusSimbolos = new Dictionary<string, string>();
nomeDasMoedasSeusSimbolos.Add("Dólar", "US$");
nomeDasMoedasSeusSimbolos.Add("Euro", "€");
nomeDasMoedasSeusSimbolos.Add("Libra", "£");
string moeda = " ";

Converter conv = new Converter();

inicio:
Menu();
Console.Clear();
Console.WriteLine($"Opção escolhida:  {opcoesDeConversao[conv.Escolha]}\n");
UsandoValorEscolhido();
goto inicio;

void Menu()
{
  Console.Clear();
  Console.WriteLine("\n         ======== 𝕮𝖔𝖓𝖛𝖊𝖗𝖘𝖔𝖗 𝖉𝖊 𝖒𝖔𝖊𝖉𝖆𝖘 ========");
  Console.WriteLine("\nSeja Bem-vindo :)\n");

  Console.WriteLine("Escolha o tipo de conversão que deseja realizar:\n" +
$"{opcoesDeConversao[1]}   {opcoesDeConversao[2]}    {opcoesDeConversao[3]}     {opcoesDeConversao[0]}");
  conv.Escolha = Convert.ToInt32(Console.ReadLine());
}

void UsandoValorEscolhido()
{
  switch (conv.Escolha)
  {
    case 1:

      moeda = "Dólar";
      Menssagem(moeda);
      break;
    
    case 2:
      moeda = "Euro";
      Menssagem(moeda);

      break;

    case 3:
      moeda = "Libra";
      Menssagem(moeda);
      break;

    case 0:
      Console.Clear();
      Console.WriteLine("Hasta lá vista, baby!");
      Thread.Sleep(3000);
      Environment.Exit(0);
      break;
  }
}

void Menssagem(string moeda)
{

  Console.Write($"Digite a cotação do {moeda}: " + nomeDasMoedasSeusSimbolos[moeda] + " ");
  conv.CotacaoDaMoeda = decimal.Parse(Console.ReadLine()!.Replace('.', ','));
  Console.Write($"Digite o valor do montante: " + nomeDasMoedasSeusSimbolos[moeda] + " ");
  conv.ValorDoMontante = decimal.Parse(Console.ReadLine()!.Replace('.', ','));
  Console.WriteLine("O Montante de " + nomeDasMoedasSeusSimbolos[moeda] + " " + conv.ValorDoMontante +
   " convertido em Real vale: " +
  conv.CalculoDeConversao().ToString("C"));
  Console.WriteLine("\n\nDigite qualquer tecla para voltar ao Menu.");

  if(Console.ReadKey().Key.ToString() != string.Empty )
      return;

     
}









