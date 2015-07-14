using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using FormsAnimations.Annotations;

namespace FormsAnimations
{
    public class ExampleViewCellModel : INotifyPropertyChanged
    {
        private ICommand _tappedAnimation;
        private ICommand _reset;

        private string _title;


        public ICommand Reset
        {
            get { return _reset; }
            set
            {
                if (_reset != value)
                {
                    _reset = value;
                    OnPropertyChanged();
                }
            }
        }
        

        public ICommand TappedAnimation
        {
            get { return _tappedAnimation; }
            set
            {
                if (_tappedAnimation != value)
                {
                    _tappedAnimation = value;
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