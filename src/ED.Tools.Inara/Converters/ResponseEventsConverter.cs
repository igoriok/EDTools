using ED.Tools.Inara.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace ED.Tools.Inara.Converters
{
    public class ResponseEventsConverter : JsonConverter<IList<ResponseEvent>>
    {
        private static readonly ConcurrentDictionary<Type, Type> Cache = new ConcurrentDictionary<Type, Type>();

        private readonly IList<RequestEvent> _events;

        public override bool CanWrite => false;

        public ResponseEventsConverter(IList<RequestEvent> events)
        {
            _events = events;
        }

        public override void WriteJson(JsonWriter writer, IList<ResponseEvent> value, JsonSerializer serializer)
        {
            throw new NotSupportedException();
        }

        public override IList<ResponseEvent> ReadJson(JsonReader reader, Type objectType, IList<ResponseEvent> existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var list = new List<ResponseEvent>();

            if (reader.TokenType == JsonToken.StartArray)
            {
                while (reader.Read() && reader.TokenType != JsonToken.EndArray)
                {
                    if (reader.TokenType == JsonToken.StartObject)
                    {
                        var responseType = GetResponseEventType(_events[list.Count]);
                        var obj = (ResponseEvent) serializer.Deserialize(reader, responseType);

                        list.Add(obj);
                    }
                    else
                    {
                        reader.Skip();
                    }
                }
            }

            return list;
        }

        private static Type GetResponseEventType(RequestEvent requestEvent)
        {
            var requestEventType = requestEvent.GetType();

            if (Cache.TryGetValue(requestEventType, out var responseEventType))
            {
                return responseEventType;
            }

            responseEventType = typeof(ResponseEvent);

            for (var tempType = requestEventType; tempType != null && tempType.IsAssignableFrom(typeof(RequestEvent)); tempType = tempType.BaseType)
            {
                if (tempType.IsGenericType && tempType.GetGenericTypeDefinition() == typeof(RequestEvent<,>))
                {
                    var responseEventDataType = tempType.GetGenericArguments()[1];
                    responseEventType = typeof(ResponseEvent<>).MakeGenericType(responseEventDataType);

                    break;
                }
            }

            Cache.TryAdd(requestEventType, responseEventType);

            return responseEventType;
        }
    }
}