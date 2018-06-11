using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FontSizeApp.Views.Models.ListModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FontSizeApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContactList : ContentPage
	{
        
		public ContactList ()
		{
			InitializeComponent ();
            ContactListView.ItemsSource = new List<ContactGroup>
            {
                new ContactGroup ("N","N")
                {
                    new Contact { Name = "Nando", Status = "Online", Surname = "Otal Barja", ImageUrl="http://lorempixel.com/100/100/people/1"}
                },
                new ContactGroup("O", "O")
                {
                    new Contact { Name = "Oriolet", Status = "Offline", Surname = "Urgell Salmerón", ImageUrl="http://lorempixel.com/100/100/people/2"}
                },
                new ContactGroup("F", "F")
                {
                    new Contact { Name = "Ferrarini", Status = "Online", Surname = "Guillen", ImageUrl="http://lorempixel.com/100/100/people/3"}
                },
                new ContactGroup("R", "R")
                {
                    new Contact { Name = "Ricardio", Status = "Offline", Surname = "Baeza Barba", ImageUrl="http://lorempixel.com/100/100/people/4"}
                }                
            };

        }
	}
}