using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp6.MVVM.Models
{
    [AddINotifyPropertyChangedInterface]
    public class Categoriess
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Colors { get; set; }
        public int WaitingTask { get; set; }
        public float PercProgress { get; set; }

        public bool Select { get; set; }
    }
}
