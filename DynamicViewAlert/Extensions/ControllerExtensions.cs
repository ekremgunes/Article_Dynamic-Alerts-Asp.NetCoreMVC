using Microsoft.AspNetCore.Mvc;

namespace ViewAlertApp.Extensions
{
    public static class ControllerExtensions
    {
        //scripted by gunesekrem.com
        public static string ViewAlert(this Controller controller, AlertType alert = AlertType.Info, string alertMessage = "Info")
        {
            if (alert == AlertType.Success)
            {
                return $"<span class='successAlert'>{alertMessage}</span>";
            }
            else if (alert == AlertType.Warning)
            {
                return $"<span class='warningAlert'>{alertMessage}</span>";
            }
            else if (alert == AlertType.Error)
            {
                return $"<span class='errorAlert'>{alertMessage}</span>";
            }
            else
            {
                return $"<span class='infoAlert'>{alertMessage}</span>";
            }
        }
    }

    public enum AlertType
    {
        Success = 1,
        Error = 2,
        Info = 3,
        Warning = 4
    }
}
