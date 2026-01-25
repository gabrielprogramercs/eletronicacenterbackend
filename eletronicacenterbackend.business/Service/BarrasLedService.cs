using eletronicacenterbackend.business.Service.Interface;
using eletronicacenterbackend.data.Repository.Interface;
using eletronicacenterbackend.model.Model;

namespace eletronicacenterbackend.business.Service
{
    public class BarrasLedService : IBarrasLedService
    {
        private readonly IBarrasLedRepository _repository;

        public BarrasLedService(IBarrasLedRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<barras_led>> GetAllBarrasLed()
        {

            return await _repository.GetAllAsync();
        }

       
    }
}
