﻿// <auto-generated />
using besCenter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace besCenter.Migrations
{
    [DbContext(typeof(BESContext))]
    [Migration("20180412131618_Initial-Migration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("besCenter.Models.BESOrtak", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Ad");

                    b.Property<string>("Soyad");

                    b.Property<string>("SözleşmeDurumu");

                    b.Property<int>("TC");

                    b.Property<string>("Şirket");

                    b.HasKey("ID");

                    b.ToTable("BESOrtak");
                });
#pragma warning restore 612, 618
        }
    }
}
