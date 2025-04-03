namespace Gestao_De_Equipamentos.ConsoleApp
{
    public class Equipamento
    {
        public int Id; //sempre sera unico 
        public string Nome;
        public string Fabricante;
        public decimal precoAquisicao;
        public DateTime DataDeFabricacao;

        public Equipamento(string nome, string Fabricante, decimal precoAquisicao, DateTime DataDeFabricacao)
        {
            Nome = nome;
            Fabricante = Fabricante;
            precoAquisicao = precoAquisicao;
            DataDeFabricacao = DataDeFabricacao;
        }


        //regra de negócio
        public string ObterNumeroSerie()
        {
            string tresPrimeirosCaracteres = Nome.Substring(0, 3).ToUpper(); //ABC = A=0,B=1,C=2 (SUBSTRING = RETORNA TUDO DEPOIS DESSE INDICE)


            return ($"{tresPrimeirosCaracteres}-{Id}");
        }

    }
}
