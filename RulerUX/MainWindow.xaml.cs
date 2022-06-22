using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using WinUIEx;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace RulerUX
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : WindowEx
    {
        public MainWindow()
        {
            this.InitializeComponent();

            //this.ExtendsContentIntoTitleBar = true;  // enable custom titlebar
            //this.SetIsAlwaysOnTop(true);
            //    this.SetWindowSize(320, 64);
            //this.SetIsShownInSwitchers(false);
            //this.SetIsResizable(false);
            //this.SetIsMinimizable(false);
            //this.SetIsMaximizable(false);
            this.MoveAndResize(1000, 400, 216, 50);
        }
    }
}
