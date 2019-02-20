using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace XiaoChanZui.Models
{
    public class Addresses
    {
        public int AddressId { get; set; }
        [Display(Name ="收货人")]
        public string Consignse { get; set; }
        public int UserId { get; set; }
        [Display(Name = "收货地址")]
        public string Region { get; set; }
        [Display(Name = "详细地址")]
        public string DetailAddress { get; set; }
        [Display(Name = "电话号码")]
        public string Phone { get; set; }
    }
}