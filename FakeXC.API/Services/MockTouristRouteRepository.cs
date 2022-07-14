using FakeXC.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeXC.API.Services
{
   /* public class MockTouristRouteRepository : ITouristRouteRepository
    {
        List<TouristRoute> routes;
        public MockTouristRouteRepository()
        {
            if (routes == null)
            {
                InitializeRoutes();
            }
        }

        public IEnumerable<TouristRoutePicture> GetPicturesByTouristRouteId(Guid TouristRouteId)
        {
            throw new NotImplementedException();
        }

        public TouristRoute GetTouristRoute(Guid touristRouteId)
        {
            return routes.FirstOrDefault(n=>n.Id==touristRouteId);
        }

        public IEnumerable<TouristRoute> GetTouristRoutes()
        {
            return routes;
        }
    
        public void InitializeRoutes()
        {
            routes = new List<TouristRoute>
            {
                new TouristRoute
                {
                    Id=new Guid(),
                    Title="黄山",
                    Description="黄山一日游",
                    OriginalPrice=1299,
                    Feature="<p>吃住行购物<p>",
                    Fees="<p>交通费自理<p>",
                    Notes="<p>小心危险<p>"
                 },
                 new TouristRoute
                {
                    Id=new Guid(),
                    Title="华山",
                    Description="华山一日游",
                    OriginalPrice=1499,
                    Feature="<p>吃住行购物<p>",
                    Fees="<p>交通费自理<p>",
                    Notes="<p>小心危险<p>"
                 },
            };
        }

        public bool TouristRouteExists(Guid touristRouteId)
        {
            throw new NotImplementedException();
        }
    }*/
}
