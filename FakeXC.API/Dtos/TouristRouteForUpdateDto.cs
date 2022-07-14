﻿using FakeXC.API.Models;
using FakeXC.API.ValidationAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FakeXC.API.Dtos
{

    public class TouristRouteForUpdateDto: TouristRouteManipulationDto
    {

   
        [Required(ErrorMessage ="更新必备")]
        [MaxLength(1500)]
        public override string Description { get; set; }
     
     

        
    }
}
