using System;
using Microsoft.AspNetCore.Mvc;

namespace ComicBookGalleryMVC.Controllers
{
    public class ComicBookController : Controller
    {
        public ActionResult Detail()
        {
            var comicBook = new Models.ComicBook()
            {
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
                Artist = new Models.Artist[]
                {
                    new Models.Artist(){ Name="Dan Slot", Role = "Script"},
                    new Models.Artist(){ Name="Humberto Ramos", Role = "Pencils"},
                    new Models.Artist(){ Name="Victor Olazaba", Role = "Inks"},
                    new Models.Artist(){ Name="Edgar Delgado", Role = "Colors"},
                    new Models.Artist(){ Name="Chris Eliopoulos", Role = "Letters"},
                }
            };

            




            return View(comicBook);

        }
        

    }
}