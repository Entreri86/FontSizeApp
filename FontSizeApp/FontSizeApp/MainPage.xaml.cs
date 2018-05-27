using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Xamarin.Forms;

namespace FontSizeApp
{
    public partial class MainPage : ContentPage
    {

        private String [] StringList;
        private int Index = 0;
        public MainPage()
		{
            
            InitializeComponent();
            LoadStrings();
            currentQuote.Text = StringList[Index];
		}

        private String GetPhrase(int pos)
        {            
            return StringList[pos];
        }

        private void LoadStrings()
        {
            StringList = new string[]
            {
                "Buenos dias peña como va todo?",
                "Que hambre tengo!!!",
                "Tengo que mejorar para ganar panoja!",
                "Tengo que mejorar para ganar panoja!",
                "Orale! no te achicopales!!!",
                "Que pasa mijo!!!"
            };                                                          
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Index++;

            if (Index >= StringList.Length)
            {
                Index = 0;
            }
            currentQuote.Text = StringList[Index];
        }
    }
}
