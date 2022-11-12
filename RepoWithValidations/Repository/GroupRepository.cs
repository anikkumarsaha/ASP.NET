using RepoWithValidations.Database;
using RepoWithValidations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepoWithValidations.Repository
{
    public class GroupRepository
    {
        static MidExamScenario1Entities db;

        static GroupRepository()
        {
            db = new MidExamScenario1Entities();
        }

        public static void AddGroup(GroupModel g)
        {
            Group gp = new Group();
            gp.Name = g.Name;
            db.Groups.Add(gp);
            db.SaveChanges();
        }
    }
}