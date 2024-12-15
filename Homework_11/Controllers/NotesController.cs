using Microsoft.AspNetCore.Mvc;
using Homework_11.Models;
using System.Collections.Generic;

namespace Homework_11.Controllers
{
    public class NotesController : Controller
    {

        private static List<Note> notes = new List<Note>();


        public IActionResult Index()
        {
            return View(notes);
        }


        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(Note note, string tags)
        {
            if (ModelState.IsValid)
            {
                if (!string.IsNullOrEmpty(tags))
                {
                    note.Tags = new List<string>(tags.Split(','));
                }
                note.Id = notes.Count + 1;
                notes.Add(note); 
                return RedirectToAction(nameof(Index));
            }
            return View(note);
        }

    
        public IActionResult Details(int id)
        {
            var note = notes.Find(n => n.Id == id);
            if (note == null)
            {
                return NotFound();
            }
            return View(note);
        }
    }
}