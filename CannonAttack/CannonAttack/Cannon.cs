using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace CannonAttack
{
    public sealed class Cannon
    {
        private readonly string CANNONID = "Human";
        public static readonly int MAXANGLE = 90;
        public static readonly int MINANGLE = 1;
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

        public Tuple<bool, string> Shoot(int angle, int velocity)
        {
            if (angle > MAXANGLE || angle < MINANGLE) //Angle must be //between 0 and 90 degrees
            {
                return Tuple.Create(false, "Angle Incorrect");
            }
            return Tuple.Create(true, "Angle OK"); //Not //going to do the calculation just yet
        }
    }
}