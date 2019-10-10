using ShellSample.Models;
using ShellSample.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ShellSample.Views
{
    public class ItemsSearchHandler : SearchHandler
    {
        protected override async void OnItemSelected(object item)
        {
            base.OnItemSelected(item);

            var theItem = item as Item;
            if (theItem == null)
                return;

            await Shell.Current.Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(theItem)));
        }
    }
}
