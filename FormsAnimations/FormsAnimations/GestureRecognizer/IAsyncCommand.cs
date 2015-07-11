using System.Threading.Tasks;
using System.Windows.Input;

namespace FormsAnimations.GestureRecognizer
{
    public interface IAsyncCommand : ICommand
    {
        Task ExecuteAsync(object parameter);
    }
}