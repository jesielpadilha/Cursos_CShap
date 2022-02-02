﻿using Microsoft.EntityFrameworkCore;
using NSE.Core.Data;
using NSE.Pedido.Domain.Vouchers;

namespace NSE.Pedido.Infra.Data.Repositories
{
    public class VoucherRepository : IVoucherRepository
    {
        private readonly PedidosContext _context;

        public VoucherRepository(PedidosContext context)
        {
            _context = context;
        }

        public IUnitOfWork UnitOfWork => _context;

        public async Task<Voucher> ObterVoucherPorCodigo(string codigo)
        {
            return await _context.Vouchers.FirstOrDefaultAsync(p => p.Codigo == codigo);
        }

        public void Atualizar(Voucher voucher)
        {
            _context.Vouchers.Update(voucher); 
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}