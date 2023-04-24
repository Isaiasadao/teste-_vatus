namespace vatusAPI.Services.VatusService
{
    public class VatuService : IVatuService
    {
        private static List<Vatus> vatuss = new List<Vatus> {
            new Vatus {
                Id =1,
                Name ="Eduardo",
                About="About",
                Home="Home",
                Place=" hair"
            },
            new Vatus {
                Id =2,
                Name ="Isaias",
                About="Adap",
                Home="Home",
                Place=" hair"
            }
            };
        public List<Vatus> AddVatus(Vatus dados)
        {
            vatuss.Add(dados);

            return vatuss;
        }

        public List<Vatus>? DeleteVatus(int id)
        {
            var item = vatuss.Find(x => x.Id == id);
            if (item == null)
            {
                return null;
            }
            vatuss.Remove(item);
            return vatuss;
        }

        public List<Vatus>? GetAllVatus()
        {
            return vatuss;
        }

        public Vatus GetSingleVatus(int id)
        {
            var item = vatuss.Find(x => x.Id == id);
            if (item == null)
            {
                return null;
            }
            return item;
        }

        public List<Vatus>? PutVatus(int id, Vatus request)
        {
          


            var item = vatuss.Find(x => x.Id == id);
            if (item == null)
            {
                return null;
            }
            item.About = request.About;
            item.Home = request.Home;
            item.Name = request.Name;
            item.Place = request.Place;
            return vatuss;
        }
    }
}
