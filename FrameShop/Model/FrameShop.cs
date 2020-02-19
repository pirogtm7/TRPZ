using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameShop
{
    public class FrameShop
    {
        private List<Material> materials = new List<Material>();

        public List<Material> Materials { get { return materials; } set { materials = value; } }

        //public void AddMaterials()
        //{
        //    Materials.Add(new Material() { Name = "Wood", QuanInStock = 213, QuanPerUnit = 5 });
        //    Materials.Add(new Material() { Name = "Metal lining", QuanInStock = 100, QuanPerUnit = 2 });
        //    Materials.Add(new Material() { Name = "Plastic lining", QuanInStock = 43, QuanPerUnit = 3 });
        //    Materials.Add(new Material() { Name = "Paint", QuanInStock = 300, QuanPerUnit = 6 });
        //    Materials.Add(new Material() { Name = "Varnish", QuanInStock = 200, QuanPerUnit = 5 });

        //}
    }
}
