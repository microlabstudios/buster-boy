using MicroLabEngine.Core.Messaging;
using BusterBoy.Messaging.Metadata;

namespace BusterBoy.Messaging.Events
{
    public partial class GameStartEvent : IEvent<GameStateMetadata>
    {
        public GameStateMetadata Metadata { get; private set; }

        public GameStartEvent(GameStateMetadata metadata)
        {
            Metadata = metadata;
        }
    }

    public class GameStateEvent
    {
    }
}