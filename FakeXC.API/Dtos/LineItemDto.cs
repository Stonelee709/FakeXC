using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeXC.API.Dtos
{
    public class LineItemDto
    {
        public int Id { get; set; }

      
        public Guid TouristRouteId { get; set; }
        public TouristRouteDto TouristRoute { get; set; }
        public Guid? ShoppingCartId { get; set; }
        public decimal OriginalPrice { get; set; }
     
        public double? DiscountPercentage { get; set; }
    }
}
