using MixModes.Synergy.VisualFramework.Windows;
using System;
using System.Windows.Controls;
using System.Windows.Media;

namespace AppShell.Views.content
{
    /// <summary>
    /// Interaction logic for WindowsManager
    /// </summary>
    public partial class DockManager : UserControl
    {

        public DockManager()
        {
            InitializeComponent();

            DockPane pane = new DockPane
            {
                MinHeight = 200,
                MinWidth = 150,
                Header = "Solution Explorer"
            };

            Grid g = new Grid();
            g.Background = Brushes.White;

            PaneContent panecontent = new PaneContent();
            g.Children.Add( panecontent);

            pane.Content = g;
            
            WindowsManager.AddPinnedWindow(pane, Dock.Left);
        }
    }
}
