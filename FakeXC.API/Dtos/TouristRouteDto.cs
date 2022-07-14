using FakeXC.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeXC.API.Dtos
{
    public class TouristRouteDto
    {
       
        public Guid Id { get; set; } = Guid.NewGuid();
        
        public string Title { get; set; }
     
        public string Description { get; set; }
     
        //原价*折扣
        public decimal Price { get; set; }
        
        public DateTime CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public DateTime? DepatureTime { get; set; }
    
        public string Feature { get; set; }

        public string Fees { get; set; }

        public string Notes { get; set; }

        public double? Rating { get; set; }
        public string TravelDays { get; set; }
        public string TripType { get; set; }
        public string DepatureCity { get; set; }
        public ICollection<TouristRoutePictureDto> TouristRoutePictures { get; set; } 
    }
}
