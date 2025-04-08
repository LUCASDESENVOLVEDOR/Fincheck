using FinCheck.Models;

namespace FinCheck.Services
{
    public interface ITransacaoService
    {
        Task<IEnumerable<Transacao>> ObterTodasAsync();      
        Task<Transacao> ObterPorIdAsync(int id);
        Task<Transacao> AdicionarAsync(Transacao transacao);
        Task<Boolean> ExcluirAsync(int id);
    }
}
