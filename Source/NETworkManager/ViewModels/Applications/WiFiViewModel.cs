using NETworkManager.Models.Network;
using NETworkManager.Helpers;
using System;
using System.Windows;
using System.Windows.Input;
using System.ComponentModel;
using System.Windows.Data;
using System.Collections.ObjectModel;

namespace NETworkManager.ViewModels.Applications
{
    public class WiFiViewModel : ViewModelBase
    {
        #region Variables
        //private bool _isLoading = true;

      
        #endregion

        #region Contructor, load settings
        public WiFiViewModel()
        {
            LoadSettings();

            //_isLoading = false;
        }

        private void LoadSettings()
        {

        }
        #endregion

        #region ICommands & Actions
       


        #endregion

        #region Methods
        


        #endregion

        #region Events
        


        #endregion
    }
}