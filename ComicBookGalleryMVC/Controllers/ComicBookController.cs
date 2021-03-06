using System;
using Microsoft.AspNetCore.Mvc;
using ComicBookGalleryMVC.Models;

namespace ComicBookGalleryMVC.Controllers
{
    public class ComicBookController : Controller
    {
        public ActionResult Detail()
        {

            var comicBook = new ComicBook()
            {
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",

                Artist = new Models.Artist[]
               {
                    new Artist(){ Name="Dan Slot", Role = "Script"},
                    new Artist(){ Name="Humberto Ramos", Role = "Pencils"},
                    new Artist(){ Name="Victor Olazaba", Role = "Inks"},
                    new Artist(){ Name="Edgar Delgado", Role = "Colors"},
                    new Artist(){ Name="Chris Eliopoulos", Role = "Letters"},
               }
            };
            






            return View(comicBook);

        }
        

    }
}