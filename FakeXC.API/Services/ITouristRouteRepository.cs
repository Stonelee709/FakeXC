using FakeXC.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeXC.API.Services
{
   public  interface ITouristRouteRepository
    {
        public Task<IEnumerable<TouristRoute>> GetTouristRoutesAsync(string keyword, string RatingOperator, int? RatingValue);
        Task<TouristRoute> GetTouristRouteAsync(Guid touristRouteId);
        Task<bool> TouristRouteExistsAsync(Guid touristRouteId);
        Task<IEnumerable<TouristRoutePicture>> GetPicturesByTouristRouteIdAsync(Guid TouristRouteId);
        Task<TouristRoutePicture>GetPictureAsync(int pictureId);
        Task<IEnumerable<TouristRoute>> GetTouristRoutesByIDListAsync(IEnumerable<Guid> Ids);


        void DeleteTouristRoutesByIDList(IEnumerable<TouristRoute> Ids);
        void AddTouristRoute(TouristRoute touristRoute);
        void AddTouristRoutePicture(Guid touristRouteId, TouristRoutePicture touristRoutePicture);
        void DeleteTouristRoute(TouristRoute touristRoute);
        void DeleteTouristRoutePicture(TouristRoutePicture touristRoutePicture);

        //ShoppingCart
        Task<ShoppingCart> GetShopingCartByUserId(string userId);
        Task CreateShoppingCart(ShoppingCart shoppingCart);
        Task AddShoppingCartItem(LineItem lineItem);
        Task<LineItem> GetShoppingCartByItemId(int lineItemId);
        void DeleteShoppingCartItem(LineItem lineItem);
        Task<IEnumerable<LineItem>> GetShoppingCartByIdListAsync(IEnumerable<int> Ids);
        void DeleteShoppingCartItems(IEnumerable<LineItem> lineItems);

        Task AddOrderAsync(Order order);

        Task<bool> SaveAsync();
    }
}
