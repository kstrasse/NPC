using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NPC.Models;
using NPC.Logic.Classes;

namespace NPC.Controllers
{
    public class CharacterController : Controller
    {
        [HttpGet]
        // GET: Character
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Index(ClassTypes selectedClass, int level = 1)
        {
            FifthEdCharacter character = new FifthEdCharacter(level);
            character.generate(selectedClass, level);
            return View(character);
        }
    }
}