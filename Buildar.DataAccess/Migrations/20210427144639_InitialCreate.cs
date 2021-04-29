using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Buildar.DataAccess.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cases",
                columns: table => new
                {
                    CaseId = table.Column<string>(nullable: false),
                    CaseModel = table.Column<string>(nullable: true),
                    CaseMaker = table.Column<string>(nullable: true),
                    CasePrice = table.Column<int>(nullable: false),
                    CaseSize = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cases", x => x.CaseId);
                });

            migrationBuilder.CreateTable(
                name: "Coolers",
                columns: table => new
                {
                    CoolerId = table.Column<string>(nullable: false),
                    CoolerModel = table.Column<string>(nullable: true),
                    CoolerMaker = table.Column<string>(nullable: true),
                    CoolerPrice = table.Column<int>(nullable: false),
                    CoolerNoiseMin = table.Column<int>(nullable: false),
                    CoolerNoiseMax = table.Column<int>(nullable: false),
                    CoolerRpmMin = table.Column<int>(nullable: false),
                    CoolerRpmMax = table.Column<int>(nullable: false),
                    CoolerEstWattage = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coolers", x => x.CoolerId);
                });

            migrationBuilder.CreateTable(
                name: "Cpus",
                columns: table => new
                {
                    CpuId = table.Column<string>(nullable: false),
                    CpuModel = table.Column<string>(nullable: true),
                    CpuMaker = table.Column<string>(nullable: true),
                    CpuPrice = table.Column<int>(nullable: false),
                    CpuCores = table.Column<int>(nullable: false),
                    CpuThreads = table.Column<int>(nullable: false),
                    CpuClockMin = table.Column<int>(nullable: false),
                    CpuClockMax = table.Column<int>(nullable: false),
                    CpuSocket = table.Column<string>(nullable: true),
                    CpuReleaseDate = table.Column<int>(nullable: false),
                    CpuEstWattage = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cpus", x => x.CpuId);
                });

            migrationBuilder.CreateTable(
                name: "Gpus",
                columns: table => new
                {
                    GpuId = table.Column<string>(nullable: false),
                    GpuModel = table.Column<string>(nullable: true),
                    GpuMaker = table.Column<string>(nullable: true),
                    GpuPrice = table.Column<int>(nullable: false),
                    GpuVram = table.Column<int>(nullable: false),
                    GpuClock = table.Column<int>(nullable: false),
                    GpuReleaseDate = table.Column<int>(nullable: false),
                    GpuEstWattage = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gpus", x => x.GpuId);
                });

            migrationBuilder.CreateTable(
                name: "Memorys",
                columns: table => new
                {
                    MemoryId = table.Column<string>(nullable: false),
                    MemoryModel = table.Column<string>(nullable: true),
                    MemoryMaker = table.Column<string>(nullable: true),
                    RMemorySticks = table.Column<int>(nullable: false),
                    MemoryPrice = table.Column<int>(nullable: false),
                    MemoryType = table.Column<string>(nullable: true),
                    MemorySpeed = table.Column<int>(nullable: false),
                    MemoryEstWattage = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Memorys", x => x.MemoryId);
                });

            migrationBuilder.CreateTable(
                name: "Motherboards",
                columns: table => new
                {
                    MotherboardId = table.Column<string>(nullable: false),
                    MotherboardModel = table.Column<string>(nullable: true),
                    MotherboardMaker = table.Column<string>(nullable: true),
                    MotherboardPrice = table.Column<int>(nullable: false),
                    MotherboardSocket = table.Column<string>(nullable: true),
                    MotherboardChipset = table.Column<string>(nullable: true),
                    MotherboardMaxSize = table.Column<string>(nullable: true),
                    MotherboardEstWattage = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motherboards", x => x.MotherboardId);
                });

            migrationBuilder.CreateTable(
                name: "Psus",
                columns: table => new
                {
                    PsuId = table.Column<string>(nullable: false),
                    PsuModel = table.Column<string>(nullable: true),
                    PsuMaker = table.Column<string>(nullable: true),
                    PsuPrice = table.Column<int>(nullable: false),
                    PsuWattage = table.Column<int>(nullable: false),
                    PsuCertification = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Psus", x => x.PsuId);
                });

            migrationBuilder.CreateTable(
                name: "Storages",
                columns: table => new
                {
                    StorageId = table.Column<string>(nullable: false),
                    StorageModel = table.Column<string>(nullable: true),
                    StorageMaker = table.Column<string>(nullable: true),
                    StoragePrice = table.Column<int>(nullable: false),
                    StorageSize = table.Column<int>(nullable: false),
                    StorageType = table.Column<string>(nullable: true),
                    StorageEstWattage = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Storages", x => x.StorageId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(maxLength: 50, nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Firstname = table.Column<string>(maxLength: 50, nullable: false),
                    Lastname = table.Column<string>(maxLength: 50, nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Builds",
                columns: table => new
                {
                    BuildId = table.Column<string>(nullable: false),
                    BuildName = table.Column<string>(nullable: true),
                    CpuId = table.Column<string>(nullable: true),
                    GpuId = table.Column<string>(nullable: true),
                    MemoryId = table.Column<string>(nullable: true),
                    StorageId = table.Column<string>(nullable: true),
                    PsuId = table.Column<string>(nullable: true),
                    MainImage = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Builds", x => x.BuildId);
                    table.ForeignKey(
                        name: "FK_Builds_Cpus_CpuId",
                        column: x => x.CpuId,
                        principalTable: "Cpus",
                        principalColumn: "CpuId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Builds_Gpus_GpuId",
                        column: x => x.GpuId,
                        principalTable: "Gpus",
                        principalColumn: "GpuId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Builds_Memorys_MemoryId",
                        column: x => x.MemoryId,
                        principalTable: "Memorys",
                        principalColumn: "MemoryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Builds_Psus_PsuId",
                        column: x => x.PsuId,
                        principalTable: "Psus",
                        principalColumn: "PsuId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Builds_Storages_StorageId",
                        column: x => x.StorageId,
                        principalTable: "Storages",
                        principalColumn: "StorageId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Builds_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Builds_CpuId",
                table: "Builds",
                column: "CpuId");

            migrationBuilder.CreateIndex(
                name: "IX_Builds_GpuId",
                table: "Builds",
                column: "GpuId");

            migrationBuilder.CreateIndex(
                name: "IX_Builds_MemoryId",
                table: "Builds",
                column: "MemoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Builds_PsuId",
                table: "Builds",
                column: "PsuId");

            migrationBuilder.CreateIndex(
                name: "IX_Builds_StorageId",
                table: "Builds",
                column: "StorageId");

            migrationBuilder.CreateIndex(
                name: "IX_Builds_UserId",
                table: "Builds",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Builds");

            migrationBuilder.DropTable(
                name: "Cases");

            migrationBuilder.DropTable(
                name: "Coolers");

            migrationBuilder.DropTable(
                name: "Motherboards");

            migrationBuilder.DropTable(
                name: "Cpus");

            migrationBuilder.DropTable(
                name: "Gpus");

            migrationBuilder.DropTable(
                name: "Memorys");

            migrationBuilder.DropTable(
                name: "Psus");

            migrationBuilder.DropTable(
                name: "Storages");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
