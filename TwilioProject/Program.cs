using System;
using RestSharp;
using RestSharp.Authenticators;

namespace TwilioProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            var client = new RestClient("https://api.twilio.com/2010-04-01");
            //2
            var request = new RestRequest("Accounts/AC29fe9bc311b4b004b07a9eacdaf14f44/Messages", Method.POST);
            //3
            request.AddParameter("To", "+12062293453");
            request.AddParameter("From", "+19096751391 ");
            request.AddParameter("Body", "Hello world!");
            //4
            client.Authenticator = new HttpBasicAuthenticator("AC29fe9bc311b4b004b07a9eacdaf14f44", "12c6af9e9f5a01b0abba01cd78f761a2");
            //5
            client.ExecuteAsync(request, response =>
            {
                Console.WriteLine(response);
            });
            Console.ReadLine();
        }
    }
}
