using Microsoft.AspNetCore.SignalR;

namespace Demo2.Hubs
{
    public class TestHub:Hub
    {
        public void TestServerMethod(string name)
        {
            Clients.All.SendAsync("testClientMethod");
        }
    }
}