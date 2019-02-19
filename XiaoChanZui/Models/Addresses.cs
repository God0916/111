using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XiaoChanZui.Models
{
    public class Addresses
    {
        public int AddressId { get; set; }
        public string Consignse { get; set; }
        public int UserId { get; set; }
        public string Region { get; set; }
        public string DetailAddress { get; set; }
        public string Phone { get; set; }
    }
}