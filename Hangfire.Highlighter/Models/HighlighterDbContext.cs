namespace Hangfire.Highlighter.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class HighlighterDbContext : DbContext
    {
        public HighlighterDbContext() : base("name=HighlighterDb") { }
        public DbSet<CodeSnippet> CodeSnippets { get; set; }
    }
}