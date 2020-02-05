using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameShop
{
    public class Frame
    {
        private List<Material> materials = new List<Material>();
        private int width, length, quantity;

        public List<Material> Materials { get { return materials; } set { materials = value; } }
        public int Width { get { return width; } set { width = value; } }
        public int Length { get { return length; } set { length = value; } }
        public int Quantity { get { return quantity; } set { quantity = value; } }

    }
}
