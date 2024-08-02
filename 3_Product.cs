//Lukhanyo Kalashe
//2023575000
namespace Computers
{
    public class Computer
    {
        public string Name { get; set; }
        public string CPU { get; set; }
        public string Cooler { get; set; }
        public string Memory { get; set; }
        public string SSD { get; set; }
        public string Graphics { get; set; }
        public decimal Price { get; set; }

        public Computer()
        {

        }

        public override string ToString()
        {
            string s = "\nName       : " + Name + "\n" +
                        "CPU        : " + CPU + "\n" +
                        "Cooler     : " + Cooler + "\n" +
                        "Memory     : " + Memory + "\n" +
                        "SSD        : " + SSD + "\n" +
                        "Graphics   : " + Graphics + "\n" +
                        "Price      : " + "R" + Price.ToString("0.00");


            return s;
            
        }
    }
}