using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ShoppingApp.Web.Areas.Admin.Models.Dtos
{
    public class ProductListWithSearchDto
    {
        public List<ProductListDto> ProductListDtos { get; set; }
        public SearchQueryDto SearchQueryDto { get; set; }
        public List<SelectListItem> IsHomeList { get; set; }
        public List<SelectListItem> IsApprovedList { get; set; }
    }
}