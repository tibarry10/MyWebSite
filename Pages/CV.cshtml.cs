using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace MyWebSite.Pages
{
    public class CVModel : PageModel
    {
        public string Nom { get; set; } = "Thierno Barry";
        public string Email { get; set; } = "tbexample@gmail.com";
        public string Telephone { get; set; } = "07.51.25.89.75";
        public string Adresse { get; set; } = "57b chemin de Bellevue, St Genis Laval, 69250";
        public string Description { get; set; } = "Actuellement �tudiant en BTS SIO (SLAM), passionn� par la programmation et � la recherche d�un stage pour approfondir mes comp�tences.";

        public List<Formation> Formations { get; set; } = new()
        {
            new Formation { Annee = "2023 - 2025", Diplome = "BTS SIO (SLAM)", Etablissement = "La Martini�re Duch�re, Lyon" },
            new Formation { Annee = "2022 - 2023", Diplome = "Terminale Syst�mes Num�riques", Etablissement = "Lyc�e Flesselles, Lyon" }
        };

        public List<Diplome> Diplomes { get; set; } = new()
        {
            new Diplome { Annee = "2023", Titre = "Baccalaur�at Professionnel (Mention Bien)" },
            new Diplome { Annee = "2022", Titre = "BAFA" }
        };

        public List<Experience> Experiences { get; set; } = new()
        {
            new Experience { Annee = "2023", Poste = "Stagiaire D�veloppement", Entreprise = "Makrisoft", Description = "Formation C# et base de donn�es (4 semaines)" },
            new Experience { Annee = "2022", Poste = "Projet Raspberry Pi", Entreprise = "Makrisoft", Description = "D�veloppement en Python et C# (4 semaines)" }
        };

        public List<string> Competences { get; set; } = new()
        {
            "C#", "ASP.NET Core", "XAML", "HTML/CSS", "JavaScript", "SQL"
        };

        public List<Langue> Langues { get; set; } = new()
        {
            new Langue { Nom = "Fran�ais", Niveau = "Langue maternelle" },
            new Langue { Nom = "Anglais", Niveau = "Interm�diaire (B2)" }
        };

        public void OnGet() { }
    }

    public class Formation { public string Annee { get; set; } public string Diplome { get; set; } public string Etablissement { get; set; } }
    public class Diplome { public string Annee { get; set; } public string Titre { get; set; } }
    public class Experience { public string Annee { get; set; } public string Poste { get; set; } public string Entreprise { get; set; } public string Description { get; set; } }
    public class Langue { public string Nom { get; set; } public string Niveau { get; set; } }
}
