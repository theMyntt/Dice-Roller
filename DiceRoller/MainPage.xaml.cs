using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DiceRoller
{
    public partial class MainPage : ContentPage
    {
        public int index;

        public MainPage()
        {
            InitializeComponent();
        }

        void RandResult(System.Object sender, System.EventArgs e)
        {
            Random rand = new Random();

            if (index != -1 && SelectDiceFaceNumber.SelectedItem != null)
            {
                int min = 1;
                int max = (int)SelectDiceFaceNumber.SelectedItem;

                int v = rand.Next(min, max + 1);
                DiceRollerResult.Text = v.ToString();
            }
            else
            {
                DisplayAlert("Atenção", "Você precisa selecionar um dado primeiro.", "OK");
            }
        }
    }
}
