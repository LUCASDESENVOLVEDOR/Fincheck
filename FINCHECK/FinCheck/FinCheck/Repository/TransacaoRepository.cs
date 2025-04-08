using FinCheck.Models;
using Microsoft.EntityFrameworkCore;

namespace FinCheck.Repository
{
    public class TransacaoRepository : ITransacaoRepository
    {
        private readonly FinchekContext _context;

        public TransacaoRepository(FinchekContext context)
        {
            _context = context;
        }


        public async Task<Transacao> AdicionarAsync(Transacao transacao)
        {
            _context.Entry(transacao).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return transacao;
        }

        public async Task<Boolean> ExcluirAsync(int id)
        {
            var transacao = await _context.Transacoes.FindAsync(id);

            if (transacao == null) 
                return false;

            _context.Transacoes.Remove(transacao);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<Transacao> ObterPorIdAsync(int id)
        {
            return await _context.Transacoes.FindAsync(id);
        }

        public async Task<IEnumerable<Transacao>> ObterTodasAsync()
        {
            return await _context.Transacoes.ToListAsync();
        }
    }
}
