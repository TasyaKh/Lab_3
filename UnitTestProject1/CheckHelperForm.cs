using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab_3;

namespace UnitTestProject1
{
    [TestClass]
    public class CheckHelperForm
    {
        HelperForm helper = new HelperForm();
        [TestMethod]
        public void CheckOnWrongSymbolsTest() //Проверка на ввод символов
        {
            string txt = "gg";    //Что вводим
            string unit = "pt.";  //Тип данных
            int numField = 1;     //В каком поле

            Assert.IsFalse(helper.diapasonValuesIsValid(txt, unit, numField));//Данные будут недействительны, т.е false
            Assert.AreEqual(helper.getMessageError(), "Ошибка!Введены недопустимые символы: gg.Введите числовой тип данных.Проверьте поле №1");
        }
        [TestMethod]                          //Проверка на ввод данных, не входщих в текущий диапазон
        public void CheckOnWrongTypeOfDate1Test() //Тип данных - доли
        {
            string txt = "10";    //Что вводим
            string unit = "pt.";  //Тип данных
            int numField = 1;     //В каком поле

            Assert.IsFalse(helper.diapasonValuesIsValid(txt, unit, numField));//Данные будут недействительны, т.е false
            Assert.AreEqual(helper.getMessageError(), $"Ошибка!Недопустимое значение: 10 (диапазон допустимых значений [0;1]).Проверьте поле №1");
        }
        [TestMethod]                          //Проверка на ввод данных, не входщих в текущий диапазон
        public void CheckOnWrongTypeOfDate2Test() //Тип данных - проценты
        {
            string txt = "-1";      //Что вводим
            string unit = "%";      //Тип данных
            int numField = 2;       //В каком поле

            Assert.IsFalse(helper.diapasonValuesIsValid(txt, unit, numField));//Данные будут недействительны, т.е false
            Assert.AreEqual(helper.getMessageError(), $"Ошибка!Недопустимое значение: -1 (диапазон допустимых значений [0;100]).Проверьте поле №2");
        }
        [TestMethod]                          //Проверка на ввод данных, не входщих в текущий диапазон
        public void CheckOnWrongTypeOfDate3Test() //Тип данных - градусы
        {
            string txt = "367";     //Что вводим
            string unit = "degr.";  //Тип данных
            int numField = 1;       //В каком поле

            Assert.IsFalse(helper.diapasonValuesIsValid(txt, unit, numField));//Данные будут недействительны, т.е false
            Assert.AreEqual(helper.getMessageError(), $"Ошибка!Недопустимое значение: 367 (диапазон допустимых значений [0;360]).Проверьте поле №1");
        }
        [TestMethod]                          //Проверка на ввод данных, не входщих в текущий диапазон
        public void CheckOnTrueTypeOfDate1Test() //Тип данных - градусы
        {
            string txt = "360";     //Что вводим
            string unit = "degr.";  //Тип данных
            int numField = 1;       //В каком поле

            Assert.IsTrue(helper.diapasonValuesIsValid(txt, unit, numField));//Данные будут недействительны, т.е false
          }
    }
}
