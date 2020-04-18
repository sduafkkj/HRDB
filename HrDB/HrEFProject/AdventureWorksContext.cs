//using System.Data.Entity;
//namespace HrEFProject
//{
//    public partial class AdventureWorksContext:HrDBContext
//    {
//        static AdventureWorksContext()
//        {
//            Database.SetInitializer<AdventureWorksContext>(null);
//        }
//        public AdventureWorksContext()
//           : base("Name=AdventureWorksContext")
//        {
//        }
//        public DbSet<Employee> Employees { get; set; }
//        public DbSet<Person> People { get; set; }
//    }
//}
