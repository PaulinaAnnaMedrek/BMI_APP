using MauiApp6.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp6.MVVM.ViewModels
{
    class NTViewModel
    {
        public string Task { get; set; }
        public ObservableCollection<Tasks> Tasks { get; set; }
        public ObservableCollection<Categoriess> Categoriess { get; set; }
    }
}
