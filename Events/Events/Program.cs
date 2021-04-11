using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            IEventTrigger trigger = new PartyInfo();

            trigger.partyStarted = true;

            trigger.OnPartyStarted += (e,o) => Console.WriteLine("Buying some snacks");

            trigger.partyStarted = true;

            trigger.OnPartyStarted += LogChanges;

            trigger.partyStarted = true;

            trigger.OnPartyStarted -= LogChanges;

            trigger.partyStarted = true;

        }

        private static void LogChanges(object sender, GetPartyStarted e)
        {
            Console.WriteLine("calling friends, party started={0} ", e.partyStartedInfo);
        }
    }

    public class GetPartyStarted : EventArgs
    {
        public bool partyStartedInfo { get; set; }
    }

    public interface IEventTrigger
    {
        public event EventHandler<GetPartyStarted> OnPartyStarted;

        public bool partyStarted { set; }
    }

    public class PartyInfo : IEventTrigger
    {
        public event EventHandler<GetPartyStarted> OnPartyStarted = delegate { };

        public bool partyStarted
        {
            set
            {
                var partyStarted = value;

                if (partyStarted == true)
                {
                    var partyE = new GetPartyStarted
                    {
                        partyStartedInfo = partyStarted
                    };

                    OnPartyStarted(this, partyE);
                }
            }
            get => partyStarted;
        }
    }

    




}
