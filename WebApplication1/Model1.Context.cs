﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MyFirstDatabaseEntities1 : DbContext
    {
        public MyFirstDatabaseEntities1()
            : base("name=MyFirstDatabaseEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Area> Area { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<NBAScore> NBAScore { get; set; }
        public virtual DbSet<Seats> Seats { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<Students> Students { get; set; }
        public virtual DbSet<TblTeacher> TblTeacher { get; set; }
        public virtual DbSet<Test1> Test1 { get; set; }
        public virtual DbSet<Test2> Test2 { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<xiaoshuo> xiaoshuo { get; set; }
        public virtual DbSet<SeatsCopy> SeatsCopy { get; set; }
    }
}
