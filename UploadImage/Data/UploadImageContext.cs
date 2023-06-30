using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UploadImage.Models;

namespace UploadImage.Data
{
    public class UploadImageContext : DbContext
    {
        public UploadImageContext (DbContextOptions<UploadImageContext> options)
            : base(options)
        {
        }

        public DbSet<UploadImage.Models.Student> Student { get; set; } = default!;
    }
}
