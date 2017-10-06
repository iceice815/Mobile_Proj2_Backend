using Microsoft.Azure.Mobile.Server;

namespace ElderFitnessService.DataObjects
{
    public class RecordTrack : EntityData
    {
        public string Username { get; set; }

        public string Date { get; set; }

        public int Distance { get; set; }

        public int FlightsClimbed { get; set; }

        public double Calories { get; set; }
    }
}