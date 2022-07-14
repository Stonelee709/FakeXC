using FakeXC.API.Models;
using FakeXC.API.ValidationAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FakeXC.API.Dtos
{
    //class 级别的数据验证
   
    public class TouristRouteForCreationDto: TouristRouteManipulationDto//:IValidatableObject
    {


        

        //属性级别数据验证,确保 TITLE 和 DESCRIPTION 不相同
       /* public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Title == Description)
            {
                yield return new ValidationResult(
                    "路线名称必须与路线描述不同",
                    new[] { "TouristRouteForCreationDto" }
                    );
            }
        }*/
    }
}
