using System;

enum TypeColor
{
    RED, GREEN, BLUE
}

namespace WindowsFormsApp1
{
    class HSV
    {
        private TypeColor CurrentColor;
        private String messageAboutError;
        public HSV()
        {
           
        }

        public double convertColorToDegrees(String typeDate,double colorValue) //Конвертировать цвет в градусы
        {
            double colorDegrees = 0;

            switch (typeDate)
            {
                case "degr.":
                    colorDegrees = colorValue;
                    break;
                case "%":
                    colorDegrees = 360d / 100 * colorValue;
                    break;
                case "pt.":
                    colorDegrees = 360d * colorValue;
                    break;
            }
            return colorDegrees;
        }

        public double convertValueToPersent(String typeDate, double value)
        {
            double toPersent = value;

            if(typeDate == "pt.")
            {
                toPersent = 100 * value;
            }
            return toPersent;
        }

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
        public bool colorInItsRange(double colorValue, String currentColor, String typeDate)
        {        //Проверяем корректность диапазона цвета, в соответствии с выбранным типом цвета.
            Checker check = new Checker();
            bool colorValid = false;
            double colorDegrees;

                saveTypeColor(currentColor);                                //Сохранить тип текущего цвета(RGB)
                colorDegrees = convertColorToDegrees(typeDate, colorValue); //Коневертируем цвет в градусы, для просмтрода диапазона

                switch (CurrentColor)                                       //Входит ли цвет в свой диапазон
                {
                    case TypeColor.RED:
                        colorValid = diapasonIsRed(colorDegrees);  //Если занчение входит в диапазон красного цвета
                        break;
                    case TypeColor.GREEN:
                        colorValid = diapasonIsGreen(colorDegrees); //Если занчение входит в диапазон зеленого цвета
                        break;
                    case TypeColor.BLUE:
                        colorValid = diapasonIsBlue(colorDegrees);  //Если занчение входит в диапазон синего цвета
                        break;
                }
            
            return colorValid;

        }
        private bool diapasonIsRed(double color)
        {
            bool colorValid =  false;

            if (color < 120 || color == 360)
            {
                colorValid =  true;
            }
            else
            {
                messageAboutError = $"Значение цвета({color}) не входит в диапазон красного цвета(0 - 120, 360 град.)";
            }

            return colorValid;
        }
        private bool diapasonIsGreen(double color)
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
        private bool diapasonIsBlue(double color)
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

        private void saveTypeColor(String typeColor)
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
        public int diapasonTypeOfColor(double value, string unit)   //Проверить входит ли число
        {                                                           //в диапазон("degr", "%", "pt")  
            int typeColor = 0;                                      //(0 - red, 1 - green, 2 - blue)
            double valueInDegree = convertColorToDegrees(unit,value);

            if (valueInDegree < 120 || valueInDegree == 360)
            {
                typeColor = 0;
            }
            else if (valueInDegree >= 120 && valueInDegree < 240)
            {
                typeColor = 1;
            }
            else if (valueInDegree >= 240 && valueInDegree < 360)
            {
                typeColor = 2;

            }
            else typeColor = -1;

            return typeColor;
        }
       public String typeColorByIndex(int index)
        {
            String colorGrad = "";

            switch (index)
            {
                case 0:
                    colorGrad = "0";
                    break;
                case 1:
                    colorGrad = "120";
                    break;
                case 2:
                    colorGrad = "240";
                    break;
            }
            return colorGrad;
        }
        public String getMessageError()
        {
            return messageAboutError;
        }

        public int[] HSVtoRGB(double colorInDegrees,double saturInPersent, double brightInPersent)
        {
            int[] RGB = null;

            //int j = (int)Math.Round(212.5,0, MidpointRounding.ToEven);
            int Hi = (int)((colorInDegrees / 60) % 6);
            float Vmin = (float)((100 - saturInPersent) * brightInPersent) / 100;
            float a = ((float)brightInPersent - Vmin) * (float)((colorInDegrees % 60) / 60);

            float Vinc =(Vmin + a);
            float Vdec = ((float)brightInPersent - a);

            int V = (int)Math.Round(brightInPersent * 255 / 100, MidpointRounding.AwayFromZero);
            int _Vmin = (int)Math.Round((Vmin * 255 / 100), MidpointRounding.AwayFromZero);
            int _Vinc = (int)Math.Round((Vinc * 255 / 100), MidpointRounding.AwayFromZero); //212,52 = 213
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
