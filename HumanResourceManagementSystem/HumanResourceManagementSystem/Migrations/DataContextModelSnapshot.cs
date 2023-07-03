﻿// <auto-generated />
using System;
using HumanResourceManagementSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HumanResourceManagementSystem.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.16");

            modelBuilder.Entity("HumanResourceManagementSystem.Models.Departments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DepartmentName")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("HumanResourceManagementSystem.Models.Identity.HRMSUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("BloodType")
                        .HasColumnType("TEXT");

                    b.Property<string>("Citizenship")
                        .HasColumnType("TEXT");

                    b.Property<string>("CivilStatus")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("DateExam")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateHired")
                        .HasColumnType("TEXT");

                    b.Property<string>("DateRegitered")
                        .HasColumnType("TEXT");

                    b.Property<string>("DegreeEarned")
                        .HasColumnType("TEXT");

                    b.Property<int?>("DepartmentsId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("EmployeeNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("Ethnicity")
                        .HasColumnType("TEXT");

                    b.Property<string>("ExtentName")
                        .HasColumnType("TEXT");

                    b.Property<string>("FatherName")
                        .HasColumnType("TEXT");

                    b.Property<string>("FatherOccupation")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Gender")
                        .HasColumnType("TEXT");

                    b.Property<string>("GovLicensureExam")
                        .HasColumnType("TEXT");

                    b.Property<string>("Height")
                        .HasColumnType("TEXT");

                    b.Property<string>("Image")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("Major")
                        .HasColumnType("TEXT");

                    b.Property<string>("MastersAcademicHonor")
                        .HasColumnType("TEXT");

                    b.Property<string>("MastersDegreeEarned")
                        .HasColumnType("TEXT");

                    b.Property<string>("MastersMajor")
                        .HasColumnType("TEXT");

                    b.Property<string>("MastersSchool")
                        .HasColumnType("TEXT");

                    b.Property<string>("MastersYearGraduated")
                        .HasColumnType("TEXT");

                    b.Property<string>("MiddleName")
                        .HasColumnType("TEXT");

                    b.Property<string>("MotherName")
                        .HasColumnType("TEXT");

                    b.Property<string>("MotherOccupation")
                        .HasColumnType("TEXT");

                    b.Property<string>("NationalIDNo")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PagibigNo")
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PermanentAddress")
                        .HasColumnType("TEXT");

                    b.Property<string>("PermanentCityMun")
                        .HasColumnType("TEXT");

                    b.Property<string>("PermanentProvince")
                        .HasColumnType("TEXT");

                    b.Property<string>("PermanentZip")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhdAcademicHonor")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhdDegreeEarned")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhdMajor")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhdSchool")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhdYearGraduated")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhilHealthNo")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PlaceBirth")
                        .HasColumnType("TEXT");

                    b.Property<string>("PlaceofExam")
                        .HasColumnType("TEXT");

                    b.Property<int?>("PositionsId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PresentAddress")
                        .HasColumnType("TEXT");

                    b.Property<string>("PresentCityMun")
                        .HasColumnType("TEXT");

                    b.Property<string>("PresentProvince")
                        .HasColumnType("TEXT");

                    b.Property<string>("PresentZip")
                        .HasColumnType("TEXT");

                    b.Property<string>("PrimaryAcademicHonor")
                        .HasColumnType("TEXT");

                    b.Property<string>("PrimarySchool")
                        .HasColumnType("TEXT");

                    b.Property<string>("PrimaryYearGraduated")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rating")
                        .HasColumnType("TEXT");

                    b.Property<string>("RegNo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Religion")
                        .HasColumnType("TEXT");

                    b.Property<string>("Remarks")
                        .HasColumnType("TEXT");

                    b.Property<string>("SSSNo")
                        .HasColumnType("TEXT");

                    b.Property<string>("SecondaryAcademicHonor")
                        .HasColumnType("TEXT");

                    b.Property<string>("SecondarySchool")
                        .HasColumnType("TEXT");

                    b.Property<string>("SecondaryYearGraduated")
                        .HasColumnType("TEXT");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<string>("SpouseCompanyAdd")
                        .HasColumnType("TEXT");

                    b.Property<string>("SpouseCompanyName")
                        .HasColumnType("TEXT");

                    b.Property<string>("SpouseContactNo")
                        .HasColumnType("TEXT");

                    b.Property<string>("SpouseFullName")
                        .HasColumnType("TEXT");

                    b.Property<string>("SpouseOccupation")
                        .HasColumnType("TEXT");

                    b.Property<string>("TINNo")
                        .HasColumnType("TEXT");

                    b.Property<string>("TertiaryAcademicHonor")
                        .HasColumnType("TEXT");

                    b.Property<string>("TertiarySchool")
                        .HasColumnType("TEXT");

                    b.Property<string>("TertiaryYearGraduated")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("TEXT");

                    b.Property<string>("TribalAffiliation")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("Validity")
                        .HasColumnType("TEXT");

                    b.Property<string>("Weight")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentsId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.HasIndex("PositionsId");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("HumanResourceManagementSystem.Models.Positions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("PositionDescription")
                        .HasColumnType("TEXT");

                    b.Property<string>("PositionName")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("HumanResourceManagementSystem.Models.Identity.HRMSUser", b =>
                {
                    b.HasOne("HumanResourceManagementSystem.Models.Departments", "Departments")
                        .WithMany()
                        .HasForeignKey("DepartmentsId");

                    b.HasOne("HumanResourceManagementSystem.Models.Positions", "Positions")
                        .WithMany()
                        .HasForeignKey("PositionsId");

                    b.Navigation("Departments");

                    b.Navigation("Positions");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("HumanResourceManagementSystem.Models.Identity.HRMSUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("HumanResourceManagementSystem.Models.Identity.HRMSUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HumanResourceManagementSystem.Models.Identity.HRMSUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("HumanResourceManagementSystem.Models.Identity.HRMSUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
