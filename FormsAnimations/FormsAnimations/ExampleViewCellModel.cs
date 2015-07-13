using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using FormsAnimations.Annotations;

namespace FormsAnimations
{
    public class ExampleViewCellModel : INotifyPropertyChanged
    {
        private ICommand _animation;
        private string _title;


        public ICommand Animation
        {
            get { return _animation; }
            set
            {
                if (_animation != value)
                {
                    _animation = value;
                    OnPropertyChanged();
                }
            }
        }


        public string Title
        {
            get { return _title; }
            set
            {
                if (_title != value)
                {
                    _title = value;
                    OnPropertyChanged();
                }
            }
        }


        #region Property Changed


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }


        #endregion

    }
}