﻿// <auto-generated />
using DotnetSpider.Migrator;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace DotnetSpider.Migrator.Migrations
{
    [DbContext(typeof(DotnetSpiderDbContext))]
    partial class DotnetSpiderDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DotnetSpider.Common.Entity.Block", b =>
                {
                    b.Property<string>("BlockId");

                    b.Property<string>("Identity");

                    b.Property<DateTime>("CreationTime");

                    b.Property<string>("Exception");

                    b.Property<DateTime?>("LastModificationTime");

                    b.HasKey("BlockId", "Identity");

                    b.ToTable("Block");
                });

            modelBuilder.Entity("DotnetSpider.Common.Entity.Node", b =>
                {
                    b.Property<string>("NodeId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(32);

                    b.Property<int>("CpuCount");

                    b.Property<DateTime>("CreationTime");

                    b.Property<string>("Group")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<string>("Ip")
                        .HasMaxLength(32);

                    b.Property<bool?>("IsEnable");

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<string>("Os")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<int>("TotalMemory");

                    b.HasKey("NodeId");

                    b.ToTable("Node");
                });

            modelBuilder.Entity("DotnetSpider.Common.Entity.Running", b =>
                {
                    b.Property<string>("Identity")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(32);

                    b.Property<int>("BlockTimes");

                    b.Property<DateTime>("CreationTime");

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<int>("Priority");

                    b.HasKey("Identity");

                    b.ToTable("Running");
                });

            modelBuilder.Entity("DotnetSpider.Common.Entity.RunningHistory", b =>
                {
                    b.Property<string>("Identity")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(32);

                    b.Property<DateTime>("CreationTime");

                    b.Property<string>("JobId")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<int>("Status");

                    b.HasKey("Identity");

                    b.ToTable("RunningHistory");
                });

            modelBuilder.Entity("DotnetSpider.Common.NodeHeartbeat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Cpu");

                    b.Property<long>("FreeMemory");

                    b.Property<string>("NodeId");

                    b.Property<int>("ProcessCount");

                    b.HasKey("Id");

                    b.ToTable("NodeHeartbeat");
                });

            modelBuilder.Entity("DotnetSpider.Common.RequestQueue", b =>
                {
                    b.Property<string>("RequestId")
                        .HasMaxLength(32);

                    b.Property<string>("Identity")
                        .HasMaxLength(32);

                    b.Property<string>("BlockId")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<DateTime>("CreationTime");

                    b.Property<DateTime?>("ProcessTime");

                    b.Property<string>("Request");

                    b.Property<string>("Response");

                    b.Property<DateTime?>("ResponseTime");

                    b.Property<int>("StatusCode");

                    b.HasKey("RequestId", "Identity");

                    b.HasAlternateKey("Identity", "RequestId");

                    b.ToTable("RequestQueue");
                });
#pragma warning restore 612, 618
        }
    }
}
