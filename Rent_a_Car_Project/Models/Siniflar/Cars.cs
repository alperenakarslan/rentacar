using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Rent_a_Car_Project.Models.Siniflar
{
    public class Cars
    {
        [Key]
        public int ID { get; set; }
        public string model { get; set; }
        public string carName { get; set; }
        public string carInfo { get; set; }
        public int price { get; set; }
        public string carImage { get; set; }
    }
}