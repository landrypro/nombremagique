using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace nombremagique.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GamePage : ContentPage
    {

        const int NB_MIN = 1;
        const int NB_MAX = 10; 

        int magicNumber;


        public GamePage()
        {
            InitializeComponent();
           

           magicNumber = new Random().Next(NB_MIN, NB_MAX);

            lblTitre.Text = $"Entre {NB_MIN} et {NB_MAX}";



        }

        private void btnDevine_Clicked(object sender, EventArgs e)
        {

            int nbreCherche = 0;
            try
            {

                 nbreCherche = Int32.Parse(txtEntry.Text);
            }

            catch (Exception)

            { 

                DisplayAlert("", "Ce nombre n'est pas numérique", "OK");
            }


            if (nbreCherche < NB_MIN || nbreCherche > NB_MAX)
            {
                DisplayAlert("AlerteNombre", $"Le Nombre entré n'est  pas dans l'intervalle {NB_MIN} et {NB_MAX}", "OK");
                txtEntry.Text = "";
            }

            if (nbreCherche < NB_MAX || nbreCherche > NB_MIN)
            {

                if (nbreCherche == magicNumber) 
                
                { 
                
                }
            }

        }
    }
}