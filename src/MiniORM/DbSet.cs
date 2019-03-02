namespace MiniORM
{
    using System.Collections.Generic;

    // TODO: Create your DbSet class here.
    public class DbSet<T>
    {
        public List<T> Entities { get; set; }
    }
}