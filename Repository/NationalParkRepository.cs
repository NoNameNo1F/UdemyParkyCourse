using PankyAPI.Models;
using PankyAPI.Repository.IRepository;

namespace PankyAPI.Repository
{
    public class NationalParkRepository : INationalParkRepository
    {
        public ICollection<NationalPark> GetNationalParks()
        {
            throw new NotImplementedException();
        }
        public NationalPark GetNationalPark(int nationalParkId)
        {
            throw new NotImplementedException();
        }
        public bool NationalParkExists(string name)
        {
            throw new NotImplementedException();
        }
        public bool NationalParkExists(int id)
        {
            throw new NotImplementedException();
        }
        public bool CreateNationalPark(NationalPark nationalPark)
        {
            throw new NotImplementedException();
        }
        public bool UpdateNationalPark(NationalPark nationalPark)
        {
            throw new NotImplementedException();
        }
        public bool DeleteNationalPark(NationalPark nationalPark)
        {
            throw new NotImplementedException();
        }
        public bool Save()
        {
            throw new NotImplementedException();
        }
    }
}