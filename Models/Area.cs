using Desafio.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Models
{
    public class Area
    {
        BoiViewModel model = new BoiViewModel();


        public long Id { get => Id ; set => Id++; } 
        public string nameArea { get; set; }
        public int max { get; set; }
        public double GMD { get; set; }
        public int CountBoi { get; set; }

        public Area()
        {
        }

        

        public Area(string nameArea, int max, double gMD) : this(nameArea)
        {
            this.max = max;
            GMD = gMD;
        }
       
        

        public Area(string nameArea)
        {
            this.nameArea = nameArea ?? throw new ArgumentNullException(nameof(nameArea));
        }
    }
}
