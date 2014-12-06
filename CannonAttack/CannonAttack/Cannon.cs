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
    }
}