﻿using Microsoft.UI.Xaml;
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

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace SetTitleBarWinUIPreview4
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }

        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            setTitleBarOn = !setTitleBarOn;
            setAppTitleBar();
        }

        private void setAppTitleBar()
        {
            if (setTitleBarOn)
            {
                this.ExtendsContentIntoTitleBar = true;
                this.SetTitleBar(AppTitleBar);
                myButton.Content = "Set Title Bar Off";
            }
            else
            {
                this.ExtendsContentIntoTitleBar = false;
                this.SetTitleBar(null);
                myButton.Content = "Set Title Bar On";
            }
        }


        private bool setTitleBarOn = false;
    }
}
