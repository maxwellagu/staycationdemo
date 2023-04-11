using StaycationDemo.Models.Abstractions;
using System.Collections.Generic;

namespace StaycationDemo.Models.Repositories
{
    public class HotelRepository : IHotelRepository
    {
        public IEnumerable<Suite> AllHotels => throw new System.NotImplementedException();

        public IEnumerable<Suite> MostPickedHotels => throw new System.NotImplementedException();

        public Suite GetHotelById(int hotelId)
        {
            throw new System.NotImplementedException();
        }

        public bool SaveHotel(Suite hotel)
        {
            throw new System.NotImplementedException();
        }
    }
}
