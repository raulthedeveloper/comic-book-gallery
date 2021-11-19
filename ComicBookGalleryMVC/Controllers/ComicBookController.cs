using System;
using Microsoft.AspNetCore.Mvc;

namespace ComicBookGalleryMVC.Controllers
{
    public class ComicBookController : Controller
    {
        public ActionResult Detail()
        {

            ViewBag.SeriesTitle = "The Amazing Iron Man";

            ViewBag.IssueNumber = 877;

            ViewBag.Description = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>";

            ViewBag.Artists = new string[]
             {
                "Script: Dan Slott",
                "Pencils: Humberto Ramos",
                "Inks: Victor Olazaba",
                "Colors: Edgar Delgado",
                "Letters: Chris Eliopoulos"
             };


            return View();

        }
        

    }
}