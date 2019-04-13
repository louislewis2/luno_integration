namespace LunoIntegration.Enums
{
    using System.Runtime.Serialization;

    public enum OrderTypes
    {
        [EnumMember(Value = "BID")]
        Bid,

        [EnumMember(Value = "ASK")]
        Ask
    }
}
