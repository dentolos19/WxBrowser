﻿using System;
using System.Windows;
using Cto.MassFileRename.Core;

namespace Cto.MassFileRename.Graphics
{

    public partial class WnException
    {

        public WnException(Exception error)
        {
            InitializeComponent();
            MessageText.Text = error.Message;
            StackTraceText.Text = error.StackTrace ?? "The error info doesn't contain stack trace data.";
        }

        private void Restart(object sender, RoutedEventArgs args)
        {
            Utilities.RestartApp();
        }

        private void Exit(object sender, RoutedEventArgs args)
        {
            Application.Current.Shutdown();
        }

    }

}