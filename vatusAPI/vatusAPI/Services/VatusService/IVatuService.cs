namespace vatusAPI.Services.VatusService
{
    public interface IVatuService
    {
        List<Vatus> GetAllVatus();
        Vatus? GetSingleVatus(int id);
        List<Vatus> AddVatus(Vatus dados);
        List<Vatus>? PutVatus(int id, Vatus request);
        List<Vatus>? DeleteVatus(int id);
    }
}
