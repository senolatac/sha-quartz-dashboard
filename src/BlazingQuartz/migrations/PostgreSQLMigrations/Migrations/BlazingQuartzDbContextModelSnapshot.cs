﻿// <auto-generated />
using System;
using BlazingQuartz.Core.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace PostgreSQLMigrations.Migrations
{
    [DbContext(typeof(BlazingQuartzDbContext))]
    partial class BlazingQuartzDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BlazingQuartz.Core.Data.Entities.ExecutionLog", b =>
                {
                    b.Property<long>("LogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("LogId"));

                    b.Property<DateTimeOffset>("DateAddedUtc")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ExceptionMessage")
                        .HasColumnType("text");

                    b.Property<string>("ExecutionDetails")
                        .HasColumnType("text");

                    b.Property<DateTimeOffset?>("FireTimeUtc")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool?>("IsException")
                        .HasColumnType("boolean");

                    b.Property<bool?>("IsVetoed")
                        .HasColumnType("boolean");

                    b.Property<string>("JobGroup")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("JobName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<TimeSpan?>("JobRunTime")
                        .HasColumnType("interval");

                    b.Property<string>("LogType")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Result")
                        .HasMaxLength(8000)
                        .HasColumnType("character varying(8000)");

                    b.Property<int?>("RetryCount")
                        .HasColumnType("integer");

                    b.Property<string>("RunInstanceId")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<DateTimeOffset?>("ScheduleFireTimeUtc")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("TriggerGroup")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("TriggerName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

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
