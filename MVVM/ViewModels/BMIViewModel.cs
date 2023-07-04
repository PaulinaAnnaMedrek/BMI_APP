using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp6.MVVM.ViewModels
{
    class BMIViewModel
    {
        public Models.BMI BMI { get; set; }
        public BMIViewModel()
        {
            BMI=new  Models.BMI();
            BMI.Growth = 180;
            BMI.Weight = 73;
            
        }



    }
}
