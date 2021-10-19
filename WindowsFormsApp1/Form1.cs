using System;
using System.Windows.Forms;

namespace Lab_3
{
    public partial class Form1 : Form
    {
        
        HSV hsv;
        HelperForm helper;         //Отвечает за проверку данных на корректность    
        bool switchHSBtoRGB;       //Отвечает за переключение полей с элементами для ввода ргб или хсв
        //---------------------------------------------------------------------------------------------------------------------------------------
        public Form1()
        {
            InitializeComponent();

            switchHSBtoRGB = true; //доступен конвертатор с хсв к ргб
            hsv = new HSV();
            helper = new HelperForm();
                                  //Индексы с выбранными значениями по умолчанию устанавливаем 0
            comboBoxColor.SelectedIndex = comboBoxDates1.SelectedIndex = 0;
            comboBoxDates2.SelectedIndex = comboBoxDates3.SelectedIndex = 0;
            comboBoxSymbol1.SelectedIndex = comboBoxSymbol2.SelectedIndex = comboBoxSymbol3.SelectedIndex = 0;

            pictureBoxReplacerRGB_HSV.SizeMode = PictureBoxSizeMode.StretchImage; //Устанавливаем картинку между HSV и RGB лейблами,где происходит конвертация
            toolTip1.SetToolTip(Question,"Red = [0;120) и 360,\nGreen = [120;240),\nBlue = [240;360).\nТолько для градусов");
            
            toolTip1.AutomaticDelay = 100; //Подсказка высплювающая
            toolTip1.AutoPopDelay = 5000;
        }
        //---------------------------------------------------------------------------------------------------------------------------------------
        private void comboBoxColor_SelectedIndexChanged(object sender, EventArgs e)        //Если первое поле с текстом(цвет) изменено, то выводим этот цвет в градусах для хсв в поле ввода для цвета      
        {
            ComboBox comb = (ComboBox)sender;

            if (comboBoxDates1.SelectedIndex == 0)                                         //Если выбраны градусы
            {
                comboBoxDates1.SelectedIndex = 0;                                          //Обнулить бокс с типом данных цвета
                textBoxColor1.Text = helper.getColorByIndex(comboBoxColor.SelectedIndex);  //Приравниваем поле с цветом к цвету(градусы),  в соответствии с выбранным в боксе для цвета(red, green, blue) стоит слева
            }
            else comboBoxColor.SelectedIndex = -1;                                         //Если не градусы, то убираем значения цветов с поля слева
        }
        //---------------------------------------------------------------------------------------------------------------------------------------
        private void textBox_Leave(object sender, EventArgs e)  //В случае, если мы покидаем поля ввода для хсв, то начинаем проверку введенных данных
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
        //---------------------------------------------------------------------------------------------------------------------------------------
        private void textBoxColor1_Leave(object sender, EventArgs e)                    //Здесь тоже осуществляем проверку, в случае, если покидаем поле с вводом цвета, но она более расширенная(т. к 3ри значения)
        {
            if (helper.diapasonValuesIsValid(textBoxColor1.Text, comboBoxDates1.Text, 1))//Если данные цвета корректны
            {                                                                   
                double colorValue = Convert.ToDouble(textBoxColor1.Text);

                if (comboBoxDates1.SelectedIndex == 0)                                  //если выбранный тип данных - градусы
                {
                    if(hsv.colorInItsRange(colorValue, comboBoxColor.Text))             //Смотрим входит ли эи градусы в текщий дтиапазон цвета
                    {
                        textBoxColor1.Text = Convert.ToString(colorValue);
                    }
                    else
                    {
                        MessageBox.Show(hsv.getMessageError());                                   //Показать сообщение об ошибке
                        textBoxColor1.Text = helper.getColorByIndex(comboBoxColor.SelectedIndex); //Сбросить поле до нужного цвета
                    }
                   
                }  
                else comboBoxColor.SelectedIndex = -1;                                   //Если не градусы, то убрать тип данных цвета
            }
            else
            {
                MessageBox.Show(helper.getMessageError());
                textBoxColor1.Text = "0";
                comboBoxColor.SelectedIndex = 0;
            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------------
        private void comboBoxDates1_SelectedIndexChanged(object sender, EventArgs e)//Если меняем тип данных для цвета
        {                                                  //Если комбо бокс выбора единиц измерения цвета изменить, то
            textBoxColor1.Text = textBoxColor2.Text = "0"; //Обнулить поле со значением цвета
            comboBoxColor.SelectedIndex = 0;               //комбо бокс выбора цвета по умолчанию на красный

            if (comboBoxDates1.SelectedIndex != 0)
                comboBoxColor.SelectedIndex = -1;              //Убрать значение цвета для бокса, если не градусы выбраны
            else
                comboBoxColor.SelectedIndex = 0;               //Значение цвета для бокса, если градусы выбраны, теперь красный
        }
        //---------------------------------------------------------------------------------------------------------------------------------------
        private void comboBoxDates2_SelectedIndexChanged(object sender, EventArgs e)  //Если меняем тип данных для насыщенности
        {
           textBoxSaturation1.Text = textBoxSaturation2.Text = "0";                   //Обнуляем поля
        }
        //---------------------------------------------------------------------------------------------------------------------------------------
        private void comboBoxDates3_SelectedIndexChanged(object sender, EventArgs e)  //Если меняем тип данных для яркости
        {
            textBoxBright1.Text = textBoxBright2.Text = "0";                          //Обнуляем поля
        }
        //---------------------------------------------------------------------------------------------------------------------------------------
        private void comboBoxSymbol1_SelectedIndexChanged(object sender, EventArgs e) //Если мы вычитаем или прибавлаем доп значение для цвета, то осущ проверку данных
        {
            bool checkFirstField = helper.diapasonValuesIsValid(textBoxColor1.Text, comboBoxDates1.Text, 1);    //Проверить первое поле цвета
            bool checkSecondField = helper.diapasonValuesIsValid(textBoxColor2.Text, comboBoxDates1.Text, 2);   //Проверить второе поле
             
            if (checkFirstField == false || checkSecondField == false)                                          //Если какое то поле имеет некорректные данные
            {
                MessageBox.Show("Внимание!Проверьте правильность введенных данных полей №1 и №2");             //Выводим сообщение об ошибке
            }
            else    //Если данные корректны
            {
                double endColor = hsv.plusMinusValue(Convert.ToDouble(textBoxColor1.Text),
                    comboBoxSymbol1.Text, Convert.ToDouble(textBoxColor2.Text)); //Плюс минус к цвету

                if (comboBoxDates1.SelectedIndex == 0 &&
                    hsv.colorInItsRange(endColor, comboBoxColor.Text))   //Если цвет входит в свой диапазон(только градусы)
                {                                                        //и соответсвует выбранному в комбо боксе цвету,то
                    
                    textBoxColor1.Text = Convert.ToString(endColor);     //Заменяем текущие данные на новые (вычтенные/добавленные)
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
            }                                                          //Комбо бокс меняется в соответствии с выбранным цветом
            textBoxColor2.Text = "0";                                   //Обнюляем значение, которое нужно было добавить
        }
        //---------------------------------------------------------------------------------------------------------------------------------------
        private void comboBoxSymbol2And3_SelectedIndexChanged(object sender, EventArgs e) //Если хотим добавить/вычесть значения для полей насыщенность и яркость
        {
            ComboBox signBox = (ComboBox)sender;        //Бокс, который содержи знак
            TextBox field1 = null;                      //Сохраняем первоначальное поле
            TextBox field2 = null;                      //Сохраняем поле, значение которого нало прибавить
            ComboBox fieldCmbBox = null;                //Сохраняем комбо бокс, который содержит типданный

            bool checkFirstField;                       //Проверяет на корретные данные первое поле
            bool checkSecondField;                      //Аналогично со вторым

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


                if (checkFirstField == false || checkSecondField == false) //Если какое то поле некорректно, то сооб ошиб
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
                    else MessageBox.Show(helper.getMessageError());        //Иначе сообшить об ошибке
                        
                }
                //signBox.SelectedIndex = -1;                              //Возвращаем действие бокса в исходное, пустое состояние
                field2.Text = "0";                                         //Обнюляем значение, которое нужно было добавить
            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------------
        private void button1_ClickToRGB(object sender, EventArgs e)        //Конвертируем HSV в RGB
        {
            bool H = helper.diapasonValuesIsValid(textBoxColor1.Text,comboBoxDates1.Text,1);
            bool S = helper.diapasonValuesIsValid(textBoxSaturation1.Text, comboBoxDates2.Text, 3);
            bool B = helper.diapasonValuesIsValid(textBoxBright1.Text, comboBoxDates3.Text, 5);

            if (H != false && S != false && B != false) //Если все данные корректны
            {         //Проверяем коректности всех полей
                double h = hsv.convertToDegrees(comboBoxDates1.Text, Convert.ToDouble(textBoxColor1.Text));
                double s = hsv.convertValueToPersent(comboBoxDates2.Text, Convert.ToDouble(textBoxSaturation1.Text));
                double v = hsv.convertValueToPersent(comboBoxDates3.Text, Convert.ToDouble(textBoxBright1.Text));

                int[]RGB = hsv.HSVtoRGB(h,s,v);                                                    //Переводим хсв в ргб
                pictureBoxColor.BackColor = System.Drawing.Color.FromArgb(RGB[0], RGB[1], RGB[2]); //Красим большой квадрат

                textBoxR.Text = Convert.ToString(RGB[0]);               //Выводим полученные значения в поля RGB    
                textBoxG.Text = Convert.ToString(RGB[1]); 
                textBoxB.Text = Convert.ToString(RGB[2]);
            }
            else                                                        //Если нет, то делаем сброс значений
            {
                textBoxR.Text = textBoxG.Text = textBoxB.Text = "0";
                pictureBoxColor.BackColor =System.Drawing.Color.Black;
            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------------
        private void button1_ClickToHSV(object sender, EventArgs e)      //Конвертируем RGB в HSV
        {
            bool R = helper.diapasonValuesIsValid(numericUpDownRed.Text, "RGB", 1);
            bool G = helper.diapasonValuesIsValid(numericUpDownGreen.Text, "RGB", 2);
            bool B = helper.diapasonValuesIsValid(numericUpDownBlue.Text, "RGB", 3);

            if (R != false && G != false && B != false)                   //Если все данные корректны
            {
                RGB rgb = new RGB();

                int r = Convert.ToInt32(numericUpDownRed.Text); 
                int g = Convert.ToInt32(numericUpDownGreen.Text);
                int b = Convert.ToInt32(numericUpDownBlue.Text);

                int[] HSV = rgb.RGBtoHSV(r,g,b); 
               
                pictureBoxColor.BackColor = System.Drawing.Color.FromArgb(r, g, b); //Красим большой квадрат

                textBoxH.Text = Convert.ToString((int)HSV[0]);                      //Выводим полученные значения в поля RGB    
                textBoxS.Text = Convert.ToString((int)HSV[1]);
                textBoxV.Text = Convert.ToString((int)HSV[2]);
            }
            else                                                                    //Если нет, то делаем сброс значений
            {
                textBoxH.Text = textBoxS.Text = textBoxV.Text = "0";
                pictureBoxColor.BackColor = System.Drawing.Color.Black;
            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------------
        private void textBoxColor1_TextChanged(object sender, EventArgs e)
        {
            textBoxH.Text = textBoxColor1.Text;
        }
        //---------------------------------------------------------------------------------------------------------------------------------------
        private void textBoxSaturation1_TextChanged(object sender, EventArgs e)
        {
            textBoxS.Text = textBoxSaturation1.Text;
        }
        //---------------------------------------------------------------------------------------------------------------------------------------
        private void textBoxBright1_TextChanged(object sender, EventArgs e)
        {
            textBoxV.Text = textBoxBright1.Text;
        }
        //---------------------------------------------------------------------------------------------------------------------------------------
        private void textBoxColor1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
                textBoxColor2.Focus();
        }
        //---------------------------------------------------------------------------------------------------------------------------------------
        private void textBoxColor2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
                textBoxSaturation1.Focus();
        }
        //---------------------------------------------------------------------------------------------------------------------------------------
        private void textBoxSaturation1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
                textBoxSaturation2.Focus();
        }
        //---------------------------------------------------------------------------------------------------------------------------------------
        private void textBoxSaturation2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
                textBoxBright1.Focus();
        }
        //---------------------------------------------------------------------------------------------------------------------------------------
        private void textBoxBright1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
                textBoxBright2.Focus();
        }
        //---------------------------------------------------------------------------------------------------------------------------------------
        private void textBoxBright2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
                textBoxColor1.Focus();
        }
        //---------------------------------------------------------------------------------------------------------------------------------------
        private void numericUpDownRed_Leave(object sender, EventArgs e)
        {
            textBoxR.Text = numericUpDownRed.Text;                   //Приравниваем к полю, содержащему красный цвет значение
        }
        //---------------------------------------------------------------------------------------------------------------------------------------
        private void numericUpDownGreen_Leave(object sender, EventArgs e)
        {
            textBoxG.Text = numericUpDownGreen.Text;                 //Приравниваем к полю, содержащему зеленый цвет значение

        }
        //---------------------------------------------------------------------------------------------------------------------------------------
        private void numericUpDownBlue_Leave(object sender, EventArgs e)
        {
            textBoxB.Text = numericUpDownBlue.Text;                  //Приравниваем к полю, содержащему синий цвет значение
        }
        //---------------------------------------------------------------------------------------------------------------------------------------
        /*
         * Принцип работы события pictureBoxReplacerRGB_HSV_Click
         * 1)По нажатию кнопки смены вида конвертации RGB/HSV мы меняем местами кнопоки с надписями
         * 2)Делаем невидимое поле RGB/HSV видимым, а противоположное невидимым и меняем их местами
         * 3)Меняем надпись на кнопке, которая осуществляет конвертацию данных
         * 4)Меняем событие этой кнопки на противоположное(если у нас было событие с именем button1_ClickToHSV, то оно изменится на button1_ClickToRGB, а старое вичитаем(убираем))
         * 5)Так же не забываем занулить поля с введенными данными в зависимости от того, какое поле было закрыто
         */
        private void pictureBoxReplacerRGB_HSV_Click(object sender, EventArgs e)  //Если нажали маленькую кнопку между ргб и хсв, то меняем поля для ввода данных чсв или ргб
        {
            if (switchHSBtoRGB == true)                              //если был выбран HSV in RGB
            {
                groupBoxHSV.Visible = false;                         //Теперь мы не сможем изменять hsv поля
                groupBoxRGB.Visible = true;                          //Но сможет изменять RGB поля
                switchHSBtoRGB = false;                              //Переключились на RGB

                textBoxH.Text = textBoxS.Text = textBoxV.Text = "0"; //Обнуляем значения полей HSV(в конвертере)
                textBoxR.Text = textBoxG.Text = textBoxB.Text = "0"; //Обнуляем значения полей RGB(в конвертере)

                textBoxColor1.Text = textBoxColor2.Text = "0";       //Обнуляем все поля HSV
                textBoxSaturation1.Text = textBoxSaturation2.Text = "0";
                textBoxBright1.Text = textBoxBright2.Text = "0";
                                                                     //Делаем по умолчанию все выпадающие списки
                comboBoxColor.SelectedIndex = comboBoxDates1.SelectedIndex = comboBoxDates2.SelectedIndex
                    = comboBoxDates3.SelectedIndex = comboBoxSymbol1.SelectedIndex 
                    = comboBoxSymbol2.SelectedIndex = comboBoxSymbol3.SelectedIndex = 0;

                buttonConverter.Text = "to HSV";                     //Изменяем текст кнопки конвертера

                buttonConverter.Click += new System.EventHandler(this.button1_ClickToHSV);
                buttonConverter.Click -= new System.EventHandler(this.button1_ClickToRGB);
            }
            else
            {
                groupBoxHSV.Visible = true;                           //Теперь мы сможем изменять HSV поля
                groupBoxRGB.Visible = false;                          //Но не сможем изменять RGB поля
                switchHSBtoRGB = true;                                //Переключились на HSV

                textBoxR.Text = textBoxG.Text = textBoxB.Text = "0";  //Обнуляем значения полей RGB
                textBoxH.Text = textBoxS.Text = textBoxV.Text = "0";  //Обнуляем значения полей HSV
                buttonConverter.Text = "to RGB";                      //Изменяем текст кнопки конвертера
                                                                     
                numericUpDownRed.Value = numericUpDownGreen.Value = numericUpDownBlue.Value = 0; //обнуляем поля ргб, где вводятся значения
                buttonConverter.Click += new System.EventHandler(this.button1_ClickToRGB);
                buttonConverter.Click -= new System.EventHandler(this.button1_ClickToHSV);
            }

            System.Drawing.Point locationHSV = groupBoxHSV.Location;  
            groupBoxHSV.Location = groupBoxRGB.Location;
            groupBoxRGB.Location = locationHSV;

            System.Drawing.Point saveHSVLocation = labelHSV.Location;
            labelHSV.Location = labelRGB.Location;
            labelRGB.Location = saveHSVLocation;
            pictureBoxColor.BackColor = System.Drawing.Color.Black;
            
        }
    }
}
