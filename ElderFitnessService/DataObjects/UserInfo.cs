using Microsoft.Azure.Mobile.Server;

namespace ElderFitnessService.DataObjects
{
    public class UserInfo : EntityData
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public string EmergencyNumber { get; set; }
       

    }
}