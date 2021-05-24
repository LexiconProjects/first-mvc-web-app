using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMVCWebApp.Models
{
    public class TemperatureCheckModel
    {

        public float Temperature { get; set; }

        public string Scale { get; set; }

        public static string CheckTemp(float temp, string scale)
        {

            if (scale == "Celsius")
            {
                if (temp >= 37.5 && temp<=41)
                    return "Your temperature indicates a fever!";
                if (temp < 37.5 && temp >= 36.5)
                    return "Your temperature is normal!";
                if (temp > 35 && temp < 36.5)
                    return "Your temperature is below normal!";
                if (temp <= 35)
                    return "Your temperature indicates hypothermia!";
            }else
            if (scale == "Fahrenheit")
            {
                if (temp >= 99.5 && temp <= 105.8)
                    return "Your temperature indicates that you have a fever";
                if (temp < 97.7 && temp >= 99.5)
                    return "Your temperature is normal";
                if (temp > 95 && temp < 97.7)
                    return "Your temperature is below normal!";
                if (temp <= 95)
                    return "Your temperature indicates hypothermia!";
            }
                return "Invalid measurement! Try again.";
        }
    }

}
