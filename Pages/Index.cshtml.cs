using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UserLog.Datos;
using UserLog.Models;

namespace UserLog.Pages
{
    public class IndexModel : PageModel
    {
      
        private readonly ILogger<IndexModel> _logger;
        public Collection<Users> users;
        public string Mensaje;
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public PageResult OnGetAsync(UserSql userSql)
        {

            users = userSql.Listar();
            Mensaje = "Diego Calderón S";
            return Page();

        }
    }
}