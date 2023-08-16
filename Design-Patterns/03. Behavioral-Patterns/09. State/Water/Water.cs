namespace Water
{
    public class Water
    {
        public WaterState State { get; set; }

        public Water(WaterState ws)
        {
            State = ws;
        }

        public void Heat()
        {
            if (State == WaterState.ICE)
            {
                Console.WriteLine("Melting ice to liquid.");
                State = WaterState.LIQUID;
            }
            else if (State == WaterState.LIQUID)
            {
                Console.WriteLine("Vaporizing liquid to steam.");
                State = WaterState.GAS;
            }
            else if (State == WaterState.GAS)
            {
                Console.WriteLine("Increasing temperature of the steam.");
            }
        }

        public void Frost()
        {
            if (State == WaterState.LIQUID)
            {
                Console.WriteLine("Cooling water to ice.");
                State = WaterState.ICE;
            }
            else if (State == WaterState.GAS)
            {
                Console.WriteLine("Cooling steam to water.");
                State = WaterState.LIQUID;
            }
        }
    }
}
