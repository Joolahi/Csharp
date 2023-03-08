namespace T12_Tank
{
    class Tank
    {
        public string name { get; set; }
        public string type { get; set; }
        public int crewNumber = 4;
        private float speed = 0;
        public float speedMax = 100;
        public Tank(string name, string type, int crewNumber = 4)
        {
            this.name = name;
            this.type = type;
            this.crewNumber = crewNumber;
        }
        public int CrewNumber
        {
            get
            { return crewNumber; }
            set
            {
                if (value >= 2 && value <= 6)
                {
                    crewNumber = value;
                }
            }
        }
        public float SpeedMax
        {
            get { return speedMax; }
            set { speedMax = value; }
        }
        public void AccelarateTo(float speed)
        {
            if (speed > 0 && speed <= speedMax)
            {
                this.speed = speed;
            }
        }
        public void SlowTo(float speed)
        {
            if (speed >= 0 && speed <= speedMax)
            {
                this.speed = speed;
            }
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                Tank tank = new Tank("Leopard 2", "Heavy");
                Console.Write($"Tank name: {tank.name}\nTank type: {tank.type}\nCrew number: {tank.CrewNumber}\nMax speed: {tank.SpeedMax}\nTank speed:{tank.speed}\n");

                tank.CrewNumber = 6;
                Console.WriteLine("Crew number now: " + tank.CrewNumber);

                tank.AccelarateTo(30);
                Console.WriteLine("Speed now: " + tank.speed);

                tank.SlowTo(-5);
                Console.WriteLine("Speed now: " + tank.speed);

                tank.SlowTo(10);
                Console.WriteLine("Speed now: " + tank.speed);






            }
        }
    }
}
