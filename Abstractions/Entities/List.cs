using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notifier.Abstractions.Entities;

public class List : Entity
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public string Name { get; set; }
    public override string ToString()
        => $"{Name}";
}
