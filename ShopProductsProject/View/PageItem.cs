using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProductsProject.View
{
    public class PageItem
    {
        public int Num { get; set; }
        public string Selected { get; set; }
        public string TextColor { get; set; }
        public string FontWeight { get; set; }

        public PageItem()
        {
            Num = 0;
            Selected = "None";
            TextColor = "Black";
            FontWeight = "Normal";
        }
        public PageItem(int num, bool selected)
        {
            Num = num;
            Selected = (selected ? "Underline" : "None");
            TextColor = (selected ? "Blue" : "Black");
            FontWeight = (selected ? "Bold" : "Normal");
        }
    }
}
