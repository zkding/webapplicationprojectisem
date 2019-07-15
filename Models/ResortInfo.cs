using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Models
{
    public class ResortInfo
    {
        [DisplayName("Name")]
        public string Name { get; set; }

        [DisplayName("Country")]
        public string Country { get; set; }

        [DisplayName("ContactNumber")]
        public string ContactNumber { get; set; }
    }
}
