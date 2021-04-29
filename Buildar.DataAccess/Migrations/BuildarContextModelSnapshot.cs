﻿// <auto-generated />
using System;
using Buildar.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Buildar.DataAccess.Migrations
{
    [DbContext(typeof(BuildarContext))]
    partial class BuildarContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Buildar.Model.Build", b =>
                {
                    b.Property<string>("BuildId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BuildName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CpuId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("GpuId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MainImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MemoryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PsuId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("StorageId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("BuildId");

                    b.HasIndex("CpuId");

                    b.HasIndex("GpuId");

                    b.HasIndex("MemoryId");

                    b.HasIndex("PsuId");

                    b.HasIndex("StorageId");

                    b.HasIndex("UserId");

                    b.ToTable("Builds");
                });

            modelBuilder.Entity("Buildar.Model.Parts.Case", b =>
                {
                    b.Property<string>("CaseId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CaseMaker")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CaseModel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CasePrice")
                        .HasColumnType("int");

                    b.Property<int>("CaseSize")
                        .HasColumnType("int");

                    b.HasKey("CaseId");

                    b.ToTable("Cases");
                });

            modelBuilder.Entity("Buildar.Model.Parts.Cooler", b =>
                {
                    b.Property<string>("CoolerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("CoolerEstWattage")
                        .HasColumnType("int");

                    b.Property<string>("CoolerMaker")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CoolerModel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CoolerNoiseMax")
                        .HasColumnType("int");

                    b.Property<int>("CoolerNoiseMin")
                        .HasColumnType("int");

                    b.Property<int>("CoolerPrice")
                        .HasColumnType("int");

                    b.Property<int>("CoolerRpmMax")
                        .HasColumnType("int");

                    b.Property<int>("CoolerRpmMin")
                        .HasColumnType("int");

                    b.HasKey("CoolerId");

                    b.ToTable("Coolers");
                });

            modelBuilder.Entity("Buildar.Model.Parts.Cpu", b =>
                {
                    b.Property<string>("CpuId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("CpuClockMax")
                        .HasColumnType("int");

                    b.Property<int>("CpuClockMin")
                        .HasColumnType("int");

                    b.Property<int>("CpuCores")
                        .HasColumnType("int");

                    b.Property<int>("CpuEstWattage")
                        .HasColumnType("int");

                    b.Property<string>("CpuMaker")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CpuModel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CpuPrice")
                        .HasColumnType("int");

                    b.Property<int>("CpuReleaseDate")
                        .HasColumnType("int");

                    b.Property<string>("CpuSocket")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CpuThreads")
                        .HasColumnType("int");

                    b.HasKey("CpuId");

                    b.ToTable("Cpus");
                });

            modelBuilder.Entity("Buildar.Model.Parts.Gpu", b =>
                {
                    b.Property<string>("GpuId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("GpuClock")
                        .HasColumnType("int");

                    b.Property<int>("GpuEstWattage")
                        .HasColumnType("int");

                    b.Property<string>("GpuMaker")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GpuModel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GpuPrice")
                        .HasColumnType("int");

                    b.Property<int>("GpuReleaseDate")
                        .HasColumnType("int");

                    b.Property<int>("GpuVram")
                        .HasColumnType("int");

                    b.HasKey("GpuId");

                    b.ToTable("Gpus");
                });

            modelBuilder.Entity("Buildar.Model.Parts.Memory", b =>
                {
                    b.Property<string>("MemoryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("MemoryEstWattage")
                        .HasColumnType("int");

                    b.Property<string>("MemoryMaker")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MemoryModel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MemoryPrice")
                        .HasColumnType("int");

                    b.Property<int>("MemorySpeed")
                        .HasColumnType("int");

                    b.Property<string>("MemoryType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RMemorySticks")
                        .HasColumnType("int");

                    b.HasKey("MemoryId");

                    b.ToTable("Memorys");
                });

            modelBuilder.Entity("Buildar.Model.Parts.Motherboard", b =>
                {
                    b.Property<string>("MotherboardId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MotherboardChipset")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MotherboardEstWattage")
                        .HasColumnType("int");

                    b.Property<string>("MotherboardMaker")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherboardMaxSize")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherboardModel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MotherboardPrice")
                        .HasColumnType("int");

                    b.Property<string>("MotherboardSocket")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MotherboardId");

                    b.ToTable("Motherboards");
                });

            modelBuilder.Entity("Buildar.Model.Parts.Psu", b =>
                {
                    b.Property<string>("PsuId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PsuCertification")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PsuMaker")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PsuModel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PsuPrice")
                        .HasColumnType("int");

                    b.Property<int>("PsuWattage")
                        .HasColumnType("int");

                    b.HasKey("PsuId");

                    b.ToTable("Psus");
                });

            modelBuilder.Entity("Buildar.Model.Parts.Storage", b =>
                {
                    b.Property<string>("StorageId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("StorageEstWattage")
                        .HasColumnType("int");

                    b.Property<string>("StorageMaker")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StorageModel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StoragePrice")
                        .HasColumnType("int");

                    b.Property<int>("StorageSize")
                        .HasColumnType("int");

                    b.Property<string>("StorageType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StorageId");

                    b.ToTable("Storages");
                });

            modelBuilder.Entity("Buildar.Model.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Buildar.Model.Build", b =>
                {
                    b.HasOne("Buildar.Model.Parts.Cpu", "Cpu")
                        .WithMany()
                        .HasForeignKey("CpuId");

                    b.HasOne("Buildar.Model.Parts.Gpu", "Gpu")
                        .WithMany()
                        .HasForeignKey("GpuId");

                    b.HasOne("Buildar.Model.Parts.Memory", "Memory")
                        .WithMany()
                        .HasForeignKey("MemoryId");

                    b.HasOne("Buildar.Model.Parts.Psu", "Psu")
                        .WithMany()
                        .HasForeignKey("PsuId");

                    b.HasOne("Buildar.Model.Parts.Storage", "Storage")
                        .WithMany()
                        .HasForeignKey("StorageId");

                    b.HasOne("Buildar.Model.User", "User")
                        .WithMany("Builds")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
