﻿using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Issue12MySQL.Migrations
{
    public partial class V2020_03_30_1042 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    AddDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    Points = table.Column<long>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    ByteValue = table.Column<byte>(nullable: false),
                    CharValue = table.Column<string>(nullable: false),
                    DateTimeOffsetValue = table.Column<DateTimeOffset>(nullable: false),
                    DecimalValue = table.Column<decimal>(nullable: false),
                    DoubleValue = table.Column<double>(nullable: false),
                    FloatValue = table.Column<float>(nullable: false),
                    GuidValue = table.Column<Guid>(nullable: false),
                    TimeSpanValue = table.Column<TimeSpan>(nullable: false),
                    ShortValue = table.Column<short>(nullable: false),
                    ByteArrayValue = table.Column<byte[]>(nullable: true),
                    UintValue = table.Column<uint>(nullable: false),
                    UlongValue = table.Column<ulong>(nullable: false),
                    UshortValue = table.Column<ulong>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "People");
        }
    }
}
