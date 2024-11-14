﻿// <auto-generated />
using AWPloiesti;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AWPloiesti.Migrations
{
    [DbContext(typeof(AWDbContext))]
    partial class AWDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.11");

            modelBuilder.Entity("AWPloiesti.Models.Participant", b =>
                {
                    b.Property<int>("ParticipantID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Losses")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TournamentID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Wins")
                        .HasColumnType("INTEGER");

                    b.HasKey("ParticipantID");

                    b.ToTable("Participants");
                });

            modelBuilder.Entity("AWPloiesti.Models.Tournament", b =>
                {
                    b.Property<int>("TournamentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CurrentPlayer1")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CurrentPlayer2")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("CurrentStage")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TournamentName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("TournamentID");

                    b.ToTable("Tournaments");
                });
#pragma warning restore 612, 618
        }
    }
}
