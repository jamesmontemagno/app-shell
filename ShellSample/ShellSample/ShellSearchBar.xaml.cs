using ShellSample.Models;
using ShellSample.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShellSample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShellSearchBar : Shell
    {
        public ShellSearchBar()
        {
            InitializeComponent();
        }
    }
}