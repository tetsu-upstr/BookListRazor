using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using BookListRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookListRazor.Pages.BookList
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        // コンストラクタ
        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public Book Book {get; set;}

        public void OnGet()
        {
        }
    }
}
