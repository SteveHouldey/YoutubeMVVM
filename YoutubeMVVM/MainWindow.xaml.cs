/**
 * Main Window- Created by Steven Houldey
 * 
 * This file was created by Steven Houldey for a youtube video.
 * Full Code is aviliable on Github - see the link below:
 * 
 * No Liabilty will be taken for any mishap to your computer / infrastructure by using this program.....
 * 
 * If you find this useful, please give me a thumbs up and leave a comment....
 * 
 * 
 * Licensed under MIT. - Free to use ;)
 * 
 */

using System.Windows;

using YoutubeMVVM.ViewModels;

namespace YoutubeMVVM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainWindowViewModel();
        }
    }
}