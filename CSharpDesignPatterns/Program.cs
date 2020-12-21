﻿using System;

namespace CSharpDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonDemo();
            // BuilderDemo();
            // AbstractFactoryDemo();
        }

        static void SingletonDemo()
        {
            SerialNumberGenerator generator = SerialNumberGenerator.Instance;
            Console.WriteLine("Next Serial: {0}", generator.NextSerial());
            Console.WriteLine("Next Serial: {0}", generator.NextOtherSerial);
            Console.WriteLine("Next Serial: {0}", generator.NextSerial());
            Console.WriteLine("Next Serial: {0}", generator.NextOtherSerial);
        }
        static void BuilderDemo()
        {
            AbstractMountainBike mountainBike = new Downhill(new WideWheel(24), BikeColor.Red);
            BikeBuilder builder = new MountainBikeBuilder(mountainBike);
            BikeDirector director = new MountainBikeDirector();
            IBicycle bicycle = director.Build(builder);
            Console.WriteLine(bicycle);
        }

        static void AbstractFactoryDemo()
        {
            AbstractBikeFactory factory = new RoadBikeFactory();

            // Create the bike parts
            IBikeFrames bikeFrame = factory.CreateBikeFrame();
            IBikeSeat bikeSeat = factory.CreateBikeSeat();
            // Show what we created
            Console.WriteLine(bikeFrame.BikeFrameParts);
            Console.WriteLine(bikeSeat.BikeSeatParts);
        }
    }
}