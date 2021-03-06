﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Internal;
using MyMeetUp.Logic.Entities;
using MyMeetUp.Logic.Infrastructure.DataContexts;
using System;
using System.Collections.Generic;

namespace MyMeetUp.Logic.Infrastructure
{
    public static class Seeding
    {
        public static void SeedData(MyMeetupContext context)
        {
            if (context.AppParameters.Any() == false)
            {
                AppParameter ap = new AppParameter { Title = "MyMeetup" };
                context.AppParameters.Add(ap);
                context.SaveChanges();
            }
            SeedMeetupData(context);
        }

        public static void SeedMeetupData(MyMeetupContext context)
        {
            if (context.Meetups.Any())
            {
                return;
            }
            Meetup m = new Meetup
            {

                Title = "Ce meetup 2018",
                StartDate = new DateTime(2018, 10, 22),
                EndDate = new DateTime(2018, 10, 29),
                IsVisible = true,
                OpenForRegistrationOn = new DateTime(2018, 2, 1),
                PublicDescription = "Situé dans un écrin de forêt, les hébergements se répartissent entre gîtes, landettes, emplacements pour tentes et camions, et quelques yourtes.<br/>"
              + @"<div>
<h2><u>Comment s'inscrire &agrave; la rencontre ?</u></h2>
</div>
<div>Ne peuvent s'inscrire &agrave; cette rencontre que les personnes qui s'engagent &agrave; respecter la charte mise en place.</div>
<div><strong>Proc&eacute;dure&nbsp;</strong>:</div>
<div>1. Vous lisez l'engagement que vous demande la charte</div>
<div>2. Si la charte vous convient : vous vous engagez &agrave; la respecter en la validant, la signant num&eacute;riquement et en nous donnant vos coordonn&eacute;es : le tout nous sera adress&eacute; directement.</div>",
                RegisteredDescription = "<div><strong>Toutes les inscriptions (locatif ou camping) doivent se faire uniquement par mail <div><strong>"
             
            };
            context.Meetups.Add(m);
            context.SaveChanges();
            List<CharterContent> chartes = new List<CharterContent>
            {
                new CharterContent
                {

                    Category = "Communication sur le respect des lieux",
                    Content =
                        "Chaque membre de votre famille, présent à la rencontre, doit être informé que le respect des lieux est important pour que nous puissions revenir. Aussi merci de nous prévenir en cas d’éventuels dégâts pour montrer aux gérants notre implication dans la remise en état des lieux.",
                    Position=1

                },
                new CharterContent
                {

                    Category = "Animaux",
                    Content =
                        "Les chiens sont tolérés, à condition qu'ils restent attachés ou auprès de vous en permanence.<br/>Ils ne doivent également pas être bruyants.",
                    Position=3

                },
                new CharterContent
                {

                    Category = "Participation financière",
                    Content =
                        " Chaque famille participante devra régler 3€ de participation à Rencontres Nonscos : ces paiements permettront à l'association de couvrir ses dépenses d'existence (assurance notamment)",
                    Position=2

                },
                new CharterContent
                {

                    Category = "Alcool",
                    Content =
                        "La consommation d’alcool doit être raisonnée, pour toutes les personnes participantes, quel que soit leur âge, et bien sûr, les parents ou les référents sont invités à être attentifs à cette problématique vis-à-vis des personnes dont ils sont responsables.",
                    Position=4

                },
                new CharterContent
                {

                    Category = "Spécifique à ce meetup",
                    Content =
                        "La tradition est née de faire des trous autour du barbecue, il est important de les reboucher au départ des enfants",
                  
                    Position=1

                }
            };
            int id = 1;
            foreach (var charte in chartes)
            {
                charte.MeetupId = m.Id;
            }
            context.CharterContents.AddRange(chartes);
            context.SaveChanges();
        }

        public static void SeedRoles(RoleManager<MyMeetupRole> roleManager)
        {
            if (!roleManager.RoleExistsAsync(MyMeetupRole.Participant).Result)
            {
                var role = new MyMeetupRole(MyMeetupRole.Participant);

                IdentityResult roleResult = roleManager.CreateAsync(role).Result;
            }


            if (!roleManager.RoleExistsAsync(MyMeetupRole.Administrateur).Result)
            {
                var role = new MyMeetupRole(MyMeetupRole.Administrateur);
                IdentityResult roleResult = roleManager.CreateAsync(role).Result;
            }
        }

        public static void SeedUsers(UserManager<MyMeetupUser> userManager)
        {
            if (userManager.FindByNameAsync("admin").Result == null)
            {
                var user = new MyMeetupUser
                {
                    UserName = "admin",
                    Email = "test@gmail.com",
                    FirstName = "test",
                    LastName = "test2",
                    LockoutEnabled = false
                };
                string pwd = $"admin{DateTime.Now:yyMMdd}";
                MyMeetupUser.CreateUser(user, MyMeetupRole.Administrateur, pwd, userManager);
            }
           
        }
    }
}
