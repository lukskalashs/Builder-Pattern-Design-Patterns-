//Lukhanyo Kalashe
//2023575000
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers
{
    public abstract class AComputerBuilder : IBuilder
    {
        protected Computer computer;

        public AComputerBuilder(string name)
        {
            computer = new Computer();
            computer.Name = name;
            SetAttributes();
        }

        public abstract void SetAttributes();
        public Computer GetComputers()
        {
            return computer;
        }
    }
    public class BareboneBuilder : AComputerBuilder
    {
        public BareboneBuilder(string name) : base(name)
        {
        }

        public override void SetAttributes()
        {
            
            computer.CPU = "Intel i3";
            computer.Cooler = "Air 95 mm";
            computer.Memory = "16 GB DDR5";
            computer.SSD = "240 GB SSD";
            computer.Graphics = "Intel on-board";
            computer.Price = 7800M;
        }
    }
    public class HomeComputerBuilder : AComputerBuilder
    {
        public HomeComputerBuilder(string name) : base(name)
        {
        }

        public override void SetAttributes()
        {
            
            computer.CPU = "Intel i5";
            computer.Cooler = "Air 120 mm";
            computer.Memory = "24 GB DDR5";
            computer.SSD = "1 TB SSD";
            computer.Graphics = "GeForce RTX4060";
            computer.Price = 16900M;
        }
    }
    public class OfficeComputerBuilder : AComputerBuilder
    {
        public OfficeComputerBuilder(string name) : base(name)
        {
        }

        public override void SetAttributes()
        {
            
            computer.CPU = "Intel i7";
            computer.Cooler = "Air 120 mm";
            computer.Memory = "32 GB DDR4";
            computer.SSD = "2 TB SSD with heatsink";
            computer.Graphics = "GeForce RTX 4060";
            computer.Price = 24500;
        }
    }
    public class GamingComputerBuilder : AComputerBuilder
    {
        public GamingComputerBuilder(string name) : base(name)
        {
        }

        public override void SetAttributes()
        {
            
            computer.CPU = "Intel i9";
            computer.Cooler = "Liquid";
            computer.Memory = "48 GB DDR5";
            computer.SSD = "2 TB SSD";
            computer.Graphics = "ASRock Intel A750";
            computer.Price = 46000M;
        }
    }
    public class BeastComputerBuilder : AComputerBuilder
    {
        public BeastComputerBuilder(string name) : base(name)
        {
        }

        public override void SetAttributes()
        {
            
            computer.CPU = "AMD Ryzen 7970X";
            computer.Cooler = "Liquid";
            computer.Memory = "Micron 128 GB DDR4";
            computer.SSD = "Micron 7450 Pro";
            computer.Graphics = "GeForce RTX4070Ti";
            computer.Price = 210000M;
        }
    }

}
