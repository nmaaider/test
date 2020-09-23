using System;

namespace ConsoleApp1
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Method)]
    public class SampleAttribute:Attribute
    {
        [Sample]
        public string Name { get; set; }
        public int Version { get; set; }
    }

    [Sample(Name = "Na", Version = 1)]
    public class WithAttribute
    {
        [Sample()]
        public string Id { get; set; }

        [Sample]
        public void DoSomthing()
        {

        }
    }

    public class MyWithoutArtribute
    {

    }
}
