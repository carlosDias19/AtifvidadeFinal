using DDD.Domain.AtividadeAulaContext;

namespace ApplicationService.Interface
{
    public interface IEstadoApplication
    {
        List<Estado> GetEstado();
        Estado GetEstadoById(int id);
        
    }
}
