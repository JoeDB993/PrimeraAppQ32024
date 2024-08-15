namespace PrimeraAppQ32024
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void txtCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b, c, discriminante, X1, X2;

                a = double.Parse(txtA.Text);
                b = double.Parse(txtB.Text);
                c = double.Parse(txtC.Text);

                if (a == 0)
                {
                    DisplayAlert("ADVERTENCIA", "El valor de a no puede ser igual a 0.", "Aceptar");
                }
                else
                {
                    discriminante = Math.Pow(b, 2) - 4 * a * c;

                    if (discriminante >= 0)
                    {
                        X1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
                        X2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
                        txtX1.Text = X1.ToString();
                        txtX2.Text = X2.ToString();
                    }
                    else
                    {
                        DisplayAlert("ADVERTENCIA", "La ecuación no tiene soluciones reales.", "Aceptar");
                    }
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("ERROR", ex.Message, "Aceptar");
            }
        }

        private void txtLimpiar_Click(object sender, EventArgs e)
        {
            txtA.Text = string.Empty;
            txtB.Text = string.Empty;
            txtC.Text = string.Empty;
            txtX1.Text = string.Empty;
            txtX2.Text = string.Empty;
        }
    }
}
