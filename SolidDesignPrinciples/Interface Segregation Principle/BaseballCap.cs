using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDesignPrinciples.Interface_Segregation_Principle
{
    public class BaseballCap : IProduct, IHat
    {
        public int ID { get; set; } = 201;
        public double Weight { get; set; } = 1.5;
        public String Stock { get; set; } = "Fresh";
        public int HatSize { get; set; } = 6;
    }
}
