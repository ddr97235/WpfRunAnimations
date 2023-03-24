using System.Threading.Tasks;
using WpfRunAnimations.ViewModel.Simplified;
using System.Windows;

namespace WpfRunAnimations.ViewModel
{
    internal class MainWindowViewModel : BaseInpc
    {

        private RelayCommand? buttonClick;
        public RelayCommand ButtonClick => buttonClick
           ??= new RelayCommand(() =>
           {
               DoStartAnimation();
           });

        private Visibility bordeVisibility = Visibility.Collapsed;
        public Visibility BordeVisibility
        {
            get => bordeVisibility;
            set => Set(ref bordeVisibility, value);
        }

        private bool isNeedStartAnimation = false;
        public bool IsNeedStartAnimation
        {
            get=> isNeedStartAnimation;
            set=> Set(ref isNeedStartAnimation, value);
        }

        private void DoStartAnimation()
        {
            IsNeedStartAnimation = !IsNeedStartAnimation;
            BordeVisibility = Visibility.Visible;
        }
    }
}
