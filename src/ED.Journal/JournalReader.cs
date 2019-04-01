using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ED.Journal.Events;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ED.Journal
{
    public static class JournalReader
    {
        private static readonly Dictionary<string, Type> Mapping = new Dictionary<string, Type>();

        static JournalReader()
        {
            var baseType = typeof(JournalEvent);

            foreach (var type in baseType.Assembly.GetTypes())
            {
                if (!type.IsAbstract && baseType.IsAssignableFrom(type))
                {
                    Mapping[type.Name] = type;
                }
            }
        }

        public static IList<JournalEvent> ReadAll(Stream stream, bool debug = false)
        {
            return Read(stream, debug).ToList();
        }

        public static IEnumerable<JournalEvent> Read(Stream stream, bool debug = false)
        {
            var serializer = new JsonSerializer
            {
                MissingMemberHandling = debug ? MissingMemberHandling.Error : MissingMemberHandling.Ignore,
                DateFormatString = "yyyy'-'MM'-'dd'T'HH':'mm':'ssK",
                DateTimeZoneHandling = DateTimeZoneHandling.Utc,
            };

            using (var reader = new StreamReader(stream))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();

                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    JournalEvent @event;

                    try
                    {
                        var obj = JObject.Parse(line);

                        if (Mapping.TryGetValue(obj.Value<string>("event"), out var type))
                        {
                            @event = (JournalEvent) obj.ToObject(type, serializer);
                        }
                        else
                        {
                            @event = obj.ToObject<JournalEvent>(serializer);
                        }
                    }
                    catch (Exception e)
                    {
                        continue;
                    }

                    @event.Source = line;

                    yield return @event;
                }
            }
        }
    }
}