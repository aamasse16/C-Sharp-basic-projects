﻿using System.Data.Entity;

namespace FinalCSharpChallenge
{
    public class SchoolContext: DbContext
    {
        public SchoolContext() : base()
        { 
            
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}
