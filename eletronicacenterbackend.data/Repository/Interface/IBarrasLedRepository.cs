using eletronicacenterbackend.model.Model;

namespace eletronicacenterbackend.data.Repository.Interface
{
    public interface IBarrasLedRepository
    {
        Task<List<barras_led>> GetAllAsync();
    }
}