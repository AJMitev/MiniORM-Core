namespace MiniORM
{
    using System;

    public class DbContext
    {
        public static Type[] AllowedSqlTypes =
        {
            typeof(bool),
            typeof(string),
            typeof(int),
            typeof(uint),
            typeof(long),
            typeof(ulong),
            typeof(double),
            typeof(decimal),
            typeof(DateTime)
        };
    }
}