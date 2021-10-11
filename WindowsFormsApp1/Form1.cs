using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        
        HSV hsv;
        HelperForm helper;
        public Form1()
        {
            InitializeComponent();
            hsv = new HSV();
            helper = new HelperForm();
            comboBoxColor.SelectedIndex = comboBoxDates1.SelectedIndex = 0;
            comboBoxDates2.SelectedIndex = comboBoxDates3.SelectedIndex = 0;       
        }
        private void comboBoxColor_SelectedIndexChanged(object sender, EventArgs e)       //Если первое поле с текстом(цвет) изменено
        {
            ComboBox comb = (ComboBox)sender;

            if (comboBoxDates1.SelectedIndex == 0)                                        //Если выбраны градусы
            {
                comboBoxDates1.SelectedIndex = 0;                                         //Обнулить бокс с типом данных цвета
                textBoxColor1.Text = helper.getColorByIndex(comboBoxColor.SelectedIndex);  //Приравниваем поле с цветом к цвету(градусы),  в соответствии с выбранным в боксе для цвета(red, green, blue) стоит слева
            }
            else comboBoxColor.SelectedIndex = -1;   //Если не градусы, то убираем значения цветов с поля слева
        }

        private void textBox_Leave(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            String typeDate = "";                       //НУжен для единиц измерения
            int keepTagElem = Convert.ToInt32(txt.Tag); //Содержит тег текущего элемента(номер бокса 1-6)

            switch (keepTagElem)                        //Смотрим номер выюранного текст бокса
            {                                           //Первый отдельно обрабатывается
                                                        // с определенного комбо бокса
                case 3:                                 //Насыщенность
                    typeDate = comboBoxDates2.Text; 
                    break;
                case 5:                                 //Яркость
                    typeDate = comboBoxDates3.Text;
                    break;
                case 2:                                 //Добавить цвет
                    typeDate = comboBoxDates1.Text; 
                    break;
                case 4:                                 //Добавить  Насыщенность         
                    typeDate = comboBoxDates2.Text;  
                    break;
                case 6:                                 //Добавить Яркость
                    typeDate = comboBoxDates3.Text; 
                    break;
            }

            if (!helper.diapasonValuesIsValid(txt.Text, typeDate, keepTagElem))
            {
                MessageBox.Show(helper.getMessageError());
                txt.Text = "0";
 
            }                           
        }
        private void textBoxColor1_Leave(object sender, EventArgs e)
        {
            if (helper.diapasonValuesIsValid(textBoxColor1.Text, comboBoxDates1.Text, 1))
            {                                                                   //Если данные цвета действительны
                double colorValue = Convert.ToDouble(textBoxColor1.Text);
                if (!(hsv.colorInItsRange(colorValue, comboBoxColor.Text, comboBoxDates1.Text)))
                {                                                              //Если цвет не входит в диапазон
                    if (comboBoxDates1.SelectedIndex == 0)
                    {                                                          //Если тип данных градусы
                        MessageBox.Show(hsv.getMessageError());                //Показать сообщение об ошибке
                        textBoxColor1.Text = helper.getColorByIndex(comboBoxColor.SelectedIndex); //Сбросить поле до нужного цвета
                    }  
                    else comboBoxColor.SelectedIndex = -1;                     //Если не градусы, то убрать тип данных цвета
                }
            }
            else
            {
                MessageBox.Show(helper.getMessageError());
                textBoxColor1.Text = "0";
                comboBoxColor.SelectedIndex = 0;
            }
        }
        private void comboBoxDates1_SelectedIndexChanged(object sender, EventArgs e)
        {                                                  //Если комбо бокс выбора единиц измерения цвета изменить, то
            textBoxColor1.Text = textBoxColor2.Text = "0"; //Обнулить поле со значением цвета
            comboBoxColor.SelectedIndex = 0;               //комбо бокс выбора цвета по умолчанию на красный
            comboBoxSymbol1.SelectedIndex = -1;            //бокс выбора знака очистить

            if (comboBoxDates1.SelectedIndex != 0)
                comboBoxColor.SelectedIndex = -1;              //Убрать значение цвета для бокса, если не градусы выбраны
            else
                comboBoxColor.SelectedIndex = 0;               //Значение цвета для бокса, если градусы выбраны, теперь красный
        }

        private void comboBoxDates2_SelectedIndexChanged(object sender, EventArgs e)
        {
           textBoxSaturation1.Text = textBoxSaturation2.Text = "0";
           comboBoxSymbol2.SelectedIndex = -1;
        }

        private void comboBoxDates3_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxBright1.Text = textBoxBright2.Text = "0";
            comboBoxSymbol3.SelectedIndex = -1;
        }

        private void comboBoxSymbol1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool checkFirstField = helper.diapasonValuesIsValid(textBoxColor1.Text, comboBoxDates1.Text, 1); //П
            bool checkSecondField = helper.diapasonValuesIsValid(textBoxColor2.Text, comboBoxDates1.Text, 2);

            if (checkFirstField == false || checkSecondField == false)          //Если какое то поле имеет некорректные данные
            {
                MessageBox.Show("Внимание!Проверьте правильность введенных данных полей №1 и №2");
            }
            else    //Если данные корректны
            {
                double endColor = hsv.plusMinusValue(Convert.ToDouble(textBoxColor1.Text),
                    comboBoxSymbol1.Text, Convert.ToDouble(textBoxColor2.Text)); //Плюс мину к цвету

                if (comboBoxDates1.SelectedIndex == 0 &&
                    hsv.colorInItsRange(endColor, comboBoxColor.Text, comboBoxDates1.Text)) //Если цвет входит в свой диапазон(градусы)
                {                                                        //и соответсвует выбранному в комбо боксе цвету,то
                    textBoxColor1.Text = Convert.ToString(endColor);     //Заменяем текущие данные на добавленные
                }
                else if (comboBoxDates1.SelectedIndex == 0)
                {
                    MessageBox.Show(hsv.getMessageError());              //Выводим сообщение об ошибке
                }
                else if (helper.diapasonValuesIsValid(Convert.ToString(endColor), comboBoxDates1.Text, 1))
                {              //Значит выбраны другие единицы измерения, помимо градусов(%, pt.) и их биапазон корректен, то
                    textBoxColor1.Text = Convert.ToString(endColor);
                }
                else                                                   //Если же диапазон этих единиц измерения некорректен, то
                {
                    MessageBox.Show(helper.getMessageError());
                } 
            }                                                //Комбо бокс меняется в соответствии с выбранным цветом
            comboBoxSymbol1.SelectedIndex = -1;              //Возвращаем действие бокса в исходное, пустое состояние
            textBoxColor2.Text = "0";                        //Обнюляем значение, которое нужно было добавить
        }

        private void comboBoxSymbol2And3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox signBox = (ComboBox)sender;     //Бокс, который содержи знак
            TextBox field1 = null;                   //Сохраняем первоначальное поле
            TextBox field2 = null;                   //Сохраняем поле, значение которого нало прибавить
            ComboBox fieldCmbBox = null;             //Сохраняем комбо бокс, который содержит типданный

            bool checkFirstField;                    //Проверяет на корретные данные первое поле
            bool checkSecondField;                   //Аналогично со вторым

            String endValue;                            //Содержит сумму полей

            int keepTag = Convert.ToInt32(signBox.Tag); //Содержит номер бокса со знаком

            switch (keepTag){                           //Первый бокс отдельно обрабатывается
                case 2:
                    field1 = textBoxSaturation1;
                    field2 = textBoxSaturation2;
                    fieldCmbBox = comboBoxDates2;
                    break;
                case 3:
                    field1 = textBoxBright1;
                    field2 = textBoxBright2;
                    fieldCmbBox = comboBoxDates3;
                    break;
            }

            if(field1 != null && field2 != null && fieldCmbBox != null)   //Если данные поля1 и 2 и бокса существуют, то
            {
                checkFirstField = helper.diapasonValuesIsValid(field1.Text, fieldCmbBox.Text,
                    Convert.ToInt32(field1.Tag));                         //Проверить корректность анных поля 1
                checkSecondField = helper.diapasonValuesIsValid(field2.Text, fieldCmbBox.Text, 
                    Convert.ToInt32(field2.Tag));                         //Проверить корректность анных поля 2


                if (checkFirstField == false || checkSecondField == false) //Если какое то поле некорректно, то сооб об ошиб
                {
                    MessageBox.Show(helper.getMessageError());
                }
                else                                                       //Иначе сложить или вычесть поле1 со 2ым и 
                {
                    endValue = Convert.ToString(hsv.plusMinusValue(Convert.ToDouble(field1.Text),signBox.Text,
                        Convert.ToDouble(field2.Text)));
                    if (helper.diapasonValuesIsValid(endValue, fieldCmbBox.Text,
                        Convert.ToInt32(field1.Tag)))                      //Если полученное значение входит в допустимый диап данных
                    {
                        field1.Text = endValue;                            //Приравнять к 1ому полю получившееся значение
                    }
                    else MessageBox.Show(helper.getMessageError());         //Иначе сообшить об ошибке
                        
                }
                signBox.SelectedIndex = -1;                                    //Возвращаем действие бокса в исходное, пустое состояние
                field2.Text = "0";                                             //Обнюляем значение, которое нужно было добавить
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool H = helper.diapasonValuesIsValid(textBoxColor1.Text,comboBoxDates1.Text,1);
            bool S = helper.diapasonValuesIsValid(textBoxSaturation1.Text, comboBoxDates2.Text, 3);
            bool B = helper.diapasonValuesIsValid(textBoxBright1.Text, comboBoxDates3.Text, 5);

            if(H != false && S != false && B != false) //Если все данные корректны
            {         //Проверяем коректности всех полей
                double h = hsv.convertColorToDegrees(comboBoxDates1.Text, Convert.ToDouble(textBoxColor1.Text));
                double s = hsv.convertValueToPersent(comboBoxDates2.Text, Convert.ToDouble(textBoxSaturation1.Text));
                double v = hsv.convertValueToPersent(comboBoxDates3.Text, Convert.ToDouble(textBoxBright1.Text));

                int[]RGB = hsv.HSVtoRGB(h,s,v);                        //Переводим хсв в ргб
                textBoxRGB.Text =$"rgb({RGB[0]}, {RGB[1]}, {RGB[2]})"; //выводим ответ
                pictureBox1.BackColor = System.Drawing.Color.FromArgb(RGB[0], RGB[1], RGB[2]); //Красим большой квадрат
            }
            else                                                        //Если нет, то делаем сброс значений
            {
                textBoxRGB.Text = "rgb(0, 0, 0)";
                pictureBox1.BackColor =System.Drawing.Color.Black;
            }
        }

        private void textBoxColor1_TextChanged(object sender, EventArgs e)
        {
            textBoxH.Text = textBoxColor1.Text;
        }

        private void textBoxSaturation1_TextChanged(object sender, EventArgs e)
        {
            textBoxS.Text = textBoxSaturation1.Text;
        }

        private void textBoxBright1_TextChanged(object sender, EventArgs e)
        {
            textBoxV.Text = textBoxBright1.Text;
        }

        private void textBoxColor1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
                textBoxColor2.Focus();
        }

        private void textBoxColor2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
                textBoxSaturation1.Focus();
        }

        private void textBoxSaturation1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
                textBoxSaturation2.Focus();
        }

        private void textBoxSaturation2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
                textBoxBright1.Focus();
        }

        private void textBoxBright1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
                textBoxBright2.Focus();
        }

        private void textBoxBright2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
                textBoxColor1.Focus();
        }
    }
}
