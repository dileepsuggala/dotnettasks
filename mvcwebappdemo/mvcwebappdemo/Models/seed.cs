using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using mvcwebappdemo.data;
using Microsoft.EntityFrameworkCore;

namespace mvcwebappdemo.Models
{
    public class seed
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new bookcontext(serviceProvider.GetRequiredService<DbContextOptions<bookcontext>>())) 
            {
                if(context.Books.Any())
                {
                    return;
                }
                context.Books.AddRange(
                     new book
                     {
                         Btitle = "psycho",
                         Category = "psycho-thriller",
                         Price = 140,
                         Authorname = "subrahmanyam",
                         Publisher = "own",
                         Releasedate = Convert.ToDateTime("03-05-2018")
                     },
                new book
                    {
                        Btitle = "sadist",
                        Category = "lovestory",
                        Price = 120,
                        Authorname = "dileep",
                        Publisher = "own",
                        Releasedate = Convert.ToDateTime("10-02-2019")
                    });
                context.SaveChanges();
            }
        }
    }
}
