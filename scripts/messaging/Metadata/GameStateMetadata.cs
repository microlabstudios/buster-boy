using System;
using System.Collections.Generic;
using MicroLabEngine.Core.Messaging;

namespace BusterBoy.Messaging.Metadata
{
    public class GameStateMetadata : IEventMetadata
    {
        public Dictionary<string, Tuple<object, Type>> Values => throw new NotImplementedException();

        public Tuple<object, Type> GetValue(string key)
        {
            throw new NotImplementedException();
        }

        public void SetValue<T>(string key, Tuple<object, Type> value)
        {
            throw new NotImplementedException();
        }
    }
}