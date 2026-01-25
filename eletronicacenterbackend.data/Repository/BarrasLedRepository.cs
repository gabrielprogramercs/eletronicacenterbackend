using eletronicacenterbackend.data.Data;
using eletronicacenterbackend.data.Repository.Interface;
using eletronicacenterbackend.model.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eletronicacenterbackend.data.Repository
{
    public class BarrasLedRepository : IBarrasLedRepository
    {
        private readonly AppDbContext _context;

        public BarrasLedRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<barras_led>> GetAllAsync()
        {
            return await _context.BarrasLed.ToListAsync();
        }
    }
}
