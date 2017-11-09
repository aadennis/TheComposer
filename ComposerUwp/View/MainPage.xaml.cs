using Windows.UI.Xaml.Controls;
using Composer.ViewModel;

namespace Composer {
    public sealed partial class MainPage : Page {
        public MainPage() {
            this.InitializeComponent();
            Vm = new ComposerVm();
        }
        public ComposerVm Vm { get; private set; }
    }
}
