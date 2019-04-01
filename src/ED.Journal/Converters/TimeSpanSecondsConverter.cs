using System;
using Newtonsoft.Json;

namespace ED.Journal.Converters
{
    public class TimeSpanSecondsConverter : JsonConverter<TimeSpan?>
    {
        public override void WriteJson(JsonWriter writer, TimeSpan? value, JsonSerializer serializer)
        {
            if (value.HasValue)
            {
                writer.WriteValue(value.Value.TotalSeconds);
            }
            else
            {
                writer.WriteNull();
            }
        }

        public override TimeSpan? ReadJson(JsonReader reader, Type objectType, TimeSpan? existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Integer || reader.TokenType == JsonToken.Float)
            {
                return TimeSpan.FromSeconds(Convert.ToDouble(reader.Value));
            }

            return null;
        }
    }
}