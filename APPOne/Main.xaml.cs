using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace APPOne
{
    public partial class Main : MasterDetailPage
    {
        public Main()
        {
            InitializeComponent();
            Detail = new NavigationPage(new StartPage());
            IsPresented = false; 

        }

        void Handle_About(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new About());
            IsPresented = false;
        }

        void Handle_StartPage(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new StartPage());
            IsPresented = false;
        }

        void Handle_StartGame(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new Game());
            IsPresented = false;
        }

    }
}
