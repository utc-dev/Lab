using Bics.Data;
using Microsoft.EntityFrameworkCore;

namespace Lab.Data
{
    public class LabDataContext : AuditableDatabaseContext
    {
        public LabDataContext(DbContextOptions<LabDataContext> options) : base(options)
        {
        }
    }
}
