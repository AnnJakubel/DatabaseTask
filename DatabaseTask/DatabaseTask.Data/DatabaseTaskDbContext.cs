using DatabaseTask.Core.Domain;
using Microsoft.EntityFrameworkCore;


namespace DatabaseTask.Data
{
    public class DatabaseTaskDbContext : DbContext
    {
        public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
            : base(options) { }

        // näide, kuidas teha, kui lisate domaini alla ühe objekti
        // migratsioonid peavad tulema siia libary-sse e TARge20.Data alla.
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Child> Children { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeChildrenConnection> EmployeeChildrenConnections { get; set; }
        public DbSet<Hint> Hints { get; set; }
        public DbSet<JobTitleHistory> JobTitleHistories { get; set; }
        public DbSet<JobTitleList> JobTitleList { get; set; }
        public DbSet<Permissions> Permissions { get; set; }
        public DbSet<PhysicalEvaluation> PhysicalEvaluations { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<RentalItem> RentalItems { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<SickLeave> SickLeaves { get; set; }
        public DbSet<Vacation> Vacations { get; set; }
    }
}
