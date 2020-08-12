using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICT638June2020Group2API.Models
{
    public class RoomInfo
    {
        public int Id { get; set; }
        public string roomrent { get; set; }
        public int NumOfBedroom { get; set; }
        public int NumOfBathroom { get; set; }
        public int Agentid { get; set; }
    }
}
