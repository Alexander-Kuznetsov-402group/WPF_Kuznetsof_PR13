﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WPF_Kuznetsof_PR13.ApplicationData
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PR13Entities : DbContext
    {
        private static PR13Entities _context;
        public PR13Entities()
            : base("name=PR13Entities")
        {
        }

        public static PR13Entities GetContext()
        {
            if (_context == null)
                _context = new PR13Entities();
            return _context;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Sklad> Sklad { get; set; }
        public virtual DbSet<Strana> Strana { get; set; }
    }
}
