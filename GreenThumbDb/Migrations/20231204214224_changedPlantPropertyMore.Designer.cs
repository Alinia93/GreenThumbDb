﻿// <auto-generated />
using GreenThumbDb.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GreenThumbDb.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231204214224_changedPlantPropertyMore")]
    partial class changedPlantPropertyMore
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GreenThumbDb.Models.Garden", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name)");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.ToTable("Gardens");
                });

            modelBuilder.Entity("GreenThumbDb.Models.GardenPlants", b =>
                {
                    b.Property<int>("PlantId")
                        .HasColumnType("int")
                        .HasColumnName("plant_id");

                    b.Property<int>("GardenId")
                        .HasColumnType("int")
                        .HasColumnName("garden_id");

                    b.HasKey("PlantId", "GardenId");

                    b.HasIndex("GardenId");

                    b.ToTable("GardenPlants");
                });

            modelBuilder.Entity("GreenThumbDb.Models.Instruction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.Property<int>("PlantId")
                        .HasColumnType("int")
                        .HasColumnName("plant_id");

                    b.HasKey("Id");

                    b.HasIndex("PlantId");

                    b.ToTable("Instructions");
                });

            modelBuilder.Entity("GreenThumbDb.Models.Plant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("BotanicalName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("botanical_name");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("color");

                    b.Property<string>("EnglishName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("english_name");

                    b.Property<string>("Family")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("family");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("image_url");

                    b.HasKey("Id");

                    b.ToTable("Plants");
                });

            modelBuilder.Entity("GreenThumbDb.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("password");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("user_name");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("GreenThumbDb.Models.Garden", b =>
                {
                    b.HasOne("GreenThumbDb.Models.User", "User")
                        .WithOne("Garden")
                        .HasForeignKey("GreenThumbDb.Models.Garden", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("GreenThumbDb.Models.GardenPlants", b =>
                {
                    b.HasOne("GreenThumbDb.Models.Garden", "Garden")
                        .WithMany("GardenPlants")
                        .HasForeignKey("GardenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GreenThumbDb.Models.Plant", "Plant")
                        .WithMany("GardenPlants")
                        .HasForeignKey("PlantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Garden");

                    b.Navigation("Plant");
                });

            modelBuilder.Entity("GreenThumbDb.Models.Instruction", b =>
                {
                    b.HasOne("GreenThumbDb.Models.Plant", "Plant")
                        .WithMany("Instructions")
                        .HasForeignKey("PlantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Plant");
                });

            modelBuilder.Entity("GreenThumbDb.Models.Garden", b =>
                {
                    b.Navigation("GardenPlants");
                });

            modelBuilder.Entity("GreenThumbDb.Models.Plant", b =>
                {
                    b.Navigation("GardenPlants");

                    b.Navigation("Instructions");
                });

            modelBuilder.Entity("GreenThumbDb.Models.User", b =>
                {
                    b.Navigation("Garden");
                });
#pragma warning restore 612, 618
        }
    }
}
