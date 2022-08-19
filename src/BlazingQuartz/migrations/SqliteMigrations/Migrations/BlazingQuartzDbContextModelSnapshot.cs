﻿// <auto-generated />
using System;
using BlazingQuartz.Core.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace SqliteMigrations.Migrations
{
    [DbContext(typeof(BlazingQuartzDbContext))]
    partial class BlazingQuartzDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.8");

            modelBuilder.Entity("BlazingQuartz.Core.History.ExecutionLog", b =>
                {
                    b.Property<long>("LogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset>("DateAddedUtc")
                        .HasColumnType("TEXT");

                    b.Property<string>("ExceptionMessage")
                        .HasColumnType("TEXT");

                    b.Property<string>("ExecutionDetails")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset?>("FireTimeUtc")
                        .HasColumnType("TEXT");

                    b.Property<bool?>("IsException")
                        .HasColumnType("INTEGER");

                    b.Property<bool?>("IsVetoed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("JobGroup")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("JobName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<TimeSpan?>("JobRunTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("LogType")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Result")
                        .HasMaxLength(8000)
                        .HasColumnType("TEXT");

                    b.Property<int?>("RetryCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("RunInstanceId")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset?>("ScheduleFireTimeUtc")
                        .HasColumnType("TEXT");

                    b.Property<string>("TriggerGroup")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("TriggerName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("LogId");

                    b.HasIndex("RunInstanceId")
                        .IsUnique();

                    b.HasIndex("DateAddedUtc", "LogType");

                    b.HasIndex("TriggerName", "TriggerGroup", "JobName", "JobGroup", "DateAddedUtc");

                    b.ToTable("bqz_ExecutionLogs");
                });
#pragma warning restore 612, 618
        }
    }
}
