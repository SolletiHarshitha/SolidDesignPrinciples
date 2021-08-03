using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDesignPrinciples.Interface_Segregation_Principle
{
    public class Jeans : IProduct, IPants
    {
        public int ID { get; set; } = 101;
        public double Weight { get; set; } = 2;
        public String Stock { get; set; } = "Fresh";
        public int Inseam { get; set; } = 32;
        public int WaistSize { get; set; } = 30;
    }
}
