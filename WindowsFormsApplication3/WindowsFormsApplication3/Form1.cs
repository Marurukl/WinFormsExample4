using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        DateTimePicker dateTime = new DateTimePicker();
        bool lessDate = false;
        int index = 0;
        
        public Form1()
        {
            InitializeComponent();
            dateTime.Value = dateTimePicker.Value;
        }

        private void GetResults()
        {
            if (lessDate)
            {
                textBoxInfo.Text= "Выбранная дата уже прошла!";
            }
            else
            {
                switch (index)
                {
                    case 0:
                        textBoxInfo.Text = "";
                        break;
                    case 1:
                        textBoxInfo.Text = "Осталось  " +GetData(index) +"  года";
                        break;
                    case 2:
                        textBoxInfo.Text = "Осталось  " + GetData(index) + "  месяцов";
                        break;
                    case 3:
                        textBoxInfo.Text = "Осталось  " + GetData(index) + "  дней";
                        break;
                    case 4:
                        textBoxInfo.Text = "Осталось  " + GetData(index) + "  минут";
                        break;
                    case 5:
                        textBoxInfo.Text = "Осталось  " + GetData(index) + "  секунд";
                        break;
                    default:
                        break;
                }
            }

        }
        private string GetData(int index)
        {
            int intData;
            double doubleData;
            int dayInYear = 365;
            int avarageDayInMonth = 30;
            int monthInYear = 12;
            int minutesInDay = 1440;
            int secondsInDay = 86400;
            double dateInMonthDateTimePicker = dateTimePicker.Value.Year * monthInYear + dateTimePicker.Value.Month;
            double dateInDayDateTimePicker = dateTimePicker.Value.Year * dayInYear + dateTimePicker.Value.Month*avarageDayInMonth+dateTimePicker.Value.Day;
            double dateInMonthDateTime = dateTime.Value.Year * monthInYear + dateTime.Value.Month;
            double dateInDayDateTime = dateTime.Value.Year * dayInYear + dateTime.Value.Month * avarageDayInMonth + dateTime.Value.Day;
            int DateInDayTimePickerInt = dateTimePicker.Value.Year * monthInYear + dateTimePicker.Value.Month;
            int dateInDayDateTimePickerInt = dateTimePicker.Value.Year * dayInYear + dateTimePicker.Value.Month * avarageDayInMonth + dateTimePicker.Value.Day;
            int dateInMonthDateTimeInt = dateTime.Value.Year * monthInYear + dateTime.Value.Month;
            int dateInDayDateTimeInt = dateTime.Value.Year * dayInYear + dateTime.Value.Month * avarageDayInMonth + dateTime.Value.Day;
            switch (index)
            {

                case 0:
                    return "";
                case 1:
                    doubleData = (dateInMonthDateTimePicker - dateInMonthDateTime) / monthInYear;
                    return doubleData.ToString();
                case 2:
                    doubleData = (dateInDayDateTimePicker - dateInDayDateTime) / dayInYear;
                    return doubleData.ToString();
                case 3:
                    intData = dateInDayDateTimePickerInt - dateInDayDateTimeInt;
                    return intData.ToString();
                case 4:
                    intData = (dateInDayDateTimePickerInt - dateInDayDateTimeInt) * minutesInDay;
                    return intData.ToString();
                case 5:
                    intData = (dateInDayDateTimePickerInt - dateInDayDateTimeInt) * secondsInDay;
                    return intData.ToString();
                default:
                    return"";
            }
        }
        private void RadioButtonInYear_CheckedChanged(object sender, EventArgs e)
        {
            index = 1;
            GetResults();
        }

        private void RadioButtonInMonth_CheckedChanged(object sender, EventArgs e)
        {
            index = 2;
            GetResults();
        }

        private void RadioButtonInDay_CheckedChanged(object sender, EventArgs e)
        {
            index = 3;
            GetResults();
        }

        private void RadioButtonInMinutes_CheckedChanged(object sender, EventArgs e)
        {
            index = 4;
            GetResults();
        }

        private void RadioButtonInSeconds_CheckedChanged(object sender, EventArgs e)
        {
            index = 5;
            GetResults();
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker.Value <= dateTime.Value)
                lessDate = true;
            else
                lessDate = false;
            GetResults();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
