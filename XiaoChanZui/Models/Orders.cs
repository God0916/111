using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XiaoChanZui.Models
{
    public class Orders
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public int GoodsId { get; set; }
        public int OrderNum { get; set; }
        public string AddressId { get; set; }
        public string OrderState { get; set; }
    }
}