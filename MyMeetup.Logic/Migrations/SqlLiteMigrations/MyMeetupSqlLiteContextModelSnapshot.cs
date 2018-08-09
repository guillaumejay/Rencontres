﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyMeetUp.Logic.Infrastructure.DataContexts;

namespace MyMeetUp.Logic.Migrations.SqlLiteMigrations
{
    [DbContext(typeof(MyMeetupSqlLiteContext))]
    partial class MyMeetupSqlLiteContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<int>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("MyMeetUp.Logic.Entities.AppParameter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(80);

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getutcdate()");

                    b.HasKey("Id");

                    b.ToTable("AppParameters");
                });

            modelBuilder.Entity("MyMeetUp.Logic.Entities.CharterContent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasMaxLength(80);

                    b.Property<string>("Content")
                        .IsRequired();

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<bool>("IsActive");

                    b.Property<int?>("MeetupId");

                    b.Property<int>("Position");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getutcdate()");

                    b.HasKey("Id");

                    b.HasIndex("MeetupId");

                    b.ToTable("CharterContents");

                    b.HasData(
                        new { Id = 1, Category = "Communication sur le respect des lieux", Content = "Chaque membre de votre famille, présent à la rencontre, doit être informé que le respect des lieux est important pour que nous puissions revenir. Aussi merci de nous prévenir en cas d’éventuels dégâts pour montrer aux gérants notre implication dans la remise en état des lieux.", CreatedAt = new DateTime(2018, 8, 8, 18, 16, 4, 87, DateTimeKind.Utc), IsActive = true, Position = 1, UpdatedAt = new DateTime(2018, 8, 8, 18, 16, 4, 87, DateTimeKind.Utc) },
                        new { Id = 2, Category = "Animaux", Content = "Les chiens sont tolérés, à condition qu'ils restent attachés ou auprès de vous en permanence.<br/>Ils ne doivent également pas être bruyants.", CreatedAt = new DateTime(2018, 8, 8, 18, 16, 4, 87, DateTimeKind.Utc), IsActive = true, Position = 3, UpdatedAt = new DateTime(2018, 8, 8, 18, 16, 4, 87, DateTimeKind.Utc) },
                        new { Id = 3, Category = "Participation financière", Content = " Chaque famille participante devra régler 3€ de participation à Rencontres Nonscos : ces paiements permettront à l'association de couvrir ses dépenses d'existence (assurance notamment)", CreatedAt = new DateTime(2018, 8, 8, 18, 16, 4, 87, DateTimeKind.Utc), IsActive = true, Position = 2, UpdatedAt = new DateTime(2018, 8, 8, 18, 16, 4, 87, DateTimeKind.Utc) },
                        new { Id = 4, Category = "Alcool", Content = "La consommation d’alcool doit être raisonnée, pour toutes les personnes participantes, quel que soit leur âge, et bien sûr, les parents ou les référents sont invités à être attentifs à cette problématique vis-à-vis des personnes dont ils sont responsables.", CreatedAt = new DateTime(2018, 8, 8, 18, 16, 4, 87, DateTimeKind.Utc), IsActive = true, Position = 4, UpdatedAt = new DateTime(2018, 8, 8, 18, 16, 4, 87, DateTimeKind.Utc) },
                        new { Id = 5, Category = "Spécifique à la Taillade", Content = "La tradition est née de faire des trous autour du barbecue, il est important de les reboucher au départ des enfants", CreatedAt = new DateTime(2018, 8, 8, 18, 16, 4, 87, DateTimeKind.Utc), IsActive = true, MeetupId = 1, Position = 1, UpdatedAt = new DateTime(2018, 8, 8, 18, 16, 4, 87, DateTimeKind.Utc) }
                    );
                });

            modelBuilder.Entity("MyMeetUp.Logic.Entities.Meetup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("Date");

                    b.Property<bool>("IsVisible");

                    b.Property<DateTime?>("OpenForRegistrationOn");

                    b.Property<string>("PublicDescription")
                        .IsRequired();

                    b.Property<string>("RegisteredDescription")
                        .IsRequired();

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("Date");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(80);

                    b.Property<string>("TitleImage");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getutcdate()");

                    b.HasKey("Id");

                    b.ToTable("Meetups");

                    b.HasData(
                        new { Id = 1, CreatedAt = new DateTime(2018, 8, 8, 18, 16, 4, 87, DateTimeKind.Utc), EndDate = new DateTime(2018, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), IsVisible = true, OpenForRegistrationOn = new DateTime(2018, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), PublicDescription = @"Rencontre près de Casteljaloux(47). Situé dans un écrin de forêt, les hébergements se répartissent entre gîtes, landettes, emplacements pour tentes et camions, et quelques yourtes.<br/><div>
<h2><u>Comment s'inscrire &agrave; la rencontre ?</u></h2>
</div>
<div>Ne peuvent s'inscrire &agrave; cette rencontre que les personnes qui s'engagent &agrave; respecter la charte mise en place.</div>
<div><strong>Proc&eacute;dure&nbsp;</strong>:</div>
<div>1. Vous lisez l'engagement que vous demande la charte</div>
<div>2. Si la charte vous convient : vous vous engagez &agrave; la respecter en la validant, la signant num&eacute;riquement et en nous donnant vos coordonn&eacute;es : le tout nous sera adress&eacute; directement.</div>", RegisteredDescription = "<div><strong>Toutes les inscriptions (locatif ou camping) doivent se faire uniquement par mail <div><strong>", StartDate = new DateTime(2018, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "La Taillade 2018", TitleImage = "La-Taillade.jpg", UpdatedAt = new DateTime(2018, 8, 8, 18, 16, 4, 87, DateTimeKind.Utc) }
                    );
                });

            modelBuilder.Entity("MyMeetUp.Logic.Entities.MeetupAdmin", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("MeetupId");

                    b.HasKey("UserId", "MeetupId");

                    b.HasAlternateKey("MeetupId", "UserId");

                    b.ToTable("MeetupAdmins");
                });

            modelBuilder.Entity("MyMeetUp.Logic.Entities.Registration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<int>("MeetupId");

                    b.Property<string>("Notes")
                        .HasMaxLength(250);

                    b.Property<decimal>("PaidFees");

                    b.Property<int?>("ReferentUserId");

                    b.Property<string>("RegistrationCode")
                        .HasMaxLength(20);

                    b.Property<int>("RegistrationStatus");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("MeetupId");

                    b.HasIndex("ReferentUserId");

                    b.HasIndex("UserId");

                    b.ToTable("Registrations");
                });

            modelBuilder.Entity("MyMeetUp.Logic.Infrastructure.MyMeetupRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("MyMeetUp.Logic.Infrastructure.MyMeetupUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("MyMeetUp.Logic.Infrastructure.MyMeetupRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("MyMeetUp.Logic.Infrastructure.MyMeetupUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("MyMeetUp.Logic.Infrastructure.MyMeetupUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("MyMeetUp.Logic.Infrastructure.MyMeetupRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MyMeetUp.Logic.Infrastructure.MyMeetupUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("MyMeetUp.Logic.Infrastructure.MyMeetupUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MyMeetUp.Logic.Entities.CharterContent", b =>
                {
                    b.HasOne("MyMeetUp.Logic.Entities.Meetup", "Meetup")
                        .WithMany()
                        .HasForeignKey("MeetupId");
                });

            modelBuilder.Entity("MyMeetUp.Logic.Entities.MeetupAdmin", b =>
                {
                    b.HasOne("MyMeetUp.Logic.Entities.Meetup", "Meetup")
                        .WithMany("MeetupAdmins")
                        .HasForeignKey("MeetupId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MyMeetUp.Logic.Infrastructure.MyMeetupUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MyMeetUp.Logic.Entities.Registration", b =>
                {
                    b.HasOne("MyMeetUp.Logic.Entities.Meetup", "Meetup")
                        .WithMany()
                        .HasForeignKey("MeetupId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MyMeetUp.Logic.Infrastructure.MyMeetupUser", "ReferentUser")
                        .WithMany()
                        .HasForeignKey("ReferentUserId");

                    b.HasOne("MyMeetUp.Logic.Infrastructure.MyMeetupUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
