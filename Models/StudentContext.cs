namespace StudentManagement.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Configuration;

    public class StudentContext : DbContext
    {
        // Votre contexte a été configuré pour utiliser une chaîne de connexion « StudentContext » du fichier 
        // de configuration de votre application (App.config ou Web.config). Par défaut, cette chaîne de connexion cible 
        // la base de données « StudentManagement.Models.StudentContext » sur votre instance LocalDb. 
        // 
        // Pour cibler une autre base de données et/ou un autre fournisseur de base de données, modifiez 
        // la chaîne de connexion « StudentContext » dans le fichier de configuration de l'application.
        public StudentContext()
            : base("name=StudentContext")
        {
        }

        // Ajoutez un DbSet pour chaque type d'entité à inclure dans votre modèle. Pour plus d'informations 
        // sur la configuration et l'utilisation du modèle Code First, consultez http://go.microsoft.com/fwlink/?LinkId=390109.

         public virtual DbSet<Group> Groups { get; set; }
         public virtual DbSet<Student> Students { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}