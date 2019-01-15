namespace TestWorkWebApi2._0.Services.Models
{
    using TestWorkWebApi2._0.Services.Interfaces;
    using TestWorkWebApi2._0.Constants;
    using System;

    public class Greeter : IGreeter
    {
        public string SayHello(string fromController)
        {
            string result;

            if (!string.IsNullOrEmpty(fromController))
            {
                if (fromController.StartsWith(Constants.ContollerName, StringComparison.InvariantCultureIgnoreCase))
                {
                    result = Constants.Greeting.There;
                }
                else
                {
                    result = Constants.Greeting.Everyone;
                }
            }
            else
            {
                string message = string.Format(Constants.ExeptionMessage.NullRefference, nameof(fromController));
                throw new NullReferenceException(message);
            }

            return result;
        }
    }
}
