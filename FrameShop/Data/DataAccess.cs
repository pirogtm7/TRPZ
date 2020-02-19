using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FrameShop
{
    public class DataAccess
    {
        public static void GetDataFromFile(FrameShop myfm)
        {
            string text = File.ReadAllText(@"C:\Users\User\source\repos\FrameShop\FrameShop\Stock.txt");
            string[] wordsArr = text.Split(' ', '\n');

            for (int i = 0; i < wordsArr.Length; i++)
            {
                myfm.Materials.Add(new Material() { Name = wordsArr[i+2], QuanInStock = Convert.ToInt32(wordsArr[i+6]), QuanPerUnit = Convert.ToInt32(wordsArr[i+10]) });
                i = i + 10;
            }
        }
    }
}
