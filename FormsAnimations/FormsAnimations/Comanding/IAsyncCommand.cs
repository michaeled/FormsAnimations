using System.Threading.Tasks;
using System.Windows.Input;

namespace FormsAnimations.Comanding
{
    public interface IAsyncCommand : ICommand
    {
        Task ExecuteAsync(object parameter);
    }
}