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
        public MainPage()
        {
            InitializeComponent();
        }

        void RandResult(System.Object sender, System.EventArgs e)
        {
            Random rand = new Random();

            int selectedNum = (int)SelectDiceFaceNumber.SelectedItem;

            if (SelectDiceFaceNumber.SelectedItem != null)
            {
                DiceRollerResult.Text = rand.Next(1, selectedNum + 1).ToString();
            }
            else
            {
                DisplayAlert("Atenção", "Você precisa selecionar um número primeiro antes de sortear", "Ok");
            }
        }
    }
}
