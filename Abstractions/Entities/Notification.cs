using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notifier.Abstractions.Entities;

public class Notification: Entity
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public Guid ListId { get; init; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public DateTime DateTime { get; set; }
    public bool IsImportant { get; set; }
    public bool IsDone { get; set; }
    public override string ToString()
        => $"{Name}";

}
