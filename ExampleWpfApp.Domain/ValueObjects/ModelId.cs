using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Diagnostics;

namespace ExampleWpfApp.Domain.ValueObjects;
public struct ModelId
{
    public Guid Value
    {
        get; set;
    }

    public ModelId()
    {
        Value = Guid.NewGuid();
    }

    public ModelId(Guid value)
    {
        if (IsValid(value))
        {
            ThrowHelper.ThrowArgumentException(nameof(value), "value cannot be empty!");
        }

        Value = value;
    }

    public static bool IsValid(Guid value)
    {
        return value == Guid.Empty;
    }
}
