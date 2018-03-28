using MixModes.Synergy.VisualFramework.Windows;
using Prism.Regions;
using System.Windows.Controls;
using System.Windows.Media;

namespace AppShell.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        
        public MainWindow(IRegionManager regionManager)
        {
            InitializeComponent();

            // register top menu to header region
            regionManager.RegisterViewWithRegion("headerRegion", typeof(header.TopMenu));

            // register dockmanger to content region
            regionManager.RegisterViewWithRegion("contentRegion", typeof(content.DockManager));

            // register statusbar to footer region
            regionManager.RegisterViewWithRegion("footerRegion", typeof(footer.StatusBar));
        }
    }
}
