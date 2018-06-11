using System;
using System.Collections.Generic;
using System.Text;

namespace FontSizeApp.Views.Models.ListModels
{
    class ContactGroup : List<Contact>
    {
        public string Title { get; set; }
        public string ShortTitle { get; set; }
        public ContactGroup( string title, string shortTitle)
        {
            this.Title = title ;
            this.ShortTitle = shortTitle;
        }
    }
}
