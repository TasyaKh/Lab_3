using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
enum TypeValue
{
    DEGREES, PERSENT, PORTION, 
}

enum TypeColor
{
    RED, GREEN, BLUE
}

namespace WindowsFormsApp1
{
    class HSV
    {
        private double hue;         //Цветовой тон
        private double saturation;  //Насыщенность
        private double brighteness; //Яркость

        private TypeValue typeHue;        //Тип данных для цвета (доступно 3 типа)
        private TypeValue typeSaturation; //Тип данных для насыщенности (доступно 2 типа)
        private TypeValue typeBright;     //Тип данных для Яркости (доступно 2 типа)

        private TypeColor CurrentColor;
        private String messageAboutError;
        public HSV(short hue, short saturation, short brighteness)
        {
            typeHue = TypeValue.DEGREES;
            typeSaturation = TypeValue.PERSENT;
            typeBright = TypeValue.PERSENT;

            this.hue = hue;
            this.saturation = saturation;
            this.brighteness = brighteness;
        }
        public void setHSB(TypeValue typeHue, TypeValue typeSaturation, TypeValue typeBright)
        {
            this.typeHue = typeHue;
            this.typeSaturation = typeSaturation;
            this.typeBright = typeBright;
        }

        public void setTypeHue(TypeValue typeHue)
        {
            this.typeHue = typeHue;
        }
        public void setTypeSaturation(TypeValue typeSaturation)
        {
            this.typeSaturation = typeSaturation;
        }
        public void setTypeValue(TypeValue typeBright)
        {
            this.typeBright = typeBright;
        }

        private double colorToDegrees(double color)
        {
            double colorDegrees = 0;

            switch (typeHue)
            {
                case TypeValue.DEGREES:
                    colorDegrees = color;
                    break;
                case TypeValue.PERSENT:
                    colorDegrees = 360/100 * color;
                    break;
                case TypeValue.PORTION:
                    colorDegrees = 360 * color;
                    break;
            }
            return colorDegrees;
        }

        private double plusMinusColor(double value, bool plus)
        {
            double color;

            if (plus)
            {
                color = hue + value;
            }
            else
                color = hue - value;

            return color;
        }
        public String checkColor(double value, bool plus)
        {
            String messageAboutError = "";
            double color = plusMinusColor(value, plus);
  
            color = colorToDegrees(color);

            if (color > 360)
                messageAboutError = "Ошибка!Некорректно задано значение цвета: " +
                    $"{ color}(> 360 град.)";
            else if (color < 0)
                messageAboutError = $"Ошибка!Диапазон цвета:{color} < 0";
            else
            {
                switch (CurrentColor)
                {
                    case TypeColor.RED:
                        messageAboutError =  checkDiapasonRed(color);
                        break;
                    case TypeColor.GREEN:
                        messageAboutError = checkDiapasonGreen(color);
                        break;
                    case TypeColor.BLUE:
                        messageAboutError = checkDiapasonBlue(color);
                        break;
                }
            }
            return messageAboutError;
        }
        public String checkDiapasonRed(double color)
        {
            String messageAboutError = "";

            if (!(color < 120 || color == 360))
                messageAboutError = $"Значение цвета({color}) превысило краcный диапазон цвета(0 - 120, 360 град.)";

            return messageAboutError;
        }
        public String checkDiapasonGreen(double color)
        {
            String messageAboutError = "";

            if (!(color >= 120 && color < 240))
                messageAboutError = $"Значение цвета({color}) превысило зеленый диапазон цвета(120-240 град.)";
            return messageAboutError;
        }
        public String checkDiapasonBlue(double color)
        {
            String messageAboutError = "";
            if (!(color >= 240 && color < 360))
                messageAboutError = $"Значение цвета({color}) превысило синий диапазон цвета(240-360 град.)";
            return messageAboutError;
        }

        public bool checkCorrDatesField(String field,int numField)
        {
            bool isNumber = false;
            double number;

            try
            {
                number = Convert.ToDouble(field);
                if (number < 0)
                {
                    messageAboutError = "Ошибка!Значение не может быть отрицательным.Введите число > 0)+" +
                        $"Проверьте поле №{numField}";
                }  
                else 
                   isNumber = true;
            }
            catch (FormatException)
            {
                messageAboutError = $"Ошибка!Введены недопустимые символы: " + field + ".Введите числовой тип данных)"+
                    $"Проверьте поле №{numField}";
            
            }
            return isNumber;
        }
        public String getMessageError()
        {
            return messageAboutError;
        }
       
    }
}
