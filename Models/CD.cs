using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moment3._2.Models
{
    public class CD
    {
        public int Id { get; set; }
        public string Album { get; set; }
        public string Artist { get; set; }
        public int Release { get; set; }
        public int Tracks { get; set; }

        public CD()
        {

        }

    }
}
