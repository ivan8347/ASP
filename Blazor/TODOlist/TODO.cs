

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TODOlist
{
    public class TODO
    {
        public required string Description { get; set; } 
        public bool DONE { get; set; }
        public bool IsAnimating { get; set; }
        public override bool Equals(object? other)
        {
            return this.Description.Equals((other as TODO).Description,StringComparison.OrdinalIgnoreCase);

        }
    }
}

