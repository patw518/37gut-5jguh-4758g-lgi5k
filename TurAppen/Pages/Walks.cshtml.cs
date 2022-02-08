using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TurAppen.Model;

namespace TurAppen.Pages
{
    public class WalksModel : PageModel
    {
        private readonly TurDBContext dbContext;

        public WalksModel(TurDBContext db_c)
        {
            dbContext = db_c;
        }

        public IEnumerable<Walk> walks { get; set; }
        
        public async Task OnGet()
        {
            walks = await dbContext.Walks.ToListAsync();
            /*var w = new Walk();
            w.Description = "HELLO";
            dbContext.Walks.Add(w);
            dbContext.SaveChanges();*/
            var s = 2;
        }
    }
}
