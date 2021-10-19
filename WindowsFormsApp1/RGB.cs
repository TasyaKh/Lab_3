using System;

namespace Lab_3
{
    public class RGB
    {
        private float[] findMaxMin(float[] values) //Находит максимальное и минимальное значение переданного массива
        {
            float max = values[0];
            float min = values[0];

            foreach (float value in values)
            {
                if (max < value)
                    max = value;

                if (min > value)
                    min = value;
            }

            return new float[] { max, min };
        }
        public int[] RGBtoHSV(int red, int green, int blue)
        {
            float[] HSV = new float[3];     //Здесь хранятся значения (цвет, насыщенность, яркость)
                               
            float[] keepMaxMin;             //Храним максимальное и минимальное значения

            float R = (float)red / 255;     //Red
            float G = (float)green / 255;   //Green
            float B = (float)blue / 255;    //Blue

            keepMaxMin = findMaxMin(new float[] {R,G,B});

            float Cmax = keepMaxMin[0];    //Для удобства извлечем эти значения в отдельные переменные
            float Cmin = keepMaxMin[1];

            float delta = Cmax - Cmin;     //Находим разность между минимумом и максимумом
                                           //Все вопросы к викепедии
            //Находим H 
            if(delta == 0)
            {
                HSV[0] = 0;
            }
            else if(Cmax == R && G>=B)
            {
                HSV[0] = 60 * ((G - B) / delta);
            }
            else if(Cmax == R && G < B)
            {
                HSV[0] = (60 * ((G - B) / delta)) + 360;
            }
            else if(Cmax == G)// Значит Cmax = B
            {
                HSV[0] = (60 * (B - R) / delta) + 120;
            }
            else if(Cmax == B)
            {
                HSV[0] = (60 * ((R - G) / delta)) + 240;
            }

            //Находим S
            if (Cmax == 0)
            {
                HSV[1] = 0;
            }
            else
            {
                HSV[1] = 1 - Cmin / Cmax;
            }

            //Находим B
            HSV[2] = Cmax;
            //Обрезаем значения
            return new int[] { (int)Math.Round(HSV[0],0, MidpointRounding.AwayFromZero),
               (int) Math.Round(HSV[1]*100,0, MidpointRounding.AwayFromZero),
                (int)Math.Round(HSV[2]*100,0, MidpointRounding.AwayFromZero)};
        }
    }
}
