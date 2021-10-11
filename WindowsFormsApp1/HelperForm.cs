using System;

namespace WindowsFormsApp1
{
    class HelperForm
    {
        private String messageAboutError = "";
        public bool diapasonValuesIsValid(string number, string unit, int numField) //Проверить входит ли число
        {                                                                           //в диапазон("degr", "%", "pt")  
            bool isValid = true; //Будем считать, что значение входит в дщапазон
            double value;        //Содержит значение, которе будем проверять

            try
            {
                value = Convert.ToDouble(number);

                switch (unit) //Передаем выбранное в выпадающем спиксе значение(тип данных) сюда и смотрим, допустимо ли оно
                {
                    case "degr.": //"degr" градусы
                        if (value > 360 || value < 0)
                        {
                            messageAboutError = $"Ошибка!Недопустимое значение: {value} (диапазон допустимых значений [0;360])"+
                                $"Проверьте поле №{numField}" ;
                            isValid = false;
                        }
                        break;
                    case "%": //"%" проценты
                        if (value > 100 || value < 0)
                        {
                            messageAboutError = $"Ошибка!Недопустимое значение: {value} (диапазон допустимых значений [0;100])" +
                                $"Проверьте поле №{numField}";
                            isValid = false;
                        }
                        break;
                    case "pt.": //"pt" единицы [0;1]
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

        //public int getIndexColorByDegrees(double value, string unit)   //Получить индекс цвета в соответствии с диапазоном для бокса
        //{                                                           //("degr", "%", "pt")  
        //    int typeColor = 0;                                      //(0 - red, 1 - green, 2 - blue)
        //    double valueInDegree = convertColorToDegrees(unit, value);

        //    if (valueInDegree < 120 || valueInDegree == 360)
        //    {
        //        typeColor = 0;
        //    }
        //    else if (valueInDegree >= 120 && valueInDegree < 240)
        //    {
        //        typeColor = 1;
        //    }
        //    else if (valueInDegree >= 240 && valueInDegree < 360)
        //    {
        //        typeColor = 2;

        //    }
        //    else typeColor = -1;

        //    return typeColor;
        //}
        public String getColorByIndex(int index) //Получить цвет(градусы), в соответствии с тем, который был выбран возле поля цвета слева
        {
            String colorGrad = "";

            switch (index)
            {
                case 0:
                    colorGrad = "0";   //Красный
                    break;
                case 1:
                    colorGrad = "120"; //Зеленый
                    break;
                case 2:
                    colorGrad = "240"; //Синий
                    break;
            }
            return colorGrad;
        }
        public String getMessageError() //Вывести собщение об каких то ошибках, если что то пошло не так
        {
            return messageAboutError;
        }
    }
}
