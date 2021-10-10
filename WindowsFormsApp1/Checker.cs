using System;

namespace WindowsFormsApp1
{
    class Checker
    {
        private String messageAboutError = "";
        //private readonly String[] units = { "degr.", "%", "pt." };
        //int[] g = { 8, 7, 6 };
        public bool diapasonValuesIsValid(string number, string unit, int numField) //Проверить входит ли число
        {                                                           //в диапазон("degr", "%", "pt")  
            bool isValid = true;
            double value;

            try
            {
                value = Convert.ToDouble(number);

                switch (unit) //Передаем выбранное в выпадающем спиксе значение сюда и смотрим, допустимо ли оно
                {
                    case "degr.": //"degr"
                        if (value > 360 || value < 0)
                        {
                            messageAboutError = $"Ошибка!Недопустимое значение: {value} (диапазон допустимых значений [0;360])"+
                                $"Проверьте поле №{numField}" ;
                            isValid = false;
                        }
                        break;
                    case "%": //"%"
                        if (value > 100 || value < 0)
                        {
                            messageAboutError = $"Ошибка!Недопустимое значение: {value} (диапазон допустимых значений [0;100])" +
                                $"Проверьте поле №{numField}";
                            isValid = false;
                        }
                        break;
                    case "pt.": //"pt"
                        if (value > 1 || value < 0)
                        {
                            messageAboutError = $"Ошибка!Недопустимое значение: {value} (диапазон допустимых значений [0;1])" +
                                $"Проверьте поле №{numField}";
                            isValid = false;
                        }
                        break;
                    default:
                        messageAboutError = "Ошибка программы!Тип данных не был получен верно";
                        isValid = false;
                        break;
                }
            }
            catch (FormatException)
            {
                messageAboutError = "Ошибка!Введены недопустимые символы: " + number + ".Введите числовой тип данных)" +
                    $"Проверьте поле №{numField}";
                isValid = false;

            }
            return isValid;
        }

        public String getMessageError()
        {
            return messageAboutError;
        }
    }
}
