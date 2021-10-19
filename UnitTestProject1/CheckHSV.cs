using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab_3;

namespace UnitTestProject1
{
    [TestClass]
    public class CheckHSV
    {
        HSV hsv = new HSV();

        //---------------------------------------------------------------------------------------------------------------------------------------
        [TestMethod]
        public void ConvertToDegreesFromPersentTest() //Конвертируем в градусы с процентов
        {
            double valueDegrees = hsv.convertToDegrees("%",89); //Конвертируем 89%
            Assert.AreEqual(320,4, valueDegrees);
        }
        [TestMethod]
        public void ConvertToDegreesFromPointsTest() //Конвертируем в градусы с долей
        {
            double valueDegrees = hsv.convertToDegrees("pt.", 0.5); //Конвертируем 0.5
            Assert.AreEqual(180, valueDegrees);
        }
        [TestMethod]
        public void ConvertToDegreesFromDegreesTest() //Конвертируем в градусы с градусов
        {
            double valueDegrees = hsv.convertToDegrees("degr.", 320); //Конвертируем 320
            Assert.AreEqual(320, valueDegrees);
        }
        [TestMethod]
        public void ConvertToDegreesFromWrongDatesTest() //Конвертируем в градусы с неправильного типа данных
        {
            double valueDegrees = hsv.convertToDegrees("", 320); //Конвертируем 320
            Assert.AreEqual(0, valueDegrees);
        }
        //---------------------------------------------------------------------------------------------------------------------------------------
        [TestMethod]
        public void ConvertValueToPersentFromPointsTest() //Конвертируем с долей в градусы
        {
            double valueToPersent = hsv.convertValueToPersent("pt.",1);
            Assert.AreEqual(100, valueToPersent);
        }
        [TestMethod]
        public void ConvertValueToPersentFromPersentTest() //Конвертируем с процентов в проценты
        {
            double valueToPersent = hsv.convertValueToPersent("%", 55);
            Assert.AreEqual(55, valueToPersent);
        }
        //--------------------------------------------------------------------------------------------------------------------------------
        [TestMethod]
        public void plusMinusValuePlusTest() //Добавляем занчение
        {
            double value = hsv.plusMinusValue(90,"+", 55);
            Assert.AreEqual(145, value);
        }
        [TestMethod]
        public void plusMinusValueMinusTest() //Добавляем значение
        {
            double value = hsv.plusMinusValue(90, "-", 55);
            Assert.AreEqual(35, value);
        }
        //---------------------------------------------------------------------------------------------------------------------------------------
        [TestMethod]
        public void ColorInItsRangeRedTest() //Пверяем входит ли градусное значение цвета в свой текущий выбранный диапазон[0-120)
        {
            bool colorInRange = hsv.colorInItsRange(40, "Red");
            Assert.IsTrue(colorInRange);
        }
        [TestMethod]
        public void ColorInItsRangeGreenTest() //Пверяем входит ли градусное значение цвета в свой текущий выбранный диапазон[120-240)
        {
            bool colorInRange = hsv.colorInItsRange(120, "Green");
            Assert.IsTrue(colorInRange);
        }
        [TestMethod]
        public void ColorInItsBlueTest() //Пверяем входит ли градусное значение цвета в свой текущий выбранный диапазон[240-360)
        {
            bool colorInRange = hsv.colorInItsRange(40, "Blue");
            Assert.IsFalse(colorInRange);
        }
        //---------------------------------------------------------------------------------------------------------------------------------------
       
        [TestMethod]
        public void HSVtoRGBTest1() //Переводим из одного типа в другой
        {
            int[] HSV = hsv.HSVtoRGB(360,0,0);     //Хранит сконвертированняе занчения
            int[] trueValues = new int[] {0,0,0 }; //Хранит то, что должно получиться
            bool allIsEquals = CheckRGB.arraysIsEquals(HSV,trueValues); //Смотрим все ли равно
            Assert.IsTrue(allIsEquals);
        }
        [TestMethod]
        public void HSVtoRGBTest2() //Переводим из одного типа в другой
        {
            int[] HSV = hsv.HSVtoRGB(0, 0, 0);     //Хранит сконвертированняе занчения
            int[] trueValues = new int[] { 0, 0, 0 }; //Хранит то, что должно получиться
            bool allIsEquals = CheckRGB.arraysIsEquals(HSV, trueValues); //Смотрим все ли равно
            Assert.IsTrue(allIsEquals);
        }
        [TestMethod]
        public void HSVtoRGBTest3() //Переводим из одного типа в другой
        {
            int[] HSV = hsv.HSVtoRGB(100, 59, 70);     //Хранит сконвертированняе занчения
            int[] trueValues = new int[] { 108, 179, 73 }; //Хранит то, что должно получиться
            bool allIsEquals = CheckRGB.arraysIsEquals(HSV, trueValues); //Смотрим все ли равно
            Assert.IsTrue(allIsEquals);
        }
        [TestMethod]
        public void HSVtoRGBTest4() //Переводим из одного типа в другой
        {
            int[] HSV = hsv.HSVtoRGB(100, 0, 100);     //Хранит сконвертированняе занчения
            int[] trueValues = new int[] { 255, 255, 255 }; //Хранит то, что должно получиться
            bool allIsEquals = CheckRGB.arraysIsEquals(HSV, trueValues); //Смотрим все ли равно
            Assert.IsTrue(allIsEquals);
        }
        [TestMethod]
        public void HSVtoRGBTest5() //Переводим из одного типа в другой
        {
            int[] HSV = hsv.HSVtoRGB(360, 100, 100);     //Хранит сконвертированняе занчения
            int[] trueValues = new int[] { 255, 0, 0 }; //Хранит то, что должно получиться
            bool allIsEquals = CheckRGB.arraysIsEquals(HSV, trueValues); //Смотрим все ли равно
            Assert.IsTrue(allIsEquals);
        }
    }
}
