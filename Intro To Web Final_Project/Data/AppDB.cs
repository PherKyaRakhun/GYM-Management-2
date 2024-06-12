using Microsoft.EntityFrameworkCore;
using Intro_To_Web_Final_Project.Models;
namespace Intro_To_Web_Final_Project.Data
{
    public class AppDbcontext:DbContext
    {
        public AppDbcontext(DbContextOptions<AppDbcontext> options) : base(options)
        {

        }

        public Dbset<Login> Login { get; set; }
    }
}
