using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace Teleriklistviewcrash;

public partial class ListViewPage : ContentPage
{
    private ListViewPageModel _model = new ListViewPageModel();
    public ListViewPage()
	{
		InitializeComponent();
        this.BindingContext = _model;
        _model.LoadItems();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        _model.LoadItems();
    }

}