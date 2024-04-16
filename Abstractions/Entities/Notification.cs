using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notifier.Entities;

public class Notification
{
    public Guid Id { get; set; }
    public Guid ListId { get; init; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime DateTime { get; set;}
    public bool IsImportant { get; set; }

}
