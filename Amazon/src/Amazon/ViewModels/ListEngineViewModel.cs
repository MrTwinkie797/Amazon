using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Amazon.ViewModels
{
    public class ListEngineViewModel
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public double Bhp { get; set; }
        public int TopSpeed { get; set; }
        public double Litre { get; set; }
        public string Info { get; set; }

    }
}
