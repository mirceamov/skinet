using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Core.Specification
{
    public class ProductParamSpec
    {
        private int MAX_PAGE_SIZE = 50;

        public string Sort { get; set; }
        
        public int? BrandId { get; set; }
        
        public int? TypeId { get; set; }

        public int PageIndex { get; set; } = 1;
        
        private int _pageSize = 5;

        public int PageSize 
        {
            get => _pageSize;
            set => _pageSize = value > MAX_PAGE_SIZE ? MAX_PAGE_SIZE : value;
        }

        private string _search;

        public string Search 
        { 
            get => _search; 
            set => _search = value.ToLower(); 
        }
    }
}
