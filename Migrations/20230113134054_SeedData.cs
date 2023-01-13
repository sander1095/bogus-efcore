using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bogus_efcore.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreationDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2023, 3, 10, 11, 43, 5, 798, DateTimeKind.Unspecified).AddTicks(3470), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Cotton Chair" },
                    { 2, new DateTimeOffset(new DateTime(2023, 9, 27, 15, 24, 41, 167, DateTimeKind.Unspecified).AddTicks(9202), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Fresh Shirt" },
                    { 3, new DateTimeOffset(new DateTime(2023, 2, 8, 17, 15, 10, 772, DateTimeKind.Unspecified).AddTicks(7606), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Metal Chair" },
                    { 4, new DateTimeOffset(new DateTime(2023, 9, 6, 23, 44, 52, 32, DateTimeKind.Unspecified).AddTicks(9952), new TimeSpan(0, 1, 0, 0, 0)), "Practical Rubber Towels" },
                    { 5, new DateTimeOffset(new DateTime(2023, 6, 9, 17, 2, 10, 219, DateTimeKind.Unspecified).AddTicks(2792), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Rubber Salad" },
                    { 6, new DateTimeOffset(new DateTime(2023, 7, 2, 14, 10, 36, 535, DateTimeKind.Unspecified).AddTicks(7798), new TimeSpan(0, 1, 0, 0, 0)), "Generic Wooden Computer" },
                    { 7, new DateTimeOffset(new DateTime(2023, 10, 7, 13, 20, 46, 774, DateTimeKind.Unspecified).AddTicks(1234), new TimeSpan(0, 1, 0, 0, 0)), "Refined Wooden Gloves" },
                    { 8, new DateTimeOffset(new DateTime(2023, 12, 8, 2, 8, 57, 597, DateTimeKind.Unspecified).AddTicks(6924), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Metal Keyboard" },
                    { 9, new DateTimeOffset(new DateTime(2023, 10, 17, 2, 30, 12, 83, DateTimeKind.Unspecified).AddTicks(7996), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Granite Pizza" },
                    { 10, new DateTimeOffset(new DateTime(2023, 9, 21, 2, 18, 18, 356, DateTimeKind.Unspecified).AddTicks(9122), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Concrete Shoes" },
                    { 11, new DateTimeOffset(new DateTime(2023, 9, 24, 8, 21, 28, 400, DateTimeKind.Unspecified).AddTicks(6310), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Cotton Tuna" },
                    { 12, new DateTimeOffset(new DateTime(2023, 6, 18, 6, 28, 21, 279, DateTimeKind.Unspecified).AddTicks(3647), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Wooden Towels" },
                    { 13, new DateTimeOffset(new DateTime(2023, 10, 19, 13, 14, 10, 275, DateTimeKind.Unspecified).AddTicks(2077), new TimeSpan(0, 1, 0, 0, 0)), "Refined Steel Pizza" },
                    { 14, new DateTimeOffset(new DateTime(2023, 8, 31, 22, 37, 56, 658, DateTimeKind.Unspecified).AddTicks(9572), new TimeSpan(0, 1, 0, 0, 0)), "Small Steel Computer" },
                    { 15, new DateTimeOffset(new DateTime(2023, 3, 26, 13, 8, 42, 549, DateTimeKind.Unspecified).AddTicks(5258), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Rubber Gloves" },
                    { 16, new DateTimeOffset(new DateTime(2023, 11, 25, 21, 32, 33, 677, DateTimeKind.Unspecified).AddTicks(9405), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Metal Towels" },
                    { 17, new DateTimeOffset(new DateTime(2023, 12, 14, 11, 17, 49, 273, DateTimeKind.Unspecified).AddTicks(5606), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Wooden Fish" },
                    { 18, new DateTimeOffset(new DateTime(2023, 2, 13, 12, 21, 56, 793, DateTimeKind.Unspecified).AddTicks(1479), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Soft Ball" },
                    { 19, new DateTimeOffset(new DateTime(2023, 3, 13, 15, 12, 59, 110, DateTimeKind.Unspecified).AddTicks(8146), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Concrete Fish" },
                    { 20, new DateTimeOffset(new DateTime(2023, 10, 13, 22, 47, 9, 932, DateTimeKind.Unspecified).AddTicks(1182), new TimeSpan(0, 1, 0, 0, 0)), "Practical Cotton Computer" },
                    { 21, new DateTimeOffset(new DateTime(2023, 2, 6, 0, 40, 43, 320, DateTimeKind.Unspecified).AddTicks(6329), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Fresh Pizza" },
                    { 22, new DateTimeOffset(new DateTime(2023, 4, 23, 3, 56, 33, 805, DateTimeKind.Unspecified).AddTicks(6056), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Cotton Pizza" },
                    { 23, new DateTimeOffset(new DateTime(2023, 11, 6, 13, 0, 35, 690, DateTimeKind.Unspecified).AddTicks(9714), new TimeSpan(0, 1, 0, 0, 0)), "Practical Concrete Shoes" },
                    { 24, new DateTimeOffset(new DateTime(2024, 1, 16, 10, 45, 0, 446, DateTimeKind.Unspecified).AddTicks(5400), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Plastic Keyboard" },
                    { 25, new DateTimeOffset(new DateTime(2023, 3, 31, 18, 44, 35, 92, DateTimeKind.Unspecified).AddTicks(4094), new TimeSpan(0, 1, 0, 0, 0)), "Refined Soft Mouse" },
                    { 26, new DateTimeOffset(new DateTime(2023, 2, 9, 15, 2, 48, 958, DateTimeKind.Unspecified).AddTicks(5816), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Metal Chicken" },
                    { 27, new DateTimeOffset(new DateTime(2023, 11, 5, 8, 56, 36, 176, DateTimeKind.Unspecified).AddTicks(8074), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Soft Chicken" },
                    { 28, new DateTimeOffset(new DateTime(2023, 11, 25, 11, 31, 0, 873, DateTimeKind.Unspecified).AddTicks(2906), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Frozen Keyboard" },
                    { 29, new DateTimeOffset(new DateTime(2023, 9, 12, 1, 40, 59, 945, DateTimeKind.Unspecified).AddTicks(7171), new TimeSpan(0, 1, 0, 0, 0)), "Practical Rubber Tuna" },
                    { 30, new DateTimeOffset(new DateTime(2023, 3, 3, 3, 48, 47, 713, DateTimeKind.Unspecified).AddTicks(8667), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Granite Car" },
                    { 31, new DateTimeOffset(new DateTime(2023, 7, 20, 11, 35, 10, 382, DateTimeKind.Unspecified).AddTicks(7400), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Granite Shoes" },
                    { 32, new DateTimeOffset(new DateTime(2023, 10, 30, 20, 6, 13, 200, DateTimeKind.Unspecified).AddTicks(5856), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Granite Keyboard" },
                    { 33, new DateTimeOffset(new DateTime(2023, 9, 16, 2, 44, 3, 598, DateTimeKind.Unspecified).AddTicks(9841), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Metal Ball" },
                    { 34, new DateTimeOffset(new DateTime(2023, 12, 13, 22, 30, 45, 365, DateTimeKind.Unspecified).AddTicks(4605), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Fresh Pants" },
                    { 35, new DateTimeOffset(new DateTime(2023, 1, 21, 4, 41, 40, 744, DateTimeKind.Unspecified).AddTicks(122), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Soft Ball" },
                    { 36, new DateTimeOffset(new DateTime(2023, 7, 11, 14, 2, 25, 942, DateTimeKind.Unspecified).AddTicks(4639), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Steel Salad" },
                    { 37, new DateTimeOffset(new DateTime(2023, 5, 20, 22, 42, 42, 587, DateTimeKind.Unspecified).AddTicks(383), new TimeSpan(0, 1, 0, 0, 0)), "Small Rubber Pants" },
                    { 38, new DateTimeOffset(new DateTime(2023, 5, 23, 15, 6, 15, 333, DateTimeKind.Unspecified).AddTicks(6040), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Granite Mouse" },
                    { 39, new DateTimeOffset(new DateTime(2023, 12, 13, 17, 3, 43, 333, DateTimeKind.Unspecified).AddTicks(2784), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Steel Sausages" },
                    { 40, new DateTimeOffset(new DateTime(2023, 5, 11, 6, 12, 31, 608, DateTimeKind.Unspecified).AddTicks(4341), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Concrete Fish" },
                    { 41, new DateTimeOffset(new DateTime(2023, 9, 10, 14, 26, 21, 978, DateTimeKind.Unspecified).AddTicks(6505), new TimeSpan(0, 1, 0, 0, 0)), "Generic Fresh Fish" },
                    { 42, new DateTimeOffset(new DateTime(2023, 8, 2, 15, 48, 19, 822, DateTimeKind.Unspecified).AddTicks(9498), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Granite Soap" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreationDate", "Name" },
                values: new object[,]
                {
                    { 43, new DateTimeOffset(new DateTime(2023, 1, 25, 13, 12, 2, 949, DateTimeKind.Unspecified).AddTicks(1632), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Soft Shoes" },
                    { 44, new DateTimeOffset(new DateTime(2023, 4, 2, 6, 26, 41, 828, DateTimeKind.Unspecified).AddTicks(4456), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Steel Shirt" },
                    { 45, new DateTimeOffset(new DateTime(2023, 10, 12, 2, 58, 44, 545, DateTimeKind.Unspecified).AddTicks(410), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Frozen Table" },
                    { 46, new DateTimeOffset(new DateTime(2023, 8, 18, 11, 44, 26, 721, DateTimeKind.Unspecified).AddTicks(7866), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Fresh Keyboard" },
                    { 47, new DateTimeOffset(new DateTime(2023, 4, 5, 12, 35, 30, 730, DateTimeKind.Unspecified).AddTicks(7169), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Frozen Sausages" },
                    { 48, new DateTimeOffset(new DateTime(2023, 1, 18, 21, 20, 56, 159, DateTimeKind.Unspecified).AddTicks(1727), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Granite Fish" },
                    { 49, new DateTimeOffset(new DateTime(2023, 11, 11, 9, 16, 34, 288, DateTimeKind.Unspecified).AddTicks(9173), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Frozen Shirt" },
                    { 50, new DateTimeOffset(new DateTime(2023, 8, 6, 23, 28, 45, 387, DateTimeKind.Unspecified).AddTicks(7450), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Concrete Bacon" },
                    { 51, new DateTimeOffset(new DateTime(2023, 12, 19, 14, 10, 21, 733, DateTimeKind.Unspecified).AddTicks(4059), new TimeSpan(0, 1, 0, 0, 0)), "Small Soft Keyboard" },
                    { 52, new DateTimeOffset(new DateTime(2023, 9, 20, 20, 39, 17, 797, DateTimeKind.Unspecified).AddTicks(7480), new TimeSpan(0, 1, 0, 0, 0)), "Small Wooden Computer" },
                    { 53, new DateTimeOffset(new DateTime(2023, 3, 19, 13, 5, 43, 242, DateTimeKind.Unspecified).AddTicks(8741), new TimeSpan(0, 1, 0, 0, 0)), "Generic Metal Pants" },
                    { 54, new DateTimeOffset(new DateTime(2023, 11, 3, 3, 24, 43, 125, DateTimeKind.Unspecified).AddTicks(4433), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Frozen Mouse" },
                    { 55, new DateTimeOffset(new DateTime(2023, 10, 8, 16, 42, 21, 493, DateTimeKind.Unspecified).AddTicks(6001), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Wooden Computer" },
                    { 56, new DateTimeOffset(new DateTime(2023, 10, 10, 20, 30, 18, 930, DateTimeKind.Unspecified).AddTicks(8255), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Cotton Towels" },
                    { 57, new DateTimeOffset(new DateTime(2023, 5, 4, 9, 51, 15, 411, DateTimeKind.Unspecified).AddTicks(2854), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Granite Sausages" },
                    { 58, new DateTimeOffset(new DateTime(2023, 5, 7, 17, 21, 39, 61, DateTimeKind.Unspecified).AddTicks(993), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Rubber Pizza" },
                    { 59, new DateTimeOffset(new DateTime(2023, 5, 6, 6, 19, 33, 822, DateTimeKind.Unspecified).AddTicks(5996), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Fresh Fish" },
                    { 60, new DateTimeOffset(new DateTime(2023, 6, 4, 7, 8, 25, 372, DateTimeKind.Unspecified).AddTicks(8638), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Concrete Towels" },
                    { 61, new DateTimeOffset(new DateTime(2023, 4, 20, 12, 54, 3, 646, DateTimeKind.Unspecified).AddTicks(2259), new TimeSpan(0, 1, 0, 0, 0)), "Refined Concrete Towels" },
                    { 62, new DateTimeOffset(new DateTime(2023, 2, 12, 17, 20, 59, 156, DateTimeKind.Unspecified).AddTicks(5883), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Rubber Ball" },
                    { 63, new DateTimeOffset(new DateTime(2023, 3, 31, 9, 55, 26, 388, DateTimeKind.Unspecified).AddTicks(3188), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Rubber Car" },
                    { 64, new DateTimeOffset(new DateTime(2023, 9, 2, 23, 33, 22, 338, DateTimeKind.Unspecified).AddTicks(2043), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Wooden Chips" },
                    { 65, new DateTimeOffset(new DateTime(2023, 8, 13, 0, 26, 0, 509, DateTimeKind.Unspecified).AddTicks(6494), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Cotton Sausages" },
                    { 66, new DateTimeOffset(new DateTime(2023, 1, 30, 13, 18, 12, 922, DateTimeKind.Unspecified).AddTicks(4131), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Soft Chair" },
                    { 67, new DateTimeOffset(new DateTime(2023, 11, 18, 2, 6, 6, 924, DateTimeKind.Unspecified).AddTicks(9106), new TimeSpan(0, 1, 0, 0, 0)), "Refined Steel Chips" },
                    { 68, new DateTimeOffset(new DateTime(2023, 8, 4, 8, 24, 15, 574, DateTimeKind.Unspecified).AddTicks(2164), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Fresh Computer" },
                    { 69, new DateTimeOffset(new DateTime(2023, 5, 8, 22, 3, 37, 114, DateTimeKind.Unspecified).AddTicks(5047), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Soft Salad" },
                    { 70, new DateTimeOffset(new DateTime(2023, 6, 17, 4, 59, 41, 630, DateTimeKind.Unspecified).AddTicks(9682), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Plastic Soap" },
                    { 71, new DateTimeOffset(new DateTime(2023, 2, 7, 8, 37, 34, 365, DateTimeKind.Unspecified).AddTicks(7400), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Fresh Hat" },
                    { 72, new DateTimeOffset(new DateTime(2023, 2, 16, 19, 11, 33, 157, DateTimeKind.Unspecified).AddTicks(3010), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Metal Keyboard" },
                    { 73, new DateTimeOffset(new DateTime(2023, 4, 25, 15, 13, 0, 973, DateTimeKind.Unspecified).AddTicks(3673), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Wooden Car" },
                    { 74, new DateTimeOffset(new DateTime(2023, 1, 30, 14, 2, 56, 990, DateTimeKind.Unspecified).AddTicks(5353), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Frozen Mouse" },
                    { 75, new DateTimeOffset(new DateTime(2023, 2, 11, 20, 34, 12, 742, DateTimeKind.Unspecified).AddTicks(5527), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Granite Shirt" },
                    { 76, new DateTimeOffset(new DateTime(2023, 11, 25, 18, 26, 24, 709, DateTimeKind.Unspecified).AddTicks(1460), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Cotton Bacon" },
                    { 77, new DateTimeOffset(new DateTime(2023, 6, 12, 17, 0, 53, 687, DateTimeKind.Unspecified).AddTicks(5680), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Granite Soap" },
                    { 78, new DateTimeOffset(new DateTime(2023, 12, 26, 14, 53, 41, 863, DateTimeKind.Unspecified).AddTicks(1783), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Metal Bacon" },
                    { 79, new DateTimeOffset(new DateTime(2023, 5, 11, 11, 25, 2, 418, DateTimeKind.Unspecified).AddTicks(229), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Granite Shirt" },
                    { 80, new DateTimeOffset(new DateTime(2023, 3, 27, 22, 49, 13, 833, DateTimeKind.Unspecified).AddTicks(4780), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Frozen Hat" },
                    { 81, new DateTimeOffset(new DateTime(2023, 3, 17, 11, 24, 4, 724, DateTimeKind.Unspecified).AddTicks(1093), new TimeSpan(0, 1, 0, 0, 0)), "Refined Fresh Sausages" },
                    { 82, new DateTimeOffset(new DateTime(2023, 8, 21, 11, 14, 54, 149, DateTimeKind.Unspecified).AddTicks(7870), new TimeSpan(0, 1, 0, 0, 0)), "Refined Fresh Ball" },
                    { 83, new DateTimeOffset(new DateTime(2023, 4, 18, 0, 13, 49, 506, DateTimeKind.Unspecified).AddTicks(3318), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Fresh Car" },
                    { 84, new DateTimeOffset(new DateTime(2023, 10, 16, 14, 45, 43, 771, DateTimeKind.Unspecified).AddTicks(1022), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Granite Pizza" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreationDate", "Name" },
                values: new object[,]
                {
                    { 85, new DateTimeOffset(new DateTime(2023, 1, 24, 15, 5, 39, 973, DateTimeKind.Unspecified).AddTicks(2244), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Metal Towels" },
                    { 86, new DateTimeOffset(new DateTime(2023, 4, 9, 10, 53, 5, 263, DateTimeKind.Unspecified).AddTicks(214), new TimeSpan(0, 1, 0, 0, 0)), "Small Soft Salad" },
                    { 87, new DateTimeOffset(new DateTime(2023, 10, 19, 6, 3, 26, 286, DateTimeKind.Unspecified).AddTicks(245), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Wooden Shoes" },
                    { 88, new DateTimeOffset(new DateTime(2023, 4, 28, 3, 42, 18, 14, DateTimeKind.Unspecified).AddTicks(290), new TimeSpan(0, 1, 0, 0, 0)), "Generic Fresh Cheese" },
                    { 89, new DateTimeOffset(new DateTime(2023, 9, 19, 13, 33, 37, 214, DateTimeKind.Unspecified).AddTicks(9660), new TimeSpan(0, 1, 0, 0, 0)), "Small Concrete Mouse" },
                    { 90, new DateTimeOffset(new DateTime(2023, 9, 6, 22, 43, 31, 258, DateTimeKind.Unspecified).AddTicks(1483), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Metal Chair" },
                    { 91, new DateTimeOffset(new DateTime(2023, 5, 27, 11, 12, 38, 537, DateTimeKind.Unspecified).AddTicks(8490), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Steel Pizza" },
                    { 92, new DateTimeOffset(new DateTime(2023, 4, 18, 10, 13, 13, 287, DateTimeKind.Unspecified).AddTicks(7426), new TimeSpan(0, 1, 0, 0, 0)), "Generic Rubber Chair" },
                    { 93, new DateTimeOffset(new DateTime(2023, 8, 17, 3, 59, 29, 284, DateTimeKind.Unspecified).AddTicks(1550), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Metal Bike" },
                    { 94, new DateTimeOffset(new DateTime(2023, 2, 27, 20, 15, 29, 91, DateTimeKind.Unspecified).AddTicks(1535), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Granite Keyboard" },
                    { 95, new DateTimeOffset(new DateTime(2023, 10, 13, 19, 32, 36, 398, DateTimeKind.Unspecified).AddTicks(1665), new TimeSpan(0, 1, 0, 0, 0)), "Small Metal Salad" },
                    { 96, new DateTimeOffset(new DateTime(2023, 9, 23, 13, 6, 46, 166, DateTimeKind.Unspecified).AddTicks(6527), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Granite Chips" },
                    { 97, new DateTimeOffset(new DateTime(2023, 9, 27, 21, 40, 6, 516, DateTimeKind.Unspecified).AddTicks(6834), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Soft Bike" },
                    { 98, new DateTimeOffset(new DateTime(2023, 6, 21, 12, 47, 53, 432, DateTimeKind.Unspecified).AddTicks(8244), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Wooden Bike" },
                    { 99, new DateTimeOffset(new DateTime(2023, 1, 22, 10, 33, 44, 65, DateTimeKind.Unspecified).AddTicks(948), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Frozen Cheese" },
                    { 100, new DateTimeOffset(new DateTime(2023, 9, 23, 13, 39, 41, 282, DateTimeKind.Unspecified).AddTicks(4744), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Granite Soap" },
                    { 101, new DateTimeOffset(new DateTime(2024, 1, 2, 11, 10, 45, 300, DateTimeKind.Unspecified).AddTicks(4828), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Concrete Car" },
                    { 102, new DateTimeOffset(new DateTime(2023, 8, 9, 2, 54, 43, 413, DateTimeKind.Unspecified).AddTicks(2971), new TimeSpan(0, 1, 0, 0, 0)), "Generic Concrete Salad" },
                    { 103, new DateTimeOffset(new DateTime(2023, 11, 6, 10, 24, 1, 871, DateTimeKind.Unspecified).AddTicks(687), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Steel Tuna" },
                    { 104, new DateTimeOffset(new DateTime(2023, 10, 8, 4, 31, 42, 933, DateTimeKind.Unspecified).AddTicks(1326), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Concrete Ball" },
                    { 105, new DateTimeOffset(new DateTime(2023, 11, 12, 3, 46, 18, 592, DateTimeKind.Unspecified).AddTicks(442), new TimeSpan(0, 1, 0, 0, 0)), "Small Wooden Ball" },
                    { 106, new DateTimeOffset(new DateTime(2023, 7, 26, 23, 52, 16, 482, DateTimeKind.Unspecified).AddTicks(1638), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Plastic Salad" },
                    { 107, new DateTimeOffset(new DateTime(2023, 6, 28, 14, 8, 1, 877, DateTimeKind.Unspecified).AddTicks(7170), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Soft Salad" },
                    { 108, new DateTimeOffset(new DateTime(2023, 7, 20, 14, 26, 50, 698, DateTimeKind.Unspecified).AddTicks(8327), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Wooden Mouse" },
                    { 109, new DateTimeOffset(new DateTime(2023, 3, 9, 12, 9, 53, 64, DateTimeKind.Unspecified).AddTicks(9065), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Concrete Chicken" },
                    { 110, new DateTimeOffset(new DateTime(2023, 12, 3, 19, 48, 7, 390, DateTimeKind.Unspecified).AddTicks(6227), new TimeSpan(0, 1, 0, 0, 0)), "Practical Steel Car" },
                    { 111, new DateTimeOffset(new DateTime(2023, 4, 26, 7, 28, 32, 455, DateTimeKind.Unspecified).AddTicks(3535), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Metal Tuna" },
                    { 112, new DateTimeOffset(new DateTime(2023, 6, 12, 6, 2, 7, 507, DateTimeKind.Unspecified).AddTicks(8559), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Cotton Chicken" },
                    { 113, new DateTimeOffset(new DateTime(2023, 10, 16, 9, 51, 34, 226, DateTimeKind.Unspecified).AddTicks(1099), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Steel Chips" },
                    { 114, new DateTimeOffset(new DateTime(2023, 10, 10, 13, 0, 45, 569, DateTimeKind.Unspecified).AddTicks(7752), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Soft Gloves" },
                    { 115, new DateTimeOffset(new DateTime(2023, 11, 8, 21, 24, 57, 842, DateTimeKind.Unspecified).AddTicks(3118), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Granite Towels" },
                    { 116, new DateTimeOffset(new DateTime(2023, 12, 20, 1, 14, 42, 292, DateTimeKind.Unspecified).AddTicks(7166), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Cotton Pizza" },
                    { 117, new DateTimeOffset(new DateTime(2023, 7, 31, 20, 35, 13, 318, DateTimeKind.Unspecified).AddTicks(7682), new TimeSpan(0, 1, 0, 0, 0)), "Refined Wooden Fish" },
                    { 118, new DateTimeOffset(new DateTime(2023, 1, 16, 18, 16, 36, 619, DateTimeKind.Unspecified).AddTicks(344), new TimeSpan(0, 1, 0, 0, 0)), "Generic Wooden Ball" },
                    { 119, new DateTimeOffset(new DateTime(2023, 10, 8, 11, 6, 51, 166, DateTimeKind.Unspecified).AddTicks(2468), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Cotton Sausages" },
                    { 120, new DateTimeOffset(new DateTime(2024, 1, 2, 21, 3, 3, 904, DateTimeKind.Unspecified).AddTicks(3566), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Rubber Chair" },
                    { 121, new DateTimeOffset(new DateTime(2023, 9, 9, 1, 40, 32, 609, DateTimeKind.Unspecified).AddTicks(7559), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Granite Cheese" },
                    { 122, new DateTimeOffset(new DateTime(2023, 5, 3, 8, 9, 5, 42, DateTimeKind.Unspecified).AddTicks(8844), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Granite Ball" },
                    { 123, new DateTimeOffset(new DateTime(2023, 12, 11, 16, 6, 26, 179, DateTimeKind.Unspecified).AddTicks(4799), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Frozen Bacon" },
                    { 124, new DateTimeOffset(new DateTime(2023, 6, 29, 10, 31, 57, 555, DateTimeKind.Unspecified).AddTicks(6745), new TimeSpan(0, 1, 0, 0, 0)), "Practical Concrete Soap" },
                    { 125, new DateTimeOffset(new DateTime(2023, 6, 2, 14, 11, 15, 630, DateTimeKind.Unspecified).AddTicks(9208), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Metal Shirt" },
                    { 126, new DateTimeOffset(new DateTime(2023, 7, 31, 1, 35, 2, 175, DateTimeKind.Unspecified).AddTicks(2173), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Wooden Bacon" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreationDate", "Name" },
                values: new object[,]
                {
                    { 127, new DateTimeOffset(new DateTime(2023, 11, 15, 7, 42, 44, 502, DateTimeKind.Unspecified).AddTicks(9955), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Frozen Tuna" },
                    { 128, new DateTimeOffset(new DateTime(2023, 9, 27, 14, 46, 43, 641, DateTimeKind.Unspecified).AddTicks(9503), new TimeSpan(0, 1, 0, 0, 0)), "Refined Rubber Chair" },
                    { 129, new DateTimeOffset(new DateTime(2023, 10, 25, 12, 21, 38, 471, DateTimeKind.Unspecified).AddTicks(4609), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Rubber Chicken" },
                    { 130, new DateTimeOffset(new DateTime(2023, 6, 18, 15, 53, 38, 663, DateTimeKind.Unspecified).AddTicks(5058), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Concrete Cheese" },
                    { 131, new DateTimeOffset(new DateTime(2023, 9, 15, 14, 22, 23, 739, DateTimeKind.Unspecified).AddTicks(3472), new TimeSpan(0, 1, 0, 0, 0)), "Refined Cotton Tuna" },
                    { 132, new DateTimeOffset(new DateTime(2023, 11, 26, 16, 20, 51, 272, DateTimeKind.Unspecified).AddTicks(7562), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Cotton Hat" },
                    { 133, new DateTimeOffset(new DateTime(2024, 1, 12, 13, 53, 56, 316, DateTimeKind.Unspecified).AddTicks(7830), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Granite Sausages" },
                    { 134, new DateTimeOffset(new DateTime(2024, 1, 15, 9, 29, 14, 41, DateTimeKind.Unspecified).AddTicks(7873), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Rubber Bike" },
                    { 135, new DateTimeOffset(new DateTime(2023, 3, 19, 3, 41, 45, 510, DateTimeKind.Unspecified).AddTicks(6848), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Concrete Pizza" },
                    { 136, new DateTimeOffset(new DateTime(2023, 5, 11, 21, 49, 18, 513, DateTimeKind.Unspecified).AddTicks(4080), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Cotton Table" },
                    { 137, new DateTimeOffset(new DateTime(2023, 11, 29, 19, 58, 58, 885, DateTimeKind.Unspecified).AddTicks(5000), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Wooden Pants" },
                    { 138, new DateTimeOffset(new DateTime(2023, 8, 14, 9, 9, 18, 139, DateTimeKind.Unspecified).AddTicks(5226), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Fresh Cheese" },
                    { 139, new DateTimeOffset(new DateTime(2023, 5, 3, 7, 26, 27, 780, DateTimeKind.Unspecified).AddTicks(5519), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Frozen Hat" },
                    { 140, new DateTimeOffset(new DateTime(2023, 6, 12, 3, 4, 24, 117, DateTimeKind.Unspecified).AddTicks(4902), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Wooden Bike" },
                    { 141, new DateTimeOffset(new DateTime(2023, 6, 10, 0, 28, 44, 128, DateTimeKind.Unspecified).AddTicks(4764), new TimeSpan(0, 1, 0, 0, 0)), "Practical Soft Chair" },
                    { 142, new DateTimeOffset(new DateTime(2023, 12, 11, 18, 15, 0, 920, DateTimeKind.Unspecified).AddTicks(3782), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Steel Shoes" },
                    { 143, new DateTimeOffset(new DateTime(2023, 6, 19, 7, 55, 21, 788, DateTimeKind.Unspecified).AddTicks(6891), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Metal Car" },
                    { 144, new DateTimeOffset(new DateTime(2023, 6, 20, 21, 8, 36, 35, DateTimeKind.Unspecified).AddTicks(34), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Rubber Soap" },
                    { 145, new DateTimeOffset(new DateTime(2023, 3, 26, 17, 53, 53, 827, DateTimeKind.Unspecified).AddTicks(694), new TimeSpan(0, 1, 0, 0, 0)), "Small Plastic Cheese" },
                    { 146, new DateTimeOffset(new DateTime(2024, 1, 9, 20, 26, 18, 410, DateTimeKind.Unspecified).AddTicks(4240), new TimeSpan(0, 1, 0, 0, 0)), "Small Metal Ball" },
                    { 147, new DateTimeOffset(new DateTime(2023, 4, 17, 23, 59, 46, 567, DateTimeKind.Unspecified).AddTicks(2303), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Plastic Car" },
                    { 148, new DateTimeOffset(new DateTime(2023, 8, 12, 17, 20, 1, 161, DateTimeKind.Unspecified).AddTicks(6503), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Frozen Shoes" },
                    { 149, new DateTimeOffset(new DateTime(2023, 1, 29, 13, 50, 56, 889, DateTimeKind.Unspecified).AddTicks(9146), new TimeSpan(0, 1, 0, 0, 0)), "Small Granite Fish" },
                    { 150, new DateTimeOffset(new DateTime(2023, 11, 29, 15, 47, 44, 459, DateTimeKind.Unspecified).AddTicks(9149), new TimeSpan(0, 1, 0, 0, 0)), "Practical Steel Chicken" },
                    { 151, new DateTimeOffset(new DateTime(2023, 12, 8, 19, 35, 9, 562, DateTimeKind.Unspecified).AddTicks(2120), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Granite Hat" },
                    { 152, new DateTimeOffset(new DateTime(2023, 5, 19, 3, 33, 11, 748, DateTimeKind.Unspecified).AddTicks(1524), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Plastic Bike" },
                    { 153, new DateTimeOffset(new DateTime(2023, 3, 24, 8, 43, 46, 18, DateTimeKind.Unspecified).AddTicks(3210), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Steel Ball" },
                    { 154, new DateTimeOffset(new DateTime(2023, 11, 1, 2, 7, 11, 455, DateTimeKind.Unspecified).AddTicks(6006), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Steel Shirt" },
                    { 155, new DateTimeOffset(new DateTime(2023, 5, 1, 7, 35, 20, 286, DateTimeKind.Unspecified).AddTicks(7767), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Steel Chicken" },
                    { 156, new DateTimeOffset(new DateTime(2023, 6, 13, 3, 27, 20, 201, DateTimeKind.Unspecified).AddTicks(2761), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Concrete Cheese" },
                    { 157, new DateTimeOffset(new DateTime(2023, 12, 4, 7, 59, 55, 29, DateTimeKind.Unspecified).AddTicks(7741), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Granite Shirt" },
                    { 158, new DateTimeOffset(new DateTime(2024, 1, 8, 13, 58, 12, 400, DateTimeKind.Unspecified).AddTicks(8095), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Rubber Chair" },
                    { 159, new DateTimeOffset(new DateTime(2023, 8, 4, 8, 9, 44, 425, DateTimeKind.Unspecified).AddTicks(486), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Fresh Hat" },
                    { 160, new DateTimeOffset(new DateTime(2023, 5, 17, 21, 39, 9, 771, DateTimeKind.Unspecified).AddTicks(5074), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Cotton Bike" },
                    { 161, new DateTimeOffset(new DateTime(2023, 2, 1, 23, 26, 41, 525, DateTimeKind.Unspecified).AddTicks(4918), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Metal Salad" },
                    { 162, new DateTimeOffset(new DateTime(2024, 1, 12, 2, 33, 57, 189, DateTimeKind.Unspecified).AddTicks(362), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Plastic Mouse" },
                    { 163, new DateTimeOffset(new DateTime(2023, 6, 4, 9, 51, 51, 36, DateTimeKind.Unspecified).AddTicks(2380), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Frozen Towels" },
                    { 164, new DateTimeOffset(new DateTime(2023, 6, 26, 6, 53, 52, 968, DateTimeKind.Unspecified).AddTicks(601), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Cotton Salad" },
                    { 165, new DateTimeOffset(new DateTime(2023, 4, 24, 12, 24, 12, 88, DateTimeKind.Unspecified).AddTicks(7327), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Wooden Fish" },
                    { 166, new DateTimeOffset(new DateTime(2023, 11, 7, 1, 0, 0, 308, DateTimeKind.Unspecified).AddTicks(4033), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Plastic Table" },
                    { 167, new DateTimeOffset(new DateTime(2023, 7, 17, 11, 59, 5, 153, DateTimeKind.Unspecified).AddTicks(5140), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Plastic Hat" },
                    { 168, new DateTimeOffset(new DateTime(2023, 2, 20, 19, 54, 14, 217, DateTimeKind.Unspecified).AddTicks(7219), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Fresh Tuna" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreationDate", "Name" },
                values: new object[,]
                {
                    { 169, new DateTimeOffset(new DateTime(2023, 4, 28, 6, 34, 38, 288, DateTimeKind.Unspecified).AddTicks(2634), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Cotton Keyboard" },
                    { 170, new DateTimeOffset(new DateTime(2023, 12, 2, 0, 51, 15, 198, DateTimeKind.Unspecified).AddTicks(3967), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Soft Fish" },
                    { 171, new DateTimeOffset(new DateTime(2024, 1, 2, 16, 28, 4, 275, DateTimeKind.Unspecified).AddTicks(6784), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Cotton Bacon" },
                    { 172, new DateTimeOffset(new DateTime(2023, 4, 26, 9, 4, 21, 699, DateTimeKind.Unspecified).AddTicks(1670), new TimeSpan(0, 1, 0, 0, 0)), "Small Rubber Tuna" },
                    { 173, new DateTimeOffset(new DateTime(2023, 1, 31, 7, 33, 53, 699, DateTimeKind.Unspecified).AddTicks(347), new TimeSpan(0, 1, 0, 0, 0)), "Small Wooden Pizza" },
                    { 174, new DateTimeOffset(new DateTime(2023, 10, 31, 9, 10, 4, 550, DateTimeKind.Unspecified).AddTicks(2143), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Frozen Pants" },
                    { 175, new DateTimeOffset(new DateTime(2023, 5, 25, 16, 29, 53, 455, DateTimeKind.Unspecified).AddTicks(2914), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Steel Chips" },
                    { 176, new DateTimeOffset(new DateTime(2023, 4, 11, 9, 12, 24, 69, DateTimeKind.Unspecified).AddTicks(5140), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Metal Shoes" },
                    { 177, new DateTimeOffset(new DateTime(2023, 12, 30, 15, 22, 6, 283, DateTimeKind.Unspecified).AddTicks(3046), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Cotton Towels" },
                    { 178, new DateTimeOffset(new DateTime(2024, 1, 1, 14, 36, 9, 513, DateTimeKind.Unspecified).AddTicks(9472), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Rubber Computer" },
                    { 179, new DateTimeOffset(new DateTime(2023, 8, 5, 11, 49, 30, 951, DateTimeKind.Unspecified).AddTicks(9210), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Fresh Chips" },
                    { 180, new DateTimeOffset(new DateTime(2023, 6, 30, 22, 39, 15, 152, DateTimeKind.Unspecified).AddTicks(9591), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Granite Cheese" },
                    { 181, new DateTimeOffset(new DateTime(2023, 6, 14, 13, 32, 26, 235, DateTimeKind.Unspecified).AddTicks(8297), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Concrete Shoes" },
                    { 182, new DateTimeOffset(new DateTime(2023, 11, 30, 3, 10, 53, 877, DateTimeKind.Unspecified).AddTicks(1144), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Rubber Shirt" },
                    { 183, new DateTimeOffset(new DateTime(2023, 4, 26, 0, 41, 41, 99, DateTimeKind.Unspecified).AddTicks(9212), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Cotton Chair" },
                    { 184, new DateTimeOffset(new DateTime(2023, 8, 30, 20, 56, 59, 671, DateTimeKind.Unspecified).AddTicks(9727), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Cotton Computer" },
                    { 185, new DateTimeOffset(new DateTime(2023, 8, 15, 2, 28, 9, 977, DateTimeKind.Unspecified).AddTicks(791), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Rubber Chicken" },
                    { 186, new DateTimeOffset(new DateTime(2023, 6, 15, 6, 32, 30, 728, DateTimeKind.Unspecified).AddTicks(621), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Metal Car" },
                    { 187, new DateTimeOffset(new DateTime(2023, 11, 24, 0, 43, 57, 402, DateTimeKind.Unspecified).AddTicks(3805), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Fresh Chicken" },
                    { 188, new DateTimeOffset(new DateTime(2023, 10, 28, 4, 15, 6, 419, DateTimeKind.Unspecified).AddTicks(9293), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Fresh Bike" },
                    { 189, new DateTimeOffset(new DateTime(2023, 7, 27, 6, 52, 33, 80, DateTimeKind.Unspecified).AddTicks(604), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Granite Chicken" },
                    { 190, new DateTimeOffset(new DateTime(2023, 9, 23, 4, 38, 26, 885, DateTimeKind.Unspecified).AddTicks(757), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Steel Bike" },
                    { 191, new DateTimeOffset(new DateTime(2023, 11, 27, 23, 33, 11, 436, DateTimeKind.Unspecified).AddTicks(9558), new TimeSpan(0, 1, 0, 0, 0)), "Small Metal Sausages" },
                    { 192, new DateTimeOffset(new DateTime(2024, 1, 9, 22, 56, 12, 590, DateTimeKind.Unspecified).AddTicks(1688), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Fresh Mouse" },
                    { 193, new DateTimeOffset(new DateTime(2024, 1, 4, 9, 9, 41, 734, DateTimeKind.Unspecified).AddTicks(4057), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Plastic Tuna" },
                    { 194, new DateTimeOffset(new DateTime(2023, 12, 31, 6, 23, 40, 972, DateTimeKind.Unspecified).AddTicks(4159), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Concrete Shirt" },
                    { 195, new DateTimeOffset(new DateTime(2023, 2, 16, 21, 56, 3, 919, DateTimeKind.Unspecified).AddTicks(6985), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Steel Shirt" },
                    { 196, new DateTimeOffset(new DateTime(2023, 3, 23, 4, 42, 9, 757, DateTimeKind.Unspecified).AddTicks(2525), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Rubber Salad" },
                    { 197, new DateTimeOffset(new DateTime(2023, 4, 17, 5, 39, 54, 88, DateTimeKind.Unspecified).AddTicks(913), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Concrete Chips" },
                    { 198, new DateTimeOffset(new DateTime(2023, 11, 21, 15, 35, 32, 536, DateTimeKind.Unspecified).AddTicks(1436), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Rubber Table" },
                    { 199, new DateTimeOffset(new DateTime(2023, 6, 2, 21, 23, 47, 555, DateTimeKind.Unspecified).AddTicks(5475), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Frozen Hat" },
                    { 200, new DateTimeOffset(new DateTime(2023, 3, 18, 12, 26, 43, 846, DateTimeKind.Unspecified).AddTicks(2681), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Wooden Bacon" },
                    { 201, new DateTimeOffset(new DateTime(2023, 9, 10, 22, 29, 24, 245, DateTimeKind.Unspecified).AddTicks(9246), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Metal Computer" },
                    { 202, new DateTimeOffset(new DateTime(2023, 2, 15, 2, 46, 51, 70, DateTimeKind.Unspecified).AddTicks(532), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Plastic Chips" },
                    { 203, new DateTimeOffset(new DateTime(2023, 2, 28, 21, 39, 3, 715, DateTimeKind.Unspecified).AddTicks(4549), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Soft Gloves" },
                    { 204, new DateTimeOffset(new DateTime(2023, 7, 11, 4, 35, 39, 625, DateTimeKind.Unspecified).AddTicks(3914), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Wooden Cheese" },
                    { 205, new DateTimeOffset(new DateTime(2023, 5, 25, 3, 16, 19, 871, DateTimeKind.Unspecified).AddTicks(414), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Soft Fish" },
                    { 206, new DateTimeOffset(new DateTime(2023, 3, 19, 18, 35, 53, 229, DateTimeKind.Unspecified).AddTicks(5790), new TimeSpan(0, 1, 0, 0, 0)), "Refined Frozen Gloves" },
                    { 207, new DateTimeOffset(new DateTime(2023, 11, 10, 9, 8, 54, 716, DateTimeKind.Unspecified).AddTicks(5557), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Soft Tuna" },
                    { 208, new DateTimeOffset(new DateTime(2023, 1, 27, 8, 7, 37, 545, DateTimeKind.Unspecified).AddTicks(3505), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Steel Mouse" },
                    { 209, new DateTimeOffset(new DateTime(2023, 4, 13, 22, 59, 8, 384, DateTimeKind.Unspecified).AddTicks(5080), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Concrete Shirt" },
                    { 210, new DateTimeOffset(new DateTime(2023, 11, 17, 1, 47, 1, 485, DateTimeKind.Unspecified).AddTicks(2167), new TimeSpan(0, 1, 0, 0, 0)), "Practical Concrete Chips" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreationDate", "Name" },
                values: new object[,]
                {
                    { 211, new DateTimeOffset(new DateTime(2023, 12, 28, 4, 38, 2, 41, DateTimeKind.Unspecified).AddTicks(6377), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Fresh Computer" },
                    { 212, new DateTimeOffset(new DateTime(2023, 3, 17, 22, 11, 17, 77, DateTimeKind.Unspecified).AddTicks(1679), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Plastic Mouse" },
                    { 213, new DateTimeOffset(new DateTime(2024, 1, 6, 19, 49, 35, 830, DateTimeKind.Unspecified).AddTicks(1752), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Steel Towels" },
                    { 214, new DateTimeOffset(new DateTime(2023, 10, 19, 8, 10, 39, 392, DateTimeKind.Unspecified).AddTicks(4833), new TimeSpan(0, 1, 0, 0, 0)), "Practical Granite Gloves" },
                    { 215, new DateTimeOffset(new DateTime(2023, 6, 17, 13, 44, 44, 800, DateTimeKind.Unspecified).AddTicks(2811), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Frozen Fish" },
                    { 216, new DateTimeOffset(new DateTime(2023, 2, 27, 18, 11, 22, 147, DateTimeKind.Unspecified).AddTicks(6360), new TimeSpan(0, 1, 0, 0, 0)), "Generic Wooden Shirt" },
                    { 217, new DateTimeOffset(new DateTime(2023, 6, 17, 18, 20, 58, 838, DateTimeKind.Unspecified).AddTicks(3324), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Plastic Pizza" },
                    { 218, new DateTimeOffset(new DateTime(2023, 8, 16, 18, 55, 4, 347, DateTimeKind.Unspecified).AddTicks(6569), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Granite Chair" },
                    { 219, new DateTimeOffset(new DateTime(2023, 12, 24, 4, 57, 40, 731, DateTimeKind.Unspecified).AddTicks(4027), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Frozen Computer" },
                    { 220, new DateTimeOffset(new DateTime(2023, 8, 29, 11, 6, 50, 103, DateTimeKind.Unspecified).AddTicks(6896), new TimeSpan(0, 1, 0, 0, 0)), "Refined Plastic Salad" },
                    { 221, new DateTimeOffset(new DateTime(2023, 8, 26, 21, 19, 42, 248, DateTimeKind.Unspecified).AddTicks(4893), new TimeSpan(0, 1, 0, 0, 0)), "Generic Granite Towels" },
                    { 222, new DateTimeOffset(new DateTime(2023, 10, 29, 9, 51, 35, 563, DateTimeKind.Unspecified).AddTicks(4191), new TimeSpan(0, 1, 0, 0, 0)), "Practical Concrete Soap" },
                    { 223, new DateTimeOffset(new DateTime(2023, 7, 17, 21, 2, 37, 987, DateTimeKind.Unspecified).AddTicks(2974), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Rubber Pizza" },
                    { 224, new DateTimeOffset(new DateTime(2023, 2, 25, 0, 58, 35, 156, DateTimeKind.Unspecified).AddTicks(5819), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Rubber Mouse" },
                    { 225, new DateTimeOffset(new DateTime(2024, 1, 5, 11, 48, 6, 531, DateTimeKind.Unspecified).AddTicks(9000), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Steel Shirt" },
                    { 226, new DateTimeOffset(new DateTime(2023, 10, 7, 18, 41, 20, 914, DateTimeKind.Unspecified).AddTicks(2230), new TimeSpan(0, 1, 0, 0, 0)), "Practical Soft Shirt" },
                    { 227, new DateTimeOffset(new DateTime(2023, 7, 25, 3, 0, 57, 187, DateTimeKind.Unspecified).AddTicks(3713), new TimeSpan(0, 1, 0, 0, 0)), "Small Frozen Mouse" },
                    { 228, new DateTimeOffset(new DateTime(2023, 2, 4, 12, 26, 26, 449, DateTimeKind.Unspecified).AddTicks(2190), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Cotton Sausages" },
                    { 229, new DateTimeOffset(new DateTime(2023, 3, 18, 16, 42, 47, 847, DateTimeKind.Unspecified).AddTicks(2290), new TimeSpan(0, 1, 0, 0, 0)), "Small Wooden Bacon" },
                    { 230, new DateTimeOffset(new DateTime(2023, 5, 5, 23, 37, 11, 468, DateTimeKind.Unspecified).AddTicks(7258), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Soft Chicken" },
                    { 231, new DateTimeOffset(new DateTime(2023, 3, 13, 1, 54, 33, 87, DateTimeKind.Unspecified).AddTicks(5954), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Steel Shoes" },
                    { 232, new DateTimeOffset(new DateTime(2023, 4, 7, 6, 12, 24, 318, DateTimeKind.Unspecified).AddTicks(7130), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Granite Computer" },
                    { 233, new DateTimeOffset(new DateTime(2023, 11, 12, 4, 40, 29, 901, DateTimeKind.Unspecified).AddTicks(3065), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Frozen Table" },
                    { 234, new DateTimeOffset(new DateTime(2023, 11, 15, 19, 27, 34, 637, DateTimeKind.Unspecified).AddTicks(7431), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Frozen Mouse" },
                    { 235, new DateTimeOffset(new DateTime(2023, 7, 3, 22, 9, 49, 380, DateTimeKind.Unspecified).AddTicks(1582), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Fresh Soap" },
                    { 236, new DateTimeOffset(new DateTime(2023, 7, 29, 16, 39, 1, 243, DateTimeKind.Unspecified).AddTicks(5093), new TimeSpan(0, 1, 0, 0, 0)), "Small Steel Shirt" },
                    { 237, new DateTimeOffset(new DateTime(2023, 6, 5, 7, 32, 53, 385, DateTimeKind.Unspecified).AddTicks(3405), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Soft Shoes" },
                    { 238, new DateTimeOffset(new DateTime(2023, 9, 24, 1, 23, 1, 691, DateTimeKind.Unspecified).AddTicks(2955), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Steel Hat" },
                    { 239, new DateTimeOffset(new DateTime(2023, 5, 27, 20, 32, 36, 65, DateTimeKind.Unspecified).AddTicks(9497), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Wooden Ball" },
                    { 240, new DateTimeOffset(new DateTime(2023, 7, 11, 5, 19, 54, 220, DateTimeKind.Unspecified).AddTicks(5293), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Concrete Car" },
                    { 241, new DateTimeOffset(new DateTime(2023, 6, 12, 8, 0, 26, 840, DateTimeKind.Unspecified).AddTicks(5048), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Frozen Bacon" },
                    { 242, new DateTimeOffset(new DateTime(2023, 2, 15, 11, 34, 0, 2, DateTimeKind.Unspecified).AddTicks(5142), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Wooden Computer" },
                    { 243, new DateTimeOffset(new DateTime(2023, 10, 8, 3, 48, 0, 997, DateTimeKind.Unspecified).AddTicks(6445), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Frozen Car" },
                    { 244, new DateTimeOffset(new DateTime(2023, 8, 28, 0, 21, 55, 788, DateTimeKind.Unspecified).AddTicks(1845), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Concrete Bike" },
                    { 245, new DateTimeOffset(new DateTime(2023, 12, 5, 2, 41, 44, 203, DateTimeKind.Unspecified).AddTicks(8439), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Frozen Table" },
                    { 246, new DateTimeOffset(new DateTime(2023, 9, 28, 1, 24, 24, 113, DateTimeKind.Unspecified).AddTicks(3792), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Metal Shoes" },
                    { 247, new DateTimeOffset(new DateTime(2023, 11, 12, 5, 33, 51, 530, DateTimeKind.Unspecified).AddTicks(8945), new TimeSpan(0, 1, 0, 0, 0)), "Practical Soft Shoes" },
                    { 248, new DateTimeOffset(new DateTime(2023, 11, 24, 9, 48, 0, 208, DateTimeKind.Unspecified).AddTicks(4414), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Soft Towels" },
                    { 249, new DateTimeOffset(new DateTime(2023, 2, 17, 19, 30, 21, 488, DateTimeKind.Unspecified).AddTicks(8599), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Wooden Towels" },
                    { 250, new DateTimeOffset(new DateTime(2023, 8, 20, 2, 8, 4, 4, DateTimeKind.Unspecified).AddTicks(7423), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Frozen Soap" },
                    { 251, new DateTimeOffset(new DateTime(2023, 10, 20, 16, 2, 20, 993, DateTimeKind.Unspecified).AddTicks(2820), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Cotton Table" },
                    { 252, new DateTimeOffset(new DateTime(2023, 3, 4, 4, 3, 59, 910, DateTimeKind.Unspecified).AddTicks(2068), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Soft Shoes" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreationDate", "Name" },
                values: new object[,]
                {
                    { 253, new DateTimeOffset(new DateTime(2023, 5, 8, 16, 16, 58, 938, DateTimeKind.Unspecified).AddTicks(4299), new TimeSpan(0, 1, 0, 0, 0)), "Refined Metal Chicken" },
                    { 254, new DateTimeOffset(new DateTime(2023, 3, 30, 19, 27, 26, 831, DateTimeKind.Unspecified).AddTicks(9114), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Wooden Shirt" },
                    { 255, new DateTimeOffset(new DateTime(2023, 3, 25, 19, 47, 22, 54, DateTimeKind.Unspecified).AddTicks(7591), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Wooden Sausages" },
                    { 256, new DateTimeOffset(new DateTime(2023, 3, 2, 7, 0, 40, 399, DateTimeKind.Unspecified).AddTicks(6464), new TimeSpan(0, 1, 0, 0, 0)), "Generic Plastic Shirt" },
                    { 257, new DateTimeOffset(new DateTime(2023, 2, 25, 0, 50, 12, 529, DateTimeKind.Unspecified).AddTicks(8571), new TimeSpan(0, 1, 0, 0, 0)), "Practical Concrete Sausages" },
                    { 258, new DateTimeOffset(new DateTime(2023, 9, 22, 18, 59, 59, 986, DateTimeKind.Unspecified).AddTicks(2063), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Wooden Gloves" },
                    { 259, new DateTimeOffset(new DateTime(2023, 9, 21, 1, 30, 1, 149, DateTimeKind.Unspecified).AddTicks(3303), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Fresh Bike" },
                    { 260, new DateTimeOffset(new DateTime(2023, 9, 9, 10, 1, 40, 325, DateTimeKind.Unspecified).AddTicks(7798), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Metal Cheese" },
                    { 261, new DateTimeOffset(new DateTime(2024, 1, 15, 14, 51, 21, 490, DateTimeKind.Unspecified).AddTicks(9764), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Plastic Sausages" },
                    { 262, new DateTimeOffset(new DateTime(2023, 9, 5, 21, 5, 33, 18, DateTimeKind.Unspecified).AddTicks(1324), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Concrete Car" },
                    { 263, new DateTimeOffset(new DateTime(2023, 3, 23, 3, 54, 49, 175, DateTimeKind.Unspecified).AddTicks(3945), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Plastic Soap" },
                    { 264, new DateTimeOffset(new DateTime(2023, 6, 2, 6, 28, 54, 180, DateTimeKind.Unspecified).AddTicks(6950), new TimeSpan(0, 1, 0, 0, 0)), "Small Cotton Chips" },
                    { 265, new DateTimeOffset(new DateTime(2023, 10, 6, 22, 22, 17, 425, DateTimeKind.Unspecified).AddTicks(5881), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Plastic Gloves" },
                    { 266, new DateTimeOffset(new DateTime(2023, 9, 30, 12, 42, 34, 825, DateTimeKind.Unspecified).AddTicks(7413), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Plastic Shoes" },
                    { 267, new DateTimeOffset(new DateTime(2023, 12, 17, 11, 53, 42, 834, DateTimeKind.Unspecified).AddTicks(9644), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Frozen Sausages" },
                    { 268, new DateTimeOffset(new DateTime(2023, 10, 27, 5, 22, 5, 904, DateTimeKind.Unspecified).AddTicks(1442), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Soft Sausages" },
                    { 269, new DateTimeOffset(new DateTime(2023, 4, 23, 21, 11, 50, 227, DateTimeKind.Unspecified).AddTicks(5129), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Plastic Salad" },
                    { 270, new DateTimeOffset(new DateTime(2023, 3, 21, 21, 34, 22, 882, DateTimeKind.Unspecified).AddTicks(6590), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Cotton Chips" },
                    { 271, new DateTimeOffset(new DateTime(2023, 5, 2, 6, 39, 4, 905, DateTimeKind.Unspecified).AddTicks(4857), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Plastic Shirt" },
                    { 272, new DateTimeOffset(new DateTime(2024, 1, 8, 11, 41, 36, 282, DateTimeKind.Unspecified).AddTicks(5179), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Wooden Tuna" },
                    { 273, new DateTimeOffset(new DateTime(2023, 12, 24, 3, 57, 15, 539, DateTimeKind.Unspecified).AddTicks(6379), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Fresh Chicken" },
                    { 274, new DateTimeOffset(new DateTime(2023, 12, 20, 17, 31, 4, 805, DateTimeKind.Unspecified).AddTicks(4057), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Steel Cheese" },
                    { 275, new DateTimeOffset(new DateTime(2023, 3, 9, 4, 40, 58, 971, DateTimeKind.Unspecified).AddTicks(7986), new TimeSpan(0, 1, 0, 0, 0)), "Refined Concrete Tuna" },
                    { 276, new DateTimeOffset(new DateTime(2024, 1, 1, 13, 11, 7, 662, DateTimeKind.Unspecified).AddTicks(5187), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Wooden Chicken" },
                    { 277, new DateTimeOffset(new DateTime(2023, 10, 14, 15, 50, 7, 855, DateTimeKind.Unspecified).AddTicks(3150), new TimeSpan(0, 1, 0, 0, 0)), "Practical Fresh Bacon" },
                    { 278, new DateTimeOffset(new DateTime(2023, 8, 7, 1, 52, 25, 171, DateTimeKind.Unspecified).AddTicks(89), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Metal Chair" },
                    { 279, new DateTimeOffset(new DateTime(2023, 8, 22, 23, 0, 52, 998, DateTimeKind.Unspecified).AddTicks(4247), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Wooden Towels" },
                    { 280, new DateTimeOffset(new DateTime(2023, 3, 24, 14, 30, 37, 616, DateTimeKind.Unspecified).AddTicks(5720), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Concrete Keyboard" },
                    { 281, new DateTimeOffset(new DateTime(2023, 2, 28, 13, 3, 20, 929, DateTimeKind.Unspecified).AddTicks(3430), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Frozen Chair" },
                    { 282, new DateTimeOffset(new DateTime(2023, 5, 13, 6, 4, 55, 376, DateTimeKind.Unspecified).AddTicks(5894), new TimeSpan(0, 1, 0, 0, 0)), "Small Steel Shirt" },
                    { 283, new DateTimeOffset(new DateTime(2023, 2, 17, 17, 50, 48, 488, DateTimeKind.Unspecified).AddTicks(2637), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Frozen Shirt" },
                    { 284, new DateTimeOffset(new DateTime(2024, 1, 14, 20, 55, 8, 678, DateTimeKind.Unspecified).AddTicks(6499), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Fresh Pizza" },
                    { 285, new DateTimeOffset(new DateTime(2023, 10, 14, 10, 2, 36, 328, DateTimeKind.Unspecified).AddTicks(2924), new TimeSpan(0, 1, 0, 0, 0)), "Generic Granite Pizza" },
                    { 286, new DateTimeOffset(new DateTime(2023, 3, 29, 5, 26, 57, 613, DateTimeKind.Unspecified).AddTicks(4452), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Fresh Shoes" },
                    { 287, new DateTimeOffset(new DateTime(2023, 4, 10, 14, 39, 47, 172, DateTimeKind.Unspecified).AddTicks(4730), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Wooden Soap" },
                    { 288, new DateTimeOffset(new DateTime(2023, 9, 25, 4, 0, 13, 239, DateTimeKind.Unspecified).AddTicks(5392), new TimeSpan(0, 1, 0, 0, 0)), "Practical Wooden Chips" },
                    { 289, new DateTimeOffset(new DateTime(2023, 6, 1, 3, 40, 29, 394, DateTimeKind.Unspecified).AddTicks(3002), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Granite Cheese" },
                    { 290, new DateTimeOffset(new DateTime(2023, 6, 14, 14, 58, 52, 732, DateTimeKind.Unspecified).AddTicks(1421), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Rubber Sausages" },
                    { 291, new DateTimeOffset(new DateTime(2023, 7, 28, 17, 26, 30, 105, DateTimeKind.Unspecified).AddTicks(4270), new TimeSpan(0, 1, 0, 0, 0)), "Practical Granite Mouse" },
                    { 292, new DateTimeOffset(new DateTime(2023, 7, 15, 15, 37, 9, 744, DateTimeKind.Unspecified).AddTicks(1459), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Frozen Bacon" },
                    { 293, new DateTimeOffset(new DateTime(2023, 7, 15, 20, 39, 25, 747, DateTimeKind.Unspecified).AddTicks(5741), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Rubber Chips" },
                    { 294, new DateTimeOffset(new DateTime(2023, 7, 6, 11, 56, 11, 505, DateTimeKind.Unspecified).AddTicks(9746), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Cotton Pizza" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreationDate", "Name" },
                values: new object[,]
                {
                    { 295, new DateTimeOffset(new DateTime(2023, 12, 4, 9, 58, 18, 474, DateTimeKind.Unspecified).AddTicks(2493), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Fresh Gloves" },
                    { 296, new DateTimeOffset(new DateTime(2023, 6, 3, 14, 34, 58, 516, DateTimeKind.Unspecified).AddTicks(1025), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Wooden Pizza" },
                    { 297, new DateTimeOffset(new DateTime(2023, 4, 28, 23, 0, 0, 96, DateTimeKind.Unspecified).AddTicks(3579), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Metal Chips" },
                    { 298, new DateTimeOffset(new DateTime(2023, 1, 31, 8, 48, 36, 603, DateTimeKind.Unspecified).AddTicks(1059), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Granite Pizza" },
                    { 299, new DateTimeOffset(new DateTime(2023, 11, 8, 20, 15, 12, 414, DateTimeKind.Unspecified).AddTicks(1971), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Granite Gloves" },
                    { 300, new DateTimeOffset(new DateTime(2023, 11, 25, 21, 30, 9, 631, DateTimeKind.Unspecified).AddTicks(8499), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Frozen Salad" },
                    { 301, new DateTimeOffset(new DateTime(2023, 12, 5, 11, 36, 48, 933, DateTimeKind.Unspecified).AddTicks(3622), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Wooden Sausages" },
                    { 302, new DateTimeOffset(new DateTime(2023, 10, 3, 15, 11, 38, 980, DateTimeKind.Unspecified).AddTicks(3701), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Granite Pants" },
                    { 303, new DateTimeOffset(new DateTime(2023, 5, 9, 21, 40, 13, 867, DateTimeKind.Unspecified).AddTicks(9612), new TimeSpan(0, 1, 0, 0, 0)), "Generic Plastic Salad" },
                    { 304, new DateTimeOffset(new DateTime(2023, 4, 23, 3, 32, 9, 334, DateTimeKind.Unspecified).AddTicks(5702), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Steel Chips" },
                    { 305, new DateTimeOffset(new DateTime(2023, 8, 28, 12, 27, 4, 668, DateTimeKind.Unspecified).AddTicks(2835), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Fresh Hat" },
                    { 306, new DateTimeOffset(new DateTime(2023, 11, 11, 19, 9, 11, 968, DateTimeKind.Unspecified).AddTicks(7286), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Granite Table" },
                    { 307, new DateTimeOffset(new DateTime(2023, 11, 23, 1, 13, 10, 212, DateTimeKind.Unspecified).AddTicks(9102), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Frozen Chips" },
                    { 308, new DateTimeOffset(new DateTime(2023, 7, 28, 8, 37, 29, 213, DateTimeKind.Unspecified).AddTicks(8066), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Steel Cheese" },
                    { 309, new DateTimeOffset(new DateTime(2023, 5, 7, 3, 56, 45, 189, DateTimeKind.Unspecified).AddTicks(8528), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Granite Hat" },
                    { 310, new DateTimeOffset(new DateTime(2023, 7, 21, 23, 35, 46, 665, DateTimeKind.Unspecified).AddTicks(7659), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Frozen Mouse" },
                    { 311, new DateTimeOffset(new DateTime(2023, 10, 17, 18, 3, 59, 669, DateTimeKind.Unspecified).AddTicks(863), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Concrete Tuna" },
                    { 312, new DateTimeOffset(new DateTime(2023, 7, 11, 11, 54, 53, 657, DateTimeKind.Unspecified).AddTicks(2719), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Rubber Cheese" },
                    { 313, new DateTimeOffset(new DateTime(2023, 11, 30, 7, 33, 32, 598, DateTimeKind.Unspecified).AddTicks(7267), new TimeSpan(0, 1, 0, 0, 0)), "Practical Steel Keyboard" },
                    { 314, new DateTimeOffset(new DateTime(2023, 11, 17, 23, 14, 43, 41, DateTimeKind.Unspecified).AddTicks(4385), new TimeSpan(0, 1, 0, 0, 0)), "Practical Concrete Salad" },
                    { 315, new DateTimeOffset(new DateTime(2023, 4, 5, 16, 17, 0, 608, DateTimeKind.Unspecified).AddTicks(9499), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Wooden Mouse" },
                    { 316, new DateTimeOffset(new DateTime(2023, 8, 11, 12, 59, 20, 476, DateTimeKind.Unspecified).AddTicks(4930), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Granite Tuna" },
                    { 317, new DateTimeOffset(new DateTime(2023, 11, 2, 15, 46, 40, 76, DateTimeKind.Unspecified).AddTicks(1965), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Cotton Pants" },
                    { 318, new DateTimeOffset(new DateTime(2023, 9, 20, 3, 38, 36, 857, DateTimeKind.Unspecified).AddTicks(1114), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Metal Chair" },
                    { 319, new DateTimeOffset(new DateTime(2023, 10, 1, 1, 11, 21, 860, DateTimeKind.Unspecified).AddTicks(881), new TimeSpan(0, 1, 0, 0, 0)), "Generic Steel Ball" },
                    { 320, new DateTimeOffset(new DateTime(2023, 3, 17, 22, 20, 12, 833, DateTimeKind.Unspecified).AddTicks(4656), new TimeSpan(0, 1, 0, 0, 0)), "Refined Metal Bike" },
                    { 321, new DateTimeOffset(new DateTime(2023, 1, 29, 10, 41, 41, 9, DateTimeKind.Unspecified).AddTicks(2391), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Granite Shirt" },
                    { 322, new DateTimeOffset(new DateTime(2023, 9, 18, 8, 44, 48, 478, DateTimeKind.Unspecified).AddTicks(2116), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Fresh Computer" },
                    { 323, new DateTimeOffset(new DateTime(2023, 3, 3, 3, 5, 51, 757, DateTimeKind.Unspecified).AddTicks(4092), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Metal Tuna" },
                    { 324, new DateTimeOffset(new DateTime(2023, 11, 5, 14, 23, 24, 963, DateTimeKind.Unspecified).AddTicks(344), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Frozen Chips" },
                    { 325, new DateTimeOffset(new DateTime(2023, 4, 6, 4, 25, 53, 627, DateTimeKind.Unspecified).AddTicks(6442), new TimeSpan(0, 1, 0, 0, 0)), "Generic Wooden Bike" },
                    { 326, new DateTimeOffset(new DateTime(2023, 10, 24, 8, 44, 54, 612, DateTimeKind.Unspecified).AddTicks(4773), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Frozen Chips" },
                    { 327, new DateTimeOffset(new DateTime(2023, 6, 7, 14, 12, 43, 444, DateTimeKind.Unspecified).AddTicks(7676), new TimeSpan(0, 1, 0, 0, 0)), "Small Granite Ball" },
                    { 328, new DateTimeOffset(new DateTime(2024, 1, 15, 11, 25, 24, 395, DateTimeKind.Unspecified).AddTicks(2523), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Concrete Chips" },
                    { 329, new DateTimeOffset(new DateTime(2023, 1, 28, 18, 29, 50, 655, DateTimeKind.Unspecified).AddTicks(4038), new TimeSpan(0, 1, 0, 0, 0)), "Refined Steel Car" },
                    { 330, new DateTimeOffset(new DateTime(2023, 9, 4, 3, 13, 19, 629, DateTimeKind.Unspecified).AddTicks(2509), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Rubber Chicken" },
                    { 331, new DateTimeOffset(new DateTime(2023, 11, 13, 18, 32, 19, 752, DateTimeKind.Unspecified).AddTicks(404), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Metal Bike" },
                    { 332, new DateTimeOffset(new DateTime(2023, 9, 1, 3, 0, 38, 405, DateTimeKind.Unspecified).AddTicks(6989), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Fresh Pizza" },
                    { 333, new DateTimeOffset(new DateTime(2023, 10, 19, 9, 20, 53, 324, DateTimeKind.Unspecified).AddTicks(3662), new TimeSpan(0, 1, 0, 0, 0)), "Small Granite Car" },
                    { 334, new DateTimeOffset(new DateTime(2023, 3, 18, 19, 34, 37, 106, DateTimeKind.Unspecified).AddTicks(5442), new TimeSpan(0, 1, 0, 0, 0)), "Practical Steel Chips" },
                    { 335, new DateTimeOffset(new DateTime(2023, 6, 12, 22, 55, 12, 740, DateTimeKind.Unspecified).AddTicks(6443), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Rubber Chair" },
                    { 336, new DateTimeOffset(new DateTime(2023, 6, 5, 7, 58, 47, 141, DateTimeKind.Unspecified).AddTicks(7496), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Metal Chicken" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreationDate", "Name" },
                values: new object[,]
                {
                    { 337, new DateTimeOffset(new DateTime(2023, 11, 5, 4, 22, 51, 442, DateTimeKind.Unspecified).AddTicks(1105), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Rubber Bike" },
                    { 338, new DateTimeOffset(new DateTime(2023, 2, 1, 20, 40, 25, 250, DateTimeKind.Unspecified).AddTicks(6913), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Frozen Tuna" },
                    { 339, new DateTimeOffset(new DateTime(2023, 7, 11, 9, 1, 45, 494, DateTimeKind.Unspecified).AddTicks(9448), new TimeSpan(0, 1, 0, 0, 0)), "Practical Rubber Chips" },
                    { 340, new DateTimeOffset(new DateTime(2023, 2, 27, 4, 41, 30, 536, DateTimeKind.Unspecified).AddTicks(1013), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Wooden Chicken" },
                    { 341, new DateTimeOffset(new DateTime(2023, 7, 17, 4, 57, 18, 653, DateTimeKind.Unspecified).AddTicks(4697), new TimeSpan(0, 1, 0, 0, 0)), "Generic Rubber Pants" },
                    { 342, new DateTimeOffset(new DateTime(2023, 11, 26, 8, 2, 17, 339, DateTimeKind.Unspecified).AddTicks(405), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Concrete Hat" },
                    { 343, new DateTimeOffset(new DateTime(2023, 7, 26, 10, 25, 36, 423, DateTimeKind.Unspecified).AddTicks(1), new TimeSpan(0, 1, 0, 0, 0)), "Small Fresh Hat" },
                    { 344, new DateTimeOffset(new DateTime(2023, 7, 27, 19, 45, 12, 762, DateTimeKind.Unspecified).AddTicks(8432), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Plastic Chips" },
                    { 345, new DateTimeOffset(new DateTime(2023, 6, 26, 1, 43, 41, 94, DateTimeKind.Unspecified).AddTicks(1490), new TimeSpan(0, 1, 0, 0, 0)), "Small Fresh Computer" },
                    { 346, new DateTimeOffset(new DateTime(2023, 2, 11, 17, 53, 11, 95, DateTimeKind.Unspecified).AddTicks(8990), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Steel Chicken" },
                    { 347, new DateTimeOffset(new DateTime(2023, 12, 4, 11, 59, 17, 727, DateTimeKind.Unspecified).AddTicks(5758), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Steel Pants" },
                    { 348, new DateTimeOffset(new DateTime(2023, 6, 4, 8, 34, 47, 581, DateTimeKind.Unspecified).AddTicks(1286), new TimeSpan(0, 1, 0, 0, 0)), "Small Granite Shirt" },
                    { 349, new DateTimeOffset(new DateTime(2023, 1, 22, 17, 11, 17, 313, DateTimeKind.Unspecified).AddTicks(5158), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Fresh Cheese" },
                    { 350, new DateTimeOffset(new DateTime(2023, 7, 10, 16, 26, 52, 480, DateTimeKind.Unspecified).AddTicks(7348), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Concrete Ball" },
                    { 351, new DateTimeOffset(new DateTime(2023, 2, 4, 18, 34, 30, 217, DateTimeKind.Unspecified).AddTicks(1948), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Cotton Cheese" },
                    { 352, new DateTimeOffset(new DateTime(2023, 3, 10, 10, 59, 26, 814, DateTimeKind.Unspecified).AddTicks(5630), new TimeSpan(0, 1, 0, 0, 0)), "Practical Wooden Shoes" },
                    { 353, new DateTimeOffset(new DateTime(2023, 12, 19, 6, 13, 8, 721, DateTimeKind.Unspecified).AddTicks(7311), new TimeSpan(0, 1, 0, 0, 0)), "Generic Cotton Shoes" },
                    { 354, new DateTimeOffset(new DateTime(2023, 8, 4, 13, 51, 15, 36, DateTimeKind.Unspecified).AddTicks(5070), new TimeSpan(0, 1, 0, 0, 0)), "Small Concrete Table" },
                    { 355, new DateTimeOffset(new DateTime(2023, 2, 18, 21, 8, 51, 683, DateTimeKind.Unspecified).AddTicks(6411), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Plastic Chicken" },
                    { 356, new DateTimeOffset(new DateTime(2023, 7, 24, 1, 19, 40, 111, DateTimeKind.Unspecified).AddTicks(1778), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Metal Bacon" },
                    { 357, new DateTimeOffset(new DateTime(2023, 9, 20, 0, 27, 4, 258, DateTimeKind.Unspecified).AddTicks(2073), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Wooden Soap" },
                    { 358, new DateTimeOffset(new DateTime(2023, 11, 12, 3, 57, 12, 299, DateTimeKind.Unspecified).AddTicks(198), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Frozen Keyboard" },
                    { 359, new DateTimeOffset(new DateTime(2023, 4, 24, 0, 32, 23, 355, DateTimeKind.Unspecified).AddTicks(3702), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Metal Pants" },
                    { 360, new DateTimeOffset(new DateTime(2023, 9, 21, 12, 44, 43, 49, DateTimeKind.Unspecified).AddTicks(6686), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Rubber Tuna" },
                    { 361, new DateTimeOffset(new DateTime(2023, 8, 28, 0, 28, 19, 539, DateTimeKind.Unspecified).AddTicks(704), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Concrete Ball" },
                    { 362, new DateTimeOffset(new DateTime(2023, 9, 13, 4, 0, 29, 556, DateTimeKind.Unspecified).AddTicks(470), new TimeSpan(0, 1, 0, 0, 0)), "Small Granite Pants" },
                    { 363, new DateTimeOffset(new DateTime(2023, 2, 15, 14, 48, 6, 971, DateTimeKind.Unspecified).AddTicks(1302), new TimeSpan(0, 1, 0, 0, 0)), "Practical Concrete Car" },
                    { 364, new DateTimeOffset(new DateTime(2023, 6, 29, 0, 45, 23, 434, DateTimeKind.Unspecified).AddTicks(7443), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Wooden Soap" },
                    { 365, new DateTimeOffset(new DateTime(2023, 5, 10, 17, 58, 39, 454, DateTimeKind.Unspecified).AddTicks(3676), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Concrete Towels" },
                    { 366, new DateTimeOffset(new DateTime(2023, 9, 5, 10, 17, 37, 373, DateTimeKind.Unspecified).AddTicks(4156), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Soft Tuna" },
                    { 367, new DateTimeOffset(new DateTime(2023, 6, 6, 7, 3, 26, 286, DateTimeKind.Unspecified).AddTicks(2140), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Metal Pants" },
                    { 368, new DateTimeOffset(new DateTime(2023, 5, 11, 10, 50, 22, 303, DateTimeKind.Unspecified).AddTicks(7765), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Concrete Ball" },
                    { 369, new DateTimeOffset(new DateTime(2023, 9, 29, 6, 39, 50, 632, DateTimeKind.Unspecified).AddTicks(4556), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Frozen Hat" },
                    { 370, new DateTimeOffset(new DateTime(2023, 1, 19, 12, 11, 2, 484, DateTimeKind.Unspecified).AddTicks(4857), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Concrete Shoes" },
                    { 371, new DateTimeOffset(new DateTime(2023, 4, 16, 14, 23, 8, 144, DateTimeKind.Unspecified).AddTicks(8195), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Frozen Bike" },
                    { 372, new DateTimeOffset(new DateTime(2023, 6, 12, 3, 13, 49, 625, DateTimeKind.Unspecified).AddTicks(7890), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Steel Gloves" },
                    { 373, new DateTimeOffset(new DateTime(2023, 1, 24, 1, 29, 45, 816, DateTimeKind.Unspecified).AddTicks(802), new TimeSpan(0, 1, 0, 0, 0)), "Small Fresh Chicken" },
                    { 374, new DateTimeOffset(new DateTime(2023, 10, 22, 8, 27, 18, 837, DateTimeKind.Unspecified).AddTicks(6360), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Plastic Keyboard" },
                    { 375, new DateTimeOffset(new DateTime(2023, 6, 5, 10, 55, 16, 798, DateTimeKind.Unspecified).AddTicks(2565), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Metal Gloves" },
                    { 376, new DateTimeOffset(new DateTime(2023, 4, 19, 6, 43, 8, 236, DateTimeKind.Unspecified).AddTicks(5337), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Frozen Fish" },
                    { 377, new DateTimeOffset(new DateTime(2023, 7, 24, 1, 44, 23, 540, DateTimeKind.Unspecified).AddTicks(6700), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Soft Table" },
                    { 378, new DateTimeOffset(new DateTime(2023, 6, 5, 21, 53, 8, 716, DateTimeKind.Unspecified).AddTicks(5449), new TimeSpan(0, 1, 0, 0, 0)), "Generic Fresh Car" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreationDate", "Name" },
                values: new object[,]
                {
                    { 379, new DateTimeOffset(new DateTime(2023, 8, 18, 0, 43, 17, 288, DateTimeKind.Unspecified).AddTicks(9791), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Rubber Hat" },
                    { 380, new DateTimeOffset(new DateTime(2023, 4, 1, 6, 53, 5, 422, DateTimeKind.Unspecified).AddTicks(6330), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Cotton Fish" },
                    { 381, new DateTimeOffset(new DateTime(2023, 1, 25, 13, 6, 39, 377, DateTimeKind.Unspecified).AddTicks(7940), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Frozen Pants" },
                    { 382, new DateTimeOffset(new DateTime(2023, 5, 23, 15, 47, 30, 388, DateTimeKind.Unspecified).AddTicks(7782), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Concrete Bike" },
                    { 383, new DateTimeOffset(new DateTime(2023, 10, 7, 12, 37, 10, 918, DateTimeKind.Unspecified).AddTicks(2644), new TimeSpan(0, 1, 0, 0, 0)), "Refined Soft Mouse" },
                    { 384, new DateTimeOffset(new DateTime(2023, 11, 6, 3, 35, 40, 422, DateTimeKind.Unspecified).AddTicks(5825), new TimeSpan(0, 1, 0, 0, 0)), "Refined Wooden Pizza" },
                    { 385, new DateTimeOffset(new DateTime(2023, 3, 9, 7, 19, 24, 765, DateTimeKind.Unspecified).AddTicks(5458), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Frozen Ball" },
                    { 386, new DateTimeOffset(new DateTime(2023, 3, 17, 0, 50, 4, 279, DateTimeKind.Unspecified).AddTicks(4493), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Soft Cheese" },
                    { 387, new DateTimeOffset(new DateTime(2023, 7, 20, 16, 36, 33, 784, DateTimeKind.Unspecified).AddTicks(1602), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Plastic Bike" },
                    { 388, new DateTimeOffset(new DateTime(2023, 3, 2, 2, 3, 7, 319, DateTimeKind.Unspecified).AddTicks(2462), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Rubber Mouse" },
                    { 389, new DateTimeOffset(new DateTime(2023, 3, 27, 1, 45, 49, 787, DateTimeKind.Unspecified).AddTicks(5569), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Wooden Chair" },
                    { 390, new DateTimeOffset(new DateTime(2023, 10, 12, 14, 55, 4, 115, DateTimeKind.Unspecified).AddTicks(5988), new TimeSpan(0, 1, 0, 0, 0)), "Generic Metal Fish" },
                    { 391, new DateTimeOffset(new DateTime(2023, 11, 30, 9, 35, 53, 824, DateTimeKind.Unspecified).AddTicks(2499), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Steel Tuna" },
                    { 392, new DateTimeOffset(new DateTime(2023, 9, 22, 14, 42, 32, 294, DateTimeKind.Unspecified).AddTicks(8927), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Plastic Hat" },
                    { 393, new DateTimeOffset(new DateTime(2023, 8, 18, 5, 31, 1, 335, DateTimeKind.Unspecified).AddTicks(5593), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Soft Pants" },
                    { 394, new DateTimeOffset(new DateTime(2023, 8, 6, 5, 42, 0, 330, DateTimeKind.Unspecified).AddTicks(5367), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Rubber Towels" },
                    { 395, new DateTimeOffset(new DateTime(2023, 3, 31, 19, 34, 55, 8, DateTimeKind.Unspecified).AddTicks(6398), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Wooden Bike" },
                    { 396, new DateTimeOffset(new DateTime(2023, 5, 3, 21, 9, 31, 476, DateTimeKind.Unspecified).AddTicks(7063), new TimeSpan(0, 1, 0, 0, 0)), "Small Soft Towels" },
                    { 397, new DateTimeOffset(new DateTime(2023, 10, 13, 2, 52, 3, 56, DateTimeKind.Unspecified).AddTicks(8946), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Steel Bacon" },
                    { 398, new DateTimeOffset(new DateTime(2023, 7, 17, 17, 36, 33, 519, DateTimeKind.Unspecified).AddTicks(6558), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Metal Mouse" },
                    { 399, new DateTimeOffset(new DateTime(2023, 8, 16, 19, 54, 6, 201, DateTimeKind.Unspecified).AddTicks(5111), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Granite Tuna" },
                    { 400, new DateTimeOffset(new DateTime(2023, 7, 3, 11, 23, 51, 818, DateTimeKind.Unspecified).AddTicks(2851), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Fresh Table" },
                    { 401, new DateTimeOffset(new DateTime(2023, 2, 1, 15, 51, 27, 837, DateTimeKind.Unspecified).AddTicks(3797), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Rubber Bacon" },
                    { 402, new DateTimeOffset(new DateTime(2023, 5, 9, 20, 22, 15, 461, DateTimeKind.Unspecified).AddTicks(2287), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Rubber Chips" },
                    { 403, new DateTimeOffset(new DateTime(2023, 7, 4, 21, 6, 20, 362, DateTimeKind.Unspecified).AddTicks(7157), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Granite Chair" },
                    { 404, new DateTimeOffset(new DateTime(2023, 10, 22, 16, 36, 53, 182, DateTimeKind.Unspecified).AddTicks(2445), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Rubber Fish" },
                    { 405, new DateTimeOffset(new DateTime(2023, 9, 20, 1, 15, 36, 444, DateTimeKind.Unspecified).AddTicks(5854), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Cotton Gloves" },
                    { 406, new DateTimeOffset(new DateTime(2023, 1, 16, 15, 53, 10, 228, DateTimeKind.Unspecified).AddTicks(5765), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Soft Soap" },
                    { 407, new DateTimeOffset(new DateTime(2023, 8, 28, 3, 32, 16, 650, DateTimeKind.Unspecified).AddTicks(4026), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Fresh Pants" },
                    { 408, new DateTimeOffset(new DateTime(2023, 5, 4, 1, 47, 19, 29, DateTimeKind.Unspecified).AddTicks(4386), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Frozen Table" },
                    { 409, new DateTimeOffset(new DateTime(2023, 6, 29, 0, 6, 59, 563, DateTimeKind.Unspecified).AddTicks(7151), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Soft Table" },
                    { 410, new DateTimeOffset(new DateTime(2023, 12, 30, 13, 23, 30, 767, DateTimeKind.Unspecified).AddTicks(6818), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Granite Computer" },
                    { 411, new DateTimeOffset(new DateTime(2023, 8, 13, 13, 3, 10, 38, DateTimeKind.Unspecified).AddTicks(5552), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Granite Keyboard" },
                    { 412, new DateTimeOffset(new DateTime(2023, 9, 22, 12, 36, 12, 612, DateTimeKind.Unspecified).AddTicks(8072), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Metal Chips" },
                    { 413, new DateTimeOffset(new DateTime(2023, 10, 20, 12, 20, 23, 800, DateTimeKind.Unspecified).AddTicks(7735), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Fresh Car" },
                    { 414, new DateTimeOffset(new DateTime(2023, 1, 17, 5, 35, 49, 180, DateTimeKind.Unspecified).AddTicks(3469), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Soft Sausages" },
                    { 415, new DateTimeOffset(new DateTime(2023, 5, 11, 5, 43, 1, 555, DateTimeKind.Unspecified).AddTicks(2701), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Fresh Shoes" },
                    { 416, new DateTimeOffset(new DateTime(2023, 8, 26, 18, 41, 39, 862, DateTimeKind.Unspecified).AddTicks(7825), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Cotton Pants" },
                    { 417, new DateTimeOffset(new DateTime(2023, 10, 19, 7, 29, 24, 763, DateTimeKind.Unspecified).AddTicks(1768), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Metal Fish" },
                    { 418, new DateTimeOffset(new DateTime(2024, 1, 7, 1, 30, 20, 668, DateTimeKind.Unspecified).AddTicks(1945), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Plastic Pizza" },
                    { 419, new DateTimeOffset(new DateTime(2023, 1, 29, 5, 26, 45, 918, DateTimeKind.Unspecified).AddTicks(5981), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Plastic Soap" },
                    { 420, new DateTimeOffset(new DateTime(2023, 11, 26, 18, 43, 34, 210, DateTimeKind.Unspecified).AddTicks(199), new TimeSpan(0, 1, 0, 0, 0)), "Generic Steel Gloves" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreationDate", "Name" },
                values: new object[,]
                {
                    { 421, new DateTimeOffset(new DateTime(2023, 2, 18, 19, 22, 10, 891, DateTimeKind.Unspecified).AddTicks(5610), new TimeSpan(0, 1, 0, 0, 0)), "Refined Metal Bacon" },
                    { 422, new DateTimeOffset(new DateTime(2024, 1, 3, 1, 56, 14, 738, DateTimeKind.Unspecified).AddTicks(3416), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Metal Chicken" },
                    { 423, new DateTimeOffset(new DateTime(2023, 2, 20, 20, 9, 37, 836, DateTimeKind.Unspecified).AddTicks(7319), new TimeSpan(0, 1, 0, 0, 0)), "Refined Cotton Hat" },
                    { 424, new DateTimeOffset(new DateTime(2023, 9, 29, 12, 21, 50, 540, DateTimeKind.Unspecified).AddTicks(6772), new TimeSpan(0, 1, 0, 0, 0)), "Small Soft Chicken" },
                    { 425, new DateTimeOffset(new DateTime(2024, 1, 3, 20, 51, 27, 568, DateTimeKind.Unspecified).AddTicks(8856), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Rubber Hat" },
                    { 426, new DateTimeOffset(new DateTime(2023, 7, 22, 9, 59, 18, 514, DateTimeKind.Unspecified).AddTicks(9617), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Concrete Towels" },
                    { 427, new DateTimeOffset(new DateTime(2023, 4, 14, 7, 51, 14, 528, DateTimeKind.Unspecified).AddTicks(5938), new TimeSpan(0, 1, 0, 0, 0)), "Small Wooden Shoes" },
                    { 428, new DateTimeOffset(new DateTime(2023, 12, 5, 8, 48, 56, 383, DateTimeKind.Unspecified).AddTicks(831), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Fresh Shirt" },
                    { 429, new DateTimeOffset(new DateTime(2023, 8, 17, 13, 45, 43, 712, DateTimeKind.Unspecified).AddTicks(3736), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Rubber Table" },
                    { 430, new DateTimeOffset(new DateTime(2023, 6, 10, 13, 23, 31, 600, DateTimeKind.Unspecified).AddTicks(9502), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Concrete Fish" },
                    { 431, new DateTimeOffset(new DateTime(2023, 10, 1, 6, 28, 3, 505, DateTimeKind.Unspecified).AddTicks(7737), new TimeSpan(0, 1, 0, 0, 0)), "Small Soft Sausages" },
                    { 432, new DateTimeOffset(new DateTime(2023, 7, 7, 4, 40, 47, 224, DateTimeKind.Unspecified).AddTicks(7289), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Soft Sausages" },
                    { 433, new DateTimeOffset(new DateTime(2023, 2, 10, 1, 39, 10, 13, DateTimeKind.Unspecified).AddTicks(202), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Fresh Salad" },
                    { 434, new DateTimeOffset(new DateTime(2023, 9, 7, 3, 37, 0, 918, DateTimeKind.Unspecified).AddTicks(4243), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Plastic Salad" },
                    { 435, new DateTimeOffset(new DateTime(2023, 10, 29, 8, 10, 54, 115, DateTimeKind.Unspecified).AddTicks(5980), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Plastic Car" },
                    { 436, new DateTimeOffset(new DateTime(2023, 12, 27, 3, 47, 28, 480, DateTimeKind.Unspecified).AddTicks(6211), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Granite Bacon" },
                    { 437, new DateTimeOffset(new DateTime(2023, 6, 22, 14, 27, 27, 96, DateTimeKind.Unspecified).AddTicks(5834), new TimeSpan(0, 1, 0, 0, 0)), "Small Rubber Soap" },
                    { 438, new DateTimeOffset(new DateTime(2023, 12, 10, 23, 0, 37, 674, DateTimeKind.Unspecified).AddTicks(2270), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Wooden Keyboard" },
                    { 439, new DateTimeOffset(new DateTime(2023, 3, 30, 15, 32, 12, 3, DateTimeKind.Unspecified).AddTicks(8174), new TimeSpan(0, 1, 0, 0, 0)), "Refined Wooden Chips" },
                    { 440, new DateTimeOffset(new DateTime(2023, 4, 27, 11, 2, 57, 481, DateTimeKind.Unspecified).AddTicks(4550), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Fresh Fish" },
                    { 441, new DateTimeOffset(new DateTime(2023, 4, 18, 14, 44, 2, 932, DateTimeKind.Unspecified).AddTicks(595), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Steel Soap" },
                    { 442, new DateTimeOffset(new DateTime(2023, 3, 9, 14, 44, 28, 978, DateTimeKind.Unspecified).AddTicks(1866), new TimeSpan(0, 1, 0, 0, 0)), "Small Plastic Pants" },
                    { 443, new DateTimeOffset(new DateTime(2023, 4, 17, 5, 30, 38, 183, DateTimeKind.Unspecified).AddTicks(8442), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Soft Shoes" },
                    { 444, new DateTimeOffset(new DateTime(2023, 8, 1, 18, 40, 31, 959, DateTimeKind.Unspecified).AddTicks(3085), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Frozen Bike" },
                    { 445, new DateTimeOffset(new DateTime(2023, 3, 9, 16, 46, 48, 588, DateTimeKind.Unspecified).AddTicks(3494), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Frozen Chicken" },
                    { 446, new DateTimeOffset(new DateTime(2023, 8, 2, 16, 42, 5, 565, DateTimeKind.Unspecified).AddTicks(4628), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Granite Computer" },
                    { 447, new DateTimeOffset(new DateTime(2023, 6, 21, 22, 41, 31, 541, DateTimeKind.Unspecified).AddTicks(7990), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Frozen Bike" },
                    { 448, new DateTimeOffset(new DateTime(2023, 4, 24, 8, 11, 28, 715, DateTimeKind.Unspecified).AddTicks(5310), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Metal Gloves" },
                    { 449, new DateTimeOffset(new DateTime(2023, 3, 10, 5, 43, 58, 21, DateTimeKind.Unspecified).AddTicks(6305), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Soft Soap" },
                    { 450, new DateTimeOffset(new DateTime(2023, 10, 7, 3, 33, 18, 450, DateTimeKind.Unspecified).AddTicks(5100), new TimeSpan(0, 1, 0, 0, 0)), "Refined Rubber Sausages" },
                    { 451, new DateTimeOffset(new DateTime(2023, 8, 9, 19, 47, 2, 329, DateTimeKind.Unspecified).AddTicks(2978), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Cotton Chicken" },
                    { 452, new DateTimeOffset(new DateTime(2023, 12, 9, 12, 41, 51, 168, DateTimeKind.Unspecified).AddTicks(7662), new TimeSpan(0, 1, 0, 0, 0)), "Generic Fresh Chicken" },
                    { 453, new DateTimeOffset(new DateTime(2023, 5, 17, 11, 32, 5, 509, DateTimeKind.Unspecified).AddTicks(5926), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Cotton Bike" },
                    { 454, new DateTimeOffset(new DateTime(2023, 9, 23, 21, 49, 3, 511, DateTimeKind.Unspecified).AddTicks(8800), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Rubber Computer" },
                    { 455, new DateTimeOffset(new DateTime(2023, 1, 27, 14, 0, 52, 600, DateTimeKind.Unspecified).AddTicks(7855), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Steel Shoes" },
                    { 456, new DateTimeOffset(new DateTime(2023, 1, 30, 15, 50, 20, 266, DateTimeKind.Unspecified).AddTicks(5935), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Frozen Fish" },
                    { 457, new DateTimeOffset(new DateTime(2023, 6, 12, 14, 34, 49, 21, DateTimeKind.Unspecified).AddTicks(1631), new TimeSpan(0, 1, 0, 0, 0)), "Practical Concrete Chicken" },
                    { 458, new DateTimeOffset(new DateTime(2023, 6, 17, 4, 12, 36, 732, DateTimeKind.Unspecified).AddTicks(7910), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Steel Tuna" },
                    { 459, new DateTimeOffset(new DateTime(2023, 9, 28, 14, 20, 52, 222, DateTimeKind.Unspecified).AddTicks(8047), new TimeSpan(0, 1, 0, 0, 0)), "Small Frozen Pizza" },
                    { 460, new DateTimeOffset(new DateTime(2023, 11, 24, 22, 35, 12, 134, DateTimeKind.Unspecified).AddTicks(6030), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Rubber Salad" },
                    { 461, new DateTimeOffset(new DateTime(2024, 1, 9, 7, 42, 9, 343, DateTimeKind.Unspecified).AddTicks(574), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Plastic Towels" },
                    { 462, new DateTimeOffset(new DateTime(2024, 1, 4, 10, 4, 43, 384, DateTimeKind.Unspecified).AddTicks(1714), new TimeSpan(0, 1, 0, 0, 0)), "Practical Frozen Computer" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreationDate", "Name" },
                values: new object[,]
                {
                    { 463, new DateTimeOffset(new DateTime(2023, 11, 17, 11, 45, 48, 333, DateTimeKind.Unspecified).AddTicks(6152), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Frozen Bike" },
                    { 464, new DateTimeOffset(new DateTime(2023, 5, 31, 18, 35, 45, 514, DateTimeKind.Unspecified).AddTicks(304), new TimeSpan(0, 1, 0, 0, 0)), "Small Fresh Tuna" },
                    { 465, new DateTimeOffset(new DateTime(2023, 6, 29, 14, 0, 29, 843, DateTimeKind.Unspecified).AddTicks(4758), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Metal Computer" },
                    { 466, new DateTimeOffset(new DateTime(2023, 11, 5, 12, 1, 12, 453, DateTimeKind.Unspecified).AddTicks(2863), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Plastic Towels" },
                    { 467, new DateTimeOffset(new DateTime(2023, 4, 12, 13, 56, 25, 477, DateTimeKind.Unspecified).AddTicks(7120), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Soft Ball" },
                    { 468, new DateTimeOffset(new DateTime(2023, 5, 29, 3, 19, 18, 642, DateTimeKind.Unspecified).AddTicks(291), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Cotton Salad" },
                    { 469, new DateTimeOffset(new DateTime(2023, 10, 14, 13, 56, 57, 350, DateTimeKind.Unspecified).AddTicks(2006), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Metal Cheese" },
                    { 470, new DateTimeOffset(new DateTime(2023, 7, 8, 8, 16, 40, 420, DateTimeKind.Unspecified).AddTicks(1370), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Soft Towels" },
                    { 471, new DateTimeOffset(new DateTime(2023, 6, 18, 12, 53, 43, 327, DateTimeKind.Unspecified).AddTicks(5672), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Metal Fish" },
                    { 472, new DateTimeOffset(new DateTime(2023, 3, 8, 19, 5, 38, 368, DateTimeKind.Unspecified).AddTicks(363), new TimeSpan(0, 1, 0, 0, 0)), "Refined Fresh Pants" },
                    { 473, new DateTimeOffset(new DateTime(2023, 3, 5, 5, 34, 0, 811, DateTimeKind.Unspecified).AddTicks(2304), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Granite Chips" },
                    { 474, new DateTimeOffset(new DateTime(2024, 1, 4, 1, 15, 55, 782, DateTimeKind.Unspecified).AddTicks(5614), new TimeSpan(0, 1, 0, 0, 0)), "Practical Cotton Tuna" },
                    { 475, new DateTimeOffset(new DateTime(2023, 9, 6, 20, 0, 56, 728, DateTimeKind.Unspecified).AddTicks(2727), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Soft Bike" },
                    { 476, new DateTimeOffset(new DateTime(2023, 4, 14, 10, 52, 36, 433, DateTimeKind.Unspecified).AddTicks(1637), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Fresh Bike" },
                    { 477, new DateTimeOffset(new DateTime(2023, 6, 18, 4, 24, 49, 95, DateTimeKind.Unspecified).AddTicks(4656), new TimeSpan(0, 1, 0, 0, 0)), "Small Fresh Chicken" },
                    { 478, new DateTimeOffset(new DateTime(2023, 12, 28, 3, 40, 28, 650, DateTimeKind.Unspecified).AddTicks(7919), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Fresh Chips" },
                    { 479, new DateTimeOffset(new DateTime(2023, 7, 17, 15, 26, 55, 985, DateTimeKind.Unspecified).AddTicks(2940), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Rubber Pants" },
                    { 480, new DateTimeOffset(new DateTime(2023, 12, 22, 22, 43, 50, 833, DateTimeKind.Unspecified).AddTicks(4193), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Wooden Sausages" },
                    { 481, new DateTimeOffset(new DateTime(2023, 4, 19, 3, 7, 3, 647, DateTimeKind.Unspecified).AddTicks(8259), new TimeSpan(0, 1, 0, 0, 0)), "Practical Wooden Sausages" },
                    { 482, new DateTimeOffset(new DateTime(2023, 9, 29, 6, 37, 23, 238, DateTimeKind.Unspecified).AddTicks(1634), new TimeSpan(0, 1, 0, 0, 0)), "Practical Soft Salad" },
                    { 483, new DateTimeOffset(new DateTime(2023, 9, 4, 6, 6, 17, 100, DateTimeKind.Unspecified).AddTicks(8294), new TimeSpan(0, 1, 0, 0, 0)), "Small Soft Chips" },
                    { 484, new DateTimeOffset(new DateTime(2023, 4, 22, 3, 4, 21, 355, DateTimeKind.Unspecified).AddTicks(1636), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Frozen Cheese" },
                    { 485, new DateTimeOffset(new DateTime(2024, 1, 10, 23, 4, 14, 469, DateTimeKind.Unspecified).AddTicks(1888), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Granite Shirt" },
                    { 486, new DateTimeOffset(new DateTime(2023, 6, 14, 5, 11, 53, 235, DateTimeKind.Unspecified).AddTicks(3689), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Frozen Chips" },
                    { 487, new DateTimeOffset(new DateTime(2023, 11, 18, 0, 18, 53, 238, DateTimeKind.Unspecified).AddTicks(2190), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Steel Car" },
                    { 488, new DateTimeOffset(new DateTime(2023, 9, 6, 0, 35, 8, 481, DateTimeKind.Unspecified).AddTicks(2097), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Wooden Shirt" },
                    { 489, new DateTimeOffset(new DateTime(2023, 8, 11, 3, 24, 3, 15, DateTimeKind.Unspecified).AddTicks(3410), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Plastic Mouse" },
                    { 490, new DateTimeOffset(new DateTime(2023, 4, 22, 9, 57, 21, 423, DateTimeKind.Unspecified).AddTicks(9452), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Frozen Bacon" },
                    { 491, new DateTimeOffset(new DateTime(2023, 5, 25, 5, 26, 0, 621, DateTimeKind.Unspecified).AddTicks(4389), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Frozen Table" },
                    { 492, new DateTimeOffset(new DateTime(2023, 3, 8, 8, 40, 22, 753, DateTimeKind.Unspecified).AddTicks(9638), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Cotton Shirt" },
                    { 493, new DateTimeOffset(new DateTime(2023, 2, 11, 17, 50, 42, 233, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 1, 0, 0, 0)), "Refined Steel Chair" },
                    { 494, new DateTimeOffset(new DateTime(2023, 7, 25, 6, 41, 11, 128, DateTimeKind.Unspecified).AddTicks(9814), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Frozen Bacon" },
                    { 495, new DateTimeOffset(new DateTime(2023, 6, 9, 23, 3, 16, 548, DateTimeKind.Unspecified).AddTicks(7626), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Granite Cheese" },
                    { 496, new DateTimeOffset(new DateTime(2023, 11, 26, 14, 57, 22, 980, DateTimeKind.Unspecified).AddTicks(640), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Steel Soap" },
                    { 497, new DateTimeOffset(new DateTime(2023, 4, 18, 15, 22, 44, 939, DateTimeKind.Unspecified).AddTicks(1802), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Plastic Pizza" },
                    { 498, new DateTimeOffset(new DateTime(2023, 7, 24, 22, 35, 6, 428, DateTimeKind.Unspecified).AddTicks(7800), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Concrete Pants" },
                    { 499, new DateTimeOffset(new DateTime(2023, 3, 12, 16, 36, 35, 257, DateTimeKind.Unspecified).AddTicks(6988), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Wooden Chair" },
                    { 500, new DateTimeOffset(new DateTime(2023, 3, 2, 12, 20, 8, 280, DateTimeKind.Unspecified).AddTicks(6002), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Metal Shoes" },
                    { 501, new DateTimeOffset(new DateTime(2023, 1, 28, 22, 37, 23, 424, DateTimeKind.Unspecified).AddTicks(1746), new TimeSpan(0, 1, 0, 0, 0)), "Generic Frozen Chips" },
                    { 502, new DateTimeOffset(new DateTime(2023, 11, 13, 15, 10, 52, 25, DateTimeKind.Unspecified).AddTicks(21), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Plastic Salad" },
                    { 503, new DateTimeOffset(new DateTime(2023, 6, 10, 18, 37, 35, 925, DateTimeKind.Unspecified).AddTicks(2200), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Metal Shirt" },
                    { 504, new DateTimeOffset(new DateTime(2023, 12, 8, 6, 32, 49, 509, DateTimeKind.Unspecified).AddTicks(8150), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Cotton Towels" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreationDate", "Name" },
                values: new object[,]
                {
                    { 505, new DateTimeOffset(new DateTime(2023, 8, 26, 5, 47, 2, 684, DateTimeKind.Unspecified).AddTicks(5598), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Rubber Sausages" },
                    { 506, new DateTimeOffset(new DateTime(2023, 9, 14, 20, 7, 48, 311, DateTimeKind.Unspecified).AddTicks(3955), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Wooden Shirt" },
                    { 507, new DateTimeOffset(new DateTime(2023, 8, 28, 21, 12, 39, 895, DateTimeKind.Unspecified).AddTicks(1574), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Granite Shirt" },
                    { 508, new DateTimeOffset(new DateTime(2023, 7, 21, 14, 30, 37, 497, DateTimeKind.Unspecified).AddTicks(7636), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Metal Chips" },
                    { 509, new DateTimeOffset(new DateTime(2023, 11, 5, 18, 37, 49, 46, DateTimeKind.Unspecified).AddTicks(6133), new TimeSpan(0, 1, 0, 0, 0)), "Small Metal Cheese" },
                    { 510, new DateTimeOffset(new DateTime(2023, 2, 11, 7, 30, 57, 503, DateTimeKind.Unspecified).AddTicks(5711), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Rubber Fish" },
                    { 511, new DateTimeOffset(new DateTime(2023, 2, 23, 14, 29, 6, 515, DateTimeKind.Unspecified).AddTicks(9999), new TimeSpan(0, 1, 0, 0, 0)), "Practical Steel Cheese" },
                    { 512, new DateTimeOffset(new DateTime(2023, 4, 30, 11, 15, 27, 735, DateTimeKind.Unspecified).AddTicks(2415), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Frozen Gloves" },
                    { 513, new DateTimeOffset(new DateTime(2024, 1, 3, 22, 46, 10, 325, DateTimeKind.Unspecified).AddTicks(7627), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Wooden Cheese" },
                    { 514, new DateTimeOffset(new DateTime(2023, 7, 12, 5, 25, 36, 664, DateTimeKind.Unspecified).AddTicks(5782), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Fresh Soap" },
                    { 515, new DateTimeOffset(new DateTime(2023, 9, 9, 0, 35, 37, 403, DateTimeKind.Unspecified).AddTicks(1611), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Plastic Gloves" },
                    { 516, new DateTimeOffset(new DateTime(2023, 11, 23, 13, 7, 33, 286, DateTimeKind.Unspecified).AddTicks(6144), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Plastic Salad" },
                    { 517, new DateTimeOffset(new DateTime(2023, 8, 11, 13, 55, 28, 253, DateTimeKind.Unspecified).AddTicks(2387), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Fresh Pants" },
                    { 518, new DateTimeOffset(new DateTime(2023, 11, 19, 1, 11, 40, 874, DateTimeKind.Unspecified).AddTicks(1471), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Soft Bacon" },
                    { 519, new DateTimeOffset(new DateTime(2023, 7, 20, 23, 13, 6, 691, DateTimeKind.Unspecified).AddTicks(5285), new TimeSpan(0, 1, 0, 0, 0)), "Refined Fresh Mouse" },
                    { 520, new DateTimeOffset(new DateTime(2023, 11, 1, 7, 31, 23, 37, DateTimeKind.Unspecified).AddTicks(8924), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Concrete Salad" },
                    { 521, new DateTimeOffset(new DateTime(2023, 11, 9, 2, 16, 0, 357, DateTimeKind.Unspecified).AddTicks(9423), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Wooden Chair" },
                    { 522, new DateTimeOffset(new DateTime(2023, 3, 25, 1, 52, 49, 424, DateTimeKind.Unspecified).AddTicks(1464), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Steel Bacon" },
                    { 523, new DateTimeOffset(new DateTime(2023, 10, 25, 12, 40, 19, 296, DateTimeKind.Unspecified).AddTicks(6031), new TimeSpan(0, 1, 0, 0, 0)), "Small Plastic Ball" },
                    { 524, new DateTimeOffset(new DateTime(2023, 3, 16, 17, 49, 21, 791, DateTimeKind.Unspecified).AddTicks(7313), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Steel Computer" },
                    { 525, new DateTimeOffset(new DateTime(2023, 12, 2, 16, 0, 42, 732, DateTimeKind.Unspecified).AddTicks(8614), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Fresh Table" },
                    { 526, new DateTimeOffset(new DateTime(2023, 11, 17, 23, 24, 32, 971, DateTimeKind.Unspecified).AddTicks(492), new TimeSpan(0, 1, 0, 0, 0)), "Generic Soft Tuna" },
                    { 527, new DateTimeOffset(new DateTime(2023, 11, 4, 16, 17, 48, 656, DateTimeKind.Unspecified).AddTicks(3256), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Frozen Keyboard" },
                    { 528, new DateTimeOffset(new DateTime(2023, 4, 22, 14, 54, 31, 698, DateTimeKind.Unspecified).AddTicks(3938), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Steel Computer" },
                    { 529, new DateTimeOffset(new DateTime(2023, 11, 23, 23, 5, 45, 771, DateTimeKind.Unspecified).AddTicks(8921), new TimeSpan(0, 1, 0, 0, 0)), "Practical Granite Shoes" },
                    { 530, new DateTimeOffset(new DateTime(2023, 9, 3, 21, 36, 9, 883, DateTimeKind.Unspecified).AddTicks(8087), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Steel Chips" },
                    { 531, new DateTimeOffset(new DateTime(2023, 6, 2, 7, 52, 58, 628, DateTimeKind.Unspecified).AddTicks(896), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Wooden Hat" },
                    { 532, new DateTimeOffset(new DateTime(2023, 10, 16, 16, 56, 25, 552, DateTimeKind.Unspecified).AddTicks(7519), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Steel Towels" },
                    { 533, new DateTimeOffset(new DateTime(2023, 7, 14, 21, 33, 0, 209, DateTimeKind.Unspecified).AddTicks(6011), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Steel Pants" },
                    { 534, new DateTimeOffset(new DateTime(2023, 6, 24, 10, 22, 18, 496, DateTimeKind.Unspecified).AddTicks(510), new TimeSpan(0, 1, 0, 0, 0)), "Refined Steel Mouse" },
                    { 535, new DateTimeOffset(new DateTime(2024, 1, 7, 5, 48, 28, 126, DateTimeKind.Unspecified).AddTicks(7437), new TimeSpan(0, 1, 0, 0, 0)), "Practical Concrete Shoes" },
                    { 536, new DateTimeOffset(new DateTime(2023, 12, 30, 6, 46, 51, 883, DateTimeKind.Unspecified).AddTicks(4801), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Steel Shoes" },
                    { 537, new DateTimeOffset(new DateTime(2023, 10, 17, 6, 17, 59, 692, DateTimeKind.Unspecified).AddTicks(298), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Steel Gloves" },
                    { 538, new DateTimeOffset(new DateTime(2023, 2, 9, 13, 7, 0, 206, DateTimeKind.Unspecified).AddTicks(8904), new TimeSpan(0, 1, 0, 0, 0)), "Generic Concrete Sausages" },
                    { 539, new DateTimeOffset(new DateTime(2023, 6, 23, 20, 17, 33, 818, DateTimeKind.Unspecified).AddTicks(168), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Soft Bacon" },
                    { 540, new DateTimeOffset(new DateTime(2023, 5, 5, 23, 50, 46, 711, DateTimeKind.Unspecified).AddTicks(7394), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Concrete Pants" },
                    { 541, new DateTimeOffset(new DateTime(2023, 9, 24, 18, 14, 46, 185, DateTimeKind.Unspecified).AddTicks(4350), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Cotton Chair" },
                    { 542, new DateTimeOffset(new DateTime(2023, 6, 25, 7, 3, 27, 960, DateTimeKind.Unspecified).AddTicks(5964), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Rubber Table" },
                    { 543, new DateTimeOffset(new DateTime(2023, 2, 3, 13, 40, 45, 796, DateTimeKind.Unspecified).AddTicks(654), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Steel Shirt" },
                    { 544, new DateTimeOffset(new DateTime(2023, 2, 6, 16, 11, 12, 833, DateTimeKind.Unspecified).AddTicks(3668), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Frozen Fish" },
                    { 545, new DateTimeOffset(new DateTime(2023, 7, 7, 20, 31, 2, 118, DateTimeKind.Unspecified).AddTicks(2798), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Rubber Mouse" },
                    { 546, new DateTimeOffset(new DateTime(2023, 7, 15, 8, 3, 14, 415, DateTimeKind.Unspecified).AddTicks(6973), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Fresh Keyboard" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreationDate", "Name" },
                values: new object[,]
                {
                    { 547, new DateTimeOffset(new DateTime(2023, 1, 23, 16, 55, 6, 131, DateTimeKind.Unspecified).AddTicks(8187), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Plastic Towels" },
                    { 548, new DateTimeOffset(new DateTime(2023, 3, 30, 4, 54, 11, 883, DateTimeKind.Unspecified).AddTicks(7323), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Soft Bike" },
                    { 549, new DateTimeOffset(new DateTime(2023, 7, 21, 18, 38, 43, 528, DateTimeKind.Unspecified).AddTicks(2731), new TimeSpan(0, 1, 0, 0, 0)), "Refined Concrete Tuna" },
                    { 550, new DateTimeOffset(new DateTime(2023, 8, 20, 5, 4, 17, 23, DateTimeKind.Unspecified).AddTicks(373), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Soft Bike" },
                    { 551, new DateTimeOffset(new DateTime(2023, 8, 17, 17, 9, 2, 106, DateTimeKind.Unspecified).AddTicks(2829), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Fresh Table" },
                    { 552, new DateTimeOffset(new DateTime(2023, 12, 30, 19, 2, 47, 172, DateTimeKind.Unspecified).AddTicks(628), new TimeSpan(0, 1, 0, 0, 0)), "Refined Fresh Shoes" },
                    { 553, new DateTimeOffset(new DateTime(2023, 9, 10, 2, 58, 50, 491, DateTimeKind.Unspecified).AddTicks(2570), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Soft Cheese" },
                    { 554, new DateTimeOffset(new DateTime(2023, 7, 18, 14, 39, 28, 107, DateTimeKind.Unspecified).AddTicks(2777), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Fresh Soap" },
                    { 555, new DateTimeOffset(new DateTime(2023, 6, 15, 13, 10, 41, 570, DateTimeKind.Unspecified).AddTicks(3247), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Granite Soap" },
                    { 556, new DateTimeOffset(new DateTime(2023, 8, 6, 4, 59, 9, 484, DateTimeKind.Unspecified).AddTicks(4920), new TimeSpan(0, 1, 0, 0, 0)), "Small Cotton Bike" },
                    { 557, new DateTimeOffset(new DateTime(2023, 6, 12, 14, 53, 4, 720, DateTimeKind.Unspecified).AddTicks(1088), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Concrete Bike" },
                    { 558, new DateTimeOffset(new DateTime(2023, 12, 1, 3, 31, 28, 807, DateTimeKind.Unspecified).AddTicks(7733), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Concrete Car" },
                    { 559, new DateTimeOffset(new DateTime(2023, 11, 4, 23, 42, 45, 511, DateTimeKind.Unspecified).AddTicks(7341), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Rubber Salad" },
                    { 560, new DateTimeOffset(new DateTime(2023, 4, 7, 8, 11, 34, 138, DateTimeKind.Unspecified).AddTicks(7163), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Rubber Soap" },
                    { 561, new DateTimeOffset(new DateTime(2023, 7, 6, 17, 54, 34, 390, DateTimeKind.Unspecified).AddTicks(3577), new TimeSpan(0, 1, 0, 0, 0)), "Refined Rubber Sausages" },
                    { 562, new DateTimeOffset(new DateTime(2023, 12, 28, 23, 27, 0, 549, DateTimeKind.Unspecified).AddTicks(1263), new TimeSpan(0, 1, 0, 0, 0)), "Small Rubber Keyboard" },
                    { 563, new DateTimeOffset(new DateTime(2023, 6, 26, 12, 5, 5, 931, DateTimeKind.Unspecified).AddTicks(9637), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Wooden Ball" },
                    { 564, new DateTimeOffset(new DateTime(2023, 3, 15, 16, 58, 44, 632, DateTimeKind.Unspecified).AddTicks(8666), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Fresh Towels" },
                    { 565, new DateTimeOffset(new DateTime(2023, 9, 22, 10, 48, 19, 555, DateTimeKind.Unspecified).AddTicks(3777), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Fresh Cheese" },
                    { 566, new DateTimeOffset(new DateTime(2023, 11, 23, 18, 10, 28, 484, DateTimeKind.Unspecified).AddTicks(5595), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Steel Soap" },
                    { 567, new DateTimeOffset(new DateTime(2023, 7, 9, 14, 4, 7, 59, DateTimeKind.Unspecified).AddTicks(3567), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Fresh Gloves" },
                    { 568, new DateTimeOffset(new DateTime(2023, 10, 1, 0, 41, 13, 831, DateTimeKind.Unspecified).AddTicks(2701), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Soft Computer" },
                    { 569, new DateTimeOffset(new DateTime(2023, 6, 30, 21, 15, 42, 43, DateTimeKind.Unspecified).AddTicks(5559), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Cotton Towels" },
                    { 570, new DateTimeOffset(new DateTime(2023, 4, 17, 4, 2, 12, 517, DateTimeKind.Unspecified).AddTicks(9910), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Soft Towels" },
                    { 571, new DateTimeOffset(new DateTime(2023, 4, 2, 10, 39, 37, 302, DateTimeKind.Unspecified).AddTicks(1651), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Concrete Bacon" },
                    { 572, new DateTimeOffset(new DateTime(2023, 7, 22, 21, 47, 23, 653, DateTimeKind.Unspecified).AddTicks(774), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Rubber Chicken" },
                    { 573, new DateTimeOffset(new DateTime(2023, 7, 22, 11, 25, 27, 256, DateTimeKind.Unspecified).AddTicks(9950), new TimeSpan(0, 1, 0, 0, 0)), "Small Soft Keyboard" },
                    { 574, new DateTimeOffset(new DateTime(2023, 10, 17, 22, 25, 28, 592, DateTimeKind.Unspecified).AddTicks(4451), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Frozen Towels" },
                    { 575, new DateTimeOffset(new DateTime(2023, 2, 27, 8, 54, 19, 195, DateTimeKind.Unspecified).AddTicks(9370), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Steel Bacon" },
                    { 576, new DateTimeOffset(new DateTime(2023, 10, 27, 16, 59, 56, 573, DateTimeKind.Unspecified).AddTicks(8564), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Metal Chips" },
                    { 577, new DateTimeOffset(new DateTime(2023, 11, 14, 1, 21, 7, 163, DateTimeKind.Unspecified).AddTicks(7734), new TimeSpan(0, 1, 0, 0, 0)), "Small Rubber Hat" },
                    { 578, new DateTimeOffset(new DateTime(2023, 12, 12, 1, 49, 23, 401, DateTimeKind.Unspecified).AddTicks(5663), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Steel Chicken" },
                    { 579, new DateTimeOffset(new DateTime(2023, 6, 8, 11, 14, 17, 587, DateTimeKind.Unspecified).AddTicks(4425), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Granite Soap" },
                    { 580, new DateTimeOffset(new DateTime(2023, 1, 29, 13, 7, 48, 847, DateTimeKind.Unspecified).AddTicks(6244), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Cotton Salad" },
                    { 581, new DateTimeOffset(new DateTime(2023, 4, 17, 4, 7, 47, 631, DateTimeKind.Unspecified).AddTicks(8444), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Soft Table" },
                    { 582, new DateTimeOffset(new DateTime(2024, 1, 14, 22, 32, 18, 220, DateTimeKind.Unspecified).AddTicks(5594), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Rubber Sausages" },
                    { 583, new DateTimeOffset(new DateTime(2023, 6, 4, 10, 41, 20, 611, DateTimeKind.Unspecified).AddTicks(9649), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Fresh Shoes" },
                    { 584, new DateTimeOffset(new DateTime(2023, 6, 19, 0, 17, 55, 332, DateTimeKind.Unspecified).AddTicks(6389), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Cotton Chips" },
                    { 585, new DateTimeOffset(new DateTime(2023, 6, 18, 0, 59, 41, 326, DateTimeKind.Unspecified).AddTicks(9734), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Steel Mouse" },
                    { 586, new DateTimeOffset(new DateTime(2024, 1, 3, 8, 49, 27, 450, DateTimeKind.Unspecified).AddTicks(9894), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Fresh Ball" },
                    { 587, new DateTimeOffset(new DateTime(2023, 4, 21, 23, 10, 51, 672, DateTimeKind.Unspecified).AddTicks(3453), new TimeSpan(0, 1, 0, 0, 0)), "Small Concrete Mouse" },
                    { 588, new DateTimeOffset(new DateTime(2023, 8, 19, 21, 46, 38, 18, DateTimeKind.Unspecified).AddTicks(4024), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Wooden Shoes" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreationDate", "Name" },
                values: new object[,]
                {
                    { 589, new DateTimeOffset(new DateTime(2023, 7, 3, 2, 36, 2, 266, DateTimeKind.Unspecified).AddTicks(8531), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Soft Salad" },
                    { 590, new DateTimeOffset(new DateTime(2023, 6, 26, 10, 47, 20, 727, DateTimeKind.Unspecified).AddTicks(1310), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Metal Computer" },
                    { 591, new DateTimeOffset(new DateTime(2023, 6, 15, 5, 46, 58, 66, DateTimeKind.Unspecified).AddTicks(9626), new TimeSpan(0, 1, 0, 0, 0)), "Generic Granite Chair" },
                    { 592, new DateTimeOffset(new DateTime(2023, 12, 9, 22, 23, 31, 338, DateTimeKind.Unspecified).AddTicks(1625), new TimeSpan(0, 1, 0, 0, 0)), "Generic Plastic Sausages" },
                    { 593, new DateTimeOffset(new DateTime(2023, 4, 3, 9, 36, 48, 962, DateTimeKind.Unspecified).AddTicks(4340), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Concrete Computer" },
                    { 594, new DateTimeOffset(new DateTime(2023, 6, 1, 22, 27, 18, 775, DateTimeKind.Unspecified).AddTicks(7541), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Granite Salad" },
                    { 595, new DateTimeOffset(new DateTime(2023, 6, 23, 8, 28, 57, 77, DateTimeKind.Unspecified).AddTicks(5780), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Granite Mouse" },
                    { 596, new DateTimeOffset(new DateTime(2023, 9, 6, 6, 15, 4, 256, DateTimeKind.Unspecified).AddTicks(3288), new TimeSpan(0, 1, 0, 0, 0)), "Practical Metal Chicken" },
                    { 597, new DateTimeOffset(new DateTime(2023, 3, 27, 19, 20, 42, 162, DateTimeKind.Unspecified).AddTicks(4506), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Fresh Mouse" },
                    { 598, new DateTimeOffset(new DateTime(2023, 8, 20, 4, 54, 34, 230, DateTimeKind.Unspecified).AddTicks(3824), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Granite Mouse" },
                    { 599, new DateTimeOffset(new DateTime(2023, 8, 24, 23, 52, 5, 991, DateTimeKind.Unspecified).AddTicks(2531), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Soft Cheese" },
                    { 600, new DateTimeOffset(new DateTime(2023, 10, 15, 1, 33, 16, 326, DateTimeKind.Unspecified).AddTicks(1837), new TimeSpan(0, 1, 0, 0, 0)), "Refined Fresh Pants" },
                    { 601, new DateTimeOffset(new DateTime(2023, 3, 4, 21, 6, 39, 800, DateTimeKind.Unspecified).AddTicks(1078), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Plastic Fish" },
                    { 602, new DateTimeOffset(new DateTime(2023, 10, 13, 15, 16, 21, 16, DateTimeKind.Unspecified).AddTicks(2574), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Plastic Pants" },
                    { 603, new DateTimeOffset(new DateTime(2023, 10, 23, 14, 45, 56, 504, DateTimeKind.Unspecified).AddTicks(7286), new TimeSpan(0, 1, 0, 0, 0)), "Refined Granite Sausages" },
                    { 604, new DateTimeOffset(new DateTime(2024, 1, 3, 7, 58, 19, 29, DateTimeKind.Unspecified).AddTicks(8924), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Metal Chair" },
                    { 605, new DateTimeOffset(new DateTime(2023, 10, 17, 22, 40, 7, 583, DateTimeKind.Unspecified).AddTicks(4533), new TimeSpan(0, 1, 0, 0, 0)), "Refined Cotton Car" },
                    { 606, new DateTimeOffset(new DateTime(2024, 1, 15, 6, 9, 52, 914, DateTimeKind.Unspecified).AddTicks(9475), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Soft Pants" },
                    { 607, new DateTimeOffset(new DateTime(2023, 7, 15, 8, 18, 32, 160, DateTimeKind.Unspecified).AddTicks(6696), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Granite Ball" },
                    { 608, new DateTimeOffset(new DateTime(2023, 9, 15, 22, 42, 43, 420, DateTimeKind.Unspecified).AddTicks(4274), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Plastic Towels" },
                    { 609, new DateTimeOffset(new DateTime(2023, 3, 6, 2, 35, 22, 559, DateTimeKind.Unspecified).AddTicks(6856), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Cotton Keyboard" },
                    { 610, new DateTimeOffset(new DateTime(2023, 2, 2, 19, 27, 28, 551, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Granite Towels" },
                    { 611, new DateTimeOffset(new DateTime(2023, 1, 22, 10, 40, 23, 88, DateTimeKind.Unspecified).AddTicks(4788), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Cotton Pants" },
                    { 612, new DateTimeOffset(new DateTime(2023, 4, 18, 7, 46, 49, 178, DateTimeKind.Unspecified).AddTicks(2728), new TimeSpan(0, 1, 0, 0, 0)), "Generic Cotton Car" },
                    { 613, new DateTimeOffset(new DateTime(2023, 6, 30, 21, 7, 51, 77, DateTimeKind.Unspecified).AddTicks(8946), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Fresh Cheese" },
                    { 614, new DateTimeOffset(new DateTime(2023, 8, 1, 15, 43, 47, 382, DateTimeKind.Unspecified).AddTicks(7457), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Rubber Soap" },
                    { 615, new DateTimeOffset(new DateTime(2023, 8, 19, 14, 40, 44, 617, DateTimeKind.Unspecified).AddTicks(8665), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Soft Keyboard" },
                    { 616, new DateTimeOffset(new DateTime(2023, 8, 1, 12, 20, 12, 761, DateTimeKind.Unspecified).AddTicks(8070), new TimeSpan(0, 1, 0, 0, 0)), "Small Fresh Car" },
                    { 617, new DateTimeOffset(new DateTime(2023, 2, 8, 21, 6, 2, 62, DateTimeKind.Unspecified).AddTicks(1511), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Concrete Tuna" },
                    { 618, new DateTimeOffset(new DateTime(2023, 5, 5, 9, 36, 17, 317, DateTimeKind.Unspecified).AddTicks(3029), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Fresh Chair" },
                    { 619, new DateTimeOffset(new DateTime(2023, 9, 29, 1, 31, 22, 890, DateTimeKind.Unspecified).AddTicks(5486), new TimeSpan(0, 1, 0, 0, 0)), "Refined Steel Bike" },
                    { 620, new DateTimeOffset(new DateTime(2023, 8, 13, 4, 4, 3, 783, DateTimeKind.Unspecified).AddTicks(2898), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Plastic Shirt" },
                    { 621, new DateTimeOffset(new DateTime(2023, 11, 22, 4, 42, 29, 564, DateTimeKind.Unspecified).AddTicks(1055), new TimeSpan(0, 1, 0, 0, 0)), "Practical Steel Cheese" },
                    { 622, new DateTimeOffset(new DateTime(2023, 7, 31, 0, 4, 54, 403, DateTimeKind.Unspecified).AddTicks(9031), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Wooden Salad" },
                    { 623, new DateTimeOffset(new DateTime(2023, 3, 28, 11, 26, 30, 704, DateTimeKind.Unspecified).AddTicks(9309), new TimeSpan(0, 1, 0, 0, 0)), "Refined Rubber Mouse" },
                    { 624, new DateTimeOffset(new DateTime(2023, 9, 6, 9, 43, 53, 564, DateTimeKind.Unspecified).AddTicks(1545), new TimeSpan(0, 1, 0, 0, 0)), "Practical Frozen Chair" },
                    { 625, new DateTimeOffset(new DateTime(2023, 5, 17, 7, 1, 32, 224, DateTimeKind.Unspecified).AddTicks(4709), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Soft Chair" },
                    { 626, new DateTimeOffset(new DateTime(2023, 11, 9, 20, 2, 28, 174, DateTimeKind.Unspecified).AddTicks(8497), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Steel Fish" },
                    { 627, new DateTimeOffset(new DateTime(2023, 10, 20, 1, 42, 39, 525, DateTimeKind.Unspecified).AddTicks(9052), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Granite Tuna" },
                    { 628, new DateTimeOffset(new DateTime(2023, 8, 17, 14, 29, 49, 305, DateTimeKind.Unspecified).AddTicks(5486), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Frozen Keyboard" },
                    { 629, new DateTimeOffset(new DateTime(2024, 1, 9, 12, 47, 54, 21, DateTimeKind.Unspecified).AddTicks(6765), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Rubber Keyboard" },
                    { 630, new DateTimeOffset(new DateTime(2023, 12, 7, 0, 50, 41, 992, DateTimeKind.Unspecified).AddTicks(3809), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Concrete Chips" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreationDate", "Name" },
                values: new object[,]
                {
                    { 631, new DateTimeOffset(new DateTime(2023, 12, 24, 16, 56, 0, 866, DateTimeKind.Unspecified).AddTicks(5852), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Wooden Bike" },
                    { 632, new DateTimeOffset(new DateTime(2023, 11, 27, 22, 32, 45, 143, DateTimeKind.Unspecified).AddTicks(8090), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Fresh Salad" },
                    { 633, new DateTimeOffset(new DateTime(2023, 8, 26, 18, 59, 54, 284, DateTimeKind.Unspecified).AddTicks(1250), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Rubber Gloves" },
                    { 634, new DateTimeOffset(new DateTime(2023, 6, 16, 5, 59, 48, 464, DateTimeKind.Unspecified).AddTicks(315), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Steel Cheese" },
                    { 635, new DateTimeOffset(new DateTime(2023, 2, 17, 9, 30, 19, 717, DateTimeKind.Unspecified).AddTicks(1100), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Frozen Car" },
                    { 636, new DateTimeOffset(new DateTime(2023, 12, 23, 7, 26, 7, 91, DateTimeKind.Unspecified).AddTicks(9496), new TimeSpan(0, 1, 0, 0, 0)), "Practical Wooden Mouse" },
                    { 637, new DateTimeOffset(new DateTime(2023, 11, 24, 1, 12, 50, 81, DateTimeKind.Unspecified).AddTicks(9794), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Rubber Pizza" },
                    { 638, new DateTimeOffset(new DateTime(2023, 3, 13, 20, 47, 36, 645, DateTimeKind.Unspecified).AddTicks(2537), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Steel Towels" },
                    { 639, new DateTimeOffset(new DateTime(2023, 9, 18, 12, 28, 50, 538, DateTimeKind.Unspecified).AddTicks(775), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Wooden Sausages" },
                    { 640, new DateTimeOffset(new DateTime(2023, 12, 31, 7, 34, 33, 702, DateTimeKind.Unspecified).AddTicks(3180), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Soft Keyboard" },
                    { 641, new DateTimeOffset(new DateTime(2023, 10, 13, 23, 3, 12, 84, DateTimeKind.Unspecified).AddTicks(8158), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Soft Cheese" },
                    { 642, new DateTimeOffset(new DateTime(2023, 4, 26, 11, 36, 41, 41, DateTimeKind.Unspecified).AddTicks(695), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Granite Ball" },
                    { 643, new DateTimeOffset(new DateTime(2023, 2, 27, 23, 47, 3, 165, DateTimeKind.Unspecified).AddTicks(7380), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Soft Tuna" },
                    { 644, new DateTimeOffset(new DateTime(2023, 4, 25, 13, 27, 59, 85, DateTimeKind.Unspecified).AddTicks(3977), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Fresh Table" },
                    { 645, new DateTimeOffset(new DateTime(2023, 2, 7, 16, 30, 6, 11, DateTimeKind.Unspecified).AddTicks(68), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Plastic Shoes" },
                    { 646, new DateTimeOffset(new DateTime(2023, 12, 22, 15, 31, 2, 725, DateTimeKind.Unspecified).AddTicks(8186), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Steel Car" },
                    { 647, new DateTimeOffset(new DateTime(2023, 3, 15, 6, 0, 31, 891, DateTimeKind.Unspecified).AddTicks(1144), new TimeSpan(0, 1, 0, 0, 0)), "Small Wooden Bacon" },
                    { 648, new DateTimeOffset(new DateTime(2023, 8, 1, 18, 22, 46, 599, DateTimeKind.Unspecified).AddTicks(7677), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Wooden Soap" },
                    { 649, new DateTimeOffset(new DateTime(2023, 9, 29, 14, 5, 40, 133, DateTimeKind.Unspecified).AddTicks(9273), new TimeSpan(0, 1, 0, 0, 0)), "Refined Wooden Hat" },
                    { 650, new DateTimeOffset(new DateTime(2023, 12, 29, 16, 58, 23, 353, DateTimeKind.Unspecified).AddTicks(383), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Cotton Pants" },
                    { 651, new DateTimeOffset(new DateTime(2023, 2, 1, 8, 10, 40, 650, DateTimeKind.Unspecified).AddTicks(7746), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Rubber Computer" },
                    { 652, new DateTimeOffset(new DateTime(2023, 12, 15, 1, 9, 13, 232, DateTimeKind.Unspecified).AddTicks(1396), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Cotton Chips" },
                    { 653, new DateTimeOffset(new DateTime(2023, 7, 19, 3, 36, 17, 275, DateTimeKind.Unspecified).AddTicks(1285), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Metal Cheese" },
                    { 654, new DateTimeOffset(new DateTime(2023, 8, 4, 5, 33, 33, 102, DateTimeKind.Unspecified).AddTicks(7104), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Steel Chips" },
                    { 655, new DateTimeOffset(new DateTime(2023, 6, 13, 6, 5, 28, 490, DateTimeKind.Unspecified).AddTicks(3909), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Fresh Chicken" },
                    { 656, new DateTimeOffset(new DateTime(2023, 9, 11, 3, 28, 11, 339, DateTimeKind.Unspecified).AddTicks(2004), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Wooden Keyboard" },
                    { 657, new DateTimeOffset(new DateTime(2023, 2, 8, 21, 53, 59, 459, DateTimeKind.Unspecified).AddTicks(5407), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Wooden Ball" },
                    { 658, new DateTimeOffset(new DateTime(2023, 7, 7, 0, 33, 49, 494, DateTimeKind.Unspecified).AddTicks(5933), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Metal Sausages" },
                    { 659, new DateTimeOffset(new DateTime(2023, 6, 13, 0, 9, 6, 67, DateTimeKind.Unspecified).AddTicks(8369), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Granite Fish" },
                    { 660, new DateTimeOffset(new DateTime(2023, 8, 30, 9, 1, 11, 483, DateTimeKind.Unspecified).AddTicks(4615), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Steel Hat" },
                    { 661, new DateTimeOffset(new DateTime(2023, 7, 3, 1, 2, 2, 661, DateTimeKind.Unspecified).AddTicks(9542), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Fresh Table" },
                    { 662, new DateTimeOffset(new DateTime(2023, 10, 25, 16, 24, 2, 177, DateTimeKind.Unspecified).AddTicks(7357), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Wooden Bike" },
                    { 663, new DateTimeOffset(new DateTime(2023, 7, 24, 7, 51, 16, 746, DateTimeKind.Unspecified).AddTicks(7673), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Frozen Chair" },
                    { 664, new DateTimeOffset(new DateTime(2023, 4, 9, 1, 31, 27, 127, DateTimeKind.Unspecified).AddTicks(3392), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Frozen Bike" },
                    { 665, new DateTimeOffset(new DateTime(2023, 4, 24, 9, 50, 24, 797, DateTimeKind.Unspecified).AddTicks(8001), new TimeSpan(0, 1, 0, 0, 0)), "Practical Cotton Salad" },
                    { 666, new DateTimeOffset(new DateTime(2024, 1, 16, 10, 41, 10, 243, DateTimeKind.Unspecified).AddTicks(8), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Frozen Hat" },
                    { 667, new DateTimeOffset(new DateTime(2023, 11, 3, 0, 44, 38, 133, DateTimeKind.Unspecified).AddTicks(8836), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Plastic Towels" },
                    { 668, new DateTimeOffset(new DateTime(2023, 9, 18, 11, 3, 23, 340, DateTimeKind.Unspecified).AddTicks(1762), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Rubber Soap" },
                    { 669, new DateTimeOffset(new DateTime(2023, 11, 19, 2, 17, 16, 993, DateTimeKind.Unspecified).AddTicks(4148), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Steel Bike" },
                    { 670, new DateTimeOffset(new DateTime(2023, 1, 20, 12, 12, 58, 220, DateTimeKind.Unspecified).AddTicks(479), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Metal Ball" },
                    { 671, new DateTimeOffset(new DateTime(2023, 6, 23, 5, 58, 10, 16, DateTimeKind.Unspecified).AddTicks(8084), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Granite Sausages" },
                    { 672, new DateTimeOffset(new DateTime(2024, 1, 11, 4, 29, 54, 29, DateTimeKind.Unspecified).AddTicks(8809), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Cotton Chicken" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreationDate", "Name" },
                values: new object[,]
                {
                    { 673, new DateTimeOffset(new DateTime(2023, 7, 23, 20, 57, 29, 129, DateTimeKind.Unspecified).AddTicks(7087), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Granite Chips" },
                    { 674, new DateTimeOffset(new DateTime(2023, 4, 20, 0, 19, 21, 526, DateTimeKind.Unspecified).AddTicks(2973), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Concrete Table" },
                    { 675, new DateTimeOffset(new DateTime(2023, 2, 17, 1, 58, 8, 535, DateTimeKind.Unspecified).AddTicks(3506), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Cotton Fish" },
                    { 676, new DateTimeOffset(new DateTime(2023, 8, 9, 8, 50, 45, 849, DateTimeKind.Unspecified).AddTicks(4377), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Cotton Table" },
                    { 677, new DateTimeOffset(new DateTime(2023, 9, 26, 19, 52, 25, 865, DateTimeKind.Unspecified).AddTicks(8251), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Plastic Bike" },
                    { 678, new DateTimeOffset(new DateTime(2023, 10, 15, 23, 20, 52, 779, DateTimeKind.Unspecified).AddTicks(1636), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Cotton Hat" },
                    { 679, new DateTimeOffset(new DateTime(2023, 9, 14, 0, 38, 39, 245, DateTimeKind.Unspecified).AddTicks(6671), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Fresh Pants" },
                    { 680, new DateTimeOffset(new DateTime(2023, 5, 23, 23, 6, 6, 650, DateTimeKind.Unspecified).AddTicks(5960), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Steel Ball" },
                    { 681, new DateTimeOffset(new DateTime(2023, 11, 28, 20, 49, 26, 494, DateTimeKind.Unspecified).AddTicks(3863), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Rubber Hat" },
                    { 682, new DateTimeOffset(new DateTime(2023, 1, 26, 10, 41, 31, 618, DateTimeKind.Unspecified).AddTicks(4632), new TimeSpan(0, 1, 0, 0, 0)), "Generic Steel Towels" },
                    { 683, new DateTimeOffset(new DateTime(2023, 4, 17, 19, 29, 22, 93, DateTimeKind.Unspecified).AddTicks(1652), new TimeSpan(0, 1, 0, 0, 0)), "Generic Frozen Shoes" },
                    { 684, new DateTimeOffset(new DateTime(2023, 7, 3, 17, 32, 40, 537, DateTimeKind.Unspecified).AddTicks(3347), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Concrete Shoes" },
                    { 685, new DateTimeOffset(new DateTime(2023, 6, 5, 4, 9, 7, 486, DateTimeKind.Unspecified).AddTicks(2494), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Cotton Car" },
                    { 686, new DateTimeOffset(new DateTime(2023, 12, 11, 22, 12, 48, 209, DateTimeKind.Unspecified).AddTicks(1219), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Steel Ball" },
                    { 687, new DateTimeOffset(new DateTime(2023, 4, 3, 8, 24, 41, 705, DateTimeKind.Unspecified).AddTicks(6780), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Concrete Pants" },
                    { 688, new DateTimeOffset(new DateTime(2023, 4, 29, 18, 30, 48, 286, DateTimeKind.Unspecified).AddTicks(4733), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Soft Ball" },
                    { 689, new DateTimeOffset(new DateTime(2024, 1, 4, 16, 13, 58, 932, DateTimeKind.Unspecified).AddTicks(8884), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Plastic Hat" },
                    { 690, new DateTimeOffset(new DateTime(2023, 4, 28, 23, 27, 54, 226, DateTimeKind.Unspecified).AddTicks(4856), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Rubber Chips" },
                    { 691, new DateTimeOffset(new DateTime(2023, 10, 22, 7, 33, 56, 723, DateTimeKind.Unspecified).AddTicks(4399), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Concrete Car" },
                    { 692, new DateTimeOffset(new DateTime(2023, 12, 30, 12, 27, 32, 301, DateTimeKind.Unspecified).AddTicks(2860), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Plastic Cheese" },
                    { 693, new DateTimeOffset(new DateTime(2023, 8, 29, 20, 29, 4, 438, DateTimeKind.Unspecified).AddTicks(1295), new TimeSpan(0, 1, 0, 0, 0)), "Practical Frozen Towels" },
                    { 694, new DateTimeOffset(new DateTime(2023, 8, 9, 14, 42, 12, 807, DateTimeKind.Unspecified).AddTicks(8931), new TimeSpan(0, 1, 0, 0, 0)), "Small Fresh Mouse" },
                    { 695, new DateTimeOffset(new DateTime(2023, 6, 2, 2, 22, 52, 327, DateTimeKind.Unspecified).AddTicks(3434), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Rubber Sausages" },
                    { 696, new DateTimeOffset(new DateTime(2023, 11, 8, 17, 36, 42, 464, DateTimeKind.Unspecified).AddTicks(5681), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Plastic Keyboard" },
                    { 697, new DateTimeOffset(new DateTime(2023, 8, 30, 19, 34, 26, 947, DateTimeKind.Unspecified).AddTicks(6775), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Concrete Computer" },
                    { 698, new DateTimeOffset(new DateTime(2023, 7, 29, 20, 3, 20, 316, DateTimeKind.Unspecified).AddTicks(2286), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Granite Hat" },
                    { 699, new DateTimeOffset(new DateTime(2024, 1, 12, 15, 20, 30, 537, DateTimeKind.Unspecified).AddTicks(4549), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Soft Soap" },
                    { 700, new DateTimeOffset(new DateTime(2023, 9, 13, 12, 26, 51, 444, DateTimeKind.Unspecified).AddTicks(9797), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Granite Chips" },
                    { 701, new DateTimeOffset(new DateTime(2024, 1, 11, 8, 15, 6, 475, DateTimeKind.Unspecified).AddTicks(4041), new TimeSpan(0, 1, 0, 0, 0)), "Practical Cotton Cheese" },
                    { 702, new DateTimeOffset(new DateTime(2023, 4, 19, 6, 15, 42, 551, DateTimeKind.Unspecified).AddTicks(4339), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Metal Ball" },
                    { 703, new DateTimeOffset(new DateTime(2023, 5, 14, 7, 17, 33, 489, DateTimeKind.Unspecified).AddTicks(623), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Frozen Tuna" },
                    { 704, new DateTimeOffset(new DateTime(2023, 6, 21, 20, 13, 31, 964, DateTimeKind.Unspecified).AddTicks(5306), new TimeSpan(0, 1, 0, 0, 0)), "Generic Rubber Towels" },
                    { 705, new DateTimeOffset(new DateTime(2023, 10, 8, 12, 37, 41, 935, DateTimeKind.Unspecified).AddTicks(5173), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Concrete Car" },
                    { 706, new DateTimeOffset(new DateTime(2023, 12, 29, 9, 1, 51, 606, DateTimeKind.Unspecified).AddTicks(4787), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Wooden Ball" },
                    { 707, new DateTimeOffset(new DateTime(2023, 4, 10, 0, 59, 52, 488, DateTimeKind.Unspecified).AddTicks(1681), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Steel Mouse" },
                    { 708, new DateTimeOffset(new DateTime(2023, 11, 16, 22, 10, 13, 76, DateTimeKind.Unspecified).AddTicks(1874), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Wooden Tuna" },
                    { 709, new DateTimeOffset(new DateTime(2023, 5, 7, 14, 25, 32, 651, DateTimeKind.Unspecified).AddTicks(967), new TimeSpan(0, 1, 0, 0, 0)), "Generic Concrete Sausages" },
                    { 710, new DateTimeOffset(new DateTime(2023, 2, 5, 10, 40, 25, 412, DateTimeKind.Unspecified).AddTicks(228), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Wooden Soap" },
                    { 711, new DateTimeOffset(new DateTime(2023, 10, 12, 2, 52, 36, 947, DateTimeKind.Unspecified).AddTicks(7589), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Fresh Table" },
                    { 712, new DateTimeOffset(new DateTime(2023, 11, 12, 13, 40, 47, 937, DateTimeKind.Unspecified).AddTicks(3131), new TimeSpan(0, 1, 0, 0, 0)), "Refined Concrete Salad" },
                    { 713, new DateTimeOffset(new DateTime(2023, 9, 14, 1, 23, 51, 714, DateTimeKind.Unspecified).AddTicks(7619), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Wooden Sausages" },
                    { 714, new DateTimeOffset(new DateTime(2023, 5, 9, 16, 33, 22, 195, DateTimeKind.Unspecified).AddTicks(9416), new TimeSpan(0, 1, 0, 0, 0)), "Practical Concrete Shoes" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreationDate", "Name" },
                values: new object[,]
                {
                    { 715, new DateTimeOffset(new DateTime(2023, 3, 23, 23, 28, 48, 638, DateTimeKind.Unspecified).AddTicks(8639), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Soft Soap" },
                    { 716, new DateTimeOffset(new DateTime(2023, 1, 21, 22, 22, 5, 516, DateTimeKind.Unspecified).AddTicks(168), new TimeSpan(0, 1, 0, 0, 0)), "Practical Steel Chips" },
                    { 717, new DateTimeOffset(new DateTime(2023, 6, 1, 8, 15, 36, 996, DateTimeKind.Unspecified).AddTicks(9847), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Soft Chicken" },
                    { 718, new DateTimeOffset(new DateTime(2023, 12, 18, 9, 47, 42, 686, DateTimeKind.Unspecified).AddTicks(3880), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Concrete Pizza" },
                    { 719, new DateTimeOffset(new DateTime(2023, 5, 25, 1, 41, 16, 371, DateTimeKind.Unspecified).AddTicks(2969), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Steel Bacon" },
                    { 720, new DateTimeOffset(new DateTime(2023, 3, 19, 1, 47, 1, 417, DateTimeKind.Unspecified).AddTicks(4641), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Granite Computer" },
                    { 721, new DateTimeOffset(new DateTime(2023, 2, 27, 23, 52, 2, 521, DateTimeKind.Unspecified).AddTicks(3866), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Cotton Chair" },
                    { 722, new DateTimeOffset(new DateTime(2023, 5, 26, 12, 23, 0, 881, DateTimeKind.Unspecified).AddTicks(9574), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Frozen Shirt" },
                    { 723, new DateTimeOffset(new DateTime(2023, 10, 22, 0, 59, 20, 797, DateTimeKind.Unspecified).AddTicks(5333), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Rubber Keyboard" },
                    { 724, new DateTimeOffset(new DateTime(2023, 12, 6, 0, 30, 54, 597, DateTimeKind.Unspecified).AddTicks(3724), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Cotton Soap" },
                    { 725, new DateTimeOffset(new DateTime(2023, 2, 2, 5, 48, 31, 917, DateTimeKind.Unspecified).AddTicks(4292), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Cotton Table" },
                    { 726, new DateTimeOffset(new DateTime(2024, 1, 3, 22, 15, 6, 111, DateTimeKind.Unspecified).AddTicks(7737), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Granite Keyboard" },
                    { 727, new DateTimeOffset(new DateTime(2023, 6, 19, 20, 50, 53, 522, DateTimeKind.Unspecified).AddTicks(374), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Steel Chips" },
                    { 728, new DateTimeOffset(new DateTime(2023, 8, 28, 7, 55, 21, 12, DateTimeKind.Unspecified).AddTicks(1896), new TimeSpan(0, 1, 0, 0, 0)), "Practical Wooden Soap" },
                    { 729, new DateTimeOffset(new DateTime(2023, 2, 6, 13, 6, 47, 321, DateTimeKind.Unspecified).AddTicks(621), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Cotton Chair" },
                    { 730, new DateTimeOffset(new DateTime(2023, 5, 22, 22, 5, 18, 268, DateTimeKind.Unspecified).AddTicks(7338), new TimeSpan(0, 1, 0, 0, 0)), "Small Fresh Cheese" },
                    { 731, new DateTimeOffset(new DateTime(2023, 2, 9, 10, 36, 33, 984, DateTimeKind.Unspecified).AddTicks(2698), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Plastic Towels" },
                    { 732, new DateTimeOffset(new DateTime(2023, 4, 28, 22, 4, 52, 969, DateTimeKind.Unspecified).AddTicks(520), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Steel Shirt" },
                    { 733, new DateTimeOffset(new DateTime(2023, 5, 8, 20, 11, 45, 483, DateTimeKind.Unspecified).AddTicks(321), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Frozen Shoes" },
                    { 734, new DateTimeOffset(new DateTime(2023, 8, 29, 18, 14, 40, 529, DateTimeKind.Unspecified).AddTicks(7425), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Steel Tuna" },
                    { 735, new DateTimeOffset(new DateTime(2023, 4, 16, 18, 49, 23, 398, DateTimeKind.Unspecified).AddTicks(1481), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Steel Cheese" },
                    { 736, new DateTimeOffset(new DateTime(2023, 9, 24, 13, 53, 50, 905, DateTimeKind.Unspecified).AddTicks(6274), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Frozen Salad" },
                    { 737, new DateTimeOffset(new DateTime(2023, 2, 21, 19, 42, 35, 62, DateTimeKind.Unspecified).AddTicks(7128), new TimeSpan(0, 1, 0, 0, 0)), "Small Rubber Car" },
                    { 738, new DateTimeOffset(new DateTime(2023, 1, 30, 19, 42, 4, 965, DateTimeKind.Unspecified).AddTicks(6722), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Rubber Pizza" },
                    { 739, new DateTimeOffset(new DateTime(2023, 3, 14, 22, 15, 46, 409, DateTimeKind.Unspecified).AddTicks(4831), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Steel Tuna" },
                    { 740, new DateTimeOffset(new DateTime(2023, 4, 16, 9, 56, 49, 616, DateTimeKind.Unspecified).AddTicks(7148), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Steel Pizza" },
                    { 741, new DateTimeOffset(new DateTime(2023, 8, 2, 17, 28, 57, 173, DateTimeKind.Unspecified).AddTicks(6296), new TimeSpan(0, 1, 0, 0, 0)), "Generic Metal Chair" },
                    { 742, new DateTimeOffset(new DateTime(2023, 9, 17, 7, 29, 6, 38, DateTimeKind.Unspecified).AddTicks(4343), new TimeSpan(0, 1, 0, 0, 0)), "Generic Plastic Shoes" },
                    { 743, new DateTimeOffset(new DateTime(2024, 1, 14, 18, 20, 57, 906, DateTimeKind.Unspecified).AddTicks(2514), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Cotton Bacon" },
                    { 744, new DateTimeOffset(new DateTime(2023, 6, 20, 4, 19, 28, 260, DateTimeKind.Unspecified).AddTicks(1909), new TimeSpan(0, 1, 0, 0, 0)), "Small Granite Pants" },
                    { 745, new DateTimeOffset(new DateTime(2023, 8, 7, 0, 28, 48, 698, DateTimeKind.Unspecified).AddTicks(7191), new TimeSpan(0, 1, 0, 0, 0)), "Practical Fresh Car" },
                    { 746, new DateTimeOffset(new DateTime(2023, 11, 18, 23, 10, 1, 780, DateTimeKind.Unspecified).AddTicks(1596), new TimeSpan(0, 1, 0, 0, 0)), "Small Plastic Salad" },
                    { 747, new DateTimeOffset(new DateTime(2023, 2, 1, 17, 28, 49, 332, DateTimeKind.Unspecified).AddTicks(9559), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Cotton Tuna" },
                    { 748, new DateTimeOffset(new DateTime(2023, 3, 12, 16, 10, 38, 461, DateTimeKind.Unspecified).AddTicks(4751), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Granite Tuna" },
                    { 749, new DateTimeOffset(new DateTime(2023, 5, 8, 3, 32, 43, 248, DateTimeKind.Unspecified).AddTicks(857), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Granite Soap" },
                    { 750, new DateTimeOffset(new DateTime(2023, 10, 11, 23, 55, 48, 993, DateTimeKind.Unspecified).AddTicks(6244), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Plastic Car" },
                    { 751, new DateTimeOffset(new DateTime(2023, 12, 27, 21, 40, 11, 971, DateTimeKind.Unspecified).AddTicks(6126), new TimeSpan(0, 1, 0, 0, 0)), "Small Cotton Gloves" },
                    { 752, new DateTimeOffset(new DateTime(2023, 3, 7, 3, 42, 8, 993, DateTimeKind.Unspecified).AddTicks(5187), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Fresh Chips" },
                    { 753, new DateTimeOffset(new DateTime(2023, 2, 10, 10, 52, 17, 768, DateTimeKind.Unspecified).AddTicks(2478), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Concrete Chicken" },
                    { 754, new DateTimeOffset(new DateTime(2023, 5, 20, 11, 32, 48, 499, DateTimeKind.Unspecified).AddTicks(8644), new TimeSpan(0, 1, 0, 0, 0)), "Small Plastic Mouse" },
                    { 755, new DateTimeOffset(new DateTime(2023, 4, 3, 18, 58, 53, 369, DateTimeKind.Unspecified).AddTicks(7501), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Concrete Shoes" },
                    { 756, new DateTimeOffset(new DateTime(2023, 4, 25, 7, 0, 32, 742, DateTimeKind.Unspecified).AddTicks(5565), new TimeSpan(0, 1, 0, 0, 0)), "Generic Cotton Ball" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreationDate", "Name" },
                values: new object[,]
                {
                    { 757, new DateTimeOffset(new DateTime(2023, 7, 24, 23, 26, 50, 901, DateTimeKind.Unspecified).AddTicks(7837), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Metal Bacon" },
                    { 758, new DateTimeOffset(new DateTime(2023, 2, 21, 13, 57, 29, 711, DateTimeKind.Unspecified).AddTicks(1195), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Steel Shoes" },
                    { 759, new DateTimeOffset(new DateTime(2023, 9, 16, 23, 10, 48, 933, DateTimeKind.Unspecified).AddTicks(8367), new TimeSpan(0, 1, 0, 0, 0)), "Refined Plastic Hat" },
                    { 760, new DateTimeOffset(new DateTime(2023, 4, 1, 22, 45, 53, 246, DateTimeKind.Unspecified).AddTicks(7566), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Frozen Computer" },
                    { 761, new DateTimeOffset(new DateTime(2023, 3, 27, 19, 20, 46, 935, DateTimeKind.Unspecified).AddTicks(1062), new TimeSpan(0, 1, 0, 0, 0)), "Practical Granite Gloves" },
                    { 762, new DateTimeOffset(new DateTime(2023, 11, 27, 22, 46, 44, 426, DateTimeKind.Unspecified).AddTicks(3221), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Rubber Computer" },
                    { 763, new DateTimeOffset(new DateTime(2023, 10, 22, 17, 44, 55, 227, DateTimeKind.Unspecified).AddTicks(2949), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Plastic Hat" },
                    { 764, new DateTimeOffset(new DateTime(2023, 8, 21, 17, 21, 28, 999, DateTimeKind.Unspecified).AddTicks(5163), new TimeSpan(0, 1, 0, 0, 0)), "Refined Fresh Computer" },
                    { 765, new DateTimeOffset(new DateTime(2023, 2, 8, 1, 42, 59, 66, DateTimeKind.Unspecified).AddTicks(4550), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Steel Mouse" },
                    { 766, new DateTimeOffset(new DateTime(2023, 9, 22, 17, 16, 57, 399, DateTimeKind.Unspecified).AddTicks(9433), new TimeSpan(0, 1, 0, 0, 0)), "Small Granite Bike" },
                    { 767, new DateTimeOffset(new DateTime(2023, 10, 7, 20, 39, 24, 504, DateTimeKind.Unspecified).AddTicks(4507), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Rubber Bike" },
                    { 768, new DateTimeOffset(new DateTime(2023, 11, 9, 7, 55, 3, 252, DateTimeKind.Unspecified).AddTicks(365), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Granite Shirt" },
                    { 769, new DateTimeOffset(new DateTime(2023, 2, 23, 18, 6, 14, 852, DateTimeKind.Unspecified).AddTicks(7023), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Concrete Cheese" },
                    { 770, new DateTimeOffset(new DateTime(2023, 3, 17, 4, 5, 51, 150, DateTimeKind.Unspecified).AddTicks(7622), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Steel Shoes" },
                    { 771, new DateTimeOffset(new DateTime(2023, 8, 25, 20, 12, 33, 860, DateTimeKind.Unspecified).AddTicks(4402), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Frozen Mouse" },
                    { 772, new DateTimeOffset(new DateTime(2023, 1, 18, 16, 40, 55, 148, DateTimeKind.Unspecified).AddTicks(3029), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Metal Bike" },
                    { 773, new DateTimeOffset(new DateTime(2023, 12, 13, 16, 27, 41, 511, DateTimeKind.Unspecified).AddTicks(1669), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Frozen Towels" },
                    { 774, new DateTimeOffset(new DateTime(2024, 1, 12, 5, 34, 48, 695, DateTimeKind.Unspecified).AddTicks(4607), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Steel Mouse" },
                    { 775, new DateTimeOffset(new DateTime(2023, 3, 28, 16, 54, 58, 28, DateTimeKind.Unspecified).AddTicks(1411), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Metal Table" },
                    { 776, new DateTimeOffset(new DateTime(2023, 11, 3, 20, 42, 15, 883, DateTimeKind.Unspecified).AddTicks(7666), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Cotton Car" },
                    { 777, new DateTimeOffset(new DateTime(2023, 8, 24, 15, 23, 0, 774, DateTimeKind.Unspecified).AddTicks(7009), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Metal Chicken" },
                    { 778, new DateTimeOffset(new DateTime(2023, 2, 5, 3, 10, 2, 253, DateTimeKind.Unspecified).AddTicks(8176), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Steel Shoes" },
                    { 779, new DateTimeOffset(new DateTime(2023, 2, 14, 17, 56, 43, 126, DateTimeKind.Unspecified).AddTicks(2920), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Steel Hat" },
                    { 780, new DateTimeOffset(new DateTime(2023, 1, 31, 22, 35, 27, 551, DateTimeKind.Unspecified).AddTicks(956), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Metal Keyboard" },
                    { 781, new DateTimeOffset(new DateTime(2023, 12, 8, 11, 18, 59, 982, DateTimeKind.Unspecified).AddTicks(9739), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Concrete Hat" },
                    { 782, new DateTimeOffset(new DateTime(2023, 1, 30, 9, 11, 6, 72, DateTimeKind.Unspecified).AddTicks(8338), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Granite Chair" },
                    { 783, new DateTimeOffset(new DateTime(2023, 7, 16, 14, 46, 15, 232, DateTimeKind.Unspecified).AddTicks(1667), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Soft Bacon" },
                    { 784, new DateTimeOffset(new DateTime(2023, 3, 18, 11, 32, 13, 490, DateTimeKind.Unspecified).AddTicks(4385), new TimeSpan(0, 1, 0, 0, 0)), "Generic Plastic Bacon" },
                    { 785, new DateTimeOffset(new DateTime(2023, 11, 5, 23, 49, 19, 808, DateTimeKind.Unspecified).AddTicks(8512), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Cotton Chicken" },
                    { 786, new DateTimeOffset(new DateTime(2023, 3, 29, 17, 8, 38, 721, DateTimeKind.Unspecified).AddTicks(6582), new TimeSpan(0, 1, 0, 0, 0)), "Small Rubber Sausages" },
                    { 787, new DateTimeOffset(new DateTime(2023, 10, 19, 2, 28, 29, 615, DateTimeKind.Unspecified).AddTicks(8782), new TimeSpan(0, 1, 0, 0, 0)), "Practical Granite Gloves" },
                    { 788, new DateTimeOffset(new DateTime(2023, 9, 6, 8, 0, 28, 729, DateTimeKind.Unspecified).AddTicks(9735), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Steel Fish" },
                    { 789, new DateTimeOffset(new DateTime(2023, 3, 10, 10, 53, 26, 383, DateTimeKind.Unspecified).AddTicks(6069), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Cotton Bacon" },
                    { 790, new DateTimeOffset(new DateTime(2023, 6, 23, 20, 17, 59, 678, DateTimeKind.Unspecified).AddTicks(4679), new TimeSpan(0, 1, 0, 0, 0)), "Refined Wooden Bacon" },
                    { 791, new DateTimeOffset(new DateTime(2023, 5, 5, 19, 26, 3, 915, DateTimeKind.Unspecified).AddTicks(7648), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Metal Shoes" },
                    { 792, new DateTimeOffset(new DateTime(2023, 5, 9, 9, 17, 50, 437, DateTimeKind.Unspecified).AddTicks(6493), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Frozen Table" },
                    { 793, new DateTimeOffset(new DateTime(2023, 12, 8, 13, 53, 24, 192, DateTimeKind.Unspecified).AddTicks(2338), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Plastic Mouse" },
                    { 794, new DateTimeOffset(new DateTime(2023, 10, 21, 20, 10, 55, 867, DateTimeKind.Unspecified).AddTicks(6504), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Plastic Chair" },
                    { 795, new DateTimeOffset(new DateTime(2023, 7, 15, 21, 57, 51, 453, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Plastic Table" },
                    { 796, new DateTimeOffset(new DateTime(2023, 1, 21, 9, 17, 6, 12, DateTimeKind.Unspecified).AddTicks(8651), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Plastic Shoes" },
                    { 797, new DateTimeOffset(new DateTime(2023, 4, 6, 3, 16, 58, 172, DateTimeKind.Unspecified).AddTicks(9056), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Concrete Chair" },
                    { 798, new DateTimeOffset(new DateTime(2023, 10, 10, 2, 15, 31, 167, DateTimeKind.Unspecified).AddTicks(3945), new TimeSpan(0, 1, 0, 0, 0)), "Practical Metal Gloves" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreationDate", "Name" },
                values: new object[,]
                {
                    { 799, new DateTimeOffset(new DateTime(2023, 6, 3, 19, 44, 0, 430, DateTimeKind.Unspecified).AddTicks(2240), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Concrete Computer" },
                    { 800, new DateTimeOffset(new DateTime(2023, 7, 12, 13, 3, 25, 765, DateTimeKind.Unspecified).AddTicks(440), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Rubber Chair" },
                    { 801, new DateTimeOffset(new DateTime(2023, 3, 31, 16, 28, 7, 990, DateTimeKind.Unspecified).AddTicks(7658), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Steel Hat" },
                    { 802, new DateTimeOffset(new DateTime(2023, 2, 25, 9, 49, 36, 98, DateTimeKind.Unspecified).AddTicks(8487), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Soft Chicken" },
                    { 803, new DateTimeOffset(new DateTime(2023, 8, 3, 19, 29, 3, 34, DateTimeKind.Unspecified).AddTicks(2864), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Steel Pizza" },
                    { 804, new DateTimeOffset(new DateTime(2023, 6, 11, 18, 28, 38, 320, DateTimeKind.Unspecified).AddTicks(9339), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Plastic Ball" },
                    { 805, new DateTimeOffset(new DateTime(2024, 1, 11, 17, 4, 13, 182, DateTimeKind.Unspecified).AddTicks(3219), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Granite Bike" },
                    { 806, new DateTimeOffset(new DateTime(2023, 8, 15, 8, 7, 44, 987, DateTimeKind.Unspecified).AddTicks(4747), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Concrete Pizza" },
                    { 807, new DateTimeOffset(new DateTime(2023, 9, 18, 16, 45, 11, 397, DateTimeKind.Unspecified).AddTicks(5267), new TimeSpan(0, 1, 0, 0, 0)), "Small Cotton Gloves" },
                    { 808, new DateTimeOffset(new DateTime(2023, 9, 12, 23, 10, 56, 311, DateTimeKind.Unspecified).AddTicks(1051), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Metal Tuna" },
                    { 809, new DateTimeOffset(new DateTime(2023, 3, 6, 17, 7, 45, 302, DateTimeKind.Unspecified).AddTicks(3543), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Frozen Table" },
                    { 810, new DateTimeOffset(new DateTime(2023, 4, 17, 1, 29, 11, 88, DateTimeKind.Unspecified).AddTicks(6081), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Plastic Computer" },
                    { 811, new DateTimeOffset(new DateTime(2023, 6, 16, 10, 4, 31, 590, DateTimeKind.Unspecified).AddTicks(5922), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Frozen Pizza" },
                    { 812, new DateTimeOffset(new DateTime(2023, 4, 22, 3, 8, 28, 20, DateTimeKind.Unspecified).AddTicks(6936), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Soft Chair" },
                    { 813, new DateTimeOffset(new DateTime(2023, 9, 4, 22, 47, 55, 511, DateTimeKind.Unspecified).AddTicks(7543), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Metal Bike" },
                    { 814, new DateTimeOffset(new DateTime(2023, 11, 21, 16, 14, 8, 713, DateTimeKind.Unspecified).AddTicks(2819), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Steel Towels" },
                    { 815, new DateTimeOffset(new DateTime(2023, 7, 1, 13, 56, 3, 93, DateTimeKind.Unspecified).AddTicks(4038), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Frozen Keyboard" },
                    { 816, new DateTimeOffset(new DateTime(2023, 10, 15, 5, 0, 51, 518, DateTimeKind.Unspecified).AddTicks(3382), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Steel Pizza" },
                    { 817, new DateTimeOffset(new DateTime(2023, 10, 23, 10, 36, 20, 792, DateTimeKind.Unspecified).AddTicks(3478), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Concrete Bike" },
                    { 818, new DateTimeOffset(new DateTime(2023, 11, 24, 0, 9, 33, 427, DateTimeKind.Unspecified).AddTicks(528), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Wooden Tuna" },
                    { 819, new DateTimeOffset(new DateTime(2023, 1, 25, 23, 51, 20, 459, DateTimeKind.Unspecified).AddTicks(6956), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Frozen Shoes" },
                    { 820, new DateTimeOffset(new DateTime(2023, 5, 1, 23, 8, 32, 451, DateTimeKind.Unspecified).AddTicks(6158), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Cotton Cheese" },
                    { 821, new DateTimeOffset(new DateTime(2023, 7, 23, 2, 13, 25, 190, DateTimeKind.Unspecified).AddTicks(5280), new TimeSpan(0, 1, 0, 0, 0)), "Practical Steel Chicken" },
                    { 822, new DateTimeOffset(new DateTime(2023, 4, 24, 23, 57, 47, 252, DateTimeKind.Unspecified).AddTicks(4881), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Steel Ball" },
                    { 823, new DateTimeOffset(new DateTime(2023, 11, 6, 1, 8, 8, 379, DateTimeKind.Unspecified).AddTicks(8661), new TimeSpan(0, 1, 0, 0, 0)), "Practical Rubber Chips" },
                    { 824, new DateTimeOffset(new DateTime(2023, 7, 4, 21, 1, 43, 49, DateTimeKind.Unspecified).AddTicks(3937), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Metal Fish" },
                    { 825, new DateTimeOffset(new DateTime(2023, 8, 22, 9, 12, 54, 322, DateTimeKind.Unspecified).AddTicks(7798), new TimeSpan(0, 1, 0, 0, 0)), "Small Steel Chair" },
                    { 826, new DateTimeOffset(new DateTime(2023, 11, 16, 9, 43, 15, 313, DateTimeKind.Unspecified).AddTicks(6277), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Concrete Shirt" },
                    { 827, new DateTimeOffset(new DateTime(2023, 6, 15, 21, 46, 37, 470, DateTimeKind.Unspecified).AddTicks(2259), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Cotton Ball" },
                    { 828, new DateTimeOffset(new DateTime(2023, 10, 12, 0, 59, 27, 74, DateTimeKind.Unspecified).AddTicks(1036), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Granite Shoes" },
                    { 829, new DateTimeOffset(new DateTime(2023, 6, 28, 4, 5, 16, 514, DateTimeKind.Unspecified).AddTicks(159), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Fresh Chair" },
                    { 830, new DateTimeOffset(new DateTime(2023, 6, 11, 18, 14, 59, 568, DateTimeKind.Unspecified).AddTicks(1828), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Plastic Pants" },
                    { 831, new DateTimeOffset(new DateTime(2023, 5, 5, 7, 47, 9, 321, DateTimeKind.Unspecified).AddTicks(8368), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Frozen Pants" },
                    { 832, new DateTimeOffset(new DateTime(2023, 10, 10, 1, 36, 11, 742, DateTimeKind.Unspecified).AddTicks(6533), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Fresh Fish" },
                    { 833, new DateTimeOffset(new DateTime(2023, 5, 3, 2, 4, 52, 168, DateTimeKind.Unspecified).AddTicks(6473), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Steel Chips" },
                    { 834, new DateTimeOffset(new DateTime(2023, 4, 2, 14, 48, 54, 276, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 1, 0, 0, 0)), "Practical Concrete Cheese" },
                    { 835, new DateTimeOffset(new DateTime(2023, 1, 27, 21, 15, 24, 693, DateTimeKind.Unspecified).AddTicks(5394), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Fresh Table" },
                    { 836, new DateTimeOffset(new DateTime(2023, 12, 9, 18, 43, 21, 743, DateTimeKind.Unspecified).AddTicks(3404), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Fresh Fish" },
                    { 837, new DateTimeOffset(new DateTime(2023, 4, 20, 15, 51, 35, 978, DateTimeKind.Unspecified).AddTicks(7155), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Concrete Tuna" },
                    { 838, new DateTimeOffset(new DateTime(2023, 9, 24, 7, 11, 2, 896, DateTimeKind.Unspecified).AddTicks(8938), new TimeSpan(0, 1, 0, 0, 0)), "Generic Plastic Computer" },
                    { 839, new DateTimeOffset(new DateTime(2023, 7, 31, 10, 12, 22, 675, DateTimeKind.Unspecified).AddTicks(9471), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Rubber Tuna" },
                    { 840, new DateTimeOffset(new DateTime(2023, 4, 11, 13, 48, 18, 297, DateTimeKind.Unspecified).AddTicks(3730), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Steel Tuna" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreationDate", "Name" },
                values: new object[,]
                {
                    { 841, new DateTimeOffset(new DateTime(2023, 7, 20, 19, 55, 0, 693, DateTimeKind.Unspecified).AddTicks(6315), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Granite Mouse" },
                    { 842, new DateTimeOffset(new DateTime(2024, 1, 10, 10, 57, 22, 0, DateTimeKind.Unspecified).AddTicks(4341), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Wooden Gloves" },
                    { 843, new DateTimeOffset(new DateTime(2023, 7, 11, 13, 3, 28, 464, DateTimeKind.Unspecified).AddTicks(7678), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Soft Cheese" },
                    { 844, new DateTimeOffset(new DateTime(2023, 2, 21, 5, 58, 44, 991, DateTimeKind.Unspecified).AddTicks(304), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Plastic Tuna" },
                    { 845, new DateTimeOffset(new DateTime(2023, 12, 30, 13, 26, 21, 26, DateTimeKind.Unspecified).AddTicks(6658), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Granite Mouse" },
                    { 846, new DateTimeOffset(new DateTime(2023, 12, 24, 16, 16, 24, 568, DateTimeKind.Unspecified).AddTicks(6706), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Granite Computer" },
                    { 847, new DateTimeOffset(new DateTime(2023, 11, 13, 4, 26, 47, 699, DateTimeKind.Unspecified).AddTicks(8917), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Plastic Hat" },
                    { 848, new DateTimeOffset(new DateTime(2023, 8, 21, 22, 24, 42, 39, DateTimeKind.Unspecified).AddTicks(8510), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Concrete Gloves" },
                    { 849, new DateTimeOffset(new DateTime(2023, 4, 11, 12, 0, 34, 212, DateTimeKind.Unspecified).AddTicks(5361), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Concrete Pants" },
                    { 850, new DateTimeOffset(new DateTime(2023, 12, 28, 1, 55, 9, 419, DateTimeKind.Unspecified).AddTicks(7258), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Concrete Pants" },
                    { 851, new DateTimeOffset(new DateTime(2023, 11, 20, 18, 19, 21, 399, DateTimeKind.Unspecified).AddTicks(6334), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Metal Keyboard" },
                    { 852, new DateTimeOffset(new DateTime(2023, 6, 29, 23, 19, 48, 59, DateTimeKind.Unspecified).AddTicks(5790), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Metal Cheese" },
                    { 853, new DateTimeOffset(new DateTime(2023, 6, 22, 19, 10, 31, 24, DateTimeKind.Unspecified).AddTicks(9886), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Rubber Gloves" },
                    { 854, new DateTimeOffset(new DateTime(2023, 3, 28, 1, 25, 26, 227, DateTimeKind.Unspecified).AddTicks(8280), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Metal Chair" },
                    { 855, new DateTimeOffset(new DateTime(2023, 4, 14, 23, 31, 44, 529, DateTimeKind.Unspecified).AddTicks(5213), new TimeSpan(0, 1, 0, 0, 0)), "Practical Concrete Soap" },
                    { 856, new DateTimeOffset(new DateTime(2023, 11, 23, 14, 5, 56, 283, DateTimeKind.Unspecified).AddTicks(7090), new TimeSpan(0, 1, 0, 0, 0)), "Generic Granite Table" },
                    { 857, new DateTimeOffset(new DateTime(2023, 10, 5, 1, 9, 23, 551, DateTimeKind.Unspecified).AddTicks(6169), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Wooden Ball" },
                    { 858, new DateTimeOffset(new DateTime(2023, 1, 23, 12, 11, 12, 362, DateTimeKind.Unspecified).AddTicks(2032), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Cotton Table" },
                    { 859, new DateTimeOffset(new DateTime(2023, 8, 7, 0, 22, 54, 479, DateTimeKind.Unspecified).AddTicks(5580), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Concrete Chair" },
                    { 860, new DateTimeOffset(new DateTime(2023, 4, 22, 19, 6, 2, 600, DateTimeKind.Unspecified).AddTicks(6549), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Concrete Shirt" },
                    { 861, new DateTimeOffset(new DateTime(2024, 1, 7, 7, 12, 0, 208, DateTimeKind.Unspecified).AddTicks(1903), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Steel Pizza" },
                    { 862, new DateTimeOffset(new DateTime(2023, 7, 23, 1, 30, 25, 122, DateTimeKind.Unspecified).AddTicks(2440), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Fresh Chicken" },
                    { 863, new DateTimeOffset(new DateTime(2023, 6, 25, 10, 16, 59, 53, DateTimeKind.Unspecified).AddTicks(5268), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Wooden Bacon" },
                    { 864, new DateTimeOffset(new DateTime(2023, 6, 26, 1, 33, 32, 837, DateTimeKind.Unspecified).AddTicks(5405), new TimeSpan(0, 1, 0, 0, 0)), "Generic Wooden Gloves" },
                    { 865, new DateTimeOffset(new DateTime(2023, 5, 27, 19, 55, 19, 790, DateTimeKind.Unspecified).AddTicks(4099), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Plastic Pants" },
                    { 866, new DateTimeOffset(new DateTime(2023, 8, 4, 5, 14, 30, 0, DateTimeKind.Unspecified).AddTicks(2801), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Steel Hat" },
                    { 867, new DateTimeOffset(new DateTime(2023, 9, 18, 19, 30, 17, 404, DateTimeKind.Unspecified).AddTicks(1506), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Plastic Pants" },
                    { 868, new DateTimeOffset(new DateTime(2023, 3, 28, 11, 57, 57, 64, DateTimeKind.Unspecified).AddTicks(422), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Granite Salad" },
                    { 869, new DateTimeOffset(new DateTime(2023, 8, 5, 7, 3, 51, 464, DateTimeKind.Unspecified).AddTicks(3112), new TimeSpan(0, 1, 0, 0, 0)), "Refined Plastic Fish" },
                    { 870, new DateTimeOffset(new DateTime(2023, 8, 18, 20, 3, 6, 294, DateTimeKind.Unspecified).AddTicks(5786), new TimeSpan(0, 1, 0, 0, 0)), "Generic Granite Salad" },
                    { 871, new DateTimeOffset(new DateTime(2023, 10, 17, 0, 43, 29, 221, DateTimeKind.Unspecified).AddTicks(1212), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Soft Hat" },
                    { 872, new DateTimeOffset(new DateTime(2024, 1, 8, 21, 20, 19, 981, DateTimeKind.Unspecified).AddTicks(1352), new TimeSpan(0, 1, 0, 0, 0)), "Generic Frozen Shirt" },
                    { 873, new DateTimeOffset(new DateTime(2024, 1, 13, 0, 27, 39, 403, DateTimeKind.Unspecified).AddTicks(6614), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Rubber Pants" },
                    { 874, new DateTimeOffset(new DateTime(2023, 7, 10, 5, 22, 37, 677, DateTimeKind.Unspecified).AddTicks(9811), new TimeSpan(0, 1, 0, 0, 0)), "Refined Steel Salad" },
                    { 875, new DateTimeOffset(new DateTime(2023, 9, 19, 8, 31, 25, 778, DateTimeKind.Unspecified).AddTicks(6021), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Plastic Pizza" },
                    { 876, new DateTimeOffset(new DateTime(2023, 10, 2, 6, 33, 38, 959, DateTimeKind.Unspecified).AddTicks(7178), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Steel Pizza" },
                    { 877, new DateTimeOffset(new DateTime(2023, 4, 30, 15, 11, 21, 214, DateTimeKind.Unspecified).AddTicks(5038), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Rubber Soap" },
                    { 878, new DateTimeOffset(new DateTime(2023, 10, 7, 11, 28, 55, 803, DateTimeKind.Unspecified).AddTicks(4801), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Soft Bacon" },
                    { 879, new DateTimeOffset(new DateTime(2023, 8, 27, 4, 7, 18, 408, DateTimeKind.Unspecified).AddTicks(1445), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Soft Salad" },
                    { 880, new DateTimeOffset(new DateTime(2023, 3, 10, 11, 20, 27, 897, DateTimeKind.Unspecified).AddTicks(414), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Soft Sausages" },
                    { 881, new DateTimeOffset(new DateTime(2023, 2, 13, 0, 23, 9, 182, DateTimeKind.Unspecified).AddTicks(1538), new TimeSpan(0, 1, 0, 0, 0)), "Refined Plastic Cheese" },
                    { 882, new DateTimeOffset(new DateTime(2023, 10, 30, 19, 51, 56, 736, DateTimeKind.Unspecified).AddTicks(5122), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Fresh Gloves" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreationDate", "Name" },
                values: new object[,]
                {
                    { 883, new DateTimeOffset(new DateTime(2023, 5, 7, 3, 25, 42, 62, DateTimeKind.Unspecified).AddTicks(5608), new TimeSpan(0, 1, 0, 0, 0)), "Practical Concrete Chips" },
                    { 884, new DateTimeOffset(new DateTime(2023, 7, 3, 21, 16, 53, 743, DateTimeKind.Unspecified).AddTicks(1872), new TimeSpan(0, 1, 0, 0, 0)), "Generic Concrete Chair" },
                    { 885, new DateTimeOffset(new DateTime(2023, 1, 21, 21, 34, 15, 446, DateTimeKind.Unspecified).AddTicks(4893), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Fresh Shoes" },
                    { 886, new DateTimeOffset(new DateTime(2023, 3, 16, 12, 39, 26, 511, DateTimeKind.Unspecified).AddTicks(9768), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Wooden Towels" },
                    { 887, new DateTimeOffset(new DateTime(2023, 2, 20, 18, 59, 27, 708, DateTimeKind.Unspecified).AddTicks(2884), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Rubber Towels" },
                    { 888, new DateTimeOffset(new DateTime(2023, 11, 3, 2, 32, 12, 144, DateTimeKind.Unspecified).AddTicks(7457), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Plastic Chips" },
                    { 889, new DateTimeOffset(new DateTime(2023, 3, 31, 3, 0, 45, 609, DateTimeKind.Unspecified).AddTicks(1601), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Metal Bacon" },
                    { 890, new DateTimeOffset(new DateTime(2023, 6, 7, 0, 8, 2, 305, DateTimeKind.Unspecified).AddTicks(8411), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Soft Soap" },
                    { 891, new DateTimeOffset(new DateTime(2023, 3, 19, 3, 57, 15, 429, DateTimeKind.Unspecified).AddTicks(6003), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Fresh Pizza" },
                    { 892, new DateTimeOffset(new DateTime(2023, 3, 22, 10, 4, 30, 38, DateTimeKind.Unspecified).AddTicks(8807), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Granite Computer" },
                    { 893, new DateTimeOffset(new DateTime(2023, 9, 23, 13, 2, 52, 130, DateTimeKind.Unspecified).AddTicks(3039), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Cotton Chicken" },
                    { 894, new DateTimeOffset(new DateTime(2023, 10, 23, 18, 29, 13, 55, DateTimeKind.Unspecified).AddTicks(4870), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Frozen Cheese" },
                    { 895, new DateTimeOffset(new DateTime(2023, 7, 13, 1, 47, 31, 777, DateTimeKind.Unspecified).AddTicks(9110), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Rubber Gloves" },
                    { 896, new DateTimeOffset(new DateTime(2023, 3, 15, 20, 0, 1, 985, DateTimeKind.Unspecified).AddTicks(572), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Concrete Soap" },
                    { 897, new DateTimeOffset(new DateTime(2023, 12, 24, 16, 18, 17, 908, DateTimeKind.Unspecified).AddTicks(2289), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Concrete Salad" },
                    { 898, new DateTimeOffset(new DateTime(2023, 3, 8, 3, 59, 33, 502, DateTimeKind.Unspecified).AddTicks(5590), new TimeSpan(0, 1, 0, 0, 0)), "Practical Fresh Mouse" },
                    { 899, new DateTimeOffset(new DateTime(2023, 8, 9, 6, 24, 22, 459, DateTimeKind.Unspecified).AddTicks(5375), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Steel Fish" },
                    { 900, new DateTimeOffset(new DateTime(2023, 4, 19, 6, 34, 3, 801, DateTimeKind.Unspecified).AddTicks(3453), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Cotton Shirt" },
                    { 901, new DateTimeOffset(new DateTime(2023, 10, 17, 5, 23, 35, 489, DateTimeKind.Unspecified).AddTicks(2548), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Cotton Pants" },
                    { 902, new DateTimeOffset(new DateTime(2023, 7, 7, 12, 24, 21, 527, DateTimeKind.Unspecified).AddTicks(7079), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Plastic Shoes" },
                    { 903, new DateTimeOffset(new DateTime(2023, 9, 22, 8, 23, 33, 982, DateTimeKind.Unspecified).AddTicks(8910), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Steel Table" },
                    { 904, new DateTimeOffset(new DateTime(2023, 2, 8, 3, 49, 35, 78, DateTimeKind.Unspecified).AddTicks(3654), new TimeSpan(0, 1, 0, 0, 0)), "Practical Wooden Car" },
                    { 905, new DateTimeOffset(new DateTime(2023, 8, 19, 23, 45, 38, 630, DateTimeKind.Unspecified).AddTicks(8515), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Metal Salad" },
                    { 906, new DateTimeOffset(new DateTime(2023, 12, 18, 16, 33, 7, 458, DateTimeKind.Unspecified).AddTicks(5039), new TimeSpan(0, 1, 0, 0, 0)), "Generic Wooden Fish" },
                    { 907, new DateTimeOffset(new DateTime(2023, 4, 13, 17, 59, 16, 383, DateTimeKind.Unspecified).AddTicks(1152), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Rubber Table" },
                    { 908, new DateTimeOffset(new DateTime(2023, 6, 2, 6, 6, 4, 281, DateTimeKind.Unspecified).AddTicks(6673), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Concrete Shoes" },
                    { 909, new DateTimeOffset(new DateTime(2023, 12, 16, 8, 57, 22, 912, DateTimeKind.Unspecified).AddTicks(3415), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Steel Sausages" },
                    { 910, new DateTimeOffset(new DateTime(2024, 1, 12, 19, 18, 19, 118, DateTimeKind.Unspecified).AddTicks(4869), new TimeSpan(0, 1, 0, 0, 0)), "Refined Fresh Towels" },
                    { 911, new DateTimeOffset(new DateTime(2023, 6, 14, 23, 32, 18, 65, DateTimeKind.Unspecified).AddTicks(7708), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Cotton Chair" },
                    { 912, new DateTimeOffset(new DateTime(2023, 3, 5, 12, 45, 55, 465, DateTimeKind.Unspecified).AddTicks(876), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Granite Chicken" },
                    { 913, new DateTimeOffset(new DateTime(2023, 8, 19, 9, 3, 33, 66, DateTimeKind.Unspecified).AddTicks(1578), new TimeSpan(0, 1, 0, 0, 0)), "Small Metal Pants" },
                    { 914, new DateTimeOffset(new DateTime(2023, 6, 8, 21, 28, 19, 185, DateTimeKind.Unspecified).AddTicks(540), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Soft Tuna" },
                    { 915, new DateTimeOffset(new DateTime(2023, 1, 26, 7, 57, 46, 791, DateTimeKind.Unspecified).AddTicks(409), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Cotton Hat" },
                    { 916, new DateTimeOffset(new DateTime(2023, 10, 10, 0, 31, 56, 802, DateTimeKind.Unspecified).AddTicks(5873), new TimeSpan(0, 1, 0, 0, 0)), "Refined Concrete Ball" },
                    { 917, new DateTimeOffset(new DateTime(2023, 6, 18, 7, 25, 13, 933, DateTimeKind.Unspecified).AddTicks(7587), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Steel Shoes" },
                    { 918, new DateTimeOffset(new DateTime(2023, 5, 16, 14, 4, 29, 342, DateTimeKind.Unspecified).AddTicks(8005), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Wooden Mouse" },
                    { 919, new DateTimeOffset(new DateTime(2023, 3, 14, 12, 50, 12, 196, DateTimeKind.Unspecified).AddTicks(2239), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Fresh Salad" },
                    { 920, new DateTimeOffset(new DateTime(2023, 10, 5, 8, 40, 26, 271, DateTimeKind.Unspecified).AddTicks(4663), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Plastic Hat" },
                    { 921, new DateTimeOffset(new DateTime(2023, 7, 24, 1, 22, 10, 662, DateTimeKind.Unspecified).AddTicks(7652), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Plastic Bike" },
                    { 922, new DateTimeOffset(new DateTime(2023, 6, 15, 11, 36, 36, 473, DateTimeKind.Unspecified).AddTicks(2005), new TimeSpan(0, 1, 0, 0, 0)), "Refined Fresh Pizza" },
                    { 923, new DateTimeOffset(new DateTime(2023, 6, 29, 11, 50, 35, 538, DateTimeKind.Unspecified).AddTicks(7362), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Rubber Ball" },
                    { 924, new DateTimeOffset(new DateTime(2023, 7, 2, 6, 30, 33, 345, DateTimeKind.Unspecified).AddTicks(7174), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Rubber Keyboard" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreationDate", "Name" },
                values: new object[,]
                {
                    { 925, new DateTimeOffset(new DateTime(2023, 5, 28, 13, 59, 56, 991, DateTimeKind.Unspecified).AddTicks(6725), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Plastic Salad" },
                    { 926, new DateTimeOffset(new DateTime(2023, 11, 23, 5, 46, 35, 783, DateTimeKind.Unspecified).AddTicks(5590), new TimeSpan(0, 1, 0, 0, 0)), "Small Concrete Chips" },
                    { 927, new DateTimeOffset(new DateTime(2023, 8, 23, 4, 50, 4, 369, DateTimeKind.Unspecified).AddTicks(4038), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Steel Shoes" },
                    { 928, new DateTimeOffset(new DateTime(2023, 5, 17, 10, 30, 2, 324, DateTimeKind.Unspecified).AddTicks(1932), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Granite Bike" },
                    { 929, new DateTimeOffset(new DateTime(2023, 7, 23, 22, 40, 28, 309, DateTimeKind.Unspecified).AddTicks(299), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Soft Keyboard" },
                    { 930, new DateTimeOffset(new DateTime(2023, 8, 31, 2, 26, 37, 703, DateTimeKind.Unspecified).AddTicks(9122), new TimeSpan(0, 1, 0, 0, 0)), "Small Soft Salad" },
                    { 931, new DateTimeOffset(new DateTime(2023, 8, 27, 23, 46, 52, 309, DateTimeKind.Unspecified).AddTicks(9530), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Steel Chair" },
                    { 932, new DateTimeOffset(new DateTime(2023, 8, 9, 16, 52, 13, 353, DateTimeKind.Unspecified).AddTicks(7978), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Soft Chips" },
                    { 933, new DateTimeOffset(new DateTime(2023, 12, 1, 10, 40, 15, 316, DateTimeKind.Unspecified).AddTicks(2015), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Cotton Chips" },
                    { 934, new DateTimeOffset(new DateTime(2023, 9, 6, 18, 10, 28, 464, DateTimeKind.Unspecified).AddTicks(808), new TimeSpan(0, 1, 0, 0, 0)), "Practical Wooden Chicken" },
                    { 935, new DateTimeOffset(new DateTime(2023, 11, 8, 6, 13, 21, 255, DateTimeKind.Unspecified).AddTicks(2378), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Cotton Chair" },
                    { 936, new DateTimeOffset(new DateTime(2023, 12, 11, 9, 7, 56, 841, DateTimeKind.Unspecified).AddTicks(5125), new TimeSpan(0, 1, 0, 0, 0)), "Practical Concrete Hat" },
                    { 937, new DateTimeOffset(new DateTime(2023, 8, 2, 4, 59, 53, 339, DateTimeKind.Unspecified).AddTicks(5348), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Frozen Hat" },
                    { 938, new DateTimeOffset(new DateTime(2023, 6, 7, 22, 28, 2, 198, DateTimeKind.Unspecified).AddTicks(8942), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Metal Table" },
                    { 939, new DateTimeOffset(new DateTime(2024, 1, 4, 8, 55, 12, 127, DateTimeKind.Unspecified).AddTicks(1728), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Concrete Mouse" },
                    { 940, new DateTimeOffset(new DateTime(2023, 10, 15, 11, 8, 58, 751, DateTimeKind.Unspecified).AddTicks(9961), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Plastic Sausages" },
                    { 941, new DateTimeOffset(new DateTime(2023, 7, 9, 6, 23, 42, 296, DateTimeKind.Unspecified).AddTicks(8907), new TimeSpan(0, 1, 0, 0, 0)), "Small Frozen Pizza" },
                    { 942, new DateTimeOffset(new DateTime(2023, 10, 21, 20, 25, 47, 575, DateTimeKind.Unspecified).AddTicks(9504), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Cotton Salad" },
                    { 943, new DateTimeOffset(new DateTime(2023, 9, 3, 2, 55, 55, 267, DateTimeKind.Unspecified).AddTicks(615), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Granite Mouse" },
                    { 944, new DateTimeOffset(new DateTime(2023, 12, 15, 14, 43, 18, 102, DateTimeKind.Unspecified).AddTicks(8116), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Steel Mouse" },
                    { 945, new DateTimeOffset(new DateTime(2024, 1, 10, 7, 31, 17, 239, DateTimeKind.Unspecified).AddTicks(907), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Wooden Gloves" },
                    { 946, new DateTimeOffset(new DateTime(2023, 2, 26, 5, 4, 0, 108, DateTimeKind.Unspecified).AddTicks(6249), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Cotton Keyboard" },
                    { 947, new DateTimeOffset(new DateTime(2023, 3, 28, 5, 30, 0, 117, DateTimeKind.Unspecified).AddTicks(4644), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Rubber Shoes" },
                    { 948, new DateTimeOffset(new DateTime(2024, 1, 13, 9, 49, 35, 704, DateTimeKind.Unspecified).AddTicks(8054), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Metal Shirt" },
                    { 949, new DateTimeOffset(new DateTime(2023, 7, 22, 5, 46, 40, 707, DateTimeKind.Unspecified).AddTicks(4108), new TimeSpan(0, 1, 0, 0, 0)), "Practical Plastic Cheese" },
                    { 950, new DateTimeOffset(new DateTime(2023, 12, 23, 6, 27, 48, 867, DateTimeKind.Unspecified).AddTicks(5107), new TimeSpan(0, 1, 0, 0, 0)), "Practical Steel Shirt" },
                    { 951, new DateTimeOffset(new DateTime(2023, 12, 15, 14, 49, 37, 815, DateTimeKind.Unspecified).AddTicks(2965), new TimeSpan(0, 1, 0, 0, 0)), "Small Soft Table" },
                    { 952, new DateTimeOffset(new DateTime(2023, 5, 9, 10, 17, 43, 865, DateTimeKind.Unspecified).AddTicks(5550), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Soft Tuna" },
                    { 953, new DateTimeOffset(new DateTime(2023, 2, 26, 1, 29, 19, 254, DateTimeKind.Unspecified).AddTicks(3252), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Concrete Shirt" },
                    { 954, new DateTimeOffset(new DateTime(2023, 8, 27, 21, 10, 45, 495, DateTimeKind.Unspecified).AddTicks(9388), new TimeSpan(0, 1, 0, 0, 0)), "Small Frozen Towels" },
                    { 955, new DateTimeOffset(new DateTime(2023, 12, 8, 20, 32, 8, 751, DateTimeKind.Unspecified).AddTicks(4730), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Soft Shoes" },
                    { 956, new DateTimeOffset(new DateTime(2023, 6, 12, 22, 40, 38, 184, DateTimeKind.Unspecified).AddTicks(5345), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Metal Bacon" },
                    { 957, new DateTimeOffset(new DateTime(2023, 6, 28, 15, 8, 0, 841, DateTimeKind.Unspecified).AddTicks(9032), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Wooden Mouse" },
                    { 958, new DateTimeOffset(new DateTime(2023, 7, 30, 13, 58, 59, 338, DateTimeKind.Unspecified).AddTicks(1530), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Metal Shoes" },
                    { 959, new DateTimeOffset(new DateTime(2023, 6, 22, 5, 3, 51, 83, DateTimeKind.Unspecified).AddTicks(6487), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Cotton Sausages" },
                    { 960, new DateTimeOffset(new DateTime(2023, 3, 19, 19, 33, 39, 998, DateTimeKind.Unspecified).AddTicks(5457), new TimeSpan(0, 1, 0, 0, 0)), "Small Concrete Tuna" },
                    { 961, new DateTimeOffset(new DateTime(2023, 9, 29, 6, 54, 51, 328, DateTimeKind.Unspecified).AddTicks(332), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Wooden Keyboard" },
                    { 962, new DateTimeOffset(new DateTime(2023, 7, 6, 21, 10, 25, 402, DateTimeKind.Unspecified).AddTicks(8673), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Plastic Sausages" },
                    { 963, new DateTimeOffset(new DateTime(2023, 9, 23, 19, 58, 18, 712, DateTimeKind.Unspecified).AddTicks(2719), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Wooden Fish" },
                    { 964, new DateTimeOffset(new DateTime(2023, 5, 26, 21, 15, 36, 146, DateTimeKind.Unspecified).AddTicks(5853), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Granite Car" },
                    { 965, new DateTimeOffset(new DateTime(2023, 5, 4, 18, 13, 44, 982, DateTimeKind.Unspecified).AddTicks(253), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Steel Bacon" },
                    { 966, new DateTimeOffset(new DateTime(2023, 6, 7, 6, 11, 55, 311, DateTimeKind.Unspecified).AddTicks(1455), new TimeSpan(0, 1, 0, 0, 0)), "Generic Concrete Chips" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreationDate", "Name" },
                values: new object[,]
                {
                    { 967, new DateTimeOffset(new DateTime(2023, 9, 20, 13, 38, 48, 644, DateTimeKind.Unspecified).AddTicks(957), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Fresh Shirt" },
                    { 968, new DateTimeOffset(new DateTime(2023, 7, 27, 22, 48, 26, 817, DateTimeKind.Unspecified).AddTicks(4787), new TimeSpan(0, 1, 0, 0, 0)), "Small Wooden Soap" },
                    { 969, new DateTimeOffset(new DateTime(2023, 10, 1, 14, 54, 24, 396, DateTimeKind.Unspecified).AddTicks(1200), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Plastic Sausages" },
                    { 970, new DateTimeOffset(new DateTime(2023, 11, 1, 22, 51, 34, 601, DateTimeKind.Unspecified).AddTicks(8555), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Wooden Computer" },
                    { 971, new DateTimeOffset(new DateTime(2023, 3, 20, 10, 45, 9, 433, DateTimeKind.Unspecified).AddTicks(9787), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Metal Chicken" },
                    { 972, new DateTimeOffset(new DateTime(2023, 4, 4, 11, 14, 41, 871, DateTimeKind.Unspecified).AddTicks(7606), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Soft Chips" },
                    { 973, new DateTimeOffset(new DateTime(2023, 1, 18, 4, 16, 0, 226, DateTimeKind.Unspecified).AddTicks(5576), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Rubber Table" },
                    { 974, new DateTimeOffset(new DateTime(2023, 10, 15, 11, 50, 6, 332, DateTimeKind.Unspecified).AddTicks(4573), new TimeSpan(0, 1, 0, 0, 0)), "Practical Plastic Towels" },
                    { 975, new DateTimeOffset(new DateTime(2023, 6, 27, 16, 18, 54, 142, DateTimeKind.Unspecified).AddTicks(1905), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Soft Sausages" },
                    { 976, new DateTimeOffset(new DateTime(2023, 9, 4, 16, 13, 10, 246, DateTimeKind.Unspecified).AddTicks(1277), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Concrete Table" },
                    { 977, new DateTimeOffset(new DateTime(2023, 4, 6, 19, 58, 12, 15, DateTimeKind.Unspecified).AddTicks(6677), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Concrete Soap" },
                    { 978, new DateTimeOffset(new DateTime(2023, 12, 6, 22, 58, 49, 788, DateTimeKind.Unspecified).AddTicks(1897), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Plastic Bacon" },
                    { 979, new DateTimeOffset(new DateTime(2023, 12, 10, 3, 21, 25, 844, DateTimeKind.Unspecified).AddTicks(1154), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Steel Car" },
                    { 980, new DateTimeOffset(new DateTime(2024, 1, 6, 11, 44, 21, 896, DateTimeKind.Unspecified).AddTicks(3451), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Soft Table" },
                    { 981, new DateTimeOffset(new DateTime(2023, 6, 26, 10, 27, 39, 2, DateTimeKind.Unspecified).AddTicks(9025), new TimeSpan(0, 1, 0, 0, 0)), "Refined Wooden Pants" },
                    { 982, new DateTimeOffset(new DateTime(2023, 10, 19, 8, 56, 58, 194, DateTimeKind.Unspecified).AddTicks(1493), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Rubber Computer" },
                    { 983, new DateTimeOffset(new DateTime(2023, 11, 12, 16, 52, 11, 769, DateTimeKind.Unspecified).AddTicks(2158), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Concrete Hat" },
                    { 984, new DateTimeOffset(new DateTime(2024, 1, 6, 1, 56, 53, 910, DateTimeKind.Unspecified).AddTicks(4888), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Metal Salad" },
                    { 985, new DateTimeOffset(new DateTime(2023, 10, 5, 7, 52, 10, 693, DateTimeKind.Unspecified).AddTicks(9299), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Steel Soap" },
                    { 986, new DateTimeOffset(new DateTime(2024, 1, 10, 15, 11, 41, 766, DateTimeKind.Unspecified).AddTicks(5952), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Soft Tuna" },
                    { 987, new DateTimeOffset(new DateTime(2023, 6, 6, 23, 32, 32, 41, DateTimeKind.Unspecified).AddTicks(9975), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Rubber Car" },
                    { 988, new DateTimeOffset(new DateTime(2023, 5, 31, 15, 33, 53, 226, DateTimeKind.Unspecified).AddTicks(3), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Metal Bike" },
                    { 989, new DateTimeOffset(new DateTime(2023, 10, 9, 11, 55, 26, 438, DateTimeKind.Unspecified).AddTicks(8282), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Frozen Towels" },
                    { 990, new DateTimeOffset(new DateTime(2024, 1, 5, 1, 6, 41, 540, DateTimeKind.Unspecified).AddTicks(635), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Steel Chips" },
                    { 991, new DateTimeOffset(new DateTime(2023, 5, 31, 5, 16, 33, 658, DateTimeKind.Unspecified).AddTicks(6317), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Fresh Table" },
                    { 992, new DateTimeOffset(new DateTime(2023, 4, 29, 2, 41, 9, 547, DateTimeKind.Unspecified).AddTicks(6247), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Frozen Fish" },
                    { 993, new DateTimeOffset(new DateTime(2023, 6, 26, 11, 3, 28, 239, DateTimeKind.Unspecified).AddTicks(8881), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Steel Soap" },
                    { 994, new DateTimeOffset(new DateTime(2023, 2, 21, 19, 6, 58, 807, DateTimeKind.Unspecified).AddTicks(3506), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Soft Cheese" },
                    { 995, new DateTimeOffset(new DateTime(2023, 2, 24, 3, 41, 22, 665, DateTimeKind.Unspecified).AddTicks(7474), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Cotton Tuna" },
                    { 996, new DateTimeOffset(new DateTime(2023, 3, 1, 7, 26, 28, 588, DateTimeKind.Unspecified).AddTicks(712), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Metal Shoes" },
                    { 997, new DateTimeOffset(new DateTime(2023, 4, 6, 18, 1, 47, 344, DateTimeKind.Unspecified).AddTicks(2357), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Wooden Hat" },
                    { 998, new DateTimeOffset(new DateTime(2023, 4, 27, 11, 38, 55, 514, DateTimeKind.Unspecified).AddTicks(8121), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Wooden Car" },
                    { 999, new DateTimeOffset(new DateTime(2023, 6, 6, 4, 15, 14, 659, DateTimeKind.Unspecified).AddTicks(9973), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Metal Soap" },
                    { 1000, new DateTimeOffset(new DateTime(2023, 11, 8, 19, 46, 20, 880, DateTimeKind.Unspecified).AddTicks(356), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Plastic Keyboard" }
                });

            migrationBuilder.InsertData(
                table: "ProductCategory",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Shoes" },
                    { 2, "Grocery" },
                    { 3, "Books" },
                    { 4, "Games" },
                    { 5, "Home" },
                    { 6, "Sports" },
                    { 7, "Tools" },
                    { 8, "Clothing" }
                });

            migrationBuilder.InsertData(
                table: "ProductCategory",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 9, "Beauty" },
                    { 10, "Baby" },
                    { 11, "Books" },
                    { 12, "Movies" },
                    { 13, "Grocery" },
                    { 14, "Toys" },
                    { 15, "Beauty" },
                    { 16, "Baby" },
                    { 17, "Home" },
                    { 18, "Toys" },
                    { 19, "Outdoors" },
                    { 20, "Tools" },
                    { 21, "Kids" },
                    { 22, "Music" },
                    { 23, "Music" },
                    { 24, "Health" },
                    { 25, "Sports" },
                    { 26, "Music" },
                    { 27, "Home" },
                    { 28, "Clothing" },
                    { 29, "Music" },
                    { 30, "Baby" },
                    { 31, "Games" },
                    { 32, "Outdoors" },
                    { 33, "Garden" },
                    { 34, "Beauty" },
                    { 35, "Sports" },
                    { 36, "Shoes" },
                    { 37, "Garden" },
                    { 38, "Electronics" },
                    { 39, "Health" },
                    { 40, "Baby" },
                    { 41, "Clothing" },
                    { 42, "Grocery" },
                    { 43, "Baby" },
                    { 44, "Clothing" },
                    { 45, "Garden" },
                    { 46, "Music" },
                    { 47, "Toys" },
                    { 48, "Grocery" },
                    { 49, "Sports" },
                    { 50, "Movies" }
                });

            migrationBuilder.InsertData(
                table: "ProductProductCategory",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 40, 1 },
                    { 38, 4 },
                    { 17, 5 },
                    { 49, 5 },
                    { 4, 7 },
                    { 24, 7 },
                    { 39, 7 },
                    { 41, 7 },
                    { 16, 8 },
                    { 5, 9 },
                    { 32, 10 },
                    { 49, 10 },
                    { 34, 11 },
                    { 43, 12 },
                    { 8, 14 },
                    { 14, 14 },
                    { 21, 16 },
                    { 2, 20 },
                    { 25, 20 },
                    { 45, 20 },
                    { 50, 20 },
                    { 6, 21 },
                    { 4, 22 },
                    { 20, 22 },
                    { 24, 22 },
                    { 8, 23 },
                    { 13, 23 },
                    { 32, 25 },
                    { 44, 25 },
                    { 6, 26 },
                    { 6, 28 },
                    { 8, 28 },
                    { 36, 28 },
                    { 35, 29 },
                    { 34, 31 },
                    { 1, 32 },
                    { 25, 32 },
                    { 9, 33 },
                    { 24, 33 },
                    { 28, 34 },
                    { 13, 37 },
                    { 4, 38 }
                });

            migrationBuilder.InsertData(
                table: "ProductProductCategory",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 32, 38 },
                    { 35, 38 },
                    { 30, 39 },
                    { 10, 41 },
                    { 11, 42 },
                    { 39, 43 },
                    { 21, 46 },
                    { 48, 47 },
                    { 20, 48 },
                    { 13, 49 },
                    { 40, 49 },
                    { 42, 49 },
                    { 45, 50 },
                    { 14, 51 },
                    { 25, 51 },
                    { 26, 51 },
                    { 4, 52 },
                    { 2, 54 },
                    { 31, 56 },
                    { 46, 57 },
                    { 4, 59 },
                    { 44, 59 },
                    { 11, 61 },
                    { 35, 61 },
                    { 22, 64 },
                    { 25, 64 },
                    { 36, 64 },
                    { 7, 65 },
                    { 16, 66 },
                    { 36, 66 },
                    { 40, 66 },
                    { 26, 67 },
                    { 36, 68 },
                    { 48, 68 },
                    { 38, 69 },
                    { 5, 70 },
                    { 13, 70 },
                    { 46, 70 },
                    { 49, 70 },
                    { 12, 72 },
                    { 35, 73 },
                    { 40, 73 }
                });

            migrationBuilder.InsertData(
                table: "ProductProductCategory",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 32, 74 },
                    { 47, 76 },
                    { 11, 77 },
                    { 36, 77 },
                    { 16, 78 },
                    { 20, 79 },
                    { 37, 79 },
                    { 38, 80 },
                    { 46, 81 },
                    { 32, 82 },
                    { 12, 84 },
                    { 3, 85 },
                    { 49, 86 },
                    { 11, 87 },
                    { 43, 89 },
                    { 47, 90 },
                    { 23, 94 },
                    { 31, 95 },
                    { 20, 98 },
                    { 34, 98 },
                    { 48, 100 },
                    { 32, 103 },
                    { 48, 107 },
                    { 21, 108 },
                    { 38, 109 },
                    { 8, 110 },
                    { 24, 112 },
                    { 36, 112 },
                    { 28, 113 },
                    { 33, 114 },
                    { 12, 116 },
                    { 28, 116 },
                    { 34, 116 },
                    { 37, 116 },
                    { 42, 116 },
                    { 22, 117 },
                    { 29, 118 },
                    { 5, 119 },
                    { 16, 119 },
                    { 33, 120 },
                    { 23, 121 },
                    { 48, 122 }
                });

            migrationBuilder.InsertData(
                table: "ProductProductCategory",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 35, 124 },
                    { 15, 126 },
                    { 38, 127 },
                    { 48, 127 },
                    { 45, 128 },
                    { 49, 134 },
                    { 30, 135 },
                    { 36, 135 },
                    { 29, 136 },
                    { 26, 137 },
                    { 13, 138 },
                    { 5, 139 },
                    { 30, 139 },
                    { 48, 139 },
                    { 10, 142 },
                    { 47, 142 },
                    { 30, 144 },
                    { 50, 144 },
                    { 39, 145 },
                    { 45, 147 },
                    { 32, 148 },
                    { 20, 149 },
                    { 45, 150 },
                    { 6, 151 },
                    { 27, 151 },
                    { 15, 152 },
                    { 23, 152 },
                    { 14, 153 },
                    { 25, 153 },
                    { 28, 158 },
                    { 42, 159 },
                    { 45, 160 },
                    { 44, 161 },
                    { 29, 162 },
                    { 25, 164 },
                    { 40, 164 },
                    { 10, 166 },
                    { 43, 166 },
                    { 5, 167 },
                    { 37, 167 },
                    { 25, 168 },
                    { 11, 170 }
                });

            migrationBuilder.InsertData(
                table: "ProductProductCategory",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 24, 171 },
                    { 25, 171 },
                    { 11, 172 },
                    { 42, 177 },
                    { 45, 178 },
                    { 18, 179 },
                    { 29, 180 },
                    { 2, 181 },
                    { 50, 181 },
                    { 2, 183 },
                    { 9, 183 },
                    { 30, 183 },
                    { 9, 184 },
                    { 26, 184 },
                    { 45, 184 },
                    { 25, 186 },
                    { 50, 187 },
                    { 31, 188 },
                    { 40, 191 },
                    { 47, 192 },
                    { 6, 193 },
                    { 34, 193 },
                    { 15, 195 },
                    { 50, 197 },
                    { 41, 198 },
                    { 4, 199 },
                    { 37, 199 },
                    { 40, 199 },
                    { 27, 201 },
                    { 7, 202 },
                    { 26, 203 },
                    { 35, 207 },
                    { 2, 208 },
                    { 26, 208 },
                    { 35, 209 },
                    { 11, 210 },
                    { 4, 211 },
                    { 34, 212 },
                    { 49, 213 },
                    { 11, 215 },
                    { 11, 216 },
                    { 16, 217 }
                });

            migrationBuilder.InsertData(
                table: "ProductProductCategory",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 17, 220 },
                    { 32, 223 },
                    { 21, 224 },
                    { 13, 227 },
                    { 28, 227 },
                    { 17, 228 },
                    { 27, 228 },
                    { 30, 228 },
                    { 42, 229 },
                    { 32, 230 },
                    { 13, 231 },
                    { 42, 231 },
                    { 9, 234 },
                    { 17, 234 },
                    { 22, 235 },
                    { 40, 235 },
                    { 49, 235 },
                    { 26, 238 },
                    { 3, 239 },
                    { 28, 239 },
                    { 22, 241 },
                    { 2, 242 },
                    { 30, 242 },
                    { 50, 245 },
                    { 35, 248 },
                    { 18, 249 },
                    { 31, 249 },
                    { 39, 249 },
                    { 21, 250 },
                    { 41, 250 },
                    { 3, 251 },
                    { 35, 253 },
                    { 16, 255 },
                    { 13, 256 },
                    { 20, 256 },
                    { 36, 258 },
                    { 19, 259 },
                    { 16, 262 },
                    { 18, 263 },
                    { 46, 263 },
                    { 49, 264 },
                    { 45, 265 }
                });

            migrationBuilder.InsertData(
                table: "ProductProductCategory",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 4, 266 },
                    { 6, 268 },
                    { 24, 268 },
                    { 8, 269 },
                    { 1, 270 },
                    { 12, 271 },
                    { 17, 271 },
                    { 15, 272 },
                    { 30, 272 },
                    { 37, 272 },
                    { 4, 273 },
                    { 23, 276 },
                    { 50, 276 },
                    { 1, 278 },
                    { 4, 278 },
                    { 50, 280 },
                    { 18, 281 },
                    { 33, 281 },
                    { 23, 282 },
                    { 31, 282 },
                    { 12, 285 },
                    { 23, 285 },
                    { 23, 286 },
                    { 34, 286 },
                    { 42, 286 },
                    { 26, 287 },
                    { 32, 287 },
                    { 36, 288 },
                    { 10, 289 },
                    { 18, 289 },
                    { 50, 289 },
                    { 28, 291 },
                    { 9, 293 },
                    { 42, 294 },
                    { 37, 300 },
                    { 29, 302 },
                    { 34, 302 },
                    { 28, 303 },
                    { 25, 306 },
                    { 21, 307 },
                    { 21, 308 },
                    { 37, 311 }
                });

            migrationBuilder.InsertData(
                table: "ProductProductCategory",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 19, 312 },
                    { 48, 313 },
                    { 10, 314 },
                    { 43, 314 },
                    { 45, 314 },
                    { 6, 315 },
                    { 41, 315 },
                    { 20, 316 },
                    { 44, 323 },
                    { 45, 323 },
                    { 8, 324 },
                    { 20, 324 },
                    { 28, 324 },
                    { 14, 326 },
                    { 38, 326 },
                    { 14, 327 },
                    { 50, 327 },
                    { 37, 330 },
                    { 20, 332 },
                    { 35, 333 },
                    { 2, 336 },
                    { 5, 336 },
                    { 6, 337 },
                    { 8, 337 },
                    { 24, 337 },
                    { 45, 337 },
                    { 50, 337 },
                    { 25, 338 },
                    { 27, 340 },
                    { 21, 341 },
                    { 37, 341 },
                    { 14, 342 },
                    { 26, 342 },
                    { 13, 343 },
                    { 48, 343 },
                    { 8, 344 },
                    { 20, 345 },
                    { 31, 348 },
                    { 5, 349 },
                    { 31, 349 },
                    { 9, 350 },
                    { 16, 350 }
                });

            migrationBuilder.InsertData(
                table: "ProductProductCategory",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 9, 351 },
                    { 6, 353 },
                    { 34, 357 },
                    { 6, 358 },
                    { 18, 358 },
                    { 25, 358 },
                    { 31, 358 },
                    { 33, 358 },
                    { 8, 359 },
                    { 48, 361 },
                    { 12, 362 },
                    { 48, 363 },
                    { 44, 366 },
                    { 33, 367 },
                    { 26, 368 },
                    { 10, 369 },
                    { 42, 369 },
                    { 10, 370 },
                    { 40, 370 },
                    { 40, 371 },
                    { 30, 373 },
                    { 39, 373 },
                    { 36, 374 },
                    { 46, 374 },
                    { 18, 375 },
                    { 5, 376 },
                    { 44, 378 },
                    { 12, 383 },
                    { 45, 383 },
                    { 2, 384 },
                    { 20, 384 },
                    { 25, 384 },
                    { 2, 385 },
                    { 37, 387 },
                    { 16, 388 },
                    { 48, 388 },
                    { 5, 389 },
                    { 40, 391 },
                    { 16, 394 },
                    { 41, 394 },
                    { 50, 395 },
                    { 17, 397 }
                });

            migrationBuilder.InsertData(
                table: "ProductProductCategory",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 32, 398 },
                    { 48, 398 },
                    { 19, 399 },
                    { 35, 399 },
                    { 41, 399 },
                    { 20, 400 },
                    { 27, 400 },
                    { 45, 400 },
                    { 4, 402 },
                    { 7, 405 },
                    { 35, 406 },
                    { 9, 409 },
                    { 44, 410 },
                    { 14, 413 },
                    { 49, 413 },
                    { 11, 414 },
                    { 15, 414 },
                    { 5, 415 },
                    { 6, 415 },
                    { 42, 416 },
                    { 7, 417 },
                    { 18, 418 },
                    { 30, 420 },
                    { 2, 421 },
                    { 23, 421 },
                    { 16, 422 },
                    { 26, 422 },
                    { 43, 422 },
                    { 15, 425 },
                    { 26, 428 },
                    { 12, 430 },
                    { 12, 431 },
                    { 41, 431 },
                    { 24, 434 },
                    { 30, 436 },
                    { 39, 437 },
                    { 39, 440 },
                    { 12, 443 },
                    { 23, 443 },
                    { 29, 443 },
                    { 38, 444 },
                    { 13, 445 }
                });

            migrationBuilder.InsertData(
                table: "ProductProductCategory",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 42, 445 },
                    { 12, 446 },
                    { 2, 447 },
                    { 8, 447 },
                    { 29, 448 },
                    { 41, 448 },
                    { 37, 451 },
                    { 38, 452 },
                    { 39, 453 },
                    { 45, 454 },
                    { 23, 457 },
                    { 50, 457 },
                    { 22, 458 },
                    { 28, 458 },
                    { 41, 459 },
                    { 8, 460 },
                    { 9, 460 },
                    { 2, 463 },
                    { 1, 465 },
                    { 13, 465 },
                    { 3, 466 },
                    { 46, 467 },
                    { 8, 468 },
                    { 10, 469 },
                    { 13, 470 },
                    { 7, 471 },
                    { 47, 471 },
                    { 20, 472 },
                    { 7, 473 },
                    { 35, 473 },
                    { 42, 476 },
                    { 10, 477 },
                    { 38, 477 },
                    { 26, 479 },
                    { 34, 479 },
                    { 36, 479 },
                    { 16, 480 },
                    { 1, 484 },
                    { 26, 484 },
                    { 42, 485 },
                    { 7, 486 },
                    { 12, 487 }
                });

            migrationBuilder.InsertData(
                table: "ProductProductCategory",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 49, 487 },
                    { 3, 489 },
                    { 21, 490 },
                    { 6, 491 },
                    { 1, 492 },
                    { 3, 492 },
                    { 25, 492 },
                    { 29, 494 },
                    { 2, 495 },
                    { 8, 496 },
                    { 13, 496 },
                    { 29, 498 },
                    { 31, 500 },
                    { 19, 502 },
                    { 36, 502 },
                    { 43, 502 },
                    { 7, 504 },
                    { 10, 504 },
                    { 13, 505 },
                    { 28, 505 },
                    { 4, 507 },
                    { 33, 507 },
                    { 15, 508 },
                    { 49, 510 },
                    { 34, 511 },
                    { 45, 513 },
                    { 5, 514 },
                    { 9, 514 },
                    { 27, 514 },
                    { 22, 515 },
                    { 8, 516 },
                    { 27, 518 },
                    { 35, 518 },
                    { 31, 520 },
                    { 35, 520 },
                    { 33, 523 },
                    { 24, 528 },
                    { 16, 529 },
                    { 25, 530 },
                    { 35, 530 },
                    { 44, 531 },
                    { 43, 533 }
                });

            migrationBuilder.InsertData(
                table: "ProductProductCategory",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 28, 534 },
                    { 33, 534 },
                    { 15, 535 },
                    { 31, 535 },
                    { 34, 535 },
                    { 35, 535 },
                    { 36, 535 },
                    { 47, 535 },
                    { 31, 536 },
                    { 40, 536 },
                    { 19, 537 },
                    { 30, 537 },
                    { 3, 539 },
                    { 19, 539 },
                    { 40, 540 },
                    { 18, 541 },
                    { 25, 541 },
                    { 48, 542 },
                    { 49, 543 },
                    { 49, 544 },
                    { 20, 545 },
                    { 32, 545 },
                    { 28, 550 },
                    { 13, 552 },
                    { 45, 552 },
                    { 43, 553 },
                    { 21, 554 },
                    { 10, 557 },
                    { 26, 557 },
                    { 50, 558 },
                    { 19, 559 },
                    { 5, 560 },
                    { 48, 560 },
                    { 41, 561 },
                    { 43, 561 },
                    { 8, 563 },
                    { 21, 563 },
                    { 41, 563 },
                    { 40, 564 },
                    { 37, 565 },
                    { 44, 565 },
                    { 19, 566 }
                });

            migrationBuilder.InsertData(
                table: "ProductProductCategory",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 49, 566 },
                    { 16, 567 },
                    { 35, 567 },
                    { 8, 568 },
                    { 3, 570 },
                    { 30, 571 },
                    { 15, 572 },
                    { 42, 572 },
                    { 2, 577 },
                    { 14, 577 },
                    { 31, 577 },
                    { 43, 577 },
                    { 25, 578 },
                    { 32, 578 },
                    { 41, 578 },
                    { 22, 581 },
                    { 14, 582 },
                    { 24, 582 },
                    { 37, 582 },
                    { 13, 584 },
                    { 28, 586 },
                    { 42, 586 },
                    { 13, 587 },
                    { 30, 587 },
                    { 23, 588 },
                    { 39, 589 },
                    { 24, 590 },
                    { 44, 591 },
                    { 28, 595 },
                    { 22, 597 },
                    { 24, 597 },
                    { 40, 597 },
                    { 6, 598 },
                    { 9, 598 },
                    { 23, 599 },
                    { 12, 600 },
                    { 7, 601 },
                    { 22, 601 },
                    { 44, 601 },
                    { 8, 602 },
                    { 22, 605 },
                    { 23, 605 }
                });

            migrationBuilder.InsertData(
                table: "ProductProductCategory",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 34, 607 },
                    { 2, 609 },
                    { 30, 612 },
                    { 2, 615 },
                    { 21, 615 },
                    { 32, 616 },
                    { 35, 616 },
                    { 16, 617 },
                    { 45, 619 },
                    { 3, 620 },
                    { 21, 621 },
                    { 1, 622 },
                    { 15, 624 },
                    { 34, 626 },
                    { 49, 626 },
                    { 7, 627 },
                    { 10, 627 },
                    { 29, 628 },
                    { 37, 634 },
                    { 30, 636 },
                    { 49, 636 },
                    { 5, 637 },
                    { 33, 637 },
                    { 34, 637 },
                    { 36, 637 },
                    { 14, 638 },
                    { 49, 639 },
                    { 41, 640 },
                    { 42, 641 },
                    { 5, 642 },
                    { 8, 642 },
                    { 19, 642 },
                    { 45, 642 },
                    { 41, 647 },
                    { 46, 647 },
                    { 3, 649 },
                    { 9, 649 },
                    { 37, 650 },
                    { 42, 651 },
                    { 35, 652 },
                    { 25, 653 },
                    { 45, 654 }
                });

            migrationBuilder.InsertData(
                table: "ProductProductCategory",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 46, 654 },
                    { 14, 655 },
                    { 40, 655 },
                    { 4, 657 },
                    { 13, 657 },
                    { 24, 657 },
                    { 30, 658 },
                    { 32, 659 },
                    { 8, 661 },
                    { 21, 661 },
                    { 50, 661 },
                    { 44, 663 },
                    { 16, 664 },
                    { 26, 664 },
                    { 38, 664 },
                    { 3, 665 },
                    { 9, 665 },
                    { 3, 666 },
                    { 41, 666 },
                    { 46, 666 },
                    { 1, 667 },
                    { 11, 667 },
                    { 44, 668 },
                    { 8, 669 },
                    { 15, 670 },
                    { 20, 672 },
                    { 43, 672 },
                    { 47, 672 },
                    { 27, 674 },
                    { 39, 675 },
                    { 6, 676 },
                    { 5, 677 },
                    { 29, 677 },
                    { 21, 678 },
                    { 32, 678 },
                    { 36, 678 },
                    { 16, 680 },
                    { 41, 680 },
                    { 11, 681 },
                    { 49, 681 },
                    { 48, 682 },
                    { 23, 683 }
                });

            migrationBuilder.InsertData(
                table: "ProductProductCategory",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 21, 685 },
                    { 37, 685 },
                    { 2, 686 },
                    { 4, 686 },
                    { 32, 686 },
                    { 48, 687 },
                    { 20, 688 },
                    { 21, 688 },
                    { 5, 689 },
                    { 6, 689 },
                    { 29, 690 },
                    { 4, 691 },
                    { 7, 693 },
                    { 48, 693 },
                    { 19, 694 },
                    { 18, 695 },
                    { 36, 695 },
                    { 27, 698 },
                    { 40, 699 },
                    { 6, 700 },
                    { 7, 701 },
                    { 29, 702 },
                    { 15, 703 },
                    { 32, 703 },
                    { 35, 704 },
                    { 47, 705 },
                    { 49, 707 },
                    { 45, 708 },
                    { 13, 709 },
                    { 14, 709 },
                    { 32, 709 },
                    { 34, 711 },
                    { 43, 711 },
                    { 4, 712 },
                    { 4, 713 },
                    { 8, 713 },
                    { 48, 715 },
                    { 2, 717 },
                    { 8, 718 },
                    { 27, 719 },
                    { 20, 720 },
                    { 18, 721 }
                });

            migrationBuilder.InsertData(
                table: "ProductProductCategory",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 50, 722 },
                    { 46, 725 },
                    { 33, 727 },
                    { 40, 728 },
                    { 3, 729 },
                    { 16, 729 },
                    { 40, 729 },
                    { 38, 731 },
                    { 21, 732 },
                    { 38, 734 },
                    { 39, 734 },
                    { 50, 734 },
                    { 21, 737 },
                    { 13, 738 },
                    { 11, 739 },
                    { 14, 740 },
                    { 18, 740 },
                    { 22, 741 },
                    { 44, 741 },
                    { 1, 742 },
                    { 2, 744 },
                    { 49, 747 },
                    { 10, 748 },
                    { 2, 749 },
                    { 18, 749 },
                    { 14, 750 },
                    { 37, 750 },
                    { 33, 752 },
                    { 10, 755 },
                    { 25, 755 },
                    { 30, 757 },
                    { 41, 758 },
                    { 43, 758 },
                    { 49, 758 },
                    { 8, 759 },
                    { 9, 760 },
                    { 38, 760 },
                    { 14, 763 },
                    { 19, 763 },
                    { 20, 763 },
                    { 47, 763 },
                    { 10, 764 }
                });

            migrationBuilder.InsertData(
                table: "ProductProductCategory",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 20, 765 },
                    { 7, 768 },
                    { 38, 773 },
                    { 21, 774 },
                    { 21, 775 },
                    { 14, 776 },
                    { 27, 776 },
                    { 28, 777 },
                    { 48, 777 },
                    { 50, 778 },
                    { 26, 779 },
                    { 38, 779 },
                    { 1, 781 },
                    { 9, 781 },
                    { 19, 781 },
                    { 35, 781 },
                    { 3, 782 },
                    { 29, 782 },
                    { 33, 782 },
                    { 23, 783 },
                    { 28, 783 },
                    { 40, 787 },
                    { 1, 788 },
                    { 36, 790 },
                    { 46, 790 },
                    { 15, 791 },
                    { 25, 791 },
                    { 28, 794 },
                    { 20, 795 },
                    { 26, 795 },
                    { 27, 795 },
                    { 16, 796 },
                    { 25, 797 },
                    { 21, 798 },
                    { 44, 798 },
                    { 27, 802 },
                    { 6, 804 },
                    { 8, 804 },
                    { 14, 804 },
                    { 48, 804 },
                    { 49, 806 },
                    { 50, 806 }
                });

            migrationBuilder.InsertData(
                table: "ProductProductCategory",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 24, 808 },
                    { 11, 809 },
                    { 26, 809 },
                    { 43, 810 },
                    { 39, 811 },
                    { 5, 815 },
                    { 16, 816 },
                    { 23, 816 },
                    { 37, 816 },
                    { 28, 819 },
                    { 46, 819 },
                    { 2, 821 },
                    { 9, 821 },
                    { 27, 821 },
                    { 19, 822 },
                    { 3, 823 },
                    { 9, 825 },
                    { 18, 827 },
                    { 21, 830 },
                    { 38, 831 },
                    { 6, 832 },
                    { 6, 833 },
                    { 48, 834 },
                    { 38, 835 },
                    { 13, 841 },
                    { 13, 842 },
                    { 25, 842 },
                    { 48, 842 },
                    { 38, 844 },
                    { 49, 846 },
                    { 43, 849 },
                    { 18, 851 },
                    { 34, 853 },
                    { 42, 853 },
                    { 50, 853 },
                    { 39, 854 },
                    { 3, 856 },
                    { 35, 857 },
                    { 4, 858 },
                    { 3, 859 },
                    { 38, 859 },
                    { 19, 860 }
                });

            migrationBuilder.InsertData(
                table: "ProductProductCategory",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 47, 860 },
                    { 3, 861 },
                    { 4, 862 },
                    { 24, 862 },
                    { 3, 863 },
                    { 21, 864 },
                    { 16, 865 },
                    { 34, 865 },
                    { 6, 866 },
                    { 9, 868 },
                    { 22, 868 },
                    { 40, 869 },
                    { 32, 870 },
                    { 14, 871 },
                    { 30, 871 },
                    { 38, 874 },
                    { 7, 875 },
                    { 41, 875 },
                    { 1, 876 },
                    { 3, 876 },
                    { 4, 878 },
                    { 23, 878 },
                    { 13, 879 },
                    { 34, 879 },
                    { 46, 879 },
                    { 9, 880 },
                    { 12, 880 },
                    { 28, 880 },
                    { 19, 884 },
                    { 43, 884 },
                    { 21, 886 },
                    { 16, 887 },
                    { 29, 889 },
                    { 34, 889 },
                    { 42, 889 },
                    { 46, 889 },
                    { 32, 891 },
                    { 19, 893 },
                    { 33, 893 },
                    { 29, 895 },
                    { 16, 896 },
                    { 4, 897 }
                });

            migrationBuilder.InsertData(
                table: "ProductProductCategory",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 33, 897 },
                    { 38, 897 },
                    { 42, 897 },
                    { 43, 897 },
                    { 20, 898 },
                    { 14, 899 },
                    { 27, 902 },
                    { 47, 902 },
                    { 49, 902 },
                    { 25, 903 },
                    { 28, 906 },
                    { 36, 907 },
                    { 6, 908 },
                    { 7, 908 },
                    { 7, 909 },
                    { 23, 912 },
                    { 27, 913 },
                    { 3, 914 },
                    { 15, 914 },
                    { 31, 916 },
                    { 46, 917 },
                    { 10, 919 },
                    { 27, 919 },
                    { 1, 920 },
                    { 39, 920 },
                    { 49, 921 },
                    { 6, 922 },
                    { 32, 922 },
                    { 37, 924 },
                    { 24, 926 },
                    { 29, 926 },
                    { 36, 926 },
                    { 21, 928 },
                    { 46, 928 },
                    { 3, 929 },
                    { 9, 929 },
                    { 13, 930 },
                    { 28, 930 },
                    { 45, 930 },
                    { 46, 930 },
                    { 42, 934 },
                    { 48, 934 }
                });

            migrationBuilder.InsertData(
                table: "ProductProductCategory",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 19, 935 },
                    { 11, 936 },
                    { 29, 936 },
                    { 37, 936 },
                    { 50, 937 },
                    { 48, 939 },
                    { 50, 939 },
                    { 23, 941 },
                    { 49, 941 },
                    { 39, 944 },
                    { 6, 946 },
                    { 41, 947 },
                    { 15, 948 },
                    { 10, 949 },
                    { 10, 951 },
                    { 47, 951 },
                    { 44, 954 },
                    { 37, 955 },
                    { 15, 957 },
                    { 50, 957 },
                    { 11, 959 },
                    { 28, 961 },
                    { 18, 962 },
                    { 49, 962 },
                    { 50, 962 },
                    { 32, 965 },
                    { 39, 965 },
                    { 25, 966 },
                    { 19, 967 },
                    { 43, 967 },
                    { 50, 967 },
                    { 18, 968 },
                    { 26, 970 },
                    { 5, 971 },
                    { 12, 971 },
                    { 17, 974 },
                    { 15, 977 },
                    { 24, 978 },
                    { 35, 978 },
                    { 16, 979 },
                    { 38, 979 },
                    { 10, 983 }
                });

            migrationBuilder.InsertData(
                table: "ProductProductCategory",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 27, 983 },
                    { 38, 984 },
                    { 50, 984 },
                    { 9, 985 },
                    { 42, 985 },
                    { 13, 986 },
                    { 31, 986 },
                    { 23, 988 },
                    { 7, 989 },
                    { 32, 989 },
                    { 42, 991 },
                    { 11, 992 },
                    { 42, 992 },
                    { 41, 993 },
                    { 21, 994 },
                    { 35, 994 },
                    { 45, 994 },
                    { 25, 995 },
                    { 35, 995 },
                    { 48, 998 },
                    { 14, 1000 },
                    { 19, 1000 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 596);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 603);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 604);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 606);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 608);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 610);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 611);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 613);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 614);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 618);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 623);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 625);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 629);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 630);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 631);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 632);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 633);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 635);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 643);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 644);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 645);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 646);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 648);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 656);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 660);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 662);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 671);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 673);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 679);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 684);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 692);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 696);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 697);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 706);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 710);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 714);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 716);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 723);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 724);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 726);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 730);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 733);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 735);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 736);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 743);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 745);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 746);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 751);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 753);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 754);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 756);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 761);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 762);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 766);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 767);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 769);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 770);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 771);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 772);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 780);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 784);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 785);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 786);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 789);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 792);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 793);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 799);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 800);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 801);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 803);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 805);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 807);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 812);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 813);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 814);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 817);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 818);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 820);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 824);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 826);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 828);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 829);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 836);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 837);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 838);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 839);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 840);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 843);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 845);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 847);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 848);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 850);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 852);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 855);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 867);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 872);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 873);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 877);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 881);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 882);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 883);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 885);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 888);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 890);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 892);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 894);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 900);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 901);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 904);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 905);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 910);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 911);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 915);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 918);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 923);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 925);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 927);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 931);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 932);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 933);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 938);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 940);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 942);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 943);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 945);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 950);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 952);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 953);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 956);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 958);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 960);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 963);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 964);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 969);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 972);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 973);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 975);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 976);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 980);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 981);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 982);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 987);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 990);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 996);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 997);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 999);

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 40, 1 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 38, 4 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 17, 5 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 49, 5 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 7 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 24, 7 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 39, 7 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 41, 7 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 16, 8 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 9 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 32, 10 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 49, 10 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 34, 11 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 43, 12 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 8, 14 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 14, 14 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 21, 16 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 20 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 25, 20 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 45, 20 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 50, 20 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 6, 21 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 22 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 20, 22 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 24, 22 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 8, 23 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 13, 23 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 32, 25 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 44, 25 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 6, 26 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 6, 28 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 8, 28 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 36, 28 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 35, 29 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 34, 31 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 32 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 25, 32 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 9, 33 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 24, 33 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 28, 34 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 13, 37 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 38 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 32, 38 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 35, 38 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 30, 39 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 10, 41 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 11, 42 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 39, 43 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 21, 46 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 48, 47 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 20, 48 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 13, 49 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 40, 49 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 42, 49 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 45, 50 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 14, 51 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 25, 51 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 26, 51 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 52 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 54 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 31, 56 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 46, 57 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 59 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 44, 59 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 11, 61 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 35, 61 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 22, 64 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 25, 64 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 36, 64 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 7, 65 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 16, 66 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 36, 66 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 40, 66 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 26, 67 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 36, 68 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 48, 68 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 38, 69 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 70 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 13, 70 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 46, 70 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 49, 70 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 72 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 35, 73 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 40, 73 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 32, 74 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 47, 76 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 11, 77 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 36, 77 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 16, 78 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 20, 79 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 37, 79 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 38, 80 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 46, 81 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 32, 82 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 84 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 85 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 49, 86 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 11, 87 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 43, 89 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 47, 90 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 23, 94 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 31, 95 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 20, 98 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 34, 98 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 48, 100 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 32, 103 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 48, 107 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 21, 108 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 38, 109 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 8, 110 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 24, 112 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 36, 112 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 28, 113 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 33, 114 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 116 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 28, 116 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 34, 116 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 37, 116 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 42, 116 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 22, 117 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 29, 118 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 119 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 16, 119 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 33, 120 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 23, 121 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 48, 122 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 35, 124 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 15, 126 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 38, 127 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 48, 127 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 45, 128 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 49, 134 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 30, 135 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 36, 135 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 29, 136 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 26, 137 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 13, 138 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 139 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 30, 139 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 48, 139 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 10, 142 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 47, 142 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 30, 144 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 50, 144 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 39, 145 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 45, 147 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 32, 148 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 20, 149 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 45, 150 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 6, 151 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 27, 151 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 15, 152 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 23, 152 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 14, 153 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 25, 153 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 28, 158 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 42, 159 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 45, 160 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 44, 161 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 29, 162 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 25, 164 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 40, 164 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 10, 166 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 43, 166 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 167 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 37, 167 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 25, 168 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 11, 170 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 24, 171 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 25, 171 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 11, 172 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 42, 177 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 45, 178 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 18, 179 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 29, 180 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 181 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 50, 181 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 183 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 9, 183 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 30, 183 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 9, 184 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 26, 184 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 45, 184 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 25, 186 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 50, 187 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 31, 188 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 40, 191 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 47, 192 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 6, 193 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 34, 193 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 15, 195 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 50, 197 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 41, 198 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 199 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 37, 199 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 40, 199 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 27, 201 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 7, 202 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 26, 203 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 35, 207 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 208 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 26, 208 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 35, 209 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 11, 210 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 211 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 34, 212 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 49, 213 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 11, 215 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 11, 216 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 16, 217 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 17, 220 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 32, 223 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 21, 224 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 13, 227 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 28, 227 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 17, 228 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 27, 228 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 30, 228 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 42, 229 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 32, 230 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 13, 231 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 42, 231 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 9, 234 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 17, 234 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 22, 235 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 40, 235 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 49, 235 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 26, 238 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 239 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 28, 239 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 22, 241 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 242 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 30, 242 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 50, 245 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 35, 248 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 18, 249 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 31, 249 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 39, 249 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 21, 250 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 41, 250 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 251 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 35, 253 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 16, 255 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 13, 256 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 20, 256 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 36, 258 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 19, 259 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 16, 262 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 18, 263 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 46, 263 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 49, 264 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 45, 265 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 266 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 6, 268 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 24, 268 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 8, 269 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 270 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 271 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 17, 271 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 15, 272 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 30, 272 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 37, 272 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 273 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 23, 276 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 50, 276 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 278 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 278 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 50, 280 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 18, 281 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 33, 281 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 23, 282 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 31, 282 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 285 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 23, 285 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 23, 286 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 34, 286 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 42, 286 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 26, 287 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 32, 287 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 36, 288 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 10, 289 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 18, 289 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 50, 289 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 28, 291 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 9, 293 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 42, 294 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 37, 300 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 29, 302 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 34, 302 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 28, 303 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 25, 306 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 21, 307 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 21, 308 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 37, 311 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 19, 312 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 48, 313 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 10, 314 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 43, 314 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 45, 314 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 6, 315 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 41, 315 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 20, 316 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 44, 323 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 45, 323 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 8, 324 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 20, 324 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 28, 324 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 14, 326 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 38, 326 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 14, 327 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 50, 327 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 37, 330 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 20, 332 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 35, 333 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 336 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 336 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 6, 337 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 8, 337 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 24, 337 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 45, 337 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 50, 337 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 25, 338 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 27, 340 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 21, 341 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 37, 341 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 14, 342 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 26, 342 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 13, 343 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 48, 343 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 8, 344 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 20, 345 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 31, 348 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 349 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 31, 349 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 9, 350 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 16, 350 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 9, 351 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 6, 353 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 34, 357 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 6, 358 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 18, 358 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 25, 358 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 31, 358 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 33, 358 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 8, 359 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 48, 361 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 362 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 48, 363 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 44, 366 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 33, 367 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 26, 368 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 10, 369 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 42, 369 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 10, 370 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 40, 370 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 40, 371 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 30, 373 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 39, 373 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 36, 374 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 46, 374 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 18, 375 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 376 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 44, 378 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 383 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 45, 383 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 384 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 20, 384 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 25, 384 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 385 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 37, 387 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 16, 388 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 48, 388 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 389 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 40, 391 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 16, 394 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 41, 394 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 50, 395 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 17, 397 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 32, 398 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 48, 398 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 19, 399 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 35, 399 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 41, 399 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 20, 400 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 27, 400 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 45, 400 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 402 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 7, 405 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 35, 406 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 9, 409 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 44, 410 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 14, 413 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 49, 413 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 11, 414 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 15, 414 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 415 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 6, 415 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 42, 416 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 7, 417 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 18, 418 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 30, 420 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 421 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 23, 421 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 16, 422 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 26, 422 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 43, 422 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 15, 425 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 26, 428 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 430 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 431 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 41, 431 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 24, 434 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 30, 436 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 39, 437 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 39, 440 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 443 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 23, 443 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 29, 443 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 38, 444 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 13, 445 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 42, 445 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 446 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 447 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 8, 447 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 29, 448 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 41, 448 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 37, 451 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 38, 452 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 39, 453 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 45, 454 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 23, 457 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 50, 457 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 22, 458 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 28, 458 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 41, 459 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 8, 460 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 9, 460 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 463 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 465 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 13, 465 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 466 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 46, 467 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 8, 468 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 10, 469 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 13, 470 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 7, 471 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 47, 471 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 20, 472 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 7, 473 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 35, 473 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 42, 476 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 10, 477 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 38, 477 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 26, 479 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 34, 479 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 36, 479 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 16, 480 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 484 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 26, 484 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 42, 485 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 7, 486 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 487 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 49, 487 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 489 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 21, 490 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 6, 491 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 492 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 492 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 25, 492 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 29, 494 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 495 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 8, 496 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 13, 496 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 29, 498 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 31, 500 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 19, 502 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 36, 502 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 43, 502 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 7, 504 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 10, 504 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 13, 505 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 28, 505 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 507 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 33, 507 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 15, 508 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 49, 510 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 34, 511 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 45, 513 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 514 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 9, 514 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 27, 514 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 22, 515 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 8, 516 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 27, 518 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 35, 518 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 31, 520 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 35, 520 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 33, 523 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 24, 528 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 16, 529 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 25, 530 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 35, 530 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 44, 531 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 43, 533 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 28, 534 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 33, 534 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 15, 535 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 31, 535 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 34, 535 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 35, 535 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 36, 535 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 47, 535 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 31, 536 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 40, 536 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 19, 537 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 30, 537 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 539 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 19, 539 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 40, 540 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 18, 541 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 25, 541 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 48, 542 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 49, 543 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 49, 544 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 20, 545 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 32, 545 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 28, 550 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 13, 552 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 45, 552 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 43, 553 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 21, 554 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 10, 557 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 26, 557 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 50, 558 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 19, 559 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 560 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 48, 560 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 41, 561 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 43, 561 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 8, 563 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 21, 563 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 41, 563 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 40, 564 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 37, 565 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 44, 565 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 19, 566 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 49, 566 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 16, 567 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 35, 567 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 8, 568 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 570 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 30, 571 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 15, 572 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 42, 572 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 577 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 14, 577 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 31, 577 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 43, 577 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 25, 578 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 32, 578 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 41, 578 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 22, 581 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 14, 582 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 24, 582 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 37, 582 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 13, 584 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 28, 586 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 42, 586 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 13, 587 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 30, 587 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 23, 588 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 39, 589 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 24, 590 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 44, 591 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 28, 595 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 22, 597 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 24, 597 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 40, 597 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 6, 598 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 9, 598 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 23, 599 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 600 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 7, 601 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 22, 601 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 44, 601 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 8, 602 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 22, 605 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 23, 605 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 34, 607 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 609 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 30, 612 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 615 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 21, 615 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 32, 616 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 35, 616 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 16, 617 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 45, 619 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 620 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 21, 621 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 622 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 15, 624 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 34, 626 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 49, 626 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 7, 627 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 10, 627 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 29, 628 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 37, 634 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 30, 636 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 49, 636 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 637 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 33, 637 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 34, 637 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 36, 637 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 14, 638 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 49, 639 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 41, 640 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 42, 641 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 642 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 8, 642 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 19, 642 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 45, 642 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 41, 647 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 46, 647 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 649 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 9, 649 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 37, 650 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 42, 651 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 35, 652 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 25, 653 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 45, 654 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 46, 654 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 14, 655 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 40, 655 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 657 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 13, 657 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 24, 657 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 30, 658 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 32, 659 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 8, 661 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 21, 661 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 50, 661 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 44, 663 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 16, 664 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 26, 664 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 38, 664 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 665 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 9, 665 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 666 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 41, 666 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 46, 666 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 667 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 11, 667 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 44, 668 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 8, 669 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 15, 670 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 20, 672 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 43, 672 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 47, 672 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 27, 674 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 39, 675 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 6, 676 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 677 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 29, 677 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 21, 678 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 32, 678 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 36, 678 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 16, 680 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 41, 680 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 11, 681 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 49, 681 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 48, 682 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 23, 683 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 21, 685 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 37, 685 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 686 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 686 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 32, 686 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 48, 687 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 20, 688 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 21, 688 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 689 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 6, 689 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 29, 690 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 691 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 7, 693 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 48, 693 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 19, 694 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 18, 695 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 36, 695 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 27, 698 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 40, 699 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 6, 700 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 7, 701 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 29, 702 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 15, 703 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 32, 703 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 35, 704 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 47, 705 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 49, 707 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 45, 708 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 13, 709 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 14, 709 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 32, 709 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 34, 711 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 43, 711 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 712 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 713 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 8, 713 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 48, 715 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 717 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 8, 718 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 27, 719 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 20, 720 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 18, 721 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 50, 722 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 46, 725 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 33, 727 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 40, 728 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 729 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 16, 729 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 40, 729 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 38, 731 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 21, 732 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 38, 734 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 39, 734 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 50, 734 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 21, 737 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 13, 738 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 11, 739 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 14, 740 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 18, 740 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 22, 741 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 44, 741 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 742 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 744 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 49, 747 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 10, 748 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 749 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 18, 749 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 14, 750 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 37, 750 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 33, 752 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 10, 755 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 25, 755 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 30, 757 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 41, 758 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 43, 758 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 49, 758 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 8, 759 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 9, 760 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 38, 760 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 14, 763 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 19, 763 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 20, 763 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 47, 763 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 10, 764 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 20, 765 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 7, 768 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 38, 773 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 21, 774 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 21, 775 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 14, 776 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 27, 776 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 28, 777 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 48, 777 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 50, 778 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 26, 779 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 38, 779 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 781 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 9, 781 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 19, 781 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 35, 781 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 782 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 29, 782 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 33, 782 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 23, 783 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 28, 783 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 40, 787 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 788 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 36, 790 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 46, 790 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 15, 791 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 25, 791 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 28, 794 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 20, 795 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 26, 795 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 27, 795 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 16, 796 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 25, 797 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 21, 798 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 44, 798 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 27, 802 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 6, 804 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 8, 804 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 14, 804 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 48, 804 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 49, 806 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 50, 806 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 24, 808 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 11, 809 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 26, 809 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 43, 810 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 39, 811 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 815 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 16, 816 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 23, 816 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 37, 816 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 28, 819 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 46, 819 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 821 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 9, 821 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 27, 821 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 19, 822 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 823 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 9, 825 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 18, 827 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 21, 830 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 38, 831 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 6, 832 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 6, 833 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 48, 834 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 38, 835 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 13, 841 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 13, 842 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 25, 842 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 48, 842 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 38, 844 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 49, 846 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 43, 849 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 18, 851 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 34, 853 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 42, 853 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 50, 853 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 39, 854 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 856 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 35, 857 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 858 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 859 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 38, 859 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 19, 860 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 47, 860 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 861 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 862 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 24, 862 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 863 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 21, 864 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 16, 865 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 34, 865 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 6, 866 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 9, 868 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 22, 868 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 40, 869 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 32, 870 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 14, 871 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 30, 871 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 38, 874 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 7, 875 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 41, 875 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 876 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 876 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 878 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 23, 878 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 13, 879 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 34, 879 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 46, 879 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 9, 880 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 880 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 28, 880 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 19, 884 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 43, 884 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 21, 886 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 16, 887 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 29, 889 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 34, 889 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 42, 889 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 46, 889 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 32, 891 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 19, 893 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 33, 893 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 29, 895 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 16, 896 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 897 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 33, 897 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 38, 897 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 42, 897 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 43, 897 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 20, 898 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 14, 899 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 27, 902 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 47, 902 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 49, 902 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 25, 903 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 28, 906 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 36, 907 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 6, 908 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 7, 908 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 7, 909 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 23, 912 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 27, 913 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 914 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 15, 914 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 31, 916 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 46, 917 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 10, 919 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 27, 919 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 920 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 39, 920 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 49, 921 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 6, 922 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 32, 922 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 37, 924 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 24, 926 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 29, 926 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 36, 926 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 21, 928 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 46, 928 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 929 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 9, 929 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 13, 930 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 28, 930 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 45, 930 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 46, 930 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 42, 934 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 48, 934 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 19, 935 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 11, 936 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 29, 936 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 37, 936 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 50, 937 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 48, 939 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 50, 939 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 23, 941 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 49, 941 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 39, 944 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 6, 946 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 41, 947 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 15, 948 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 10, 949 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 10, 951 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 47, 951 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 44, 954 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 37, 955 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 15, 957 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 50, 957 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 11, 959 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 28, 961 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 18, 962 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 49, 962 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 50, 962 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 32, 965 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 39, 965 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 25, 966 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 19, 967 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 43, 967 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 50, 967 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 18, 968 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 26, 970 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 971 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 971 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 17, 974 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 15, 977 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 24, 978 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 35, 978 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 16, 979 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 38, 979 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 10, 983 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 27, 983 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 38, 984 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 50, 984 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 9, 985 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 42, 985 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 13, 986 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 31, 986 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 23, 988 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 7, 989 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 32, 989 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 42, 991 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 11, 992 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 42, 992 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 41, 993 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 21, 994 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 35, 994 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 45, 994 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 25, 995 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 35, 995 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 48, 998 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 14, 1000 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 19, 1000 });

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 588);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 597);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 599);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 601);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 602);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 605);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 607);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 609);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 612);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 615);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 616);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 617);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 619);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 620);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 621);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 622);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 624);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 626);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 627);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 628);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 634);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 636);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 637);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 638);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 639);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 640);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 641);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 642);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 647);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 649);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 650);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 651);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 652);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 653);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 654);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 655);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 657);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 658);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 659);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 661);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 663);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 664);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 665);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 666);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 667);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 668);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 669);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 670);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 672);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 674);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 675);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 676);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 677);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 678);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 680);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 681);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 682);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 683);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 685);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 686);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 687);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 688);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 689);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 690);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 691);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 693);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 694);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 695);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 698);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 699);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 700);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 701);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 702);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 703);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 704);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 705);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 707);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 708);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 709);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 711);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 712);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 713);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 715);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 717);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 718);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 719);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 720);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 721);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 722);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 725);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 727);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 728);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 729);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 731);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 732);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 734);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 737);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 738);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 739);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 740);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 741);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 742);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 744);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 747);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 748);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 749);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 750);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 752);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 755);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 757);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 758);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 759);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 760);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 763);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 764);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 765);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 768);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 773);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 774);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 775);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 776);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 777);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 778);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 779);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 781);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 782);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 783);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 787);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 788);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 790);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 791);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 794);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 795);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 796);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 797);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 798);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 802);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 804);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 806);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 808);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 809);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 810);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 811);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 815);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 816);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 819);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 821);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 822);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 823);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 825);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 827);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 830);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 831);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 832);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 833);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 834);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 835);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 841);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 842);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 844);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 846);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 849);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 851);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 853);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 854);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 856);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 857);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 858);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 859);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 860);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 861);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 862);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 863);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 864);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 865);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 866);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 868);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 869);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 870);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 871);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 874);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 875);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 876);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 878);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 879);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 880);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 884);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 886);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 887);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 889);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 891);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 893);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 895);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 896);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 897);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 898);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 899);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 902);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 903);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 906);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 907);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 908);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 909);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 912);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 913);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 914);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 916);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 917);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 919);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 920);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 921);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 922);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 924);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 926);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 928);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 929);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 930);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 934);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 935);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 936);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 937);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 939);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 941);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 944);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 946);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 947);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 948);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 949);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 951);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 954);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 955);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 957);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 959);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 961);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 962);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 965);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 966);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 967);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 968);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 970);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 971);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 974);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 977);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 978);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 979);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 983);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 984);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 985);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 986);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 988);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 989);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 991);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 992);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 993);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 994);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 995);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 998);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1000);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 50);
        }
    }
}
