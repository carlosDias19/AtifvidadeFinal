using DDD.Domain.AtividadeAulaContext;

namespace ApplicationService.Interface
{
    public interface IPontoTuristicoApplication
    {
        void DeletePontoTuristico(int Id);
        List<PontoTuristico> GetPontoTuristico();
        PontoTuristico GetPontoTuristicoById(int id);
        void InsertPontoTuristico(PontoTuristico pontoTuristico);
        void UpdatePontoTuristico(PontoTuristico pontoTuristico);
        List<PontoTuristico> BuscarPorNomeOuDescricao(string termo);
    }
}
