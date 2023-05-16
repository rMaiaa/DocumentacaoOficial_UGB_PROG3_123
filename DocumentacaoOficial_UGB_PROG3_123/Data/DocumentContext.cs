using DocumentacaoOficial_UGB_PROG3_123.Models.BLOG;
using DocumentacaoOficial_UGB_PROG3_123.Models.POST;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace DocumentacaoOficial_UGB_PROG3_123.Data
{
    public class DocumentContext : DbContext
    {
        public DocumentContext(DbContextOptions<DocumentContext> options) : base(options) { }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

    }
}
