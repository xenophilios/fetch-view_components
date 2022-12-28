# fetch-view_components

This project was created to provide background for a question on Stack Overflow (https://stackoverflow.com/questions/74903125/refresh-a-view-component-in-asp-net-core-mvc-6-with-the-help-of-fetch?noredirect=1#comment132212430_74903125).

The question is, how to initialize (or refresh) a view component in a Razor view with the help of the fetch() API. The platform is ASP.NET Core MVC 6.0.

The part with which help is requested is the JavaScript function ProcessData(data), which is found at the bottom of the view, Index.cshtml, which is in the Views/Home folder.

In this function there is an attempt to stringify (serialize) JSON data and display it for review. Although this works in the application in which the original question arose, it does not work here. Help in figuring out why it is not working here would be appreciated.

The main question, however, is how to initialize the view component, "details", with the data that is supposed to be captured by the ProcessData(data) function.
