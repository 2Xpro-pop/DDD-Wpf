using CommunityToolkit.Common;
using CommunityToolkit.Diagnostics;

namespace ExampleWpfApp.Domain.ValueObjects;

public struct Number
{
    public string Value
    {
        get; private set;
    }

    public Number(string value)
    {
        if(!IsValid(value))
        {
            ThrowHelper.ThrowArgumentException(nameof(value), "Invalid phone number");
        }
        Value = value;
    }

    public static bool IsValid(string value)
    {
        return value.IsPhoneNumber();
    }
}