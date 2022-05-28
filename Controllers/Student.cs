using CRUD.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentContext _Db;
        public StudentController(Models.StudentContext Db)
        {
            _Db = Db;
        }
        public IActionResult StudentList()
        {
           
            try
            {
                  return View();
               }
            catch (Exception ex)
            {

                return View();
            }
           
        }
    }
}
