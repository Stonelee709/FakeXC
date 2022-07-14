using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace FakeXC.API.Models
{
    public class TouristRoute
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [Required]
        [MaxLength(1500)]
        public string Description { get; set; }
        [Column(TypeName ="decimal(18,2)")] //保留两位小数
        public decimal OriginalPrice { get; set; }
        [Range(0.0,1.0)]
        public double? DiscountPercentage { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public DateTime? DepatureTime { get; set; }
       [MaxLength]//字符串的最大长度限制
        public string Feature { get; set; }
        [MaxLength]//字符串的最大长度限制
        public string Fees { get; set; }
        [MaxLength]//字符串的最大长度限制
        public string Notes { get; set; }
        public ICollection<TouristRoutePicture> TouristRoutePictures { get; set; } = new List<TouristRoutePicture>();
        public double? Rating { get; set; }
        public TravelDays? TravelDays { get; set; }
        public TripType? TripType { get; set; }
        public DepatureCity? DepatureCity { get; set; }
    }
}
