using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Kwtc.Steam.Client.Converters;

/// <summary>
/// Converter capable of converting a number (or a string) to a string. 
/// </summary>
public class NumberOrStringToStringConverter : JsonConverter<string>
{
    public override string? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        return reader.TokenType switch
        {
            JsonTokenType.String => reader.GetString(),
            JsonTokenType.Number => reader.GetInt32().ToString(),
            _ => throw new ArgumentOutOfRangeException(nameof(reader))
        };
    }

    public override void Write(Utf8JsonWriter writer, string value, JsonSerializerOptions options)
    {
        if (string.IsNullOrEmpty(value))
        {
            return;
        }

        writer.WriteStringValue(value);
    }
}
