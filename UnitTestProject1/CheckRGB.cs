using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab_3;

namespace UnitTestProject1
{
    [TestClass]
    public class CheckRGB
    {
        RGB rgb = new RGB();

        public static bool arraysIsEquals(int[]arr1,int[] arr2) //Проверяем все значения на равенство
        {
            bool allRight = true;

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    allRight = false;
                    break;
                }
            }
            return allRight;
        }
        [TestMethod]
        public void RGBtoHSVallDateIsZeroTest1() //Проверка правидбно ди сконвертирован цвет
        {
            int[] hsv = rgb.RGBtoHSV(0, 0, 0);   //Что получим после конвертации
            int[] trueDate = new int[] {0,0,0};  //Что должно получиться
            bool allRight = true;                //Все ли значения равны

            allRight = arraysIsEquals(hsv, trueDate); 


            Assert.IsTrue(allRight);
        }
        [TestMethod]
        public void RGBtoHSVallDateIsZeroTest2() //Проверка правильно ли сконвертирован цвет
        {
            int[] hsv = rgb.RGBtoHSV(255, 0, 0);
            int[] trueDate = new int[] { 0, 100, 100 };
            bool allRight = true;

            allRight = arraysIsEquals(hsv, trueDate);


            Assert.IsTrue(allRight);
        }

        [TestMethod]
        public void RGBtoHSVallDateIsZeroTest3()//Проверка правильно ли сконвертирован цвет
        {
            int[] hsv = rgb.RGBtoHSV(0, 255, 0);
            int[] trueDate = new int[] { 120, 100, 100 };
            bool allRight = true;

            allRight = arraysIsEquals(hsv, trueDate);


            Assert.IsTrue(allRight);
        }
        [TestMethod]
        public void RGBtoHSVallDateIsZeroTest4() //Проверка правильно ли сконвертирован цвет
        {
            int[] hsv = rgb.RGBtoHSV(0, 0, 255);
            int[] trueDate = new int[] { 240, 100, 100 };
            bool allRight = true;

            allRight = arraysIsEquals(hsv, trueDate);


            Assert.IsTrue(allRight);
        }
        [TestMethod]
        public void RGBtoHSVallDateIsZeroTest5() //Проверка правильно ли сконвертирован цвет
        {
            int[] hsv = rgb.RGBtoHSV(56, 200, 8);
            int[] trueDate = new int[] { 105, 96, 78 };
            bool allRight = true;

            allRight = arraysIsEquals(hsv, trueDate);


            Assert.IsTrue(allRight);
        }
        [TestMethod]
        public void RGBtoHSVallDateIsZeroTest6() //Проверка правильно ли сконвертирован цвет
        {
            int[] hsv = rgb.RGBtoHSV(255, 255, 0);
            int[] trueDate = new int[] { 60, 100, 100 };
            bool allRight = true;

            allRight = arraysIsEquals(hsv, trueDate);


            Assert.IsTrue(allRight);
        }
    }
}



  

