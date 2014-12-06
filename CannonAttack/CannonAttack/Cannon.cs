using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace CannonAttack
{
    public sealed class Cannon
    {
        private readonly string CANNONID = "Human";
        private string CannonID;
        public string ID
        {
            get
            {
                return (String.IsNullOrWhiteSpace(CannonID)) ? CANNONID : CannonID;
            }
            set
            {
                CannonID = value;
            }
        }

        private static Cannon cannonSingletonInstance;
        static readonly object padlock = new object();
        private Cannon()
        {
        }
        public static Cannon GetInstance()
        {
            lock (padlock)
            {
                if (cannonSingletonInstance == null)
                {
                    cannonSingletonInstance = new Cannon();
                }
                return cannonSingletonInstance;
            }
        }
    }
}