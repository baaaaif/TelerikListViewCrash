using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teleriklistviewcrash
{
    public partial class ListViewPageModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<ListViewModel>? _Items;

        public void LoadItems()
        {
            var list = new List<ListViewModel>();
            for (int i = 0; i < 30; i++)
                list.Add(new ListViewModel() { Index = i, Name = $"Name {i} \n a \n b \n c\n d\n e\n f\n g\n h\n\n\n\n {i}" });

            Items = new ObservableCollection<ListViewModel>(list);
        }
    }
}
