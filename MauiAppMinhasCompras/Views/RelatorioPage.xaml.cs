using MauiAppMinhasCompras.Models;

namespace MauiAppMinhasCompras.Views;

public partial class RelatorioPage : ContentPage
{
    public RelatorioPage()
    {
        InitializeComponent();
        CarregarRelatorio();
    }

    private async void CarregarRelatorio()
    {
        try
        {
            var produtos = await App.Db.GetAll();

            var relatorio = produtos
                .GroupBy(p => p.Categoria)
                .Select(g => new
                {
                    Categoria = g.Key,
                    Total = g.Sum(p => p.Total)
                })
                .ToList();

            cvRelatorio.ItemsSource = relatorio;
        }
        catch (Exception ex)
        {
            await DisplayAlert("Erro", ex.Message, "OK");
        }
    }
}
