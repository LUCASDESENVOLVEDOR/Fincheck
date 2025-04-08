using FinCheck.Models;
using FinCheck.Repository;

namespace FinCheck.Services
{
    public class TransacaoService : ITransacaoService
    {

        private readonly ITransacaoRepository _repository;

        public TransacaoService(ITransacaoRepository repository)
        {
            _repository = repository;
        }

        public async Task<Transacao> AdicionarAsync(Transacao transacao)
        {
            return await _repository.AdicionarAsync(transacao);
        }

        public Task<bool> ExcluirAsync(int id)
        {
           return _repository.ExcluirAsync(id);
        }

        public Task<Transacao> ObterPorIdAsync(int id)
        {
            return _repository.ObterPorIdAsync(id);
        }

        public Task<IEnumerable<Transacao>> ObterTodasAsync()
        {
            return _repository.ObterTodasAsync();
        }
    }
}
