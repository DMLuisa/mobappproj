using project1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1.Models
{
    public enum Genre
    {
        Academic, Fantasy, Romance, Action, Novel, SciFi, Science, Mecha, Interstellar,
        Research, Detective, Police, Humor, Horror, Report, Law, Guides, Thriller,
        Math, Physics, Chemistry, Biology, Geography, Fhilosophy, History,
        Astronomy, Archeology, Anthropology, Psychology, Medecine, 
        Pharmachology, Agricultre, Engineering, Art, Sculpture, Sport,
        Misc_Academic, Misc_Literature
    };


    public class Books
    {
        public string bookTitle { get; set; }
        public string bookAuthor { get; set; }
        public string bookDescription { get; set; }

        public int noPhysCopies {  get; set; }

        public Genre[] bookGenre { get; set; }

        public Books()
        {
            bookTitle = "";
            bookAuthor = "";
            bookDescription = "";
            noPhysCopies = 0;
            bookGenre = new Genre[0];
        }

    }
}
