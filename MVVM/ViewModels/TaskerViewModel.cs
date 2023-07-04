using MauiApp6.MVVM.Models;
using PropertyChanged;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace MauiApp6.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class TaskerViewModel
    {
        public ObservableCollection<Categoriess> Category { get; set;}
        public ObservableCollection<Tasks> Task { get; set; }

        public TaskerViewModel()
        {
            FillData();
            Task.CollectionChanged += Task_Coll_Changed;
        }

        private void Task_Coll_Changed(object sender, NotifyCollectionChangedEventArgs e)
        {
            InfoUpdate();
        }

        private void FillData()
        {
            Category = new ObservableCollection<Categoriess>
           {
               new Categoriess
               {
                   CategoryId= 1,                 
                   Colors= "#043770"
               }

              
           };
            Task = new ObservableCollection<Tasks>
            {
                
                new Tasks
                {
                    CategoryId= 1,
                    Completed= true,
                    TaskName ="Task 1"
                }

            };

            InfoUpdate();
        }

        public void InfoUpdate()
        {
            foreach (var ss in Category)
            {
                var task = from sk in Task
                           where sk.CategoryId == ss.CategoryId
                           select sk;
                var completed = from sk in Task
                                where sk.Completed == true
                                select sk;
                var nCompleted=from sk in Task
                               where sk.Completed == false
                               select sk;

                ss.WaitingTask = nCompleted.Count();
                ss.PercProgress=(float)completed.Count()/(float)task.Count();


            }

            
        }
    }
}
