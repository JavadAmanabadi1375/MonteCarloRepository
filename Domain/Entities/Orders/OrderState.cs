﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Domain.Entities.Orders
{
    public enum OrderState
    {
        [Display(Name = "در حال پردازش")]
        Processing = 0,
        [Display(Name = "لغو شده")]
        Canceled = 1,
        [Display(Name = "تحویل شده")]
        Delivered = 2,
    }

}
