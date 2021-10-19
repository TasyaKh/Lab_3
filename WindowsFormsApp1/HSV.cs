using System;

enum TypeColor
{
    RED, GREEN, BLUE
}

namespace Lab_3
{
    public class HSV
    {
        private TypeColor CurrentColor;
        private String messageAboutError;  //Хранит различные сообщения об ошибках
        //---------------------------------------------------------------------------------------------------------------------------------------
        public double convertToDegrees(String typeDate, double colorValue) //Конвертировать цвет в градусы
        {
            double colorDegrees = 0;

            switch (typeDate)
            {
                case "degr.": //Из градусов
                    colorDegrees = colorValue;
                    break;
                case "%":     //Из процентов
                    colorDegrees = 360d / 100 * colorValue;
                    break;
                case "pt.":   //Из 0 - 1
                    colorDegrees = 360d * colorValue;
                    break;
            }
            return colorDegrees;
        }
        //---------------------------------------------------------------------------------------------------------------------------------------
        public double convertValueToPersent(String typeDate, double value) //Перевод в проценты
        {
            double toPersent = value;                                      //Будет хранить число в процентах

            if (typeDate == "pt.")
            {
                toPersent = 100 * value;
            }
            else if (typeDate == "grad.")
            {
                toPersent = value / (360 / 100);
            }
            return toPersent;
        }
        //---------------------------------------------------------------------------------------------------------------------------------------
        public double plusMinusValue(double currentValue, String sign, double increaseOn) //Прибавить, вычесть цвет
        {
            double endValue = currentValue;

            switch (sign)
            {
                case "+":
                    endValue = currentValue + increaseOn;
                    break;
                case "-":
                    endValue = currentValue - increaseOn;
                    break;
            }

            return endValue;
        }
        //---------------------------------------------------------------------------------------------------------------------------------------
        public bool colorInItsRange(double colorDegrees, String currentColor)
        {        //Проверяем корректность диапазона цвета, в соответствии с выбранным типом цвета.
            bool colorValid = false;
            //double colorDegrees;

            saveTypeColor(currentColor);                                 //Сохранить тип текущего цвета(RGB)
            //colorDegrees = convertToDegrees(typeDate, colorValue);     //Коневертируем цвет в градусы, для просмтрода диапазона

            switch (CurrentColor)                                        //Входит ли цвет в свой диапазон
            {
                case TypeColor.RED:
                    colorValid = diapasonIsRed(colorDegrees);            //Если занчение входит в диапазон красного цвета
                    break;
                case TypeColor.GREEN:
                    colorValid = diapasonIsGreen(colorDegrees);         //Если занчение входит в диапазон зеленого цвета
                    break;
                case TypeColor.BLUE:
                    colorValid = diapasonIsBlue(colorDegrees);          //Если занчение входит в диапазон синего цвета
                    break;
            }

            return colorValid;

        }
        //---------------------------------------------------------------------------------------------------------------------------------------
        private bool diapasonIsRed(double color) //Проверяем входит ли цвет в диапазон красного
        {
            bool colorValid = false;

            if ((color < 120 || color == 360) && color >= 0)
            {
                colorValid = true;
            }
            else
            {
                messageAboutError = $"Значение цвета({color}) не входит в диапазон красного цвета(0 - 120, 360 град.)";
            }

            return colorValid;
        }
        //---------------------------------------------------------------------------------------------------------------------------------------
        private bool diapasonIsGreen(double color) //Проверяем входит ли цвет в диапазон зеленого
        {
            bool colorValid = false;

            if (color >= 120 && color < 240)
            {
                colorValid = true;
            }
            else
            {
                messageAboutError = $"Значение цвета({color}) не входит в диапазон зеленого цвета(120-240 град.)";
            }
            return colorValid;
        }
        //---------------------------------------------------------------------------------------------------------------------------------------
        private bool diapasonIsBlue(double color) //Проверяем входит ли цвет в диапазон синего
        {
            bool colorValid = false;

            if (color >= 240 && color < 360)
            {
                colorValid = true;
            }
            else
            {
                messageAboutError = $"Значение цвета({color}) не входит в диапазон синего цвета(240-360 град.)";
            }
            return colorValid;
        }
        //---------------------------------------------------------------------------------------------------------------------------------------
        private void saveTypeColor(String typeColor) //Сохраняем тип текщего цвета в перечисление для удобства
        {
            switch (typeColor)
            {
                case "Red":
                    CurrentColor = TypeColor.RED;
                    break;
                case "Green":
                    CurrentColor = TypeColor.GREEN;
                    break;
                case "Blue":
                    CurrentColor = TypeColor.BLUE;
                    break;
            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------------
        public String getMessageError()
        {
            return messageAboutError;
        }
        //---------------------------------------------------------------------------------------------------------------------------------------
        public int[] HSVtoRGB(double colorInDegrees, double saturInPersent, double brightInPersent)
        {                     //Здесь происходит конвертация HSV to RGB
            int[] RGB = null; //Здесь хранятся значения цветов(красный, синий, зеленый)
                              //Обращаемся к википедии!
            int Hi = (int)((colorInDegrees / 60) % 6);
            float Vmin = (float)((100 - saturInPersent) * brightInPersent) / 100;
            float a = ((float)brightInPersent - Vmin) * (float)((colorInDegrees % 60) / 60);

            float Vinc = (Vmin + a);
            float Vdec = ((float)brightInPersent - a);

            int V = (int)Math.Round(brightInPersent * 255 / 100, MidpointRounding.AwayFromZero);
            int _Vmin = (int)Math.Round((Vmin * 255 / 100), MidpointRounding.AwayFromZero);
            int _Vinc = (int)Math.Round((Vinc * 255 / 100), MidpointRounding.AwayFromZero);
            int _Vdec = (int)Math.Round((Vdec * 255 / 100), MidpointRounding.AwayFromZero);

            switch (Hi)
            {
                case 0:
                    RGB = new int[] { V, _Vinc, _Vmin };
                    break;
                case 1:
                    RGB = new int[] { _Vdec, V, _Vmin };
                    break;
                case 2:
                    RGB = new int[] { _Vmin, V, _Vinc };
                    break;
                case 3:
                    RGB = new int[] { _Vmin, _Vdec, V };
                    break;
                case 4:
                    RGB = new int[] { _Vinc, _Vmin, V };
                    break;
                case 5:
                    RGB = new int[] { V, _Vmin, _Vdec };
                    break;
            }
            return RGB;
        }  
    }
}
