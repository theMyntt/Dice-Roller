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
            SelectDiceFaceNumber.SelectedIndex = 0;
        }

        void RandResult(System.Object sender, System.EventArgs e)
        {
            Random rand = new Random();
            int max = (int)SelectDiceFaceNumber.SelectedItem;

            int v = rand.Next(1, max + 1);
            DiceRollerResult.Text = v.ToString();
        }
    }
}


