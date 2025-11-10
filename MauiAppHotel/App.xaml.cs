using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class App : Application
    {
        public List<Quarto> lista_quartos = new List<Quarto>()
        {
            new Quarto()
            {
                Descricao = "Suíte Ilha Fiji",
                ValorDiariaAdulto = 2100.50,
                ValorDiariaCrianca = 1050.25
            },
            new Quarto()
            {
                Descricao = "Suíte Brisa do Mar",
                ValorDiariaAdulto = 1548.50,
                ValorDiariaCrianca = 774.25
            },
            new Quarto()
            {
                Descricao = "Suíte Pé na Areia",
                ValorDiariaAdulto = 1298.00,
                ValorDiariaCrianca = 649.00
            },
            new Quarto()
            {
                Descricao = "Suíte Barquinho",
                ValorDiariaAdulto = 698.00,
                ValorDiariaCrianca = 349.00
            }
        };

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 600;


            return window;
        }
    }
}