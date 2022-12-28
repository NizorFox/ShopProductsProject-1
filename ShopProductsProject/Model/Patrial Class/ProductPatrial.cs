using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProductsProject.Model
{
    public partial class Product
    {
        Core db = new Core();
        /// <summary>
        /// Свойство, отвечающее за исправление пути к картинке
        /// </summary>
        public string ImagePath
        {
            get
            {
                if (Image == null)
                {
                    return "/Assets/Images/picture.png";
                }
                else
                {
                    return "/Assets/Images" + Image;
                }

            }
        }
        /// <summary>
        /// Метод, возвращающий список материалов
        /// </summary>
        public string MaterialList
        {
            get
            {
                string materials = "Материалы:  ";
                List<string> arrayMaterials = new List<string> { };

                List<ProductMaterial> arrayActiveProduct = db.context.ProductMaterial.Where(x => x.ProductID == ID).ToList();
                foreach (var item in arrayActiveProduct)
                {
                    arrayMaterials.Add($"{item.Material.Title} ({item.Material.MaterialTypeID})");

                }
                materials += String.Join(",", arrayMaterials);
                if (arrayMaterials.Count == 0)
                {
                    return string.Empty;
                }
                else
                {
                    return materials;
                }


            }
        }
        public double CostProduct
        {
            get
            {
                double costProduct = 0;
                List<ProductMaterial> arrayActiveProduct = ProductMaterial.Where(x => x.ProductID == ID).ToList();
                foreach (var item in arrayActiveProduct)
                {
                    costProduct += Convert.ToDouble(item.Count) * Convert.ToDouble(item.Material.Cost);
                }
                return costProduct;
            }

        }

    }
}
