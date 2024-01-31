using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Control_mode : Form
    {
        //Введенное число
        private string value;
        //Итоговое число без 0
        private string result0;
        //Итоговое число
        private string result;
        //Количество незначащих нулей
        private int length0;
        //Знак числа (+/-)
        private string znak;
        //целая часть вещественного числа
        private int whole;
        //порядок вещественного числа
        private string order;
        //дробная часть вещественного числа
        private double fractional;
        //мантисса вещественного числа
        private string mantissa;
        //константа для вещественного числа
        private int constanta;
        public Control_mode()
        {
            InitializeComponent();
        }

        //Вернуться в меню
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu_с = new Menu();
            menu_с.Show();
        }

        //Подсчет результата 
        private void translation_Click(object sender, EventArgs e)
        {
            value = textBox1.Text;
            if (value == null || value == "")
            {
                return;
            }
            if (comboBox1.SelectedItem == null)
            {
                return;
            }
            result0 = "";
            string selectedType = comboBox1.SelectedItem.ToString();
            switch (selectedType)
            {
                case "sbyte":
                    sbyte value1;
                    try
                    {
                        value1 = sbyte.Parse(value);
                        if (value1 < 0)
                        {
                            znak = "1";
                            if (value1 == -128)
                                result = "0000000";
                            else
                            {
                                value1 = Math.Abs(value1);
                                value1--;
                                result0 = Convert.ToString(value1, 2);
                                //обратный код
                                result0 = result0.Replace("0", "2");
                                result0 = result0.Replace("1", "0");
                                result0 = result0.Replace("2", "1");
                                //перевод незначащих 0 в 1
                                length0 = 7 - result0.Length;
                                for (int i = 0; i < length0; i++)
                                    result = result + "1";
                            }
                        }
                        else
                        {
                            znak = "0";
                            result0 = Convert.ToString(value1, 2);
                            length0 = 7 - result0.Length;
                            for (int i = 0; i < length0; i++)
                                result = result + "0";
                        }
                        result = znak + result + result0;
                    }
                    //выход за пределы
                    catch (OverflowException)
                    {
                        result = "Некорректные данные";
                    }
                    //неверный формат (например не целое число)
                    catch (System.FormatException)
                    {
                        result = "Некорректные данные";
                    }
                    break;

                case "short":
                    short value2;
                    try
                    {
                        value2 = short.Parse(value);
                        if (value2 < 0)
                        {
                            znak = "1";
                            if (value2 == -32768)
                                result = "000000000000000";
                            else
                            {
                                value2 = Math.Abs(value2);
                                value2--;
                                result0 = Convert.ToString(value2, 2);
                                //обратный код
                                result0 = result0.Replace("0", "2");
                                result0 = result0.Replace("1", "0");
                                result0 = result0.Replace("2", "1");
                                //
                                length0 = 15 - result0.Length;
                                for (int i = 0; i < length0; i++)
                                    result = result + "1";
                            }
                        }
                        else
                        {
                            znak = "0";
                            result0 = Convert.ToString(value2, 2);
                            length0 = 15 - result0.Length;
                            for (int i = 0; i < length0; i++)
                                result = result + "0";
                        }
                        result = znak + result + result0;
                    }
                    //выход за пределы
                    catch (OverflowException)
                    {
                        result = "Некорректные данные";
                    }
                    //неверный формат (например не целое число)
                    catch (System.FormatException)
                    {
                        result = "Некорректные данные";
                    }
                    break;

                case "int":
                    int value3;
                    try
                    {
                        value3 = int.Parse(value);
                        if (value3 < 0)
                        {
                            znak = "1";
                            if (value3 == -2147483648)
                                result = "0000000000000000000000000000000";
                            else
                            {
                                value3 = Math.Abs(value3);
                                value3--;
                                result0 = Convert.ToString(value3, 2);
                                //обратный код
                                result0 = result0.Replace("0", "2");
                                result0 = result0.Replace("1", "0");
                                result0 = result0.Replace("2", "1");
                                //
                                length0 = 31 - result0.Length;
                                for (int i = 0; i < length0; i++)
                                    result = result + "1";
                            }
                        }
                        else
                        {
                            znak = "0";
                            result0 = Convert.ToString(value3, 2);
                            length0 = 31 - result0.Length;
                            for (int i = 0; i < length0; i++)
                                result = result + "0";
                        }
                        result = znak + result + result0;
                    }
                    //выход за пределы
                    catch (OverflowException)
                    {
                        result = "Некорректные данные";
                    }
                    //неверный формат (например не целое число)
                    catch (System.FormatException)
                    {
                        result = "Некорректные данные";
                    }
                    break;

                case "long":
                    long value4;
                    try
                    {
                        value4 = long.Parse(value);
                        if (value4 < 0)
                        {
                            znak = "1";
                            if (value4 == -9223372036854775808)
                                result = "000000000000000000000000000000000000000000000000000000000000000";
                            else
                            {
                                value4 = Math.Abs(value4);
                                value4--;
                                result0 = Convert.ToString(value4, 2);
                                //обратный код
                                result0 = result0.Replace("0", "2");
                                result0 = result0.Replace("1", "0");
                                result0 = result0.Replace("2", "1");
                                //
                                length0 = 63 - result0.Length;
                                for (int i = 0; i < length0; i++)
                                    result = result + "1";
                            }
                        }
                        else
                        {
                            znak = "0";
                            result0 = Convert.ToString(value4, 2);
                            length0 = 63 - result0.Length;
                            for (int i = 0; i < length0; i++)
                                result = result + "0";
                        }
                        result = znak + result + result0;
                    }
                    //выход за пределы
                    catch (OverflowException)
                    {
                        result = "Некорректные данные";
                    }
                    //неверный формат (например не целое число)
                    catch (System.FormatException)
                    {
                        result = "Некорректные данные";
                    }
                    break;

                case "byte":
                    byte value5;
                    try
                    {
                        value5 = byte.Parse(value);
                        result0 = Convert.ToString(value5, 2);
                        length0 = 8 - result0.Length;
                        for (int i = 0; i < length0; i++)
                            result = result + "0";
                        result = result + result0;
                    }
                    //выход за пределы
                    catch (OverflowException)
                    {
                        result = "Некорректные данные";
                    }
                    //неверный формат (например не целое число)
                    catch (System.FormatException)
                    {
                        result = "Некорректные данные";
                    }
                    break;

                case "ushort":
                    ushort value6;
                    try
                    {
                        value6 = ushort.Parse(value);
                        result0 = Convert.ToString(value6, 2);
                        length0 = 16 - result0.Length;
                        for (int i = 0; i < length0; i++)
                            result = result + "0";
                        result = result + result0;
                    }
                    //выход за пределы
                    catch (OverflowException)
                    {
                        result = "Некорректные данные";
                    }
                    //неверный формат (например не целое число)
                    catch (System.FormatException)
                    {
                        result = "Некорректные данные";
                    }
                    break;

                case "uint":
                    uint value7;
                    try
                    {
                        value7 = uint.Parse(value);
                        result0 = Convert.ToString(value7, 2);
                        length0 = 32 - result0.Length;
                        for (int i = 0; i < length0; i++)
                            result = result + "0";
                        result = result + result0;
                    }
                    //выход за пределы
                    catch (OverflowException)
                    {
                        result = "Некорректные данные";
                    }
                    //неверный формат (например не целое число)
                    catch (System.FormatException)
                    {
                        result = "Некорректные данные";
                    }
                    break;

                case "ulong":
                    ulong value8;
                    try
                    {
                        value8 = ulong.Parse(value);
                        result0 = Convert.ToString(unchecked((long)value8), 2);
                        length0 = 64 - result0.Length;
                        for (int i = 0; i < length0; i++)
                            result = result + "0";
                        result = result + result0;
                    }
                    //выход за пределы
                    catch (OverflowException)
                    {
                        result = "Некорректные данные";
                    }
                    //неверный формат (например не целое число)
                    catch (System.FormatException)
                    {
                        result = "Некорректные данные";
                    }
                    break;

                case "float":// 7 знаков точности
                    constanta = 127;
                    mantissa = "";
                    double value01;
                    try
                    {
                        value01 = double.Parse(value);
                        //целая часть числа
                        whole = (int)Math.Truncate(value01);
                        //дробная часть числа
                        fractional = Math.Abs(value01 - whole);
                        //программа перевода вещественного числа в двоичную
                        int flag = 1;
                        for (int i = 0; (i < 32 + 7) && flag == 1; i++)
                        {
                            if (fractional * 2 >= 1)
                            {
                                mantissa = mantissa + "1";
                                fractional = fractional * 2 - 1;
                            }
                            else
                            {
                                mantissa = mantissa + "0";
                                fractional *= 2;
                            }
                            if (fractional == 1)
                            {
                                flag = 0;
                            }
                        }
                        //определение знака мантиссы
                        if (value01 < 0)
                        {
                            znak = "1";
                            whole = Math.Abs(whole);
                        }
                        else
                            znak = "0";
                        if (whole == 0)
                        {
                            //первое вхождение 1 для определения значения порядка
                            int indexOf1 = mantissa.IndexOf("1");
                            constanta = constanta - indexOf1 - 1;
                            mantissa = mantissa.Substring(indexOf1 + 1);
                        }
                        else
                        {
                            order = Convert.ToString(whole, 2);
                            //подсчет значения порядка
                            constanta = constanta + order.Length - 1;
                            //добавление мантиссы
                            mantissa = order.Substring(1, order.Length - 1) + mantissa;
                        }
                        //порядок в двоичной системе
                        order = Convert.ToString(constanta, 2);
                        //количество незначащих нулей порядка
                        length0 = 8 - order.Length;
                        for (int i = 0; i < length0; i++)
                            order = "0" + order;
                        result = znak + order + mantissa;
                        result = result.Substring(0, 32);

                    }
                    //выход за пределы
                    catch (OverflowException)
                    {
                        result = "Некорректные данные";
                    }
                    //неверный формат
                    catch (System.FormatException)
                    {
                        result = "Некорректные данные";
                    }
                    break;
                case "double":// 15 знаков точности
                    constanta = 1023;
                    mantissa = "";
                    double value02;
                    try
                    {
                        value02 = double.Parse(value);
                        //целая часть числа
                        whole = (int)Math.Truncate(value02);
                        //дробная часть числа
                        fractional = Math.Abs(value02 - whole);
                        //программа перевода вещественного числа в двоичную
                        int flag = 1;
                        for (int i = 0; (i < 64 + 15) && flag == 1; i++)
                        {
                            if (fractional * 2 >= 1)
                            {
                                mantissa = mantissa + "1";
                                fractional = fractional * 2 - 1;
                            }
                            else
                            {
                                mantissa = mantissa + "0";
                                fractional *= 2;
                            }
                            if (fractional == 1)
                            {
                                flag = 0;
                            }
                        }
                        //определение знака мантиссы
                        if (value02 < 0)
                        {
                            znak = "1";
                            whole = Math.Abs(whole);
                        }
                        else
                            znak = "0";
                        if (whole == 0)
                        {
                            //первое вхождение 1 для определения значения порядка
                            int indexOf1 = mantissa.IndexOf("1");
                            constanta = constanta - indexOf1 - 1;
                            mantissa = mantissa.Substring(indexOf1 + 1);
                        }
                        else
                        {
                            order = Convert.ToString(whole, 2);
                            //подсчет значения порядка
                            constanta = constanta + order.Length - 1;
                            //добавление мантиссы
                            mantissa = order.Substring(1, order.Length - 1) + mantissa;
                        }
                        //порядок в двоичной системе
                        order = Convert.ToString(constanta, 2);
                        //количество незначащих нулей порядка
                        length0 = 8 - order.Length;
                        for (int i = 0; i < length0; i++)
                            order = "0" + order;
                        result = znak + order + mantissa;
                        result = result.Substring(0, 64);

                    }
                    //выход за пределы
                    catch (OverflowException)
                    {
                        result = "Некорректные данные";
                    }
                    //неверный формат
                    catch (System.FormatException)
                    {
                        result = "Некорректные данные";
                    }
                    break;
            }
             
            if (textBox3.Text == result)
                this.textBox2.ForeColor = System.Drawing.Color.Green;

            else
                this.textBox2.ForeColor = System.Drawing.Color.Red;
            textBox2.Text = result;
            result = "";
        }
    }
}
