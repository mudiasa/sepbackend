﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using sepbackend.Persistence;
using System;

namespace sepbackend.Migrations
{
    [DbContext(typeof(SepDbContext))]
    [Migration("20181016172028_descriptionToString")]
    partial class descriptionToString
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("sepbackend.Core.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("sepbackend.Core.Models.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Budget");

                    b.Property<int>("ClientId");

                    b.Property<string>("Description");

                    b.Property<string>("FinishDate")
                        .IsRequired();

                    b.Property<int>("NumberOfAttendees");

                    b.Property<string>("StartDate")
                        .IsRequired();

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<int>("UserId");

                    b.Property<bool>("isCreated");

                    b.Property<bool>("isSentToCSManager");

                    b.Property<bool>("isSentToProdManagers");

                    b.Property<bool>("isSentToSubTeams");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("UserId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("sepbackend.Core.Models.Preference", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .HasMaxLength(400);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<int>("RequestId");

                    b.HasKey("Id");

                    b.HasIndex("RequestId");

                    b.ToTable("Preferences");
                });

            modelBuilder.Entity("sepbackend.Core.Models.Request", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClientName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Description")
                        .HasMaxLength(400);

                    b.Property<string>("EventType")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<int>("ExpectedBudget");

                    b.Property<string>("FinishDate")
                        .IsRequired();

                    b.Property<int>("NumberOfAttendees");

                    b.Property<string>("RecordNumber")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("StartDate")
                        .IsRequired();

                    b.Property<int>("UserId");

                    b.Property<bool>("isSentBackToCSManager");

                    b.Property<bool>("isSentToAdminManager");

                    b.Property<bool>("isSentToCSManager");

                    b.Property<bool>("isSentToFinanceManager");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Requests");
                });

            modelBuilder.Entity("sepbackend.Core.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("sepbackend.Core.Models.Event", b =>
                {
                    b.HasOne("sepbackend.Core.Models.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("sepbackend.Core.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("sepbackend.Core.Models.Preference", b =>
                {
                    b.HasOne("sepbackend.Core.Models.Request", "Request")
                        .WithMany()
                        .HasForeignKey("RequestId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("sepbackend.Core.Models.Request", b =>
                {
                    b.HasOne("sepbackend.Core.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
