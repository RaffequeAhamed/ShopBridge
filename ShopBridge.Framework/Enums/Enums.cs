using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ShopBridge.Framework.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MeasurementUnit
    {
        Litre,
        Kilogram,
        Piece
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ProductStatus
    {
        Sold,
        InStock,
        OutOfStock
    }
}
