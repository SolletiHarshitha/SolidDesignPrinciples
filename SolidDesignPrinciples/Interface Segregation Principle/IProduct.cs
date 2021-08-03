using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDesignPrinciples.Interface_Segregation_Principle
{
    public interface IProduct
    {
        int ID { get; set; }
        double Weight { get; set; }
        String Stock { get; set; }
    }

    public interface IPants
    {
        public int Inseam { get; set; }
        public int WaistSize { get; set; }
    }

    public interface IHat
    {
        public int HatSize { get; set; }
    }
}
