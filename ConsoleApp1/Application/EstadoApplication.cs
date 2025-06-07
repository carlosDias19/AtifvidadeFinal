using ApplicationService.Interface;
using DDD.Domain.AtividadeAulaContext;
using DomainService.Interface;

namespace ApplicationService.Application
{
    public class EstadoApplication : IEstadoApplication
    {
        public readonly IEstadoService _estadoService;

        public EstadoApplication(IEstadoService estadoService)
        {
            _estadoService = estadoService;
        }
        public List<Estado> GetEstado()
        {
            return _estadoService.GetEstado();
        }

        public Estado GetEstadoById(int id)
        {
            return _estadoService.GetEstadoById(id);
        }

    }
}
