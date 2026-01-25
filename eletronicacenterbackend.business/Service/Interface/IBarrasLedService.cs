using eletronicacenterbackend.model.Model;

namespace eletronicacenterbackend.business.Service.Interface
{
    public interface IBarrasLedService
    {
        Task<List<barras_led>> GetAllBarrasLed();
    }
}