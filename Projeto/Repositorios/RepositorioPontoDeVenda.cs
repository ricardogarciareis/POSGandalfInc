namespace Projeto.Lib.Repositorios
{
    //public class RepositorioPontoDeVenda : IRepositorio<PontoDeVenda>
    //{
    //    private List<PontoDeVenda> ListaPontosDeVenda;
    //    public RepositorioPontoDeVenda()
    //    {
    //        ListaPontosDeVenda = new List<PontoDeVenda>();
    //        var pontoDeVenda0 = new PontoDeVenda
    //        {

    //        };
    //        ListaPontosDeVenda.Add(pontoDeVenda0);

    //        var pontoDeVenda1 = new PontoDeVenda
    //        {

    //        };
    //        ListaPontosDeVenda.Add(pontoDeVenda1);

    //        var pontoDeVenda2 = new PontoDeVenda
    //        {

    //        };
    //        ListaPontosDeVenda.Add(pontoDeVenda2);
    //    }


    //    public void Apagar(PontoDeVenda obj)
    //    {
    //        ListaPontosDeVenda.Remove(obj);
    //    }

    //    public PontoDeVenda Atualizar(string nomeAntigo, string nomeNovo)
    //    {
    //        var temp = ObterPorNome(nomeAntigo);
    //        temp.Nome = nomeNovo;
    //        return temp;
    //    }

    //    public void Criar(PontoDeVenda obj)
    //    {
    //        ListaPontosDeVenda.Add(obj);
    //    }

    //    public PontoDeVenda ObterPorNome(string Nome)
    //    {
    //        var dadosPontoDeVenda = ListaPontosDeVenda
    //                            .Where(x => x.Nome == Nome)
    //                            .OrderByDescending(x => x.NIF)
    //                            .FirstOrDefault();
    //        return dadosPontoDeVenda;
    //    }

    //    public List<PontoDeVenda> ObterTodos()
    //    {
    //        return ListaPontosDeVenda;
    //    }
    //}
}
