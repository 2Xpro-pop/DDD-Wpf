using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExampleWpfApp.Domain.ValueObjects;

namespace ExampleWpfApp.Domain.Models;
public abstract class Entity
{
    public ModelId Id
    {
        get; set;
    }
}
