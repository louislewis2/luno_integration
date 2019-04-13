namespace LunoIntegration.Enums
{
    using System.Runtime.Serialization;

    public enum OrderStates
    {
        [EnumMember(Value = "PENDING")]
        Pending,

        [EnumMember(Value = "COMPLETE")]
        Complete
    }
}
