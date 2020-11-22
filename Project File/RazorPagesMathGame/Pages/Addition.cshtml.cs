using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MathGame.Models;

namespace MathGame.Pages
{
    public class AdditionModel : PageModel
    {
        [BindProperty]
        public int firstNumber { get; set; }
        [BindProperty]
        public int secondNumber { get; set; }

        Console.WriteLine(      );


       
        public Additioninfo AdditionMod = new Additioninfo();
      // [BindProperty]
        public string  cool { get; set; }

        [BindProperty]
        public string FirstName { get; set; }

        public void OnGet()
        {
            firstNumber = AdditionMod.genorator.Next(1, 21);
            secondNumber = AdditionMod.genorator.Next(1, 21);
            if (string.IsNullOrWhiteSpace(FirstName) == true)
            {
                FirstName = AdditionMod.Answer;
            }
            
            
        }

        public IActionResult OnPost()
        {
            firstNumber = AdditionMod.genorator.Next(1, 21);
            secondNumber = AdditionMod.genorator.Next(1, 21);
            if (ModelState.IsValid == false)
            {
                return Page();

            }

            return Page();

        }
    }
}
