using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FakeXC.API.ResourceParameters
{
    public class TouristRouteResourceParameters
    {
        public string Keyword { get; set; }
        public string Rating { get { return _rating; } set {
                if (!string.IsNullOrEmpty(value))
                {
                    Regex regex = new Regex(@"([A-Za-z]+)(\d+)");
                    Match match = regex.Match(value);
                    if (match.Success)
                    {
                        RatingOperator = match.Groups[1].Value;
                        RatingValue = int.Parse(match.Groups[2].Value);
                    }
                }
                _rating =value ;
            } }
        private string _rating;
        public string RatingOperator { get; set; }
        public int? RatingValue { get; set; }
    }
}
