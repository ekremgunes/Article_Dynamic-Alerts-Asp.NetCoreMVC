# How you can use Dynamic Alert in asp.net core MVC 

> Look at the explanation

 Step by step explanation :![Medium article ](https://medium.com/@gunesekrem.com/how-you-can-use-dynamic-alert-in-asp-net-core-mvc-5144ce574b31)
> Extension Method : 

```c#
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
```
