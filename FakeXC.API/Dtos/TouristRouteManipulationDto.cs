using FakeXC.API.Models;
using FakeXC.API.ValidationAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace FakeXC.API.Dtos
{
    [TouristRouteTitleMustNotSameAsDescriptionAttribute]
    public abstract class TouristRouteManipulationDto
    {
        [Required(ErrorMessage = "title 不可为空")]
        [MaxLength(100)]
        public string Title { get; set; }
        [Required]
        [MaxLength(1500)]
        public virtual string Description { get; set; }

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
        public ICollection<TouristRoutePictureForCreationDto> TouristRoutePictures { get; set; }
         = new List<TouristRoutePictureForCreationDto>();
    }
}
