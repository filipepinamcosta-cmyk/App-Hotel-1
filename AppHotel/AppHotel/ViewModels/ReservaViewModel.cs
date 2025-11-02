using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AppHotel;

public class ReservaViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;
    void OnPropertyChanged([CallerMemberName] string name = null) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

    public string Nome { get; set; }
    public ObservableCollection<string> Quartos { get; } =
        new ObservableCollection<string> { "Quarto Padrão", "Quarto Luxo", "Suíte Presidencial" };

    private string quartoSelecionado;
    public string QuartoSelecionado
    {
        get => quartoSelecionado;
        set { quartoSelecionado = value; OnPropertyChanged(); AtualizarResumo(); }
    }

    private DateTime dataEntrada = DateTime.Today;
    public DateTime DataEntrada
    {
        get => dataEntrada;
        set { dataEntrada = value; OnPropertyChanged(); AtualizarResumo(); }
    }

    private double numeroDiarias = 1;
    public double NumeroDiarias
    {
        get => numeroDiarias;
        set { numeroDiarias = value; OnPropertyChanged(); AtualizarResumo(); }
    }

    private string resumo;
    public string Resumo
    {
        get => resumo;
        set { resumo = value; OnPropertyChanged(); }
    }

    private void AtualizarResumo()
    {
        if (!string.IsNullOrEmpty(QuartoSelecionado))
            Resumo = $"{Nome}, você escolheu {QuartoSelecionado} por {NumeroDiarias} diária(s), a partir de {DataEntrada:dd/MM/yyyy}.";
        else
            Resumo = string.Empty;
    }
}
