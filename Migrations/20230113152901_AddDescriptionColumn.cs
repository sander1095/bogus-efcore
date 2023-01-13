using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bogus_efcore.Migrations
{
    public partial class AddDescriptionColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Product",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 21, 23, 11, 7, 392, DateTimeKind.Unspecified).AddTicks(1554), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Refined Cotton Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 13, 1, 45, 15, 880, DateTimeKind.Unspecified).AddTicks(9614), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Small Steel Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 10, 4, 6, 24, 494, DateTimeKind.Unspecified).AddTicks(5363), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Generic Plastic Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 2, 14, 10, 36, 535, DateTimeKind.Unspecified).AddTicks(7798), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Generic Wooden Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 1, 8, 44, 1, 560, DateTimeKind.Unspecified).AddTicks(2202), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Ergonomic Plastic Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 30, 4, 39, 47, 333, DateTimeKind.Unspecified).AddTicks(8447), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Rustic Fresh Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 10, 4, 14, 49, 921, DateTimeKind.Unspecified).AddTicks(5275), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Handmade Plastic Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 24, 8, 21, 28, 400, DateTimeKind.Unspecified).AddTicks(6310), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Handcrafted Cotton Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 26, 21, 40, 48, 244, DateTimeKind.Unspecified).AddTicks(8820), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Ergonomic Rubber Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 12, 20, 32, 18, 979, DateTimeKind.Unspecified).AddTicks(4602), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Refined Soft Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 10, 23, 1, 10, 363, DateTimeKind.Unspecified).AddTicks(1665), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Generic Plastic Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 25, 21, 32, 33, 677, DateTimeKind.Unspecified).AddTicks(9405), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Awesome Metal Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 9, 2, 58, 44, 802, DateTimeKind.Unspecified).AddTicks(3722), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Rustic Metal Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 6, 17, 3, 6, 137, DateTimeKind.Unspecified).AddTicks(6241), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Gorgeous Steel Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 25, 6, 22, 25, 225, DateTimeKind.Unspecified).AddTicks(2105), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Rustic Granite Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 6, 0, 40, 43, 320, DateTimeKind.Unspecified).AddTicks(6329), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Awesome Fresh Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 22, 21, 22, 7, 82, DateTimeKind.Unspecified).AddTicks(7470), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Fantastic Fresh Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 2, 6, 21, 7, 372, DateTimeKind.Unspecified).AddTicks(17), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Practical Soft Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 20, 2, 33, 40, 193, DateTimeKind.Unspecified).AddTicks(1920), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Tasty Fresh Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 9, 15, 2, 48, 958, DateTimeKind.Unspecified).AddTicks(5816), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Fantastic Metal Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 28, 19, 44, 20, 255, DateTimeKind.Unspecified).AddTicks(7854), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Licensed Metal Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 13, 15, 29, 0, 431, DateTimeKind.Unspecified).AddTicks(484), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Rustic Fresh Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 9, 0, 33, 24, 845, DateTimeKind.Unspecified).AddTicks(4009), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Handcrafted Fresh Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 20, 11, 35, 10, 382, DateTimeKind.Unspecified).AddTicks(7400), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Gorgeous Granite Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 13, 9, 10, 46, 456, DateTimeKind.Unspecified).AddTicks(8468), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Sleek Wooden Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 13, 2, 52, 50, 132, DateTimeKind.Unspecified).AddTicks(8011), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Gorgeous Metal Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 25, 0, 3, 6, 242, DateTimeKind.Unspecified).AddTicks(1079), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Unbranded Concrete Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 11, 14, 2, 25, 942, DateTimeKind.Unspecified).AddTicks(4639), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Handmade Steel Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 11, 18, 37, 51, 869, DateTimeKind.Unspecified).AddTicks(9735), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Generic Plastic Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 2, 13, 59, 52, 479, DateTimeKind.Unspecified).AddTicks(3252), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Intelligent Plastic Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 9, 15, 59, 57, 479, DateTimeKind.Unspecified).AddTicks(5563), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Unbranded Wooden Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 10, 14, 26, 21, 978, DateTimeKind.Unspecified).AddTicks(6505), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Generic Fresh Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 30, 5, 5, 18, 14, DateTimeKind.Unspecified).AddTicks(2977), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Sleek Rubber Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 4, 11, 6, 44, 101, DateTimeKind.Unspecified).AddTicks(3887), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Practical Steel Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 30, 5, 31, 2, 278, DateTimeKind.Unspecified).AddTicks(5435), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Intelligent Rubber Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 18, 11, 44, 26, 721, DateTimeKind.Unspecified).AddTicks(7866), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Ergonomic Fresh Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 12, 17, 35, 975, DateTimeKind.Unspecified).AddTicks(2906), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Unbranded Frozen Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 31, 9, 5, 34, 633, DateTimeKind.Unspecified).AddTicks(6738), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Handmade Steel Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 11, 9, 34, 32, 292, DateTimeKind.Unspecified).AddTicks(3243), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Licensed Plastic Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 19, 14, 10, 21, 733, DateTimeKind.Unspecified).AddTicks(4059), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Small Soft Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 4, 16, 38, 15, 556, DateTimeKind.Unspecified).AddTicks(4105), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Rustic Wooden Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 14, 4, 16, 12, 934, DateTimeKind.Unspecified).AddTicks(5152), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Incredible Wooden Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 27, 14, 49, 11, 628, DateTimeKind.Unspecified).AddTicks(2328), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Licensed Soft Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 10, 20, 30, 18, 930, DateTimeKind.Unspecified).AddTicks(8255), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Awesome Cotton Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 13, 15, 47, 17, 670, DateTimeKind.Unspecified).AddTicks(8427), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Practical Frozen Gloves" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 9, 21, 17, 16, 890, DateTimeKind.Unspecified).AddTicks(7985), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Refined Plastic Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 8, 11, 28, 44, 679, DateTimeKind.Unspecified).AddTicks(182), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Incredible Metal Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 20, 12, 54, 3, 646, DateTimeKind.Unspecified).AddTicks(2259), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Refined Concrete Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 19, 18, 13, 42, 760, DateTimeKind.Unspecified).AddTicks(1101), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Awesome Plastic Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 19, 8, 7, 10, 798, DateTimeKind.Unspecified).AddTicks(7243), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Ergonomic Concrete Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 24, 3, 59, 37, 471, DateTimeKind.Unspecified).AddTicks(750), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Generic Concrete Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 30, 13, 18, 12, 922, DateTimeKind.Unspecified).AddTicks(4131), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Intelligent Soft Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 23, 3, 40, 57, 660, DateTimeKind.Unspecified).AddTicks(2101), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Small Frozen Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 11, 22, 55, 46, 255, DateTimeKind.Unspecified).AddTicks(3689), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Ergonomic Rubber Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 29, 2, 36, 32, 548, DateTimeKind.Unspecified).AddTicks(3626), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Incredible Soft Gloves" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 7, 8, 37, 34, 365, DateTimeKind.Unspecified).AddTicks(7400), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Intelligent Fresh Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 14, 0, 40, 52, 519, DateTimeKind.Unspecified).AddTicks(6576), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Handcrafted Wooden Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 12, 2, 17, 44, 169, DateTimeKind.Unspecified).AddTicks(3688), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Small Concrete Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 12, 6, 45, 23, 759, DateTimeKind.Unspecified).AddTicks(1139), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Small Concrete Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 25, 18, 26, 24, 709, DateTimeKind.Unspecified).AddTicks(1460), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Awesome Cotton Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 1, 22, 15, 56, 173, DateTimeKind.Unspecified).AddTicks(190), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Sleek Rubber Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 25, 14, 14, 55, 840, DateTimeKind.Unspecified).AddTicks(1067), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Refined Frozen Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 19, 8, 17, 29, 405, DateTimeKind.Unspecified).AddTicks(9103), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Incredible Concrete Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 17, 11, 24, 4, 724, DateTimeKind.Unspecified).AddTicks(1093), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Refined Fresh Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 6, 7, 56, 15, 1, DateTimeKind.Unspecified).AddTicks(9994), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Refined Concrete Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 2, 21, 17, 19, 805, DateTimeKind.Unspecified).AddTicks(8098), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Ergonomic Concrete Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 15, 1, 17, 27, 570, DateTimeKind.Unspecified).AddTicks(7982), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Handmade Steel Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 9, 10, 53, 5, 263, DateTimeKind.Unspecified).AddTicks(214), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Small Soft Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 23, 18, 58, 52, 849, DateTimeKind.Unspecified).AddTicks(3747), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Ergonomic Granite Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 23, 11, 9, 925, DateTimeKind.Unspecified).AddTicks(6359), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Licensed Plastic Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 20, 4, 13, 18, 416, DateTimeKind.Unspecified).AddTicks(1699), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Handcrafted Granite Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 27, 11, 12, 38, 537, DateTimeKind.Unspecified).AddTicks(8490), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Gorgeous Steel Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 23, 19, 54, 17, 553, DateTimeKind.Unspecified).AddTicks(6523), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Awesome Steel Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 11, 8, 26, 49, 432, DateTimeKind.Unspecified).AddTicks(6859), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Gorgeous Rubber Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 9, 20, 32, 42, 367, DateTimeKind.Unspecified).AddTicks(9876), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Ergonomic Steel Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 23, 13, 6, 46, 166, DateTimeKind.Unspecified).AddTicks(6527), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Fantastic Granite Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 24, 11, 52, 41, 585, DateTimeKind.Unspecified).AddTicks(49), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Licensed Concrete Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 24, 17, 48, 56, 312, DateTimeKind.Unspecified).AddTicks(6500), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Gorgeous Cotton Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 29, 3, 57, 11, 345, DateTimeKind.Unspecified).AddTicks(6957), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Small Frozen Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 2, 11, 10, 45, 300, DateTimeKind.Unspecified).AddTicks(4828), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Ergonomic Concrete Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 7, 2, 33, 34, 76, DateTimeKind.Unspecified).AddTicks(6289), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Intelligent Fresh Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 24, 23, 55, 42, 18, DateTimeKind.Unspecified).AddTicks(34), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Generic Soft Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 30, 21, 46, 40, 667, DateTimeKind.Unspecified).AddTicks(301), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Handmade Steel Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 26, 23, 52, 16, 482, DateTimeKind.Unspecified).AddTicks(1638), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Fantastic Plastic Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 29, 10, 25, 19, 554, DateTimeKind.Unspecified).AddTicks(6546), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Licensed Frozen Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 3, 22, 8, 1, 85, DateTimeKind.Unspecified).AddTicks(5132), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Intelligent Granite Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 6, 23, 23, 29, 544, DateTimeKind.Unspecified).AddTicks(2357), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Rustic Cotton Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 26, 7, 28, 32, 455, DateTimeKind.Unspecified).AddTicks(3535), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Unbranded Metal Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 16, 11, 14, 32, 711, DateTimeKind.Unspecified).AddTicks(4804), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Practical Metal Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 2, 15, 25, 52, 753, DateTimeKind.Unspecified).AddTicks(6514), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Tasty Soft Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 10, 1, 57, 10, 509, DateTimeKind.Unspecified).AddTicks(3930), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Handmade Plastic Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 20, 1, 14, 42, 292, DateTimeKind.Unspecified).AddTicks(7166), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Gorgeous Cotton Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 23, 20, 16, 10, 93, DateTimeKind.Unspecified).AddTicks(7877), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Rustic Metal Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 13, 17, 13, 33, 276, DateTimeKind.Unspecified).AddTicks(4075), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Gorgeous Steel Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 20, 1, 59, 3, 480, DateTimeKind.Unspecified).AddTicks(3755), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Handmade Metal Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 9, 1, 40, 32, 609, DateTimeKind.Unspecified).AddTicks(7559), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Rustic Granite Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 11, 12, 2, 44, 216, DateTimeKind.Unspecified).AddTicks(3372), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Practical Concrete Gloves" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 16, 17, 13, 31, 701, DateTimeKind.Unspecified).AddTicks(9239), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Licensed Fresh Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 11, 2, 15, 25, 671, DateTimeKind.Unspecified).AddTicks(8299), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Practical Soft Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 31, 1, 35, 2, 175, DateTimeKind.Unspecified).AddTicks(2173), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Handmade Wooden Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 30, 10, 18, 49, 663, DateTimeKind.Unspecified).AddTicks(2267), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Tasty Metal Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 23, 20, 9, 6, 605, DateTimeKind.Unspecified).AddTicks(364), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Small Metal Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 25, 19, 52, 41, 954, DateTimeKind.Unspecified).AddTicks(9352), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Licensed Metal Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 15, 14, 22, 23, 739, DateTimeKind.Unspecified).AddTicks(3472), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Refined Cotton Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 7, 8, 16, 36, 607, DateTimeKind.Unspecified).AddTicks(6853), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Fantastic Granite Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 5, 3, 2, 47, 849, DateTimeKind.Unspecified).AddTicks(4547), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Unbranded Frozen Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 29, 3, 49, 10, 168, DateTimeKind.Unspecified).AddTicks(3014), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Tasty Metal Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 11, 21, 49, 18, 513, DateTimeKind.Unspecified).AddTicks(4080), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Licensed Cotton Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 13, 9, 17, 13, 611, DateTimeKind.Unspecified).AddTicks(1744), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Rustic Cotton Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 1, 36, 47, 8, DateTimeKind.Unspecified).AddTicks(3241), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Licensed Rubber Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 8, 7, 11, 41, 814, DateTimeKind.Unspecified).AddTicks(5262), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Gorgeous Granite Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 10, 0, 28, 44, 128, DateTimeKind.Unspecified).AddTicks(4764), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Practical Soft Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 26, 15, 42, 29, 512, DateTimeKind.Unspecified).AddTicks(8803), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Small Granite Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 25, 7, 25, 56, 444, DateTimeKind.Unspecified).AddTicks(2504), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Ergonomic Cotton Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 18, 22, 28, 36, 490, DateTimeKind.Unspecified).AddTicks(5610), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Practical Steel Gloves" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 20, 26, 18, 410, DateTimeKind.Unspecified).AddTicks(4240), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Small Metal Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 3, 22, 17, 56, 669, DateTimeKind.Unspecified).AddTicks(9715), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Fantastic Steel Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 5, 15, 59, 46, 50, DateTimeKind.Unspecified).AddTicks(8112), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Sleek Rubber Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 17, 3, 29, 34, 588, DateTimeKind.Unspecified).AddTicks(3163), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Small Cotton Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 8, 19, 35, 9, 562, DateTimeKind.Unspecified).AddTicks(2120), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Handcrafted Granite Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 2, 14, 0, 25, 213, DateTimeKind.Unspecified).AddTicks(4064), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Fantastic Concrete Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 29, 4, 32, 47, 987, DateTimeKind.Unspecified).AddTicks(4569), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Gorgeous Concrete Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 30, 0, 41, 47, 369, DateTimeKind.Unspecified).AddTicks(6921), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Licensed Granite Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 13, 3, 27, 20, 201, DateTimeKind.Unspecified).AddTicks(2761), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Tasty Concrete Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 6, 18, 30, 54, 632, DateTimeKind.Unspecified).AddTicks(1640), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Sleek Cotton Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 5, 21, 55, 52, 30, DateTimeKind.Unspecified).AddTicks(6461), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Small Frozen Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 6, 16, 59, 3, 848, DateTimeKind.Unspecified).AddTicks(2522), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Awesome Wooden Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 1, 23, 26, 41, 525, DateTimeKind.Unspecified).AddTicks(4918), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Rustic Metal Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 13, 4, 8, 42, 847, DateTimeKind.Unspecified).AddTicks(6383), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Incredible Concrete Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 4, 11, 9, 14, 301, DateTimeKind.Unspecified).AddTicks(5396), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Awesome Cotton Gloves" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 2, 4, 40, 22, 947, DateTimeKind.Unspecified).AddTicks(6930), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Practical Metal Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 7, 1, 0, 0, 308, DateTimeKind.Unspecified).AddTicks(4033), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Tasty Plastic Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 18, 13, 13, 10, 627, DateTimeKind.Unspecified).AddTicks(6132), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Incredible Granite Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 31, 18, 17, 37, 598, DateTimeKind.Unspecified).AddTicks(1847), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Generic Wooden Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 13, 20, 3, 55, 18, DateTimeKind.Unspecified).AddTicks(2331), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Gorgeous Plastic Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 2, 16, 28, 4, 275, DateTimeKind.Unspecified).AddTicks(6784), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Incredible Cotton Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 19, 18, 34, 22, 235, DateTimeKind.Unspecified).AddTicks(2224), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Generic Metal Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 29, 19, 49, 51, 759, DateTimeKind.Unspecified).AddTicks(5195), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Refined Steel Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 4, 17, 37, 21, 894, DateTimeKind.Unspecified).AddTicks(8914), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Licensed Concrete Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 9, 12, 24, 69, DateTimeKind.Unspecified).AddTicks(5140), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Licensed Metal Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 9, 20, 23, 40, 594, DateTimeKind.Unspecified).AddTicks(1406), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Practical Rubber Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 16, 19, 4, 7, 749, DateTimeKind.Unspecified).AddTicks(2963), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Ergonomic Frozen Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 29, 3, 12, 49, 976, DateTimeKind.Unspecified).AddTicks(2232), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Awesome Granite Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 14, 13, 32, 26, 235, DateTimeKind.Unspecified).AddTicks(8297), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Handcrafted Concrete Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 16, 13, 12, 38, 201, DateTimeKind.Unspecified).AddTicks(7581), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Generic Cotton Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 6, 18, 49, 1, 562, DateTimeKind.Unspecified).AddTicks(9417), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Small Concrete Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 20, 16, 54, 22, 504, DateTimeKind.Unspecified).AddTicks(4150), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Generic Frozen Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 15, 6, 32, 30, 728, DateTimeKind.Unspecified).AddTicks(621), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Ergonomic Metal Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 13, 6, 18, 38, 166, DateTimeKind.Unspecified).AddTicks(7357), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Unbranded Metal Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 23, 10, 13, 6, 741, DateTimeKind.Unspecified).AddTicks(9322), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Gorgeous Soft Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 16, 20, 4, 17, 477, DateTimeKind.Unspecified).AddTicks(5762), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Sleek Concrete Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 27, 23, 33, 11, 436, DateTimeKind.Unspecified).AddTicks(9558), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Small Metal Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 13, 11, 1, 13, 949, DateTimeKind.Unspecified).AddTicks(4074), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Refined Concrete Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 1, 15, 59, 39, 999, DateTimeKind.Unspecified).AddTicks(1441), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Generic Frozen Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 16, 19, 49, 32, 666, DateTimeKind.Unspecified).AddTicks(7645), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Tasty Concrete Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 23, 4, 42, 9, 757, DateTimeKind.Unspecified).AddTicks(2525), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Unbranded Rubber Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 25, 4, 9, 11, 316, DateTimeKind.Unspecified).AddTicks(818), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Intelligent Frozen Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 14, 3, 30, 55, 619, DateTimeKind.Unspecified).AddTicks(3393), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Practical Fresh Gloves" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 13, 13, 0, 58, 248, DateTimeKind.Unspecified).AddTicks(9259), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Fantastic Soft Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 10, 22, 29, 24, 245, DateTimeKind.Unspecified).AddTicks(9246), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Handcrafted Metal Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 3, 23, 7, 50, 667, DateTimeKind.Unspecified).AddTicks(103), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Gorgeous Frozen Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 16, 13, 23, 13, 557, DateTimeKind.Unspecified).AddTicks(8777), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Incredible Wooden Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 16, 16, 49, 16, 982, DateTimeKind.Unspecified).AddTicks(9580), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Sleek Soft Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 19, 18, 35, 53, 229, DateTimeKind.Unspecified).AddTicks(5790), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Refined Frozen Gloves" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 16, 23, 59, 21, 311, DateTimeKind.Unspecified).AddTicks(1210), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Licensed Metal Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 16, 22, 37, 48, 820, DateTimeKind.Unspecified).AddTicks(4964), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Intelligent Steel Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 11, 1, 22, 19, 402, DateTimeKind.Unspecified).AddTicks(9310), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Gorgeous Cotton Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 28, 4, 38, 2, 41, DateTimeKind.Unspecified).AddTicks(6377), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Gorgeous Fresh Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 13, 19, 14, 4, 74, DateTimeKind.Unspecified).AddTicks(5271), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Incredible Concrete Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 8, 0, 59, 38, 377, DateTimeKind.Unspecified).AddTicks(8846), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Awesome Frozen Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 10, 11, 50, 54, 91, DateTimeKind.Unspecified).AddTicks(4017), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Handmade Cotton Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 27, 18, 11, 22, 147, DateTimeKind.Unspecified).AddTicks(6360), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Generic Wooden Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 27, 23, 11, 3, 626, DateTimeKind.Unspecified).AddTicks(4949), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Gorgeous Fresh Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 16, 6, 17, 15, 497, DateTimeKind.Unspecified).AddTicks(7413), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Small Rubber Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 16, 20, 32, 58, 376, DateTimeKind.Unspecified).AddTicks(3900), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Unbranded Fresh Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 26, 21, 19, 42, 248, DateTimeKind.Unspecified).AddTicks(4893), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Generic Granite Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 19, 0, 47, 4, 666, DateTimeKind.Unspecified).AddTicks(3015), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Intelligent Rubber Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 12, 2, 52, 34, 602, DateTimeKind.Unspecified).AddTicks(6499), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Refined Granite Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 16, 2, 58, 39, 585, DateTimeKind.Unspecified).AddTicks(1403), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Ergonomic Granite Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 7, 18, 41, 20, 914, DateTimeKind.Unspecified).AddTicks(2230), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Practical Soft Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 5, 11, 38, 15, 30, DateTimeKind.Unspecified).AddTicks(9037), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Tasty Concrete Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 27, 15, 59, 3, 987, DateTimeKind.Unspecified).AddTicks(7120), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Unbranded Steel Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 18, 2, 5, 45, 371, DateTimeKind.Unspecified).AddTicks(6981), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Rustic Rubber Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 13, 1, 54, 33, 87, DateTimeKind.Unspecified).AddTicks(5954), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Handcrafted Steel Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 7, 3, 6, 55, 881, DateTimeKind.Unspecified).AddTicks(9457), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Awesome Steel Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 27, 23, 59, 51, 844, DateTimeKind.Unspecified).AddTicks(4899), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Practical Fresh Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 19, 15, 51, 14, 600, DateTimeKind.Unspecified).AddTicks(5575), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Refined Steel Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 29, 16, 39, 1, 243, DateTimeKind.Unspecified).AddTicks(5093), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Small Steel Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 16, 19, 21, 10, 479, DateTimeKind.Unspecified).AddTicks(944), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Licensed Granite Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 26, 18, 36, 28, 116, DateTimeKind.Unspecified).AddTicks(4145), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Awesome Metal Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 3, 23, 17, 20, 456, DateTimeKind.Unspecified).AddTicks(7585), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Fantastic Concrete Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 12, 8, 0, 26, 840, DateTimeKind.Unspecified).AddTicks(5048), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Unbranded Frozen Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 25, 8, 51, 4, 160, DateTimeKind.Unspecified).AddTicks(7043), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Ergonomic Wooden Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 19, 10, 55, 991, DateTimeKind.Unspecified).AddTicks(5400), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Ergonomic Metal Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 1, 4, 32, 30, 766, DateTimeKind.Unspecified).AddTicks(4277), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Generic Metal Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 28, 1, 24, 24, 113, DateTimeKind.Unspecified).AddTicks(3792), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Ergonomic Metal Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 16, 14, 52, 8, 773, DateTimeKind.Unspecified).AddTicks(6409), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Handmade Granite Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 25, 1, 46, 20, 380, DateTimeKind.Unspecified).AddTicks(282), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Awesome Fresh Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 18, 15, 22, 49, 350, DateTimeKind.Unspecified).AddTicks(3814), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Ergonomic Plastic Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 20, 16, 2, 20, 993, DateTimeKind.Unspecified).AddTicks(2820), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Handcrafted Cotton Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 28, 1, 31, 50, 726, DateTimeKind.Unspecified).AddTicks(6479), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Licensed Granite Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 18, 11, 50, 36, 252, DateTimeKind.Unspecified).AddTicks(9146), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Handcrafted Plastic Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 29, 15, 4, 43, 81, DateTimeKind.Unspecified).AddTicks(2377), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Intelligent Granite Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 2, 7, 0, 40, 399, DateTimeKind.Unspecified).AddTicks(6464), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Generic Plastic Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 10, 10, 48, 47, 32, DateTimeKind.Unspecified).AddTicks(5571), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Intelligent Frozen Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 27, 17, 39, 26, 761, DateTimeKind.Unspecified).AddTicks(6855), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Incredible Metal Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 18, 15, 59, 620, DateTimeKind.Unspecified).AddTicks(5226), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Handcrafted Concrete Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 15, 14, 51, 21, 490, DateTimeKind.Unspecified).AddTicks(9764), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Gorgeous Plastic Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 27, 2, 21, 13, 446, DateTimeKind.Unspecified).AddTicks(6083), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Gorgeous Steel Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 11, 10, 50, 27, 295, DateTimeKind.Unspecified).AddTicks(6223), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Generic Wooden Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 16, 23, 44, 14, 278, DateTimeKind.Unspecified).AddTicks(2613), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Fantastic Frozen Gloves" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 30, 12, 42, 34, 825, DateTimeKind.Unspecified).AddTicks(7413), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Unbranded Plastic Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 31, 4, 50, 1, 500, DateTimeKind.Unspecified).AddTicks(7813), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Tasty Frozen Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 7, 20, 18, 2, 755, DateTimeKind.Unspecified).AddTicks(4579), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Tasty Soft Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 11, 1, 14, 59, 26, DateTimeKind.Unspecified).AddTicks(3212), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Gorgeous Plastic Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 2, 6, 39, 4, 905, DateTimeKind.Unspecified).AddTicks(4857), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Rustic Plastic Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 9, 20, 34, 47, 73, DateTimeKind.Unspecified).AddTicks(8089), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Rustic Rubber Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 27, 11, 8, 42, 194, DateTimeKind.Unspecified).AddTicks(9345), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Handcrafted Frozen Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 14, 21, 33, 3, 629, DateTimeKind.Unspecified).AddTicks(555), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Unbranded Fresh Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 1, 13, 11, 7, 662, DateTimeKind.Unspecified).AddTicks(5187), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Incredible Wooden Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 18, 13, 0, 26, 297, DateTimeKind.Unspecified).AddTicks(8218), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Licensed Fresh Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 13, 17, 24, 51, 395, DateTimeKind.Unspecified).AddTicks(6023), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Small Rubber Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 9, 3, 57, 41, 663, DateTimeKind.Unspecified).AddTicks(2138), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Generic Frozen Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 28, 13, 3, 20, 929, DateTimeKind.Unspecified).AddTicks(3430), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Fantastic Frozen Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 2, 13, 33, 34, 136, DateTimeKind.Unspecified).AddTicks(5679), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Small Cotton Gloves" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 20, 11, 49, 0, 54, DateTimeKind.Unspecified).AddTicks(5227), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Fantastic Steel Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 1, 11, 3, 25, 245, DateTimeKind.Unspecified).AddTicks(6979), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Tasty Rubber Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 29, 5, 26, 57, 613, DateTimeKind.Unspecified).AddTicks(4452), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Incredible Fresh Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 3, 8, 32, 41, 224, DateTimeKind.Unspecified).AddTicks(8234), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Rustic Rubber Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 9, 22, 17, 26, 12, DateTimeKind.Unspecified).AddTicks(4834), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Tasty Metal Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 21, 2, 33, 8, 118, DateTimeKind.Unspecified).AddTicks(8537), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Fantastic Wooden Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 28, 17, 26, 30, 105, DateTimeKind.Unspecified).AddTicks(4270), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Practical Granite Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 6, 12, 4, 16, 985, DateTimeKind.Unspecified).AddTicks(153), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Tasty Soft Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 11, 9, 10, 5, 334, DateTimeKind.Unspecified).AddTicks(9214), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Tasty Granite Gloves" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 11, 3, 20, 20, 71, DateTimeKind.Unspecified).AddTicks(8308), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Practical Granite Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 3, 14, 34, 58, 516, DateTimeKind.Unspecified).AddTicks(1025), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Fantastic Wooden Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 8, 16, 35, 54, 108, DateTimeKind.Unspecified).AddTicks(8172), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Handcrafted Frozen Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 5, 11, 19, 32, 513, DateTimeKind.Unspecified).AddTicks(5559), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Refined Steel Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 5, 5, 39, 37, 168, DateTimeKind.Unspecified).AddTicks(8912), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Licensed Metal Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 5, 11, 36, 48, 933, DateTimeKind.Unspecified).AddTicks(3622), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Fantastic Wooden Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 29, 15, 8, 17, 37, DateTimeKind.Unspecified).AddTicks(3897), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Sleek Cotton Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 2, 7, 49, 49, 644, DateTimeKind.Unspecified).AddTicks(6044), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Unbranded Plastic Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 30, 18, 11, 21, 550, DateTimeKind.Unspecified).AddTicks(1337), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Gorgeous Metal Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 11, 19, 9, 11, 968, DateTimeKind.Unspecified).AddTicks(7286), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Tasty Granite Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 16, 15, 47, 18, 504, DateTimeKind.Unspecified).AddTicks(7951), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Tasty Frozen Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 1, 21, 5, 10, 439, DateTimeKind.Unspecified).AddTicks(9809), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Licensed Granite Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 11, 21, 28, 702, DateTimeKind.Unspecified).AddTicks(9478), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Incredible Concrete Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 18, 3, 59, 669, DateTimeKind.Unspecified).AddTicks(863), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Incredible Concrete Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 5, 15, 41, 20, 968, DateTimeKind.Unspecified).AddTicks(901), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Awesome Soft Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 25, 8, 27, 32, 500, DateTimeKind.Unspecified).AddTicks(6076), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Rustic Fresh Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 19, 12, 48, 53, 304, DateTimeKind.Unspecified).AddTicks(8795), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Refined Metal Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 11, 12, 59, 20, 476, DateTimeKind.Unspecified).AddTicks(4930), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Sleek Granite Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 24, 9, 11, 13, 177, DateTimeKind.Unspecified).AddTicks(6032), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Fantastic Cotton Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 25, 9, 50, 34, 884, DateTimeKind.Unspecified).AddTicks(3678), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Small Metal Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 12, 0, 47, 27, 253, DateTimeKind.Unspecified).AddTicks(6664), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Handcrafted Fresh Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 29, 10, 41, 41, 9, DateTimeKind.Unspecified).AddTicks(2391), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Rustic Granite Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 11, 9, 33, 47, 860, DateTimeKind.Unspecified).AddTicks(8212), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Unbranded Wooden Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 13, 10, 19, 28, 93, DateTimeKind.Unspecified).AddTicks(9979), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Generic Wooden Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 4, 20, 58, 8, 933, DateTimeKind.Unspecified).AddTicks(9588), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Licensed Metal Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 24, 8, 44, 54, 612, DateTimeKind.Unspecified).AddTicks(4773), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Intelligent Frozen Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 10, 7, 8, 13, 95, DateTimeKind.Unspecified).AddTicks(5214), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Sleek Concrete Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 18, 5, 43, 40, 471, DateTimeKind.Unspecified).AddTicks(4139), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Tasty Frozen Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 21, 2, 16, 34, 254, DateTimeKind.Unspecified).AddTicks(2782), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Small Wooden Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 13, 18, 32, 19, 752, DateTimeKind.Unspecified).AddTicks(404), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Gorgeous Metal Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 28, 0, 14, 27, 662, DateTimeKind.Unspecified).AddTicks(4315), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Unbranded Fresh Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 22, 11, 36, 33, 626, DateTimeKind.Unspecified).AddTicks(222), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Ergonomic Soft Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 22, 7, 21, 2, 872, DateTimeKind.Unspecified).AddTicks(1149), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Rustic Granite Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 5, 7, 58, 47, 141, DateTimeKind.Unspecified).AddTicks(7496), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Handcrafted Metal Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 25, 0, 17, 10, 602, DateTimeKind.Unspecified).AddTicks(3243), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Generic Concrete Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 17, 8, 59, 49, 304, DateTimeKind.Unspecified).AddTicks(7079), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Handcrafted Steel Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 28, 22, 7, 33, 85, DateTimeKind.Unspecified).AddTicks(2224), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Sleek Soft Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 17, 4, 57, 18, 653, DateTimeKind.Unspecified).AddTicks(4697), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Generic Rubber Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 23, 18, 38, 17, 543, DateTimeKind.Unspecified).AddTicks(8234), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Intelligent Granite Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 26, 18, 36, 21, 513, DateTimeKind.Unspecified).AddTicks(6340), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Sleek Granite Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 28, 7, 39, 53, 461, DateTimeKind.Unspecified).AddTicks(746), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Sleek Steel Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 11, 17, 53, 11, 95, DateTimeKind.Unspecified).AddTicks(8990), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Handcrafted Steel Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 4, 3, 47, 20, 201, DateTimeKind.Unspecified).AddTicks(1247), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Small Plastic Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 11, 17, 54, 32, 336, DateTimeKind.Unspecified).AddTicks(136), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Fantastic Cotton Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 24, 6, 57, 3, 565, DateTimeKind.Unspecified).AddTicks(7389), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Small Cotton Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 4, 18, 34, 30, 217, DateTimeKind.Unspecified).AddTicks(1948), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Ergonomic Cotton Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 23, 20, 40, 34, 682, DateTimeKind.Unspecified).AddTicks(3038), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Rustic Granite Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 21, 11, 38, 51, 991, DateTimeKind.Unspecified).AddTicks(734), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Practical Frozen Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 20, 14, 42, 18, 119, DateTimeKind.Unspecified).AddTicks(1096), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Awesome Frozen Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 24, 1, 19, 40, 111, DateTimeKind.Unspecified).AddTicks(1778), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Unbranded Metal Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 13, 5, 11, 37, 310, DateTimeKind.Unspecified).AddTicks(9732), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Rustic Rubber Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 6, 6, 28, 0, 980, DateTimeKind.Unspecified).AddTicks(3398), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Rustic Fresh Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 1, 22, 0, 36, 876, DateTimeKind.Unspecified).AddTicks(133), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Gorgeous Plastic Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 28, 0, 28, 19, 539, DateTimeKind.Unspecified).AddTicks(704), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Awesome Concrete Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 27, 19, 40, 8, 608, DateTimeKind.Unspecified).AddTicks(5885), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Sleek Plastic Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 22, 1, 3, 11, 882, DateTimeKind.Unspecified).AddTicks(978), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Ergonomic Steel Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 11, 12, 44, 13, 143, DateTimeKind.Unspecified).AddTicks(2527), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Practical Rubber Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 5, 10, 17, 37, 373, DateTimeKind.Unspecified).AddTicks(4156), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Awesome Soft Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 17, 19, 37, 33, 967, DateTimeKind.Unspecified).AddTicks(615), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Handcrafted Plastic Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 15, 17, 12, 35, 69, DateTimeKind.Unspecified).AddTicks(4409), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Gorgeous Plastic Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 12, 1, 11, 19, 145, DateTimeKind.Unspecified).AddTicks(2366), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Handcrafted Cotton Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 16, 14, 23, 8, 144, DateTimeKind.Unspecified).AddTicks(8195), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Licensed Frozen Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 3, 19, 56, 37, 313, DateTimeKind.Unspecified).AddTicks(6668), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Ergonomic Plastic Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 10, 19, 16, 57, 421, DateTimeKind.Unspecified).AddTicks(6457), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Handcrafted Steel Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 17, 14, 46, 19, 982, DateTimeKind.Unspecified).AddTicks(2918), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Handmade Granite Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 19, 6, 43, 8, 236, DateTimeKind.Unspecified).AddTicks(5337), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Rustic Frozen Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 7, 20, 43, 23, 434, DateTimeKind.Unspecified).AddTicks(3558), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Handmade Cotton Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 8, 15, 48, 10, 658, DateTimeKind.Unspecified).AddTicks(7670), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Ergonomic Cotton Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 13, 6, 51, 37, 488, DateTimeKind.Unspecified).AddTicks(868), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Awesome Rubber Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 25, 13, 6, 39, 377, DateTimeKind.Unspecified).AddTicks(7940), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Incredible Frozen Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 24, 2, 26, 54, 628, DateTimeKind.Unspecified).AddTicks(5841), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Gorgeous Concrete Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 22, 5, 31, 2, 346, DateTimeKind.Unspecified).AddTicks(9801), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Rustic Metal Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 24, 12, 16, 14, 411, DateTimeKind.Unspecified).AddTicks(9833), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Licensed Concrete Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 17, 0, 50, 4, 279, DateTimeKind.Unspecified).AddTicks(4493), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Handcrafted Soft Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 26, 23, 23, 52, 418, DateTimeKind.Unspecified).AddTicks(2215), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Incredible Concrete Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 3, 23, 8, 14, 559, DateTimeKind.Unspecified).AddTicks(6589), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Intelligent Wooden Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 1, 23, 44, 904, DateTimeKind.Unspecified).AddTicks(4588), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Intelligent Metal Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 30, 9, 35, 53, 824, DateTimeKind.Unspecified).AddTicks(2499), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Sleek Steel Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 23, 10, 35, 15, 549, DateTimeKind.Unspecified).AddTicks(8933), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Fantastic Granite Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 22, 14, 47, 12, 722, DateTimeKind.Unspecified).AddTicks(5409), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Fantastic Rubber Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 22, 27, 51, 633, DateTimeKind.Unspecified).AddTicks(1499), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Awesome Concrete Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 3, 21, 9, 31, 476, DateTimeKind.Unspecified).AddTicks(7063), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Small Soft Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 7, 14, 3, 36, 27, DateTimeKind.Unspecified).AddTicks(4992), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Small Soft Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 29, 12, 36, 10, 296, DateTimeKind.Unspecified).AddTicks(3844), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Rustic Granite Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 27, 3, 40, 33, 199, DateTimeKind.Unspecified).AddTicks(6709), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Awesome Wooden Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 1, 15, 51, 27, 837, DateTimeKind.Unspecified).AddTicks(3797), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Licensed Rubber Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 15, 6, 35, 24, 110, DateTimeKind.Unspecified).AddTicks(4651), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Generic Frozen Gloves" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 3, 21, 3, 49, 895, DateTimeKind.Unspecified).AddTicks(8190), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Small Granite Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 6, 12, 5, 54, 303, DateTimeKind.Unspecified).AddTicks(1357), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Handmade Granite Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 16, 15, 53, 10, 228, DateTimeKind.Unspecified).AddTicks(5765), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Awesome Soft Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 2, 16, 23, 45, 215, DateTimeKind.Unspecified).AddTicks(9287), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Refined Plastic Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 2, 18, 59, 814, DateTimeKind.Unspecified).AddTicks(8648), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Practical Plastic Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 24, 12, 27, 35, 882, DateTimeKind.Unspecified).AddTicks(9604), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Practical Frozen Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 13, 13, 3, 10, 38, DateTimeKind.Unspecified).AddTicks(5552), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Ergonomic Granite Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 3, 18, 51, 44, 623, DateTimeKind.Unspecified).AddTicks(8155), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Handcrafted Frozen Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 23, 17, 39, 56, 755, DateTimeKind.Unspecified).AddTicks(855), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Ergonomic Soft Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 10, 13, 16, 38, 623, DateTimeKind.Unspecified).AddTicks(3067), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Small Frozen Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 26, 18, 41, 39, 862, DateTimeKind.Unspecified).AddTicks(7825), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Gorgeous Cotton Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 3, 6, 35, 32, 110, DateTimeKind.Unspecified).AddTicks(6229), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Handmade Soft Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 23, 13, 57, 23, 535, DateTimeKind.Unspecified).AddTicks(4539), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Refined Frozen Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 14, 9, 0, 3, 298, DateTimeKind.Unspecified).AddTicks(1947), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Small Rubber Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 18, 19, 22, 10, 891, DateTimeKind.Unspecified).AddTicks(5610), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Refined Metal Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 15, 7, 57, 21, 188, DateTimeKind.Unspecified).AddTicks(4439), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Handcrafted Metal Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 1, 21, 59, 34, 327, DateTimeKind.Unspecified).AddTicks(6903), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Sleek Wooden Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 21, 12, 1, 23, 143, DateTimeKind.Unspecified).AddTicks(9948), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Handcrafted Wooden Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 22, 9, 59, 18, 514, DateTimeKind.Unspecified).AddTicks(9617), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Tasty Concrete Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 15, 17, 38, 34, 573, DateTimeKind.Unspecified).AddTicks(2339), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Ergonomic Granite Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 30, 9, 48, 4, 413, DateTimeKind.Unspecified).AddTicks(2868), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Fantastic Fresh Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 6, 9, 24, 31, 15, DateTimeKind.Unspecified).AddTicks(2394), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Awesome Rubber Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 1, 6, 28, 3, 505, DateTimeKind.Unspecified).AddTicks(7737), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Small Soft Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 12, 4, 4, 22, 694, DateTimeKind.Unspecified).AddTicks(2715), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Handmade Frozen Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 27, 3, 23, 35, 729, DateTimeKind.Unspecified).AddTicks(3091), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Refined Steel Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 9, 13, 24, 43, 907, DateTimeKind.Unspecified).AddTicks(155), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Generic Wooden Gloves" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 27, 3, 47, 28, 480, DateTimeKind.Unspecified).AddTicks(6211), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Rustic Granite Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 27, 2, 42, 17, 869, DateTimeKind.Unspecified).AddTicks(2819), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Generic Rubber Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 26, 13, 52, 51, 543, DateTimeKind.Unspecified).AddTicks(445), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Rustic Fresh Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 13, 13, 34, 9, 357, DateTimeKind.Unspecified).AddTicks(9017), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Intelligent Plastic Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 18, 14, 44, 2, 932, DateTimeKind.Unspecified).AddTicks(595), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Intelligent Steel Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 9, 12, 40, 36, 338, DateTimeKind.Unspecified).AddTicks(314), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Incredible Plastic Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 24, 16, 28, 36, 899, DateTimeKind.Unspecified).AddTicks(6414), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Practical Concrete Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 17, 17, 27, 14, 984, DateTimeKind.Unspecified).AddTicks(6042), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Awesome Frozen Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 2, 16, 42, 5, 565, DateTimeKind.Unspecified).AddTicks(4628), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Rustic Granite Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 11, 3, 50, 6, 556, DateTimeKind.Unspecified).AddTicks(5290), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Tasty Concrete Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 31, 17, 36, 46, 425, DateTimeKind.Unspecified).AddTicks(5605), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Incredible Concrete Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 24, 6, 12, 24, 663, DateTimeKind.Unspecified).AddTicks(4305), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Rustic Fresh Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 9, 19, 47, 2, 329, DateTimeKind.Unspecified).AddTicks(2978), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Gorgeous Cotton Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 5, 17, 42, 32, 987, DateTimeKind.Unspecified).AddTicks(3502), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Unbranded Metal Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 22, 12, 2, 20, 769, DateTimeKind.Unspecified).AddTicks(5523), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Intelligent Plastic Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 16, 4, 44, 30, 136, DateTimeKind.Unspecified).AddTicks(929), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Handcrafted Frozen Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 30, 15, 50, 20, 266, DateTimeKind.Unspecified).AddTicks(5935), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Ergonomic Frozen Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 18, 23, 24, 8, 357, DateTimeKind.Unspecified).AddTicks(6643), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Intelligent Metal Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 28, 5, 8, 56, 534, DateTimeKind.Unspecified).AddTicks(943), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Handcrafted Cotton Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 9, 20, 6, 26, 437, DateTimeKind.Unspecified).AddTicks(860), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Handcrafted Soft Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 7, 42, 9, 343, DateTimeKind.Unspecified).AddTicks(574), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Gorgeous Plastic Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 16, 14, 41, 45, 317, DateTimeKind.Unspecified).AddTicks(9598), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Tasty Steel Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 13, 7, 26, 32, 62, DateTimeKind.Unspecified).AddTicks(6450), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Intelligent Fresh Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 19, 17, 57, 7, 104, DateTimeKind.Unspecified).AddTicks(336), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Fantastic Metal Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 5, 12, 1, 12, 453, DateTimeKind.Unspecified).AddTicks(2863), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Intelligent Plastic Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 13, 17, 54, 19, 451, DateTimeKind.Unspecified).AddTicks(6739), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Licensed Plastic Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 6, 21, 24, 18, 1, DateTimeKind.Unspecified).AddTicks(4898), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Unbranded Plastic Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 16, 21, 31, 2, 233, DateTimeKind.Unspecified).AddTicks(1337), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Handmade Cotton Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 18, 12, 53, 43, 327, DateTimeKind.Unspecified).AddTicks(5672), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Ergonomic Metal Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 8, 5, 49, 26, 209, DateTimeKind.Unspecified).AddTicks(6313), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Refined Plastic Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 28, 21, 20, 56, 593, DateTimeKind.Unspecified).AddTicks(6101), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Tasty Wooden Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 7, 16, 9, 9, 486, DateTimeKind.Unspecified).AddTicks(4196), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Tasty Soft Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 14, 10, 52, 36, 433, DateTimeKind.Unspecified).AddTicks(1637), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Handmade Fresh Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 11, 1, 25, 48, 450, DateTimeKind.Unspecified).AddTicks(7612), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Refined Metal Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 31, 0, 55, 26, 683, DateTimeKind.Unspecified).AddTicks(8966), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Tasty Frozen Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 29, 11, 18, 4, 272, DateTimeKind.Unspecified).AddTicks(6746), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Sleek Rubber Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 19, 3, 7, 3, 647, DateTimeKind.Unspecified).AddTicks(8259), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Practical Wooden Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 16, 18, 4, 52, 498, DateTimeKind.Unspecified).AddTicks(1299), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Handmade Fresh Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 26, 16, 45, 5, 504, DateTimeKind.Unspecified).AddTicks(8610), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Tasty Rubber Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 9, 17, 26, 50, 506, DateTimeKind.Unspecified).AddTicks(1613), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Gorgeous Granite Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 14, 5, 11, 53, 235, DateTimeKind.Unspecified).AddTicks(3689), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Rustic Frozen Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 25, 16, 4, 29, 331, DateTimeKind.Unspecified).AddTicks(3106), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Small Steel Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 2, 8, 40, 18, 653, DateTimeKind.Unspecified).AddTicks(3), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Fantastic Metal Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 5, 23, 16, 38, 41, DateTimeKind.Unspecified).AddTicks(7803), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Awesome Frozen Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 25, 5, 26, 0, 621, DateTimeKind.Unspecified).AddTicks(4389), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Tasty Frozen Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 25, 16, 27, 5, 989, DateTimeKind.Unspecified).AddTicks(9756), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Fantastic Cotton Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 4, 3, 28, 49, 803, DateTimeKind.Unspecified).AddTicks(4858), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Small Steel Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 22, 16, 36, 30, 156, DateTimeKind.Unspecified).AddTicks(165), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Sleek Wooden Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 26, 14, 57, 22, 980, DateTimeKind.Unspecified).AddTicks(640), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Handmade Steel Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 22, 7, 54, 0, 445, DateTimeKind.Unspecified).AddTicks(9398), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Incredible Fresh Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 5, 22, 44, 29, 82, DateTimeKind.Unspecified).AddTicks(2161), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Incredible Granite Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 8, 2, 17, 9, 646, DateTimeKind.Unspecified).AddTicks(5627), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Rustic Granite Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 28, 22, 37, 23, 424, DateTimeKind.Unspecified).AddTicks(1746), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Generic Frozen Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 16, 10, 13, 8, 340, DateTimeKind.Unspecified).AddTicks(9580), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Incredible Fresh Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 14, 15, 28, 21, 493, DateTimeKind.Unspecified).AddTicks(177), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Practical Cotton Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 31, 12, 35, 59, 71, DateTimeKind.Unspecified).AddTicks(5409), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Unbranded Cotton Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 14, 20, 7, 48, 311, DateTimeKind.Unspecified).AddTicks(3955), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Sleek Wooden Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 26, 19, 13, 30, 325, DateTimeKind.Unspecified).AddTicks(8065), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Sleek Cotton Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 7, 19, 31, 21, 875, DateTimeKind.Unspecified).AddTicks(4164), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Tasty Granite Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 9, 0, 23, 22, 733, DateTimeKind.Unspecified).AddTicks(8405), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Licensed Steel Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 23, 14, 29, 6, 515, DateTimeKind.Unspecified).AddTicks(9999), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Practical Steel Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 17, 9, 23, 6, 503, DateTimeKind.Unspecified).AddTicks(3260), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Tasty Plastic Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 28, 11, 45, 6, 962, DateTimeKind.Unspecified).AddTicks(29), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Handmade Frozen Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 5, 19, 26, 56, 914, DateTimeKind.Unspecified).AddTicks(2704), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Sleek Granite Gloves" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 13, 7, 33, 286, DateTimeKind.Unspecified).AddTicks(6144), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Tasty Plastic Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 10, 16, 35, 21, 728, DateTimeKind.Unspecified).AddTicks(2646), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Unbranded Plastic Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 5, 20, 20, 1, 567, DateTimeKind.Unspecified).AddTicks(9698), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Licensed Fresh Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 3, 9, 13, 6, 854, DateTimeKind.Unspecified).AddTicks(5565), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Sleek Cotton Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 9, 2, 16, 0, 357, DateTimeKind.Unspecified).AddTicks(9423), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Intelligent Wooden Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 1, 9, 10, 3, 533, DateTimeKind.Unspecified).AddTicks(6840), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Small Fresh Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 15, 15, 2, 45, 330, DateTimeKind.Unspecified).AddTicks(6794), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Gorgeous Soft Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 26, 18, 21, 39, 772, DateTimeKind.Unspecified).AddTicks(70), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Rustic Wooden Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 17, 23, 24, 32, 971, DateTimeKind.Unspecified).AddTicks(492), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Generic Soft Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 27, 13, 42, 45, 677, DateTimeKind.Unspecified).AddTicks(8533), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Unbranded Wooden Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 21, 3, 10, 33, 876, DateTimeKind.Unspecified).AddTicks(3780), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Ergonomic Concrete Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 0, 16, 22, 133, DateTimeKind.Unspecified).AddTicks(1444), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Refined Concrete Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 2, 7, 52, 58, 628, DateTimeKind.Unspecified).AddTicks(896), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Ergonomic Wooden Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 21, 22, 16, 15, 105, DateTimeKind.Unspecified).AddTicks(8875), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Small Rubber Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 17, 8, 27, 24, 121, DateTimeKind.Unspecified).AddTicks(6951), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Fantastic Granite Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 12, 0, 12, 1, 666, DateTimeKind.Unspecified).AddTicks(4420), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Practical Granite Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 30, 6, 46, 51, 883, DateTimeKind.Unspecified).AddTicks(4801), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Unbranded Steel Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 29, 6, 32, 14, 470, DateTimeKind.Unspecified).AddTicks(4556), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Small Plastic Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 8, 12, 0, 29, 888, DateTimeKind.Unspecified).AddTicks(1983), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Unbranded Steel Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 27, 15, 37, 0, 994, DateTimeKind.Unspecified).AddTicks(9678), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Practical Concrete Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 24, 18, 14, 46, 185, DateTimeKind.Unspecified).AddTicks(4350), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Incredible Cotton Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 11, 1, 33, 34, 771, DateTimeKind.Unspecified).AddTicks(4266), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Generic Cotton Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 12, 9, 42, 54, 6, DateTimeKind.Unspecified).AddTicks(4007), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Fantastic Steel Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 25, 23, 46, 8, 671, DateTimeKind.Unspecified).AddTicks(2840), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Small Metal Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 15, 8, 3, 14, 415, DateTimeKind.Unspecified).AddTicks(6973), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Handcrafted Fresh Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 0, 42, 52, 839, DateTimeKind.Unspecified).AddTicks(3430), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Incredible Rubber Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 24, 15, 36, 14, 954, DateTimeKind.Unspecified).AddTicks(7026), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Intelligent Concrete Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 12, 5, 33, 25, 376, DateTimeKind.Unspecified).AddTicks(6610), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Sleek Frozen Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 17, 17, 9, 2, 106, DateTimeKind.Unspecified).AddTicks(2829), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Awesome Fresh Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 13, 13, 23, 37, 422, DateTimeKind.Unspecified).AddTicks(2423), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Refined Granite Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 6, 10, 20, 58, 876, DateTimeKind.Unspecified).AddTicks(6880), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Handmade Metal Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 22, 23, 15, 22, 267, DateTimeKind.Unspecified).AddTicks(9004), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Sleek Concrete Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 6, 4, 59, 9, 484, DateTimeKind.Unspecified).AddTicks(4920), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Small Cotton Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 23, 10, 29, 1, 600, DateTimeKind.Unspecified).AddTicks(6440), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Intelligent Concrete Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 22, 9, 56, 51, 648, DateTimeKind.Unspecified).AddTicks(2467), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Ergonomic Fresh Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 29, 9, 59, 40, 234, DateTimeKind.Unspecified).AddTicks(7796), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Licensed Cotton Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 6, 17, 54, 34, 390, DateTimeKind.Unspecified).AddTicks(3577), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Refined Rubber Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 16, 12, 4, 13, 8, DateTimeKind.Unspecified).AddTicks(4125), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Awesome Wooden Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 13, 7, 37, 43, 806, DateTimeKind.Unspecified).AddTicks(3363), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Gorgeous Cotton Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 23, 21, 55, 44, 910, DateTimeKind.Unspecified).AddTicks(8295), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Rustic Metal Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 18, 10, 28, 484, DateTimeKind.Unspecified).AddTicks(5595), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Handcrafted Steel Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 12, 6, 22, 30, 937, DateTimeKind.Unspecified).AddTicks(8329), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Unbranded Plastic Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 3, 6, 18, 48, 129, DateTimeKind.Unspecified).AddTicks(1842), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Ergonomic Metal Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 5, 16, 0, 31, 646, DateTimeKind.Unspecified).AddTicks(9429), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Practical Granite Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 10, 39, 37, 302, DateTimeKind.Unspecified).AddTicks(1651), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Ergonomic Concrete Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 5, 6, 22, 48, 527, DateTimeKind.Unspecified).AddTicks(8401), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Generic Metal Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 23, 14, 26, 20, 679, DateTimeKind.Unspecified).AddTicks(4019), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Rustic Granite Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 5, 13, 59, 3, 708, DateTimeKind.Unspecified).AddTicks(347), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Handmade Frozen Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 27, 16, 59, 56, 573, DateTimeKind.Unspecified).AddTicks(8564), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Gorgeous Metal Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 14, 15, 7, 6, 640, DateTimeKind.Unspecified).AddTicks(4269), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Awesome Granite Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 25, 9, 8, 32, 392, DateTimeKind.Unspecified).AddTicks(8385), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Handcrafted Fresh Gloves" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 5, 8, 24, 40, 267, DateTimeKind.Unspecified).AddTicks(8664), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Fantastic Concrete Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 17, 4, 7, 47, 631, DateTimeKind.Unspecified).AddTicks(8444), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Intelligent Soft Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 8, 20, 17, 17, 399, DateTimeKind.Unspecified).AddTicks(352), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Generic Frozen Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 24, 22, 21, 12, 451, DateTimeKind.Unspecified).AddTicks(59), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Practical Cotton Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 20, 23, 3, 58, 417, DateTimeKind.Unspecified).AddTicks(8576), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Practical Plastic Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 8, 49, 27, 450, DateTimeKind.Unspecified).AddTicks(9894), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Rustic Fresh Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 14, 1, 15, 2, 573, DateTimeKind.Unspecified).AddTicks(4354), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Intelligent Wooden Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 23, 16, 6, 14, 860, DateTimeKind.Unspecified).AddTicks(4103), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Sleek Rubber Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 26, 16, 8, 1, 518, DateTimeKind.Unspecified).AddTicks(5726), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Practical Concrete Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 15, 5, 46, 58, 66, DateTimeKind.Unspecified).AddTicks(9626), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Generic Granite Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 28, 13, 58, 41, 520, DateTimeKind.Unspecified).AddTicks(4665), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Incredible Frozen Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 5, 22, 39, 58, 940, DateTimeKind.Unspecified).AddTicks(8930), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Ergonomic Concrete Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 29, 7, 34, 28, 121, DateTimeKind.Unspecified).AddTicks(7408), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Fantastic Granite Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 6, 6, 15, 4, 256, DateTimeKind.Unspecified).AddTicks(3288), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Practical Metal Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 1, 12, 54, 38, 381, DateTimeKind.Unspecified).AddTicks(8653), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Refined Wooden Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 11, 3, 31, 37, 690, DateTimeKind.Unspecified).AddTicks(7265), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Intelligent Rubber Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 19, 21, 36, 2, 130, DateTimeKind.Unspecified).AddTicks(387), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Generic Fresh Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 4, 21, 6, 39, 800, DateTimeKind.Unspecified).AddTicks(1078), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Gorgeous Plastic Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 9, 54, 40, 815, DateTimeKind.Unspecified).AddTicks(4821), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Gorgeous Cotton Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 21, 22, 54, 4, 440, DateTimeKind.Unspecified).AddTicks(9946), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Unbranded Soft Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 13, 8, 11, 33, 985, DateTimeKind.Unspecified).AddTicks(6694), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Tasty Fresh Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 15, 6, 9, 52, 914, DateTimeKind.Unspecified).AddTicks(9475), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Rustic Soft Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 20, 5, 19, 34, 737, DateTimeKind.Unspecified).AddTicks(5531), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Sleek Plastic Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 30, 21, 16, 11, 795, DateTimeKind.Unspecified).AddTicks(5571), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Awesome Metal Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 5, 18, 20, 52, 491, DateTimeKind.Unspecified).AddTicks(2335), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Rustic Frozen Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 22, 10, 40, 23, 88, DateTimeKind.Unspecified).AddTicks(4788), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Sleek Cotton Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 1, 18, 6, 51, 652, DateTimeKind.Unspecified).AddTicks(9453), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Practical Steel Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 18, 14, 10, 54, 546, DateTimeKind.Unspecified).AddTicks(5854), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Handmade Cotton Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 5, 12, 23, 24, 774, DateTimeKind.Unspecified).AddTicks(1633), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Awesome Frozen Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 1, 12, 20, 12, 761, DateTimeKind.Unspecified).AddTicks(8070), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Small Fresh Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 1, 7, 40, 38, 962, DateTimeKind.Unspecified).AddTicks(4171), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Gorgeous Metal Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 27, 3, 59, 5, 434, DateTimeKind.Unspecified).AddTicks(1133), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Small Plastic Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 10, 10, 6, 4, 210, DateTimeKind.Unspecified).AddTicks(1663), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Handcrafted Cotton Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 22, 4, 42, 29, 564, DateTimeKind.Unspecified).AddTicks(1055), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Practical Steel Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 20, 9, 12, 57, 998, DateTimeKind.Unspecified).AddTicks(4790), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Ergonomic Fresh Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 2, 18, 55, 7, 873, DateTimeKind.Unspecified).AddTicks(3670), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Intelligent Concrete Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 29, 19, 41, 49, 984, DateTimeKind.Unspecified).AddTicks(5424), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Generic Cotton Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 9, 20, 2, 28, 174, DateTimeKind.Unspecified).AddTicks(8497), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Licensed Steel Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 22, 9, 22, 36, 533, DateTimeKind.Unspecified).AddTicks(6233), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Practical Rubber Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 503,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 8, 23, 34, 20, 990, DateTimeKind.Unspecified).AddTicks(8735), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Rustic Rubber Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 504,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 12, 13, 35, 57, 535, DateTimeKind.Unspecified).AddTicks(659), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Tasty Steel Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 505,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 24, 16, 56, 0, 866, DateTimeKind.Unspecified).AddTicks(5852), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Fantastic Wooden Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 12, 22, 58, 37, 69, DateTimeKind.Unspecified).AddTicks(1277), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Refined Fresh Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 507,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 9, 18, 19, 31, 985, DateTimeKind.Unspecified).AddTicks(6955), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Incredible Rubber Gloves" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 5, 6, 19, 55, 478, DateTimeKind.Unspecified).AddTicks(6881), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Practical Plastic Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 509,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 23, 7, 26, 7, 91, DateTimeKind.Unspecified).AddTicks(9496), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Practical Wooden Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 510,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 3, 6, 10, 30, 30, DateTimeKind.Unspecified).AddTicks(550), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Generic Fresh Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 511,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 11, 10, 6, 7, 992, DateTimeKind.Unspecified).AddTicks(1615), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Awesome Wooden Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 512,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 4, 20, 0, 8, 83, DateTimeKind.Unspecified).AddTicks(728), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Handcrafted Soft Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 13, 23, 3, 12, 84, DateTimeKind.Unspecified).AddTicks(8158), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Awesome Soft Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 24, 14, 54, 20, 895, DateTimeKind.Unspecified).AddTicks(9982), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Sleek Plastic Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 515,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 11, 19, 20, 37, 817, DateTimeKind.Unspecified).AddTicks(9559), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Handcrafted Wooden Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 516,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 5, 10, 34, 27, 284, DateTimeKind.Unspecified).AddTicks(2126), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Gorgeous Frozen Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 517,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 22, 15, 31, 2, 725, DateTimeKind.Unspecified).AddTicks(8186), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Tasty Steel Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 518,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 3, 22, 34, 17, 781, DateTimeKind.Unspecified).AddTicks(1260), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Rustic Soft Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 21, 14, 0, 21, 776, DateTimeKind.Unspecified).AddTicks(3701), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Generic Granite Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 520,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 25, 13, 53, 45, 716, DateTimeKind.Unspecified).AddTicks(1162), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Handcrafted Plastic Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 521,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 1, 8, 10, 40, 650, DateTimeKind.Unspecified).AddTicks(7746), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Incredible Rubber Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 522,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 7, 10, 58, 19, 50, DateTimeKind.Unspecified).AddTicks(6175), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Practical Frozen Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 523,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 10, 18, 45, 2, 72, DateTimeKind.Unspecified).AddTicks(660), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Handmade Granite Gloves" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 524,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 24, 13, 16, 25, 701, DateTimeKind.Unspecified).AddTicks(5502), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Awesome Metal Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 525,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 11, 3, 28, 11, 339, DateTimeKind.Unspecified).AddTicks(2004), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Handmade Wooden Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 9, 5, 30, 7, 366, DateTimeKind.Unspecified).AddTicks(270), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Rustic Plastic Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 23, 8, 51, 3, 931, DateTimeKind.Unspecified).AddTicks(1743), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Unbranded Granite Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 528,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 1, 4, 3, 26, 455, DateTimeKind.Unspecified).AddTicks(1479), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Fantastic Frozen Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 3, 1, 2, 2, 661, DateTimeKind.Unspecified).AddTicks(9542), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Intelligent Fresh Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 4, 6, 58, 30, 778, DateTimeKind.Unspecified).AddTicks(9855), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Rustic Concrete Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 531,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 28, 23, 3, 17, 225, DateTimeKind.Unspecified).AddTicks(7253), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Small Granite Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 532,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 15, 16, 52, 25, 488, DateTimeKind.Unspecified).AddTicks(6747), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Intelligent Cotton Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 533,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 16, 10, 41, 10, 243, DateTimeKind.Unspecified).AddTicks(8), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Rustic Frozen Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 534,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 26, 2, 39, 0, 719, DateTimeKind.Unspecified).AddTicks(5565), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Gorgeous Rubber Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 535,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 10, 19, 30, 14, 218, DateTimeKind.Unspecified).AddTicks(887), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Generic Metal Gloves" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 536,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 29, 21, 2, 57, 40, DateTimeKind.Unspecified).AddTicks(4227), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Refined Metal Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 537,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 23, 5, 58, 10, 16, DateTimeKind.Unspecified).AddTicks(8084), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Unbranded Granite Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 538,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 1, 22, 0, 47, 573, DateTimeKind.Unspecified).AddTicks(4407), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Fantastic Metal Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 539,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 25, 9, 28, 1, 657, DateTimeKind.Unspecified).AddTicks(3478), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Tasty Granite Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 540,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 2, 6, 38, 30, 150, DateTimeKind.Unspecified).AddTicks(4539), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Gorgeous Cotton Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 541,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 9, 8, 50, 45, 849, DateTimeKind.Unspecified).AddTicks(4377), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Awesome Cotton Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 542,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 9, 10, 46, 26, 211, DateTimeKind.Unspecified).AddTicks(4340), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Incredible Concrete Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 543,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 11, 19, 54, 27, 268, DateTimeKind.Unspecified).AddTicks(6268), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Awesome Soft Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 544,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 29, 13, 59, 43, 766, DateTimeKind.Unspecified).AddTicks(1558), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Handcrafted Frozen Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 545,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 28, 20, 49, 26, 494, DateTimeKind.Unspecified).AddTicks(3863), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Awesome Rubber Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 546,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 27, 13, 51, 38, 718, DateTimeKind.Unspecified).AddTicks(4948), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Ergonomic Rubber Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 547,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 29, 10, 19, 48, 505, DateTimeKind.Unspecified).AddTicks(721), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Sleek Concrete Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 548,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 10, 16, 56, 58, 793, DateTimeKind.Unspecified).AddTicks(8108), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Practical Steel Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 549,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 11, 22, 12, 48, 209, DateTimeKind.Unspecified).AddTicks(1219), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Intelligent Steel Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 550,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 10, 7, 42, 43, 797, DateTimeKind.Unspecified).AddTicks(7086), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Intelligent Cotton Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 551,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 27, 22, 47, 23, 499, DateTimeKind.Unspecified).AddTicks(8579), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Gorgeous Plastic Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 552,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 8, 15, 53, 610, DateTimeKind.Unspecified).AddTicks(5739), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Tasty Frozen Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 553,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 22, 7, 33, 56, 723, DateTimeKind.Unspecified).AddTicks(4399), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Licensed Concrete Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 554,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 27, 1, 58, 39, 971, DateTimeKind.Unspecified).AddTicks(1085), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Gorgeous Soft Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 555,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 11, 1, 5, 36, 279, DateTimeKind.Unspecified).AddTicks(9064), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Awesome Rubber Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 556,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 17, 21, 25, 54, 705, DateTimeKind.Unspecified).AddTicks(8939), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Awesome Plastic Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 557,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 8, 17, 36, 42, 464, DateTimeKind.Unspecified).AddTicks(5681), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Handmade Plastic Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 23, 18, 52, 36, 322, DateTimeKind.Unspecified).AddTicks(4689), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Intelligent Wooden Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 559,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 31, 8, 44, 4, 567, DateTimeKind.Unspecified).AddTicks(3252), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Awesome Granite Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 560,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 12, 1, 15, 21, 702, DateTimeKind.Unspecified).AddTicks(4405), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Tasty Frozen Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 11, 8, 15, 6, 475, DateTimeKind.Unspecified).AddTicks(4041), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Practical Cotton Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 562,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 27, 22, 31, 59, 239, DateTimeKind.Unspecified).AddTicks(2099), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Generic Concrete Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 563,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 19, 21, 8, 1, 283, DateTimeKind.Unspecified).AddTicks(2305), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Generic Plastic Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 564,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 8, 10, 52, 1, 492, DateTimeKind.Unspecified).AddTicks(4962), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Practical Steel Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 29, 9, 1, 51, 606, DateTimeKind.Unspecified).AddTicks(4787), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Intelligent Wooden Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 566,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 3, 21, 59, 33, 418, DateTimeKind.Unspecified).AddTicks(3812), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Small Concrete Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 567,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 22, 0, 14, 3, 260, DateTimeKind.Unspecified).AddTicks(9142), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Generic Fresh Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 568,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 18, 17, 46, 30, 176, DateTimeKind.Unspecified).AddTicks(2871), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Incredible Rubber Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 569,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 12, 2, 52, 36, 947, DateTimeKind.Unspecified).AddTicks(7589), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Unbranded Fresh Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 570,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 8, 15, 54, 19, 14, DateTimeKind.Unspecified).AddTicks(11), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Intelligent Fresh Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 571,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 22, 3, 52, 39, 766, DateTimeKind.Unspecified).AddTicks(9232), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Unbranded Metal Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 572,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 25, 23, 16, 33, 850, DateTimeKind.Unspecified).AddTicks(509), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Incredible Wooden Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 573,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 21, 22, 22, 5, 516, DateTimeKind.Unspecified).AddTicks(168), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Practical Steel Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 574,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 19, 3, 13, 6, 535, DateTimeKind.Unspecified).AddTicks(7793), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Licensed Metal Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 575,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 19, 15, 26, 36, 80, DateTimeKind.Unspecified).AddTicks(4734), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Refined Frozen Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 576,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 21, 8, 44, 18, 3, DateTimeKind.Unspecified).AddTicks(5428), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Incredible Metal Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 577,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 27, 23, 52, 2, 521, DateTimeKind.Unspecified).AddTicks(3866), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Rustic Cotton Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 578,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 4, 1, 50, 48, 897, DateTimeKind.Unspecified).AddTicks(6224), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Tasty Cotton Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 579,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 13, 9, 32, 41, 537, DateTimeKind.Unspecified).AddTicks(4231), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Rustic Soft Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 580,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 17, 20, 31, 53, 983, DateTimeKind.Unspecified).AddTicks(4180), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Unbranded Fresh Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 581,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 22, 15, 6, 111, DateTimeKind.Unspecified).AddTicks(7737), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Sleek Granite Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 3, 6, 2, 51, 171, DateTimeKind.Unspecified).AddTicks(5902), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Small Frozen Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 583,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 25, 12, 44, 32, 432, DateTimeKind.Unspecified).AddTicks(5868), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Generic Rubber Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 584,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 21, 17, 46, 18, 298, DateTimeKind.Unspecified).AddTicks(5402), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Small Steel Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 9, 10, 36, 33, 984, DateTimeKind.Unspecified).AddTicks(2698), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Fantastic Plastic Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 9, 20, 22, 25, 269, DateTimeKind.Unspecified).AddTicks(7855), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Ergonomic Cotton Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 4, 18, 10, 46, 86, DateTimeKind.Unspecified).AddTicks(1136), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Practical Plastic Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 30, 8, 19, 32, 663, DateTimeKind.Unspecified).AddTicks(2986), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Generic Concrete Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 24, 13, 53, 50, 905, DateTimeKind.Unspecified).AddTicks(6274), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Tasty Frozen Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 30, 14, 6, 36, 489, DateTimeKind.Unspecified).AddTicks(6466), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Awesome Steel Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 11, 13, 41, 35, 714, DateTimeKind.Unspecified).AddTicks(6842), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Refined Steel Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 592,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 28, 5, 8, 45, 817, DateTimeKind.Unspecified).AddTicks(3952), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Rustic Frozen Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 2, 17, 28, 57, 173, DateTimeKind.Unspecified).AddTicks(6296), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Generic Metal Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 26, 18, 22, 9, 382, DateTimeKind.Unspecified).AddTicks(8301), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Gorgeous Granite Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 595,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 23, 14, 11, 54, 900, DateTimeKind.Unspecified).AddTicks(3920), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Licensed Frozen Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 596,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 3, 0, 26, 15, 953, DateTimeKind.Unspecified).AddTicks(2188), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Practical Cotton Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 597,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 18, 23, 10, 1, 780, DateTimeKind.Unspecified).AddTicks(1596), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Small Plastic Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 598,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 15, 12, 13, 32, 380, DateTimeKind.Unspecified).AddTicks(5144), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Practical Metal Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 599,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 1, 13, 37, 43, 46, DateTimeKind.Unspecified).AddTicks(5838), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Handcrafted Wooden Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 600,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 2, 8, 16, 57, 707, DateTimeKind.Unspecified).AddTicks(5910), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Incredible Frozen Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 601,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 27, 21, 40, 11, 971, DateTimeKind.Unspecified).AddTicks(6126), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Small Cotton Gloves" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 602,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 7, 21, 20, 24, 933, DateTimeKind.Unspecified).AddTicks(2709), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Refined Frozen Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 603,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 9, 19, 54, 57, 118, DateTimeKind.Unspecified).AddTicks(6761), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Handcrafted Steel Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 604,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 10, 8, 59, 32, 504, DateTimeKind.Unspecified).AddTicks(3967), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Incredible Soft Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 605,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 25, 7, 0, 32, 742, DateTimeKind.Unspecified).AddTicks(5565), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Generic Cotton Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 606,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 7, 19, 3, 20, 130, DateTimeKind.Unspecified).AddTicks(4839), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Handcrafted Fresh Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 607,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 10, 15, 45, 26, 959, DateTimeKind.Unspecified).AddTicks(5944), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Practical Wooden Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 608,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 24, 7, 47, 39, 732, DateTimeKind.Unspecified).AddTicks(8568), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Handcrafted Frozen Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 609,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 27, 19, 20, 46, 935, DateTimeKind.Unspecified).AddTicks(1062), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Practical Granite Gloves" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 610,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 19, 1, 12, 4, 998, DateTimeKind.Unspecified).AddTicks(2569), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Generic Wooden Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 611,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 17, 4, 33, 4, 337, DateTimeKind.Unspecified).AddTicks(8409), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Sleek Soft Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 612,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 26, 4, 50, 13, 21, DateTimeKind.Unspecified).AddTicks(3384), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Generic Wooden Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 613,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 22, 17, 16, 57, 399, DateTimeKind.Unspecified).AddTicks(9433), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Small Granite Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 614,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 6, 2, 33, 44, 51, DateTimeKind.Unspecified).AddTicks(668), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Generic Concrete Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 615,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 26, 1, 28, 39, 257, DateTimeKind.Unspecified).AddTicks(6401), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Fantastic Soft Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 616,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 6, 23, 51, 0, 263, DateTimeKind.Unspecified).AddTicks(9089), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Ergonomic Wooden Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 617,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 25, 20, 12, 33, 860, DateTimeKind.Unspecified).AddTicks(4402), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Awesome Frozen Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 618,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 31, 15, 1, 25, 414, DateTimeKind.Unspecified).AddTicks(2751), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Handcrafted Concrete Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 619,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 1, 21, 19, 40, 666, DateTimeKind.Unspecified).AddTicks(4017), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Awesome Fresh Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 620,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 27, 20, 29, 8, 50, DateTimeKind.Unspecified).AddTicks(5018), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Tasty Plastic Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 621,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 3, 20, 42, 15, 883, DateTimeKind.Unspecified).AddTicks(7666), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Fantastic Cotton Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 622,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 12, 4, 49, 39, 779, DateTimeKind.Unspecified).AddTicks(725), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Handmade Metal Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 623,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 25, 15, 59, 21, 870, DateTimeKind.Unspecified).AddTicks(5762), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Practical Steel Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 624,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 18, 7, 18, 5, 354, DateTimeKind.Unspecified).AddTicks(8721), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Ergonomic Plastic Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 625,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 8, 11, 18, 59, 982, DateTimeKind.Unspecified).AddTicks(9739), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Fantastic Concrete Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 626,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 23, 4, 2, 1, 72, DateTimeKind.Unspecified).AddTicks(1066), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Sleek Steel Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 627,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 26, 22, 11, 2, 235, DateTimeKind.Unspecified).AddTicks(7678), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Refined Granite Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 628,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 29, 6, 52, 1, 641, DateTimeKind.Unspecified).AddTicks(7679), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Rustic Fresh Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 629,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 29, 17, 8, 38, 721, DateTimeKind.Unspecified).AddTicks(6582), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Small Rubber Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 630,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 1, 20, 45, 17, 583, DateTimeKind.Unspecified).AddTicks(3645), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Sleek Plastic Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 631,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 12, 13, 8, 40, 499, DateTimeKind.Unspecified).AddTicks(4062), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Handmade Metal Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 632,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 7, 21, 3, 26, 726, DateTimeKind.Unspecified).AddTicks(4818), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Rustic Fresh Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 633,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 5, 19, 26, 3, 915, DateTimeKind.Unspecified).AddTicks(7648), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Handcrafted Metal Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 634,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 10, 2, 14, 20, 237, DateTimeKind.Unspecified).AddTicks(2220), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Tasty Cotton Gloves" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 635,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 28, 22, 43, 45, 546, DateTimeKind.Unspecified).AddTicks(209), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Intelligent Fresh Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 636,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 27, 4, 33, 2, 682, DateTimeKind.Unspecified).AddTicks(4888), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Handmade Plastic Gloves" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 637,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 21, 9, 17, 6, 12, DateTimeKind.Unspecified).AddTicks(8651), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Rustic Plastic Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 638,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 4, 13, 39, 48, 979, DateTimeKind.Unspecified).AddTicks(3548), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Intelligent Steel Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 639,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 24, 1, 49, 1, 963, DateTimeKind.Unspecified).AddTicks(2999), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Incredible Soft Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 640,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 24, 1, 40, 23, 149, DateTimeKind.Unspecified).AddTicks(1755), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Fantastic Wooden Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 641,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 31, 16, 28, 7, 990, DateTimeKind.Unspecified).AddTicks(7658), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Ergonomic Steel Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 642,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 5, 18, 50, 15, 793, DateTimeKind.Unspecified).AddTicks(7602), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Licensed Metal Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 643,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 11, 14, 20, 35, 272, DateTimeKind.Unspecified).AddTicks(5848), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Refined Rubber Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 644,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 12, 8, 56, 22, 535, DateTimeKind.Unspecified).AddTicks(9239), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Fantastic Wooden Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 645,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 15, 8, 7, 44, 987, DateTimeKind.Unspecified).AddTicks(4747), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Unbranded Concrete Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 646,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 13, 10, 51, 46, 207, DateTimeKind.Unspecified).AddTicks(8075), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Practical Plastic Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 647,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 1, 6, 44, 36, 917, DateTimeKind.Unspecified).AddTicks(4448), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Generic Metal Gloves" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 648,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 24, 6, 4, 22, 520, DateTimeKind.Unspecified).AddTicks(2398), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Rustic Soft Gloves" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 649,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 16, 10, 4, 31, 590, DateTimeKind.Unspecified).AddTicks(5922), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Sleek Frozen Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 650,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 10, 4, 49, 45, 987, DateTimeKind.Unspecified).AddTicks(2867), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Handmade Steel Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 651,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 28, 23, 51, 9, 966, DateTimeKind.Unspecified).AddTicks(8537), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Intelligent Rubber Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 652,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 17, 0, 29, 48, 485, DateTimeKind.Unspecified).AddTicks(8018), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Refined Wooden Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 653,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 15, 5, 0, 51, 518, DateTimeKind.Unspecified).AddTicks(3382), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Sleek Steel Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 654,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 4, 22, 34, 17, 940, DateTimeKind.Unspecified).AddTicks(5699), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Intelligent Concrete Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 655,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 11, 22, 42, 11, 447, DateTimeKind.Unspecified).AddTicks(3158), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Handcrafted Fresh Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 656,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 28, 18, 3, 28, 356, DateTimeKind.Unspecified).AddTicks(7637), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Small Cotton Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 657,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 23, 2, 13, 25, 190, DateTimeKind.Unspecified).AddTicks(5280), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Practical Steel Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 658,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 16, 20, 25, 49, 100, DateTimeKind.Unspecified).AddTicks(5448), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Small Concrete Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 659,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 11, 7, 23, 19, 426, DateTimeKind.Unspecified).AddTicks(8360), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Tasty Soft Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 660,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 18, 10, 33, 20, 867, DateTimeKind.Unspecified).AddTicks(9967), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Practical Steel Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 661,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 16, 9, 43, 15, 313, DateTimeKind.Unspecified).AddTicks(6277), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Sleek Concrete Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 662,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 1, 6, 59, 43, 805, DateTimeKind.Unspecified).AddTicks(5457), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Fantastic Concrete Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 663,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 1, 16, 36, 16, 34, DateTimeKind.Unspecified).AddTicks(1861), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Practical Soft Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 664,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 18, 23, 33, 13, 747, DateTimeKind.Unspecified).AddTicks(3839), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Practical Plastic Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 665,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 5, 7, 47, 9, 321, DateTimeKind.Unspecified).AddTicks(8368), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Tasty Frozen Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 666,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 14, 1, 4, 9, 750, DateTimeKind.Unspecified).AddTicks(9853), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Refined Metal Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 667,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 25, 0, 5, 34, 33, DateTimeKind.Unspecified).AddTicks(9839), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Tasty Plastic Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 668,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 25, 3, 34, 9, 723, DateTimeKind.Unspecified).AddTicks(1347), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Intelligent Metal Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 669,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 9, 18, 43, 21, 743, DateTimeKind.Unspecified).AddTicks(3404), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Handmade Fresh Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 670,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 8, 13, 4, 23, 275, DateTimeKind.Unspecified).AddTicks(519), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Intelligent Rubber Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 671,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 25, 7, 33, 21, 299, DateTimeKind.Unspecified).AddTicks(8139), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Rustic Metal Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 672,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 10, 5, 56, 33, 0, DateTimeKind.Unspecified).AddTicks(5171), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Awesome Fresh Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 673,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 20, 19, 55, 0, 693, DateTimeKind.Unspecified).AddTicks(6315), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Handcrafted Granite Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 674,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 20, 5, 52, 24, 820, DateTimeKind.Unspecified).AddTicks(9740), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Rustic Plastic Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 675,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 7, 17, 32, 49, 53, DateTimeKind.Unspecified).AddTicks(8445), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Licensed Granite Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 676,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 22, 12, 28, 26, 386, DateTimeKind.Unspecified).AddTicks(9311), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Ergonomic Concrete Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 677,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 24, 16, 16, 24, 568, DateTimeKind.Unspecified).AddTicks(6706), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Intelligent Granite Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 678,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 29, 8, 16, 54, 625, DateTimeKind.Unspecified).AddTicks(5719), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Incredible Granite Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 679,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 1, 5, 0, 51, 425, DateTimeKind.Unspecified).AddTicks(7617), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Incredible Rubber Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 680,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 27, 21, 41, 47, 248, DateTimeKind.Unspecified).AddTicks(4244), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Intelligent Metal Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 681,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 20, 18, 19, 21, 399, DateTimeKind.Unspecified).AddTicks(6334), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Unbranded Metal Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 682,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 1, 20, 1, 8, 543, DateTimeKind.Unspecified).AddTicks(7789), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Generic Soft Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 683,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 27, 7, 45, 11, 973, DateTimeKind.Unspecified).AddTicks(8513), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Incredible Cotton Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 684,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 23, 23, 21, 22, 69, DateTimeKind.Unspecified).AddTicks(7309), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Intelligent Cotton Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 685,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 14, 5, 56, 283, DateTimeKind.Unspecified).AddTicks(7090), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Generic Granite Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 686,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 22, 4, 2, 56, 23, DateTimeKind.Unspecified).AddTicks(5688), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Rustic Plastic Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 687,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 1, 48, 16, 967, DateTimeKind.Unspecified).AddTicks(2052), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Practical Steel Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 688,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 13, 1, 7, 13, 102, DateTimeKind.Unspecified).AddTicks(2339), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Awesome Plastic Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 689,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 7, 12, 0, 208, DateTimeKind.Unspecified).AddTicks(1903), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Sleek Steel Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 690,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 23, 1, 13, 17, 952, DateTimeKind.Unspecified).AddTicks(9608), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Unbranded Metal Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 691,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 28, 13, 25, 2, 718, DateTimeKind.Unspecified).AddTicks(9030), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Licensed Cotton Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 692,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 30, 8, 30, 32, 827, DateTimeKind.Unspecified).AddTicks(1291), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Practical Concrete Gloves" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 693,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 4, 5, 14, 30, 0, DateTimeKind.Unspecified).AddTicks(2801), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Fantastic Steel Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 694,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 16, 10, 54, 54, 159, DateTimeKind.Unspecified).AddTicks(2323), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Gorgeous Plastic Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 695,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 19, 19, 30, 19, 469, DateTimeKind.Unspecified).AddTicks(761), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Unbranded Concrete Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 696,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 12, 8, 2, 35, 306, DateTimeKind.Unspecified).AddTicks(8770), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Awesome Rubber Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 697,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 0, 43, 29, 221, DateTimeKind.Unspecified).AddTicks(1212), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Sleek Soft Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 698,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 18, 23, 19, 26, 7, DateTimeKind.Unspecified).AddTicks(4354), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Tasty Cotton Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 699,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 1, 20, 26, 53, 311, DateTimeKind.Unspecified).AddTicks(8240), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Fantastic Frozen Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 700,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 20, 6, 7, 48, 577, DateTimeKind.Unspecified).AddTicks(7422), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Sleek Rubber Gloves" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 2, 6, 33, 38, 959, DateTimeKind.Unspecified).AddTicks(7178), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Awesome Steel Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 13, 1, 37, 20, 235, DateTimeKind.Unspecified).AddTicks(2611), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Generic Rubber Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 703,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 28, 3, 42, 26, 532, DateTimeKind.Unspecified).AddTicks(5505), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Licensed Metal Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 704,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 22, 5, 3, 1, 537, DateTimeKind.Unspecified).AddTicks(3071), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Generic Granite Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 705,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 13, 0, 23, 9, 182, DateTimeKind.Unspecified).AddTicks(1538), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Refined Plastic Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 706,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 27, 13, 19, 1, 522, DateTimeKind.Unspecified).AddTicks(9944), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Unbranded Plastic Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 707,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 10, 14, 46, 9, 528, DateTimeKind.Unspecified).AddTicks(2749), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Tasty Plastic Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 708,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 3, 11, 13, 34, 368, DateTimeKind.Unspecified).AddTicks(8075), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Practical Frozen Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 709,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 16, 12, 39, 26, 511, DateTimeKind.Unspecified).AddTicks(9768), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Fantastic Wooden Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 710,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 18, 9, 54, 17, 528, DateTimeKind.Unspecified).AddTicks(9458), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Generic Rubber Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 711,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 28, 10, 2, 20, 680, DateTimeKind.Unspecified).AddTicks(7007), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Tasty Soft Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 712,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 20, 14, 4, 31, 475, DateTimeKind.Unspecified).AddTicks(8809), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Intelligent Concrete Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 713,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 19, 3, 57, 15, 429, DateTimeKind.Unspecified).AddTicks(6003), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Gorgeous Fresh Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 714,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 4, 14, 54, 190, DateTimeKind.Unspecified).AddTicks(9472), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Sleek Steel Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 715,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 16, 22, 43, 46, 90, DateTimeKind.Unspecified).AddTicks(8178), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Handcrafted Metal Gloves" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 716,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 7, 17, 33, 5, 824, DateTimeKind.Unspecified).AddTicks(2222), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Licensed Soft Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 717,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 15, 20, 0, 1, 985, DateTimeKind.Unspecified).AddTicks(572), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Incredible Concrete Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 718,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 24, 17, 32, 7, 269, DateTimeKind.Unspecified).AddTicks(2793), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Intelligent Frozen Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 719,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 12, 2, 20, 32, 62, DateTimeKind.Unspecified).AddTicks(9663), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Intelligent Wooden Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 720,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 5, 20, 42, 43, 521, DateTimeKind.Unspecified).AddTicks(1947), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Awesome Concrete Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 721,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 5, 23, 35, 489, DateTimeKind.Unspecified).AddTicks(2548), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Awesome Cotton Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 722,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 23, 9, 42, 27, 511, DateTimeKind.Unspecified).AddTicks(8753), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Gorgeous Granite Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 723,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 24, 3, 31, 59, 697, DateTimeKind.Unspecified).AddTicks(9699), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Practical Metal Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 724,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 10, 13, 59, 29, 532, DateTimeKind.Unspecified).AddTicks(6784), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Ergonomic Concrete Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 725,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 18, 16, 33, 7, 458, DateTimeKind.Unspecified).AddTicks(5039), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Generic Wooden Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 726,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 25, 5, 45, 40, 837, DateTimeKind.Unspecified).AddTicks(6088), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Awesome Cotton Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 727,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 4, 2, 14, 2, 22, DateTimeKind.Unspecified).AddTicks(8770), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Sleek Cotton Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 728,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 13, 21, 21, 25, 571, DateTimeKind.Unspecified).AddTicks(8477), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Unbranded Fresh Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 729,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 14, 23, 32, 18, 65, DateTimeKind.Unspecified).AddTicks(7708), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Handcrafted Cotton Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 730,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 18, 7, 12, 22, 467, DateTimeKind.Unspecified).AddTicks(919), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Sleek Metal Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 731,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 2, 12, 12, 4, 890, DateTimeKind.Unspecified).AddTicks(3432), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Fantastic Rubber Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 732,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 26, 14, 59, 48, 325, DateTimeKind.Unspecified).AddTicks(1216), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Fantastic Metal Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 733,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 10, 0, 31, 56, 802, DateTimeKind.Unspecified).AddTicks(5873), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Refined Concrete Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 734,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 16, 22, 32, 46, 411, DateTimeKind.Unspecified).AddTicks(4344), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Small Granite Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 735,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 14, 9, 56, 10, 414, DateTimeKind.Unspecified).AddTicks(1915), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Intelligent Plastic Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 736,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 22, 18, 45, 17, 737, DateTimeKind.Unspecified).AddTicks(2797), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Rustic Wooden Gloves" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 737,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 24, 1, 22, 10, 662, DateTimeKind.Unspecified).AddTicks(7652), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Unbranded Plastic Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 738,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 10, 18, 53, 23, 334, DateTimeKind.Unspecified).AddTicks(828), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Unbranded Fresh Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 739,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 4, 4, 38, 38, 780, DateTimeKind.Unspecified).AddTicks(8068), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Gorgeous Cotton Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 740,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 3, 17, 50, 51, 145, DateTimeKind.Unspecified).AddTicks(1392), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Practical Wooden Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 741,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 5, 46, 35, 783, DateTimeKind.Unspecified).AddTicks(5590), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Small Concrete Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 742,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 13, 13, 40, 6, 920, DateTimeKind.Unspecified).AddTicks(7582), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Small Granite Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 743,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 6, 21, 34, 22, 53, DateTimeKind.Unspecified).AddTicks(6553), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Gorgeous Plastic Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 744,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 6, 11, 52, 15, 491, DateTimeKind.Unspecified).AddTicks(7246), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Sleek Steel Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 745,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 27, 23, 46, 52, 309, DateTimeKind.Unspecified).AddTicks(9530), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Intelligent Steel Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 746,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 18, 3, 47, 21, 106, DateTimeKind.Unspecified).AddTicks(8933), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Handmade Frozen Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 747,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 12, 20, 0, 20, 745, DateTimeKind.Unspecified).AddTicks(6072), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Tasty Fresh Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 748,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 28, 23, 31, 13, 968, DateTimeKind.Unspecified).AddTicks(7134), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Generic Plastic Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 749,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 11, 9, 7, 56, 841, DateTimeKind.Unspecified).AddTicks(5125), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Practical Concrete Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 750,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 15, 8, 16, 24, 66, DateTimeKind.Unspecified).AddTicks(112), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Unbranded Granite Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 751,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 21, 6, 39, 13, 441, DateTimeKind.Unspecified).AddTicks(2270), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Practical Cotton Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 752,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 28, 18, 33, 4, 984, DateTimeKind.Unspecified).AddTicks(3438), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Tasty Concrete Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 753,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 9, 6, 23, 42, 296, DateTimeKind.Unspecified).AddTicks(8907), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Small Frozen Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 754,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 2, 1, 17, 24, 55, DateTimeKind.Unspecified).AddTicks(5085), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Fantastic Fresh Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 755,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 13, 20, 53, 54, 236, DateTimeKind.Unspecified).AddTicks(4868), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Rustic Rubber Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 756,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 8, 14, 30, 8, 483, DateTimeKind.Unspecified).AddTicks(5576), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Unbranded Rubber Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 757,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 26, 5, 4, 0, 108, DateTimeKind.Unspecified).AddTicks(6249), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Intelligent Cotton Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 758,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 5, 13, 43, 26, 985, DateTimeKind.Unspecified).AddTicks(4144), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Generic Granite Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 759,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 2, 3, 37, 15, 216, DateTimeKind.Unspecified).AddTicks(7173), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Fantastic Frozen Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 760,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 11, 17, 13, 10, 318, DateTimeKind.Unspecified).AddTicks(9379), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Sleek Cotton Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 761,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 15, 14, 49, 37, 815, DateTimeKind.Unspecified).AddTicks(2965), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Small Soft Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 762,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 10, 11, 9, 44, 22, DateTimeKind.Unspecified).AddTicks(4808), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Licensed Metal Gloves" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 763,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 4, 2, 16, 47, 745, DateTimeKind.Unspecified).AddTicks(2532), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Fantastic Wooden Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 764,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 14, 6, 26, 37, 619, DateTimeKind.Unspecified).AddTicks(2148), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Generic Soft Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 765,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 12, 22, 40, 38, 184, DateTimeKind.Unspecified).AddTicks(5345), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Unbranded Metal Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 766,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 13, 0, 51, 39, 87, DateTimeKind.Unspecified).AddTicks(2634), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Intelligent Concrete Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 767,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 1, 23, 17, 19, 616, DateTimeKind.Unspecified).AddTicks(469), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Sleek Granite Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 768,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 6, 13, 30, 14, 970, DateTimeKind.Unspecified).AddTicks(8808), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Practical Steel Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 769,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 29, 6, 54, 51, 328, DateTimeKind.Unspecified).AddTicks(332), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Tasty Wooden Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 770,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 16, 3, 0, 47, 189, DateTimeKind.Unspecified).AddTicks(5981), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Incredible Frozen Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 771,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 20, 11, 56, 1, 567, DateTimeKind.Unspecified).AddTicks(4649), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Handmade Metal Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 772,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 12, 19, 25, 7, 16, DateTimeKind.Unspecified).AddTicks(1740), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Fantastic Frozen Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 773,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 7, 6, 11, 55, 311, DateTimeKind.Unspecified).AddTicks(1455), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Generic Concrete Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 774,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 25, 15, 21, 55, 300, DateTimeKind.Unspecified).AddTicks(7852), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Refined Cotton Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 775,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 13, 2, 7, 57, 620, DateTimeKind.Unspecified).AddTicks(6691), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Generic Granite Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 776,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 18, 8, 12, 17, 847, DateTimeKind.Unspecified).AddTicks(288), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Handmade Rubber Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 777,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 20, 10, 45, 9, 433, DateTimeKind.Unspecified).AddTicks(9787), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Gorgeous Metal Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 778,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 15, 7, 24, 48, 493, DateTimeKind.Unspecified).AddTicks(2610), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Licensed Frozen Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 779,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 21, 10, 31, 29, 988, DateTimeKind.Unspecified).AddTicks(8555), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Practical Steel Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 780,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 19, 7, 37, 31, 907, DateTimeKind.Unspecified).AddTicks(3060), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Handmade Concrete Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 781,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 4, 16, 13, 10, 246, DateTimeKind.Unspecified).AddTicks(1277), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Unbranded Concrete Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 782,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 10, 22, 18, 44, 446, DateTimeKind.Unspecified).AddTicks(8196), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Intelligent Rubber Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 783,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 27, 11, 48, 32, 414, DateTimeKind.Unspecified).AddTicks(3185), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Licensed Fresh Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 784,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 30, 23, 11, 9, 17, DateTimeKind.Unspecified).AddTicks(2522), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Unbranded Granite Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 785,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 26, 10, 27, 39, 2, DateTimeKind.Unspecified).AddTicks(9025), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Refined Wooden Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 786,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 24, 22, 44, 0, 182, DateTimeKind.Unspecified).AddTicks(3125), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Awesome Wooden Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 787,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 9, 7, 8, 23, 704, DateTimeKind.Unspecified).AddTicks(8383), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Sleek Fresh Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 788,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 29, 17, 16, 33, 950, DateTimeKind.Unspecified).AddTicks(5835), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Tasty Plastic Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 789,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 10, 15, 11, 41, 766, DateTimeKind.Unspecified).AddTicks(5952), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Intelligent Soft Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 790,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 29, 7, 59, 17, 717, DateTimeKind.Unspecified).AddTicks(8863), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Awesome Steel Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 791,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 29, 11, 8, 10, 10, DateTimeKind.Unspecified).AddTicks(9610), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Gorgeous Cotton Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 792,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 4, 20, 28, 5, 335, DateTimeKind.Unspecified).AddTicks(6136), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Handmade Frozen Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 793,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 31, 5, 16, 33, 658, DateTimeKind.Unspecified).AddTicks(6317), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Ergonomic Fresh Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 794,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 9, 22, 26, 18, 194, DateTimeKind.Unspecified).AddTicks(6303), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Tasty Metal Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 795,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 12, 6, 33, 58, 323, DateTimeKind.Unspecified).AddTicks(3223), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Generic Cotton Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 796,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 12, 6, 33, 26, 298, DateTimeKind.Unspecified).AddTicks(5513), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Ergonomic Granite Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 797,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 1, 7, 26, 28, 588, DateTimeKind.Unspecified).AddTicks(712), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Sleek Metal Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 798,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 13, 12, 21, 6, 56, DateTimeKind.Unspecified).AddTicks(1468), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Rustic Granite Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 799,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 10, 7, 24, 52, 410, DateTimeKind.Unspecified).AddTicks(5200), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Small Plastic Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 800,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 16, 8, 23, 10, 865, DateTimeKind.Unspecified).AddTicks(7361), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Fantastic Plastic Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 27, 16, 8, 59, 357, DateTimeKind.Unspecified).AddTicks(4059), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Refined Soft Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 29, 1, 41, 55, 109, DateTimeKind.Unspecified).AddTicks(7309), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Licensed Wooden Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 803,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 27, 8, 1, 42, 669, DateTimeKind.Unspecified).AddTicks(8662), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Intelligent Granite Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 804,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 15, 1, 51, 57, 556, DateTimeKind.Unspecified).AddTicks(8356), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Fantastic Plastic Gloves" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 805,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 11, 5, 44, 30, 413, DateTimeKind.Unspecified).AddTicks(7702), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Practical Granite Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 806,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 4, 1, 38, 0, 868, DateTimeKind.Unspecified).AddTicks(1930), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Incredible Plastic Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 807,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 20, 2, 2, 5, 418, DateTimeKind.Unspecified).AddTicks(5157), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Licensed Concrete Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 808,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 16, 21, 15, 36, 223, DateTimeKind.Unspecified).AddTicks(9536), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Handmade Granite Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 809,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 25, 21, 25, 47, 214, DateTimeKind.Unspecified).AddTicks(8060), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Tasty Frozen Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 810,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 26, 19, 28, 37, 839, DateTimeKind.Unspecified).AddTicks(6937), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Sleek Frozen Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 811,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 13, 10, 40, 22, 564, DateTimeKind.Unspecified).AddTicks(6836), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Small Frozen Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 812,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 16, 3, 29, 56, 257, DateTimeKind.Unspecified).AddTicks(6818), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Incredible Rubber Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 813,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 14, 5, 15, 54, 868, DateTimeKind.Unspecified).AddTicks(4981), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Practical Rubber Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 814,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 22, 17, 50, 9, 815, DateTimeKind.Unspecified).AddTicks(8924), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Tasty Plastic Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 815,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 16, 16, 16, 27, 901, DateTimeKind.Unspecified).AddTicks(5433), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Unbranded Steel Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 816,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 26, 1, 5, 12, 553, DateTimeKind.Unspecified).AddTicks(3403), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Practical Granite Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 817,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 12, 13, 58, 26, 332, DateTimeKind.Unspecified).AddTicks(6993), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Practical Wooden Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 818,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 6, 14, 43, 36, 360, DateTimeKind.Unspecified).AddTicks(1658), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Licensed Cotton Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 819,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 8, 19, 47, 27, 575, DateTimeKind.Unspecified).AddTicks(1476), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Rustic Concrete Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 820,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 14, 5, 12, 1, 328, DateTimeKind.Unspecified).AddTicks(226), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Fantastic Rubber Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 821,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 27, 7, 12, 32, 811, DateTimeKind.Unspecified).AddTicks(6345), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Rustic Cotton Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 822,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 2, 9, 38, 45, 31, DateTimeKind.Unspecified).AddTicks(1668), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Tasty Soft Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 823,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 7, 16, 48, 48, 153, DateTimeKind.Unspecified).AddTicks(2210), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Refined Frozen Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 824,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 12, 0, 44, 57, 428, DateTimeKind.Unspecified).AddTicks(4078), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Incredible Concrete Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 825,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 19, 19, 36, 21, 684, DateTimeKind.Unspecified).AddTicks(9349), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Awesome Rubber Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 826,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 1, 10, 37, 34, 523, DateTimeKind.Unspecified).AddTicks(4305), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Handcrafted Frozen Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 827,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 21, 22, 44, 51, 861, DateTimeKind.Unspecified).AddTicks(2516), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Refined Plastic Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 828,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 19, 2, 16, 38, 245, DateTimeKind.Unspecified).AddTicks(432), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Tasty Granite Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 829,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 2, 18, 36, 12, 564, DateTimeKind.Unspecified).AddTicks(1352), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Small Soft Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 830,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 27, 1, 55, 31, 927, DateTimeKind.Unspecified).AddTicks(4694), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Rustic Frozen Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 831,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 11, 11, 32, 5, 788, DateTimeKind.Unspecified).AddTicks(2876), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Ergonomic Steel Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 832,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 10, 10, 41, 23, 391, DateTimeKind.Unspecified).AddTicks(3503), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Awesome Cotton Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 833,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 5, 12, 38, 15, 416, DateTimeKind.Unspecified).AddTicks(1243), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Tasty Fresh Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 834,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 4, 20, 1, 22, 297, DateTimeKind.Unspecified).AddTicks(336), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Awesome Plastic Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 835,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 18, 15, 7, 32, 49, DateTimeKind.Unspecified).AddTicks(4623), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Unbranded Plastic Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 836,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 29, 23, 23, 5, 422, DateTimeKind.Unspecified).AddTicks(7411), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Licensed Metal Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 837,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 24, 8, 12, 2, 653, DateTimeKind.Unspecified).AddTicks(8704), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Handcrafted Granite Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 838,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 13, 1, 17, 21, 794, DateTimeKind.Unspecified).AddTicks(8891), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Refined Rubber Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 839,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 1, 7, 50, 43, 567, DateTimeKind.Unspecified).AddTicks(237), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Generic Granite Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 840,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 17, 5, 23, 20, 46, DateTimeKind.Unspecified).AddTicks(1279), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Rustic Metal Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 841,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 15, 23, 3, 37, 948, DateTimeKind.Unspecified).AddTicks(8477), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Licensed Soft Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 842,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 16, 15, 20, 25, 9, DateTimeKind.Unspecified).AddTicks(4222), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Licensed Wooden Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 843,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 11, 6, 9, 11, 920, DateTimeKind.Unspecified).AddTicks(5209), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Refined Fresh Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 844,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 17, 18, 29, 42, 14, DateTimeKind.Unspecified).AddTicks(103), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Sleek Wooden Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 845,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 20, 18, 47, 10, 895, DateTimeKind.Unspecified).AddTicks(9499), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Small Rubber Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 846,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 26, 15, 10, 52, 852, DateTimeKind.Unspecified).AddTicks(8391), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Fantastic Concrete Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 847,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 11, 17, 32, 5, 541, DateTimeKind.Unspecified).AddTicks(650), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Rustic Concrete Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 848,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 3, 18, 50, 43, 109, DateTimeKind.Unspecified).AddTicks(415), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Unbranded Plastic Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 849,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 24, 22, 32, 34, 119, DateTimeKind.Unspecified).AddTicks(5679), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Handmade Frozen Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 850,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 27, 0, 45, 20, 140, DateTimeKind.Unspecified).AddTicks(6966), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Handmade Wooden Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 851,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 29, 9, 50, 11, 64, DateTimeKind.Unspecified).AddTicks(2193), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Tasty Soft Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 852,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 18, 3, 37, 17, 329, DateTimeKind.Unspecified).AddTicks(1581), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Intelligent Wooden Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 853,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 7, 10, 1, 2, 851, DateTimeKind.Unspecified).AddTicks(4306), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Awesome Wooden Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 854,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 4, 12, 2, 15, 689, DateTimeKind.Unspecified).AddTicks(4752), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Generic Fresh Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 855,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 10, 1, 37, 11, 451, DateTimeKind.Unspecified).AddTicks(1607), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Intelligent Concrete Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 856,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 16, 18, 5, 46, 79, DateTimeKind.Unspecified).AddTicks(4526), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Ergonomic Frozen Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 857,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 11, 1, 57, 10, 667, DateTimeKind.Unspecified).AddTicks(6701), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Intelligent Cotton Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 858,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 30, 7, 14, 6, 489, DateTimeKind.Unspecified).AddTicks(2596), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Fantastic Steel Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 859,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 3, 10, 37, 10, 604, DateTimeKind.Unspecified).AddTicks(9925), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Licensed Rubber Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 860,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 26, 20, 13, 44, 385, DateTimeKind.Unspecified).AddTicks(1030), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Awesome Steel Gloves" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 861,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 27, 16, 21, 44, 827, DateTimeKind.Unspecified).AddTicks(1228), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Refined Frozen Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 862,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 26, 2, 42, 5, 873, DateTimeKind.Unspecified).AddTicks(8129), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Handcrafted Rubber Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 863,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 12, 13, 42, 32, 216, DateTimeKind.Unspecified).AddTicks(877), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Gorgeous Cotton Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 864,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 9, 20, 47, 10, 693, DateTimeKind.Unspecified).AddTicks(307), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Ergonomic Concrete Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 865,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 19, 20, 42, 1, 148, DateTimeKind.Unspecified).AddTicks(9039), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Generic Wooden Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 866,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 23, 12, 31, 45, 294, DateTimeKind.Unspecified).AddTicks(4421), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Generic Granite Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 867,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 1, 0, 53, 24, 483, DateTimeKind.Unspecified).AddTicks(5535), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Ergonomic Metal Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 868,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 21, 5, 57, 10, 734, DateTimeKind.Unspecified).AddTicks(79), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Gorgeous Plastic Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 869,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 21, 14, 36, 20, 604, DateTimeKind.Unspecified).AddTicks(8144), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Licensed Rubber Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 870,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 28, 21, 39, 38, 334, DateTimeKind.Unspecified).AddTicks(9011), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Fantastic Granite Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 871,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 9, 23, 0, 29, 271, DateTimeKind.Unspecified).AddTicks(9390), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Incredible Fresh Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 872,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 20, 1, 15, 31, 711, DateTimeKind.Unspecified).AddTicks(4789), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Handcrafted Granite Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 873,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 13, 18, 8, 49, 160, DateTimeKind.Unspecified).AddTicks(6162), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Intelligent Steel Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 874,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 14, 18, 57, 35, 169, DateTimeKind.Unspecified).AddTicks(74), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Awesome Wooden Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 875,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 24, 0, 52, 29, 482, DateTimeKind.Unspecified).AddTicks(8058), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Refined Plastic Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 876,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 27, 22, 19, 38, 900, DateTimeKind.Unspecified).AddTicks(4370), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Tasty Concrete Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 877,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 19, 18, 57, 8, 130, DateTimeKind.Unspecified).AddTicks(7312), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Ergonomic Steel Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 878,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 23, 20, 48, 25, 236, DateTimeKind.Unspecified).AddTicks(7825), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Intelligent Fresh Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 879,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 12, 11, 38, 1, 806, DateTimeKind.Unspecified).AddTicks(8757), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Refined Plastic Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 880,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 6, 6, 46, 35, 260, DateTimeKind.Unspecified).AddTicks(5165), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Handmade Wooden Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 881,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 5, 13, 53, 52, 428, DateTimeKind.Unspecified).AddTicks(90), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Gorgeous Metal Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 882,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 2, 6, 53, 3, 482, DateTimeKind.Unspecified).AddTicks(1084), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Ergonomic Frozen Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 883,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 4, 21, 58, 57, 983, DateTimeKind.Unspecified).AddTicks(4899), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Practical Plastic Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 884,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 10, 0, 14, 9, 899, DateTimeKind.Unspecified).AddTicks(9448), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Rustic Concrete Gloves" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 885,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 22, 5, 57, 38, 94, DateTimeKind.Unspecified).AddTicks(7527), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Handmade Concrete Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 886,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 12, 11, 8, 52, 410, DateTimeKind.Unspecified).AddTicks(470), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Awesome Concrete Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 887,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 3, 10, 10, 0, 845, DateTimeKind.Unspecified).AddTicks(2137), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Licensed Wooden Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 888,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 16, 5, 2, 31, 877, DateTimeKind.Unspecified).AddTicks(4398), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Fantastic Metal Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 889,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 10, 23, 48, 58, 509, DateTimeKind.Unspecified).AddTicks(271), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Intelligent Plastic Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 890,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 10, 2, 32, 30, 76, DateTimeKind.Unspecified).AddTicks(8150), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Sleek Concrete Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 891,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 29, 5, 11, 2, 196, DateTimeKind.Unspecified).AddTicks(7803), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Sleek Fresh Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 892,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 10, 1, 4, 5, 460, DateTimeKind.Unspecified).AddTicks(3628), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Ergonomic Granite Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 893,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 30, 19, 50, 9, 134, DateTimeKind.Unspecified).AddTicks(2392), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Refined Wooden Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 894,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 24, 20, 2, 19, 552, DateTimeKind.Unspecified).AddTicks(3256), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Fantastic Concrete Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 895,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 25, 17, 49, 16, 529, DateTimeKind.Unspecified).AddTicks(5993), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Sleek Metal Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 896,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 16, 18, 47, 46, 373, DateTimeKind.Unspecified).AddTicks(8102), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Fantastic Concrete Gloves" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 897,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 2, 5, 38, 52, 688, DateTimeKind.Unspecified).AddTicks(6657), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Incredible Concrete Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 898,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 4, 22, 59, 29, 490, DateTimeKind.Unspecified).AddTicks(8510), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Tasty Concrete Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 899,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 29, 13, 55, 34, 633, DateTimeKind.Unspecified).AddTicks(6104), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Unbranded Steel Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 900,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 23, 18, 56, 20, 217, DateTimeKind.Unspecified).AddTicks(905), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Small Concrete Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 901,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 29, 23, 40, 34, 686, DateTimeKind.Unspecified).AddTicks(3322), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Incredible Granite Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 902,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 8, 22, 52, 6, 787, DateTimeKind.Unspecified).AddTicks(6395), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Licensed Fresh Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 903,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 23, 1, 21, 35, 849, DateTimeKind.Unspecified).AddTicks(9989), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Refined Concrete Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 904,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 30, 7, 24, 17, 428, DateTimeKind.Unspecified).AddTicks(6538), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Generic Rubber Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 905,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 4, 20, 8, 21, 774, DateTimeKind.Unspecified).AddTicks(6620), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Rustic Steel Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 906,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 12, 14, 32, 5, 238, DateTimeKind.Unspecified).AddTicks(3861), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Practical Rubber Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 907,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 22, 12, 9, 9, 699, DateTimeKind.Unspecified).AddTicks(7021), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Rustic Rubber Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 908,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 27, 19, 53, 8, 388, DateTimeKind.Unspecified).AddTicks(1855), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Licensed Metal Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 909,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 1, 15, 28, 28, 468, DateTimeKind.Unspecified).AddTicks(6387), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Rustic Steel Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 910,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 31, 20, 37, 41, 779, DateTimeKind.Unspecified).AddTicks(4798), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Handmade Plastic Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 911,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 18, 2, 32, 43, 893, DateTimeKind.Unspecified).AddTicks(9600), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Practical Soft Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 912,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 12, 7, 56, 2, 493, DateTimeKind.Unspecified).AddTicks(1153), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Gorgeous Wooden Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 913,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 10, 20, 5, 26, 233, DateTimeKind.Unspecified).AddTicks(8719), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Intelligent Metal Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 914,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 31, 21, 53, 12, 596, DateTimeKind.Unspecified).AddTicks(4273), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Incredible Fresh Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 915,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 25, 6, 2, 56, 219, DateTimeKind.Unspecified).AddTicks(3600), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Unbranded Soft Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 916,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 5, 18, 34, 15, 972, DateTimeKind.Unspecified).AddTicks(5728), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Rustic Frozen Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 917,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 17, 18, 3, 21, 982, DateTimeKind.Unspecified).AddTicks(6280), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Ergonomic Soft Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 918,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 18, 10, 19, 52, 179, DateTimeKind.Unspecified).AddTicks(413), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Fantastic Concrete Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 919,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 27, 12, 7, 44, 338, DateTimeKind.Unspecified).AddTicks(9903), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Handcrafted Concrete Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 920,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 24, 6, 17, 30, 123, DateTimeKind.Unspecified).AddTicks(4918), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Sleek Soft Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 921,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 21, 9, 9, 5, 131, DateTimeKind.Unspecified).AddTicks(2648), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Licensed Fresh Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 922,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 29, 16, 33, 48, 811, DateTimeKind.Unspecified).AddTicks(3676), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Handcrafted Metal Gloves" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 923,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 13, 7, 32, 29, 561, DateTimeKind.Unspecified).AddTicks(78), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Gorgeous Metal Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 924,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 19, 13, 2, 19, 486, DateTimeKind.Unspecified).AddTicks(1840), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Practical Concrete Gloves" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 925,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 13, 20, 45, 13, 83, DateTimeKind.Unspecified).AddTicks(8516), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Ergonomic Metal Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 926,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 10, 13, 19, 24, 553, DateTimeKind.Unspecified).AddTicks(6882), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Handcrafted Frozen Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 927,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 30, 2, 36, 30, 299, DateTimeKind.Unspecified).AddTicks(2901), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Incredible Wooden Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 928,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 25, 15, 19, 22, 933, DateTimeKind.Unspecified).AddTicks(8385), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Gorgeous Plastic Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 929,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 3, 8, 40, 35, 801, DateTimeKind.Unspecified).AddTicks(9316), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Handcrafted Fresh Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 930,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 5, 3, 51, 25, 758, DateTimeKind.Unspecified).AddTicks(5135), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Small Plastic Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 931,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 24, 15, 43, 22, 825, DateTimeKind.Unspecified).AddTicks(2848), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Intelligent Granite Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 932,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 8, 12, 44, 13, 450, DateTimeKind.Unspecified).AddTicks(3120), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Ergonomic Concrete Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 933,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 30, 5, 48, 5, 346, DateTimeKind.Unspecified).AddTicks(1793), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Handmade Wooden Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 934,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 31, 22, 22, 0, 942, DateTimeKind.Unspecified).AddTicks(9175), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Rustic Metal Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 935,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 9, 17, 24, 12, 558, DateTimeKind.Unspecified).AddTicks(8787), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Ergonomic Cotton Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 936,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 11, 19, 26, 16, 293, DateTimeKind.Unspecified).AddTicks(5291), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Intelligent Soft Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 937,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 4, 1, 46, 16, 822, DateTimeKind.Unspecified).AddTicks(2926), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Fantastic Plastic Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 938,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 29, 6, 21, 32, 310, DateTimeKind.Unspecified).AddTicks(5508), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Licensed Wooden Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 939,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 3, 19, 38, 32, 704, DateTimeKind.Unspecified).AddTicks(594), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Ergonomic Rubber Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 940,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 15, 22, 17, 35, 203, DateTimeKind.Unspecified).AddTicks(5822), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Awesome Rubber Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 941,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 25, 10, 51, 28, 551, DateTimeKind.Unspecified).AddTicks(5363), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Fantastic Granite Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 942,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 25, 13, 1, 2, 580, DateTimeKind.Unspecified).AddTicks(6667), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Refined Frozen Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 943,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 6, 17, 38, 23, 974, DateTimeKind.Unspecified).AddTicks(4581), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Incredible Steel Gloves" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 944,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 19, 4, 34, 13, 200, DateTimeKind.Unspecified).AddTicks(9154), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Fantastic Plastic Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 945,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 1, 12, 37, 26, 786, DateTimeKind.Unspecified).AddTicks(8567), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Ergonomic Concrete Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 946,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 19, 7, 41, 36, 36, DateTimeKind.Unspecified).AddTicks(7404), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Sleek Cotton Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 947,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 1, 56, 56, 569, DateTimeKind.Unspecified).AddTicks(8991), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Handcrafted Soft Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 948,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 2, 8, 17, 10, 162, DateTimeKind.Unspecified).AddTicks(7236), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Unbranded Soft Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 949,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 14, 23, 57, 52, 745, DateTimeKind.Unspecified).AddTicks(2365), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Refined Concrete Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 950,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 31, 19, 22, 8, 373, DateTimeKind.Unspecified).AddTicks(2886), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Small Plastic Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 951,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 22, 11, 14, 15, 681, DateTimeKind.Unspecified).AddTicks(6794), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Intelligent Rubber Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 952,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 16, 0, 8, 47, 131, DateTimeKind.Unspecified).AddTicks(1462), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Rustic Soft Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 953,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 13, 15, 30, 48, 694, DateTimeKind.Unspecified).AddTicks(701), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Practical Soft Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 954,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 11, 20, 5, 12, 294, DateTimeKind.Unspecified).AddTicks(5390), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Sleek Rubber Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 955,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 10, 22, 46, 56, 272, DateTimeKind.Unspecified).AddTicks(4860), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Generic Frozen Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 956,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 3, 17, 33, 33, 524, DateTimeKind.Unspecified).AddTicks(5749), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Refined Frozen Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 957,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 17, 20, 56, 35, 514, DateTimeKind.Unspecified).AddTicks(269), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Rustic Metal Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 958,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 3, 13, 2, 24, 134, DateTimeKind.Unspecified).AddTicks(3986), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Small Metal Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 959,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 8, 36, 31, 375, DateTimeKind.Unspecified).AddTicks(5767), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Rustic Concrete Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 960,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 28, 11, 31, 40, 971, DateTimeKind.Unspecified).AddTicks(6851), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Ergonomic Granite Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 961,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 18, 14, 32, 49, 190, DateTimeKind.Unspecified).AddTicks(1896), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Sleek Concrete Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 962,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 24, 0, 26, 50, 262, DateTimeKind.Unspecified).AddTicks(5480), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Gorgeous Granite Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 963,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 15, 16, 32, 18, 616, DateTimeKind.Unspecified).AddTicks(8054), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Intelligent Steel Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 964,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 17, 4, 1, 58, 9, DateTimeKind.Unspecified).AddTicks(1983), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Handmade Soft Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 965,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 16, 1, 48, 9, 529, DateTimeKind.Unspecified).AddTicks(1043), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Refined Cotton Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 966,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 12, 0, 27, 49, 201, DateTimeKind.Unspecified).AddTicks(8783), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Practical Granite Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 967,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 20, 53, 58, 525, DateTimeKind.Unspecified).AddTicks(3792), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Gorgeous Steel Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 968,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 8, 5, 35, 50, 651, DateTimeKind.Unspecified).AddTicks(5520), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Unbranded Wooden Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 969,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 12, 3, 12, 526, DateTimeKind.Unspecified).AddTicks(5840), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Awesome Wooden Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 970,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 5, 9, 8, 20, 630, DateTimeKind.Unspecified).AddTicks(9630), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Ergonomic Steel Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 971,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 31, 20, 35, 28, 165, DateTimeKind.Unspecified).AddTicks(3986), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Incredible Cotton Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 972,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 30, 1, 48, 4, 261, DateTimeKind.Unspecified).AddTicks(5409), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Small Plastic Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 973,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 19, 3, 20, 46, 997, DateTimeKind.Unspecified).AddTicks(921), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Licensed Plastic Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 974,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 5, 7, 36, 27, 630, DateTimeKind.Unspecified).AddTicks(7687), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Rustic Concrete Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 975,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 5, 23, 16, 16, 357, DateTimeKind.Unspecified).AddTicks(4884), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Generic Metal Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 976,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 12, 4, 14, 39, 743, DateTimeKind.Unspecified).AddTicks(7513), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Handmade Cotton Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 977,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 7, 21, 21, 53, 399, DateTimeKind.Unspecified).AddTicks(6992), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Practical Soft Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 978,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 19, 9, 31, 56, 895, DateTimeKind.Unspecified).AddTicks(2190), new TimeSpan(0, 1, 0, 0, 0)), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Refined Steel Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 979,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 10, 16, 8, 8, 389, DateTimeKind.Unspecified).AddTicks(8288), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Generic Granite Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 980,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 25, 0, 28, 42, 567, DateTimeKind.Unspecified).AddTicks(3905), new TimeSpan(0, 1, 0, 0, 0)), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Gorgeous Plastic Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 981,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 17, 12, 14, 14, 898, DateTimeKind.Unspecified).AddTicks(6101), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Refined Wooden Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 982,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 18, 13, 5, 57, 146, DateTimeKind.Unspecified).AddTicks(3191), new TimeSpan(0, 1, 0, 0, 0)), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Generic Frozen Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 983,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 2, 13, 37, 19, 806, DateTimeKind.Unspecified).AddTicks(9995), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Awesome Concrete Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 984,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 7, 17, 43, 40, 587, DateTimeKind.Unspecified).AddTicks(5066), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Small Steel Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 985,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 4, 19, 41, 50, 616, DateTimeKind.Unspecified).AddTicks(4038), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Rustic Fresh Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 986,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 7, 4, 54, 11, 426, DateTimeKind.Unspecified).AddTicks(9655), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Rustic Metal Gloves" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 987,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 3, 8, 20, 11, 257, DateTimeKind.Unspecified).AddTicks(542), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Fantastic Plastic Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 988,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 26, 20, 7, 24, 751, DateTimeKind.Unspecified).AddTicks(6359), new TimeSpan(0, 1, 0, 0, 0)), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Incredible Soft Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 989,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 13, 13, 58, 25, 204, DateTimeKind.Unspecified).AddTicks(2001), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Unbranded Rubber Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 990,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 7, 18, 45, 49, 424, DateTimeKind.Unspecified).AddTicks(4947), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Practical Steel Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 991,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 11, 16, 15, 26, 845, DateTimeKind.Unspecified).AddTicks(1052), new TimeSpan(0, 1, 0, 0, 0)), "The Football Is Good For Training And Recreational Purposes", "Gorgeous Wooden Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 992,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 11, 18, 26, 3, 813, DateTimeKind.Unspecified).AddTicks(4637), new TimeSpan(0, 1, 0, 0, 0)), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Small Steel Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 993,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 13, 12, 2, 31, 3, DateTimeKind.Unspecified).AddTicks(2526), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Unbranded Rubber Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 994,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 19, 2, 5, 18, 187, DateTimeKind.Unspecified).AddTicks(4159), new TimeSpan(0, 1, 0, 0, 0)), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Gorgeous Frozen Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 995,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 30, 2, 27, 23, 197, DateTimeKind.Unspecified).AddTicks(874), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Gorgeous Soft Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 996,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 1, 20, 43, 25, 575, DateTimeKind.Unspecified).AddTicks(6437), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Awesome Plastic Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 997,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 30, 6, 17, 34, 145, DateTimeKind.Unspecified).AddTicks(4374), new TimeSpan(0, 1, 0, 0, 0)), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Rustic Rubber Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 998,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 9, 17, 41, 18, 631, DateTimeKind.Unspecified).AddTicks(3664), new TimeSpan(0, 1, 0, 0, 0)), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Gorgeous Steel Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 999,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 10, 11, 42, 44, 89, DateTimeKind.Unspecified).AddTicks(3519), new TimeSpan(0, 1, 0, 0, 0)), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Intelligent Soft Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1000,
                columns: new[] { "CreationDate", "Description", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 4, 3, 9, 12, 284, DateTimeKind.Unspecified).AddTicks(7062), new TimeSpan(0, 1, 0, 0, 0)), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Incredible Wooden Computer" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Product");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 27, 15, 24, 41, 167, DateTimeKind.Unspecified).AddTicks(9202), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Fresh Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 8, 17, 15, 10, 772, DateTimeKind.Unspecified).AddTicks(7606), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Metal Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 6, 23, 44, 52, 32, DateTimeKind.Unspecified).AddTicks(9952), new TimeSpan(0, 1, 0, 0, 0)), "Practical Rubber Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 9, 17, 2, 10, 219, DateTimeKind.Unspecified).AddTicks(2792), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Rubber Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 2, 14, 10, 36, 535, DateTimeKind.Unspecified).AddTicks(7798), new TimeSpan(0, 1, 0, 0, 0)), "Generic Wooden Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 7, 13, 20, 46, 774, DateTimeKind.Unspecified).AddTicks(1234), new TimeSpan(0, 1, 0, 0, 0)), "Refined Wooden Gloves" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 8, 2, 8, 57, 597, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Metal Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 2, 30, 12, 83, DateTimeKind.Unspecified).AddTicks(7996), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Granite Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 21, 2, 18, 18, 356, DateTimeKind.Unspecified).AddTicks(9122), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Concrete Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 24, 8, 21, 28, 400, DateTimeKind.Unspecified).AddTicks(6310), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Cotton Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 18, 6, 28, 21, 279, DateTimeKind.Unspecified).AddTicks(3647), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Wooden Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 19, 13, 14, 10, 275, DateTimeKind.Unspecified).AddTicks(2077), new TimeSpan(0, 1, 0, 0, 0)), "Refined Steel Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 31, 22, 37, 56, 658, DateTimeKind.Unspecified).AddTicks(9572), new TimeSpan(0, 1, 0, 0, 0)), "Small Steel Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 26, 13, 8, 42, 549, DateTimeKind.Unspecified).AddTicks(5258), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Rubber Gloves" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 25, 21, 32, 33, 677, DateTimeKind.Unspecified).AddTicks(9405), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Metal Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 14, 11, 17, 49, 273, DateTimeKind.Unspecified).AddTicks(5606), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Wooden Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 13, 12, 21, 56, 793, DateTimeKind.Unspecified).AddTicks(1479), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Soft Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 13, 15, 12, 59, 110, DateTimeKind.Unspecified).AddTicks(8146), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Concrete Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 13, 22, 47, 9, 932, DateTimeKind.Unspecified).AddTicks(1182), new TimeSpan(0, 1, 0, 0, 0)), "Practical Cotton Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 6, 0, 40, 43, 320, DateTimeKind.Unspecified).AddTicks(6329), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Fresh Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 23, 3, 56, 33, 805, DateTimeKind.Unspecified).AddTicks(6056), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Cotton Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 6, 13, 0, 35, 690, DateTimeKind.Unspecified).AddTicks(9714), new TimeSpan(0, 1, 0, 0, 0)), "Practical Concrete Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 16, 10, 45, 0, 446, DateTimeKind.Unspecified).AddTicks(5400), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Plastic Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 31, 18, 44, 35, 92, DateTimeKind.Unspecified).AddTicks(4094), new TimeSpan(0, 1, 0, 0, 0)), "Refined Soft Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 9, 15, 2, 48, 958, DateTimeKind.Unspecified).AddTicks(5816), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Metal Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 5, 8, 56, 36, 176, DateTimeKind.Unspecified).AddTicks(8074), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Soft Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 25, 11, 31, 0, 873, DateTimeKind.Unspecified).AddTicks(2906), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Frozen Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 12, 1, 40, 59, 945, DateTimeKind.Unspecified).AddTicks(7171), new TimeSpan(0, 1, 0, 0, 0)), "Practical Rubber Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 3, 3, 48, 47, 713, DateTimeKind.Unspecified).AddTicks(8667), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Granite Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 20, 11, 35, 10, 382, DateTimeKind.Unspecified).AddTicks(7400), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Granite Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 30, 20, 6, 13, 200, DateTimeKind.Unspecified).AddTicks(5856), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Granite Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 16, 2, 44, 3, 598, DateTimeKind.Unspecified).AddTicks(9841), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Metal Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 13, 22, 30, 45, 365, DateTimeKind.Unspecified).AddTicks(4605), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Fresh Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 21, 4, 41, 40, 744, DateTimeKind.Unspecified).AddTicks(122), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Soft Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 11, 14, 2, 25, 942, DateTimeKind.Unspecified).AddTicks(4639), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Steel Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 20, 22, 42, 42, 587, DateTimeKind.Unspecified).AddTicks(383), new TimeSpan(0, 1, 0, 0, 0)), "Small Rubber Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 23, 15, 6, 15, 333, DateTimeKind.Unspecified).AddTicks(6040), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Granite Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 13, 17, 3, 43, 333, DateTimeKind.Unspecified).AddTicks(2784), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Steel Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 11, 6, 12, 31, 608, DateTimeKind.Unspecified).AddTicks(4341), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Concrete Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 10, 14, 26, 21, 978, DateTimeKind.Unspecified).AddTicks(6505), new TimeSpan(0, 1, 0, 0, 0)), "Generic Fresh Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 2, 15, 48, 19, 822, DateTimeKind.Unspecified).AddTicks(9498), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Granite Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 25, 13, 12, 2, 949, DateTimeKind.Unspecified).AddTicks(1632), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Soft Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 6, 26, 41, 828, DateTimeKind.Unspecified).AddTicks(4456), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Steel Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 12, 2, 58, 44, 545, DateTimeKind.Unspecified).AddTicks(410), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Frozen Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 18, 11, 44, 26, 721, DateTimeKind.Unspecified).AddTicks(7866), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Fresh Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 5, 12, 35, 30, 730, DateTimeKind.Unspecified).AddTicks(7169), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Frozen Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 18, 21, 20, 56, 159, DateTimeKind.Unspecified).AddTicks(1727), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Granite Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 11, 9, 16, 34, 288, DateTimeKind.Unspecified).AddTicks(9173), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Frozen Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 6, 23, 28, 45, 387, DateTimeKind.Unspecified).AddTicks(7450), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Concrete Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 19, 14, 10, 21, 733, DateTimeKind.Unspecified).AddTicks(4059), new TimeSpan(0, 1, 0, 0, 0)), "Small Soft Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 20, 20, 39, 17, 797, DateTimeKind.Unspecified).AddTicks(7480), new TimeSpan(0, 1, 0, 0, 0)), "Small Wooden Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 19, 13, 5, 43, 242, DateTimeKind.Unspecified).AddTicks(8741), new TimeSpan(0, 1, 0, 0, 0)), "Generic Metal Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 3, 3, 24, 43, 125, DateTimeKind.Unspecified).AddTicks(4433), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Frozen Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 8, 16, 42, 21, 493, DateTimeKind.Unspecified).AddTicks(6001), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Wooden Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 10, 20, 30, 18, 930, DateTimeKind.Unspecified).AddTicks(8255), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Cotton Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 4, 9, 51, 15, 411, DateTimeKind.Unspecified).AddTicks(2854), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Granite Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 7, 17, 21, 39, 61, DateTimeKind.Unspecified).AddTicks(993), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Rubber Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 6, 6, 19, 33, 822, DateTimeKind.Unspecified).AddTicks(5996), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Fresh Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 4, 7, 8, 25, 372, DateTimeKind.Unspecified).AddTicks(8638), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Concrete Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 20, 12, 54, 3, 646, DateTimeKind.Unspecified).AddTicks(2259), new TimeSpan(0, 1, 0, 0, 0)), "Refined Concrete Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 12, 17, 20, 59, 156, DateTimeKind.Unspecified).AddTicks(5883), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Rubber Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 31, 9, 55, 26, 388, DateTimeKind.Unspecified).AddTicks(3188), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Rubber Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 2, 23, 33, 22, 338, DateTimeKind.Unspecified).AddTicks(2043), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Wooden Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 13, 0, 26, 0, 509, DateTimeKind.Unspecified).AddTicks(6494), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Cotton Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 30, 13, 18, 12, 922, DateTimeKind.Unspecified).AddTicks(4131), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Soft Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 18, 2, 6, 6, 924, DateTimeKind.Unspecified).AddTicks(9106), new TimeSpan(0, 1, 0, 0, 0)), "Refined Steel Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 4, 8, 24, 15, 574, DateTimeKind.Unspecified).AddTicks(2164), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Fresh Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 8, 22, 3, 37, 114, DateTimeKind.Unspecified).AddTicks(5047), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Soft Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 17, 4, 59, 41, 630, DateTimeKind.Unspecified).AddTicks(9682), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Plastic Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 7, 8, 37, 34, 365, DateTimeKind.Unspecified).AddTicks(7400), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Fresh Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 16, 19, 11, 33, 157, DateTimeKind.Unspecified).AddTicks(3010), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Metal Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 25, 15, 13, 0, 973, DateTimeKind.Unspecified).AddTicks(3673), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Wooden Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 30, 14, 2, 56, 990, DateTimeKind.Unspecified).AddTicks(5353), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Frozen Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 11, 20, 34, 12, 742, DateTimeKind.Unspecified).AddTicks(5527), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Granite Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 25, 18, 26, 24, 709, DateTimeKind.Unspecified).AddTicks(1460), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Cotton Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 12, 17, 0, 53, 687, DateTimeKind.Unspecified).AddTicks(5680), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Granite Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 26, 14, 53, 41, 863, DateTimeKind.Unspecified).AddTicks(1783), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Metal Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 11, 11, 25, 2, 418, DateTimeKind.Unspecified).AddTicks(229), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Granite Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 27, 22, 49, 13, 833, DateTimeKind.Unspecified).AddTicks(4780), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Frozen Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 17, 11, 24, 4, 724, DateTimeKind.Unspecified).AddTicks(1093), new TimeSpan(0, 1, 0, 0, 0)), "Refined Fresh Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 21, 11, 14, 54, 149, DateTimeKind.Unspecified).AddTicks(7870), new TimeSpan(0, 1, 0, 0, 0)), "Refined Fresh Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 18, 0, 13, 49, 506, DateTimeKind.Unspecified).AddTicks(3318), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Fresh Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 16, 14, 45, 43, 771, DateTimeKind.Unspecified).AddTicks(1022), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Granite Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 24, 15, 5, 39, 973, DateTimeKind.Unspecified).AddTicks(2244), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Metal Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 9, 10, 53, 5, 263, DateTimeKind.Unspecified).AddTicks(214), new TimeSpan(0, 1, 0, 0, 0)), "Small Soft Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 19, 6, 3, 26, 286, DateTimeKind.Unspecified).AddTicks(245), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Wooden Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 28, 3, 42, 18, 14, DateTimeKind.Unspecified).AddTicks(290), new TimeSpan(0, 1, 0, 0, 0)), "Generic Fresh Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 19, 13, 33, 37, 214, DateTimeKind.Unspecified).AddTicks(9660), new TimeSpan(0, 1, 0, 0, 0)), "Small Concrete Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 6, 22, 43, 31, 258, DateTimeKind.Unspecified).AddTicks(1483), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Metal Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 27, 11, 12, 38, 537, DateTimeKind.Unspecified).AddTicks(8490), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Steel Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 18, 10, 13, 13, 287, DateTimeKind.Unspecified).AddTicks(7426), new TimeSpan(0, 1, 0, 0, 0)), "Generic Rubber Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 17, 3, 59, 29, 284, DateTimeKind.Unspecified).AddTicks(1550), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Metal Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 27, 20, 15, 29, 91, DateTimeKind.Unspecified).AddTicks(1535), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Granite Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 13, 19, 32, 36, 398, DateTimeKind.Unspecified).AddTicks(1665), new TimeSpan(0, 1, 0, 0, 0)), "Small Metal Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 23, 13, 6, 46, 166, DateTimeKind.Unspecified).AddTicks(6527), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Granite Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 27, 21, 40, 6, 516, DateTimeKind.Unspecified).AddTicks(6834), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Soft Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 21, 12, 47, 53, 432, DateTimeKind.Unspecified).AddTicks(8244), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Wooden Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 22, 10, 33, 44, 65, DateTimeKind.Unspecified).AddTicks(948), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Frozen Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 23, 13, 39, 41, 282, DateTimeKind.Unspecified).AddTicks(4744), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Granite Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 2, 11, 10, 45, 300, DateTimeKind.Unspecified).AddTicks(4828), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Concrete Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 9, 2, 54, 43, 413, DateTimeKind.Unspecified).AddTicks(2971), new TimeSpan(0, 1, 0, 0, 0)), "Generic Concrete Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 6, 10, 24, 1, 871, DateTimeKind.Unspecified).AddTicks(687), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Steel Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 8, 4, 31, 42, 933, DateTimeKind.Unspecified).AddTicks(1326), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Concrete Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 12, 3, 46, 18, 592, DateTimeKind.Unspecified).AddTicks(442), new TimeSpan(0, 1, 0, 0, 0)), "Small Wooden Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 26, 23, 52, 16, 482, DateTimeKind.Unspecified).AddTicks(1638), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Plastic Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 28, 14, 8, 1, 877, DateTimeKind.Unspecified).AddTicks(7170), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Soft Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 20, 14, 26, 50, 698, DateTimeKind.Unspecified).AddTicks(8327), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Wooden Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 9, 12, 9, 53, 64, DateTimeKind.Unspecified).AddTicks(9065), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Concrete Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 3, 19, 48, 7, 390, DateTimeKind.Unspecified).AddTicks(6227), new TimeSpan(0, 1, 0, 0, 0)), "Practical Steel Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 26, 7, 28, 32, 455, DateTimeKind.Unspecified).AddTicks(3535), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Metal Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 12, 6, 2, 7, 507, DateTimeKind.Unspecified).AddTicks(8559), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Cotton Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 16, 9, 51, 34, 226, DateTimeKind.Unspecified).AddTicks(1099), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Steel Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 10, 13, 0, 45, 569, DateTimeKind.Unspecified).AddTicks(7752), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Soft Gloves" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 8, 21, 24, 57, 842, DateTimeKind.Unspecified).AddTicks(3118), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Granite Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 20, 1, 14, 42, 292, DateTimeKind.Unspecified).AddTicks(7166), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Cotton Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 31, 20, 35, 13, 318, DateTimeKind.Unspecified).AddTicks(7682), new TimeSpan(0, 1, 0, 0, 0)), "Refined Wooden Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 16, 18, 16, 36, 619, DateTimeKind.Unspecified).AddTicks(344), new TimeSpan(0, 1, 0, 0, 0)), "Generic Wooden Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 8, 11, 6, 51, 166, DateTimeKind.Unspecified).AddTicks(2468), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Cotton Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 2, 21, 3, 3, 904, DateTimeKind.Unspecified).AddTicks(3566), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Rubber Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 9, 1, 40, 32, 609, DateTimeKind.Unspecified).AddTicks(7559), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Granite Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 3, 8, 9, 5, 42, DateTimeKind.Unspecified).AddTicks(8844), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Granite Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 11, 16, 6, 26, 179, DateTimeKind.Unspecified).AddTicks(4799), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Frozen Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 29, 10, 31, 57, 555, DateTimeKind.Unspecified).AddTicks(6745), new TimeSpan(0, 1, 0, 0, 0)), "Practical Concrete Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 2, 14, 11, 15, 630, DateTimeKind.Unspecified).AddTicks(9208), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Metal Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 31, 1, 35, 2, 175, DateTimeKind.Unspecified).AddTicks(2173), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Wooden Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 15, 7, 42, 44, 502, DateTimeKind.Unspecified).AddTicks(9955), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Frozen Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 27, 14, 46, 43, 641, DateTimeKind.Unspecified).AddTicks(9503), new TimeSpan(0, 1, 0, 0, 0)), "Refined Rubber Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 25, 12, 21, 38, 471, DateTimeKind.Unspecified).AddTicks(4609), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Rubber Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 18, 15, 53, 38, 663, DateTimeKind.Unspecified).AddTicks(5058), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Concrete Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 15, 14, 22, 23, 739, DateTimeKind.Unspecified).AddTicks(3472), new TimeSpan(0, 1, 0, 0, 0)), "Refined Cotton Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 26, 16, 20, 51, 272, DateTimeKind.Unspecified).AddTicks(7562), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Cotton Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 12, 13, 53, 56, 316, DateTimeKind.Unspecified).AddTicks(7830), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Granite Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 15, 9, 29, 14, 41, DateTimeKind.Unspecified).AddTicks(7873), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Rubber Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 19, 3, 41, 45, 510, DateTimeKind.Unspecified).AddTicks(6848), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Concrete Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 11, 21, 49, 18, 513, DateTimeKind.Unspecified).AddTicks(4080), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Cotton Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 29, 19, 58, 58, 885, DateTimeKind.Unspecified).AddTicks(5000), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Wooden Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 14, 9, 9, 18, 139, DateTimeKind.Unspecified).AddTicks(5226), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Fresh Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 3, 7, 26, 27, 780, DateTimeKind.Unspecified).AddTicks(5519), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Frozen Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 12, 3, 4, 24, 117, DateTimeKind.Unspecified).AddTicks(4902), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Wooden Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 10, 0, 28, 44, 128, DateTimeKind.Unspecified).AddTicks(4764), new TimeSpan(0, 1, 0, 0, 0)), "Practical Soft Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 11, 18, 15, 0, 920, DateTimeKind.Unspecified).AddTicks(3782), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Steel Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 19, 7, 55, 21, 788, DateTimeKind.Unspecified).AddTicks(6891), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Metal Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 20, 21, 8, 36, 35, DateTimeKind.Unspecified).AddTicks(34), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Rubber Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 26, 17, 53, 53, 827, DateTimeKind.Unspecified).AddTicks(694), new TimeSpan(0, 1, 0, 0, 0)), "Small Plastic Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 20, 26, 18, 410, DateTimeKind.Unspecified).AddTicks(4240), new TimeSpan(0, 1, 0, 0, 0)), "Small Metal Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 17, 23, 59, 46, 567, DateTimeKind.Unspecified).AddTicks(2303), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Plastic Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 12, 17, 20, 1, 161, DateTimeKind.Unspecified).AddTicks(6503), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Frozen Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 29, 13, 50, 56, 889, DateTimeKind.Unspecified).AddTicks(9146), new TimeSpan(0, 1, 0, 0, 0)), "Small Granite Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 29, 15, 47, 44, 459, DateTimeKind.Unspecified).AddTicks(9149), new TimeSpan(0, 1, 0, 0, 0)), "Practical Steel Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 8, 19, 35, 9, 562, DateTimeKind.Unspecified).AddTicks(2120), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Granite Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 19, 3, 33, 11, 748, DateTimeKind.Unspecified).AddTicks(1524), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Plastic Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 24, 8, 43, 46, 18, DateTimeKind.Unspecified).AddTicks(3210), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Steel Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 1, 2, 7, 11, 455, DateTimeKind.Unspecified).AddTicks(6006), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Steel Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 1, 7, 35, 20, 286, DateTimeKind.Unspecified).AddTicks(7767), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Steel Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 13, 3, 27, 20, 201, DateTimeKind.Unspecified).AddTicks(2761), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Concrete Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 4, 7, 59, 55, 29, DateTimeKind.Unspecified).AddTicks(7741), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Granite Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 13, 58, 12, 400, DateTimeKind.Unspecified).AddTicks(8095), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Rubber Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 4, 8, 9, 44, 425, DateTimeKind.Unspecified).AddTicks(486), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Fresh Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 17, 21, 39, 9, 771, DateTimeKind.Unspecified).AddTicks(5074), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Cotton Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 1, 23, 26, 41, 525, DateTimeKind.Unspecified).AddTicks(4918), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Metal Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 12, 2, 33, 57, 189, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Plastic Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 4, 9, 51, 51, 36, DateTimeKind.Unspecified).AddTicks(2380), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Frozen Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 26, 6, 53, 52, 968, DateTimeKind.Unspecified).AddTicks(601), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Cotton Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 24, 12, 24, 12, 88, DateTimeKind.Unspecified).AddTicks(7327), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Wooden Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 7, 1, 0, 0, 308, DateTimeKind.Unspecified).AddTicks(4033), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Plastic Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 17, 11, 59, 5, 153, DateTimeKind.Unspecified).AddTicks(5140), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Plastic Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 20, 19, 54, 14, 217, DateTimeKind.Unspecified).AddTicks(7219), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Fresh Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 28, 6, 34, 38, 288, DateTimeKind.Unspecified).AddTicks(2634), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Cotton Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 2, 0, 51, 15, 198, DateTimeKind.Unspecified).AddTicks(3967), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Soft Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 2, 16, 28, 4, 275, DateTimeKind.Unspecified).AddTicks(6784), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Cotton Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 26, 9, 4, 21, 699, DateTimeKind.Unspecified).AddTicks(1670), new TimeSpan(0, 1, 0, 0, 0)), "Small Rubber Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 31, 7, 33, 53, 699, DateTimeKind.Unspecified).AddTicks(347), new TimeSpan(0, 1, 0, 0, 0)), "Small Wooden Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 31, 9, 10, 4, 550, DateTimeKind.Unspecified).AddTicks(2143), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Frozen Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 25, 16, 29, 53, 455, DateTimeKind.Unspecified).AddTicks(2914), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Steel Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 9, 12, 24, 69, DateTimeKind.Unspecified).AddTicks(5140), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Metal Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 30, 15, 22, 6, 283, DateTimeKind.Unspecified).AddTicks(3046), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Cotton Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 1, 14, 36, 9, 513, DateTimeKind.Unspecified).AddTicks(9472), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Rubber Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 5, 11, 49, 30, 951, DateTimeKind.Unspecified).AddTicks(9210), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Fresh Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 30, 22, 39, 15, 152, DateTimeKind.Unspecified).AddTicks(9591), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Granite Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 14, 13, 32, 26, 235, DateTimeKind.Unspecified).AddTicks(8297), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Concrete Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 30, 3, 10, 53, 877, DateTimeKind.Unspecified).AddTicks(1144), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Rubber Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 26, 0, 41, 41, 99, DateTimeKind.Unspecified).AddTicks(9212), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Cotton Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 30, 20, 56, 59, 671, DateTimeKind.Unspecified).AddTicks(9727), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Cotton Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 15, 2, 28, 9, 977, DateTimeKind.Unspecified).AddTicks(791), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Rubber Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 15, 6, 32, 30, 728, DateTimeKind.Unspecified).AddTicks(621), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Metal Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 24, 0, 43, 57, 402, DateTimeKind.Unspecified).AddTicks(3805), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Fresh Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 28, 4, 15, 6, 419, DateTimeKind.Unspecified).AddTicks(9293), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Fresh Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 27, 6, 52, 33, 80, DateTimeKind.Unspecified).AddTicks(604), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Granite Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 23, 4, 38, 26, 885, DateTimeKind.Unspecified).AddTicks(757), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Steel Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 27, 23, 33, 11, 436, DateTimeKind.Unspecified).AddTicks(9558), new TimeSpan(0, 1, 0, 0, 0)), "Small Metal Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 22, 56, 12, 590, DateTimeKind.Unspecified).AddTicks(1688), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Fresh Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 4, 9, 9, 41, 734, DateTimeKind.Unspecified).AddTicks(4057), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Plastic Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 31, 6, 23, 40, 972, DateTimeKind.Unspecified).AddTicks(4159), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Concrete Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 16, 21, 56, 3, 919, DateTimeKind.Unspecified).AddTicks(6985), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Steel Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 23, 4, 42, 9, 757, DateTimeKind.Unspecified).AddTicks(2525), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Rubber Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 17, 5, 39, 54, 88, DateTimeKind.Unspecified).AddTicks(913), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Concrete Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 15, 35, 32, 536, DateTimeKind.Unspecified).AddTicks(1436), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Rubber Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 2, 21, 23, 47, 555, DateTimeKind.Unspecified).AddTicks(5475), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Frozen Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 18, 12, 26, 43, 846, DateTimeKind.Unspecified).AddTicks(2681), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Wooden Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 10, 22, 29, 24, 245, DateTimeKind.Unspecified).AddTicks(9246), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Metal Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 15, 2, 46, 51, 70, DateTimeKind.Unspecified).AddTicks(532), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Plastic Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 28, 21, 39, 3, 715, DateTimeKind.Unspecified).AddTicks(4549), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Soft Gloves" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 11, 4, 35, 39, 625, DateTimeKind.Unspecified).AddTicks(3914), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Wooden Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 25, 3, 16, 19, 871, DateTimeKind.Unspecified).AddTicks(414), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Soft Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 19, 18, 35, 53, 229, DateTimeKind.Unspecified).AddTicks(5790), new TimeSpan(0, 1, 0, 0, 0)), "Refined Frozen Gloves" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 10, 9, 8, 54, 716, DateTimeKind.Unspecified).AddTicks(5557), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Soft Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 27, 8, 7, 37, 545, DateTimeKind.Unspecified).AddTicks(3505), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Steel Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 13, 22, 59, 8, 384, DateTimeKind.Unspecified).AddTicks(5080), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Concrete Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 17, 1, 47, 1, 485, DateTimeKind.Unspecified).AddTicks(2167), new TimeSpan(0, 1, 0, 0, 0)), "Practical Concrete Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 28, 4, 38, 2, 41, DateTimeKind.Unspecified).AddTicks(6377), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Fresh Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 17, 22, 11, 17, 77, DateTimeKind.Unspecified).AddTicks(1679), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Plastic Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 19, 49, 35, 830, DateTimeKind.Unspecified).AddTicks(1752), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Steel Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 19, 8, 10, 39, 392, DateTimeKind.Unspecified).AddTicks(4833), new TimeSpan(0, 1, 0, 0, 0)), "Practical Granite Gloves" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 17, 13, 44, 44, 800, DateTimeKind.Unspecified).AddTicks(2811), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Frozen Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 27, 18, 11, 22, 147, DateTimeKind.Unspecified).AddTicks(6360), new TimeSpan(0, 1, 0, 0, 0)), "Generic Wooden Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 17, 18, 20, 58, 838, DateTimeKind.Unspecified).AddTicks(3324), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Plastic Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 16, 18, 55, 4, 347, DateTimeKind.Unspecified).AddTicks(6569), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Granite Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 24, 4, 57, 40, 731, DateTimeKind.Unspecified).AddTicks(4027), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Frozen Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 29, 11, 6, 50, 103, DateTimeKind.Unspecified).AddTicks(6896), new TimeSpan(0, 1, 0, 0, 0)), "Refined Plastic Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 26, 21, 19, 42, 248, DateTimeKind.Unspecified).AddTicks(4893), new TimeSpan(0, 1, 0, 0, 0)), "Generic Granite Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 29, 9, 51, 35, 563, DateTimeKind.Unspecified).AddTicks(4191), new TimeSpan(0, 1, 0, 0, 0)), "Practical Concrete Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 17, 21, 2, 37, 987, DateTimeKind.Unspecified).AddTicks(2974), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Rubber Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 25, 0, 58, 35, 156, DateTimeKind.Unspecified).AddTicks(5819), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Rubber Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 5, 11, 48, 6, 531, DateTimeKind.Unspecified).AddTicks(9000), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Steel Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 7, 18, 41, 20, 914, DateTimeKind.Unspecified).AddTicks(2230), new TimeSpan(0, 1, 0, 0, 0)), "Practical Soft Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 25, 3, 0, 57, 187, DateTimeKind.Unspecified).AddTicks(3713), new TimeSpan(0, 1, 0, 0, 0)), "Small Frozen Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 4, 12, 26, 26, 449, DateTimeKind.Unspecified).AddTicks(2190), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Cotton Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 18, 16, 42, 47, 847, DateTimeKind.Unspecified).AddTicks(2290), new TimeSpan(0, 1, 0, 0, 0)), "Small Wooden Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 5, 23, 37, 11, 468, DateTimeKind.Unspecified).AddTicks(7258), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Soft Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 13, 1, 54, 33, 87, DateTimeKind.Unspecified).AddTicks(5954), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Steel Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 7, 6, 12, 24, 318, DateTimeKind.Unspecified).AddTicks(7130), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Granite Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 12, 4, 40, 29, 901, DateTimeKind.Unspecified).AddTicks(3065), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Frozen Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 15, 19, 27, 34, 637, DateTimeKind.Unspecified).AddTicks(7431), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Frozen Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 3, 22, 9, 49, 380, DateTimeKind.Unspecified).AddTicks(1582), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Fresh Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 29, 16, 39, 1, 243, DateTimeKind.Unspecified).AddTicks(5093), new TimeSpan(0, 1, 0, 0, 0)), "Small Steel Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 5, 7, 32, 53, 385, DateTimeKind.Unspecified).AddTicks(3405), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Soft Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 24, 1, 23, 1, 691, DateTimeKind.Unspecified).AddTicks(2955), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Steel Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 27, 20, 32, 36, 65, DateTimeKind.Unspecified).AddTicks(9497), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Wooden Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 11, 5, 19, 54, 220, DateTimeKind.Unspecified).AddTicks(5293), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Concrete Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 12, 8, 0, 26, 840, DateTimeKind.Unspecified).AddTicks(5048), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Frozen Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 15, 11, 34, 0, 2, DateTimeKind.Unspecified).AddTicks(5142), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Wooden Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 8, 3, 48, 0, 997, DateTimeKind.Unspecified).AddTicks(6445), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Frozen Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 28, 0, 21, 55, 788, DateTimeKind.Unspecified).AddTicks(1845), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Concrete Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 5, 2, 41, 44, 203, DateTimeKind.Unspecified).AddTicks(8439), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Frozen Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 28, 1, 24, 24, 113, DateTimeKind.Unspecified).AddTicks(3792), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Metal Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 12, 5, 33, 51, 530, DateTimeKind.Unspecified).AddTicks(8945), new TimeSpan(0, 1, 0, 0, 0)), "Practical Soft Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 24, 9, 48, 0, 208, DateTimeKind.Unspecified).AddTicks(4414), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Soft Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 17, 19, 30, 21, 488, DateTimeKind.Unspecified).AddTicks(8599), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Wooden Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 20, 2, 8, 4, 4, DateTimeKind.Unspecified).AddTicks(7423), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Frozen Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 20, 16, 2, 20, 993, DateTimeKind.Unspecified).AddTicks(2820), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Cotton Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 4, 4, 3, 59, 910, DateTimeKind.Unspecified).AddTicks(2068), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Soft Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 8, 16, 16, 58, 938, DateTimeKind.Unspecified).AddTicks(4299), new TimeSpan(0, 1, 0, 0, 0)), "Refined Metal Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 30, 19, 27, 26, 831, DateTimeKind.Unspecified).AddTicks(9114), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Wooden Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 25, 19, 47, 22, 54, DateTimeKind.Unspecified).AddTicks(7591), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Wooden Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 2, 7, 0, 40, 399, DateTimeKind.Unspecified).AddTicks(6464), new TimeSpan(0, 1, 0, 0, 0)), "Generic Plastic Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 25, 0, 50, 12, 529, DateTimeKind.Unspecified).AddTicks(8571), new TimeSpan(0, 1, 0, 0, 0)), "Practical Concrete Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 22, 18, 59, 59, 986, DateTimeKind.Unspecified).AddTicks(2063), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Wooden Gloves" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 21, 1, 30, 1, 149, DateTimeKind.Unspecified).AddTicks(3303), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Fresh Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 9, 10, 1, 40, 325, DateTimeKind.Unspecified).AddTicks(7798), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Metal Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 15, 14, 51, 21, 490, DateTimeKind.Unspecified).AddTicks(9764), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Plastic Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 5, 21, 5, 33, 18, DateTimeKind.Unspecified).AddTicks(1324), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Concrete Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 23, 3, 54, 49, 175, DateTimeKind.Unspecified).AddTicks(3945), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Plastic Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 2, 6, 28, 54, 180, DateTimeKind.Unspecified).AddTicks(6950), new TimeSpan(0, 1, 0, 0, 0)), "Small Cotton Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 6, 22, 22, 17, 425, DateTimeKind.Unspecified).AddTicks(5881), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Plastic Gloves" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 30, 12, 42, 34, 825, DateTimeKind.Unspecified).AddTicks(7413), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Plastic Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 17, 11, 53, 42, 834, DateTimeKind.Unspecified).AddTicks(9644), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Frozen Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 27, 5, 22, 5, 904, DateTimeKind.Unspecified).AddTicks(1442), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Soft Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 23, 21, 11, 50, 227, DateTimeKind.Unspecified).AddTicks(5129), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Plastic Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 21, 21, 34, 22, 882, DateTimeKind.Unspecified).AddTicks(6590), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Cotton Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 2, 6, 39, 4, 905, DateTimeKind.Unspecified).AddTicks(4857), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Plastic Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 11, 41, 36, 282, DateTimeKind.Unspecified).AddTicks(5179), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Wooden Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 24, 3, 57, 15, 539, DateTimeKind.Unspecified).AddTicks(6379), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Fresh Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 20, 17, 31, 4, 805, DateTimeKind.Unspecified).AddTicks(4057), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Steel Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 9, 4, 40, 58, 971, DateTimeKind.Unspecified).AddTicks(7986), new TimeSpan(0, 1, 0, 0, 0)), "Refined Concrete Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 1, 13, 11, 7, 662, DateTimeKind.Unspecified).AddTicks(5187), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Wooden Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 14, 15, 50, 7, 855, DateTimeKind.Unspecified).AddTicks(3150), new TimeSpan(0, 1, 0, 0, 0)), "Practical Fresh Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 7, 1, 52, 25, 171, DateTimeKind.Unspecified).AddTicks(89), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Metal Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 22, 23, 0, 52, 998, DateTimeKind.Unspecified).AddTicks(4247), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Wooden Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 24, 14, 30, 37, 616, DateTimeKind.Unspecified).AddTicks(5720), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Concrete Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 28, 13, 3, 20, 929, DateTimeKind.Unspecified).AddTicks(3430), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Frozen Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 13, 6, 4, 55, 376, DateTimeKind.Unspecified).AddTicks(5894), new TimeSpan(0, 1, 0, 0, 0)), "Small Steel Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 17, 17, 50, 48, 488, DateTimeKind.Unspecified).AddTicks(2637), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Frozen Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 14, 20, 55, 8, 678, DateTimeKind.Unspecified).AddTicks(6499), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Fresh Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 14, 10, 2, 36, 328, DateTimeKind.Unspecified).AddTicks(2924), new TimeSpan(0, 1, 0, 0, 0)), "Generic Granite Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 29, 5, 26, 57, 613, DateTimeKind.Unspecified).AddTicks(4452), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Fresh Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 10, 14, 39, 47, 172, DateTimeKind.Unspecified).AddTicks(4730), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Wooden Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 25, 4, 0, 13, 239, DateTimeKind.Unspecified).AddTicks(5392), new TimeSpan(0, 1, 0, 0, 0)), "Practical Wooden Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 1, 3, 40, 29, 394, DateTimeKind.Unspecified).AddTicks(3002), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Granite Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 14, 14, 58, 52, 732, DateTimeKind.Unspecified).AddTicks(1421), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Rubber Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 28, 17, 26, 30, 105, DateTimeKind.Unspecified).AddTicks(4270), new TimeSpan(0, 1, 0, 0, 0)), "Practical Granite Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 15, 15, 37, 9, 744, DateTimeKind.Unspecified).AddTicks(1459), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Frozen Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 15, 20, 39, 25, 747, DateTimeKind.Unspecified).AddTicks(5741), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Rubber Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 6, 11, 56, 11, 505, DateTimeKind.Unspecified).AddTicks(9746), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Cotton Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 4, 9, 58, 18, 474, DateTimeKind.Unspecified).AddTicks(2493), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Fresh Gloves" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 3, 14, 34, 58, 516, DateTimeKind.Unspecified).AddTicks(1025), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Wooden Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 28, 23, 0, 0, 96, DateTimeKind.Unspecified).AddTicks(3579), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Metal Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 31, 8, 48, 36, 603, DateTimeKind.Unspecified).AddTicks(1059), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Granite Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 8, 20, 15, 12, 414, DateTimeKind.Unspecified).AddTicks(1971), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Granite Gloves" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 25, 21, 30, 9, 631, DateTimeKind.Unspecified).AddTicks(8499), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Frozen Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 5, 11, 36, 48, 933, DateTimeKind.Unspecified).AddTicks(3622), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Wooden Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 3, 15, 11, 38, 980, DateTimeKind.Unspecified).AddTicks(3701), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Granite Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 9, 21, 40, 13, 867, DateTimeKind.Unspecified).AddTicks(9612), new TimeSpan(0, 1, 0, 0, 0)), "Generic Plastic Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 23, 3, 32, 9, 334, DateTimeKind.Unspecified).AddTicks(5702), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Steel Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 28, 12, 27, 4, 668, DateTimeKind.Unspecified).AddTicks(2835), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Fresh Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 11, 19, 9, 11, 968, DateTimeKind.Unspecified).AddTicks(7286), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Granite Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 1, 13, 10, 212, DateTimeKind.Unspecified).AddTicks(9102), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Frozen Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 28, 8, 37, 29, 213, DateTimeKind.Unspecified).AddTicks(8066), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Steel Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 7, 3, 56, 45, 189, DateTimeKind.Unspecified).AddTicks(8528), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Granite Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 21, 23, 35, 46, 665, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Frozen Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 18, 3, 59, 669, DateTimeKind.Unspecified).AddTicks(863), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Concrete Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 11, 11, 54, 53, 657, DateTimeKind.Unspecified).AddTicks(2719), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Rubber Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 30, 7, 33, 32, 598, DateTimeKind.Unspecified).AddTicks(7267), new TimeSpan(0, 1, 0, 0, 0)), "Practical Steel Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 17, 23, 14, 43, 41, DateTimeKind.Unspecified).AddTicks(4385), new TimeSpan(0, 1, 0, 0, 0)), "Practical Concrete Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 5, 16, 17, 0, 608, DateTimeKind.Unspecified).AddTicks(9499), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Wooden Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 11, 12, 59, 20, 476, DateTimeKind.Unspecified).AddTicks(4930), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Granite Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 2, 15, 46, 40, 76, DateTimeKind.Unspecified).AddTicks(1965), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Cotton Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 20, 3, 38, 36, 857, DateTimeKind.Unspecified).AddTicks(1114), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Metal Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 1, 1, 11, 21, 860, DateTimeKind.Unspecified).AddTicks(881), new TimeSpan(0, 1, 0, 0, 0)), "Generic Steel Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 17, 22, 20, 12, 833, DateTimeKind.Unspecified).AddTicks(4656), new TimeSpan(0, 1, 0, 0, 0)), "Refined Metal Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 29, 10, 41, 41, 9, DateTimeKind.Unspecified).AddTicks(2391), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Granite Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 18, 8, 44, 48, 478, DateTimeKind.Unspecified).AddTicks(2116), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Fresh Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 3, 3, 5, 51, 757, DateTimeKind.Unspecified).AddTicks(4092), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Metal Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 5, 14, 23, 24, 963, DateTimeKind.Unspecified).AddTicks(344), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Frozen Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 6, 4, 25, 53, 627, DateTimeKind.Unspecified).AddTicks(6442), new TimeSpan(0, 1, 0, 0, 0)), "Generic Wooden Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 24, 8, 44, 54, 612, DateTimeKind.Unspecified).AddTicks(4773), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Frozen Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 7, 14, 12, 43, 444, DateTimeKind.Unspecified).AddTicks(7676), new TimeSpan(0, 1, 0, 0, 0)), "Small Granite Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 15, 11, 25, 24, 395, DateTimeKind.Unspecified).AddTicks(2523), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Concrete Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 28, 18, 29, 50, 655, DateTimeKind.Unspecified).AddTicks(4038), new TimeSpan(0, 1, 0, 0, 0)), "Refined Steel Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 4, 3, 13, 19, 629, DateTimeKind.Unspecified).AddTicks(2509), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Rubber Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 13, 18, 32, 19, 752, DateTimeKind.Unspecified).AddTicks(404), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Metal Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 1, 3, 0, 38, 405, DateTimeKind.Unspecified).AddTicks(6989), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Fresh Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 19, 9, 20, 53, 324, DateTimeKind.Unspecified).AddTicks(3662), new TimeSpan(0, 1, 0, 0, 0)), "Small Granite Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 18, 19, 34, 37, 106, DateTimeKind.Unspecified).AddTicks(5442), new TimeSpan(0, 1, 0, 0, 0)), "Practical Steel Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 12, 22, 55, 12, 740, DateTimeKind.Unspecified).AddTicks(6443), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Rubber Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 5, 7, 58, 47, 141, DateTimeKind.Unspecified).AddTicks(7496), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Metal Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 5, 4, 22, 51, 442, DateTimeKind.Unspecified).AddTicks(1105), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Rubber Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 1, 20, 40, 25, 250, DateTimeKind.Unspecified).AddTicks(6913), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Frozen Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 11, 9, 1, 45, 494, DateTimeKind.Unspecified).AddTicks(9448), new TimeSpan(0, 1, 0, 0, 0)), "Practical Rubber Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 27, 4, 41, 30, 536, DateTimeKind.Unspecified).AddTicks(1013), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Wooden Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 17, 4, 57, 18, 653, DateTimeKind.Unspecified).AddTicks(4697), new TimeSpan(0, 1, 0, 0, 0)), "Generic Rubber Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 26, 8, 2, 17, 339, DateTimeKind.Unspecified).AddTicks(405), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Concrete Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 26, 10, 25, 36, 423, DateTimeKind.Unspecified).AddTicks(1), new TimeSpan(0, 1, 0, 0, 0)), "Small Fresh Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 27, 19, 45, 12, 762, DateTimeKind.Unspecified).AddTicks(8432), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Plastic Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 26, 1, 43, 41, 94, DateTimeKind.Unspecified).AddTicks(1490), new TimeSpan(0, 1, 0, 0, 0)), "Small Fresh Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 11, 17, 53, 11, 95, DateTimeKind.Unspecified).AddTicks(8990), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Steel Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 4, 11, 59, 17, 727, DateTimeKind.Unspecified).AddTicks(5758), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Steel Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 4, 8, 34, 47, 581, DateTimeKind.Unspecified).AddTicks(1286), new TimeSpan(0, 1, 0, 0, 0)), "Small Granite Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 22, 17, 11, 17, 313, DateTimeKind.Unspecified).AddTicks(5158), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Fresh Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 10, 16, 26, 52, 480, DateTimeKind.Unspecified).AddTicks(7348), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Concrete Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 4, 18, 34, 30, 217, DateTimeKind.Unspecified).AddTicks(1948), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Cotton Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 10, 10, 59, 26, 814, DateTimeKind.Unspecified).AddTicks(5630), new TimeSpan(0, 1, 0, 0, 0)), "Practical Wooden Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 19, 6, 13, 8, 721, DateTimeKind.Unspecified).AddTicks(7311), new TimeSpan(0, 1, 0, 0, 0)), "Generic Cotton Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 4, 13, 51, 15, 36, DateTimeKind.Unspecified).AddTicks(5070), new TimeSpan(0, 1, 0, 0, 0)), "Small Concrete Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 18, 21, 8, 51, 683, DateTimeKind.Unspecified).AddTicks(6411), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Plastic Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 24, 1, 19, 40, 111, DateTimeKind.Unspecified).AddTicks(1778), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Metal Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 20, 0, 27, 4, 258, DateTimeKind.Unspecified).AddTicks(2073), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Wooden Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 12, 3, 57, 12, 299, DateTimeKind.Unspecified).AddTicks(198), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Frozen Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 24, 0, 32, 23, 355, DateTimeKind.Unspecified).AddTicks(3702), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Metal Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 21, 12, 44, 43, 49, DateTimeKind.Unspecified).AddTicks(6686), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Rubber Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 28, 0, 28, 19, 539, DateTimeKind.Unspecified).AddTicks(704), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Concrete Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 13, 4, 0, 29, 556, DateTimeKind.Unspecified).AddTicks(470), new TimeSpan(0, 1, 0, 0, 0)), "Small Granite Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 15, 14, 48, 6, 971, DateTimeKind.Unspecified).AddTicks(1302), new TimeSpan(0, 1, 0, 0, 0)), "Practical Concrete Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 29, 0, 45, 23, 434, DateTimeKind.Unspecified).AddTicks(7443), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Wooden Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 10, 17, 58, 39, 454, DateTimeKind.Unspecified).AddTicks(3676), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Concrete Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 5, 10, 17, 37, 373, DateTimeKind.Unspecified).AddTicks(4156), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Soft Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 6, 7, 3, 26, 286, DateTimeKind.Unspecified).AddTicks(2140), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Metal Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 11, 10, 50, 22, 303, DateTimeKind.Unspecified).AddTicks(7765), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Concrete Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 29, 6, 39, 50, 632, DateTimeKind.Unspecified).AddTicks(4556), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Frozen Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 19, 12, 11, 2, 484, DateTimeKind.Unspecified).AddTicks(4857), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Concrete Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 16, 14, 23, 8, 144, DateTimeKind.Unspecified).AddTicks(8195), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Frozen Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 12, 3, 13, 49, 625, DateTimeKind.Unspecified).AddTicks(7890), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Steel Gloves" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 24, 1, 29, 45, 816, DateTimeKind.Unspecified).AddTicks(802), new TimeSpan(0, 1, 0, 0, 0)), "Small Fresh Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 22, 8, 27, 18, 837, DateTimeKind.Unspecified).AddTicks(6360), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Plastic Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 5, 10, 55, 16, 798, DateTimeKind.Unspecified).AddTicks(2565), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Metal Gloves" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 19, 6, 43, 8, 236, DateTimeKind.Unspecified).AddTicks(5337), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Frozen Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 24, 1, 44, 23, 540, DateTimeKind.Unspecified).AddTicks(6700), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Soft Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 5, 21, 53, 8, 716, DateTimeKind.Unspecified).AddTicks(5449), new TimeSpan(0, 1, 0, 0, 0)), "Generic Fresh Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 18, 0, 43, 17, 288, DateTimeKind.Unspecified).AddTicks(9791), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Rubber Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 1, 6, 53, 5, 422, DateTimeKind.Unspecified).AddTicks(6330), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Cotton Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 25, 13, 6, 39, 377, DateTimeKind.Unspecified).AddTicks(7940), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Frozen Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 23, 15, 47, 30, 388, DateTimeKind.Unspecified).AddTicks(7782), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Concrete Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 7, 12, 37, 10, 918, DateTimeKind.Unspecified).AddTicks(2644), new TimeSpan(0, 1, 0, 0, 0)), "Refined Soft Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 6, 3, 35, 40, 422, DateTimeKind.Unspecified).AddTicks(5825), new TimeSpan(0, 1, 0, 0, 0)), "Refined Wooden Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 9, 7, 19, 24, 765, DateTimeKind.Unspecified).AddTicks(5458), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Frozen Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 17, 0, 50, 4, 279, DateTimeKind.Unspecified).AddTicks(4493), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Soft Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 20, 16, 36, 33, 784, DateTimeKind.Unspecified).AddTicks(1602), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Plastic Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 2, 2, 3, 7, 319, DateTimeKind.Unspecified).AddTicks(2462), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Rubber Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 27, 1, 45, 49, 787, DateTimeKind.Unspecified).AddTicks(5569), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Wooden Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 12, 14, 55, 4, 115, DateTimeKind.Unspecified).AddTicks(5988), new TimeSpan(0, 1, 0, 0, 0)), "Generic Metal Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 30, 9, 35, 53, 824, DateTimeKind.Unspecified).AddTicks(2499), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Steel Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 22, 14, 42, 32, 294, DateTimeKind.Unspecified).AddTicks(8927), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Plastic Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 18, 5, 31, 1, 335, DateTimeKind.Unspecified).AddTicks(5593), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Soft Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 6, 5, 42, 0, 330, DateTimeKind.Unspecified).AddTicks(5367), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Rubber Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 31, 19, 34, 55, 8, DateTimeKind.Unspecified).AddTicks(6398), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Wooden Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 3, 21, 9, 31, 476, DateTimeKind.Unspecified).AddTicks(7063), new TimeSpan(0, 1, 0, 0, 0)), "Small Soft Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 13, 2, 52, 3, 56, DateTimeKind.Unspecified).AddTicks(8946), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Steel Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 17, 17, 36, 33, 519, DateTimeKind.Unspecified).AddTicks(6558), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Metal Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 16, 19, 54, 6, 201, DateTimeKind.Unspecified).AddTicks(5111), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Granite Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 3, 11, 23, 51, 818, DateTimeKind.Unspecified).AddTicks(2851), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Fresh Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 1, 15, 51, 27, 837, DateTimeKind.Unspecified).AddTicks(3797), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Rubber Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 9, 20, 22, 15, 461, DateTimeKind.Unspecified).AddTicks(2287), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Rubber Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 4, 21, 6, 20, 362, DateTimeKind.Unspecified).AddTicks(7157), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Granite Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 22, 16, 36, 53, 182, DateTimeKind.Unspecified).AddTicks(2445), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Rubber Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 20, 1, 15, 36, 444, DateTimeKind.Unspecified).AddTicks(5854), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Cotton Gloves" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 16, 15, 53, 10, 228, DateTimeKind.Unspecified).AddTicks(5765), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Soft Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 28, 3, 32, 16, 650, DateTimeKind.Unspecified).AddTicks(4026), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Fresh Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 4, 1, 47, 19, 29, DateTimeKind.Unspecified).AddTicks(4386), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Frozen Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 29, 0, 6, 59, 563, DateTimeKind.Unspecified).AddTicks(7151), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Soft Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 30, 13, 23, 30, 767, DateTimeKind.Unspecified).AddTicks(6818), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Granite Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 13, 13, 3, 10, 38, DateTimeKind.Unspecified).AddTicks(5552), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Granite Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 22, 12, 36, 12, 612, DateTimeKind.Unspecified).AddTicks(8072), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Metal Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 20, 12, 20, 23, 800, DateTimeKind.Unspecified).AddTicks(7735), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Fresh Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 17, 5, 35, 49, 180, DateTimeKind.Unspecified).AddTicks(3469), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Soft Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 11, 5, 43, 1, 555, DateTimeKind.Unspecified).AddTicks(2701), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Fresh Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 26, 18, 41, 39, 862, DateTimeKind.Unspecified).AddTicks(7825), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Cotton Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 19, 7, 29, 24, 763, DateTimeKind.Unspecified).AddTicks(1768), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Metal Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 1, 30, 20, 668, DateTimeKind.Unspecified).AddTicks(1945), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Plastic Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 29, 5, 26, 45, 918, DateTimeKind.Unspecified).AddTicks(5981), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Plastic Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 26, 18, 43, 34, 210, DateTimeKind.Unspecified).AddTicks(199), new TimeSpan(0, 1, 0, 0, 0)), "Generic Steel Gloves" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 18, 19, 22, 10, 891, DateTimeKind.Unspecified).AddTicks(5610), new TimeSpan(0, 1, 0, 0, 0)), "Refined Metal Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 1, 56, 14, 738, DateTimeKind.Unspecified).AddTicks(3416), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Metal Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 20, 20, 9, 37, 836, DateTimeKind.Unspecified).AddTicks(7319), new TimeSpan(0, 1, 0, 0, 0)), "Refined Cotton Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 29, 12, 21, 50, 540, DateTimeKind.Unspecified).AddTicks(6772), new TimeSpan(0, 1, 0, 0, 0)), "Small Soft Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 20, 51, 27, 568, DateTimeKind.Unspecified).AddTicks(8856), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Rubber Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 22, 9, 59, 18, 514, DateTimeKind.Unspecified).AddTicks(9617), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Concrete Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 14, 7, 51, 14, 528, DateTimeKind.Unspecified).AddTicks(5938), new TimeSpan(0, 1, 0, 0, 0)), "Small Wooden Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 5, 8, 48, 56, 383, DateTimeKind.Unspecified).AddTicks(831), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Fresh Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 17, 13, 45, 43, 712, DateTimeKind.Unspecified).AddTicks(3736), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Rubber Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 10, 13, 23, 31, 600, DateTimeKind.Unspecified).AddTicks(9502), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Concrete Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 1, 6, 28, 3, 505, DateTimeKind.Unspecified).AddTicks(7737), new TimeSpan(0, 1, 0, 0, 0)), "Small Soft Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 7, 4, 40, 47, 224, DateTimeKind.Unspecified).AddTicks(7289), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Soft Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 10, 1, 39, 10, 13, DateTimeKind.Unspecified).AddTicks(202), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Fresh Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 7, 3, 37, 0, 918, DateTimeKind.Unspecified).AddTicks(4243), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Plastic Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 29, 8, 10, 54, 115, DateTimeKind.Unspecified).AddTicks(5980), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Plastic Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 27, 3, 47, 28, 480, DateTimeKind.Unspecified).AddTicks(6211), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Granite Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 22, 14, 27, 27, 96, DateTimeKind.Unspecified).AddTicks(5834), new TimeSpan(0, 1, 0, 0, 0)), "Small Rubber Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 10, 23, 0, 37, 674, DateTimeKind.Unspecified).AddTicks(2270), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Wooden Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 30, 15, 32, 12, 3, DateTimeKind.Unspecified).AddTicks(8174), new TimeSpan(0, 1, 0, 0, 0)), "Refined Wooden Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 27, 11, 2, 57, 481, DateTimeKind.Unspecified).AddTicks(4550), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Fresh Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 18, 14, 44, 2, 932, DateTimeKind.Unspecified).AddTicks(595), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Steel Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 9, 14, 44, 28, 978, DateTimeKind.Unspecified).AddTicks(1866), new TimeSpan(0, 1, 0, 0, 0)), "Small Plastic Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 17, 5, 30, 38, 183, DateTimeKind.Unspecified).AddTicks(8442), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Soft Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 1, 18, 40, 31, 959, DateTimeKind.Unspecified).AddTicks(3085), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Frozen Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 9, 16, 46, 48, 588, DateTimeKind.Unspecified).AddTicks(3494), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Frozen Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 2, 16, 42, 5, 565, DateTimeKind.Unspecified).AddTicks(4628), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Granite Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 21, 22, 41, 31, 541, DateTimeKind.Unspecified).AddTicks(7990), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Frozen Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 24, 8, 11, 28, 715, DateTimeKind.Unspecified).AddTicks(5310), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Metal Gloves" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 10, 5, 43, 58, 21, DateTimeKind.Unspecified).AddTicks(6305), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Soft Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 7, 3, 33, 18, 450, DateTimeKind.Unspecified).AddTicks(5100), new TimeSpan(0, 1, 0, 0, 0)), "Refined Rubber Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 9, 19, 47, 2, 329, DateTimeKind.Unspecified).AddTicks(2978), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Cotton Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 9, 12, 41, 51, 168, DateTimeKind.Unspecified).AddTicks(7662), new TimeSpan(0, 1, 0, 0, 0)), "Generic Fresh Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 17, 11, 32, 5, 509, DateTimeKind.Unspecified).AddTicks(5926), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Cotton Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 23, 21, 49, 3, 511, DateTimeKind.Unspecified).AddTicks(8800), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Rubber Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 27, 14, 0, 52, 600, DateTimeKind.Unspecified).AddTicks(7855), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Steel Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 30, 15, 50, 20, 266, DateTimeKind.Unspecified).AddTicks(5935), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Frozen Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 12, 14, 34, 49, 21, DateTimeKind.Unspecified).AddTicks(1631), new TimeSpan(0, 1, 0, 0, 0)), "Practical Concrete Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 17, 4, 12, 36, 732, DateTimeKind.Unspecified).AddTicks(7910), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Steel Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 28, 14, 20, 52, 222, DateTimeKind.Unspecified).AddTicks(8047), new TimeSpan(0, 1, 0, 0, 0)), "Small Frozen Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 24, 22, 35, 12, 134, DateTimeKind.Unspecified).AddTicks(6030), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Rubber Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 7, 42, 9, 343, DateTimeKind.Unspecified).AddTicks(574), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Plastic Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 4, 10, 4, 43, 384, DateTimeKind.Unspecified).AddTicks(1714), new TimeSpan(0, 1, 0, 0, 0)), "Practical Frozen Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 17, 11, 45, 48, 333, DateTimeKind.Unspecified).AddTicks(6152), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Frozen Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 31, 18, 35, 45, 514, DateTimeKind.Unspecified).AddTicks(304), new TimeSpan(0, 1, 0, 0, 0)), "Small Fresh Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 29, 14, 0, 29, 843, DateTimeKind.Unspecified).AddTicks(4758), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Metal Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 5, 12, 1, 12, 453, DateTimeKind.Unspecified).AddTicks(2863), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Plastic Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 12, 13, 56, 25, 477, DateTimeKind.Unspecified).AddTicks(7120), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Soft Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 29, 3, 19, 18, 642, DateTimeKind.Unspecified).AddTicks(291), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Cotton Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 14, 13, 56, 57, 350, DateTimeKind.Unspecified).AddTicks(2006), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Metal Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 8, 8, 16, 40, 420, DateTimeKind.Unspecified).AddTicks(1370), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Soft Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 18, 12, 53, 43, 327, DateTimeKind.Unspecified).AddTicks(5672), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Metal Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 8, 19, 5, 38, 368, DateTimeKind.Unspecified).AddTicks(363), new TimeSpan(0, 1, 0, 0, 0)), "Refined Fresh Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 5, 5, 34, 0, 811, DateTimeKind.Unspecified).AddTicks(2304), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Granite Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 4, 1, 15, 55, 782, DateTimeKind.Unspecified).AddTicks(5614), new TimeSpan(0, 1, 0, 0, 0)), "Practical Cotton Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 6, 20, 0, 56, 728, DateTimeKind.Unspecified).AddTicks(2727), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Soft Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 14, 10, 52, 36, 433, DateTimeKind.Unspecified).AddTicks(1637), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Fresh Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 18, 4, 24, 49, 95, DateTimeKind.Unspecified).AddTicks(4656), new TimeSpan(0, 1, 0, 0, 0)), "Small Fresh Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 28, 3, 40, 28, 650, DateTimeKind.Unspecified).AddTicks(7919), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Fresh Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 17, 15, 26, 55, 985, DateTimeKind.Unspecified).AddTicks(2940), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Rubber Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 22, 22, 43, 50, 833, DateTimeKind.Unspecified).AddTicks(4193), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Wooden Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 19, 3, 7, 3, 647, DateTimeKind.Unspecified).AddTicks(8259), new TimeSpan(0, 1, 0, 0, 0)), "Practical Wooden Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 29, 6, 37, 23, 238, DateTimeKind.Unspecified).AddTicks(1634), new TimeSpan(0, 1, 0, 0, 0)), "Practical Soft Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 4, 6, 6, 17, 100, DateTimeKind.Unspecified).AddTicks(8294), new TimeSpan(0, 1, 0, 0, 0)), "Small Soft Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 22, 3, 4, 21, 355, DateTimeKind.Unspecified).AddTicks(1636), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Frozen Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 10, 23, 4, 14, 469, DateTimeKind.Unspecified).AddTicks(1888), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Granite Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 14, 5, 11, 53, 235, DateTimeKind.Unspecified).AddTicks(3689), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Frozen Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 18, 0, 18, 53, 238, DateTimeKind.Unspecified).AddTicks(2190), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Steel Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 6, 0, 35, 8, 481, DateTimeKind.Unspecified).AddTicks(2097), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Wooden Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 11, 3, 24, 3, 15, DateTimeKind.Unspecified).AddTicks(3410), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Plastic Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 22, 9, 57, 21, 423, DateTimeKind.Unspecified).AddTicks(9452), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Frozen Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 25, 5, 26, 0, 621, DateTimeKind.Unspecified).AddTicks(4389), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Frozen Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 8, 8, 40, 22, 753, DateTimeKind.Unspecified).AddTicks(9638), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Cotton Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 11, 17, 50, 42, 233, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 1, 0, 0, 0)), "Refined Steel Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 25, 6, 41, 11, 128, DateTimeKind.Unspecified).AddTicks(9814), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Frozen Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 9, 23, 3, 16, 548, DateTimeKind.Unspecified).AddTicks(7626), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Granite Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 26, 14, 57, 22, 980, DateTimeKind.Unspecified).AddTicks(640), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Steel Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 18, 15, 22, 44, 939, DateTimeKind.Unspecified).AddTicks(1802), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Plastic Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 24, 22, 35, 6, 428, DateTimeKind.Unspecified).AddTicks(7800), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Concrete Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 12, 16, 36, 35, 257, DateTimeKind.Unspecified).AddTicks(6988), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Wooden Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 2, 12, 20, 8, 280, DateTimeKind.Unspecified).AddTicks(6002), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Metal Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 28, 22, 37, 23, 424, DateTimeKind.Unspecified).AddTicks(1746), new TimeSpan(0, 1, 0, 0, 0)), "Generic Frozen Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 13, 15, 10, 52, 25, DateTimeKind.Unspecified).AddTicks(21), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Plastic Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 503,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 10, 18, 37, 35, 925, DateTimeKind.Unspecified).AddTicks(2200), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Metal Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 504,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 8, 6, 32, 49, 509, DateTimeKind.Unspecified).AddTicks(8150), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Cotton Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 505,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 26, 5, 47, 2, 684, DateTimeKind.Unspecified).AddTicks(5598), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Rubber Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 14, 20, 7, 48, 311, DateTimeKind.Unspecified).AddTicks(3955), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Wooden Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 507,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 28, 21, 12, 39, 895, DateTimeKind.Unspecified).AddTicks(1574), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Granite Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 21, 14, 30, 37, 497, DateTimeKind.Unspecified).AddTicks(7636), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Metal Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 509,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 5, 18, 37, 49, 46, DateTimeKind.Unspecified).AddTicks(6133), new TimeSpan(0, 1, 0, 0, 0)), "Small Metal Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 510,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 11, 7, 30, 57, 503, DateTimeKind.Unspecified).AddTicks(5711), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Rubber Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 511,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 23, 14, 29, 6, 515, DateTimeKind.Unspecified).AddTicks(9999), new TimeSpan(0, 1, 0, 0, 0)), "Practical Steel Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 512,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 30, 11, 15, 27, 735, DateTimeKind.Unspecified).AddTicks(2415), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Frozen Gloves" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 22, 46, 10, 325, DateTimeKind.Unspecified).AddTicks(7627), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Wooden Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 12, 5, 25, 36, 664, DateTimeKind.Unspecified).AddTicks(5782), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Fresh Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 515,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 9, 0, 35, 37, 403, DateTimeKind.Unspecified).AddTicks(1611), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Plastic Gloves" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 516,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 13, 7, 33, 286, DateTimeKind.Unspecified).AddTicks(6144), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Plastic Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 517,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 11, 13, 55, 28, 253, DateTimeKind.Unspecified).AddTicks(2387), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Fresh Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 518,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 19, 1, 11, 40, 874, DateTimeKind.Unspecified).AddTicks(1471), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Soft Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 20, 23, 13, 6, 691, DateTimeKind.Unspecified).AddTicks(5285), new TimeSpan(0, 1, 0, 0, 0)), "Refined Fresh Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 520,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 1, 7, 31, 23, 37, DateTimeKind.Unspecified).AddTicks(8924), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Concrete Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 521,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 9, 2, 16, 0, 357, DateTimeKind.Unspecified).AddTicks(9423), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Wooden Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 522,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 25, 1, 52, 49, 424, DateTimeKind.Unspecified).AddTicks(1464), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Steel Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 523,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 25, 12, 40, 19, 296, DateTimeKind.Unspecified).AddTicks(6031), new TimeSpan(0, 1, 0, 0, 0)), "Small Plastic Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 524,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 16, 17, 49, 21, 791, DateTimeKind.Unspecified).AddTicks(7313), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Steel Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 525,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 2, 16, 0, 42, 732, DateTimeKind.Unspecified).AddTicks(8614), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Fresh Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 17, 23, 24, 32, 971, DateTimeKind.Unspecified).AddTicks(492), new TimeSpan(0, 1, 0, 0, 0)), "Generic Soft Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 4, 16, 17, 48, 656, DateTimeKind.Unspecified).AddTicks(3256), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Frozen Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 528,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 22, 14, 54, 31, 698, DateTimeKind.Unspecified).AddTicks(3938), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Steel Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 23, 5, 45, 771, DateTimeKind.Unspecified).AddTicks(8921), new TimeSpan(0, 1, 0, 0, 0)), "Practical Granite Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 3, 21, 36, 9, 883, DateTimeKind.Unspecified).AddTicks(8087), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Steel Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 531,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 2, 7, 52, 58, 628, DateTimeKind.Unspecified).AddTicks(896), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Wooden Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 532,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 16, 16, 56, 25, 552, DateTimeKind.Unspecified).AddTicks(7519), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Steel Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 533,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 14, 21, 33, 0, 209, DateTimeKind.Unspecified).AddTicks(6011), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Steel Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 534,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 24, 10, 22, 18, 496, DateTimeKind.Unspecified).AddTicks(510), new TimeSpan(0, 1, 0, 0, 0)), "Refined Steel Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 535,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 5, 48, 28, 126, DateTimeKind.Unspecified).AddTicks(7437), new TimeSpan(0, 1, 0, 0, 0)), "Practical Concrete Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 536,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 30, 6, 46, 51, 883, DateTimeKind.Unspecified).AddTicks(4801), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Steel Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 537,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 6, 17, 59, 692, DateTimeKind.Unspecified).AddTicks(298), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Steel Gloves" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 538,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 9, 13, 7, 0, 206, DateTimeKind.Unspecified).AddTicks(8904), new TimeSpan(0, 1, 0, 0, 0)), "Generic Concrete Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 539,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 23, 20, 17, 33, 818, DateTimeKind.Unspecified).AddTicks(168), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Soft Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 540,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 5, 23, 50, 46, 711, DateTimeKind.Unspecified).AddTicks(7394), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Concrete Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 541,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 24, 18, 14, 46, 185, DateTimeKind.Unspecified).AddTicks(4350), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Cotton Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 542,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 25, 7, 3, 27, 960, DateTimeKind.Unspecified).AddTicks(5964), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Rubber Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 543,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 3, 13, 40, 45, 796, DateTimeKind.Unspecified).AddTicks(654), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Steel Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 544,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 6, 16, 11, 12, 833, DateTimeKind.Unspecified).AddTicks(3668), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Frozen Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 545,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 7, 20, 31, 2, 118, DateTimeKind.Unspecified).AddTicks(2798), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Rubber Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 546,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 15, 8, 3, 14, 415, DateTimeKind.Unspecified).AddTicks(6973), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Fresh Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 547,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 23, 16, 55, 6, 131, DateTimeKind.Unspecified).AddTicks(8187), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Plastic Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 548,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 30, 4, 54, 11, 883, DateTimeKind.Unspecified).AddTicks(7323), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Soft Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 549,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 21, 18, 38, 43, 528, DateTimeKind.Unspecified).AddTicks(2731), new TimeSpan(0, 1, 0, 0, 0)), "Refined Concrete Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 550,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 20, 5, 4, 17, 23, DateTimeKind.Unspecified).AddTicks(373), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Soft Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 551,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 17, 17, 9, 2, 106, DateTimeKind.Unspecified).AddTicks(2829), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Fresh Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 552,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 30, 19, 2, 47, 172, DateTimeKind.Unspecified).AddTicks(628), new TimeSpan(0, 1, 0, 0, 0)), "Refined Fresh Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 553,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 10, 2, 58, 50, 491, DateTimeKind.Unspecified).AddTicks(2570), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Soft Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 554,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 18, 14, 39, 28, 107, DateTimeKind.Unspecified).AddTicks(2777), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Fresh Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 555,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 15, 13, 10, 41, 570, DateTimeKind.Unspecified).AddTicks(3247), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Granite Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 556,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 6, 4, 59, 9, 484, DateTimeKind.Unspecified).AddTicks(4920), new TimeSpan(0, 1, 0, 0, 0)), "Small Cotton Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 557,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 12, 14, 53, 4, 720, DateTimeKind.Unspecified).AddTicks(1088), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Concrete Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 1, 3, 31, 28, 807, DateTimeKind.Unspecified).AddTicks(7733), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Concrete Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 559,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 4, 23, 42, 45, 511, DateTimeKind.Unspecified).AddTicks(7341), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Rubber Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 560,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 7, 8, 11, 34, 138, DateTimeKind.Unspecified).AddTicks(7163), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Rubber Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 6, 17, 54, 34, 390, DateTimeKind.Unspecified).AddTicks(3577), new TimeSpan(0, 1, 0, 0, 0)), "Refined Rubber Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 562,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 28, 23, 27, 0, 549, DateTimeKind.Unspecified).AddTicks(1263), new TimeSpan(0, 1, 0, 0, 0)), "Small Rubber Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 563,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 26, 12, 5, 5, 931, DateTimeKind.Unspecified).AddTicks(9637), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Wooden Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 564,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 15, 16, 58, 44, 632, DateTimeKind.Unspecified).AddTicks(8666), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Fresh Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 22, 10, 48, 19, 555, DateTimeKind.Unspecified).AddTicks(3777), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Fresh Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 566,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 18, 10, 28, 484, DateTimeKind.Unspecified).AddTicks(5595), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Steel Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 567,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 9, 14, 4, 7, 59, DateTimeKind.Unspecified).AddTicks(3567), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Fresh Gloves" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 568,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 1, 0, 41, 13, 831, DateTimeKind.Unspecified).AddTicks(2701), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Soft Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 569,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 30, 21, 15, 42, 43, DateTimeKind.Unspecified).AddTicks(5559), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Cotton Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 570,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 17, 4, 2, 12, 517, DateTimeKind.Unspecified).AddTicks(9910), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Soft Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 571,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 10, 39, 37, 302, DateTimeKind.Unspecified).AddTicks(1651), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Concrete Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 572,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 22, 21, 47, 23, 653, DateTimeKind.Unspecified).AddTicks(774), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Rubber Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 573,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 22, 11, 25, 27, 256, DateTimeKind.Unspecified).AddTicks(9950), new TimeSpan(0, 1, 0, 0, 0)), "Small Soft Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 574,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 22, 25, 28, 592, DateTimeKind.Unspecified).AddTicks(4451), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Frozen Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 575,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 27, 8, 54, 19, 195, DateTimeKind.Unspecified).AddTicks(9370), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Steel Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 576,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 27, 16, 59, 56, 573, DateTimeKind.Unspecified).AddTicks(8564), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Metal Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 577,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 14, 1, 21, 7, 163, DateTimeKind.Unspecified).AddTicks(7734), new TimeSpan(0, 1, 0, 0, 0)), "Small Rubber Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 578,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 12, 1, 49, 23, 401, DateTimeKind.Unspecified).AddTicks(5663), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Steel Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 579,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 8, 11, 14, 17, 587, DateTimeKind.Unspecified).AddTicks(4425), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Granite Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 580,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 29, 13, 7, 48, 847, DateTimeKind.Unspecified).AddTicks(6244), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Cotton Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 581,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 17, 4, 7, 47, 631, DateTimeKind.Unspecified).AddTicks(8444), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Soft Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 14, 22, 32, 18, 220, DateTimeKind.Unspecified).AddTicks(5594), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Rubber Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 583,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 4, 10, 41, 20, 611, DateTimeKind.Unspecified).AddTicks(9649), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Fresh Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 584,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 19, 0, 17, 55, 332, DateTimeKind.Unspecified).AddTicks(6389), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Cotton Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 18, 0, 59, 41, 326, DateTimeKind.Unspecified).AddTicks(9734), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Steel Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 8, 49, 27, 450, DateTimeKind.Unspecified).AddTicks(9894), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Fresh Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 21, 23, 10, 51, 672, DateTimeKind.Unspecified).AddTicks(3453), new TimeSpan(0, 1, 0, 0, 0)), "Small Concrete Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 19, 21, 46, 38, 18, DateTimeKind.Unspecified).AddTicks(4024), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Wooden Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 3, 2, 36, 2, 266, DateTimeKind.Unspecified).AddTicks(8531), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Soft Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 26, 10, 47, 20, 727, DateTimeKind.Unspecified).AddTicks(1310), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Metal Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 15, 5, 46, 58, 66, DateTimeKind.Unspecified).AddTicks(9626), new TimeSpan(0, 1, 0, 0, 0)), "Generic Granite Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 592,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 9, 22, 23, 31, 338, DateTimeKind.Unspecified).AddTicks(1625), new TimeSpan(0, 1, 0, 0, 0)), "Generic Plastic Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 3, 9, 36, 48, 962, DateTimeKind.Unspecified).AddTicks(4340), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Concrete Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 1, 22, 27, 18, 775, DateTimeKind.Unspecified).AddTicks(7541), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Granite Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 595,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 23, 8, 28, 57, 77, DateTimeKind.Unspecified).AddTicks(5780), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Granite Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 596,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 6, 6, 15, 4, 256, DateTimeKind.Unspecified).AddTicks(3288), new TimeSpan(0, 1, 0, 0, 0)), "Practical Metal Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 597,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 27, 19, 20, 42, 162, DateTimeKind.Unspecified).AddTicks(4506), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Fresh Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 598,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 20, 4, 54, 34, 230, DateTimeKind.Unspecified).AddTicks(3824), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Granite Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 599,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 24, 23, 52, 5, 991, DateTimeKind.Unspecified).AddTicks(2531), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Soft Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 600,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 15, 1, 33, 16, 326, DateTimeKind.Unspecified).AddTicks(1837), new TimeSpan(0, 1, 0, 0, 0)), "Refined Fresh Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 601,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 4, 21, 6, 39, 800, DateTimeKind.Unspecified).AddTicks(1078), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Plastic Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 602,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 13, 15, 16, 21, 16, DateTimeKind.Unspecified).AddTicks(2574), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Plastic Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 603,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 23, 14, 45, 56, 504, DateTimeKind.Unspecified).AddTicks(7286), new TimeSpan(0, 1, 0, 0, 0)), "Refined Granite Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 604,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 7, 58, 19, 29, DateTimeKind.Unspecified).AddTicks(8924), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Metal Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 605,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 22, 40, 7, 583, DateTimeKind.Unspecified).AddTicks(4533), new TimeSpan(0, 1, 0, 0, 0)), "Refined Cotton Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 606,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 15, 6, 9, 52, 914, DateTimeKind.Unspecified).AddTicks(9475), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Soft Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 607,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 15, 8, 18, 32, 160, DateTimeKind.Unspecified).AddTicks(6696), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Granite Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 608,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 15, 22, 42, 43, 420, DateTimeKind.Unspecified).AddTicks(4274), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Plastic Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 609,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 6, 2, 35, 22, 559, DateTimeKind.Unspecified).AddTicks(6856), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Cotton Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 610,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 2, 19, 27, 28, 551, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Granite Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 611,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 22, 10, 40, 23, 88, DateTimeKind.Unspecified).AddTicks(4788), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Cotton Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 612,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 18, 7, 46, 49, 178, DateTimeKind.Unspecified).AddTicks(2728), new TimeSpan(0, 1, 0, 0, 0)), "Generic Cotton Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 613,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 30, 21, 7, 51, 77, DateTimeKind.Unspecified).AddTicks(8946), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Fresh Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 614,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 1, 15, 43, 47, 382, DateTimeKind.Unspecified).AddTicks(7457), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Rubber Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 615,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 19, 14, 40, 44, 617, DateTimeKind.Unspecified).AddTicks(8665), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Soft Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 616,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 1, 12, 20, 12, 761, DateTimeKind.Unspecified).AddTicks(8070), new TimeSpan(0, 1, 0, 0, 0)), "Small Fresh Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 617,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 8, 21, 6, 2, 62, DateTimeKind.Unspecified).AddTicks(1511), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Concrete Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 618,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 5, 9, 36, 17, 317, DateTimeKind.Unspecified).AddTicks(3029), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Fresh Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 619,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 29, 1, 31, 22, 890, DateTimeKind.Unspecified).AddTicks(5486), new TimeSpan(0, 1, 0, 0, 0)), "Refined Steel Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 620,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 13, 4, 4, 3, 783, DateTimeKind.Unspecified).AddTicks(2898), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Plastic Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 621,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 22, 4, 42, 29, 564, DateTimeKind.Unspecified).AddTicks(1055), new TimeSpan(0, 1, 0, 0, 0)), "Practical Steel Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 622,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 31, 0, 4, 54, 403, DateTimeKind.Unspecified).AddTicks(9031), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Wooden Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 623,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 28, 11, 26, 30, 704, DateTimeKind.Unspecified).AddTicks(9309), new TimeSpan(0, 1, 0, 0, 0)), "Refined Rubber Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 624,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 6, 9, 43, 53, 564, DateTimeKind.Unspecified).AddTicks(1545), new TimeSpan(0, 1, 0, 0, 0)), "Practical Frozen Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 625,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 17, 7, 1, 32, 224, DateTimeKind.Unspecified).AddTicks(4709), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Soft Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 626,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 9, 20, 2, 28, 174, DateTimeKind.Unspecified).AddTicks(8497), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Steel Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 627,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 20, 1, 42, 39, 525, DateTimeKind.Unspecified).AddTicks(9052), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Granite Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 628,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 17, 14, 29, 49, 305, DateTimeKind.Unspecified).AddTicks(5486), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Frozen Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 629,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 9, 12, 47, 54, 21, DateTimeKind.Unspecified).AddTicks(6765), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Rubber Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 630,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 7, 0, 50, 41, 992, DateTimeKind.Unspecified).AddTicks(3809), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Concrete Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 631,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 24, 16, 56, 0, 866, DateTimeKind.Unspecified).AddTicks(5852), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Wooden Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 632,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 27, 22, 32, 45, 143, DateTimeKind.Unspecified).AddTicks(8090), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Fresh Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 633,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 26, 18, 59, 54, 284, DateTimeKind.Unspecified).AddTicks(1250), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Rubber Gloves" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 634,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 16, 5, 59, 48, 464, DateTimeKind.Unspecified).AddTicks(315), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Steel Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 635,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 17, 9, 30, 19, 717, DateTimeKind.Unspecified).AddTicks(1100), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Frozen Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 636,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 23, 7, 26, 7, 91, DateTimeKind.Unspecified).AddTicks(9496), new TimeSpan(0, 1, 0, 0, 0)), "Practical Wooden Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 637,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 24, 1, 12, 50, 81, DateTimeKind.Unspecified).AddTicks(9794), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Rubber Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 638,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 13, 20, 47, 36, 645, DateTimeKind.Unspecified).AddTicks(2537), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Steel Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 639,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 18, 12, 28, 50, 538, DateTimeKind.Unspecified).AddTicks(775), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Wooden Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 640,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 31, 7, 34, 33, 702, DateTimeKind.Unspecified).AddTicks(3180), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Soft Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 641,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 13, 23, 3, 12, 84, DateTimeKind.Unspecified).AddTicks(8158), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Soft Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 642,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 26, 11, 36, 41, 41, DateTimeKind.Unspecified).AddTicks(695), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Granite Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 643,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 27, 23, 47, 3, 165, DateTimeKind.Unspecified).AddTicks(7380), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Soft Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 644,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 25, 13, 27, 59, 85, DateTimeKind.Unspecified).AddTicks(3977), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Fresh Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 645,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 7, 16, 30, 6, 11, DateTimeKind.Unspecified).AddTicks(68), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Plastic Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 646,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 22, 15, 31, 2, 725, DateTimeKind.Unspecified).AddTicks(8186), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Steel Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 647,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 15, 6, 0, 31, 891, DateTimeKind.Unspecified).AddTicks(1144), new TimeSpan(0, 1, 0, 0, 0)), "Small Wooden Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 648,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 1, 18, 22, 46, 599, DateTimeKind.Unspecified).AddTicks(7677), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Wooden Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 649,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 29, 14, 5, 40, 133, DateTimeKind.Unspecified).AddTicks(9273), new TimeSpan(0, 1, 0, 0, 0)), "Refined Wooden Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 650,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 29, 16, 58, 23, 353, DateTimeKind.Unspecified).AddTicks(383), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Cotton Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 651,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 1, 8, 10, 40, 650, DateTimeKind.Unspecified).AddTicks(7746), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Rubber Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 652,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 15, 1, 9, 13, 232, DateTimeKind.Unspecified).AddTicks(1396), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Cotton Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 653,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 19, 3, 36, 17, 275, DateTimeKind.Unspecified).AddTicks(1285), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Metal Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 654,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 4, 5, 33, 33, 102, DateTimeKind.Unspecified).AddTicks(7104), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Steel Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 655,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 13, 6, 5, 28, 490, DateTimeKind.Unspecified).AddTicks(3909), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Fresh Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 656,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 11, 3, 28, 11, 339, DateTimeKind.Unspecified).AddTicks(2004), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Wooden Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 657,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 8, 21, 53, 59, 459, DateTimeKind.Unspecified).AddTicks(5407), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Wooden Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 658,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 7, 0, 33, 49, 494, DateTimeKind.Unspecified).AddTicks(5933), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Metal Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 659,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 13, 0, 9, 6, 67, DateTimeKind.Unspecified).AddTicks(8369), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Granite Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 660,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 30, 9, 1, 11, 483, DateTimeKind.Unspecified).AddTicks(4615), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Steel Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 661,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 3, 1, 2, 2, 661, DateTimeKind.Unspecified).AddTicks(9542), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Fresh Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 662,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 25, 16, 24, 2, 177, DateTimeKind.Unspecified).AddTicks(7357), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Wooden Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 663,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 24, 7, 51, 16, 746, DateTimeKind.Unspecified).AddTicks(7673), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Frozen Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 664,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 9, 1, 31, 27, 127, DateTimeKind.Unspecified).AddTicks(3392), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Frozen Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 665,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 24, 9, 50, 24, 797, DateTimeKind.Unspecified).AddTicks(8001), new TimeSpan(0, 1, 0, 0, 0)), "Practical Cotton Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 666,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 16, 10, 41, 10, 243, DateTimeKind.Unspecified).AddTicks(8), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Frozen Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 667,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 3, 0, 44, 38, 133, DateTimeKind.Unspecified).AddTicks(8836), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Plastic Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 668,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 18, 11, 3, 23, 340, DateTimeKind.Unspecified).AddTicks(1762), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Rubber Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 669,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 19, 2, 17, 16, 993, DateTimeKind.Unspecified).AddTicks(4148), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Steel Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 670,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 20, 12, 12, 58, 220, DateTimeKind.Unspecified).AddTicks(479), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Metal Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 671,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 23, 5, 58, 10, 16, DateTimeKind.Unspecified).AddTicks(8084), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Granite Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 672,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 11, 4, 29, 54, 29, DateTimeKind.Unspecified).AddTicks(8809), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Cotton Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 673,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 23, 20, 57, 29, 129, DateTimeKind.Unspecified).AddTicks(7087), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Granite Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 674,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 20, 0, 19, 21, 526, DateTimeKind.Unspecified).AddTicks(2973), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Concrete Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 675,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 17, 1, 58, 8, 535, DateTimeKind.Unspecified).AddTicks(3506), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Cotton Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 676,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 9, 8, 50, 45, 849, DateTimeKind.Unspecified).AddTicks(4377), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Cotton Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 677,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 26, 19, 52, 25, 865, DateTimeKind.Unspecified).AddTicks(8251), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Plastic Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 678,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 15, 23, 20, 52, 779, DateTimeKind.Unspecified).AddTicks(1636), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Cotton Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 679,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 14, 0, 38, 39, 245, DateTimeKind.Unspecified).AddTicks(6671), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Fresh Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 680,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 23, 23, 6, 6, 650, DateTimeKind.Unspecified).AddTicks(5960), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Steel Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 681,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 28, 20, 49, 26, 494, DateTimeKind.Unspecified).AddTicks(3863), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Rubber Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 682,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 26, 10, 41, 31, 618, DateTimeKind.Unspecified).AddTicks(4632), new TimeSpan(0, 1, 0, 0, 0)), "Generic Steel Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 683,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 17, 19, 29, 22, 93, DateTimeKind.Unspecified).AddTicks(1652), new TimeSpan(0, 1, 0, 0, 0)), "Generic Frozen Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 684,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 3, 17, 32, 40, 537, DateTimeKind.Unspecified).AddTicks(3347), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Concrete Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 685,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 5, 4, 9, 7, 486, DateTimeKind.Unspecified).AddTicks(2494), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Cotton Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 686,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 11, 22, 12, 48, 209, DateTimeKind.Unspecified).AddTicks(1219), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Steel Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 687,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 3, 8, 24, 41, 705, DateTimeKind.Unspecified).AddTicks(6780), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Concrete Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 688,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 29, 18, 30, 48, 286, DateTimeKind.Unspecified).AddTicks(4733), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Soft Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 689,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 4, 16, 13, 58, 932, DateTimeKind.Unspecified).AddTicks(8884), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Plastic Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 690,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 28, 23, 27, 54, 226, DateTimeKind.Unspecified).AddTicks(4856), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Rubber Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 691,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 22, 7, 33, 56, 723, DateTimeKind.Unspecified).AddTicks(4399), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Concrete Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 692,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 30, 12, 27, 32, 301, DateTimeKind.Unspecified).AddTicks(2860), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Plastic Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 693,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 29, 20, 29, 4, 438, DateTimeKind.Unspecified).AddTicks(1295), new TimeSpan(0, 1, 0, 0, 0)), "Practical Frozen Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 694,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 9, 14, 42, 12, 807, DateTimeKind.Unspecified).AddTicks(8931), new TimeSpan(0, 1, 0, 0, 0)), "Small Fresh Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 695,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 2, 2, 22, 52, 327, DateTimeKind.Unspecified).AddTicks(3434), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Rubber Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 696,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 8, 17, 36, 42, 464, DateTimeKind.Unspecified).AddTicks(5681), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Plastic Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 697,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 30, 19, 34, 26, 947, DateTimeKind.Unspecified).AddTicks(6775), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Concrete Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 698,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 29, 20, 3, 20, 316, DateTimeKind.Unspecified).AddTicks(2286), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Granite Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 699,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 12, 15, 20, 30, 537, DateTimeKind.Unspecified).AddTicks(4549), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Soft Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 700,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 13, 12, 26, 51, 444, DateTimeKind.Unspecified).AddTicks(9797), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Granite Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 11, 8, 15, 6, 475, DateTimeKind.Unspecified).AddTicks(4041), new TimeSpan(0, 1, 0, 0, 0)), "Practical Cotton Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 19, 6, 15, 42, 551, DateTimeKind.Unspecified).AddTicks(4339), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Metal Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 703,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 14, 7, 17, 33, 489, DateTimeKind.Unspecified).AddTicks(623), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Frozen Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 704,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 21, 20, 13, 31, 964, DateTimeKind.Unspecified).AddTicks(5306), new TimeSpan(0, 1, 0, 0, 0)), "Generic Rubber Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 705,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 8, 12, 37, 41, 935, DateTimeKind.Unspecified).AddTicks(5173), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Concrete Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 706,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 29, 9, 1, 51, 606, DateTimeKind.Unspecified).AddTicks(4787), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Wooden Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 707,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 10, 0, 59, 52, 488, DateTimeKind.Unspecified).AddTicks(1681), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Steel Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 708,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 16, 22, 10, 13, 76, DateTimeKind.Unspecified).AddTicks(1874), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Wooden Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 709,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 7, 14, 25, 32, 651, DateTimeKind.Unspecified).AddTicks(967), new TimeSpan(0, 1, 0, 0, 0)), "Generic Concrete Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 710,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 5, 10, 40, 25, 412, DateTimeKind.Unspecified).AddTicks(228), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Wooden Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 711,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 12, 2, 52, 36, 947, DateTimeKind.Unspecified).AddTicks(7589), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Fresh Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 712,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 12, 13, 40, 47, 937, DateTimeKind.Unspecified).AddTicks(3131), new TimeSpan(0, 1, 0, 0, 0)), "Refined Concrete Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 713,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 14, 1, 23, 51, 714, DateTimeKind.Unspecified).AddTicks(7619), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Wooden Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 714,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 9, 16, 33, 22, 195, DateTimeKind.Unspecified).AddTicks(9416), new TimeSpan(0, 1, 0, 0, 0)), "Practical Concrete Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 715,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 23, 23, 28, 48, 638, DateTimeKind.Unspecified).AddTicks(8639), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Soft Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 716,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 21, 22, 22, 5, 516, DateTimeKind.Unspecified).AddTicks(168), new TimeSpan(0, 1, 0, 0, 0)), "Practical Steel Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 717,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 1, 8, 15, 36, 996, DateTimeKind.Unspecified).AddTicks(9847), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Soft Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 718,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 18, 9, 47, 42, 686, DateTimeKind.Unspecified).AddTicks(3880), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Concrete Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 719,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 25, 1, 41, 16, 371, DateTimeKind.Unspecified).AddTicks(2969), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Steel Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 720,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 19, 1, 47, 1, 417, DateTimeKind.Unspecified).AddTicks(4641), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Granite Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 721,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 27, 23, 52, 2, 521, DateTimeKind.Unspecified).AddTicks(3866), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Cotton Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 722,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 26, 12, 23, 0, 881, DateTimeKind.Unspecified).AddTicks(9574), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Frozen Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 723,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 22, 0, 59, 20, 797, DateTimeKind.Unspecified).AddTicks(5333), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Rubber Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 724,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 6, 0, 30, 54, 597, DateTimeKind.Unspecified).AddTicks(3724), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Cotton Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 725,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 2, 5, 48, 31, 917, DateTimeKind.Unspecified).AddTicks(4292), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Cotton Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 726,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 3, 22, 15, 6, 111, DateTimeKind.Unspecified).AddTicks(7737), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Granite Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 727,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 19, 20, 50, 53, 522, DateTimeKind.Unspecified).AddTicks(374), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Steel Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 728,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 28, 7, 55, 21, 12, DateTimeKind.Unspecified).AddTicks(1896), new TimeSpan(0, 1, 0, 0, 0)), "Practical Wooden Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 729,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 6, 13, 6, 47, 321, DateTimeKind.Unspecified).AddTicks(621), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Cotton Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 730,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 22, 22, 5, 18, 268, DateTimeKind.Unspecified).AddTicks(7338), new TimeSpan(0, 1, 0, 0, 0)), "Small Fresh Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 731,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 9, 10, 36, 33, 984, DateTimeKind.Unspecified).AddTicks(2698), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Plastic Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 732,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 28, 22, 4, 52, 969, DateTimeKind.Unspecified).AddTicks(520), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Steel Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 733,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 8, 20, 11, 45, 483, DateTimeKind.Unspecified).AddTicks(321), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Frozen Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 734,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 29, 18, 14, 40, 529, DateTimeKind.Unspecified).AddTicks(7425), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Steel Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 735,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 16, 18, 49, 23, 398, DateTimeKind.Unspecified).AddTicks(1481), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Steel Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 736,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 24, 13, 53, 50, 905, DateTimeKind.Unspecified).AddTicks(6274), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Frozen Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 737,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 21, 19, 42, 35, 62, DateTimeKind.Unspecified).AddTicks(7128), new TimeSpan(0, 1, 0, 0, 0)), "Small Rubber Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 738,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 30, 19, 42, 4, 965, DateTimeKind.Unspecified).AddTicks(6722), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Rubber Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 739,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 14, 22, 15, 46, 409, DateTimeKind.Unspecified).AddTicks(4831), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Steel Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 740,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 16, 9, 56, 49, 616, DateTimeKind.Unspecified).AddTicks(7148), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Steel Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 741,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 2, 17, 28, 57, 173, DateTimeKind.Unspecified).AddTicks(6296), new TimeSpan(0, 1, 0, 0, 0)), "Generic Metal Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 742,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 17, 7, 29, 6, 38, DateTimeKind.Unspecified).AddTicks(4343), new TimeSpan(0, 1, 0, 0, 0)), "Generic Plastic Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 743,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 14, 18, 20, 57, 906, DateTimeKind.Unspecified).AddTicks(2514), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Cotton Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 744,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 20, 4, 19, 28, 260, DateTimeKind.Unspecified).AddTicks(1909), new TimeSpan(0, 1, 0, 0, 0)), "Small Granite Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 745,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 7, 0, 28, 48, 698, DateTimeKind.Unspecified).AddTicks(7191), new TimeSpan(0, 1, 0, 0, 0)), "Practical Fresh Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 746,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 18, 23, 10, 1, 780, DateTimeKind.Unspecified).AddTicks(1596), new TimeSpan(0, 1, 0, 0, 0)), "Small Plastic Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 747,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 1, 17, 28, 49, 332, DateTimeKind.Unspecified).AddTicks(9559), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Cotton Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 748,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 12, 16, 10, 38, 461, DateTimeKind.Unspecified).AddTicks(4751), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Granite Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 749,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 8, 3, 32, 43, 248, DateTimeKind.Unspecified).AddTicks(857), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Granite Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 750,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 11, 23, 55, 48, 993, DateTimeKind.Unspecified).AddTicks(6244), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Plastic Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 751,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 27, 21, 40, 11, 971, DateTimeKind.Unspecified).AddTicks(6126), new TimeSpan(0, 1, 0, 0, 0)), "Small Cotton Gloves" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 752,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 7, 3, 42, 8, 993, DateTimeKind.Unspecified).AddTicks(5187), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Fresh Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 753,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 10, 10, 52, 17, 768, DateTimeKind.Unspecified).AddTicks(2478), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Concrete Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 754,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 20, 11, 32, 48, 499, DateTimeKind.Unspecified).AddTicks(8644), new TimeSpan(0, 1, 0, 0, 0)), "Small Plastic Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 755,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 3, 18, 58, 53, 369, DateTimeKind.Unspecified).AddTicks(7501), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Concrete Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 756,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 25, 7, 0, 32, 742, DateTimeKind.Unspecified).AddTicks(5565), new TimeSpan(0, 1, 0, 0, 0)), "Generic Cotton Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 757,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 24, 23, 26, 50, 901, DateTimeKind.Unspecified).AddTicks(7837), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Metal Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 758,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 21, 13, 57, 29, 711, DateTimeKind.Unspecified).AddTicks(1195), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Steel Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 759,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 16, 23, 10, 48, 933, DateTimeKind.Unspecified).AddTicks(8367), new TimeSpan(0, 1, 0, 0, 0)), "Refined Plastic Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 760,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 1, 22, 45, 53, 246, DateTimeKind.Unspecified).AddTicks(7566), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Frozen Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 761,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 27, 19, 20, 46, 935, DateTimeKind.Unspecified).AddTicks(1062), new TimeSpan(0, 1, 0, 0, 0)), "Practical Granite Gloves" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 762,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 27, 22, 46, 44, 426, DateTimeKind.Unspecified).AddTicks(3221), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Rubber Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 763,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 22, 17, 44, 55, 227, DateTimeKind.Unspecified).AddTicks(2949), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Plastic Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 764,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 21, 17, 21, 28, 999, DateTimeKind.Unspecified).AddTicks(5163), new TimeSpan(0, 1, 0, 0, 0)), "Refined Fresh Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 765,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 8, 1, 42, 59, 66, DateTimeKind.Unspecified).AddTicks(4550), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Steel Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 766,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 22, 17, 16, 57, 399, DateTimeKind.Unspecified).AddTicks(9433), new TimeSpan(0, 1, 0, 0, 0)), "Small Granite Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 767,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 7, 20, 39, 24, 504, DateTimeKind.Unspecified).AddTicks(4507), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Rubber Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 768,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 9, 7, 55, 3, 252, DateTimeKind.Unspecified).AddTicks(365), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Granite Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 769,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 23, 18, 6, 14, 852, DateTimeKind.Unspecified).AddTicks(7023), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Concrete Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 770,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 17, 4, 5, 51, 150, DateTimeKind.Unspecified).AddTicks(7622), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Steel Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 771,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 25, 20, 12, 33, 860, DateTimeKind.Unspecified).AddTicks(4402), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Frozen Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 772,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 18, 16, 40, 55, 148, DateTimeKind.Unspecified).AddTicks(3029), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Metal Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 773,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 13, 16, 27, 41, 511, DateTimeKind.Unspecified).AddTicks(1669), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Frozen Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 774,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 12, 5, 34, 48, 695, DateTimeKind.Unspecified).AddTicks(4607), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Steel Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 775,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 28, 16, 54, 58, 28, DateTimeKind.Unspecified).AddTicks(1411), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Metal Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 776,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 3, 20, 42, 15, 883, DateTimeKind.Unspecified).AddTicks(7666), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Cotton Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 777,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 24, 15, 23, 0, 774, DateTimeKind.Unspecified).AddTicks(7009), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Metal Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 778,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 5, 3, 10, 2, 253, DateTimeKind.Unspecified).AddTicks(8176), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Steel Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 779,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 14, 17, 56, 43, 126, DateTimeKind.Unspecified).AddTicks(2920), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Steel Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 780,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 31, 22, 35, 27, 551, DateTimeKind.Unspecified).AddTicks(956), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Metal Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 781,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 8, 11, 18, 59, 982, DateTimeKind.Unspecified).AddTicks(9739), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Concrete Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 782,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 30, 9, 11, 6, 72, DateTimeKind.Unspecified).AddTicks(8338), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Granite Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 783,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 16, 14, 46, 15, 232, DateTimeKind.Unspecified).AddTicks(1667), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Soft Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 784,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 18, 11, 32, 13, 490, DateTimeKind.Unspecified).AddTicks(4385), new TimeSpan(0, 1, 0, 0, 0)), "Generic Plastic Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 785,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 5, 23, 49, 19, 808, DateTimeKind.Unspecified).AddTicks(8512), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Cotton Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 786,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 29, 17, 8, 38, 721, DateTimeKind.Unspecified).AddTicks(6582), new TimeSpan(0, 1, 0, 0, 0)), "Small Rubber Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 787,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 19, 2, 28, 29, 615, DateTimeKind.Unspecified).AddTicks(8782), new TimeSpan(0, 1, 0, 0, 0)), "Practical Granite Gloves" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 788,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 6, 8, 0, 28, 729, DateTimeKind.Unspecified).AddTicks(9735), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Steel Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 789,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 10, 10, 53, 26, 383, DateTimeKind.Unspecified).AddTicks(6069), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Cotton Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 790,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 23, 20, 17, 59, 678, DateTimeKind.Unspecified).AddTicks(4679), new TimeSpan(0, 1, 0, 0, 0)), "Refined Wooden Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 791,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 5, 19, 26, 3, 915, DateTimeKind.Unspecified).AddTicks(7648), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Metal Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 792,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 9, 9, 17, 50, 437, DateTimeKind.Unspecified).AddTicks(6493), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Frozen Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 793,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 8, 13, 53, 24, 192, DateTimeKind.Unspecified).AddTicks(2338), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Plastic Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 794,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 21, 20, 10, 55, 867, DateTimeKind.Unspecified).AddTicks(6504), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Plastic Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 795,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 15, 21, 57, 51, 453, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Plastic Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 796,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 21, 9, 17, 6, 12, DateTimeKind.Unspecified).AddTicks(8651), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Plastic Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 797,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 6, 3, 16, 58, 172, DateTimeKind.Unspecified).AddTicks(9056), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Concrete Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 798,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 10, 2, 15, 31, 167, DateTimeKind.Unspecified).AddTicks(3945), new TimeSpan(0, 1, 0, 0, 0)), "Practical Metal Gloves" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 799,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 3, 19, 44, 0, 430, DateTimeKind.Unspecified).AddTicks(2240), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Concrete Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 800,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 12, 13, 3, 25, 765, DateTimeKind.Unspecified).AddTicks(440), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Rubber Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 31, 16, 28, 7, 990, DateTimeKind.Unspecified).AddTicks(7658), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Steel Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 25, 9, 49, 36, 98, DateTimeKind.Unspecified).AddTicks(8487), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Soft Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 803,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 3, 19, 29, 3, 34, DateTimeKind.Unspecified).AddTicks(2864), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Steel Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 804,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 11, 18, 28, 38, 320, DateTimeKind.Unspecified).AddTicks(9339), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Plastic Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 805,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 11, 17, 4, 13, 182, DateTimeKind.Unspecified).AddTicks(3219), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Granite Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 806,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 15, 8, 7, 44, 987, DateTimeKind.Unspecified).AddTicks(4747), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Concrete Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 807,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 18, 16, 45, 11, 397, DateTimeKind.Unspecified).AddTicks(5267), new TimeSpan(0, 1, 0, 0, 0)), "Small Cotton Gloves" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 808,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 12, 23, 10, 56, 311, DateTimeKind.Unspecified).AddTicks(1051), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Metal Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 809,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 6, 17, 7, 45, 302, DateTimeKind.Unspecified).AddTicks(3543), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Frozen Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 810,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 17, 1, 29, 11, 88, DateTimeKind.Unspecified).AddTicks(6081), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Plastic Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 811,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 16, 10, 4, 31, 590, DateTimeKind.Unspecified).AddTicks(5922), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Frozen Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 812,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 22, 3, 8, 28, 20, DateTimeKind.Unspecified).AddTicks(6936), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Soft Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 813,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 4, 22, 47, 55, 511, DateTimeKind.Unspecified).AddTicks(7543), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Metal Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 814,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 16, 14, 8, 713, DateTimeKind.Unspecified).AddTicks(2819), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Steel Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 815,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 1, 13, 56, 3, 93, DateTimeKind.Unspecified).AddTicks(4038), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Frozen Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 816,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 15, 5, 0, 51, 518, DateTimeKind.Unspecified).AddTicks(3382), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Steel Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 817,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 23, 10, 36, 20, 792, DateTimeKind.Unspecified).AddTicks(3478), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Concrete Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 818,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 24, 0, 9, 33, 427, DateTimeKind.Unspecified).AddTicks(528), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Wooden Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 819,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 25, 23, 51, 20, 459, DateTimeKind.Unspecified).AddTicks(6956), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Frozen Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 820,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 1, 23, 8, 32, 451, DateTimeKind.Unspecified).AddTicks(6158), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Cotton Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 821,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 23, 2, 13, 25, 190, DateTimeKind.Unspecified).AddTicks(5280), new TimeSpan(0, 1, 0, 0, 0)), "Practical Steel Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 822,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 24, 23, 57, 47, 252, DateTimeKind.Unspecified).AddTicks(4881), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Steel Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 823,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 6, 1, 8, 8, 379, DateTimeKind.Unspecified).AddTicks(8661), new TimeSpan(0, 1, 0, 0, 0)), "Practical Rubber Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 824,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 4, 21, 1, 43, 49, DateTimeKind.Unspecified).AddTicks(3937), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Metal Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 825,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 22, 9, 12, 54, 322, DateTimeKind.Unspecified).AddTicks(7798), new TimeSpan(0, 1, 0, 0, 0)), "Small Steel Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 826,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 16, 9, 43, 15, 313, DateTimeKind.Unspecified).AddTicks(6277), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Concrete Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 827,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 15, 21, 46, 37, 470, DateTimeKind.Unspecified).AddTicks(2259), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Cotton Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 828,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 12, 0, 59, 27, 74, DateTimeKind.Unspecified).AddTicks(1036), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Granite Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 829,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 28, 4, 5, 16, 514, DateTimeKind.Unspecified).AddTicks(159), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Fresh Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 830,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 11, 18, 14, 59, 568, DateTimeKind.Unspecified).AddTicks(1828), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Plastic Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 831,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 5, 7, 47, 9, 321, DateTimeKind.Unspecified).AddTicks(8368), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Frozen Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 832,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 10, 1, 36, 11, 742, DateTimeKind.Unspecified).AddTicks(6533), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Fresh Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 833,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 3, 2, 4, 52, 168, DateTimeKind.Unspecified).AddTicks(6473), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Steel Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 834,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 2, 14, 48, 54, 276, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 1, 0, 0, 0)), "Practical Concrete Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 835,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 27, 21, 15, 24, 693, DateTimeKind.Unspecified).AddTicks(5394), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Fresh Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 836,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 9, 18, 43, 21, 743, DateTimeKind.Unspecified).AddTicks(3404), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Fresh Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 837,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 20, 15, 51, 35, 978, DateTimeKind.Unspecified).AddTicks(7155), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Concrete Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 838,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 24, 7, 11, 2, 896, DateTimeKind.Unspecified).AddTicks(8938), new TimeSpan(0, 1, 0, 0, 0)), "Generic Plastic Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 839,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 31, 10, 12, 22, 675, DateTimeKind.Unspecified).AddTicks(9471), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Rubber Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 840,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 13, 48, 18, 297, DateTimeKind.Unspecified).AddTicks(3730), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Steel Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 841,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 20, 19, 55, 0, 693, DateTimeKind.Unspecified).AddTicks(6315), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Granite Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 842,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 10, 10, 57, 22, 0, DateTimeKind.Unspecified).AddTicks(4341), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Wooden Gloves" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 843,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 11, 13, 3, 28, 464, DateTimeKind.Unspecified).AddTicks(7678), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Soft Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 844,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 21, 5, 58, 44, 991, DateTimeKind.Unspecified).AddTicks(304), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Plastic Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 845,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 30, 13, 26, 21, 26, DateTimeKind.Unspecified).AddTicks(6658), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Granite Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 846,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 24, 16, 16, 24, 568, DateTimeKind.Unspecified).AddTicks(6706), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Granite Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 847,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 13, 4, 26, 47, 699, DateTimeKind.Unspecified).AddTicks(8917), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Plastic Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 848,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 21, 22, 24, 42, 39, DateTimeKind.Unspecified).AddTicks(8510), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Concrete Gloves" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 849,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 11, 12, 0, 34, 212, DateTimeKind.Unspecified).AddTicks(5361), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Concrete Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 850,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 28, 1, 55, 9, 419, DateTimeKind.Unspecified).AddTicks(7258), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Concrete Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 851,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 20, 18, 19, 21, 399, DateTimeKind.Unspecified).AddTicks(6334), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Metal Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 852,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 29, 23, 19, 48, 59, DateTimeKind.Unspecified).AddTicks(5790), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Metal Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 853,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 22, 19, 10, 31, 24, DateTimeKind.Unspecified).AddTicks(9886), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Rubber Gloves" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 854,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 28, 1, 25, 26, 227, DateTimeKind.Unspecified).AddTicks(8280), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Metal Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 855,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 14, 23, 31, 44, 529, DateTimeKind.Unspecified).AddTicks(5213), new TimeSpan(0, 1, 0, 0, 0)), "Practical Concrete Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 856,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 14, 5, 56, 283, DateTimeKind.Unspecified).AddTicks(7090), new TimeSpan(0, 1, 0, 0, 0)), "Generic Granite Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 857,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 5, 1, 9, 23, 551, DateTimeKind.Unspecified).AddTicks(6169), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Wooden Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 858,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 23, 12, 11, 12, 362, DateTimeKind.Unspecified).AddTicks(2032), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Cotton Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 859,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 7, 0, 22, 54, 479, DateTimeKind.Unspecified).AddTicks(5580), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Concrete Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 860,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 22, 19, 6, 2, 600, DateTimeKind.Unspecified).AddTicks(6549), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Concrete Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 861,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 7, 7, 12, 0, 208, DateTimeKind.Unspecified).AddTicks(1903), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Steel Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 862,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 23, 1, 30, 25, 122, DateTimeKind.Unspecified).AddTicks(2440), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Fresh Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 863,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 25, 10, 16, 59, 53, DateTimeKind.Unspecified).AddTicks(5268), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Wooden Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 864,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 26, 1, 33, 32, 837, DateTimeKind.Unspecified).AddTicks(5405), new TimeSpan(0, 1, 0, 0, 0)), "Generic Wooden Gloves" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 865,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 27, 19, 55, 19, 790, DateTimeKind.Unspecified).AddTicks(4099), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Plastic Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 866,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 4, 5, 14, 30, 0, DateTimeKind.Unspecified).AddTicks(2801), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Steel Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 867,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 18, 19, 30, 17, 404, DateTimeKind.Unspecified).AddTicks(1506), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Plastic Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 868,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 28, 11, 57, 57, 64, DateTimeKind.Unspecified).AddTicks(422), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Granite Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 869,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 5, 7, 3, 51, 464, DateTimeKind.Unspecified).AddTicks(3112), new TimeSpan(0, 1, 0, 0, 0)), "Refined Plastic Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 870,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 18, 20, 3, 6, 294, DateTimeKind.Unspecified).AddTicks(5786), new TimeSpan(0, 1, 0, 0, 0)), "Generic Granite Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 871,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 0, 43, 29, 221, DateTimeKind.Unspecified).AddTicks(1212), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Soft Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 872,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 8, 21, 20, 19, 981, DateTimeKind.Unspecified).AddTicks(1352), new TimeSpan(0, 1, 0, 0, 0)), "Generic Frozen Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 873,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 13, 0, 27, 39, 403, DateTimeKind.Unspecified).AddTicks(6614), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Rubber Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 874,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 10, 5, 22, 37, 677, DateTimeKind.Unspecified).AddTicks(9811), new TimeSpan(0, 1, 0, 0, 0)), "Refined Steel Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 875,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 19, 8, 31, 25, 778, DateTimeKind.Unspecified).AddTicks(6021), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Plastic Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 876,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 2, 6, 33, 38, 959, DateTimeKind.Unspecified).AddTicks(7178), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Steel Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 877,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 30, 15, 11, 21, 214, DateTimeKind.Unspecified).AddTicks(5038), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Rubber Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 878,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 7, 11, 28, 55, 803, DateTimeKind.Unspecified).AddTicks(4801), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Soft Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 879,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 27, 4, 7, 18, 408, DateTimeKind.Unspecified).AddTicks(1445), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Soft Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 880,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 10, 11, 20, 27, 897, DateTimeKind.Unspecified).AddTicks(414), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Soft Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 881,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 13, 0, 23, 9, 182, DateTimeKind.Unspecified).AddTicks(1538), new TimeSpan(0, 1, 0, 0, 0)), "Refined Plastic Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 882,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 30, 19, 51, 56, 736, DateTimeKind.Unspecified).AddTicks(5122), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Fresh Gloves" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 883,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 7, 3, 25, 42, 62, DateTimeKind.Unspecified).AddTicks(5608), new TimeSpan(0, 1, 0, 0, 0)), "Practical Concrete Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 884,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 3, 21, 16, 53, 743, DateTimeKind.Unspecified).AddTicks(1872), new TimeSpan(0, 1, 0, 0, 0)), "Generic Concrete Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 885,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 21, 21, 34, 15, 446, DateTimeKind.Unspecified).AddTicks(4893), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Fresh Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 886,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 16, 12, 39, 26, 511, DateTimeKind.Unspecified).AddTicks(9768), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Wooden Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 887,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 20, 18, 59, 27, 708, DateTimeKind.Unspecified).AddTicks(2884), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Rubber Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 888,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 3, 2, 32, 12, 144, DateTimeKind.Unspecified).AddTicks(7457), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Plastic Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 889,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 31, 3, 0, 45, 609, DateTimeKind.Unspecified).AddTicks(1601), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Metal Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 890,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 7, 0, 8, 2, 305, DateTimeKind.Unspecified).AddTicks(8411), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Soft Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 891,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 19, 3, 57, 15, 429, DateTimeKind.Unspecified).AddTicks(6003), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Fresh Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 892,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 22, 10, 4, 30, 38, DateTimeKind.Unspecified).AddTicks(8807), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Granite Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 893,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 23, 13, 2, 52, 130, DateTimeKind.Unspecified).AddTicks(3039), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Cotton Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 894,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 23, 18, 29, 13, 55, DateTimeKind.Unspecified).AddTicks(4870), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Frozen Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 895,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 13, 1, 47, 31, 777, DateTimeKind.Unspecified).AddTicks(9110), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Rubber Gloves" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 896,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 15, 20, 0, 1, 985, DateTimeKind.Unspecified).AddTicks(572), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Concrete Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 897,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 24, 16, 18, 17, 908, DateTimeKind.Unspecified).AddTicks(2289), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Concrete Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 898,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 8, 3, 59, 33, 502, DateTimeKind.Unspecified).AddTicks(5590), new TimeSpan(0, 1, 0, 0, 0)), "Practical Fresh Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 899,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 9, 6, 24, 22, 459, DateTimeKind.Unspecified).AddTicks(5375), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Steel Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 900,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 19, 6, 34, 3, 801, DateTimeKind.Unspecified).AddTicks(3453), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Cotton Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 901,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 5, 23, 35, 489, DateTimeKind.Unspecified).AddTicks(2548), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Cotton Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 902,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 7, 12, 24, 21, 527, DateTimeKind.Unspecified).AddTicks(7079), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Plastic Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 903,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 22, 8, 23, 33, 982, DateTimeKind.Unspecified).AddTicks(8910), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Steel Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 904,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 8, 3, 49, 35, 78, DateTimeKind.Unspecified).AddTicks(3654), new TimeSpan(0, 1, 0, 0, 0)), "Practical Wooden Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 905,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 19, 23, 45, 38, 630, DateTimeKind.Unspecified).AddTicks(8515), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Metal Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 906,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 18, 16, 33, 7, 458, DateTimeKind.Unspecified).AddTicks(5039), new TimeSpan(0, 1, 0, 0, 0)), "Generic Wooden Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 907,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 13, 17, 59, 16, 383, DateTimeKind.Unspecified).AddTicks(1152), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Rubber Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 908,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 2, 6, 6, 4, 281, DateTimeKind.Unspecified).AddTicks(6673), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Concrete Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 909,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 16, 8, 57, 22, 912, DateTimeKind.Unspecified).AddTicks(3415), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Steel Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 910,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 12, 19, 18, 19, 118, DateTimeKind.Unspecified).AddTicks(4869), new TimeSpan(0, 1, 0, 0, 0)), "Refined Fresh Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 911,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 14, 23, 32, 18, 65, DateTimeKind.Unspecified).AddTicks(7708), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Cotton Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 912,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 5, 12, 45, 55, 465, DateTimeKind.Unspecified).AddTicks(876), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Granite Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 913,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 19, 9, 3, 33, 66, DateTimeKind.Unspecified).AddTicks(1578), new TimeSpan(0, 1, 0, 0, 0)), "Small Metal Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 914,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 8, 21, 28, 19, 185, DateTimeKind.Unspecified).AddTicks(540), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Soft Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 915,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 26, 7, 57, 46, 791, DateTimeKind.Unspecified).AddTicks(409), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Cotton Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 916,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 10, 0, 31, 56, 802, DateTimeKind.Unspecified).AddTicks(5873), new TimeSpan(0, 1, 0, 0, 0)), "Refined Concrete Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 917,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 18, 7, 25, 13, 933, DateTimeKind.Unspecified).AddTicks(7587), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Steel Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 918,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 16, 14, 4, 29, 342, DateTimeKind.Unspecified).AddTicks(8005), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Wooden Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 919,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 14, 12, 50, 12, 196, DateTimeKind.Unspecified).AddTicks(2239), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Fresh Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 920,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 5, 8, 40, 26, 271, DateTimeKind.Unspecified).AddTicks(4663), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Plastic Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 921,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 24, 1, 22, 10, 662, DateTimeKind.Unspecified).AddTicks(7652), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Plastic Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 922,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 15, 11, 36, 36, 473, DateTimeKind.Unspecified).AddTicks(2005), new TimeSpan(0, 1, 0, 0, 0)), "Refined Fresh Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 923,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 29, 11, 50, 35, 538, DateTimeKind.Unspecified).AddTicks(7362), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Rubber Ball" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 924,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 2, 6, 30, 33, 345, DateTimeKind.Unspecified).AddTicks(7174), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Rubber Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 925,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 28, 13, 59, 56, 991, DateTimeKind.Unspecified).AddTicks(6725), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Plastic Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 926,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 5, 46, 35, 783, DateTimeKind.Unspecified).AddTicks(5590), new TimeSpan(0, 1, 0, 0, 0)), "Small Concrete Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 927,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 23, 4, 50, 4, 369, DateTimeKind.Unspecified).AddTicks(4038), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Steel Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 928,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 17, 10, 30, 2, 324, DateTimeKind.Unspecified).AddTicks(1932), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Granite Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 929,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 23, 22, 40, 28, 309, DateTimeKind.Unspecified).AddTicks(299), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Soft Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 930,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 31, 2, 26, 37, 703, DateTimeKind.Unspecified).AddTicks(9122), new TimeSpan(0, 1, 0, 0, 0)), "Small Soft Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 931,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 27, 23, 46, 52, 309, DateTimeKind.Unspecified).AddTicks(9530), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Steel Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 932,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 9, 16, 52, 13, 353, DateTimeKind.Unspecified).AddTicks(7978), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Soft Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 933,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 1, 10, 40, 15, 316, DateTimeKind.Unspecified).AddTicks(2015), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Cotton Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 934,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 6, 18, 10, 28, 464, DateTimeKind.Unspecified).AddTicks(808), new TimeSpan(0, 1, 0, 0, 0)), "Practical Wooden Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 935,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 8, 6, 13, 21, 255, DateTimeKind.Unspecified).AddTicks(2378), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Cotton Chair" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 936,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 11, 9, 7, 56, 841, DateTimeKind.Unspecified).AddTicks(5125), new TimeSpan(0, 1, 0, 0, 0)), "Practical Concrete Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 937,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 2, 4, 59, 53, 339, DateTimeKind.Unspecified).AddTicks(5348), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Frozen Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 938,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 7, 22, 28, 2, 198, DateTimeKind.Unspecified).AddTicks(8942), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Metal Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 939,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 4, 8, 55, 12, 127, DateTimeKind.Unspecified).AddTicks(1728), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Concrete Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 940,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 15, 11, 8, 58, 751, DateTimeKind.Unspecified).AddTicks(9961), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Plastic Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 941,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 9, 6, 23, 42, 296, DateTimeKind.Unspecified).AddTicks(8907), new TimeSpan(0, 1, 0, 0, 0)), "Small Frozen Pizza" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 942,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 21, 20, 25, 47, 575, DateTimeKind.Unspecified).AddTicks(9504), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Cotton Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 943,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 3, 2, 55, 55, 267, DateTimeKind.Unspecified).AddTicks(615), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Granite Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 944,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 15, 14, 43, 18, 102, DateTimeKind.Unspecified).AddTicks(8116), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Steel Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 945,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 10, 7, 31, 17, 239, DateTimeKind.Unspecified).AddTicks(907), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Wooden Gloves" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 946,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 26, 5, 4, 0, 108, DateTimeKind.Unspecified).AddTicks(6249), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Cotton Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 947,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 28, 5, 30, 0, 117, DateTimeKind.Unspecified).AddTicks(4644), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Rubber Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 948,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 13, 9, 49, 35, 704, DateTimeKind.Unspecified).AddTicks(8054), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Metal Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 949,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 22, 5, 46, 40, 707, DateTimeKind.Unspecified).AddTicks(4108), new TimeSpan(0, 1, 0, 0, 0)), "Practical Plastic Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 950,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 23, 6, 27, 48, 867, DateTimeKind.Unspecified).AddTicks(5107), new TimeSpan(0, 1, 0, 0, 0)), "Practical Steel Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 951,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 15, 14, 49, 37, 815, DateTimeKind.Unspecified).AddTicks(2965), new TimeSpan(0, 1, 0, 0, 0)), "Small Soft Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 952,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 9, 10, 17, 43, 865, DateTimeKind.Unspecified).AddTicks(5550), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Soft Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 953,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 26, 1, 29, 19, 254, DateTimeKind.Unspecified).AddTicks(3252), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Concrete Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 954,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 8, 27, 21, 10, 45, 495, DateTimeKind.Unspecified).AddTicks(9388), new TimeSpan(0, 1, 0, 0, 0)), "Small Frozen Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 955,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 8, 20, 32, 8, 751, DateTimeKind.Unspecified).AddTicks(4730), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Soft Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 956,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 12, 22, 40, 38, 184, DateTimeKind.Unspecified).AddTicks(5345), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Metal Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 957,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 28, 15, 8, 0, 841, DateTimeKind.Unspecified).AddTicks(9032), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Wooden Mouse" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 958,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 30, 13, 58, 59, 338, DateTimeKind.Unspecified).AddTicks(1530), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Metal Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 959,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 22, 5, 3, 51, 83, DateTimeKind.Unspecified).AddTicks(6487), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Cotton Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 960,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 19, 19, 33, 39, 998, DateTimeKind.Unspecified).AddTicks(5457), new TimeSpan(0, 1, 0, 0, 0)), "Small Concrete Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 961,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 29, 6, 54, 51, 328, DateTimeKind.Unspecified).AddTicks(332), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Wooden Keyboard" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 962,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 6, 21, 10, 25, 402, DateTimeKind.Unspecified).AddTicks(8673), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Plastic Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 963,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 23, 19, 58, 18, 712, DateTimeKind.Unspecified).AddTicks(2719), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Wooden Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 964,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 26, 21, 15, 36, 146, DateTimeKind.Unspecified).AddTicks(5853), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Granite Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 965,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 4, 18, 13, 44, 982, DateTimeKind.Unspecified).AddTicks(253), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Steel Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 966,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 7, 6, 11, 55, 311, DateTimeKind.Unspecified).AddTicks(1455), new TimeSpan(0, 1, 0, 0, 0)), "Generic Concrete Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 967,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 20, 13, 38, 48, 644, DateTimeKind.Unspecified).AddTicks(957), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Fresh Shirt" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 968,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 7, 27, 22, 48, 26, 817, DateTimeKind.Unspecified).AddTicks(4787), new TimeSpan(0, 1, 0, 0, 0)), "Small Wooden Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 969,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 1, 14, 54, 24, 396, DateTimeKind.Unspecified).AddTicks(1200), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Plastic Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 970,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 1, 22, 51, 34, 601, DateTimeKind.Unspecified).AddTicks(8555), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Wooden Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 971,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 20, 10, 45, 9, 433, DateTimeKind.Unspecified).AddTicks(9787), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Metal Chicken" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 972,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 4, 11, 14, 41, 871, DateTimeKind.Unspecified).AddTicks(7606), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Soft Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 973,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 1, 18, 4, 16, 0, 226, DateTimeKind.Unspecified).AddTicks(5576), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Rubber Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 974,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 15, 11, 50, 6, 332, DateTimeKind.Unspecified).AddTicks(4573), new TimeSpan(0, 1, 0, 0, 0)), "Practical Plastic Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 975,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 27, 16, 18, 54, 142, DateTimeKind.Unspecified).AddTicks(1905), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Soft Sausages" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 976,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 9, 4, 16, 13, 10, 246, DateTimeKind.Unspecified).AddTicks(1277), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Concrete Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 977,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 6, 19, 58, 12, 15, DateTimeKind.Unspecified).AddTicks(6677), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Concrete Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 978,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 6, 22, 58, 49, 788, DateTimeKind.Unspecified).AddTicks(1897), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Plastic Bacon" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 979,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 12, 10, 3, 21, 25, 844, DateTimeKind.Unspecified).AddTicks(1154), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Steel Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 980,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 11, 44, 21, 896, DateTimeKind.Unspecified).AddTicks(3451), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Soft Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 981,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 26, 10, 27, 39, 2, DateTimeKind.Unspecified).AddTicks(9025), new TimeSpan(0, 1, 0, 0, 0)), "Refined Wooden Pants" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 982,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 19, 8, 56, 58, 194, DateTimeKind.Unspecified).AddTicks(1493), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Rubber Computer" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 983,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 12, 16, 52, 11, 769, DateTimeKind.Unspecified).AddTicks(2158), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Concrete Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 984,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 6, 1, 56, 53, 910, DateTimeKind.Unspecified).AddTicks(4888), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Metal Salad" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 985,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 5, 7, 52, 10, 693, DateTimeKind.Unspecified).AddTicks(9299), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Steel Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 986,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 10, 15, 11, 41, 766, DateTimeKind.Unspecified).AddTicks(5952), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Soft Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 987,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 6, 23, 32, 32, 41, DateTimeKind.Unspecified).AddTicks(9975), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Rubber Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 988,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 31, 15, 33, 53, 226, DateTimeKind.Unspecified).AddTicks(3), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Metal Bike" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 989,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 9, 11, 55, 26, 438, DateTimeKind.Unspecified).AddTicks(8282), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Frozen Towels" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 990,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 5, 1, 6, 41, 540, DateTimeKind.Unspecified).AddTicks(635), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Steel Chips" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 991,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 31, 5, 16, 33, 658, DateTimeKind.Unspecified).AddTicks(6317), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Fresh Table" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 992,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 29, 2, 41, 9, 547, DateTimeKind.Unspecified).AddTicks(6247), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Frozen Fish" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 993,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 26, 11, 3, 28, 239, DateTimeKind.Unspecified).AddTicks(8881), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Steel Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 994,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 21, 19, 6, 58, 807, DateTimeKind.Unspecified).AddTicks(3506), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Soft Cheese" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 995,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 24, 3, 41, 22, 665, DateTimeKind.Unspecified).AddTicks(7474), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Cotton Tuna" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 996,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 3, 1, 7, 26, 28, 588, DateTimeKind.Unspecified).AddTicks(712), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Metal Shoes" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 997,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 6, 18, 1, 47, 344, DateTimeKind.Unspecified).AddTicks(2357), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Wooden Hat" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 998,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 4, 27, 11, 38, 55, 514, DateTimeKind.Unspecified).AddTicks(8121), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Wooden Car" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 999,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 6, 6, 4, 15, 14, 659, DateTimeKind.Unspecified).AddTicks(9973), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Metal Soap" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1000,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 8, 19, 46, 20, 880, DateTimeKind.Unspecified).AddTicks(356), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Plastic Keyboard" });
        }
    }
}
