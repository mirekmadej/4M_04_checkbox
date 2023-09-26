namespace _4M_04_checkbox
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        bool cML=false, cDL = false, cC = false, cZD = false;
        bool cX = false;

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnGenerujClicked(object sender, EventArgs e)
        {
            string wynik = "wybrano: ";
            if (chkMaleLitery.IsChecked )
                wynik += "małe litery; ";
            if (chkDuzeLitery.IsChecked)
                wynik += "duże litery; ";
            if (chkCyfry.IsChecked)
                wynik += "cyfry; ";
            if (chkZnakiSpec.IsChecked)
                wynik += "znaki specjalne; ";
            lblWynik.Text = wynik;
            SemanticScreenReader.Announce(lblWynik.Text);
        }
        private void chkXChengedState(object sender, EventArgs e)
        {
            if(chkX.IsChecked)
                lblCheckboxState.Text = "checbox checked";
            else
                lblCheckboxState.Text = "checbox unchecked";
 
            SemanticScreenReader.Announce(lblCheckboxState.Text);
        }




    }
}