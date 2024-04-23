using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notifier.Abstractions;

public interface Entity
{
    public Guid Id { get; init; }
    public string Name { get; set; }
}
