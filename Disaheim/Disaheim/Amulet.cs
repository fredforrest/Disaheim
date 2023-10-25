using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{

    public class Amulet
    {

        public string ItemId
        {
            get;
            set;
        }

        public Level Quality
        {
            get;
            set;
        }

        public string Design
        {
            get;
            set;
        }

        public Amulet(string itemId) : this(itemId, Level.LOW) //chaining til nedenunder
        {

        }

        public Amulet(string itemId, Level quality) : this(itemId, quality, "") //chaining til nedenunder
        {

        }

        public Amulet(string itemId, Level quality, string design)
        {
            ItemId = itemId;
            Quality = quality;
            Design = design;
        }

        public override string ToString() //overrider ToString metoden for ikke at kalde default implementationen,som er klassens navn
        {
            return "ItemId: " + ItemId + ", Quality: " + Quality + ", Design: " + Design;
        }



    }








}
