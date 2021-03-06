﻿// <auto-generated />
using AppointmentEntry.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace AppointmentEntry.Migrations
{
    [DbContext(typeof(AppointmentEntryContext))]
    [Migration("20171120201154_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AppointmentEntry.Models.Appointment", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Date");

                    b.Property<string>("Description");

                    b.Property<string>("Time");

                    b.Property<string>("Title");

                    b.Property<string>("Type");

                    b.Property<bool>("Workrelated");

                    b.HasKey("ID");

                    b.ToTable("Appointment");
                });
#pragma warning restore 612, 618
        }
    }
}
