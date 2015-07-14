using System;
using System.Threading.Tasks;
using FormsAnimations.GestureRecognizer;

namespace FormsAnimations.Comanding
{
    /// <remarks>
    /// Example inspired from:
    ///     1) http://enumeratethis.com/2012/06/14/asynchronous-commands-in-metro-wpf-silverlight/
    ///     2) https://msdn.microsoft.com/en-us/magazine/dn630647.aspx
    /// </remarks>
    public class AsyncCommand : IAsyncCommand
    {
        private readonly Func<object, Task> _execute;
        private readonly Func<object, bool> _canExecute;
        private bool _isExecuting;

        public event EventHandler CanExecuteChanged;


        public AsyncCommand(Func<object, Task> execute)
            : this(execute, o => true)
        {
        }


        public AsyncCommand(Func<object, Task> execute, Func<object, bool> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
        }


        public bool CanExecute(object parameter)
        {
            return !_isExecuting && _canExecute(parameter);
        }


        public void Execute(object parameter)
        {
            ExecuteAsync(parameter).Wait();
        }


        public async Task ExecuteAsync(object parameter)
        {
            _isExecuting = true;
            OnCanExecuteChanged();
            
            try
            {
                await _execute(parameter).ConfigureAwait(false);
            }
            finally
            {
                _isExecuting = false;
                OnCanExecuteChanged();
            }
        }


        protected virtual void OnCanExecuteChanged()
        {
            if (CanExecuteChanged != null)
            {
                CanExecuteChanged(this, new EventArgs());
            }
        }
    }
}
