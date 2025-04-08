using FinCheck.Models;

namespace FinCheck.Repository
{
    public interface ITransacaoRepository
    {  
        //Define uma tarefa assincrona que retorna todas as transacoes.
        Task<IEnumerable<Transacao>> ObterTodasAsync();

        //Define uma tarefa assincrona que uma retorna uma transacao
        Task<Transacao> ObterPorIdAsync( int id );

        Task<Transacao> AdicionarAsync(Transacao transacao);
        Task<Boolean> ExcluirAsync(int id);



    }
}
