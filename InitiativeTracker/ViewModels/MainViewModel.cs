using InitiativeTracker.Models;
using ReactiveUI;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace InitiativeTracker.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    private ObservableCollection<Player> _players;
    public ObservableCollection<Player> Players { get => this._players; set => this._players = value; }

    private bool _isStartButtonOpen;
    public bool IsStartButtonOpen
    {
        get => _isStartButtonOpen;
        set
        {
            this.RaiseAndSetIfChanged(ref this._isStartButtonOpen, value);
        }
    }


    public MainViewModel()
    {
        this._players = [
            new("Lillian", 20),
            new("Krim", 17),
            new("Adrim", 15),
            new("Lilith", 12),
            new("Zephyr", 24),
        ];
        this._isStartButtonOpen = true;


        this.StartButtonClick = ReactiveCommand.Create(() => {
            this.IsStartButtonOpen = false;
        });


    }

    public ICommand StartButtonClick { get; }
}
