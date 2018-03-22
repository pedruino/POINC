using System;

namespace Poinc.Domain.Model
{
    internal class Client : IClient
    {
        public Client(string name, bool status)
        {
            Name = name;
            Status = status;
        }

        public string Name { get; }

        public float Percentage
        {
            get
            {
                //TODO: testing values
                Random rnd = new Random();
                return rnd.Next(1, 100);
            }
            set
            {
                //TODO: whatever
            }
        }

        public bool Status { get; }
    }
}