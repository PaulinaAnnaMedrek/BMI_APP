using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp6.MVVM.Models
{
    [AddINotifyPropertyChangedInterface]
    public class BMI
    {
        private float result;
        private string rText;

        public float Growth { get; set; }
        public float Weight { get; set; }

        public float Result
        {
            get
            {
                return ((Weight / Growth) / Growth) * 10000;
            }
        }


        public string RText
        {
            get
            {
                
                if (Result <= 16)
                {
                    return ( "Severe Undereight");
                }
                else if (Result > 16 && Result <= 17)
                {
                    return ( "Moderate Underveight");
                }
                else if (Result > 17 && Result <= 18.5)
                {
                    return ("Mild Undereight");
                }
                else if (Result > 18.5 && Result <= 25)
                {
                    return ("Normal");
                }
                else if (Result > 25 && Result <= 30)
                {
                    return ( "Overweight");
                }
                else if (Result > 30 && Result <= 35)
                {
                    return ( "Obese Class I");
                }
                else if (Result > 35 && Result <= 40)
                {
                    return ( "Obese Class II");
                }
                else
                {
                    return ( "Obese Class III");
                }

            }
        }


    }
}
