using System;
using System.Collections.Generic;

namespace Server.Core.Entities
{
    public partial class Enterprise : Entity
    {
        public string Rnc { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Comercial { get; set; } = null!;
        public string? Category { get; set; }
        public string Payment { get; set; } = null!;
        public string Status { get; set; } = null!;
        public string Activity { get; set; } = null!;
        public string Branch { get; set; } = null!;
    }
}
