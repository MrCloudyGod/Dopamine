﻿using Dopamine.Common.Controls;
using System.Threading.Tasks;
using System.Windows;

namespace Dopamine.Common.Services.Notification
{
    public interface INotificationService
    {
        bool SystemNotificationIsEnabled { get; set; }
        bool ShowNotificationWhenPlaying { get; set; }
        bool ShowNotificationWhenPausing { get; set; }
        bool ShowNotificationWhenResuming { get; set; }
        bool ShowNotificationControls { get; set; }

        Task ShowNotificationAsync();
        void HideNotification();
        void SetApplicationWindows(DopamineWindow mainWindow, DopamineWindow playlistWindow, Window trayControlsWindow);
    }
}
