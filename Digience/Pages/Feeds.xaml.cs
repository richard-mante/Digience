using Digience.Models;
using Digience.ViewModels;
namespace Digience.Pages;

public partial class Feeds : ContentPage
{
	public Feeds()
	{
		InitializeComponent();

		BindingContext = new LoadAllFeedsViewModel();
	}

}