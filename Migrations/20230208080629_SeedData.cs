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
                    { 1, new DateTimeOffset(new DateTime(2023, 10, 25, 6, 30, 7, 592, DateTimeKind.Unspecified).AddTicks(852), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Wooden Shoes" },
                    { 2, new DateTimeOffset(new DateTime(2024, 1, 11, 4, 15, 43, 851, DateTimeKind.Unspecified).AddTicks(278), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Cotton Keyboard" },
                    { 3, new DateTimeOffset(new DateTime(2023, 3, 30, 2, 1, 20, 109, DateTimeKind.Unspecified).AddTicks(9704), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Metal Pizza" },
                    { 4, new DateTimeOffset(new DateTime(2023, 6, 15, 23, 46, 56, 368, DateTimeKind.Unspecified).AddTicks(9131), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Frozen Towels" },
                    { 5, new DateTimeOffset(new DateTime(2023, 9, 1, 21, 32, 32, 627, DateTimeKind.Unspecified).AddTicks(8557), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Plastic Ball" },
                    { 6, new DateTimeOffset(new DateTime(2023, 11, 18, 19, 18, 8, 886, DateTimeKind.Unspecified).AddTicks(7983), new TimeSpan(0, 1, 0, 0, 0)), "Refined Rubber Chips" },
                    { 7, new DateTimeOffset(new DateTime(2023, 2, 4, 17, 3, 45, 145, DateTimeKind.Unspecified).AddTicks(7409), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Fresh Tuna" },
                    { 8, new DateTimeOffset(new DateTime(2023, 4, 23, 14, 49, 21, 404, DateTimeKind.Unspecified).AddTicks(6835), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Wooden Pants" },
                    { 9, new DateTimeOffset(new DateTime(2023, 7, 10, 12, 34, 57, 663, DateTimeKind.Unspecified).AddTicks(6261), new TimeSpan(0, 1, 0, 0, 0)), "Practical Granite Car" },
                    { 10, new DateTimeOffset(new DateTime(2023, 9, 26, 10, 20, 33, 922, DateTimeKind.Unspecified).AddTicks(5687), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Soft Cheese" },
                    { 11, new DateTimeOffset(new DateTime(2023, 12, 13, 8, 6, 10, 181, DateTimeKind.Unspecified).AddTicks(5113), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Steel Table" },
                    { 12, new DateTimeOffset(new DateTime(2023, 3, 1, 5, 51, 46, 440, DateTimeKind.Unspecified).AddTicks(4539), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Plastic Keyboard" },
                    { 13, new DateTimeOffset(new DateTime(2023, 5, 18, 3, 37, 22, 699, DateTimeKind.Unspecified).AddTicks(3965), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Rubber Pizza" },
                    { 14, new DateTimeOffset(new DateTime(2023, 8, 4, 1, 22, 58, 958, DateTimeKind.Unspecified).AddTicks(3391), new TimeSpan(0, 1, 0, 0, 0)), "Small Frozen Towels" },
                    { 15, new DateTimeOffset(new DateTime(2023, 10, 20, 23, 8, 35, 217, DateTimeKind.Unspecified).AddTicks(2817), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Concrete Ball" },
                    { 16, new DateTimeOffset(new DateTime(2024, 1, 6, 20, 54, 11, 476, DateTimeKind.Unspecified).AddTicks(2243), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Granite Sausages" },
                    { 17, new DateTimeOffset(new DateTime(2023, 3, 25, 18, 39, 47, 735, DateTimeKind.Unspecified).AddTicks(1669), new TimeSpan(0, 1, 0, 0, 0)), "Generic Soft Tuna" },
                    { 18, new DateTimeOffset(new DateTime(2023, 6, 11, 16, 25, 23, 994, DateTimeKind.Unspecified).AddTicks(1095), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Wooden Pants" },
                    { 19, new DateTimeOffset(new DateTime(2023, 8, 28, 14, 11, 0, 253, DateTimeKind.Unspecified).AddTicks(521), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Cotton Car" },
                    { 20, new DateTimeOffset(new DateTime(2023, 11, 14, 11, 56, 36, 511, DateTimeKind.Unspecified).AddTicks(9947), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Metal Fish" },
                    { 21, new DateTimeOffset(new DateTime(2023, 1, 31, 9, 42, 12, 770, DateTimeKind.Unspecified).AddTicks(9373), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Frozen Table" },
                    { 22, new DateTimeOffset(new DateTime(2023, 4, 19, 7, 27, 49, 29, DateTimeKind.Unspecified).AddTicks(8799), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Concrete Keyboard" },
                    { 23, new DateTimeOffset(new DateTime(2023, 7, 6, 5, 13, 25, 288, DateTimeKind.Unspecified).AddTicks(8225), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Rubber Pizza" },
                    { 24, new DateTimeOffset(new DateTime(2023, 9, 22, 2, 59, 1, 547, DateTimeKind.Unspecified).AddTicks(7651), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Fresh Towels" },
                    { 25, new DateTimeOffset(new DateTime(2023, 12, 9, 0, 44, 37, 806, DateTimeKind.Unspecified).AddTicks(7077), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Wooden Bike" },
                    { 26, new DateTimeOffset(new DateTime(2023, 2, 24, 22, 30, 14, 65, DateTimeKind.Unspecified).AddTicks(6503), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Cotton Sausages" },
                    { 27, new DateTimeOffset(new DateTime(2023, 5, 13, 20, 15, 50, 324, DateTimeKind.Unspecified).AddTicks(5929), new TimeSpan(0, 1, 0, 0, 0)), "Refined Soft Tuna" },
                    { 28, new DateTimeOffset(new DateTime(2023, 7, 30, 18, 1, 26, 583, DateTimeKind.Unspecified).AddTicks(5356), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Steel Pants" },
                    { 29, new DateTimeOffset(new DateTime(2023, 10, 16, 15, 47, 2, 842, DateTimeKind.Unspecified).AddTicks(4782), new TimeSpan(0, 1, 0, 0, 0)), "Refined Plastic Chair" },
                    { 30, new DateTimeOffset(new DateTime(2024, 1, 2, 13, 32, 39, 101, DateTimeKind.Unspecified).AddTicks(4208), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Rubber Fish" },
                    { 31, new DateTimeOffset(new DateTime(2023, 3, 21, 11, 18, 15, 360, DateTimeKind.Unspecified).AddTicks(3634), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Frozen Table" },
                    { 32, new DateTimeOffset(new DateTime(2023, 6, 7, 9, 3, 51, 619, DateTimeKind.Unspecified).AddTicks(3060), new TimeSpan(0, 1, 0, 0, 0)), "Practical Concrete Keyboard" },
                    { 33, new DateTimeOffset(new DateTime(2023, 8, 24, 6, 49, 27, 878, DateTimeKind.Unspecified).AddTicks(2486), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Granite Pizza" },
                    { 34, new DateTimeOffset(new DateTime(2023, 11, 10, 4, 35, 4, 137, DateTimeKind.Unspecified).AddTicks(1912), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Soft Hat" },
                    { 35, new DateTimeOffset(new DateTime(2023, 1, 27, 2, 20, 40, 396, DateTimeKind.Unspecified).AddTicks(1338), new TimeSpan(0, 1, 0, 0, 0)), "Small Steel Bike" },
                    { 36, new DateTimeOffset(new DateTime(2023, 4, 15, 0, 6, 16, 655, DateTimeKind.Unspecified).AddTicks(764), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Cotton Sausages" },
                    { 37, new DateTimeOffset(new DateTime(2023, 7, 1, 21, 51, 52, 914, DateTimeKind.Unspecified).AddTicks(190), new TimeSpan(0, 1, 0, 0, 0)), "Small Metal Tuna" },
                    { 38, new DateTimeOffset(new DateTime(2023, 9, 17, 19, 37, 29, 172, DateTimeKind.Unspecified).AddTicks(9616), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Frozen Gloves" },
                    { 39, new DateTimeOffset(new DateTime(2023, 12, 4, 17, 23, 5, 431, DateTimeKind.Unspecified).AddTicks(9042), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Concrete Chair" },
                    { 40, new DateTimeOffset(new DateTime(2023, 2, 20, 15, 8, 41, 690, DateTimeKind.Unspecified).AddTicks(8468), new TimeSpan(0, 1, 0, 0, 0)), "Generic Rubber Fish" },
                    { 41, new DateTimeOffset(new DateTime(2023, 5, 9, 12, 54, 17, 949, DateTimeKind.Unspecified).AddTicks(7894), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Fresh Table" },
                    { 42, new DateTimeOffset(new DateTime(2023, 7, 26, 10, 39, 54, 208, DateTimeKind.Unspecified).AddTicks(7320), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Wooden Keyboard" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreationDate", "Name" },
                values: new object[,]
                {
                    { 43, new DateTimeOffset(new DateTime(2023, 10, 12, 8, 25, 30, 467, DateTimeKind.Unspecified).AddTicks(6746), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Cotton Bacon" },
                    { 44, new DateTimeOffset(new DateTime(2023, 12, 29, 6, 11, 6, 726, DateTimeKind.Unspecified).AddTicks(6172), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Soft Hat" },
                    { 45, new DateTimeOffset(new DateTime(2023, 3, 17, 3, 56, 42, 985, DateTimeKind.Unspecified).AddTicks(5598), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Steel Bike" },
                    { 46, new DateTimeOffset(new DateTime(2023, 6, 3, 1, 42, 19, 244, DateTimeKind.Unspecified).AddTicks(5024), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Plastic Sausages" },
                    { 47, new DateTimeOffset(new DateTime(2023, 8, 19, 23, 27, 55, 503, DateTimeKind.Unspecified).AddTicks(4450), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Rubber Soap" },
                    { 48, new DateTimeOffset(new DateTime(2023, 11, 5, 21, 13, 31, 762, DateTimeKind.Unspecified).AddTicks(3876), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Fresh Gloves" },
                    { 49, new DateTimeOffset(new DateTime(2023, 1, 22, 18, 59, 8, 21, DateTimeKind.Unspecified).AddTicks(3302), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Concrete Chair" },
                    { 50, new DateTimeOffset(new DateTime(2023, 4, 10, 16, 44, 44, 280, DateTimeKind.Unspecified).AddTicks(2728), new TimeSpan(0, 1, 0, 0, 0)), "Refined Granite Fish" },
                    { 51, new DateTimeOffset(new DateTime(2023, 6, 27, 14, 30, 20, 539, DateTimeKind.Unspecified).AddTicks(2154), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Soft Shirt" },
                    { 52, new DateTimeOffset(new DateTime(2023, 9, 13, 12, 15, 56, 798, DateTimeKind.Unspecified).AddTicks(1581), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Steel Computer" },
                    { 53, new DateTimeOffset(new DateTime(2023, 11, 30, 10, 1, 33, 57, DateTimeKind.Unspecified).AddTicks(1007), new TimeSpan(0, 1, 0, 0, 0)), "Practical Cotton Bacon" },
                    { 54, new DateTimeOffset(new DateTime(2023, 2, 16, 7, 47, 9, 316, DateTimeKind.Unspecified).AddTicks(433), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Metal Hat" },
                    { 55, new DateTimeOffset(new DateTime(2023, 5, 5, 5, 32, 45, 574, DateTimeKind.Unspecified).AddTicks(9859), new TimeSpan(0, 1, 0, 0, 0)), "Practical Frozen Bike" },
                    { 56, new DateTimeOffset(new DateTime(2023, 7, 22, 3, 18, 21, 833, DateTimeKind.Unspecified).AddTicks(9285), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Concrete Salad" },
                    { 57, new DateTimeOffset(new DateTime(2023, 10, 8, 1, 3, 58, 92, DateTimeKind.Unspecified).AddTicks(8711), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Granite Soap" },
                    { 58, new DateTimeOffset(new DateTime(2023, 12, 24, 22, 49, 34, 351, DateTimeKind.Unspecified).AddTicks(8137), new TimeSpan(0, 1, 0, 0, 0)), "Small Fresh Gloves" },
                    { 59, new DateTimeOffset(new DateTime(2023, 3, 12, 20, 35, 10, 610, DateTimeKind.Unspecified).AddTicks(7563), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Wooden Chair" },
                    { 60, new DateTimeOffset(new DateTime(2023, 5, 29, 18, 20, 46, 869, DateTimeKind.Unspecified).AddTicks(6989), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Cotton Chicken" },
                    { 61, new DateTimeOffset(new DateTime(2023, 8, 15, 16, 6, 23, 128, DateTimeKind.Unspecified).AddTicks(6415), new TimeSpan(0, 1, 0, 0, 0)), "Generic Metal Shirt" },
                    { 62, new DateTimeOffset(new DateTime(2023, 11, 1, 13, 51, 59, 387, DateTimeKind.Unspecified).AddTicks(5841), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Steel Computer" },
                    { 63, new DateTimeOffset(new DateTime(2023, 1, 18, 11, 37, 35, 646, DateTimeKind.Unspecified).AddTicks(5267), new TimeSpan(0, 1, 0, 0, 0)), "Generic Plastic Bacon" },
                    { 64, new DateTimeOffset(new DateTime(2023, 4, 6, 9, 23, 11, 905, DateTimeKind.Unspecified).AddTicks(4693), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Rubber Hat" },
                    { 65, new DateTimeOffset(new DateTime(2023, 6, 23, 7, 8, 48, 164, DateTimeKind.Unspecified).AddTicks(4119), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Fresh Mouse" },
                    { 66, new DateTimeOffset(new DateTime(2023, 9, 9, 4, 54, 24, 423, DateTimeKind.Unspecified).AddTicks(3545), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Concrete Salad" },
                    { 67, new DateTimeOffset(new DateTime(2023, 11, 26, 2, 40, 0, 682, DateTimeKind.Unspecified).AddTicks(2971), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Granite Soap" },
                    { 68, new DateTimeOffset(new DateTime(2023, 2, 12, 0, 25, 36, 941, DateTimeKind.Unspecified).AddTicks(2397), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Soft Gloves" },
                    { 69, new DateTimeOffset(new DateTime(2023, 4, 30, 22, 11, 13, 200, DateTimeKind.Unspecified).AddTicks(1823), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Steel Chips" },
                    { 70, new DateTimeOffset(new DateTime(2023, 7, 17, 19, 56, 49, 459, DateTimeKind.Unspecified).AddTicks(1249), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Plastic Chicken" },
                    { 71, new DateTimeOffset(new DateTime(2023, 10, 3, 17, 42, 25, 718, DateTimeKind.Unspecified).AddTicks(675), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Metal Shirt" },
                    { 72, new DateTimeOffset(new DateTime(2023, 12, 20, 15, 28, 1, 977, DateTimeKind.Unspecified).AddTicks(101), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Frozen Computer" },
                    { 73, new DateTimeOffset(new DateTime(2023, 3, 8, 13, 13, 38, 235, DateTimeKind.Unspecified).AddTicks(9527), new TimeSpan(0, 1, 0, 0, 0)), "Refined Concrete Bacon" },
                    { 74, new DateTimeOffset(new DateTime(2023, 5, 25, 10, 59, 14, 494, DateTimeKind.Unspecified).AddTicks(8953), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Granite Shoes" },
                    { 75, new DateTimeOffset(new DateTime(2023, 8, 11, 8, 44, 50, 753, DateTimeKind.Unspecified).AddTicks(8380), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Fresh Mouse" },
                    { 76, new DateTimeOffset(new DateTime(2023, 10, 28, 6, 30, 27, 12, DateTimeKind.Unspecified).AddTicks(7806), new TimeSpan(0, 1, 0, 0, 0)), "Practical Wooden Salad" },
                    { 77, new DateTimeOffset(new DateTime(2024, 1, 14, 4, 16, 3, 271, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Cotton Soap" },
                    { 78, new DateTimeOffset(new DateTime(2023, 4, 2, 2, 1, 39, 530, DateTimeKind.Unspecified).AddTicks(6658), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Metal Ball" },
                    { 79, new DateTimeOffset(new DateTime(2023, 6, 18, 23, 47, 15, 789, DateTimeKind.Unspecified).AddTicks(6084), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Frozen Chips" },
                    { 80, new DateTimeOffset(new DateTime(2023, 9, 4, 21, 32, 52, 48, DateTimeKind.Unspecified).AddTicks(5510), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Plastic Chicken" },
                    { 81, new DateTimeOffset(new DateTime(2023, 11, 21, 19, 18, 28, 307, DateTimeKind.Unspecified).AddTicks(4936), new TimeSpan(0, 1, 0, 0, 0)), "Small Rubber Shirt" },
                    { 82, new DateTimeOffset(new DateTime(2023, 2, 7, 17, 4, 4, 566, DateTimeKind.Unspecified).AddTicks(4362), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Fresh Computer" },
                    { 83, new DateTimeOffset(new DateTime(2023, 4, 26, 14, 49, 40, 825, DateTimeKind.Unspecified).AddTicks(3788), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Wooden Cheese" },
                    { 84, new DateTimeOffset(new DateTime(2023, 7, 13, 12, 35, 17, 84, DateTimeKind.Unspecified).AddTicks(3214), new TimeSpan(0, 1, 0, 0, 0)), "Generic Granite Shoes" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreationDate", "Name" },
                values: new object[,]
                {
                    { 85, new DateTimeOffset(new DateTime(2023, 9, 29, 10, 20, 53, 343, DateTimeKind.Unspecified).AddTicks(2640), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Soft Mouse" },
                    { 86, new DateTimeOffset(new DateTime(2023, 12, 16, 8, 6, 29, 602, DateTimeKind.Unspecified).AddTicks(2066), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Steel Salad" },
                    { 87, new DateTimeOffset(new DateTime(2023, 3, 4, 5, 52, 5, 861, DateTimeKind.Unspecified).AddTicks(1492), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Plastic Towels" },
                    { 88, new DateTimeOffset(new DateTime(2023, 5, 21, 3, 37, 42, 120, DateTimeKind.Unspecified).AddTicks(918), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Metal Ball" },
                    { 89, new DateTimeOffset(new DateTime(2023, 8, 7, 1, 23, 18, 379, DateTimeKind.Unspecified).AddTicks(344), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Frozen Chips" },
                    { 90, new DateTimeOffset(new DateTime(2023, 10, 23, 23, 8, 54, 637, DateTimeKind.Unspecified).AddTicks(9770), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Concrete Chicken" },
                    { 91, new DateTimeOffset(new DateTime(2024, 1, 9, 20, 54, 30, 896, DateTimeKind.Unspecified).AddTicks(9196), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Granite Shirt" },
                    { 92, new DateTimeOffset(new DateTime(2023, 3, 28, 18, 40, 7, 155, DateTimeKind.Unspecified).AddTicks(8622), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Soft Car" },
                    { 93, new DateTimeOffset(new DateTime(2023, 6, 14, 16, 25, 43, 414, DateTimeKind.Unspecified).AddTicks(8048), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Wooden Cheese" },
                    { 94, new DateTimeOffset(new DateTime(2023, 8, 31, 14, 11, 19, 673, DateTimeKind.Unspecified).AddTicks(7474), new TimeSpan(0, 1, 0, 0, 0)), "Refined Cotton Shoes" },
                    { 95, new DateTimeOffset(new DateTime(2023, 11, 17, 11, 56, 55, 932, DateTimeKind.Unspecified).AddTicks(6900), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Metal Mouse" },
                    { 96, new DateTimeOffset(new DateTime(2023, 2, 3, 9, 42, 32, 191, DateTimeKind.Unspecified).AddTicks(6326), new TimeSpan(0, 1, 0, 0, 0)), "Refined Frozen Pizza" },
                    { 97, new DateTimeOffset(new DateTime(2023, 4, 22, 7, 28, 8, 450, DateTimeKind.Unspecified).AddTicks(5752), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Plastic Towels" },
                    { 98, new DateTimeOffset(new DateTime(2023, 7, 9, 5, 13, 44, 709, DateTimeKind.Unspecified).AddTicks(5178), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Rubber Ball" },
                    { 99, new DateTimeOffset(new DateTime(2023, 9, 25, 2, 59, 20, 968, DateTimeKind.Unspecified).AddTicks(4604), new TimeSpan(0, 1, 0, 0, 0)), "Practical Fresh Chips" },
                    { 100, new DateTimeOffset(new DateTime(2023, 12, 12, 0, 44, 57, 227, DateTimeKind.Unspecified).AddTicks(4030), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Wooden Chicken" },
                    { 101, new DateTimeOffset(new DateTime(2023, 2, 27, 22, 30, 33, 486, DateTimeKind.Unspecified).AddTicks(3457), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Cotton Pants" },
                    { 102, new DateTimeOffset(new DateTime(2023, 5, 16, 20, 16, 9, 745, DateTimeKind.Unspecified).AddTicks(2883), new TimeSpan(0, 1, 0, 0, 0)), "Small Soft Car" },
                    { 103, new DateTimeOffset(new DateTime(2023, 8, 2, 18, 1, 46, 4, DateTimeKind.Unspecified).AddTicks(2309), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Steel Cheese" },
                    { 104, new DateTimeOffset(new DateTime(2023, 10, 19, 15, 47, 22, 263, DateTimeKind.Unspecified).AddTicks(1735), new TimeSpan(0, 1, 0, 0, 0)), "Small Plastic Shoes" },
                    { 105, new DateTimeOffset(new DateTime(2024, 1, 5, 13, 32, 58, 522, DateTimeKind.Unspecified).AddTicks(1161), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Rubber Keyboard" },
                    { 106, new DateTimeOffset(new DateTime(2023, 3, 24, 11, 18, 34, 781, DateTimeKind.Unspecified).AddTicks(587), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Frozen Pizza" },
                    { 107, new DateTimeOffset(new DateTime(2023, 6, 10, 9, 4, 11, 40, DateTimeKind.Unspecified).AddTicks(13), new TimeSpan(0, 1, 0, 0, 0)), "Generic Concrete Towels" },
                    { 108, new DateTimeOffset(new DateTime(2023, 8, 27, 6, 49, 47, 298, DateTimeKind.Unspecified).AddTicks(9439), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Granite Ball" },
                    { 109, new DateTimeOffset(new DateTime(2023, 11, 13, 4, 35, 23, 557, DateTimeKind.Unspecified).AddTicks(8865), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Soft Sausages" },
                    { 110, new DateTimeOffset(new DateTime(2023, 1, 30, 2, 20, 59, 816, DateTimeKind.Unspecified).AddTicks(8291), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Wooden Tuna" },
                    { 111, new DateTimeOffset(new DateTime(2023, 4, 18, 0, 6, 36, 75, DateTimeKind.Unspecified).AddTicks(7717), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Cotton Pants" },
                    { 112, new DateTimeOffset(new DateTime(2023, 7, 4, 21, 52, 12, 334, DateTimeKind.Unspecified).AddTicks(7143), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Metal Car" },
                    { 113, new DateTimeOffset(new DateTime(2023, 9, 20, 19, 37, 48, 593, DateTimeKind.Unspecified).AddTicks(6569), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Frozen Cheese" },
                    { 114, new DateTimeOffset(new DateTime(2023, 12, 7, 17, 23, 24, 852, DateTimeKind.Unspecified).AddTicks(5995), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Concrete Table" },
                    { 115, new DateTimeOffset(new DateTime(2023, 2, 23, 15, 9, 1, 111, DateTimeKind.Unspecified).AddTicks(5421), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Rubber Keyboard" },
                    { 116, new DateTimeOffset(new DateTime(2023, 5, 12, 12, 54, 37, 370, DateTimeKind.Unspecified).AddTicks(4847), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Fresh Pizza" },
                    { 117, new DateTimeOffset(new DateTime(2023, 7, 29, 10, 40, 13, 629, DateTimeKind.Unspecified).AddTicks(4273), new TimeSpan(0, 1, 0, 0, 0)), "Refined Wooden Towels" },
                    { 118, new DateTimeOffset(new DateTime(2023, 10, 15, 8, 25, 49, 888, DateTimeKind.Unspecified).AddTicks(3699), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Cotton Bike" },
                    { 119, new DateTimeOffset(new DateTime(2024, 1, 1, 6, 11, 26, 147, DateTimeKind.Unspecified).AddTicks(3125), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Soft Sausages" },
                    { 120, new DateTimeOffset(new DateTime(2023, 3, 20, 3, 57, 2, 406, DateTimeKind.Unspecified).AddTicks(2551), new TimeSpan(0, 1, 0, 0, 0)), "Practical Steel Tuna" },
                    { 121, new DateTimeOffset(new DateTime(2023, 6, 6, 1, 42, 38, 665, DateTimeKind.Unspecified).AddTicks(1977), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Plastic Pants" },
                    { 122, new DateTimeOffset(new DateTime(2023, 8, 22, 23, 28, 14, 924, DateTimeKind.Unspecified).AddTicks(1403), new TimeSpan(0, 1, 0, 0, 0)), "Practical Rubber Car" },
                    { 123, new DateTimeOffset(new DateTime(2023, 11, 8, 21, 13, 51, 183, DateTimeKind.Unspecified).AddTicks(830), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Fresh Fish" },
                    { 124, new DateTimeOffset(new DateTime(2023, 1, 25, 18, 59, 27, 442, DateTimeKind.Unspecified).AddTicks(256), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Concrete Table" },
                    { 125, new DateTimeOffset(new DateTime(2023, 4, 13, 16, 45, 3, 700, DateTimeKind.Unspecified).AddTicks(9682), new TimeSpan(0, 1, 0, 0, 0)), "Small Granite Keyboard" },
                    { 126, new DateTimeOffset(new DateTime(2023, 6, 30, 14, 30, 39, 959, DateTimeKind.Unspecified).AddTicks(9108), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Soft Pizza" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreationDate", "Name" },
                values: new object[,]
                {
                    { 127, new DateTimeOffset(new DateTime(2023, 9, 16, 12, 16, 16, 218, DateTimeKind.Unspecified).AddTicks(8534), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Steel Hat" },
                    { 128, new DateTimeOffset(new DateTime(2023, 12, 3, 10, 1, 52, 477, DateTimeKind.Unspecified).AddTicks(7960), new TimeSpan(0, 1, 0, 0, 0)), "Generic Cotton Bike" },
                    { 129, new DateTimeOffset(new DateTime(2023, 2, 19, 7, 47, 28, 736, DateTimeKind.Unspecified).AddTicks(7386), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Metal Sausages" },
                    { 130, new DateTimeOffset(new DateTime(2023, 5, 8, 5, 33, 4, 995, DateTimeKind.Unspecified).AddTicks(6812), new TimeSpan(0, 1, 0, 0, 0)), "Generic Frozen Tuna" },
                    { 131, new DateTimeOffset(new DateTime(2023, 7, 25, 3, 18, 41, 254, DateTimeKind.Unspecified).AddTicks(6238), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Concrete Pants" },
                    { 132, new DateTimeOffset(new DateTime(2023, 10, 11, 1, 4, 17, 513, DateTimeKind.Unspecified).AddTicks(5664), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Rubber Chair" },
                    { 133, new DateTimeOffset(new DateTime(2023, 12, 27, 22, 49, 53, 772, DateTimeKind.Unspecified).AddTicks(5090), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Fresh Fish" },
                    { 134, new DateTimeOffset(new DateTime(2023, 3, 15, 20, 35, 30, 31, DateTimeKind.Unspecified).AddTicks(4516), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Wooden Table" },
                    { 135, new DateTimeOffset(new DateTime(2023, 6, 1, 18, 21, 6, 290, DateTimeKind.Unspecified).AddTicks(3942), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Cotton Keyboard" },
                    { 136, new DateTimeOffset(new DateTime(2023, 8, 18, 16, 6, 42, 549, DateTimeKind.Unspecified).AddTicks(3368), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Metal Bacon" },
                    { 137, new DateTimeOffset(new DateTime(2023, 11, 4, 13, 52, 18, 808, DateTimeKind.Unspecified).AddTicks(2794), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Steel Hat" },
                    { 138, new DateTimeOffset(new DateTime(2023, 1, 21, 11, 37, 55, 67, DateTimeKind.Unspecified).AddTicks(2220), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Plastic Bike" },
                    { 139, new DateTimeOffset(new DateTime(2023, 4, 9, 9, 23, 31, 326, DateTimeKind.Unspecified).AddTicks(1646), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Rubber Sausages" },
                    { 140, new DateTimeOffset(new DateTime(2023, 6, 26, 7, 9, 7, 585, DateTimeKind.Unspecified).AddTicks(1072), new TimeSpan(0, 1, 0, 0, 0)), "Refined Fresh Tuna" },
                    { 141, new DateTimeOffset(new DateTime(2023, 9, 12, 4, 54, 43, 844, DateTimeKind.Unspecified).AddTicks(498), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Concrete Gloves" },
                    { 142, new DateTimeOffset(new DateTime(2023, 11, 29, 2, 40, 20, 102, DateTimeKind.Unspecified).AddTicks(9924), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Granite Chair" },
                    { 143, new DateTimeOffset(new DateTime(2023, 2, 15, 0, 25, 56, 361, DateTimeKind.Unspecified).AddTicks(9350), new TimeSpan(0, 1, 0, 0, 0)), "Practical Soft Fish" },
                    { 144, new DateTimeOffset(new DateTime(2023, 5, 3, 22, 11, 32, 620, DateTimeKind.Unspecified).AddTicks(8776), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Steel Table" },
                    { 145, new DateTimeOffset(new DateTime(2023, 7, 20, 19, 57, 8, 879, DateTimeKind.Unspecified).AddTicks(8202), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Plastic Computer" },
                    { 146, new DateTimeOffset(new DateTime(2023, 10, 6, 17, 42, 45, 138, DateTimeKind.Unspecified).AddTicks(7628), new TimeSpan(0, 1, 0, 0, 0)), "Small Metal Bacon" },
                    { 147, new DateTimeOffset(new DateTime(2023, 12, 23, 15, 28, 21, 397, DateTimeKind.Unspecified).AddTicks(7054), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Frozen Hat" },
                    { 148, new DateTimeOffset(new DateTime(2023, 3, 11, 13, 13, 57, 656, DateTimeKind.Unspecified).AddTicks(6481), new TimeSpan(0, 1, 0, 0, 0)), "Small Concrete Bike" },
                    { 149, new DateTimeOffset(new DateTime(2023, 5, 28, 10, 59, 33, 915, DateTimeKind.Unspecified).AddTicks(5907), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Granite Sausages" },
                    { 150, new DateTimeOffset(new DateTime(2023, 8, 14, 8, 45, 10, 174, DateTimeKind.Unspecified).AddTicks(5333), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Fresh Soap" },
                    { 151, new DateTimeOffset(new DateTime(2023, 10, 31, 6, 30, 46, 433, DateTimeKind.Unspecified).AddTicks(4759), new TimeSpan(0, 1, 0, 0, 0)), "Generic Wooden Gloves" },
                    { 152, new DateTimeOffset(new DateTime(2023, 1, 17, 4, 16, 22, 692, DateTimeKind.Unspecified).AddTicks(4185), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Cotton Chair" },
                    { 153, new DateTimeOffset(new DateTime(2023, 4, 5, 2, 1, 58, 951, DateTimeKind.Unspecified).AddTicks(3611), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Metal Fish" },
                    { 154, new DateTimeOffset(new DateTime(2023, 6, 21, 23, 47, 35, 210, DateTimeKind.Unspecified).AddTicks(3037), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Steel Shirt" },
                    { 155, new DateTimeOffset(new DateTime(2023, 9, 7, 21, 33, 11, 469, DateTimeKind.Unspecified).AddTicks(2463), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Plastic Computer" },
                    { 156, new DateTimeOffset(new DateTime(2023, 11, 24, 19, 18, 47, 728, DateTimeKind.Unspecified).AddTicks(1889), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Rubber Bacon" },
                    { 157, new DateTimeOffset(new DateTime(2023, 2, 10, 17, 4, 23, 987, DateTimeKind.Unspecified).AddTicks(1315), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Fresh Hat" },
                    { 158, new DateTimeOffset(new DateTime(2023, 4, 29, 14, 50, 0, 246, DateTimeKind.Unspecified).AddTicks(741), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Wooden Mouse" },
                    { 159, new DateTimeOffset(new DateTime(2023, 7, 16, 12, 35, 36, 505, DateTimeKind.Unspecified).AddTicks(167), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Granite Salad" },
                    { 160, new DateTimeOffset(new DateTime(2023, 10, 2, 10, 21, 12, 763, DateTimeKind.Unspecified).AddTicks(9593), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Soft Soap" },
                    { 161, new DateTimeOffset(new DateTime(2023, 12, 19, 8, 6, 49, 22, DateTimeKind.Unspecified).AddTicks(9019), new TimeSpan(0, 1, 0, 0, 0)), "Refined Steel Gloves" },
                    { 162, new DateTimeOffset(new DateTime(2023, 3, 7, 5, 52, 25, 281, DateTimeKind.Unspecified).AddTicks(8445), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Plastic Chair" },
                    { 163, new DateTimeOffset(new DateTime(2023, 5, 24, 3, 38, 1, 540, DateTimeKind.Unspecified).AddTicks(7871), new TimeSpan(0, 1, 0, 0, 0)), "Refined Metal Chicken" },
                    { 164, new DateTimeOffset(new DateTime(2023, 8, 10, 1, 23, 37, 799, DateTimeKind.Unspecified).AddTicks(7297), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Frozen Shirt" },
                    { 165, new DateTimeOffset(new DateTime(2023, 10, 26, 23, 9, 14, 58, DateTimeKind.Unspecified).AddTicks(6723), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Concrete Computer" },
                    { 166, new DateTimeOffset(new DateTime(2024, 1, 12, 20, 54, 50, 317, DateTimeKind.Unspecified).AddTicks(6149), new TimeSpan(0, 1, 0, 0, 0)), "Practical Granite Bacon" },
                    { 167, new DateTimeOffset(new DateTime(2023, 3, 31, 18, 40, 26, 576, DateTimeKind.Unspecified).AddTicks(5575), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Fresh Shoes" },
                    { 168, new DateTimeOffset(new DateTime(2023, 6, 17, 16, 26, 2, 835, DateTimeKind.Unspecified).AddTicks(5001), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Wooden Mouse" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreationDate", "Name" },
                values: new object[,]
                {
                    { 169, new DateTimeOffset(new DateTime(2023, 9, 3, 14, 11, 39, 94, DateTimeKind.Unspecified).AddTicks(4427), new TimeSpan(0, 1, 0, 0, 0)), "Small Cotton Salad" },
                    { 170, new DateTimeOffset(new DateTime(2023, 11, 20, 11, 57, 15, 353, DateTimeKind.Unspecified).AddTicks(3853), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Metal Soap" },
                    { 171, new DateTimeOffset(new DateTime(2023, 2, 6, 9, 42, 51, 612, DateTimeKind.Unspecified).AddTicks(3280), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Frozen Gloves" },
                    { 172, new DateTimeOffset(new DateTime(2023, 4, 25, 7, 28, 27, 871, DateTimeKind.Unspecified).AddTicks(2706), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Plastic Chips" },
                    { 173, new DateTimeOffset(new DateTime(2023, 7, 12, 5, 14, 4, 130, DateTimeKind.Unspecified).AddTicks(2132), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Rubber Chicken" },
                    { 174, new DateTimeOffset(new DateTime(2023, 9, 28, 2, 59, 40, 389, DateTimeKind.Unspecified).AddTicks(1558), new TimeSpan(0, 1, 0, 0, 0)), "Generic Fresh Shirt" },
                    { 175, new DateTimeOffset(new DateTime(2023, 12, 15, 0, 45, 16, 648, DateTimeKind.Unspecified).AddTicks(984), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Wooden Computer" },
                    { 176, new DateTimeOffset(new DateTime(2023, 3, 2, 22, 30, 52, 907, DateTimeKind.Unspecified).AddTicks(410), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Granite Cheese" },
                    { 177, new DateTimeOffset(new DateTime(2023, 5, 19, 20, 16, 29, 165, DateTimeKind.Unspecified).AddTicks(9836), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Soft Shoes" },
                    { 178, new DateTimeOffset(new DateTime(2023, 8, 5, 18, 2, 5, 424, DateTimeKind.Unspecified).AddTicks(9262), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Steel Mouse" },
                    { 179, new DateTimeOffset(new DateTime(2023, 10, 22, 15, 47, 41, 683, DateTimeKind.Unspecified).AddTicks(8688), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Plastic Salad" },
                    { 180, new DateTimeOffset(new DateTime(2024, 1, 8, 13, 33, 17, 942, DateTimeKind.Unspecified).AddTicks(8114), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Rubber Soap" },
                    { 181, new DateTimeOffset(new DateTime(2023, 3, 27, 11, 18, 54, 201, DateTimeKind.Unspecified).AddTicks(7540), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Frozen Ball" },
                    { 182, new DateTimeOffset(new DateTime(2023, 6, 13, 9, 4, 30, 460, DateTimeKind.Unspecified).AddTicks(6966), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Concrete Chips" },
                    { 183, new DateTimeOffset(new DateTime(2023, 8, 30, 6, 50, 6, 719, DateTimeKind.Unspecified).AddTicks(6392), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Granite Chicken" },
                    { 184, new DateTimeOffset(new DateTime(2023, 11, 16, 4, 35, 42, 978, DateTimeKind.Unspecified).AddTicks(5818), new TimeSpan(0, 1, 0, 0, 0)), "Refined Soft Shirt" },
                    { 185, new DateTimeOffset(new DateTime(2023, 2, 2, 2, 21, 19, 237, DateTimeKind.Unspecified).AddTicks(5244), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Wooden Car" },
                    { 186, new DateTimeOffset(new DateTime(2023, 4, 21, 0, 6, 55, 496, DateTimeKind.Unspecified).AddTicks(4670), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Cotton Cheese" },
                    { 187, new DateTimeOffset(new DateTime(2023, 7, 7, 21, 52, 31, 755, DateTimeKind.Unspecified).AddTicks(4096), new TimeSpan(0, 1, 0, 0, 0)), "Practical Metal Shoes" },
                    { 188, new DateTimeOffset(new DateTime(2023, 9, 23, 19, 38, 8, 14, DateTimeKind.Unspecified).AddTicks(3522), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Frozen Mouse" },
                    { 189, new DateTimeOffset(new DateTime(2023, 12, 10, 17, 23, 44, 273, DateTimeKind.Unspecified).AddTicks(2948), new TimeSpan(0, 1, 0, 0, 0)), "Practical Plastic Salad" },
                    { 190, new DateTimeOffset(new DateTime(2023, 2, 26, 15, 9, 20, 532, DateTimeKind.Unspecified).AddTicks(2374), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Rubber Towels" },
                    { 191, new DateTimeOffset(new DateTime(2023, 5, 15, 12, 54, 56, 791, DateTimeKind.Unspecified).AddTicks(1800), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Fresh Ball" },
                    { 192, new DateTimeOffset(new DateTime(2023, 8, 1, 10, 40, 33, 50, DateTimeKind.Unspecified).AddTicks(1226), new TimeSpan(0, 1, 0, 0, 0)), "Small Wooden Chips" },
                    { 193, new DateTimeOffset(new DateTime(2023, 10, 18, 8, 26, 9, 309, DateTimeKind.Unspecified).AddTicks(652), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Cotton Chicken" },
                    { 194, new DateTimeOffset(new DateTime(2024, 1, 4, 6, 11, 45, 568, DateTimeKind.Unspecified).AddTicks(78), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Soft Pants" },
                    { 195, new DateTimeOffset(new DateTime(2023, 3, 23, 3, 57, 21, 826, DateTimeKind.Unspecified).AddTicks(9505), new TimeSpan(0, 1, 0, 0, 0)), "Generic Steel Car" },
                    { 196, new DateTimeOffset(new DateTime(2023, 6, 9, 1, 42, 58, 85, DateTimeKind.Unspecified).AddTicks(8931), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Plastic Cheese" },
                    { 197, new DateTimeOffset(new DateTime(2023, 8, 25, 23, 28, 34, 344, DateTimeKind.Unspecified).AddTicks(8357), new TimeSpan(0, 1, 0, 0, 0)), "Generic Rubber Shoes" },
                    { 198, new DateTimeOffset(new DateTime(2023, 11, 11, 21, 14, 10, 603, DateTimeKind.Unspecified).AddTicks(7783), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Frozen Mouse" },
                    { 199, new DateTimeOffset(new DateTime(2023, 1, 28, 18, 59, 46, 862, DateTimeKind.Unspecified).AddTicks(7209), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Concrete Pizza" },
                    { 200, new DateTimeOffset(new DateTime(2023, 4, 16, 16, 45, 23, 121, DateTimeKind.Unspecified).AddTicks(6635), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Granite Towels" },
                    { 201, new DateTimeOffset(new DateTime(2023, 7, 3, 14, 30, 59, 380, DateTimeKind.Unspecified).AddTicks(6061), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Soft Ball" },
                    { 202, new DateTimeOffset(new DateTime(2023, 9, 19, 12, 16, 35, 639, DateTimeKind.Unspecified).AddTicks(5487), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Steel Chips" },
                    { 203, new DateTimeOffset(new DateTime(2023, 12, 6, 10, 2, 11, 898, DateTimeKind.Unspecified).AddTicks(4913), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Cotton Tuna" },
                    { 204, new DateTimeOffset(new DateTime(2023, 2, 22, 7, 47, 48, 157, DateTimeKind.Unspecified).AddTicks(4339), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Metal Pants" },
                    { 205, new DateTimeOffset(new DateTime(2023, 5, 11, 5, 33, 24, 416, DateTimeKind.Unspecified).AddTicks(3765), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Frozen Car" },
                    { 206, new DateTimeOffset(new DateTime(2023, 7, 28, 3, 19, 0, 675, DateTimeKind.Unspecified).AddTicks(3191), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Concrete Cheese" },
                    { 207, new DateTimeOffset(new DateTime(2023, 10, 14, 1, 4, 36, 934, DateTimeKind.Unspecified).AddTicks(2617), new TimeSpan(0, 1, 0, 0, 0)), "Refined Rubber Shoes" },
                    { 208, new DateTimeOffset(new DateTime(2023, 12, 30, 22, 50, 13, 193, DateTimeKind.Unspecified).AddTicks(2043), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Fresh Keyboard" },
                    { 209, new DateTimeOffset(new DateTime(2023, 3, 18, 20, 35, 49, 452, DateTimeKind.Unspecified).AddTicks(1469), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Wooden Pizza" },
                    { 210, new DateTimeOffset(new DateTime(2023, 6, 4, 18, 21, 25, 711, DateTimeKind.Unspecified).AddTicks(895), new TimeSpan(0, 1, 0, 0, 0)), "Practical Cotton Towels" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreationDate", "Name" },
                values: new object[,]
                {
                    { 211, new DateTimeOffset(new DateTime(2023, 8, 21, 16, 7, 1, 970, DateTimeKind.Unspecified).AddTicks(321), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Soft Ball" },
                    { 212, new DateTimeOffset(new DateTime(2023, 11, 7, 13, 52, 38, 228, DateTimeKind.Unspecified).AddTicks(9747), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Steel Sausages" },
                    { 213, new DateTimeOffset(new DateTime(2023, 1, 24, 11, 38, 14, 487, DateTimeKind.Unspecified).AddTicks(9173), new TimeSpan(0, 1, 0, 0, 0)), "Small Plastic Tuna" },
                    { 214, new DateTimeOffset(new DateTime(2023, 4, 12, 9, 23, 50, 746, DateTimeKind.Unspecified).AddTicks(8599), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Rubber Pants" },
                    { 215, new DateTimeOffset(new DateTime(2023, 6, 29, 7, 9, 27, 5, DateTimeKind.Unspecified).AddTicks(8025), new TimeSpan(0, 1, 0, 0, 0)), "Small Fresh Car" },
                    { 216, new DateTimeOffset(new DateTime(2023, 9, 15, 4, 55, 3, 264, DateTimeKind.Unspecified).AddTicks(7451), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Concrete Fish" },
                    { 217, new DateTimeOffset(new DateTime(2023, 12, 2, 2, 40, 39, 523, DateTimeKind.Unspecified).AddTicks(6877), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Granite Table" },
                    { 218, new DateTimeOffset(new DateTime(2023, 2, 18, 0, 26, 15, 782, DateTimeKind.Unspecified).AddTicks(6303), new TimeSpan(0, 1, 0, 0, 0)), "Generic Soft Keyboard" },
                    { 219, new DateTimeOffset(new DateTime(2023, 5, 6, 22, 11, 52, 41, DateTimeKind.Unspecified).AddTicks(5730), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Steel Pizza" },
                    { 220, new DateTimeOffset(new DateTime(2023, 7, 23, 19, 57, 28, 300, DateTimeKind.Unspecified).AddTicks(5156), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Cotton Towels" },
                    { 221, new DateTimeOffset(new DateTime(2023, 10, 9, 17, 43, 4, 559, DateTimeKind.Unspecified).AddTicks(4582), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Metal Bike" },
                    { 222, new DateTimeOffset(new DateTime(2023, 12, 26, 15, 28, 40, 818, DateTimeKind.Unspecified).AddTicks(4008), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Frozen Sausages" },
                    { 223, new DateTimeOffset(new DateTime(2023, 3, 14, 13, 14, 17, 77, DateTimeKind.Unspecified).AddTicks(3434), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Concrete Tuna" },
                    { 224, new DateTimeOffset(new DateTime(2023, 5, 31, 10, 59, 53, 336, DateTimeKind.Unspecified).AddTicks(2860), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Granite Pants" },
                    { 225, new DateTimeOffset(new DateTime(2023, 8, 17, 8, 45, 29, 595, DateTimeKind.Unspecified).AddTicks(2286), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Fresh Chair" },
                    { 226, new DateTimeOffset(new DateTime(2023, 11, 3, 6, 31, 5, 854, DateTimeKind.Unspecified).AddTicks(1712), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Wooden Fish" },
                    { 227, new DateTimeOffset(new DateTime(2023, 1, 20, 4, 16, 42, 113, DateTimeKind.Unspecified).AddTicks(1138), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Cotton Table" },
                    { 228, new DateTimeOffset(new DateTime(2023, 4, 8, 2, 2, 18, 372, DateTimeKind.Unspecified).AddTicks(564), new TimeSpan(0, 1, 0, 0, 0)), "Refined Metal Keyboard" },
                    { 229, new DateTimeOffset(new DateTime(2023, 6, 24, 23, 47, 54, 630, DateTimeKind.Unspecified).AddTicks(9990), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Steel Pizza" },
                    { 230, new DateTimeOffset(new DateTime(2023, 9, 10, 21, 33, 30, 889, DateTimeKind.Unspecified).AddTicks(9416), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Plastic Hat" },
                    { 231, new DateTimeOffset(new DateTime(2023, 11, 27, 19, 19, 7, 148, DateTimeKind.Unspecified).AddTicks(8842), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Rubber Bike" },
                    { 232, new DateTimeOffset(new DateTime(2023, 2, 13, 17, 4, 43, 407, DateTimeKind.Unspecified).AddTicks(8268), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Fresh Sausages" },
                    { 233, new DateTimeOffset(new DateTime(2023, 5, 2, 14, 50, 19, 666, DateTimeKind.Unspecified).AddTicks(7694), new TimeSpan(0, 1, 0, 0, 0)), "Practical Concrete Tuna" },
                    { 234, new DateTimeOffset(new DateTime(2023, 7, 19, 12, 35, 55, 925, DateTimeKind.Unspecified).AddTicks(7120), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Granite Gloves" },
                    { 235, new DateTimeOffset(new DateTime(2023, 10, 5, 10, 21, 32, 184, DateTimeKind.Unspecified).AddTicks(6546), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Soft Chair" },
                    { 236, new DateTimeOffset(new DateTime(2023, 12, 22, 8, 7, 8, 443, DateTimeKind.Unspecified).AddTicks(5972), new TimeSpan(0, 1, 0, 0, 0)), "Small Steel Fish" },
                    { 237, new DateTimeOffset(new DateTime(2023, 3, 10, 5, 52, 44, 702, DateTimeKind.Unspecified).AddTicks(5398), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Plastic Table" },
                    { 238, new DateTimeOffset(new DateTime(2023, 5, 27, 3, 38, 20, 961, DateTimeKind.Unspecified).AddTicks(4824), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Metal Keyboard" },
                    { 239, new DateTimeOffset(new DateTime(2023, 8, 13, 1, 23, 57, 220, DateTimeKind.Unspecified).AddTicks(4250), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Frozen Bacon" },
                    { 240, new DateTimeOffset(new DateTime(2023, 10, 29, 23, 9, 33, 479, DateTimeKind.Unspecified).AddTicks(3676), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Concrete Hat" },
                    { 241, new DateTimeOffset(new DateTime(2024, 1, 15, 20, 55, 9, 738, DateTimeKind.Unspecified).AddTicks(3102), new TimeSpan(0, 1, 0, 0, 0)), "Generic Granite Bike" },
                    { 242, new DateTimeOffset(new DateTime(2023, 4, 3, 18, 40, 45, 997, DateTimeKind.Unspecified).AddTicks(2528), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Fresh Sausages" },
                    { 243, new DateTimeOffset(new DateTime(2023, 6, 20, 16, 26, 22, 256, DateTimeKind.Unspecified).AddTicks(1955), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Wooden Soap" },
                    { 244, new DateTimeOffset(new DateTime(2023, 9, 6, 14, 11, 58, 515, DateTimeKind.Unspecified).AddTicks(1381), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Cotton Gloves" },
                    { 245, new DateTimeOffset(new DateTime(2023, 11, 23, 11, 57, 34, 774, DateTimeKind.Unspecified).AddTicks(807), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Metal Chair" },
                    { 246, new DateTimeOffset(new DateTime(2023, 2, 9, 9, 43, 11, 33, DateTimeKind.Unspecified).AddTicks(233), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Frozen Fish" },
                    { 247, new DateTimeOffset(new DateTime(2023, 4, 28, 7, 28, 47, 291, DateTimeKind.Unspecified).AddTicks(9659), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Plastic Table" },
                    { 248, new DateTimeOffset(new DateTime(2023, 7, 15, 5, 14, 23, 550, DateTimeKind.Unspecified).AddTicks(9085), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Rubber Computer" },
                    { 249, new DateTimeOffset(new DateTime(2023, 10, 1, 2, 59, 59, 809, DateTimeKind.Unspecified).AddTicks(8511), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Fresh Bacon" },
                    { 250, new DateTimeOffset(new DateTime(2023, 12, 18, 0, 45, 36, 68, DateTimeKind.Unspecified).AddTicks(7937), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Wooden Hat" },
                    { 251, new DateTimeOffset(new DateTime(2023, 3, 5, 22, 31, 12, 327, DateTimeKind.Unspecified).AddTicks(7363), new TimeSpan(0, 1, 0, 0, 0)), "Refined Granite Bike" },
                    { 252, new DateTimeOffset(new DateTime(2023, 5, 22, 20, 16, 48, 586, DateTimeKind.Unspecified).AddTicks(6789), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Soft Salad" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreationDate", "Name" },
                values: new object[,]
                {
                    { 253, new DateTimeOffset(new DateTime(2023, 8, 8, 18, 2, 24, 845, DateTimeKind.Unspecified).AddTicks(6215), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Steel Soap" },
                    { 254, new DateTimeOffset(new DateTime(2023, 10, 25, 15, 48, 1, 104, DateTimeKind.Unspecified).AddTicks(5641), new TimeSpan(0, 1, 0, 0, 0)), "Practical Plastic Gloves" },
                    { 255, new DateTimeOffset(new DateTime(2024, 1, 11, 13, 33, 37, 363, DateTimeKind.Unspecified).AddTicks(5067), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Metal Chair" },
                    { 256, new DateTimeOffset(new DateTime(2023, 3, 30, 11, 19, 13, 622, DateTimeKind.Unspecified).AddTicks(4493), new TimeSpan(0, 1, 0, 0, 0)), "Practical Frozen Fish" },
                    { 257, new DateTimeOffset(new DateTime(2023, 6, 16, 9, 4, 49, 881, DateTimeKind.Unspecified).AddTicks(3919), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Concrete Shirt" },
                    { 258, new DateTimeOffset(new DateTime(2023, 9, 2, 6, 50, 26, 140, DateTimeKind.Unspecified).AddTicks(3345), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Granite Computer" },
                    { 259, new DateTimeOffset(new DateTime(2023, 11, 19, 4, 36, 2, 399, DateTimeKind.Unspecified).AddTicks(2771), new TimeSpan(0, 1, 0, 0, 0)), "Small Soft Bacon" },
                    { 260, new DateTimeOffset(new DateTime(2023, 2, 5, 2, 21, 38, 658, DateTimeKind.Unspecified).AddTicks(2197), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Wooden Hat" },
                    { 261, new DateTimeOffset(new DateTime(2023, 4, 24, 0, 7, 14, 917, DateTimeKind.Unspecified).AddTicks(1623), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Cotton Mouse" },
                    { 262, new DateTimeOffset(new DateTime(2023, 7, 10, 21, 52, 51, 176, DateTimeKind.Unspecified).AddTicks(1049), new TimeSpan(0, 1, 0, 0, 0)), "Generic Metal Salad" },
                    { 263, new DateTimeOffset(new DateTime(2023, 9, 26, 19, 38, 27, 435, DateTimeKind.Unspecified).AddTicks(475), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Frozen Soap" },
                    { 264, new DateTimeOffset(new DateTime(2023, 12, 13, 17, 24, 3, 693, DateTimeKind.Unspecified).AddTicks(9901), new TimeSpan(0, 1, 0, 0, 0)), "Generic Plastic Gloves" },
                    { 265, new DateTimeOffset(new DateTime(2023, 3, 1, 15, 9, 39, 952, DateTimeKind.Unspecified).AddTicks(9327), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Rubber Chips" },
                    { 266, new DateTimeOffset(new DateTime(2023, 5, 18, 12, 55, 16, 211, DateTimeKind.Unspecified).AddTicks(8753), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Fresh Chicken" },
                    { 267, new DateTimeOffset(new DateTime(2023, 8, 4, 10, 40, 52, 470, DateTimeKind.Unspecified).AddTicks(8180), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Wooden Shirt" },
                    { 268, new DateTimeOffset(new DateTime(2023, 10, 21, 8, 26, 28, 729, DateTimeKind.Unspecified).AddTicks(7606), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Cotton Computer" },
                    { 269, new DateTimeOffset(new DateTime(2024, 1, 7, 6, 12, 4, 988, DateTimeKind.Unspecified).AddTicks(7032), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Soft Bacon" },
                    { 270, new DateTimeOffset(new DateTime(2023, 3, 26, 3, 57, 41, 247, DateTimeKind.Unspecified).AddTicks(6458), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Steel Shoes" },
                    { 271, new DateTimeOffset(new DateTime(2023, 6, 12, 1, 43, 17, 506, DateTimeKind.Unspecified).AddTicks(5884), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Plastic Mouse" },
                    { 272, new DateTimeOffset(new DateTime(2023, 8, 28, 23, 28, 53, 765, DateTimeKind.Unspecified).AddTicks(5310), new TimeSpan(0, 1, 0, 0, 0)), "Refined Rubber Salad" },
                    { 273, new DateTimeOffset(new DateTime(2023, 11, 14, 21, 14, 30, 24, DateTimeKind.Unspecified).AddTicks(4736), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Frozen Soap" },
                    { 274, new DateTimeOffset(new DateTime(2023, 1, 31, 19, 0, 6, 283, DateTimeKind.Unspecified).AddTicks(4162), new TimeSpan(0, 1, 0, 0, 0)), "Refined Concrete Ball" },
                    { 275, new DateTimeOffset(new DateTime(2023, 4, 19, 16, 45, 42, 542, DateTimeKind.Unspecified).AddTicks(3588), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Granite Chips" },
                    { 276, new DateTimeOffset(new DateTime(2023, 7, 6, 14, 31, 18, 801, DateTimeKind.Unspecified).AddTicks(3014), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Soft Chicken" },
                    { 277, new DateTimeOffset(new DateTime(2023, 9, 22, 12, 16, 55, 60, DateTimeKind.Unspecified).AddTicks(2440), new TimeSpan(0, 1, 0, 0, 0)), "Practical Wooden Shirt" },
                    { 278, new DateTimeOffset(new DateTime(2023, 12, 9, 10, 2, 31, 319, DateTimeKind.Unspecified).AddTicks(1866), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Cotton Computer" },
                    { 279, new DateTimeOffset(new DateTime(2023, 2, 25, 7, 48, 7, 578, DateTimeKind.Unspecified).AddTicks(1292), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Metal Cheese" },
                    { 280, new DateTimeOffset(new DateTime(2023, 5, 14, 5, 33, 43, 837, DateTimeKind.Unspecified).AddTicks(718), new TimeSpan(0, 1, 0, 0, 0)), "Small Frozen Shoes" },
                    { 281, new DateTimeOffset(new DateTime(2023, 7, 31, 3, 19, 20, 96, DateTimeKind.Unspecified).AddTicks(144), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Concrete Mouse" },
                    { 282, new DateTimeOffset(new DateTime(2023, 10, 17, 1, 4, 56, 354, DateTimeKind.Unspecified).AddTicks(9570), new TimeSpan(0, 1, 0, 0, 0)), "Small Rubber Salad" },
                    { 283, new DateTimeOffset(new DateTime(2024, 1, 2, 22, 50, 32, 613, DateTimeKind.Unspecified).AddTicks(8996), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Fresh Towels" },
                    { 284, new DateTimeOffset(new DateTime(2023, 3, 21, 20, 36, 8, 872, DateTimeKind.Unspecified).AddTicks(8422), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Wooden Ball" },
                    { 285, new DateTimeOffset(new DateTime(2023, 6, 7, 18, 21, 45, 131, DateTimeKind.Unspecified).AddTicks(7848), new TimeSpan(0, 1, 0, 0, 0)), "Generic Cotton Chips" },
                    { 286, new DateTimeOffset(new DateTime(2023, 8, 24, 16, 7, 21, 390, DateTimeKind.Unspecified).AddTicks(7274), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Soft Chicken" },
                    { 287, new DateTimeOffset(new DateTime(2023, 11, 10, 13, 52, 57, 649, DateTimeKind.Unspecified).AddTicks(6700), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Steel Shirt" },
                    { 288, new DateTimeOffset(new DateTime(2023, 1, 27, 11, 38, 33, 908, DateTimeKind.Unspecified).AddTicks(6126), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Plastic Car" },
                    { 289, new DateTimeOffset(new DateTime(2023, 4, 15, 9, 24, 10, 167, DateTimeKind.Unspecified).AddTicks(5552), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Rubber Cheese" },
                    { 290, new DateTimeOffset(new DateTime(2023, 7, 2, 7, 9, 46, 426, DateTimeKind.Unspecified).AddTicks(4978), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Fresh Shoes" },
                    { 291, new DateTimeOffset(new DateTime(2023, 9, 18, 4, 55, 22, 685, DateTimeKind.Unspecified).AddTicks(4405), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Concrete Mouse" },
                    { 292, new DateTimeOffset(new DateTime(2023, 12, 5, 2, 40, 58, 944, DateTimeKind.Unspecified).AddTicks(3831), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Granite Pizza" },
                    { 293, new DateTimeOffset(new DateTime(2023, 2, 21, 0, 26, 35, 203, DateTimeKind.Unspecified).AddTicks(3257), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Soft Towels" },
                    { 294, new DateTimeOffset(new DateTime(2023, 5, 9, 22, 12, 11, 462, DateTimeKind.Unspecified).AddTicks(2683), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Steel Ball" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreationDate", "Name" },
                values: new object[,]
                {
                    { 295, new DateTimeOffset(new DateTime(2023, 7, 26, 19, 57, 47, 721, DateTimeKind.Unspecified).AddTicks(2109), new TimeSpan(0, 1, 0, 0, 0)), "Refined Cotton Chips" },
                    { 296, new DateTimeOffset(new DateTime(2023, 10, 12, 17, 43, 23, 980, DateTimeKind.Unspecified).AddTicks(1535), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Metal Chicken" },
                    { 297, new DateTimeOffset(new DateTime(2023, 12, 29, 15, 29, 0, 239, DateTimeKind.Unspecified).AddTicks(961), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Frozen Pants" },
                    { 298, new DateTimeOffset(new DateTime(2023, 3, 17, 13, 14, 36, 498, DateTimeKind.Unspecified).AddTicks(387), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Concrete Car" },
                    { 299, new DateTimeOffset(new DateTime(2023, 6, 3, 11, 0, 12, 756, DateTimeKind.Unspecified).AddTicks(9813), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Rubber Cheese" },
                    { 300, new DateTimeOffset(new DateTime(2023, 8, 20, 8, 45, 49, 15, DateTimeKind.Unspecified).AddTicks(9239), new TimeSpan(0, 1, 0, 0, 0)), "Practical Fresh Shoes" },
                    { 301, new DateTimeOffset(new DateTime(2023, 11, 6, 6, 31, 25, 274, DateTimeKind.Unspecified).AddTicks(8665), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Wooden Keyboard" },
                    { 302, new DateTimeOffset(new DateTime(2023, 1, 23, 4, 17, 1, 533, DateTimeKind.Unspecified).AddTicks(8091), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Cotton Pizza" },
                    { 303, new DateTimeOffset(new DateTime(2023, 4, 11, 2, 2, 37, 792, DateTimeKind.Unspecified).AddTicks(7517), new TimeSpan(0, 1, 0, 0, 0)), "Small Metal Towels" },
                    { 304, new DateTimeOffset(new DateTime(2023, 6, 27, 23, 48, 14, 51, DateTimeKind.Unspecified).AddTicks(6943), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Steel Ball" },
                    { 305, new DateTimeOffset(new DateTime(2023, 9, 13, 21, 33, 50, 310, DateTimeKind.Unspecified).AddTicks(6369), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Plastic Chips" },
                    { 306, new DateTimeOffset(new DateTime(2023, 11, 30, 19, 19, 26, 569, DateTimeKind.Unspecified).AddTicks(5795), new TimeSpan(0, 1, 0, 0, 0)), "Generic Rubber Tuna" },
                    { 307, new DateTimeOffset(new DateTime(2023, 2, 16, 17, 5, 2, 828, DateTimeKind.Unspecified).AddTicks(5221), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Fresh Pants" },
                    { 308, new DateTimeOffset(new DateTime(2023, 5, 5, 14, 50, 39, 87, DateTimeKind.Unspecified).AddTicks(4647), new TimeSpan(0, 1, 0, 0, 0)), "Generic Concrete Car" },
                    { 309, new DateTimeOffset(new DateTime(2023, 7, 22, 12, 36, 15, 346, DateTimeKind.Unspecified).AddTicks(4073), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Granite Cheese" },
                    { 310, new DateTimeOffset(new DateTime(2023, 10, 8, 10, 21, 51, 605, DateTimeKind.Unspecified).AddTicks(3499), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Soft Table" },
                    { 311, new DateTimeOffset(new DateTime(2023, 12, 25, 8, 7, 27, 864, DateTimeKind.Unspecified).AddTicks(2925), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Steel Keyboard" },
                    { 312, new DateTimeOffset(new DateTime(2023, 3, 13, 5, 53, 4, 123, DateTimeKind.Unspecified).AddTicks(2351), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Cotton Pizza" },
                    { 313, new DateTimeOffset(new DateTime(2023, 5, 30, 3, 38, 40, 382, DateTimeKind.Unspecified).AddTicks(1777), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Metal Towels" },
                    { 314, new DateTimeOffset(new DateTime(2023, 8, 16, 1, 24, 16, 641, DateTimeKind.Unspecified).AddTicks(1204), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Frozen Ball" },
                    { 315, new DateTimeOffset(new DateTime(2023, 11, 1, 23, 9, 52, 900, DateTimeKind.Unspecified).AddTicks(630), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Concrete Sausages" },
                    { 316, new DateTimeOffset(new DateTime(2023, 1, 18, 20, 55, 29, 159, DateTimeKind.Unspecified).AddTicks(56), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Granite Tuna" },
                    { 317, new DateTimeOffset(new DateTime(2023, 4, 6, 18, 41, 5, 417, DateTimeKind.Unspecified).AddTicks(9482), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Fresh Pants" },
                    { 318, new DateTimeOffset(new DateTime(2023, 6, 23, 16, 26, 41, 676, DateTimeKind.Unspecified).AddTicks(8908), new TimeSpan(0, 1, 0, 0, 0)), "Refined Wooden Car" },
                    { 319, new DateTimeOffset(new DateTime(2023, 9, 9, 14, 12, 17, 935, DateTimeKind.Unspecified).AddTicks(8334), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Cotton Fish" },
                    { 320, new DateTimeOffset(new DateTime(2023, 11, 26, 11, 57, 54, 194, DateTimeKind.Unspecified).AddTicks(7760), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Metal Table" },
                    { 321, new DateTimeOffset(new DateTime(2023, 2, 12, 9, 43, 30, 453, DateTimeKind.Unspecified).AddTicks(7186), new TimeSpan(0, 1, 0, 0, 0)), "Practical Steel Keyboard" },
                    { 322, new DateTimeOffset(new DateTime(2023, 5, 1, 7, 29, 6, 712, DateTimeKind.Unspecified).AddTicks(6612), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Plastic Pizza" },
                    { 323, new DateTimeOffset(new DateTime(2023, 7, 18, 5, 14, 42, 971, DateTimeKind.Unspecified).AddTicks(6038), new TimeSpan(0, 1, 0, 0, 0)), "Practical Rubber Hat" },
                    { 324, new DateTimeOffset(new DateTime(2023, 10, 4, 3, 0, 19, 230, DateTimeKind.Unspecified).AddTicks(5464), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Fresh Bike" },
                    { 325, new DateTimeOffset(new DateTime(2023, 12, 21, 0, 45, 55, 489, DateTimeKind.Unspecified).AddTicks(4890), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Wooden Sausages" },
                    { 326, new DateTimeOffset(new DateTime(2023, 3, 8, 22, 31, 31, 748, DateTimeKind.Unspecified).AddTicks(4316), new TimeSpan(0, 1, 0, 0, 0)), "Small Granite Tuna" },
                    { 327, new DateTimeOffset(new DateTime(2023, 5, 25, 20, 17, 8, 7, DateTimeKind.Unspecified).AddTicks(3742), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Soft Pants" },
                    { 328, new DateTimeOffset(new DateTime(2023, 8, 11, 18, 2, 44, 266, DateTimeKind.Unspecified).AddTicks(3168), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Steel Chair" },
                    { 329, new DateTimeOffset(new DateTime(2023, 10, 28, 15, 48, 20, 525, DateTimeKind.Unspecified).AddTicks(2594), new TimeSpan(0, 1, 0, 0, 0)), "Generic Plastic Fish" },
                    { 330, new DateTimeOffset(new DateTime(2024, 1, 14, 13, 33, 56, 784, DateTimeKind.Unspecified).AddTicks(2020), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Metal Table" },
                    { 331, new DateTimeOffset(new DateTime(2023, 4, 2, 11, 19, 33, 43, DateTimeKind.Unspecified).AddTicks(1446), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Frozen Keyboard" },
                    { 332, new DateTimeOffset(new DateTime(2023, 6, 19, 9, 5, 9, 302, DateTimeKind.Unspecified).AddTicks(872), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Concrete Bacon" },
                    { 333, new DateTimeOffset(new DateTime(2023, 9, 5, 6, 50, 45, 561, DateTimeKind.Unspecified).AddTicks(298), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Granite Hat" },
                    { 334, new DateTimeOffset(new DateTime(2023, 11, 22, 4, 36, 21, 819, DateTimeKind.Unspecified).AddTicks(9724), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Fresh Bike" },
                    { 335, new DateTimeOffset(new DateTime(2023, 2, 8, 2, 21, 58, 78, DateTimeKind.Unspecified).AddTicks(9150), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Wooden Sausages" },
                    { 336, new DateTimeOffset(new DateTime(2023, 4, 27, 0, 7, 34, 337, DateTimeKind.Unspecified).AddTicks(8576), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Cotton Tuna" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreationDate", "Name" },
                values: new object[,]
                {
                    { 337, new DateTimeOffset(new DateTime(2023, 7, 13, 21, 53, 10, 596, DateTimeKind.Unspecified).AddTicks(8002), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Metal Gloves" },
                    { 338, new DateTimeOffset(new DateTime(2023, 9, 29, 19, 38, 46, 855, DateTimeKind.Unspecified).AddTicks(7428), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Frozen Chair" },
                    { 339, new DateTimeOffset(new DateTime(2023, 12, 16, 17, 24, 23, 114, DateTimeKind.Unspecified).AddTicks(6855), new TimeSpan(0, 1, 0, 0, 0)), "Refined Plastic Fish" },
                    { 340, new DateTimeOffset(new DateTime(2023, 3, 4, 15, 9, 59, 373, DateTimeKind.Unspecified).AddTicks(6281), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Rubber Table" },
                    { 341, new DateTimeOffset(new DateTime(2023, 5, 21, 12, 55, 35, 632, DateTimeKind.Unspecified).AddTicks(5707), new TimeSpan(0, 1, 0, 0, 0)), "Refined Fresh Computer" },
                    { 342, new DateTimeOffset(new DateTime(2023, 8, 7, 10, 41, 11, 891, DateTimeKind.Unspecified).AddTicks(5133), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Wooden Bacon" },
                    { 343, new DateTimeOffset(new DateTime(2023, 10, 24, 8, 26, 48, 150, DateTimeKind.Unspecified).AddTicks(4559), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Granite Hat" },
                    { 344, new DateTimeOffset(new DateTime(2024, 1, 10, 6, 12, 24, 409, DateTimeKind.Unspecified).AddTicks(3985), new TimeSpan(0, 1, 0, 0, 0)), "Practical Soft Bike" },
                    { 345, new DateTimeOffset(new DateTime(2023, 3, 29, 3, 58, 0, 668, DateTimeKind.Unspecified).AddTicks(3411), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Steel Sausages" },
                    { 346, new DateTimeOffset(new DateTime(2023, 6, 15, 1, 43, 36, 927, DateTimeKind.Unspecified).AddTicks(2837), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Plastic Soap" },
                    { 347, new DateTimeOffset(new DateTime(2023, 8, 31, 23, 29, 13, 186, DateTimeKind.Unspecified).AddTicks(2263), new TimeSpan(0, 1, 0, 0, 0)), "Small Rubber Gloves" },
                    { 348, new DateTimeOffset(new DateTime(2023, 11, 17, 21, 14, 49, 445, DateTimeKind.Unspecified).AddTicks(1689), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Frozen Chair" },
                    { 349, new DateTimeOffset(new DateTime(2023, 2, 3, 19, 0, 25, 704, DateTimeKind.Unspecified).AddTicks(1115), new TimeSpan(0, 1, 0, 0, 0)), "Small Concrete Fish" },
                    { 350, new DateTimeOffset(new DateTime(2023, 4, 22, 16, 46, 1, 963, DateTimeKind.Unspecified).AddTicks(541), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Granite Shirt" },
                    { 351, new DateTimeOffset(new DateTime(2023, 7, 9, 14, 31, 38, 221, DateTimeKind.Unspecified).AddTicks(9967), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Soft Computer" },
                    { 352, new DateTimeOffset(new DateTime(2023, 9, 25, 12, 17, 14, 480, DateTimeKind.Unspecified).AddTicks(9393), new TimeSpan(0, 1, 0, 0, 0)), "Generic Wooden Bacon" },
                    { 353, new DateTimeOffset(new DateTime(2023, 12, 12, 10, 2, 50, 739, DateTimeKind.Unspecified).AddTicks(8819), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Cotton Hat" },
                    { 354, new DateTimeOffset(new DateTime(2023, 2, 28, 7, 48, 26, 998, DateTimeKind.Unspecified).AddTicks(8245), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Metal Bike" },
                    { 355, new DateTimeOffset(new DateTime(2023, 5, 17, 5, 34, 3, 257, DateTimeKind.Unspecified).AddTicks(7671), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Frozen Salad" },
                    { 356, new DateTimeOffset(new DateTime(2023, 8, 3, 3, 19, 39, 516, DateTimeKind.Unspecified).AddTicks(7097), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Plastic Soap" },
                    { 357, new DateTimeOffset(new DateTime(2023, 10, 20, 1, 5, 15, 775, DateTimeKind.Unspecified).AddTicks(6523), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Rubber Gloves" },
                    { 358, new DateTimeOffset(new DateTime(2024, 1, 5, 22, 50, 52, 34, DateTimeKind.Unspecified).AddTicks(5949), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Fresh Chair" },
                    { 359, new DateTimeOffset(new DateTime(2023, 3, 24, 20, 36, 28, 293, DateTimeKind.Unspecified).AddTicks(5375), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Wooden Chicken" },
                    { 360, new DateTimeOffset(new DateTime(2023, 6, 10, 18, 22, 4, 552, DateTimeKind.Unspecified).AddTicks(4801), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Cotton Shirt" },
                    { 361, new DateTimeOffset(new DateTime(2023, 8, 27, 16, 7, 40, 811, DateTimeKind.Unspecified).AddTicks(4227), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Soft Computer" },
                    { 362, new DateTimeOffset(new DateTime(2023, 11, 13, 13, 53, 17, 70, DateTimeKind.Unspecified).AddTicks(3654), new TimeSpan(0, 1, 0, 0, 0)), "Refined Steel Bacon" },
                    { 363, new DateTimeOffset(new DateTime(2023, 1, 30, 11, 38, 53, 329, DateTimeKind.Unspecified).AddTicks(3080), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Plastic Hat" },
                    { 364, new DateTimeOffset(new DateTime(2023, 4, 18, 9, 24, 29, 588, DateTimeKind.Unspecified).AddTicks(2506), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Rubber Mouse" },
                    { 365, new DateTimeOffset(new DateTime(2023, 7, 5, 7, 10, 5, 847, DateTimeKind.Unspecified).AddTicks(1932), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Frozen Salad" },
                    { 366, new DateTimeOffset(new DateTime(2023, 9, 21, 4, 55, 42, 106, DateTimeKind.Unspecified).AddTicks(1358), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Concrete Soap" },
                    { 367, new DateTimeOffset(new DateTime(2023, 12, 8, 2, 41, 18, 365, DateTimeKind.Unspecified).AddTicks(784), new TimeSpan(0, 1, 0, 0, 0)), "Practical Granite Gloves" },
                    { 368, new DateTimeOffset(new DateTime(2023, 2, 24, 0, 26, 54, 624, DateTimeKind.Unspecified).AddTicks(210), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Soft Chips" },
                    { 369, new DateTimeOffset(new DateTime(2023, 5, 12, 22, 12, 30, 882, DateTimeKind.Unspecified).AddTicks(9636), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Steel Chicken" },
                    { 370, new DateTimeOffset(new DateTime(2023, 7, 29, 19, 58, 7, 141, DateTimeKind.Unspecified).AddTicks(9062), new TimeSpan(0, 1, 0, 0, 0)), "Small Cotton Shirt" },
                    { 371, new DateTimeOffset(new DateTime(2023, 10, 15, 17, 43, 43, 400, DateTimeKind.Unspecified).AddTicks(8488), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Metal Computer" },
                    { 372, new DateTimeOffset(new DateTime(2024, 1, 1, 15, 29, 19, 659, DateTimeKind.Unspecified).AddTicks(7914), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Frozen Cheese" },
                    { 373, new DateTimeOffset(new DateTime(2023, 3, 20, 13, 14, 55, 918, DateTimeKind.Unspecified).AddTicks(7340), new TimeSpan(0, 1, 0, 0, 0)), "Generic Concrete Shoes" },
                    { 374, new DateTimeOffset(new DateTime(2023, 6, 6, 11, 0, 32, 177, DateTimeKind.Unspecified).AddTicks(6766), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Rubber Mouse" },
                    { 375, new DateTimeOffset(new DateTime(2023, 8, 23, 8, 46, 8, 436, DateTimeKind.Unspecified).AddTicks(6192), new TimeSpan(0, 1, 0, 0, 0)), "Generic Fresh Salad" },
                    { 376, new DateTimeOffset(new DateTime(2023, 11, 9, 6, 31, 44, 695, DateTimeKind.Unspecified).AddTicks(5618), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Wooden Soap" },
                    { 377, new DateTimeOffset(new DateTime(2023, 1, 26, 4, 17, 20, 954, DateTimeKind.Unspecified).AddTicks(5044), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Cotton Ball" },
                    { 378, new DateTimeOffset(new DateTime(2023, 4, 14, 2, 2, 57, 213, DateTimeKind.Unspecified).AddTicks(4470), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Soft Chips" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreationDate", "Name" },
                values: new object[,]
                {
                    { 379, new DateTimeOffset(new DateTime(2023, 6, 30, 23, 48, 33, 472, DateTimeKind.Unspecified).AddTicks(3896), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Steel Chicken" },
                    { 380, new DateTimeOffset(new DateTime(2023, 9, 16, 21, 34, 9, 731, DateTimeKind.Unspecified).AddTicks(3322), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Plastic Shirt" },
                    { 381, new DateTimeOffset(new DateTime(2023, 12, 3, 19, 19, 45, 990, DateTimeKind.Unspecified).AddTicks(2748), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Rubber Car" },
                    { 382, new DateTimeOffset(new DateTime(2023, 2, 19, 17, 5, 22, 249, DateTimeKind.Unspecified).AddTicks(2174), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Fresh Cheese" },
                    { 383, new DateTimeOffset(new DateTime(2023, 5, 8, 14, 50, 58, 508, DateTimeKind.Unspecified).AddTicks(1600), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Concrete Shoes" },
                    { 384, new DateTimeOffset(new DateTime(2023, 7, 25, 12, 36, 34, 767, DateTimeKind.Unspecified).AddTicks(1026), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Granite Mouse" },
                    { 385, new DateTimeOffset(new DateTime(2023, 10, 11, 10, 22, 11, 26, DateTimeKind.Unspecified).AddTicks(452), new TimeSpan(0, 1, 0, 0, 0)), "Refined Soft Salad" },
                    { 386, new DateTimeOffset(new DateTime(2023, 12, 28, 8, 7, 47, 284, DateTimeKind.Unspecified).AddTicks(9878), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Steel Towels" },
                    { 387, new DateTimeOffset(new DateTime(2023, 3, 16, 5, 53, 23, 543, DateTimeKind.Unspecified).AddTicks(9305), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Cotton Ball" },
                    { 388, new DateTimeOffset(new DateTime(2023, 6, 2, 3, 38, 59, 802, DateTimeKind.Unspecified).AddTicks(8731), new TimeSpan(0, 1, 0, 0, 0)), "Practical Metal Chips" },
                    { 389, new DateTimeOffset(new DateTime(2023, 8, 19, 1, 24, 36, 61, DateTimeKind.Unspecified).AddTicks(8157), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Frozen Chicken" },
                    { 390, new DateTimeOffset(new DateTime(2023, 11, 4, 23, 10, 12, 320, DateTimeKind.Unspecified).AddTicks(7583), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Concrete Pants" },
                    { 391, new DateTimeOffset(new DateTime(2023, 1, 21, 20, 55, 48, 579, DateTimeKind.Unspecified).AddTicks(7009), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Granite Car" },
                    { 392, new DateTimeOffset(new DateTime(2023, 4, 9, 18, 41, 24, 838, DateTimeKind.Unspecified).AddTicks(6435), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Fresh Cheese" },
                    { 393, new DateTimeOffset(new DateTime(2023, 6, 26, 16, 27, 1, 97, DateTimeKind.Unspecified).AddTicks(5861), new TimeSpan(0, 1, 0, 0, 0)), "Small Wooden Shoes" },
                    { 394, new DateTimeOffset(new DateTime(2023, 9, 12, 14, 12, 37, 356, DateTimeKind.Unspecified).AddTicks(5287), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Cotton Mouse" },
                    { 395, new DateTimeOffset(new DateTime(2023, 11, 29, 11, 58, 13, 615, DateTimeKind.Unspecified).AddTicks(4713), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Metal Pizza" },
                    { 396, new DateTimeOffset(new DateTime(2023, 2, 15, 9, 43, 49, 874, DateTimeKind.Unspecified).AddTicks(4139), new TimeSpan(0, 1, 0, 0, 0)), "Generic Steel Towels" },
                    { 397, new DateTimeOffset(new DateTime(2023, 5, 4, 7, 29, 26, 133, DateTimeKind.Unspecified).AddTicks(3565), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Plastic Ball" },
                    { 398, new DateTimeOffset(new DateTime(2023, 7, 21, 5, 15, 2, 392, DateTimeKind.Unspecified).AddTicks(2991), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Rubber Chips" },
                    { 399, new DateTimeOffset(new DateTime(2023, 10, 7, 3, 0, 38, 651, DateTimeKind.Unspecified).AddTicks(2417), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Fresh Tuna" },
                    { 400, new DateTimeOffset(new DateTime(2023, 12, 24, 0, 46, 14, 910, DateTimeKind.Unspecified).AddTicks(1843), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Concrete Pants" },
                    { 401, new DateTimeOffset(new DateTime(2023, 3, 11, 22, 31, 51, 169, DateTimeKind.Unspecified).AddTicks(1269), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Granite Car" },
                    { 402, new DateTimeOffset(new DateTime(2023, 5, 28, 20, 17, 27, 428, DateTimeKind.Unspecified).AddTicks(695), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Soft Cheese" },
                    { 403, new DateTimeOffset(new DateTime(2023, 8, 14, 18, 3, 3, 687, DateTimeKind.Unspecified).AddTicks(121), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Steel Shoes" },
                    { 404, new DateTimeOffset(new DateTime(2023, 10, 31, 15, 48, 39, 945, DateTimeKind.Unspecified).AddTicks(9547), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Plastic Keyboard" },
                    { 405, new DateTimeOffset(new DateTime(2023, 1, 17, 13, 34, 16, 204, DateTimeKind.Unspecified).AddTicks(8973), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Metal Pizza" },
                    { 406, new DateTimeOffset(new DateTime(2023, 4, 5, 11, 19, 52, 463, DateTimeKind.Unspecified).AddTicks(8399), new TimeSpan(0, 1, 0, 0, 0)), "Refined Frozen Towels" },
                    { 407, new DateTimeOffset(new DateTime(2023, 6, 22, 9, 5, 28, 722, DateTimeKind.Unspecified).AddTicks(7825), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Concrete Ball" },
                    { 408, new DateTimeOffset(new DateTime(2023, 9, 8, 6, 51, 4, 981, DateTimeKind.Unspecified).AddTicks(7251), new TimeSpan(0, 1, 0, 0, 0)), "Refined Granite Sausages" },
                    { 409, new DateTimeOffset(new DateTime(2023, 11, 25, 4, 36, 41, 240, DateTimeKind.Unspecified).AddTicks(6678), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Fresh Tuna" },
                    { 410, new DateTimeOffset(new DateTime(2023, 2, 11, 2, 22, 17, 499, DateTimeKind.Unspecified).AddTicks(6104), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Wooden Pants" },
                    { 411, new DateTimeOffset(new DateTime(2023, 4, 30, 0, 7, 53, 758, DateTimeKind.Unspecified).AddTicks(5530), new TimeSpan(0, 1, 0, 0, 0)), "Practical Cotton Car" },
                    { 412, new DateTimeOffset(new DateTime(2023, 7, 16, 21, 53, 30, 17, DateTimeKind.Unspecified).AddTicks(4956), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Metal Cheese" },
                    { 413, new DateTimeOffset(new DateTime(2023, 10, 2, 19, 39, 6, 276, DateTimeKind.Unspecified).AddTicks(4382), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Frozen Table" },
                    { 414, new DateTimeOffset(new DateTime(2023, 12, 19, 17, 24, 42, 535, DateTimeKind.Unspecified).AddTicks(3808), new TimeSpan(0, 1, 0, 0, 0)), "Small Plastic Keyboard" },
                    { 415, new DateTimeOffset(new DateTime(2023, 3, 7, 15, 10, 18, 794, DateTimeKind.Unspecified).AddTicks(3234), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Rubber Pizza" },
                    { 416, new DateTimeOffset(new DateTime(2023, 5, 24, 12, 55, 55, 53, DateTimeKind.Unspecified).AddTicks(2660), new TimeSpan(0, 1, 0, 0, 0)), "Small Fresh Towels" },
                    { 417, new DateTimeOffset(new DateTime(2023, 8, 10, 10, 41, 31, 312, DateTimeKind.Unspecified).AddTicks(2086), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Wooden Bike" },
                    { 418, new DateTimeOffset(new DateTime(2023, 10, 27, 8, 27, 7, 571, DateTimeKind.Unspecified).AddTicks(1512), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Granite Sausages" },
                    { 419, new DateTimeOffset(new DateTime(2024, 1, 13, 6, 12, 43, 830, DateTimeKind.Unspecified).AddTicks(938), new TimeSpan(0, 1, 0, 0, 0)), "Generic Soft Tuna" },
                    { 420, new DateTimeOffset(new DateTime(2023, 4, 1, 3, 58, 20, 89, DateTimeKind.Unspecified).AddTicks(364), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Steel Pants" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreationDate", "Name" },
                values: new object[,]
                {
                    { 421, new DateTimeOffset(new DateTime(2023, 6, 18, 1, 43, 56, 347, DateTimeKind.Unspecified).AddTicks(9790), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Plastic Car" },
                    { 422, new DateTimeOffset(new DateTime(2023, 9, 3, 23, 29, 32, 606, DateTimeKind.Unspecified).AddTicks(9216), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Metal Fish" },
                    { 423, new DateTimeOffset(new DateTime(2023, 11, 20, 21, 15, 8, 865, DateTimeKind.Unspecified).AddTicks(8642), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Frozen Table" },
                    { 424, new DateTimeOffset(new DateTime(2023, 2, 6, 19, 0, 45, 124, DateTimeKind.Unspecified).AddTicks(8068), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Concrete Keyboard" },
                    { 425, new DateTimeOffset(new DateTime(2023, 4, 25, 16, 46, 21, 383, DateTimeKind.Unspecified).AddTicks(7494), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Granite Pizza" },
                    { 426, new DateTimeOffset(new DateTime(2023, 7, 12, 14, 31, 57, 642, DateTimeKind.Unspecified).AddTicks(6920), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Soft Hat" },
                    { 427, new DateTimeOffset(new DateTime(2023, 9, 28, 12, 17, 33, 901, DateTimeKind.Unspecified).AddTicks(6346), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Wooden Bike" },
                    { 428, new DateTimeOffset(new DateTime(2023, 12, 15, 10, 3, 10, 160, DateTimeKind.Unspecified).AddTicks(5772), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Cotton Sausages" },
                    { 429, new DateTimeOffset(new DateTime(2023, 3, 3, 7, 48, 46, 419, DateTimeKind.Unspecified).AddTicks(5198), new TimeSpan(0, 1, 0, 0, 0)), "Refined Metal Tuna" },
                    { 430, new DateTimeOffset(new DateTime(2023, 5, 20, 5, 34, 22, 678, DateTimeKind.Unspecified).AddTicks(4624), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Frozen Gloves" },
                    { 431, new DateTimeOffset(new DateTime(2023, 8, 6, 3, 19, 58, 937, DateTimeKind.Unspecified).AddTicks(4050), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Plastic Chair" },
                    { 432, new DateTimeOffset(new DateTime(2023, 10, 23, 1, 5, 35, 196, DateTimeKind.Unspecified).AddTicks(3476), new TimeSpan(0, 1, 0, 0, 0)), "Practical Rubber Fish" },
                    { 433, new DateTimeOffset(new DateTime(2024, 1, 8, 22, 51, 11, 455, DateTimeKind.Unspecified).AddTicks(2902), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Fresh Table" },
                    { 434, new DateTimeOffset(new DateTime(2023, 3, 27, 20, 36, 47, 714, DateTimeKind.Unspecified).AddTicks(2329), new TimeSpan(0, 1, 0, 0, 0)), "Practical Wooden Keyboard" },
                    { 435, new DateTimeOffset(new DateTime(2023, 6, 13, 18, 22, 23, 973, DateTimeKind.Unspecified).AddTicks(1755), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Cotton Bacon" },
                    { 436, new DateTimeOffset(new DateTime(2023, 8, 30, 16, 8, 0, 232, DateTimeKind.Unspecified).AddTicks(1181), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Soft Hat" },
                    { 437, new DateTimeOffset(new DateTime(2023, 11, 16, 13, 53, 36, 491, DateTimeKind.Unspecified).AddTicks(607), new TimeSpan(0, 1, 0, 0, 0)), "Small Steel Bike" },
                    { 438, new DateTimeOffset(new DateTime(2023, 2, 2, 11, 39, 12, 750, DateTimeKind.Unspecified).AddTicks(33), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Plastic Sausages" },
                    { 439, new DateTimeOffset(new DateTime(2023, 4, 21, 9, 24, 49, 8, DateTimeKind.Unspecified).AddTicks(9459), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Rubber Soap" },
                    { 440, new DateTimeOffset(new DateTime(2023, 7, 8, 7, 10, 25, 267, DateTimeKind.Unspecified).AddTicks(8885), new TimeSpan(0, 1, 0, 0, 0)), "Generic Frozen Gloves" },
                    { 441, new DateTimeOffset(new DateTime(2023, 9, 24, 4, 56, 1, 526, DateTimeKind.Unspecified).AddTicks(8311), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Concrete Chair" },
                    { 442, new DateTimeOffset(new DateTime(2023, 12, 11, 2, 41, 37, 785, DateTimeKind.Unspecified).AddTicks(7737), new TimeSpan(0, 1, 0, 0, 0)), "Generic Granite Fish" },
                    { 443, new DateTimeOffset(new DateTime(2023, 2, 27, 0, 27, 14, 44, DateTimeKind.Unspecified).AddTicks(7163), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Soft Table" },
                    { 444, new DateTimeOffset(new DateTime(2023, 5, 15, 22, 12, 50, 303, DateTimeKind.Unspecified).AddTicks(6589), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Wooden Computer" },
                    { 445, new DateTimeOffset(new DateTime(2023, 8, 1, 19, 58, 26, 562, DateTimeKind.Unspecified).AddTicks(6015), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Cotton Bacon" },
                    { 446, new DateTimeOffset(new DateTime(2023, 10, 18, 17, 44, 2, 821, DateTimeKind.Unspecified).AddTicks(5441), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Metal Hat" },
                    { 447, new DateTimeOffset(new DateTime(2024, 1, 4, 15, 29, 39, 80, DateTimeKind.Unspecified).AddTicks(4867), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Frozen Bike" },
                    { 448, new DateTimeOffset(new DateTime(2023, 3, 23, 13, 15, 15, 339, DateTimeKind.Unspecified).AddTicks(4293), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Concrete Salad" },
                    { 449, new DateTimeOffset(new DateTime(2023, 6, 9, 11, 0, 51, 598, DateTimeKind.Unspecified).AddTicks(3719), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Rubber Soap" },
                    { 450, new DateTimeOffset(new DateTime(2023, 8, 26, 8, 46, 27, 857, DateTimeKind.Unspecified).AddTicks(3145), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Fresh Gloves" },
                    { 451, new DateTimeOffset(new DateTime(2023, 11, 12, 6, 32, 4, 116, DateTimeKind.Unspecified).AddTicks(2571), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Wooden Chair" },
                    { 452, new DateTimeOffset(new DateTime(2023, 1, 29, 4, 17, 40, 375, DateTimeKind.Unspecified).AddTicks(1997), new TimeSpan(0, 1, 0, 0, 0)), "Refined Cotton Fish" },
                    { 453, new DateTimeOffset(new DateTime(2023, 4, 17, 2, 3, 16, 634, DateTimeKind.Unspecified).AddTicks(1423), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Soft Shirt" },
                    { 454, new DateTimeOffset(new DateTime(2023, 7, 3, 23, 48, 52, 893, DateTimeKind.Unspecified).AddTicks(849), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Steel Computer" },
                    { 455, new DateTimeOffset(new DateTime(2023, 9, 19, 21, 34, 29, 152, DateTimeKind.Unspecified).AddTicks(275), new TimeSpan(0, 1, 0, 0, 0)), "Practical Plastic Bacon" },
                    { 456, new DateTimeOffset(new DateTime(2023, 12, 6, 19, 20, 5, 410, DateTimeKind.Unspecified).AddTicks(9701), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Rubber Hat" },
                    { 457, new DateTimeOffset(new DateTime(2023, 2, 22, 17, 5, 41, 669, DateTimeKind.Unspecified).AddTicks(9127), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Frozen Mouse" },
                    { 458, new DateTimeOffset(new DateTime(2023, 5, 11, 14, 51, 17, 928, DateTimeKind.Unspecified).AddTicks(8554), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Concrete Salad" },
                    { 459, new DateTimeOffset(new DateTime(2023, 7, 28, 12, 36, 54, 187, DateTimeKind.Unspecified).AddTicks(7980), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Granite Soap" },
                    { 460, new DateTimeOffset(new DateTime(2023, 10, 14, 10, 22, 30, 446, DateTimeKind.Unspecified).AddTicks(7406), new TimeSpan(0, 1, 0, 0, 0)), "Small Soft Gloves" },
                    { 461, new DateTimeOffset(new DateTime(2023, 12, 31, 8, 8, 6, 705, DateTimeKind.Unspecified).AddTicks(6832), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Steel Chair" },
                    { 462, new DateTimeOffset(new DateTime(2023, 3, 19, 5, 53, 42, 964, DateTimeKind.Unspecified).AddTicks(6258), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Cotton Chicken" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreationDate", "Name" },
                values: new object[,]
                {
                    { 463, new DateTimeOffset(new DateTime(2023, 6, 5, 3, 39, 19, 223, DateTimeKind.Unspecified).AddTicks(5684), new TimeSpan(0, 1, 0, 0, 0)), "Generic Metal Shirt" },
                    { 464, new DateTimeOffset(new DateTime(2023, 8, 22, 1, 24, 55, 482, DateTimeKind.Unspecified).AddTicks(5110), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Frozen Computer" },
                    { 465, new DateTimeOffset(new DateTime(2023, 11, 7, 23, 10, 31, 741, DateTimeKind.Unspecified).AddTicks(4536), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Concrete Bacon" },
                    { 466, new DateTimeOffset(new DateTime(2023, 1, 24, 20, 56, 8, 0, DateTimeKind.Unspecified).AddTicks(3962), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Rubber Shoes" },
                    { 467, new DateTimeOffset(new DateTime(2023, 4, 12, 18, 41, 44, 259, DateTimeKind.Unspecified).AddTicks(3388), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Fresh Mouse" },
                    { 468, new DateTimeOffset(new DateTime(2023, 6, 29, 16, 27, 20, 518, DateTimeKind.Unspecified).AddTicks(2814), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Wooden Salad" },
                    { 469, new DateTimeOffset(new DateTime(2023, 9, 15, 14, 12, 56, 777, DateTimeKind.Unspecified).AddTicks(2240), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Cotton Soap" },
                    { 470, new DateTimeOffset(new DateTime(2023, 12, 2, 11, 58, 33, 36, DateTimeKind.Unspecified).AddTicks(1666), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Metal Gloves" },
                    { 471, new DateTimeOffset(new DateTime(2023, 2, 18, 9, 44, 9, 295, DateTimeKind.Unspecified).AddTicks(1092), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Steel Chips" },
                    { 472, new DateTimeOffset(new DateTime(2023, 5, 7, 7, 29, 45, 554, DateTimeKind.Unspecified).AddTicks(518), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Plastic Chicken" },
                    { 473, new DateTimeOffset(new DateTime(2023, 7, 24, 5, 15, 21, 812, DateTimeKind.Unspecified).AddTicks(9944), new TimeSpan(0, 1, 0, 0, 0)), "Refined Rubber Shirt" },
                    { 474, new DateTimeOffset(new DateTime(2023, 10, 10, 3, 0, 58, 71, DateTimeKind.Unspecified).AddTicks(9370), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Fresh Computer" },
                    { 475, new DateTimeOffset(new DateTime(2023, 12, 27, 0, 46, 34, 330, DateTimeKind.Unspecified).AddTicks(8796), new TimeSpan(0, 1, 0, 0, 0)), "Refined Concrete Cheese" },
                    { 476, new DateTimeOffset(new DateTime(2023, 3, 14, 22, 32, 10, 589, DateTimeKind.Unspecified).AddTicks(8222), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Granite Shoes" },
                    { 477, new DateTimeOffset(new DateTime(2023, 5, 31, 20, 17, 46, 848, DateTimeKind.Unspecified).AddTicks(7648), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Soft Mouse" },
                    { 478, new DateTimeOffset(new DateTime(2023, 8, 17, 18, 3, 23, 107, DateTimeKind.Unspecified).AddTicks(7074), new TimeSpan(0, 1, 0, 0, 0)), "Practical Steel Salad" },
                    { 479, new DateTimeOffset(new DateTime(2023, 11, 3, 15, 48, 59, 366, DateTimeKind.Unspecified).AddTicks(6500), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Cotton Towels" },
                    { 480, new DateTimeOffset(new DateTime(2023, 1, 20, 13, 34, 35, 625, DateTimeKind.Unspecified).AddTicks(5926), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Metal Ball" },
                    { 481, new DateTimeOffset(new DateTime(2023, 4, 8, 11, 20, 11, 884, DateTimeKind.Unspecified).AddTicks(5352), new TimeSpan(0, 1, 0, 0, 0)), "Small Frozen Chips" },
                    { 482, new DateTimeOffset(new DateTime(2023, 6, 25, 9, 5, 48, 143, DateTimeKind.Unspecified).AddTicks(4779), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Concrete Chicken" },
                    { 483, new DateTimeOffset(new DateTime(2023, 9, 11, 6, 51, 24, 402, DateTimeKind.Unspecified).AddTicks(4205), new TimeSpan(0, 1, 0, 0, 0)), "Small Granite Shirt" },
                    { 484, new DateTimeOffset(new DateTime(2023, 11, 28, 4, 37, 0, 661, DateTimeKind.Unspecified).AddTicks(3631), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Fresh Car" },
                    { 485, new DateTimeOffset(new DateTime(2023, 2, 14, 2, 22, 36, 920, DateTimeKind.Unspecified).AddTicks(3057), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Wooden Cheese" },
                    { 486, new DateTimeOffset(new DateTime(2023, 5, 3, 0, 8, 13, 179, DateTimeKind.Unspecified).AddTicks(2483), new TimeSpan(0, 1, 0, 0, 0)), "Generic Cotton Shoes" },
                    { 487, new DateTimeOffset(new DateTime(2023, 7, 19, 21, 53, 49, 438, DateTimeKind.Unspecified).AddTicks(1909), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Metal Mouse" },
                    { 488, new DateTimeOffset(new DateTime(2023, 10, 5, 19, 39, 25, 697, DateTimeKind.Unspecified).AddTicks(1335), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Steel Pizza" },
                    { 489, new DateTimeOffset(new DateTime(2023, 12, 22, 17, 25, 1, 956, DateTimeKind.Unspecified).AddTicks(761), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Plastic Towels" },
                    { 490, new DateTimeOffset(new DateTime(2023, 3, 10, 15, 10, 38, 215, DateTimeKind.Unspecified).AddTicks(187), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Rubber Ball" },
                    { 491, new DateTimeOffset(new DateTime(2023, 5, 27, 12, 56, 14, 473, DateTimeKind.Unspecified).AddTicks(9613), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Fresh Chips" },
                    { 492, new DateTimeOffset(new DateTime(2023, 8, 13, 10, 41, 50, 732, DateTimeKind.Unspecified).AddTicks(9039), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Wooden Chicken" },
                    { 493, new DateTimeOffset(new DateTime(2023, 10, 30, 8, 27, 26, 991, DateTimeKind.Unspecified).AddTicks(8465), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Granite Pants" },
                    { 494, new DateTimeOffset(new DateTime(2024, 1, 16, 6, 13, 3, 250, DateTimeKind.Unspecified).AddTicks(7891), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Soft Car" },
                    { 495, new DateTimeOffset(new DateTime(2023, 4, 4, 3, 58, 39, 509, DateTimeKind.Unspecified).AddTicks(7317), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Steel Cheese" },
                    { 496, new DateTimeOffset(new DateTime(2023, 6, 21, 1, 44, 15, 768, DateTimeKind.Unspecified).AddTicks(6743), new TimeSpan(0, 1, 0, 0, 0)), "Refined Plastic Shoes" },
                    { 497, new DateTimeOffset(new DateTime(2023, 9, 6, 23, 29, 52, 27, DateTimeKind.Unspecified).AddTicks(6169), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Metal Keyboard" },
                    { 498, new DateTimeOffset(new DateTime(2023, 11, 23, 21, 15, 28, 286, DateTimeKind.Unspecified).AddTicks(5595), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Frozen Pizza" },
                    { 499, new DateTimeOffset(new DateTime(2023, 2, 9, 19, 1, 4, 545, DateTimeKind.Unspecified).AddTicks(5021), new TimeSpan(0, 1, 0, 0, 0)), "Practical Concrete Towels" },
                    { 500, new DateTimeOffset(new DateTime(2023, 4, 28, 16, 46, 40, 804, DateTimeKind.Unspecified).AddTicks(4447), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Granite Ball" },
                    { 501, new DateTimeOffset(new DateTime(2023, 7, 15, 14, 32, 17, 63, DateTimeKind.Unspecified).AddTicks(3873), new TimeSpan(0, 1, 0, 0, 0)), "Practical Fresh Chips" },
                    { 502, new DateTimeOffset(new DateTime(2023, 10, 1, 12, 17, 53, 322, DateTimeKind.Unspecified).AddTicks(3299), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Wooden Tuna" },
                    { 503, new DateTimeOffset(new DateTime(2023, 12, 18, 10, 3, 29, 581, DateTimeKind.Unspecified).AddTicks(2725), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Cotton Pants" },
                    { 504, new DateTimeOffset(new DateTime(2023, 3, 6, 7, 49, 5, 840, DateTimeKind.Unspecified).AddTicks(2151), new TimeSpan(0, 1, 0, 0, 0)), "Small Metal Car" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreationDate", "Name" },
                values: new object[,]
                {
                    { 505, new DateTimeOffset(new DateTime(2023, 5, 23, 5, 34, 42, 99, DateTimeKind.Unspecified).AddTicks(1577), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Frozen Cheese" },
                    { 506, new DateTimeOffset(new DateTime(2023, 8, 9, 3, 20, 18, 358, DateTimeKind.Unspecified).AddTicks(1004), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Plastic Table" },
                    { 507, new DateTimeOffset(new DateTime(2023, 10, 26, 1, 5, 54, 617, DateTimeKind.Unspecified).AddTicks(430), new TimeSpan(0, 1, 0, 0, 0)), "Generic Rubber Keyboard" },
                    { 508, new DateTimeOffset(new DateTime(2024, 1, 11, 22, 51, 30, 875, DateTimeKind.Unspecified).AddTicks(9856), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Fresh Pizza" },
                    { 509, new DateTimeOffset(new DateTime(2023, 3, 30, 20, 37, 7, 134, DateTimeKind.Unspecified).AddTicks(9282), new TimeSpan(0, 1, 0, 0, 0)), "Generic Wooden Towels" },
                    { 510, new DateTimeOffset(new DateTime(2023, 6, 16, 18, 22, 43, 393, DateTimeKind.Unspecified).AddTicks(8708), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Granite Ball" },
                    { 511, new DateTimeOffset(new DateTime(2023, 9, 2, 16, 8, 19, 652, DateTimeKind.Unspecified).AddTicks(8134), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Soft Sausages" },
                    { 512, new DateTimeOffset(new DateTime(2023, 11, 19, 13, 53, 55, 911, DateTimeKind.Unspecified).AddTicks(7560), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Steel Tuna" },
                    { 513, new DateTimeOffset(new DateTime(2023, 2, 5, 11, 39, 32, 170, DateTimeKind.Unspecified).AddTicks(6986), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Plastic Pants" },
                    { 514, new DateTimeOffset(new DateTime(2023, 4, 24, 9, 25, 8, 429, DateTimeKind.Unspecified).AddTicks(6412), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Rubber Car" },
                    { 515, new DateTimeOffset(new DateTime(2023, 7, 11, 7, 10, 44, 688, DateTimeKind.Unspecified).AddTicks(5838), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Frozen Fish" },
                    { 516, new DateTimeOffset(new DateTime(2023, 9, 27, 4, 56, 20, 947, DateTimeKind.Unspecified).AddTicks(5264), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Concrete Table" },
                    { 517, new DateTimeOffset(new DateTime(2023, 12, 14, 2, 41, 57, 206, DateTimeKind.Unspecified).AddTicks(4690), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Granite Keyboard" },
                    { 518, new DateTimeOffset(new DateTime(2023, 3, 2, 0, 27, 33, 465, DateTimeKind.Unspecified).AddTicks(4116), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Soft Pizza" },
                    { 519, new DateTimeOffset(new DateTime(2023, 5, 18, 22, 13, 9, 724, DateTimeKind.Unspecified).AddTicks(3542), new TimeSpan(0, 1, 0, 0, 0)), "Refined Wooden Towels" },
                    { 520, new DateTimeOffset(new DateTime(2023, 8, 4, 19, 58, 45, 983, DateTimeKind.Unspecified).AddTicks(2968), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Cotton Bike" },
                    { 521, new DateTimeOffset(new DateTime(2023, 10, 21, 17, 44, 22, 242, DateTimeKind.Unspecified).AddTicks(2394), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Metal Sausages" },
                    { 522, new DateTimeOffset(new DateTime(2024, 1, 7, 15, 29, 58, 501, DateTimeKind.Unspecified).AddTicks(1820), new TimeSpan(0, 1, 0, 0, 0)), "Practical Frozen Tuna" },
                    { 523, new DateTimeOffset(new DateTime(2023, 3, 26, 13, 15, 34, 760, DateTimeKind.Unspecified).AddTicks(1246), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Plastic Pants" },
                    { 524, new DateTimeOffset(new DateTime(2023, 6, 12, 11, 1, 11, 19, DateTimeKind.Unspecified).AddTicks(672), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Rubber Chair" },
                    { 525, new DateTimeOffset(new DateTime(2023, 8, 29, 8, 46, 47, 278, DateTimeKind.Unspecified).AddTicks(98), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Fresh Fish" },
                    { 526, new DateTimeOffset(new DateTime(2023, 11, 15, 6, 32, 23, 536, DateTimeKind.Unspecified).AddTicks(9524), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Wooden Table" },
                    { 527, new DateTimeOffset(new DateTime(2023, 2, 1, 4, 17, 59, 795, DateTimeKind.Unspecified).AddTicks(8950), new TimeSpan(0, 1, 0, 0, 0)), "Small Cotton Keyboard" },
                    { 528, new DateTimeOffset(new DateTime(2023, 4, 20, 2, 3, 36, 54, DateTimeKind.Unspecified).AddTicks(8376), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Soft Pizza" },
                    { 529, new DateTimeOffset(new DateTime(2023, 7, 6, 23, 49, 12, 313, DateTimeKind.Unspecified).AddTicks(7802), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Steel Hat" },
                    { 530, new DateTimeOffset(new DateTime(2023, 9, 22, 21, 34, 48, 572, DateTimeKind.Unspecified).AddTicks(7229), new TimeSpan(0, 1, 0, 0, 0)), "Generic Plastic Bike" },
                    { 531, new DateTimeOffset(new DateTime(2023, 12, 9, 19, 20, 24, 831, DateTimeKind.Unspecified).AddTicks(6655), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Rubber Sausages" },
                    { 532, new DateTimeOffset(new DateTime(2023, 2, 25, 17, 6, 1, 90, DateTimeKind.Unspecified).AddTicks(6081), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Frozen Tuna" },
                    { 533, new DateTimeOffset(new DateTime(2023, 5, 14, 14, 51, 37, 349, DateTimeKind.Unspecified).AddTicks(5507), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Concrete Gloves" },
                    { 534, new DateTimeOffset(new DateTime(2023, 7, 31, 12, 37, 13, 608, DateTimeKind.Unspecified).AddTicks(4933), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Granite Chair" },
                    { 535, new DateTimeOffset(new DateTime(2023, 10, 17, 10, 22, 49, 867, DateTimeKind.Unspecified).AddTicks(4359), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Soft Fish" },
                    { 536, new DateTimeOffset(new DateTime(2024, 1, 3, 8, 8, 26, 126, DateTimeKind.Unspecified).AddTicks(3785), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Steel Table" },
                    { 537, new DateTimeOffset(new DateTime(2023, 3, 22, 5, 54, 2, 385, DateTimeKind.Unspecified).AddTicks(3211), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Cotton Computer" },
                    { 538, new DateTimeOffset(new DateTime(2023, 6, 8, 3, 39, 38, 644, DateTimeKind.Unspecified).AddTicks(2637), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Metal Bacon" },
                    { 539, new DateTimeOffset(new DateTime(2023, 8, 25, 1, 25, 14, 903, DateTimeKind.Unspecified).AddTicks(2063), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Frozen Hat" },
                    { 540, new DateTimeOffset(new DateTime(2023, 11, 10, 23, 10, 51, 162, DateTimeKind.Unspecified).AddTicks(1489), new TimeSpan(0, 1, 0, 0, 0)), "Refined Concrete Bike" },
                    { 541, new DateTimeOffset(new DateTime(2023, 1, 27, 20, 56, 27, 421, DateTimeKind.Unspecified).AddTicks(915), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Rubber Sausages" },
                    { 542, new DateTimeOffset(new DateTime(2023, 4, 15, 18, 42, 3, 680, DateTimeKind.Unspecified).AddTicks(341), new TimeSpan(0, 1, 0, 0, 0)), "Refined Fresh Soap" },
                    { 543, new DateTimeOffset(new DateTime(2023, 7, 2, 16, 27, 39, 938, DateTimeKind.Unspecified).AddTicks(9767), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Wooden Gloves" },
                    { 544, new DateTimeOffset(new DateTime(2023, 9, 18, 14, 13, 16, 197, DateTimeKind.Unspecified).AddTicks(9193), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Cotton Chair" },
                    { 545, new DateTimeOffset(new DateTime(2023, 12, 5, 11, 58, 52, 456, DateTimeKind.Unspecified).AddTicks(8619), new TimeSpan(0, 1, 0, 0, 0)), "Practical Soft Fish" },
                    { 546, new DateTimeOffset(new DateTime(2023, 2, 21, 9, 44, 28, 715, DateTimeKind.Unspecified).AddTicks(8045), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Steel Shirt" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreationDate", "Name" },
                values: new object[,]
                {
                    { 547, new DateTimeOffset(new DateTime(2023, 5, 10, 7, 30, 4, 974, DateTimeKind.Unspecified).AddTicks(7471), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Plastic Computer" },
                    { 548, new DateTimeOffset(new DateTime(2023, 7, 27, 5, 15, 41, 233, DateTimeKind.Unspecified).AddTicks(6897), new TimeSpan(0, 1, 0, 0, 0)), "Small Rubber Bacon" },
                    { 549, new DateTimeOffset(new DateTime(2023, 10, 13, 3, 1, 17, 492, DateTimeKind.Unspecified).AddTicks(6323), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Fresh Hat" },
                    { 550, new DateTimeOffset(new DateTime(2023, 12, 30, 0, 46, 53, 751, DateTimeKind.Unspecified).AddTicks(5749), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Concrete Bike" },
                    { 551, new DateTimeOffset(new DateTime(2023, 3, 17, 22, 32, 30, 10, DateTimeKind.Unspecified).AddTicks(5175), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Granite Salad" },
                    { 552, new DateTimeOffset(new DateTime(2023, 6, 3, 20, 18, 6, 269, DateTimeKind.Unspecified).AddTicks(4601), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Soft Soap" },
                    { 553, new DateTimeOffset(new DateTime(2023, 8, 20, 18, 3, 42, 528, DateTimeKind.Unspecified).AddTicks(4028), new TimeSpan(0, 1, 0, 0, 0)), "Generic Steel Gloves" },
                    { 554, new DateTimeOffset(new DateTime(2023, 11, 6, 15, 49, 18, 787, DateTimeKind.Unspecified).AddTicks(3454), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Cotton Chair" },
                    { 555, new DateTimeOffset(new DateTime(2023, 1, 23, 13, 34, 55, 46, DateTimeKind.Unspecified).AddTicks(2880), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Metal Chicken" },
                    { 556, new DateTimeOffset(new DateTime(2023, 4, 11, 11, 20, 31, 305, DateTimeKind.Unspecified).AddTicks(2306), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Frozen Shirt" },
                    { 557, new DateTimeOffset(new DateTime(2023, 6, 28, 9, 6, 7, 564, DateTimeKind.Unspecified).AddTicks(1732), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Concrete Computer" },
                    { 558, new DateTimeOffset(new DateTime(2023, 9, 14, 6, 51, 43, 823, DateTimeKind.Unspecified).AddTicks(1158), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Granite Bacon" },
                    { 559, new DateTimeOffset(new DateTime(2023, 12, 1, 4, 37, 20, 82, DateTimeKind.Unspecified).AddTicks(584), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Fresh Hat" },
                    { 560, new DateTimeOffset(new DateTime(2023, 2, 17, 2, 22, 56, 341, DateTimeKind.Unspecified).AddTicks(10), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Wooden Mouse" },
                    { 561, new DateTimeOffset(new DateTime(2023, 5, 6, 0, 8, 32, 599, DateTimeKind.Unspecified).AddTicks(9436), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Cotton Salad" },
                    { 562, new DateTimeOffset(new DateTime(2023, 7, 22, 21, 54, 8, 858, DateTimeKind.Unspecified).AddTicks(8862), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Metal Soap" },
                    { 563, new DateTimeOffset(new DateTime(2023, 10, 8, 19, 39, 45, 117, DateTimeKind.Unspecified).AddTicks(8288), new TimeSpan(0, 1, 0, 0, 0)), "Refined Steel Gloves" },
                    { 564, new DateTimeOffset(new DateTime(2023, 12, 25, 17, 25, 21, 376, DateTimeKind.Unspecified).AddTicks(7714), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Plastic Chips" },
                    { 565, new DateTimeOffset(new DateTime(2023, 3, 13, 15, 10, 57, 635, DateTimeKind.Unspecified).AddTicks(7140), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Rubber Chicken" },
                    { 566, new DateTimeOffset(new DateTime(2023, 5, 30, 12, 56, 33, 894, DateTimeKind.Unspecified).AddTicks(6566), new TimeSpan(0, 1, 0, 0, 0)), "Practical Fresh Shirt" },
                    { 567, new DateTimeOffset(new DateTime(2023, 8, 16, 10, 42, 10, 153, DateTimeKind.Unspecified).AddTicks(5992), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Concrete Computer" },
                    { 568, new DateTimeOffset(new DateTime(2023, 11, 2, 8, 27, 46, 412, DateTimeKind.Unspecified).AddTicks(5418), new TimeSpan(0, 1, 0, 0, 0)), "Practical Granite Bacon" },
                    { 569, new DateTimeOffset(new DateTime(2023, 1, 19, 6, 13, 22, 671, DateTimeKind.Unspecified).AddTicks(4844), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Soft Shoes" },
                    { 570, new DateTimeOffset(new DateTime(2023, 4, 7, 3, 58, 58, 930, DateTimeKind.Unspecified).AddTicks(4270), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Steel Mouse" },
                    { 571, new DateTimeOffset(new DateTime(2023, 6, 24, 1, 44, 35, 189, DateTimeKind.Unspecified).AddTicks(3696), new TimeSpan(0, 1, 0, 0, 0)), "Small Plastic Salad" },
                    { 572, new DateTimeOffset(new DateTime(2023, 9, 9, 23, 30, 11, 448, DateTimeKind.Unspecified).AddTicks(3122), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Metal Soap" },
                    { 573, new DateTimeOffset(new DateTime(2023, 11, 26, 21, 15, 47, 707, DateTimeKind.Unspecified).AddTicks(2548), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Frozen Ball" },
                    { 574, new DateTimeOffset(new DateTime(2023, 2, 12, 19, 1, 23, 966, DateTimeKind.Unspecified).AddTicks(1974), new TimeSpan(0, 1, 0, 0, 0)), "Generic Concrete Chips" },
                    { 575, new DateTimeOffset(new DateTime(2023, 5, 1, 16, 47, 0, 225, DateTimeKind.Unspecified).AddTicks(1400), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Granite Chicken" },
                    { 576, new DateTimeOffset(new DateTime(2023, 7, 18, 14, 32, 36, 484, DateTimeKind.Unspecified).AddTicks(826), new TimeSpan(0, 1, 0, 0, 0)), "Generic Fresh Shirt" },
                    { 577, new DateTimeOffset(new DateTime(2023, 10, 4, 12, 18, 12, 743, DateTimeKind.Unspecified).AddTicks(252), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Wooden Computer" },
                    { 578, new DateTimeOffset(new DateTime(2023, 12, 21, 10, 3, 49, 1, DateTimeKind.Unspecified).AddTicks(9679), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Cotton Cheese" },
                    { 579, new DateTimeOffset(new DateTime(2023, 3, 9, 7, 49, 25, 260, DateTimeKind.Unspecified).AddTicks(9105), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Metal Shoes" },
                    { 580, new DateTimeOffset(new DateTime(2023, 5, 26, 5, 35, 1, 519, DateTimeKind.Unspecified).AddTicks(8531), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Steel Mouse" },
                    { 581, new DateTimeOffset(new DateTime(2023, 8, 12, 3, 20, 37, 778, DateTimeKind.Unspecified).AddTicks(7957), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Plastic Salad" },
                    { 582, new DateTimeOffset(new DateTime(2023, 10, 29, 1, 6, 14, 37, DateTimeKind.Unspecified).AddTicks(7383), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Rubber Towels" },
                    { 583, new DateTimeOffset(new DateTime(2024, 1, 14, 22, 51, 50, 296, DateTimeKind.Unspecified).AddTicks(6809), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Fresh Ball" },
                    { 584, new DateTimeOffset(new DateTime(2023, 4, 2, 20, 37, 26, 555, DateTimeKind.Unspecified).AddTicks(6235), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Wooden Chips" },
                    { 585, new DateTimeOffset(new DateTime(2023, 6, 19, 18, 23, 2, 814, DateTimeKind.Unspecified).AddTicks(5661), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Granite Chicken" },
                    { 586, new DateTimeOffset(new DateTime(2023, 9, 5, 16, 8, 39, 73, DateTimeKind.Unspecified).AddTicks(5087), new TimeSpan(0, 1, 0, 0, 0)), "Refined Soft Pants" },
                    { 587, new DateTimeOffset(new DateTime(2023, 11, 22, 13, 54, 15, 332, DateTimeKind.Unspecified).AddTicks(4513), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Steel Car" },
                    { 588, new DateTimeOffset(new DateTime(2023, 2, 8, 11, 39, 51, 591, DateTimeKind.Unspecified).AddTicks(3939), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Plastic Cheese" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreationDate", "Name" },
                values: new object[,]
                {
                    { 589, new DateTimeOffset(new DateTime(2023, 4, 27, 9, 25, 27, 850, DateTimeKind.Unspecified).AddTicks(3365), new TimeSpan(0, 1, 0, 0, 0)), "Practical Metal Shoes" },
                    { 590, new DateTimeOffset(new DateTime(2023, 7, 14, 7, 11, 4, 109, DateTimeKind.Unspecified).AddTicks(2791), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Frozen Mouse" },
                    { 591, new DateTimeOffset(new DateTime(2023, 9, 30, 4, 56, 40, 368, DateTimeKind.Unspecified).AddTicks(2217), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Concrete Pizza" },
                    { 592, new DateTimeOffset(new DateTime(2023, 12, 17, 2, 42, 16, 627, DateTimeKind.Unspecified).AddTicks(1643), new TimeSpan(0, 1, 0, 0, 0)), "Small Granite Towels" },
                    { 593, new DateTimeOffset(new DateTime(2023, 3, 5, 0, 27, 52, 886, DateTimeKind.Unspecified).AddTicks(1069), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Soft Ball" },
                    { 594, new DateTimeOffset(new DateTime(2023, 5, 21, 22, 13, 29, 145, DateTimeKind.Unspecified).AddTicks(495), new TimeSpan(0, 1, 0, 0, 0)), "Small Wooden Chips" },
                    { 595, new DateTimeOffset(new DateTime(2023, 8, 7, 19, 59, 5, 403, DateTimeKind.Unspecified).AddTicks(9921), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Cotton Tuna" },
                    { 596, new DateTimeOffset(new DateTime(2023, 10, 24, 17, 44, 41, 662, DateTimeKind.Unspecified).AddTicks(9347), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Metal Pants" },
                    { 597, new DateTimeOffset(new DateTime(2024, 1, 10, 15, 30, 17, 921, DateTimeKind.Unspecified).AddTicks(8773), new TimeSpan(0, 1, 0, 0, 0)), "Generic Frozen Car" },
                    { 598, new DateTimeOffset(new DateTime(2023, 3, 29, 13, 15, 54, 180, DateTimeKind.Unspecified).AddTicks(8199), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Plastic Cheese" },
                    { 599, new DateTimeOffset(new DateTime(2023, 6, 15, 11, 1, 30, 439, DateTimeKind.Unspecified).AddTicks(7625), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Rubber Shoes" },
                    { 600, new DateTimeOffset(new DateTime(2023, 9, 1, 8, 47, 6, 698, DateTimeKind.Unspecified).AddTicks(7051), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Fresh Keyboard" },
                    { 601, new DateTimeOffset(new DateTime(2023, 11, 18, 6, 32, 42, 957, DateTimeKind.Unspecified).AddTicks(6478), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Wooden Pizza" },
                    { 602, new DateTimeOffset(new DateTime(2023, 2, 4, 4, 18, 19, 216, DateTimeKind.Unspecified).AddTicks(5904), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Granite Towels" },
                    { 603, new DateTimeOffset(new DateTime(2023, 4, 23, 2, 3, 55, 475, DateTimeKind.Unspecified).AddTicks(5330), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Soft Ball" },
                    { 604, new DateTimeOffset(new DateTime(2023, 7, 9, 23, 49, 31, 734, DateTimeKind.Unspecified).AddTicks(4756), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Steel Sausages" },
                    { 605, new DateTimeOffset(new DateTime(2023, 9, 25, 21, 35, 7, 993, DateTimeKind.Unspecified).AddTicks(4182), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Plastic Tuna" },
                    { 606, new DateTimeOffset(new DateTime(2023, 12, 12, 19, 20, 44, 252, DateTimeKind.Unspecified).AddTicks(3608), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Rubber Pants" },
                    { 607, new DateTimeOffset(new DateTime(2023, 2, 28, 17, 6, 20, 511, DateTimeKind.Unspecified).AddTicks(3034), new TimeSpan(0, 1, 0, 0, 0)), "Refined Frozen Car" },
                    { 608, new DateTimeOffset(new DateTime(2023, 5, 17, 14, 51, 56, 770, DateTimeKind.Unspecified).AddTicks(2460), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Concrete Cheese" },
                    { 609, new DateTimeOffset(new DateTime(2023, 8, 3, 12, 37, 33, 29, DateTimeKind.Unspecified).AddTicks(1886), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Granite Table" },
                    { 610, new DateTimeOffset(new DateTime(2023, 10, 20, 10, 23, 9, 288, DateTimeKind.Unspecified).AddTicks(1312), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Soft Keyboard" },
                    { 611, new DateTimeOffset(new DateTime(2024, 1, 6, 8, 8, 45, 547, DateTimeKind.Unspecified).AddTicks(738), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Wooden Pizza" },
                    { 612, new DateTimeOffset(new DateTime(2023, 3, 25, 5, 54, 21, 806, DateTimeKind.Unspecified).AddTicks(164), new TimeSpan(0, 1, 0, 0, 0)), "Practical Cotton Towels" },
                    { 613, new DateTimeOffset(new DateTime(2023, 6, 11, 3, 39, 58, 64, DateTimeKind.Unspecified).AddTicks(9590), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Metal Bike" },
                    { 614, new DateTimeOffset(new DateTime(2023, 8, 28, 1, 25, 34, 323, DateTimeKind.Unspecified).AddTicks(9016), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Frozen Sausages" },
                    { 615, new DateTimeOffset(new DateTime(2023, 11, 13, 23, 11, 10, 582, DateTimeKind.Unspecified).AddTicks(8442), new TimeSpan(0, 1, 0, 0, 0)), "Small Concrete Tuna" },
                    { 616, new DateTimeOffset(new DateTime(2023, 1, 30, 20, 56, 46, 841, DateTimeKind.Unspecified).AddTicks(7868), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Rubber Pants" },
                    { 617, new DateTimeOffset(new DateTime(2023, 4, 18, 18, 42, 23, 100, DateTimeKind.Unspecified).AddTicks(7294), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Fresh Car" },
                    { 618, new DateTimeOffset(new DateTime(2023, 7, 5, 16, 27, 59, 359, DateTimeKind.Unspecified).AddTicks(6720), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Wooden Fish" },
                    { 619, new DateTimeOffset(new DateTime(2023, 9, 21, 14, 13, 35, 618, DateTimeKind.Unspecified).AddTicks(6146), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Cotton Table" },
                    { 620, new DateTimeOffset(new DateTime(2023, 12, 8, 11, 59, 11, 877, DateTimeKind.Unspecified).AddTicks(5572), new TimeSpan(0, 1, 0, 0, 0)), "Generic Soft Keyboard" },
                    { 621, new DateTimeOffset(new DateTime(2023, 2, 24, 9, 44, 48, 136, DateTimeKind.Unspecified).AddTicks(4998), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Steel Pizza" },
                    { 622, new DateTimeOffset(new DateTime(2023, 5, 13, 7, 30, 24, 395, DateTimeKind.Unspecified).AddTicks(4424), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Plastic Hat" },
                    { 623, new DateTimeOffset(new DateTime(2023, 7, 30, 5, 16, 0, 654, DateTimeKind.Unspecified).AddTicks(3850), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Rubber Bike" },
                    { 624, new DateTimeOffset(new DateTime(2023, 10, 16, 3, 1, 36, 913, DateTimeKind.Unspecified).AddTicks(3276), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Frozen Sausages" },
                    { 625, new DateTimeOffset(new DateTime(2024, 1, 2, 0, 47, 13, 172, DateTimeKind.Unspecified).AddTicks(2703), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Concrete Tuna" },
                    { 626, new DateTimeOffset(new DateTime(2023, 3, 20, 22, 32, 49, 431, DateTimeKind.Unspecified).AddTicks(2129), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Granite Pants" },
                    { 627, new DateTimeOffset(new DateTime(2023, 6, 6, 20, 18, 25, 690, DateTimeKind.Unspecified).AddTicks(1555), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Soft Chair" },
                    { 628, new DateTimeOffset(new DateTime(2023, 8, 23, 18, 4, 1, 949, DateTimeKind.Unspecified).AddTicks(981), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Steel Fish" },
                    { 629, new DateTimeOffset(new DateTime(2023, 11, 9, 15, 49, 38, 208, DateTimeKind.Unspecified).AddTicks(407), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Cotton Table" },
                    { 630, new DateTimeOffset(new DateTime(2023, 1, 26, 13, 35, 14, 466, DateTimeKind.Unspecified).AddTicks(9833), new TimeSpan(0, 1, 0, 0, 0)), "Refined Metal Keyboard" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreationDate", "Name" },
                values: new object[,]
                {
                    { 631, new DateTimeOffset(new DateTime(2023, 4, 14, 11, 20, 50, 725, DateTimeKind.Unspecified).AddTicks(9259), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Frozen Bacon" },
                    { 632, new DateTimeOffset(new DateTime(2023, 7, 1, 9, 6, 26, 984, DateTimeKind.Unspecified).AddTicks(8685), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Concrete Hat" },
                    { 633, new DateTimeOffset(new DateTime(2023, 9, 17, 6, 52, 3, 243, DateTimeKind.Unspecified).AddTicks(8111), new TimeSpan(0, 1, 0, 0, 0)), "Practical Rubber Bike" },
                    { 634, new DateTimeOffset(new DateTime(2023, 12, 4, 4, 37, 39, 502, DateTimeKind.Unspecified).AddTicks(7537), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Fresh Sausages" },
                    { 635, new DateTimeOffset(new DateTime(2023, 2, 20, 2, 23, 15, 761, DateTimeKind.Unspecified).AddTicks(6963), new TimeSpan(0, 1, 0, 0, 0)), "Practical Wooden Tuna" },
                    { 636, new DateTimeOffset(new DateTime(2023, 5, 9, 0, 8, 52, 20, DateTimeKind.Unspecified).AddTicks(6389), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Cotton Gloves" },
                    { 637, new DateTimeOffset(new DateTime(2023, 7, 25, 21, 54, 28, 279, DateTimeKind.Unspecified).AddTicks(5815), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Metal Chair" },
                    { 638, new DateTimeOffset(new DateTime(2023, 10, 11, 19, 40, 4, 538, DateTimeKind.Unspecified).AddTicks(5241), new TimeSpan(0, 1, 0, 0, 0)), "Small Steel Fish" },
                    { 639, new DateTimeOffset(new DateTime(2023, 12, 28, 17, 25, 40, 797, DateTimeKind.Unspecified).AddTicks(4667), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Plastic Table" },
                    { 640, new DateTimeOffset(new DateTime(2023, 3, 16, 15, 11, 17, 56, DateTimeKind.Unspecified).AddTicks(4093), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Rubber Computer" },
                    { 641, new DateTimeOffset(new DateTime(2023, 6, 2, 12, 56, 53, 315, DateTimeKind.Unspecified).AddTicks(3519), new TimeSpan(0, 1, 0, 0, 0)), "Generic Fresh Bacon" },
                    { 642, new DateTimeOffset(new DateTime(2023, 8, 19, 10, 42, 29, 574, DateTimeKind.Unspecified).AddTicks(2945), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Concrete Hat" },
                    { 643, new DateTimeOffset(new DateTime(2023, 11, 5, 8, 28, 5, 833, DateTimeKind.Unspecified).AddTicks(2371), new TimeSpan(0, 1, 0, 0, 0)), "Generic Granite Bike" },
                    { 644, new DateTimeOffset(new DateTime(2023, 1, 22, 6, 13, 42, 92, DateTimeKind.Unspecified).AddTicks(1797), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Soft Salad" },
                    { 645, new DateTimeOffset(new DateTime(2023, 4, 10, 3, 59, 18, 351, DateTimeKind.Unspecified).AddTicks(1223), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Steel Soap" },
                    { 646, new DateTimeOffset(new DateTime(2023, 6, 27, 1, 44, 54, 610, DateTimeKind.Unspecified).AddTicks(649), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Cotton Gloves" },
                    { 647, new DateTimeOffset(new DateTime(2023, 9, 12, 23, 30, 30, 869, DateTimeKind.Unspecified).AddTicks(75), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Metal Chair" },
                    { 648, new DateTimeOffset(new DateTime(2023, 11, 29, 21, 16, 7, 127, DateTimeKind.Unspecified).AddTicks(9501), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Frozen Fish" },
                    { 649, new DateTimeOffset(new DateTime(2023, 2, 15, 19, 1, 43, 386, DateTimeKind.Unspecified).AddTicks(8928), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Concrete Shirt" },
                    { 650, new DateTimeOffset(new DateTime(2023, 5, 4, 16, 47, 19, 645, DateTimeKind.Unspecified).AddTicks(8354), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Granite Computer" },
                    { 651, new DateTimeOffset(new DateTime(2023, 7, 21, 14, 32, 55, 904, DateTimeKind.Unspecified).AddTicks(7780), new TimeSpan(0, 1, 0, 0, 0)), "Refined Fresh Bacon" },
                    { 652, new DateTimeOffset(new DateTime(2023, 10, 7, 12, 18, 32, 163, DateTimeKind.Unspecified).AddTicks(7206), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Wooden Hat" },
                    { 653, new DateTimeOffset(new DateTime(2023, 12, 24, 10, 4, 8, 422, DateTimeKind.Unspecified).AddTicks(6632), new TimeSpan(0, 1, 0, 0, 0)), "Refined Cotton Mouse" },
                    { 654, new DateTimeOffset(new DateTime(2023, 3, 12, 7, 49, 44, 681, DateTimeKind.Unspecified).AddTicks(6058), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Metal Salad" },
                    { 655, new DateTimeOffset(new DateTime(2023, 5, 29, 5, 35, 20, 940, DateTimeKind.Unspecified).AddTicks(5484), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Steel Soap" },
                    { 656, new DateTimeOffset(new DateTime(2023, 8, 15, 3, 20, 57, 199, DateTimeKind.Unspecified).AddTicks(4910), new TimeSpan(0, 1, 0, 0, 0)), "Practical Plastic Gloves" },
                    { 657, new DateTimeOffset(new DateTime(2023, 11, 1, 1, 6, 33, 458, DateTimeKind.Unspecified).AddTicks(4336), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Rubber Chair" },
                    { 658, new DateTimeOffset(new DateTime(2023, 1, 17, 22, 52, 9, 717, DateTimeKind.Unspecified).AddTicks(3762), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Fresh Chicken" },
                    { 659, new DateTimeOffset(new DateTime(2023, 4, 5, 20, 37, 45, 976, DateTimeKind.Unspecified).AddTicks(3188), new TimeSpan(0, 1, 0, 0, 0)), "Small Wooden Shirt" },
                    { 660, new DateTimeOffset(new DateTime(2023, 6, 22, 18, 23, 22, 235, DateTimeKind.Unspecified).AddTicks(2614), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Granite Computer" },
                    { 661, new DateTimeOffset(new DateTime(2023, 9, 8, 16, 8, 58, 494, DateTimeKind.Unspecified).AddTicks(2040), new TimeSpan(0, 1, 0, 0, 0)), "Small Soft Bacon" },
                    { 662, new DateTimeOffset(new DateTime(2023, 11, 25, 13, 54, 34, 753, DateTimeKind.Unspecified).AddTicks(1466), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Steel Shoes" },
                    { 663, new DateTimeOffset(new DateTime(2023, 2, 11, 11, 40, 11, 12, DateTimeKind.Unspecified).AddTicks(892), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Plastic Mouse" },
                    { 664, new DateTimeOffset(new DateTime(2023, 4, 30, 9, 25, 47, 271, DateTimeKind.Unspecified).AddTicks(318), new TimeSpan(0, 1, 0, 0, 0)), "Generic Metal Salad" },
                    { 665, new DateTimeOffset(new DateTime(2023, 7, 17, 7, 11, 23, 529, DateTimeKind.Unspecified).AddTicks(9744), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Frozen Soap" },
                    { 666, new DateTimeOffset(new DateTime(2023, 10, 3, 4, 56, 59, 788, DateTimeKind.Unspecified).AddTicks(9170), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Concrete Gloves" },
                    { 667, new DateTimeOffset(new DateTime(2023, 12, 20, 2, 42, 36, 47, DateTimeKind.Unspecified).AddTicks(8596), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Granite Chips" },
                    { 668, new DateTimeOffset(new DateTime(2023, 3, 8, 0, 28, 12, 306, DateTimeKind.Unspecified).AddTicks(8022), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Fresh Chicken" },
                    { 669, new DateTimeOffset(new DateTime(2023, 5, 24, 22, 13, 48, 565, DateTimeKind.Unspecified).AddTicks(7448), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Wooden Shirt" },
                    { 670, new DateTimeOffset(new DateTime(2023, 8, 10, 19, 59, 24, 824, DateTimeKind.Unspecified).AddTicks(6874), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Cotton Computer" },
                    { 671, new DateTimeOffset(new DateTime(2023, 10, 27, 17, 45, 1, 83, DateTimeKind.Unspecified).AddTicks(6300), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Metal Cheese" },
                    { 672, new DateTimeOffset(new DateTime(2024, 1, 13, 15, 30, 37, 342, DateTimeKind.Unspecified).AddTicks(5726), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Frozen Shoes" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreationDate", "Name" },
                values: new object[,]
                {
                    { 673, new DateTimeOffset(new DateTime(2023, 4, 1, 13, 16, 13, 601, DateTimeKind.Unspecified).AddTicks(5153), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Plastic Mouse" },
                    { 674, new DateTimeOffset(new DateTime(2023, 6, 18, 11, 1, 49, 860, DateTimeKind.Unspecified).AddTicks(4579), new TimeSpan(0, 1, 0, 0, 0)), "Refined Rubber Salad" },
                    { 675, new DateTimeOffset(new DateTime(2023, 9, 4, 8, 47, 26, 119, DateTimeKind.Unspecified).AddTicks(4005), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Fresh Soap" },
                    { 676, new DateTimeOffset(new DateTime(2023, 11, 21, 6, 33, 2, 378, DateTimeKind.Unspecified).AddTicks(3431), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Wooden Ball" },
                    { 677, new DateTimeOffset(new DateTime(2023, 2, 7, 4, 18, 38, 637, DateTimeKind.Unspecified).AddTicks(2857), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Granite Chips" },
                    { 678, new DateTimeOffset(new DateTime(2023, 4, 26, 2, 4, 14, 896, DateTimeKind.Unspecified).AddTicks(2283), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Soft Chicken" },
                    { 679, new DateTimeOffset(new DateTime(2023, 7, 12, 23, 49, 51, 155, DateTimeKind.Unspecified).AddTicks(1709), new TimeSpan(0, 1, 0, 0, 0)), "Practical Steel Shirt" },
                    { 680, new DateTimeOffset(new DateTime(2023, 9, 28, 21, 35, 27, 414, DateTimeKind.Unspecified).AddTicks(1135), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Plastic Car" },
                    { 681, new DateTimeOffset(new DateTime(2023, 12, 15, 19, 21, 3, 673, DateTimeKind.Unspecified).AddTicks(561), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Rubber Cheese" },
                    { 682, new DateTimeOffset(new DateTime(2023, 3, 3, 17, 6, 39, 931, DateTimeKind.Unspecified).AddTicks(9987), new TimeSpan(0, 1, 0, 0, 0)), "Small Frozen Shoes" },
                    { 683, new DateTimeOffset(new DateTime(2023, 5, 20, 14, 52, 16, 190, DateTimeKind.Unspecified).AddTicks(9413), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Concrete Mouse" },
                    { 684, new DateTimeOffset(new DateTime(2023, 8, 6, 12, 37, 52, 449, DateTimeKind.Unspecified).AddTicks(8839), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Granite Salad" },
                    { 685, new DateTimeOffset(new DateTime(2023, 10, 23, 10, 23, 28, 708, DateTimeKind.Unspecified).AddTicks(8265), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Soft Towels" },
                    { 686, new DateTimeOffset(new DateTime(2024, 1, 9, 8, 9, 4, 967, DateTimeKind.Unspecified).AddTicks(7691), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Wooden Ball" },
                    { 687, new DateTimeOffset(new DateTime(2023, 3, 28, 5, 54, 41, 226, DateTimeKind.Unspecified).AddTicks(7117), new TimeSpan(0, 1, 0, 0, 0)), "Generic Cotton Chips" },
                    { 688, new DateTimeOffset(new DateTime(2023, 6, 14, 3, 40, 17, 485, DateTimeKind.Unspecified).AddTicks(6543), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Metal Chicken" },
                    { 689, new DateTimeOffset(new DateTime(2023, 8, 31, 1, 25, 53, 744, DateTimeKind.Unspecified).AddTicks(5969), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Frozen Pants" },
                    { 690, new DateTimeOffset(new DateTime(2023, 11, 16, 23, 11, 30, 3, DateTimeKind.Unspecified).AddTicks(5395), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Plastic Car" },
                    { 691, new DateTimeOffset(new DateTime(2023, 2, 2, 20, 57, 6, 262, DateTimeKind.Unspecified).AddTicks(4821), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Rubber Cheese" },
                    { 692, new DateTimeOffset(new DateTime(2023, 4, 21, 18, 42, 42, 521, DateTimeKind.Unspecified).AddTicks(4247), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Fresh Shoes" },
                    { 693, new DateTimeOffset(new DateTime(2023, 7, 8, 16, 28, 18, 780, DateTimeKind.Unspecified).AddTicks(3673), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Wooden Mouse" },
                    { 694, new DateTimeOffset(new DateTime(2023, 9, 24, 14, 13, 55, 39, DateTimeKind.Unspecified).AddTicks(3099), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Cotton Pizza" },
                    { 695, new DateTimeOffset(new DateTime(2023, 12, 11, 11, 59, 31, 298, DateTimeKind.Unspecified).AddTicks(2525), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Soft Towels" },
                    { 696, new DateTimeOffset(new DateTime(2023, 2, 27, 9, 45, 7, 557, DateTimeKind.Unspecified).AddTicks(1951), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Steel Ball" },
                    { 697, new DateTimeOffset(new DateTime(2023, 5, 16, 7, 30, 43, 816, DateTimeKind.Unspecified).AddTicks(1378), new TimeSpan(0, 1, 0, 0, 0)), "Refined Plastic Chips" },
                    { 698, new DateTimeOffset(new DateTime(2023, 8, 2, 5, 16, 20, 75, DateTimeKind.Unspecified).AddTicks(804), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Rubber Tuna" },
                    { 699, new DateTimeOffset(new DateTime(2023, 10, 19, 3, 1, 56, 334, DateTimeKind.Unspecified).AddTicks(230), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Frozen Pants" },
                    { 700, new DateTimeOffset(new DateTime(2024, 1, 5, 0, 47, 32, 592, DateTimeKind.Unspecified).AddTicks(9656), new TimeSpan(0, 1, 0, 0, 0)), "Practical Concrete Car" },
                    { 701, new DateTimeOffset(new DateTime(2023, 3, 23, 22, 33, 8, 851, DateTimeKind.Unspecified).AddTicks(9082), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Granite Cheese" },
                    { 702, new DateTimeOffset(new DateTime(2023, 6, 9, 20, 18, 45, 110, DateTimeKind.Unspecified).AddTicks(8508), new TimeSpan(0, 1, 0, 0, 0)), "Practical Soft Table" },
                    { 703, new DateTimeOffset(new DateTime(2023, 8, 26, 18, 4, 21, 369, DateTimeKind.Unspecified).AddTicks(7934), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Steel Keyboard" },
                    { 704, new DateTimeOffset(new DateTime(2023, 11, 12, 15, 49, 57, 628, DateTimeKind.Unspecified).AddTicks(7360), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Cotton Pizza" },
                    { 705, new DateTimeOffset(new DateTime(2023, 1, 29, 13, 35, 33, 887, DateTimeKind.Unspecified).AddTicks(6786), new TimeSpan(0, 1, 0, 0, 0)), "Small Metal Towels" },
                    { 706, new DateTimeOffset(new DateTime(2023, 4, 17, 11, 21, 10, 146, DateTimeKind.Unspecified).AddTicks(6212), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Frozen Ball" },
                    { 707, new DateTimeOffset(new DateTime(2023, 7, 4, 9, 6, 46, 405, DateTimeKind.Unspecified).AddTicks(5638), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Concrete Sausages" },
                    { 708, new DateTimeOffset(new DateTime(2023, 9, 20, 6, 52, 22, 664, DateTimeKind.Unspecified).AddTicks(5064), new TimeSpan(0, 1, 0, 0, 0)), "Generic Rubber Tuna" },
                    { 709, new DateTimeOffset(new DateTime(2023, 12, 7, 4, 37, 58, 923, DateTimeKind.Unspecified).AddTicks(4490), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Fresh Pants" },
                    { 710, new DateTimeOffset(new DateTime(2023, 2, 23, 2, 23, 35, 182, DateTimeKind.Unspecified).AddTicks(3916), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Wooden Car" },
                    { 711, new DateTimeOffset(new DateTime(2023, 5, 12, 0, 9, 11, 441, DateTimeKind.Unspecified).AddTicks(3342), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Cotton Fish" },
                    { 712, new DateTimeOffset(new DateTime(2023, 7, 28, 21, 54, 47, 700, DateTimeKind.Unspecified).AddTicks(2768), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Soft Table" },
                    { 713, new DateTimeOffset(new DateTime(2023, 10, 14, 19, 40, 23, 959, DateTimeKind.Unspecified).AddTicks(2194), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Steel Keyboard" },
                    { 714, new DateTimeOffset(new DateTime(2023, 12, 31, 17, 26, 0, 218, DateTimeKind.Unspecified).AddTicks(1620), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Plastic Pizza" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreationDate", "Name" },
                values: new object[,]
                {
                    { 715, new DateTimeOffset(new DateTime(2023, 3, 19, 15, 11, 36, 477, DateTimeKind.Unspecified).AddTicks(1046), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Rubber Towels" },
                    { 716, new DateTimeOffset(new DateTime(2023, 6, 5, 12, 57, 12, 736, DateTimeKind.Unspecified).AddTicks(472), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Fresh Bike" },
                    { 717, new DateTimeOffset(new DateTime(2023, 8, 22, 10, 42, 48, 994, DateTimeKind.Unspecified).AddTicks(9898), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Concrete Sausages" },
                    { 718, new DateTimeOffset(new DateTime(2023, 11, 8, 8, 28, 25, 253, DateTimeKind.Unspecified).AddTicks(9324), new TimeSpan(0, 1, 0, 0, 0)), "Refined Granite Tuna" },
                    { 719, new DateTimeOffset(new DateTime(2023, 1, 25, 6, 14, 1, 512, DateTimeKind.Unspecified).AddTicks(8750), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Soft Pants" },
                    { 720, new DateTimeOffset(new DateTime(2023, 4, 13, 3, 59, 37, 771, DateTimeKind.Unspecified).AddTicks(8176), new TimeSpan(0, 1, 0, 0, 0)), "Refined Steel Chair" },
                    { 721, new DateTimeOffset(new DateTime(2023, 6, 30, 1, 45, 14, 30, DateTimeKind.Unspecified).AddTicks(7603), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Cotton Fish" },
                    { 722, new DateTimeOffset(new DateTime(2023, 9, 15, 23, 30, 50, 289, DateTimeKind.Unspecified).AddTicks(7029), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Metal Table" },
                    { 723, new DateTimeOffset(new DateTime(2023, 12, 2, 21, 16, 26, 548, DateTimeKind.Unspecified).AddTicks(6455), new TimeSpan(0, 1, 0, 0, 0)), "Practical Frozen Keyboard" },
                    { 724, new DateTimeOffset(new DateTime(2023, 2, 18, 19, 2, 2, 807, DateTimeKind.Unspecified).AddTicks(5881), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Concrete Pizza" },
                    { 725, new DateTimeOffset(new DateTime(2023, 5, 7, 16, 47, 39, 66, DateTimeKind.Unspecified).AddTicks(5307), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Rubber Hat" },
                    { 726, new DateTimeOffset(new DateTime(2023, 7, 24, 14, 33, 15, 325, DateTimeKind.Unspecified).AddTicks(4733), new TimeSpan(0, 1, 0, 0, 0)), "Small Fresh Bike" },
                    { 727, new DateTimeOffset(new DateTime(2023, 10, 10, 12, 18, 51, 584, DateTimeKind.Unspecified).AddTicks(4159), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Wooden Sausages" },
                    { 728, new DateTimeOffset(new DateTime(2023, 12, 27, 10, 4, 27, 843, DateTimeKind.Unspecified).AddTicks(3585), new TimeSpan(0, 1, 0, 0, 0)), "Small Cotton Tuna" },
                    { 729, new DateTimeOffset(new DateTime(2023, 3, 15, 7, 50, 4, 102, DateTimeKind.Unspecified).AddTicks(3011), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Metal Gloves" },
                    { 730, new DateTimeOffset(new DateTime(2023, 6, 1, 5, 35, 40, 361, DateTimeKind.Unspecified).AddTicks(2437), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Steel Chair" },
                    { 731, new DateTimeOffset(new DateTime(2023, 8, 18, 3, 21, 16, 620, DateTimeKind.Unspecified).AddTicks(1863), new TimeSpan(0, 1, 0, 0, 0)), "Generic Plastic Fish" },
                    { 732, new DateTimeOffset(new DateTime(2023, 11, 4, 1, 6, 52, 879, DateTimeKind.Unspecified).AddTicks(1289), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Rubber Table" },
                    { 733, new DateTimeOffset(new DateTime(2023, 1, 20, 22, 52, 29, 138, DateTimeKind.Unspecified).AddTicks(715), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Fresh Keyboard" },
                    { 734, new DateTimeOffset(new DateTime(2023, 4, 8, 20, 38, 5, 397, DateTimeKind.Unspecified).AddTicks(141), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Concrete Bacon" },
                    { 735, new DateTimeOffset(new DateTime(2023, 6, 25, 18, 23, 41, 655, DateTimeKind.Unspecified).AddTicks(9567), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Granite Hat" },
                    { 736, new DateTimeOffset(new DateTime(2023, 9, 11, 16, 9, 17, 914, DateTimeKind.Unspecified).AddTicks(8993), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Soft Bike" },
                    { 737, new DateTimeOffset(new DateTime(2023, 11, 28, 13, 54, 54, 173, DateTimeKind.Unspecified).AddTicks(8419), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Steel Sausages" },
                    { 738, new DateTimeOffset(new DateTime(2023, 2, 14, 11, 40, 30, 432, DateTimeKind.Unspecified).AddTicks(7845), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Plastic Soap" },
                    { 739, new DateTimeOffset(new DateTime(2023, 5, 3, 9, 26, 6, 691, DateTimeKind.Unspecified).AddTicks(7271), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Metal Gloves" },
                    { 740, new DateTimeOffset(new DateTime(2023, 7, 20, 7, 11, 42, 950, DateTimeKind.Unspecified).AddTicks(6697), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Frozen Chair" },
                    { 741, new DateTimeOffset(new DateTime(2023, 10, 6, 4, 57, 19, 209, DateTimeKind.Unspecified).AddTicks(6123), new TimeSpan(0, 1, 0, 0, 0)), "Refined Concrete Fish" },
                    { 742, new DateTimeOffset(new DateTime(2023, 12, 23, 2, 42, 55, 468, DateTimeKind.Unspecified).AddTicks(5549), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Granite Table" },
                    { 743, new DateTimeOffset(new DateTime(2023, 3, 11, 0, 28, 31, 727, DateTimeKind.Unspecified).AddTicks(4975), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Fresh Computer" },
                    { 744, new DateTimeOffset(new DateTime(2023, 5, 27, 22, 14, 7, 986, DateTimeKind.Unspecified).AddTicks(4402), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Wooden Bacon" },
                    { 745, new DateTimeOffset(new DateTime(2023, 8, 13, 19, 59, 44, 245, DateTimeKind.Unspecified).AddTicks(3828), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Cotton Hat" },
                    { 746, new DateTimeOffset(new DateTime(2023, 10, 30, 17, 45, 20, 504, DateTimeKind.Unspecified).AddTicks(3254), new TimeSpan(0, 1, 0, 0, 0)), "Practical Metal Bike" },
                    { 747, new DateTimeOffset(new DateTime(2023, 1, 16, 15, 30, 56, 763, DateTimeKind.Unspecified).AddTicks(2680), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Steel Salad" },
                    { 748, new DateTimeOffset(new DateTime(2023, 4, 4, 13, 16, 33, 22, DateTimeKind.Unspecified).AddTicks(2106), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Plastic Soap" },
                    { 749, new DateTimeOffset(new DateTime(2023, 6, 21, 11, 2, 9, 281, DateTimeKind.Unspecified).AddTicks(1532), new TimeSpan(0, 1, 0, 0, 0)), "Small Rubber Gloves" },
                    { 750, new DateTimeOffset(new DateTime(2023, 9, 7, 8, 47, 45, 540, DateTimeKind.Unspecified).AddTicks(958), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Fresh Chair" },
                    { 751, new DateTimeOffset(new DateTime(2023, 11, 24, 6, 33, 21, 799, DateTimeKind.Unspecified).AddTicks(384), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Wooden Chicken" },
                    { 752, new DateTimeOffset(new DateTime(2023, 2, 10, 4, 18, 58, 57, DateTimeKind.Unspecified).AddTicks(9810), new TimeSpan(0, 1, 0, 0, 0)), "Generic Granite Shirt" },
                    { 753, new DateTimeOffset(new DateTime(2023, 4, 29, 2, 4, 34, 316, DateTimeKind.Unspecified).AddTicks(9236), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Soft Computer" },
                    { 754, new DateTimeOffset(new DateTime(2023, 7, 15, 23, 50, 10, 575, DateTimeKind.Unspecified).AddTicks(8662), new TimeSpan(0, 1, 0, 0, 0)), "Generic Steel Bacon" },
                    { 755, new DateTimeOffset(new DateTime(2023, 10, 1, 21, 35, 46, 834, DateTimeKind.Unspecified).AddTicks(8088), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Plastic Hat" },
                    { 756, new DateTimeOffset(new DateTime(2023, 12, 18, 19, 21, 23, 93, DateTimeKind.Unspecified).AddTicks(7514), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Metal Mouse" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreationDate", "Name" },
                values: new object[,]
                {
                    { 757, new DateTimeOffset(new DateTime(2023, 3, 6, 17, 6, 59, 352, DateTimeKind.Unspecified).AddTicks(6940), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Frozen Salad" },
                    { 758, new DateTimeOffset(new DateTime(2023, 5, 23, 14, 52, 35, 611, DateTimeKind.Unspecified).AddTicks(6366), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Concrete Soap" },
                    { 759, new DateTimeOffset(new DateTime(2023, 8, 9, 12, 38, 11, 870, DateTimeKind.Unspecified).AddTicks(5792), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Granite Gloves" },
                    { 760, new DateTimeOffset(new DateTime(2023, 10, 26, 10, 23, 48, 129, DateTimeKind.Unspecified).AddTicks(5218), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Soft Chips" },
                    { 761, new DateTimeOffset(new DateTime(2024, 1, 12, 8, 9, 24, 388, DateTimeKind.Unspecified).AddTicks(4644), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Wooden Chicken" },
                    { 762, new DateTimeOffset(new DateTime(2023, 3, 31, 5, 55, 0, 647, DateTimeKind.Unspecified).AddTicks(4070), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Cotton Shirt" },
                    { 763, new DateTimeOffset(new DateTime(2023, 6, 17, 3, 40, 36, 906, DateTimeKind.Unspecified).AddTicks(3496), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Metal Computer" },
                    { 764, new DateTimeOffset(new DateTime(2023, 9, 3, 1, 26, 13, 165, DateTimeKind.Unspecified).AddTicks(2922), new TimeSpan(0, 1, 0, 0, 0)), "Refined Frozen Bacon" },
                    { 765, new DateTimeOffset(new DateTime(2023, 11, 19, 23, 11, 49, 424, DateTimeKind.Unspecified).AddTicks(2348), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Plastic Shoes" },
                    { 766, new DateTimeOffset(new DateTime(2023, 2, 5, 20, 57, 25, 683, DateTimeKind.Unspecified).AddTicks(1774), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Rubber Mouse" },
                    { 767, new DateTimeOffset(new DateTime(2023, 4, 24, 18, 43, 1, 942, DateTimeKind.Unspecified).AddTicks(1200), new TimeSpan(0, 1, 0, 0, 0)), "Practical Fresh Salad" },
                    { 768, new DateTimeOffset(new DateTime(2023, 7, 11, 16, 28, 38, 201, DateTimeKind.Unspecified).AddTicks(626), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Wooden Soap" },
                    { 769, new DateTimeOffset(new DateTime(2023, 9, 27, 14, 14, 14, 460, DateTimeKind.Unspecified).AddTicks(53), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Granite Ball" },
                    { 770, new DateTimeOffset(new DateTime(2023, 12, 14, 11, 59, 50, 718, DateTimeKind.Unspecified).AddTicks(9479), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Soft Chips" },
                    { 771, new DateTimeOffset(new DateTime(2023, 3, 2, 9, 45, 26, 977, DateTimeKind.Unspecified).AddTicks(8905), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Steel Chicken" },
                    { 772, new DateTimeOffset(new DateTime(2023, 5, 19, 7, 31, 3, 236, DateTimeKind.Unspecified).AddTicks(8331), new TimeSpan(0, 1, 0, 0, 0)), "Small Plastic Shirt" },
                    { 773, new DateTimeOffset(new DateTime(2023, 8, 5, 5, 16, 39, 495, DateTimeKind.Unspecified).AddTicks(7757), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Rubber Computer" },
                    { 774, new DateTimeOffset(new DateTime(2023, 10, 22, 3, 2, 15, 754, DateTimeKind.Unspecified).AddTicks(7183), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Frozen Cheese" },
                    { 775, new DateTimeOffset(new DateTime(2024, 1, 8, 0, 47, 52, 13, DateTimeKind.Unspecified).AddTicks(6609), new TimeSpan(0, 1, 0, 0, 0)), "Generic Concrete Shoes" },
                    { 776, new DateTimeOffset(new DateTime(2023, 3, 26, 22, 33, 28, 272, DateTimeKind.Unspecified).AddTicks(6035), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Granite Mouse" },
                    { 777, new DateTimeOffset(new DateTime(2023, 6, 12, 20, 19, 4, 531, DateTimeKind.Unspecified).AddTicks(5461), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Soft Salad" },
                    { 778, new DateTimeOffset(new DateTime(2023, 8, 29, 18, 4, 40, 790, DateTimeKind.Unspecified).AddTicks(4887), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Wooden Towels" },
                    { 779, new DateTimeOffset(new DateTime(2023, 11, 15, 15, 50, 17, 49, DateTimeKind.Unspecified).AddTicks(4313), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Cotton Ball" },
                    { 780, new DateTimeOffset(new DateTime(2023, 2, 1, 13, 35, 53, 308, DateTimeKind.Unspecified).AddTicks(3739), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Metal Chips" },
                    { 781, new DateTimeOffset(new DateTime(2023, 4, 20, 11, 21, 29, 567, DateTimeKind.Unspecified).AddTicks(3165), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Frozen Chicken" },
                    { 782, new DateTimeOffset(new DateTime(2023, 7, 7, 9, 7, 5, 826, DateTimeKind.Unspecified).AddTicks(2591), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Concrete Shirt" },
                    { 783, new DateTimeOffset(new DateTime(2023, 9, 23, 6, 52, 42, 85, DateTimeKind.Unspecified).AddTicks(2017), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Rubber Car" },
                    { 784, new DateTimeOffset(new DateTime(2023, 12, 10, 4, 38, 18, 344, DateTimeKind.Unspecified).AddTicks(1443), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Fresh Cheese" },
                    { 785, new DateTimeOffset(new DateTime(2023, 2, 26, 2, 23, 54, 603, DateTimeKind.Unspecified).AddTicks(869), new TimeSpan(0, 1, 0, 0, 0)), "Refined Wooden Shoes" },
                    { 786, new DateTimeOffset(new DateTime(2023, 5, 15, 0, 9, 30, 862, DateTimeKind.Unspecified).AddTicks(295), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Cotton Mouse" },
                    { 787, new DateTimeOffset(new DateTime(2023, 7, 31, 21, 55, 7, 120, DateTimeKind.Unspecified).AddTicks(9721), new TimeSpan(0, 1, 0, 0, 0)), "Refined Soft Pizza" },
                    { 788, new DateTimeOffset(new DateTime(2023, 10, 17, 19, 40, 43, 379, DateTimeKind.Unspecified).AddTicks(9147), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Steel Towels" },
                    { 789, new DateTimeOffset(new DateTime(2024, 1, 3, 17, 26, 19, 638, DateTimeKind.Unspecified).AddTicks(8573), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Plastic Ball" },
                    { 790, new DateTimeOffset(new DateTime(2023, 3, 22, 15, 11, 55, 897, DateTimeKind.Unspecified).AddTicks(7999), new TimeSpan(0, 1, 0, 0, 0)), "Practical Rubber Chips" },
                    { 791, new DateTimeOffset(new DateTime(2023, 6, 8, 12, 57, 32, 156, DateTimeKind.Unspecified).AddTicks(7425), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Frozen Chicken" },
                    { 792, new DateTimeOffset(new DateTime(2023, 8, 25, 10, 43, 8, 415, DateTimeKind.Unspecified).AddTicks(6852), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Concrete Pants" },
                    { 793, new DateTimeOffset(new DateTime(2023, 11, 11, 8, 28, 44, 674, DateTimeKind.Unspecified).AddTicks(6278), new TimeSpan(0, 1, 0, 0, 0)), "Small Granite Car" },
                    { 794, new DateTimeOffset(new DateTime(2023, 1, 28, 6, 14, 20, 933, DateTimeKind.Unspecified).AddTicks(5704), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Soft Cheese" },
                    { 795, new DateTimeOffset(new DateTime(2023, 4, 16, 3, 59, 57, 192, DateTimeKind.Unspecified).AddTicks(5130), new TimeSpan(0, 1, 0, 0, 0)), "Small Steel Shoes" },
                    { 796, new DateTimeOffset(new DateTime(2023, 7, 3, 1, 45, 33, 451, DateTimeKind.Unspecified).AddTicks(4556), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Cotton Keyboard" },
                    { 797, new DateTimeOffset(new DateTime(2023, 9, 18, 23, 31, 9, 710, DateTimeKind.Unspecified).AddTicks(3982), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Metal Pizza" },
                    { 798, new DateTimeOffset(new DateTime(2023, 12, 5, 21, 16, 45, 969, DateTimeKind.Unspecified).AddTicks(3408), new TimeSpan(0, 1, 0, 0, 0)), "Generic Frozen Towels" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreationDate", "Name" },
                values: new object[,]
                {
                    { 799, new DateTimeOffset(new DateTime(2023, 2, 21, 19, 2, 22, 228, DateTimeKind.Unspecified).AddTicks(2834), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Concrete Ball" },
                    { 800, new DateTimeOffset(new DateTime(2023, 5, 10, 16, 47, 58, 487, DateTimeKind.Unspecified).AddTicks(2260), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Rubber Chips" },
                    { 801, new DateTimeOffset(new DateTime(2023, 7, 27, 14, 33, 34, 746, DateTimeKind.Unspecified).AddTicks(1686), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Fresh Tuna" },
                    { 802, new DateTimeOffset(new DateTime(2023, 10, 13, 12, 19, 11, 5, DateTimeKind.Unspecified).AddTicks(1112), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Wooden Pants" },
                    { 803, new DateTimeOffset(new DateTime(2023, 12, 30, 10, 4, 47, 264, DateTimeKind.Unspecified).AddTicks(538), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Cotton Car" },
                    { 804, new DateTimeOffset(new DateTime(2023, 3, 18, 7, 50, 23, 522, DateTimeKind.Unspecified).AddTicks(9964), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Metal Cheese" },
                    { 805, new DateTimeOffset(new DateTime(2023, 6, 4, 5, 35, 59, 781, DateTimeKind.Unspecified).AddTicks(9390), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Steel Table" },
                    { 806, new DateTimeOffset(new DateTime(2023, 8, 21, 3, 21, 36, 40, DateTimeKind.Unspecified).AddTicks(8816), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Plastic Keyboard" },
                    { 807, new DateTimeOffset(new DateTime(2023, 11, 7, 1, 7, 12, 299, DateTimeKind.Unspecified).AddTicks(8242), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Rubber Pizza" },
                    { 808, new DateTimeOffset(new DateTime(2023, 1, 23, 22, 52, 48, 558, DateTimeKind.Unspecified).AddTicks(7668), new TimeSpan(0, 1, 0, 0, 0)), "Refined Fresh Towels" },
                    { 809, new DateTimeOffset(new DateTime(2023, 4, 11, 20, 38, 24, 817, DateTimeKind.Unspecified).AddTicks(7094), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Concrete Bike" },
                    { 810, new DateTimeOffset(new DateTime(2023, 6, 28, 18, 24, 1, 76, DateTimeKind.Unspecified).AddTicks(6520), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Granite Sausages" },
                    { 811, new DateTimeOffset(new DateTime(2023, 9, 14, 16, 9, 37, 335, DateTimeKind.Unspecified).AddTicks(5946), new TimeSpan(0, 1, 0, 0, 0)), "Practical Soft Tuna" },
                    { 812, new DateTimeOffset(new DateTime(2023, 12, 1, 13, 55, 13, 594, DateTimeKind.Unspecified).AddTicks(5372), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Steel Pants" },
                    { 813, new DateTimeOffset(new DateTime(2023, 2, 17, 11, 40, 49, 853, DateTimeKind.Unspecified).AddTicks(4798), new TimeSpan(0, 1, 0, 0, 0)), "Practical Cotton Car" },
                    { 814, new DateTimeOffset(new DateTime(2023, 5, 6, 9, 26, 26, 112, DateTimeKind.Unspecified).AddTicks(4224), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Metal Fish" },
                    { 815, new DateTimeOffset(new DateTime(2023, 7, 23, 7, 12, 2, 371, DateTimeKind.Unspecified).AddTicks(3650), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Frozen Table" },
                    { 816, new DateTimeOffset(new DateTime(2023, 10, 9, 4, 57, 38, 630, DateTimeKind.Unspecified).AddTicks(3076), new TimeSpan(0, 1, 0, 0, 0)), "Small Concrete Keyboard" },
                    { 817, new DateTimeOffset(new DateTime(2023, 12, 26, 2, 43, 14, 889, DateTimeKind.Unspecified).AddTicks(2503), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Granite Pizza" },
                    { 818, new DateTimeOffset(new DateTime(2023, 3, 14, 0, 28, 51, 148, DateTimeKind.Unspecified).AddTicks(1929), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Fresh Hat" },
                    { 819, new DateTimeOffset(new DateTime(2023, 5, 30, 22, 14, 27, 407, DateTimeKind.Unspecified).AddTicks(1355), new TimeSpan(0, 1, 0, 0, 0)), "Generic Wooden Bike" },
                    { 820, new DateTimeOffset(new DateTime(2023, 8, 16, 20, 0, 3, 666, DateTimeKind.Unspecified).AddTicks(781), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Cotton Sausages" },
                    { 821, new DateTimeOffset(new DateTime(2023, 11, 2, 17, 45, 39, 925, DateTimeKind.Unspecified).AddTicks(207), new TimeSpan(0, 1, 0, 0, 0)), "Generic Metal Tuna" },
                    { 822, new DateTimeOffset(new DateTime(2023, 1, 19, 15, 31, 16, 183, DateTimeKind.Unspecified).AddTicks(9633), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Steel Pants" },
                    { 823, new DateTimeOffset(new DateTime(2023, 4, 7, 13, 16, 52, 442, DateTimeKind.Unspecified).AddTicks(9059), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Plastic Chair" },
                    { 824, new DateTimeOffset(new DateTime(2023, 6, 24, 11, 2, 28, 701, DateTimeKind.Unspecified).AddTicks(8485), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Rubber Fish" },
                    { 825, new DateTimeOffset(new DateTime(2023, 9, 10, 8, 48, 4, 960, DateTimeKind.Unspecified).AddTicks(7911), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Fresh Table" },
                    { 826, new DateTimeOffset(new DateTime(2023, 11, 27, 6, 33, 41, 219, DateTimeKind.Unspecified).AddTicks(7337), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Wooden Keyboard" },
                    { 827, new DateTimeOffset(new DateTime(2023, 2, 13, 4, 19, 17, 478, DateTimeKind.Unspecified).AddTicks(6763), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Granite Bacon" },
                    { 828, new DateTimeOffset(new DateTime(2023, 5, 2, 2, 4, 53, 737, DateTimeKind.Unspecified).AddTicks(6189), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Soft Hat" },
                    { 829, new DateTimeOffset(new DateTime(2023, 7, 18, 23, 50, 29, 996, DateTimeKind.Unspecified).AddTicks(5615), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Steel Bike" },
                    { 830, new DateTimeOffset(new DateTime(2023, 10, 4, 21, 36, 6, 255, DateTimeKind.Unspecified).AddTicks(5041), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Plastic Sausages" },
                    { 831, new DateTimeOffset(new DateTime(2023, 12, 21, 19, 21, 42, 514, DateTimeKind.Unspecified).AddTicks(4467), new TimeSpan(0, 1, 0, 0, 0)), "Refined Metal Tuna" },
                    { 832, new DateTimeOffset(new DateTime(2023, 3, 9, 17, 7, 18, 773, DateTimeKind.Unspecified).AddTicks(3893), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Frozen Gloves" },
                    { 833, new DateTimeOffset(new DateTime(2023, 5, 26, 14, 52, 55, 32, DateTimeKind.Unspecified).AddTicks(3319), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Concrete Chair" },
                    { 834, new DateTimeOffset(new DateTime(2023, 8, 12, 12, 38, 31, 291, DateTimeKind.Unspecified).AddTicks(2745), new TimeSpan(0, 1, 0, 0, 0)), "Practical Granite Fish" },
                    { 835, new DateTimeOffset(new DateTime(2023, 10, 29, 10, 24, 7, 550, DateTimeKind.Unspecified).AddTicks(2171), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Fresh Table" },
                    { 836, new DateTimeOffset(new DateTime(2024, 1, 15, 8, 9, 43, 809, DateTimeKind.Unspecified).AddTicks(1597), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Wooden Computer" },
                    { 837, new DateTimeOffset(new DateTime(2023, 4, 3, 5, 55, 20, 68, DateTimeKind.Unspecified).AddTicks(1023), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Cotton Bacon" },
                    { 838, new DateTimeOffset(new DateTime(2023, 6, 20, 3, 40, 56, 327, DateTimeKind.Unspecified).AddTicks(449), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Metal Hat" },
                    { 839, new DateTimeOffset(new DateTime(2023, 9, 6, 1, 26, 32, 585, DateTimeKind.Unspecified).AddTicks(9876), new TimeSpan(0, 1, 0, 0, 0)), "Small Frozen Bike" },
                    { 840, new DateTimeOffset(new DateTime(2023, 11, 22, 23, 12, 8, 844, DateTimeKind.Unspecified).AddTicks(9302), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Plastic Sausages" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreationDate", "Name" },
                values: new object[,]
                {
                    { 841, new DateTimeOffset(new DateTime(2023, 2, 8, 20, 57, 45, 103, DateTimeKind.Unspecified).AddTicks(8728), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Rubber Soap" },
                    { 842, new DateTimeOffset(new DateTime(2023, 4, 27, 18, 43, 21, 362, DateTimeKind.Unspecified).AddTicks(8154), new TimeSpan(0, 1, 0, 0, 0)), "Generic Fresh Gloves" },
                    { 843, new DateTimeOffset(new DateTime(2023, 7, 14, 16, 28, 57, 621, DateTimeKind.Unspecified).AddTicks(7580), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Wooden Chair" },
                    { 844, new DateTimeOffset(new DateTime(2023, 9, 30, 14, 14, 33, 880, DateTimeKind.Unspecified).AddTicks(7006), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Granite Fish" },
                    { 845, new DateTimeOffset(new DateTime(2023, 12, 17, 12, 0, 10, 139, DateTimeKind.Unspecified).AddTicks(6432), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Soft Shirt" },
                    { 846, new DateTimeOffset(new DateTime(2023, 3, 5, 9, 45, 46, 398, DateTimeKind.Unspecified).AddTicks(5858), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Steel Computer" },
                    { 847, new DateTimeOffset(new DateTime(2023, 5, 22, 7, 31, 22, 657, DateTimeKind.Unspecified).AddTicks(5284), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Plastic Bacon" },
                    { 848, new DateTimeOffset(new DateTime(2023, 8, 8, 5, 16, 58, 916, DateTimeKind.Unspecified).AddTicks(4710), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Rubber Hat" },
                    { 849, new DateTimeOffset(new DateTime(2023, 10, 25, 3, 2, 35, 175, DateTimeKind.Unspecified).AddTicks(4136), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Frozen Bike" },
                    { 850, new DateTimeOffset(new DateTime(2024, 1, 11, 0, 48, 11, 434, DateTimeKind.Unspecified).AddTicks(3562), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Concrete Salad" },
                    { 851, new DateTimeOffset(new DateTime(2023, 3, 29, 22, 33, 47, 693, DateTimeKind.Unspecified).AddTicks(2988), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Granite Soap" },
                    { 852, new DateTimeOffset(new DateTime(2023, 6, 15, 20, 19, 23, 952, DateTimeKind.Unspecified).AddTicks(2414), new TimeSpan(0, 1, 0, 0, 0)), "Refined Soft Gloves" },
                    { 853, new DateTimeOffset(new DateTime(2023, 9, 1, 18, 5, 0, 211, DateTimeKind.Unspecified).AddTicks(1840), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Wooden Chair" },
                    { 854, new DateTimeOffset(new DateTime(2023, 11, 18, 15, 50, 36, 470, DateTimeKind.Unspecified).AddTicks(1266), new TimeSpan(0, 1, 0, 0, 0)), "Refined Cotton Chicken" },
                    { 855, new DateTimeOffset(new DateTime(2023, 2, 4, 13, 36, 12, 729, DateTimeKind.Unspecified).AddTicks(692), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Metal Shirt" },
                    { 856, new DateTimeOffset(new DateTime(2023, 4, 23, 11, 21, 48, 988, DateTimeKind.Unspecified).AddTicks(118), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Frozen Computer" },
                    { 857, new DateTimeOffset(new DateTime(2023, 7, 10, 9, 7, 25, 246, DateTimeKind.Unspecified).AddTicks(9544), new TimeSpan(0, 1, 0, 0, 0)), "Practical Plastic Bacon" },
                    { 858, new DateTimeOffset(new DateTime(2023, 9, 26, 6, 53, 1, 505, DateTimeKind.Unspecified).AddTicks(8970), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Rubber Shoes" },
                    { 859, new DateTimeOffset(new DateTime(2023, 12, 13, 4, 38, 37, 764, DateTimeKind.Unspecified).AddTicks(8396), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Fresh Mouse" },
                    { 860, new DateTimeOffset(new DateTime(2023, 3, 1, 2, 24, 14, 23, DateTimeKind.Unspecified).AddTicks(7822), new TimeSpan(0, 1, 0, 0, 0)), "Small Wooden Salad" },
                    { 861, new DateTimeOffset(new DateTime(2023, 5, 18, 0, 9, 50, 282, DateTimeKind.Unspecified).AddTicks(7248), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Cotton Soap" },
                    { 862, new DateTimeOffset(new DateTime(2023, 8, 3, 21, 55, 26, 541, DateTimeKind.Unspecified).AddTicks(6674), new TimeSpan(0, 1, 0, 0, 0)), "Small Soft Gloves" },
                    { 863, new DateTimeOffset(new DateTime(2023, 10, 20, 19, 41, 2, 800, DateTimeKind.Unspecified).AddTicks(6100), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Steel Chips" },
                    { 864, new DateTimeOffset(new DateTime(2024, 1, 6, 17, 26, 39, 59, DateTimeKind.Unspecified).AddTicks(5526), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Plastic Chicken" },
                    { 865, new DateTimeOffset(new DateTime(2023, 3, 25, 15, 12, 15, 318, DateTimeKind.Unspecified).AddTicks(4953), new TimeSpan(0, 1, 0, 0, 0)), "Generic Rubber Shirt" },
                    { 866, new DateTimeOffset(new DateTime(2023, 6, 11, 12, 57, 51, 577, DateTimeKind.Unspecified).AddTicks(4379), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Frozen Computer" },
                    { 867, new DateTimeOffset(new DateTime(2023, 8, 28, 10, 43, 27, 836, DateTimeKind.Unspecified).AddTicks(3805), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Concrete Cheese" },
                    { 868, new DateTimeOffset(new DateTime(2023, 11, 14, 8, 29, 4, 95, DateTimeKind.Unspecified).AddTicks(3231), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Granite Shoes" },
                    { 869, new DateTimeOffset(new DateTime(2023, 1, 31, 6, 14, 40, 354, DateTimeKind.Unspecified).AddTicks(2657), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Soft Mouse" },
                    { 870, new DateTimeOffset(new DateTime(2023, 4, 19, 4, 0, 16, 613, DateTimeKind.Unspecified).AddTicks(2083), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Wooden Salad" },
                    { 871, new DateTimeOffset(new DateTime(2023, 7, 6, 1, 45, 52, 872, DateTimeKind.Unspecified).AddTicks(1509), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Cotton Soap" },
                    { 872, new DateTimeOffset(new DateTime(2023, 9, 21, 23, 31, 29, 131, DateTimeKind.Unspecified).AddTicks(935), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Metal Ball" },
                    { 873, new DateTimeOffset(new DateTime(2023, 12, 8, 21, 17, 5, 390, DateTimeKind.Unspecified).AddTicks(361), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Frozen Chips" },
                    { 874, new DateTimeOffset(new DateTime(2023, 2, 24, 19, 2, 41, 648, DateTimeKind.Unspecified).AddTicks(9787), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Concrete Chicken" },
                    { 875, new DateTimeOffset(new DateTime(2023, 5, 13, 16, 48, 17, 907, DateTimeKind.Unspecified).AddTicks(9213), new TimeSpan(0, 1, 0, 0, 0)), "Refined Rubber Shirt" },
                    { 876, new DateTimeOffset(new DateTime(2023, 7, 30, 14, 33, 54, 166, DateTimeKind.Unspecified).AddTicks(8639), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Fresh Car" },
                    { 877, new DateTimeOffset(new DateTime(2023, 10, 16, 12, 19, 30, 425, DateTimeKind.Unspecified).AddTicks(8065), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Wooden Cheese" },
                    { 878, new DateTimeOffset(new DateTime(2024, 1, 2, 10, 5, 6, 684, DateTimeKind.Unspecified).AddTicks(7491), new TimeSpan(0, 1, 0, 0, 0)), "Practical Cotton Shoes" },
                    { 879, new DateTimeOffset(new DateTime(2023, 3, 21, 7, 50, 42, 943, DateTimeKind.Unspecified).AddTicks(6917), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Soft Mouse" },
                    { 880, new DateTimeOffset(new DateTime(2023, 6, 7, 5, 36, 19, 202, DateTimeKind.Unspecified).AddTicks(6343), new TimeSpan(0, 1, 0, 0, 0)), "Practical Steel Salad" },
                    { 881, new DateTimeOffset(new DateTime(2023, 8, 24, 3, 21, 55, 461, DateTimeKind.Unspecified).AddTicks(5769), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Plastic Towels" },
                    { 882, new DateTimeOffset(new DateTime(2023, 11, 10, 1, 7, 31, 720, DateTimeKind.Unspecified).AddTicks(5195), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Rubber Ball" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreationDate", "Name" },
                values: new object[,]
                {
                    { 883, new DateTimeOffset(new DateTime(2023, 1, 26, 22, 53, 7, 979, DateTimeKind.Unspecified).AddTicks(4621), new TimeSpan(0, 1, 0, 0, 0)), "Small Fresh Chips" },
                    { 884, new DateTimeOffset(new DateTime(2023, 4, 14, 20, 38, 44, 238, DateTimeKind.Unspecified).AddTicks(4047), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Concrete Chicken" },
                    { 885, new DateTimeOffset(new DateTime(2023, 7, 1, 18, 24, 20, 497, DateTimeKind.Unspecified).AddTicks(3473), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Granite Pants" },
                    { 886, new DateTimeOffset(new DateTime(2023, 9, 17, 16, 9, 56, 756, DateTimeKind.Unspecified).AddTicks(2899), new TimeSpan(0, 1, 0, 0, 0)), "Generic Soft Car" },
                    { 887, new DateTimeOffset(new DateTime(2023, 12, 4, 13, 55, 33, 15, DateTimeKind.Unspecified).AddTicks(2326), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Steel Cheese" },
                    { 888, new DateTimeOffset(new DateTime(2023, 2, 20, 11, 41, 9, 274, DateTimeKind.Unspecified).AddTicks(1752), new TimeSpan(0, 1, 0, 0, 0)), "Generic Cotton Shoes" },
                    { 889, new DateTimeOffset(new DateTime(2023, 5, 9, 9, 26, 45, 533, DateTimeKind.Unspecified).AddTicks(1178), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Metal Mouse" },
                    { 890, new DateTimeOffset(new DateTime(2023, 7, 26, 7, 12, 21, 792, DateTimeKind.Unspecified).AddTicks(604), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Frozen Pizza" },
                    { 891, new DateTimeOffset(new DateTime(2023, 10, 12, 4, 57, 58, 51, DateTimeKind.Unspecified).AddTicks(30), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Concrete Towels" },
                    { 892, new DateTimeOffset(new DateTime(2023, 12, 29, 2, 43, 34, 309, DateTimeKind.Unspecified).AddTicks(9456), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Rubber Ball" },
                    { 893, new DateTimeOffset(new DateTime(2023, 3, 17, 0, 29, 10, 568, DateTimeKind.Unspecified).AddTicks(8882), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Fresh Chips" },
                    { 894, new DateTimeOffset(new DateTime(2023, 6, 2, 22, 14, 46, 827, DateTimeKind.Unspecified).AddTicks(8308), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Wooden Tuna" },
                    { 895, new DateTimeOffset(new DateTime(2023, 8, 19, 20, 0, 23, 86, DateTimeKind.Unspecified).AddTicks(7734), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Cotton Pants" },
                    { 896, new DateTimeOffset(new DateTime(2023, 11, 5, 17, 45, 59, 345, DateTimeKind.Unspecified).AddTicks(7160), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Metal Car" },
                    { 897, new DateTimeOffset(new DateTime(2023, 1, 22, 15, 31, 35, 604, DateTimeKind.Unspecified).AddTicks(6586), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Steel Cheese" },
                    { 898, new DateTimeOffset(new DateTime(2023, 4, 10, 13, 17, 11, 863, DateTimeKind.Unspecified).AddTicks(6012), new TimeSpan(0, 1, 0, 0, 0)), "Refined Plastic Shoes" },
                    { 899, new DateTimeOffset(new DateTime(2023, 6, 27, 11, 2, 48, 122, DateTimeKind.Unspecified).AddTicks(5438), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Rubber Keyboard" },
                    { 900, new DateTimeOffset(new DateTime(2023, 9, 13, 8, 48, 24, 381, DateTimeKind.Unspecified).AddTicks(4864), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Fresh Pizza" },
                    { 901, new DateTimeOffset(new DateTime(2023, 11, 30, 6, 34, 0, 640, DateTimeKind.Unspecified).AddTicks(4290), new TimeSpan(0, 1, 0, 0, 0)), "Practical Concrete Towels" },
                    { 902, new DateTimeOffset(new DateTime(2023, 2, 16, 4, 19, 36, 899, DateTimeKind.Unspecified).AddTicks(3716), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Granite Ball" },
                    { 903, new DateTimeOffset(new DateTime(2023, 5, 5, 2, 5, 13, 158, DateTimeKind.Unspecified).AddTicks(3142), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Soft Sausages" },
                    { 904, new DateTimeOffset(new DateTime(2023, 7, 21, 23, 50, 49, 417, DateTimeKind.Unspecified).AddTicks(2568), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Steel Tuna" },
                    { 905, new DateTimeOffset(new DateTime(2023, 10, 7, 21, 36, 25, 676, DateTimeKind.Unspecified).AddTicks(1994), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Plastic Pants" },
                    { 906, new DateTimeOffset(new DateTime(2023, 12, 24, 19, 22, 1, 935, DateTimeKind.Unspecified).AddTicks(1420), new TimeSpan(0, 1, 0, 0, 0)), "Small Metal Car" },
                    { 907, new DateTimeOffset(new DateTime(2023, 3, 12, 17, 7, 38, 194, DateTimeKind.Unspecified).AddTicks(846), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Frozen Cheese" },
                    { 908, new DateTimeOffset(new DateTime(2023, 5, 29, 14, 53, 14, 453, DateTimeKind.Unspecified).AddTicks(272), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Concrete Table" },
                    { 909, new DateTimeOffset(new DateTime(2023, 8, 15, 12, 38, 50, 711, DateTimeKind.Unspecified).AddTicks(9698), new TimeSpan(0, 1, 0, 0, 0)), "Generic Granite Keyboard" },
                    { 910, new DateTimeOffset(new DateTime(2023, 11, 1, 10, 24, 26, 970, DateTimeKind.Unspecified).AddTicks(9124), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Fresh Pizza" },
                    { 911, new DateTimeOffset(new DateTime(2023, 1, 18, 8, 10, 3, 229, DateTimeKind.Unspecified).AddTicks(8550), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Wooden Towels" },
                    { 912, new DateTimeOffset(new DateTime(2023, 4, 6, 5, 55, 39, 488, DateTimeKind.Unspecified).AddTicks(7977), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Cotton Bike" },
                    { 913, new DateTimeOffset(new DateTime(2023, 6, 23, 3, 41, 15, 747, DateTimeKind.Unspecified).AddTicks(7403), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Metal Sausages" },
                    { 914, new DateTimeOffset(new DateTime(2023, 9, 9, 1, 26, 52, 6, DateTimeKind.Unspecified).AddTicks(6829), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Steel Tuna" },
                    { 915, new DateTimeOffset(new DateTime(2023, 11, 25, 23, 12, 28, 265, DateTimeKind.Unspecified).AddTicks(6255), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Plastic Pants" },
                    { 916, new DateTimeOffset(new DateTime(2023, 2, 11, 20, 58, 4, 524, DateTimeKind.Unspecified).AddTicks(5681), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Rubber Chair" },
                    { 917, new DateTimeOffset(new DateTime(2023, 4, 30, 18, 43, 40, 783, DateTimeKind.Unspecified).AddTicks(5107), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Fresh Fish" },
                    { 918, new DateTimeOffset(new DateTime(2023, 7, 17, 16, 29, 17, 42, DateTimeKind.Unspecified).AddTicks(4533), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Wooden Table" },
                    { 919, new DateTimeOffset(new DateTime(2023, 10, 3, 14, 14, 53, 301, DateTimeKind.Unspecified).AddTicks(3959), new TimeSpan(0, 1, 0, 0, 0)), "Refined Granite Keyboard" },
                    { 920, new DateTimeOffset(new DateTime(2023, 12, 20, 12, 0, 29, 560, DateTimeKind.Unspecified).AddTicks(3385), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Soft Pizza" },
                    { 921, new DateTimeOffset(new DateTime(2023, 3, 8, 9, 46, 5, 819, DateTimeKind.Unspecified).AddTicks(2811), new TimeSpan(0, 1, 0, 0, 0)), "Refined Steel Hat" },
                    { 922, new DateTimeOffset(new DateTime(2023, 5, 25, 7, 31, 42, 78, DateTimeKind.Unspecified).AddTicks(2237), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Plastic Bike" },
                    { 923, new DateTimeOffset(new DateTime(2023, 8, 11, 5, 17, 18, 337, DateTimeKind.Unspecified).AddTicks(1663), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Metal Sausages" },
                    { 924, new DateTimeOffset(new DateTime(2023, 10, 28, 3, 2, 54, 596, DateTimeKind.Unspecified).AddTicks(1089), new TimeSpan(0, 1, 0, 0, 0)), "Practical Frozen Tuna" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreationDate", "Name" },
                values: new object[,]
                {
                    { 925, new DateTimeOffset(new DateTime(2024, 1, 14, 0, 48, 30, 855, DateTimeKind.Unspecified).AddTicks(515), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Concrete Gloves" },
                    { 926, new DateTimeOffset(new DateTime(2023, 4, 1, 22, 34, 7, 113, DateTimeKind.Unspecified).AddTicks(9941), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Granite Chair" },
                    { 927, new DateTimeOffset(new DateTime(2023, 6, 18, 20, 19, 43, 372, DateTimeKind.Unspecified).AddTicks(9367), new TimeSpan(0, 1, 0, 0, 0)), "Small Soft Fish" },
                    { 928, new DateTimeOffset(new DateTime(2023, 9, 4, 18, 5, 19, 631, DateTimeKind.Unspecified).AddTicks(8793), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Wooden Table" },
                    { 929, new DateTimeOffset(new DateTime(2023, 11, 21, 15, 50, 55, 890, DateTimeKind.Unspecified).AddTicks(8219), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Cotton Keyboard" },
                    { 930, new DateTimeOffset(new DateTime(2023, 2, 7, 13, 36, 32, 149, DateTimeKind.Unspecified).AddTicks(7645), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Metal Bacon" },
                    { 931, new DateTimeOffset(new DateTime(2023, 4, 26, 11, 22, 8, 408, DateTimeKind.Unspecified).AddTicks(7071), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Frozen Hat" },
                    { 932, new DateTimeOffset(new DateTime(2023, 7, 13, 9, 7, 44, 667, DateTimeKind.Unspecified).AddTicks(6497), new TimeSpan(0, 1, 0, 0, 0)), "Generic Plastic Bike" },
                    { 933, new DateTimeOffset(new DateTime(2023, 9, 29, 6, 53, 20, 926, DateTimeKind.Unspecified).AddTicks(5923), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Rubber Sausages" },
                    { 934, new DateTimeOffset(new DateTime(2023, 12, 16, 4, 38, 57, 185, DateTimeKind.Unspecified).AddTicks(5349), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Fresh Soap" },
                    { 935, new DateTimeOffset(new DateTime(2023, 3, 4, 2, 24, 33, 444, DateTimeKind.Unspecified).AddTicks(4775), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Wooden Gloves" },
                    { 936, new DateTimeOffset(new DateTime(2023, 5, 21, 0, 10, 9, 703, DateTimeKind.Unspecified).AddTicks(4202), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Granite Chair" },
                    { 937, new DateTimeOffset(new DateTime(2023, 8, 6, 21, 55, 45, 962, DateTimeKind.Unspecified).AddTicks(3628), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Soft Fish" },
                    { 938, new DateTimeOffset(new DateTime(2023, 10, 23, 19, 41, 22, 221, DateTimeKind.Unspecified).AddTicks(3054), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Steel Table" },
                    { 939, new DateTimeOffset(new DateTime(2024, 1, 9, 17, 26, 58, 480, DateTimeKind.Unspecified).AddTicks(2480), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Plastic Computer" },
                    { 940, new DateTimeOffset(new DateTime(2023, 3, 28, 15, 12, 34, 739, DateTimeKind.Unspecified).AddTicks(1906), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Rubber Bacon" },
                    { 941, new DateTimeOffset(new DateTime(2023, 6, 14, 12, 58, 10, 998, DateTimeKind.Unspecified).AddTicks(1332), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Frozen Hat" },
                    { 942, new DateTimeOffset(new DateTime(2023, 8, 31, 10, 43, 47, 257, DateTimeKind.Unspecified).AddTicks(758), new TimeSpan(0, 1, 0, 0, 0)), "Refined Concrete Bike" },
                    { 943, new DateTimeOffset(new DateTime(2023, 11, 17, 8, 29, 23, 516, DateTimeKind.Unspecified).AddTicks(184), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Granite Salad" },
                    { 944, new DateTimeOffset(new DateTime(2023, 2, 3, 6, 14, 59, 774, DateTimeKind.Unspecified).AddTicks(9610), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Soft Soap" },
                    { 945, new DateTimeOffset(new DateTime(2023, 4, 22, 4, 0, 36, 33, DateTimeKind.Unspecified).AddTicks(9036), new TimeSpan(0, 1, 0, 0, 0)), "Practical Wooden Gloves" },
                    { 946, new DateTimeOffset(new DateTime(2023, 7, 9, 1, 46, 12, 292, DateTimeKind.Unspecified).AddTicks(8462), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Cotton Chair" },
                    { 947, new DateTimeOffset(new DateTime(2023, 9, 24, 23, 31, 48, 551, DateTimeKind.Unspecified).AddTicks(7888), new TimeSpan(0, 1, 0, 0, 0)), "Practical Metal Fish" },
                    { 948, new DateTimeOffset(new DateTime(2023, 12, 11, 21, 17, 24, 810, DateTimeKind.Unspecified).AddTicks(7314), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Frozen Shirt" },
                    { 949, new DateTimeOffset(new DateTime(2023, 2, 27, 19, 3, 1, 69, DateTimeKind.Unspecified).AddTicks(6740), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Concrete Computer" },
                    { 950, new DateTimeOffset(new DateTime(2023, 5, 16, 16, 48, 37, 328, DateTimeKind.Unspecified).AddTicks(6166), new TimeSpan(0, 1, 0, 0, 0)), "Small Rubber Bacon" },
                    { 951, new DateTimeOffset(new DateTime(2023, 8, 2, 14, 34, 13, 587, DateTimeKind.Unspecified).AddTicks(5592), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Fresh Hat" },
                    { 952, new DateTimeOffset(new DateTime(2023, 10, 19, 12, 19, 49, 846, DateTimeKind.Unspecified).AddTicks(5018), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Wooden Mouse" },
                    { 953, new DateTimeOffset(new DateTime(2024, 1, 5, 10, 5, 26, 105, DateTimeKind.Unspecified).AddTicks(4444), new TimeSpan(0, 1, 0, 0, 0)), "Generic Cotton Salad" },
                    { 954, new DateTimeOffset(new DateTime(2023, 3, 24, 7, 51, 2, 364, DateTimeKind.Unspecified).AddTicks(3870), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Soft Soap" },
                    { 955, new DateTimeOffset(new DateTime(2023, 6, 10, 5, 36, 38, 623, DateTimeKind.Unspecified).AddTicks(3296), new TimeSpan(0, 1, 0, 0, 0)), "Generic Steel Gloves" },
                    { 956, new DateTimeOffset(new DateTime(2023, 8, 27, 3, 22, 14, 882, DateTimeKind.Unspecified).AddTicks(2722), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Plastic Chair" },
                    { 957, new DateTimeOffset(new DateTime(2023, 11, 13, 1, 7, 51, 141, DateTimeKind.Unspecified).AddTicks(2148), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Rubber Chicken" },
                    { 958, new DateTimeOffset(new DateTime(2023, 1, 29, 22, 53, 27, 400, DateTimeKind.Unspecified).AddTicks(1574), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Frozen Shirt" },
                    { 959, new DateTimeOffset(new DateTime(2023, 4, 17, 20, 39, 3, 659, DateTimeKind.Unspecified).AddTicks(1000), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Concrete Computer" },
                    { 960, new DateTimeOffset(new DateTime(2023, 7, 4, 18, 24, 39, 918, DateTimeKind.Unspecified).AddTicks(427), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Granite Bacon" },
                    { 961, new DateTimeOffset(new DateTime(2023, 9, 20, 16, 10, 16, 176, DateTimeKind.Unspecified).AddTicks(9853), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Soft Shoes" },
                    { 962, new DateTimeOffset(new DateTime(2023, 12, 7, 13, 55, 52, 435, DateTimeKind.Unspecified).AddTicks(9279), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Steel Mouse" },
                    { 963, new DateTimeOffset(new DateTime(2023, 2, 23, 11, 41, 28, 694, DateTimeKind.Unspecified).AddTicks(8705), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Cotton Salad" },
                    { 964, new DateTimeOffset(new DateTime(2023, 5, 12, 9, 27, 4, 953, DateTimeKind.Unspecified).AddTicks(8131), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Metal Soap" },
                    { 965, new DateTimeOffset(new DateTime(2023, 7, 29, 7, 12, 41, 212, DateTimeKind.Unspecified).AddTicks(7557), new TimeSpan(0, 1, 0, 0, 0)), "Refined Frozen Ball" },
                    { 966, new DateTimeOffset(new DateTime(2023, 10, 15, 4, 58, 17, 471, DateTimeKind.Unspecified).AddTicks(6983), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Concrete Chips" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreationDate", "Name" },
                values: new object[,]
                {
                    { 967, new DateTimeOffset(new DateTime(2024, 1, 1, 2, 43, 53, 730, DateTimeKind.Unspecified).AddTicks(6409), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Rubber Chicken" },
                    { 968, new DateTimeOffset(new DateTime(2023, 3, 20, 0, 29, 29, 989, DateTimeKind.Unspecified).AddTicks(5835), new TimeSpan(0, 1, 0, 0, 0)), "Practical Fresh Shirt" },
                    { 969, new DateTimeOffset(new DateTime(2023, 6, 5, 22, 15, 6, 248, DateTimeKind.Unspecified).AddTicks(5261), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Wooden Computer" },
                    { 970, new DateTimeOffset(new DateTime(2023, 8, 22, 20, 0, 42, 507, DateTimeKind.Unspecified).AddTicks(4687), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Cotton Cheese" },
                    { 971, new DateTimeOffset(new DateTime(2023, 11, 8, 17, 46, 18, 766, DateTimeKind.Unspecified).AddTicks(4113), new TimeSpan(0, 1, 0, 0, 0)), "Small Metal Shoes" },
                    { 972, new DateTimeOffset(new DateTime(2023, 1, 25, 15, 31, 55, 25, DateTimeKind.Unspecified).AddTicks(3539), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Steel Mouse" },
                    { 973, new DateTimeOffset(new DateTime(2023, 4, 13, 13, 17, 31, 284, DateTimeKind.Unspecified).AddTicks(2965), new TimeSpan(0, 1, 0, 0, 0)), "Small Plastic Salad" },
                    { 974, new DateTimeOffset(new DateTime(2023, 6, 30, 11, 3, 7, 543, DateTimeKind.Unspecified).AddTicks(2391), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Rubber Towels" },
                    { 975, new DateTimeOffset(new DateTime(2023, 9, 16, 8, 48, 43, 802, DateTimeKind.Unspecified).AddTicks(1817), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Fresh Ball" },
                    { 976, new DateTimeOffset(new DateTime(2023, 12, 3, 6, 34, 20, 61, DateTimeKind.Unspecified).AddTicks(1243), new TimeSpan(0, 1, 0, 0, 0)), "Generic Concrete Chips" },
                    { 977, new DateTimeOffset(new DateTime(2023, 2, 19, 4, 19, 56, 320, DateTimeKind.Unspecified).AddTicks(669), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Granite Chicken" },
                    { 978, new DateTimeOffset(new DateTime(2023, 5, 8, 2, 5, 32, 579, DateTimeKind.Unspecified).AddTicks(95), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Soft Shirt" },
                    { 979, new DateTimeOffset(new DateTime(2023, 7, 24, 23, 51, 8, 837, DateTimeKind.Unspecified).AddTicks(9521), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Steel Car" },
                    { 980, new DateTimeOffset(new DateTime(2023, 10, 10, 21, 36, 45, 96, DateTimeKind.Unspecified).AddTicks(8947), new TimeSpan(0, 1, 0, 0, 0)), "Handcrafted Cotton Cheese" },
                    { 981, new DateTimeOffset(new DateTime(2023, 12, 27, 19, 22, 21, 355, DateTimeKind.Unspecified).AddTicks(8373), new TimeSpan(0, 1, 0, 0, 0)), "Intelligent Metal Shoes" },
                    { 982, new DateTimeOffset(new DateTime(2023, 3, 15, 17, 7, 57, 614, DateTimeKind.Unspecified).AddTicks(7799), new TimeSpan(0, 1, 0, 0, 0)), "Handmade Frozen Mouse" },
                    { 983, new DateTimeOffset(new DateTime(2023, 6, 1, 14, 53, 33, 873, DateTimeKind.Unspecified).AddTicks(7226), new TimeSpan(0, 1, 0, 0, 0)), "Gorgeous Concrete Pizza" },
                    { 984, new DateTimeOffset(new DateTime(2023, 8, 18, 12, 39, 10, 132, DateTimeKind.Unspecified).AddTicks(6652), new TimeSpan(0, 1, 0, 0, 0)), "Licensed Granite Towels" },
                    { 985, new DateTimeOffset(new DateTime(2023, 11, 4, 10, 24, 46, 391, DateTimeKind.Unspecified).AddTicks(6078), new TimeSpan(0, 1, 0, 0, 0)), "Incredible Fresh Ball" },
                    { 986, new DateTimeOffset(new DateTime(2023, 1, 21, 8, 10, 22, 650, DateTimeKind.Unspecified).AddTicks(5504), new TimeSpan(0, 1, 0, 0, 0)), "Refined Wooden Chips" },
                    { 987, new DateTimeOffset(new DateTime(2023, 4, 9, 5, 55, 58, 909, DateTimeKind.Unspecified).AddTicks(4930), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Cotton Chicken" },
                    { 988, new DateTimeOffset(new DateTime(2023, 6, 26, 3, 41, 35, 168, DateTimeKind.Unspecified).AddTicks(4356), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Metal Pants" },
                    { 989, new DateTimeOffset(new DateTime(2023, 9, 12, 1, 27, 11, 427, DateTimeKind.Unspecified).AddTicks(3782), new TimeSpan(0, 1, 0, 0, 0)), "Fantastic Steel Car" },
                    { 990, new DateTimeOffset(new DateTime(2023, 11, 28, 23, 12, 47, 686, DateTimeKind.Unspecified).AddTicks(3208), new TimeSpan(0, 1, 0, 0, 0)), "Unbranded Plastic Cheese" },
                    { 991, new DateTimeOffset(new DateTime(2023, 2, 14, 20, 58, 23, 945, DateTimeKind.Unspecified).AddTicks(2634), new TimeSpan(0, 1, 0, 0, 0)), "Practical Rubber Shoes" },
                    { 992, new DateTimeOffset(new DateTime(2023, 5, 3, 18, 44, 0, 204, DateTimeKind.Unspecified).AddTicks(2060), new TimeSpan(0, 1, 0, 0, 0)), "Tasty Fresh Keyboard" },
                    { 993, new DateTimeOffset(new DateTime(2023, 7, 20, 16, 29, 36, 463, DateTimeKind.Unspecified).AddTicks(1486), new TimeSpan(0, 1, 0, 0, 0)), "Sleek Concrete Pizza" },
                    { 994, new DateTimeOffset(new DateTime(2023, 10, 6, 14, 15, 12, 722, DateTimeKind.Unspecified).AddTicks(912), new TimeSpan(0, 1, 0, 0, 0)), "Small Granite Towels" },
                    { 995, new DateTimeOffset(new DateTime(2023, 12, 23, 12, 0, 48, 981, DateTimeKind.Unspecified).AddTicks(338), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Soft Ball" },
                    { 996, new DateTimeOffset(new DateTime(2023, 3, 11, 9, 46, 25, 239, DateTimeKind.Unspecified).AddTicks(9764), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Steel Chips" },
                    { 997, new DateTimeOffset(new DateTime(2023, 5, 28, 7, 32, 1, 498, DateTimeKind.Unspecified).AddTicks(9190), new TimeSpan(0, 1, 0, 0, 0)), "Awesome Plastic Tuna" },
                    { 998, new DateTimeOffset(new DateTime(2023, 8, 14, 5, 17, 37, 757, DateTimeKind.Unspecified).AddTicks(8616), new TimeSpan(0, 1, 0, 0, 0)), "Ergonomic Metal Pants" },
                    { 999, new DateTimeOffset(new DateTime(2023, 10, 31, 3, 3, 14, 16, DateTimeKind.Unspecified).AddTicks(8042), new TimeSpan(0, 1, 0, 0, 0)), "Generic Frozen Car" },
                    { 1000, new DateTimeOffset(new DateTime(2023, 1, 17, 0, 48, 50, 275, DateTimeKind.Unspecified).AddTicks(7468), new TimeSpan(0, 1, 0, 0, 0)), "Rustic Concrete Cheese" }
                });

            migrationBuilder.InsertData(
                table: "ProductCategory",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Computers" },
                    { 2, "Shoes" },
                    { 3, "Home" },
                    { 4, "Jewelery" },
                    { 5, "Garden" },
                    { 6, "Sports" },
                    { 7, "Tools" },
                    { 8, "Outdoors" }
                });

            migrationBuilder.InsertData(
                table: "ProductCategory",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 9, "Grocery" },
                    { 10, "Automotive" },
                    { 11, "Health" },
                    { 12, "Industrial" },
                    { 13, "Beauty" },
                    { 14, "Books" },
                    { 15, "Toys" },
                    { 16, "Movies" },
                    { 17, "Kids" },
                    { 18, "Music" },
                    { 19, "Baby" },
                    { 20, "Games" },
                    { 21, "Clothing" },
                    { 22, "Electronics" },
                    { 23, "Shoes" },
                    { 24, "Computers" },
                    { 25, "Jewelery" },
                    { 26, "Home" },
                    { 27, "Sports" },
                    { 28, "Garden" },
                    { 29, "Outdoors" },
                    { 30, "Tools" },
                    { 31, "Automotive" },
                    { 32, "Grocery" },
                    { 33, "Industrial" },
                    { 34, "Health" },
                    { 35, "Books" },
                    { 36, "Beauty" },
                    { 37, "Movies" },
                    { 38, "Toys" },
                    { 39, "Music" },
                    { 40, "Kids" },
                    { 41, "Games" },
                    { 42, "Baby" },
                    { 43, "Electronics" },
                    { 44, "Clothing" },
                    { 45, "Computers" },
                    { 46, "Shoes" },
                    { 47, "Home" },
                    { 48, "Jewelery" },
                    { 49, "Garden" },
                    { 50, "Sports" }
                });

            migrationBuilder.InsertData(
                table: "ProductProductCategory",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 33, 1 },
                    { 37, 2 },
                    { 16, 3 },
                    { 27, 3 },
                    { 10, 5 },
                    { 49, 6 },
                    { 32, 8 },
                    { 42, 8 },
                    { 25, 10 },
                    { 15, 11 },
                    { 5, 12 },
                    { 8, 13 },
                    { 48, 13 },
                    { 38, 14 },
                    { 41, 15 },
                    { 31, 16 },
                    { 21, 17 },
                    { 14, 18 },
                    { 24, 18 },
                    { 4, 19 },
                    { 47, 21 },
                    { 37, 22 },
                    { 30, 23 },
                    { 20, 24 },
                    { 13, 26 },
                    { 3, 27 },
                    { 42, 27 },
                    { 46, 28 },
                    { 36, 29 },
                    { 25, 30 },
                    { 29, 31 },
                    { 8, 32 },
                    { 18, 32 },
                    { 1, 34 },
                    { 41, 35 },
                    { 24, 37 },
                    { 34, 37 },
                    { 17, 39 },
                    { 7, 40 },
                    { 47, 41 },
                    { 40, 42 },
                    { 50, 42 }
                });

            migrationBuilder.InsertData(
                table: "ProductProductCategory",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 30, 43 },
                    { 33, 44 },
                    { 23, 45 },
                    { 13, 46 },
                    { 6, 47 },
                    { 16, 47 },
                    { 46, 48 },
                    { 39, 50 },
                    { 29, 51 },
                    { 22, 52 },
                    { 12, 53 },
                    { 5, 55 },
                    { 34, 56 },
                    { 44, 56 },
                    { 38, 57 },
                    { 27, 58 },
                    { 17, 59 },
                    { 21, 60 },
                    { 10, 61 },
                    { 50, 61 },
                    { 4, 62 },
                    { 43, 63 },
                    { 33, 64 },
                    { 16, 66 },
                    { 26, 66 },
                    { 9, 68 },
                    { 49, 69 },
                    { 32, 71 },
                    { 42, 71 },
                    { 22, 72 },
                    { 25, 73 },
                    { 15, 74 },
                    { 5, 75 },
                    { 8, 76 },
                    { 48, 76 },
                    { 38, 77 },
                    { 31, 79 },
                    { 20, 80 },
                    { 14, 81 },
                    { 3, 82 },
                    { 47, 84 },
                    { 36, 85 }
                });

            migrationBuilder.InsertData(
                table: "ProductProductCategory",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 26, 86 },
                    { 30, 86 },
                    { 19, 87 },
                    { 9, 88 },
                    { 13, 89 },
                    { 2, 90 },
                    { 42, 91 },
                    { 46, 91 },
                    { 35, 92 },
                    { 25, 93 },
                    { 18, 95 },
                    { 8, 96 },
                    { 1, 97 },
                    { 41, 98 },
                    { 34, 100 },
                    { 14, 101 },
                    { 24, 101 },
                    { 17, 102 },
                    { 7, 103 },
                    { 46, 104 },
                    { 50, 105 },
                    { 29, 106 },
                    { 40, 106 },
                    { 33, 107 },
                    { 23, 108 },
                    { 12, 109 },
                    { 6, 111 },
                    { 45, 111 },
                    { 39, 113 },
                    { 28, 114 },
                    { 11, 116 },
                    { 22, 116 },
                    { 1, 117 },
                    { 4, 118 },
                    { 44, 119 },
                    { 34, 120 },
                    { 37, 120 },
                    { 27, 121 },
                    { 17, 122 },
                    { 10, 124 },
                    { 50, 125 },
                    { 43, 126 }
                });

            migrationBuilder.InsertData(
                table: "ProductProductCategory",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 33, 127 },
                    { 26, 129 },
                    { 5, 130 },
                    { 16, 130 },
                    { 9, 131 },
                    { 49, 132 },
                    { 38, 133 },
                    { 42, 134 },
                    { 21, 135 },
                    { 32, 135 },
                    { 25, 136 },
                    { 15, 137 },
                    { 4, 138 },
                    { 37, 140 },
                    { 48, 140 },
                    { 30, 142 },
                    { 20, 143 },
                    { 3, 145 },
                    { 13, 145 },
                    { 43, 146 },
                    { 46, 147 },
                    { 36, 148 },
                    { 26, 149 },
                    { 19, 150 },
                    { 29, 150 },
                    { 9, 151 },
                    { 12, 152 },
                    { 2, 153 },
                    { 42, 154 },
                    { 35, 155 },
                    { 25, 156 },
                    { 18, 158 },
                    { 8, 159 },
                    { 1, 160 },
                    { 41, 161 },
                    { 30, 162 },
                    { 34, 163 },
                    { 13, 164 },
                    { 24, 164 },
                    { 17, 165 },
                    { 6, 166 },
                    { 46, 167 }
                });

            migrationBuilder.InsertData(
                table: "ProductProductCategory",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 29, 169 },
                    { 39, 169 },
                    { 22, 171 },
                    { 12, 172 },
                    { 5, 174 },
                    { 45, 174 },
                    { 35, 175 },
                    { 38, 176 },
                    { 28, 177 },
                    { 18, 178 },
                    { 11, 179 },
                    { 21, 179 },
                    { 1, 180 },
                    { 4, 181 },
                    { 44, 182 },
                    { 34, 183 },
                    { 27, 184 },
                    { 17, 185 },
                    { 10, 187 },
                    { 50, 188 },
                    { 43, 189 },
                    { 32, 190 },
                    { 22, 191 },
                    { 26, 192 },
                    { 15, 193 },
                    { 5, 194 },
                    { 9, 194 },
                    { 48, 195 },
                    { 38, 196 },
                    { 31, 198 },
                    { 21, 199 },
                    { 14, 200 },
                    { 4, 201 },
                    { 47, 203 },
                    { 37, 204 },
                    { 30, 205 },
                    { 20, 206 },
                    { 10, 207 },
                    { 13, 208 },
                    { 3, 209 },
                    { 43, 209 },
                    { 46, 210 }
                });

            migrationBuilder.InsertData(
                table: "ProductProductCategory",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 36, 211 },
                    { 26, 212 },
                    { 19, 213 },
                    { 9, 214 },
                    { 2, 216 },
                    { 41, 217 },
                    { 35, 218 },
                    { 24, 219 },
                    { 14, 220 },
                    { 18, 221 },
                    { 7, 222 },
                    { 1, 223 },
                    { 47, 223 },
                    { 40, 224 },
                    { 30, 225 },
                    { 34, 226 },
                    { 23, 227 },
                    { 13, 228 },
                    { 6, 229 },
                    { 46, 230 },
                    { 39, 232 },
                    { 29, 233 },
                    { 22, 234 },
                    { 12, 235 },
                    { 2, 236 },
                    { 5, 237 },
                    { 35, 238 },
                    { 45, 238 },
                    { 38, 239 },
                    { 28, 240 },
                    { 17, 241 },
                    { 11, 243 },
                    { 50, 243 },
                    { 44, 245 },
                    { 33, 246 },
                    { 16, 248 },
                    { 27, 248 },
                    { 6, 249 },
                    { 10, 250 },
                    { 49, 251 },
                    { 39, 252 },
                    { 32, 253 }
                });

            migrationBuilder.InsertData(
                table: "ProductProductCategory",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 43, 253 },
                    { 22, 254 },
                    { 25, 255 },
                    { 15, 256 },
                    { 5, 257 },
                    { 48, 258 },
                    { 38, 259 },
                    { 31, 261 },
                    { 21, 262 },
                    { 14, 263 },
                    { 4, 264 },
                    { 43, 265 },
                    { 47, 266 },
                    { 26, 267 },
                    { 37, 267 },
                    { 30, 268 },
                    { 20, 269 },
                    { 9, 270 },
                    { 13, 271 },
                    { 3, 272 },
                    { 42, 272 },
                    { 36, 274 },
                    { 25, 275 },
                    { 8, 277 },
                    { 19, 277 },
                    { 1, 279 },
                    { 41, 280 },
                    { 31, 281 },
                    { 24, 282 },
                    { 34, 282 },
                    { 14, 283 },
                    { 17, 284 },
                    { 7, 285 },
                    { 47, 286 },
                    { 40, 287 },
                    { 30, 288 },
                    { 23, 290 },
                    { 13, 291 },
                    { 6, 292 },
                    { 46, 293 },
                    { 35, 294 },
                    { 39, 295 }
                });

            migrationBuilder.InsertData(
                table: "ProductProductCategory",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 29, 296 },
                    { 18, 297 },
                    { 22, 297 },
                    { 12, 298 },
                    { 1, 299 },
                    { 5, 300 },
                    { 45, 301 },
                    { 34, 302 },
                    { 27, 303 },
                    { 17, 304 },
                    { 10, 306 },
                    { 50, 306 },
                    { 43, 308 },
                    { 33, 309 },
                    { 23, 310 },
                    { 16, 311 },
                    { 26, 311 },
                    { 6, 312 },
                    { 9, 313 },
                    { 49, 314 },
                    { 39, 315 },
                    { 32, 316 },
                    { 42, 316 },
                    { 22, 317 },
                    { 15, 319 },
                    { 5, 320 },
                    { 48, 321 },
                    { 38, 322 },
                    { 31, 324 },
                    { 21, 325 },
                    { 10, 326 },
                    { 14, 326 },
                    { 3, 327 },
                    { 43, 328 },
                    { 47, 329 },
                    { 36, 330 },
                    { 26, 331 },
                    { 19, 332 },
                    { 9, 333 },
                    { 2, 335 },
                    { 42, 336 },
                    { 35, 337 }
                });

            migrationBuilder.InsertData(
                table: "ProductProductCategory",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 25, 338 },
                    { 15, 339 },
                    { 18, 340 },
                    { 8, 341 },
                    { 48, 341 },
                    { 1, 342 },
                    { 41, 343 },
                    { 31, 344 },
                    { 34, 345 },
                    { 14, 346 },
                    { 24, 346 },
                    { 7, 348 },
                    { 47, 349 },
                    { 29, 351 },
                    { 40, 351 },
                    { 23, 353 },
                    { 12, 354 },
                    { 2, 355 },
                    { 6, 356 },
                    { 45, 356 },
                    { 35, 357 },
                    { 39, 358 },
                    { 28, 359 },
                    { 18, 360 },
                    { 11, 361 },
                    { 22, 361 },
                    { 1, 362 },
                    { 44, 364 },
                    { 34, 365 },
                    { 27, 366 },
                    { 17, 367 },
                    { 10, 369 },
                    { 40, 370 },
                    { 50, 370 },
                    { 43, 371 },
                    { 33, 372 },
                    { 23, 373 },
                    { 26, 374 },
                    { 5, 375 },
                    { 16, 375 },
                    { 49, 377 },
                    { 38, 378 }
                });

            migrationBuilder.InsertData(
                table: "ProductProductCategory",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 21, 380 },
                    { 32, 380 },
                    { 15, 382 },
                    { 4, 383 },
                    { 44, 384 },
                    { 37, 385 },
                    { 48, 385 },
                    { 27, 386 },
                    { 31, 387 },
                    { 20, 388 },
                    { 10, 389 },
                    { 3, 390 },
                    { 13, 390 },
                    { 43, 391 },
                    { 36, 393 },
                    { 26, 394 },
                    { 19, 395 },
                    { 9, 396 },
                    { 2, 398 },
                    { 42, 399 },
                    { 31, 400 },
                    { 35, 400 },
                    { 25, 401 },
                    { 14, 402 },
                    { 18, 403 },
                    { 8, 404 },
                    { 47, 404 },
                    { 1, 405 },
                    { 41, 406 },
                    { 30, 407 },
                    { 13, 409 },
                    { 24, 409 },
                    { 7, 411 },
                    { 46, 412 },
                    { 29, 414 },
                    { 39, 414 },
                    { 19, 415 },
                    { 22, 416 },
                    { 12, 417 },
                    { 2, 418 },
                    { 5, 419 },
                    { 45, 419 }
                });

            migrationBuilder.InsertData(
                table: "ProductProductCategory",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 35, 420 },
                    { 28, 422 },
                    { 18, 423 },
                    { 11, 424 },
                    { 1, 425 },
                    { 44, 427 },
                    { 34, 428 },
                    { 23, 429 },
                    { 27, 429 },
                    { 17, 430 },
                    { 6, 431 },
                    { 10, 432 },
                    { 50, 433 },
                    { 39, 434 },
                    { 43, 434 },
                    { 33, 435 },
                    { 22, 436 },
                    { 15, 438 },
                    { 5, 439 },
                    { 48, 440 },
                    { 38, 441 },
                    { 31, 443 },
                    { 11, 444 },
                    { 21, 444 },
                    { 14, 445 },
                    { 4, 446 },
                    { 44, 447 },
                    { 47, 448 },
                    { 27, 449 },
                    { 37, 449 },
                    { 30, 450 },
                    { 20, 451 },
                    { 10, 452 },
                    { 3, 454 },
                    { 43, 454 },
                    { 36, 456 },
                    { 26, 457 },
                    { 9, 459 },
                    { 19, 459 },
                    { 48, 460 },
                    { 2, 461 },
                    { 42, 462 }
                });

            migrationBuilder.InsertData(
                table: "ProductProductCategory",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 31, 463 },
                    { 24, 464 },
                    { 35, 464 },
                    { 14, 465 },
                    { 7, 467 },
                    { 47, 468 },
                    { 40, 469 },
                    { 30, 470 },
                    { 23, 472 },
                    { 3, 473 },
                    { 13, 473 },
                    { 6, 474 },
                    { 46, 475 },
                    { 36, 476 },
                    { 39, 477 },
                    { 19, 478 },
                    { 29, 478 },
                    { 22, 479 },
                    { 12, 480 },
                    { 2, 481 },
                    { 35, 483 },
                    { 45, 483 },
                    { 28, 485 },
                    { 18, 486 },
                    { 11, 488 },
                    { 50, 488 },
                    { 40, 489 },
                    { 44, 490 },
                    { 33, 491 },
                    { 23, 492 },
                    { 16, 493 },
                    { 27, 493 },
                    { 6, 494 },
                    { 10, 495 },
                    { 49, 496 },
                    { 39, 497 },
                    { 32, 498 },
                    { 22, 499 },
                    { 15, 501 },
                    { 5, 502 },
                    { 48, 503 },
                    { 38, 504 }
                });

            migrationBuilder.InsertData(
                table: "ProductProductCategory",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 28, 505 },
                    { 31, 506 },
                    { 11, 507 },
                    { 21, 507 },
                    { 14, 508 },
                    { 4, 509 },
                    { 44, 510 },
                    { 26, 512 },
                    { 37, 512 },
                    { 20, 514 },
                    { 9, 515 },
                    { 3, 517 },
                    { 42, 517 },
                    { 32, 518 },
                    { 36, 519 },
                    { 25, 520 },
                    { 15, 521 },
                    { 8, 522 },
                    { 19, 522 },
                    { 48, 523 },
                    { 2, 524 },
                    { 41, 525 },
                    { 31, 526 },
                    { 24, 527 },
                    { 14, 528 },
                    { 7, 530 },
                    { 47, 531 },
                    { 40, 532 },
                    { 30, 533 },
                    { 20, 534 },
                    { 23, 535 },
                    { 13, 536 },
                    { 2, 537 },
                    { 6, 537 },
                    { 46, 538 },
                    { 35, 539 },
                    { 39, 540 },
                    { 29, 541 },
                    { 18, 542 },
                    { 12, 543 },
                    { 1, 544 },
                    { 45, 546 }
                });

            migrationBuilder.InsertData(
                table: "ProductProductCategory",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 34, 547 },
                    { 28, 548 },
                    { 17, 549 },
                    { 7, 550 },
                    { 10, 551 },
                    { 40, 552 },
                    { 50, 552 },
                    { 43, 553 },
                    { 33, 554 },
                    { 23, 555 },
                    { 6, 557 },
                    { 16, 557 },
                    { 49, 559 },
                    { 39, 560 },
                    { 22, 562 },
                    { 32, 562 },
                    { 11, 563 },
                    { 15, 564 },
                    { 5, 565 },
                    { 44, 566 },
                    { 38, 567 },
                    { 48, 567 },
                    { 27, 568 },
                    { 31, 569 },
                    { 21, 570 },
                    { 10, 571 },
                    { 4, 572 },
                    { 43, 573 },
                    { 36, 575 },
                    { 26, 576 },
                    { 19, 577 },
                    { 9, 578 },
                    { 49, 579 },
                    { 2, 580 },
                    { 32, 581 },
                    { 42, 581 },
                    { 35, 582 },
                    { 25, 583 },
                    { 15, 584 },
                    { 18, 585 },
                    { 8, 586 },
                    { 48, 586 }
                });

            migrationBuilder.InsertData(
                table: "ProductProductCategory",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 41, 588 },
                    { 31, 589 },
                    { 14, 591 },
                    { 24, 591 },
                    { 7, 593 },
                    { 47, 594 },
                    { 36, 595 },
                    { 30, 596 },
                    { 40, 596 },
                    { 19, 597 },
                    { 23, 598 },
                    { 12, 599 },
                    { 2, 600 },
                    { 45, 601 },
                    { 35, 602 },
                    { 28, 604 },
                    { 18, 605 },
                    { 11, 606 },
                    { 1, 607 },
                    { 41, 608 },
                    { 44, 609 },
                    { 24, 610 },
                    { 34, 610 },
                    { 27, 611 },
                    { 17, 612 },
                    { 7, 613 },
                    { 10, 614 },
                    { 40, 615 },
                    { 50, 615 },
                    { 33, 617 },
                    { 23, 618 },
                    { 6, 620 },
                    { 16, 620 },
                    { 49, 622 },
                    { 38, 623 },
                    { 28, 624 },
                    { 21, 625 },
                    { 32, 625 },
                    { 11, 626 },
                    { 15, 627 },
                    { 4, 628 },
                    { 44, 629 }
                });

            migrationBuilder.InsertData(
                table: "ProductProductCategory",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 37, 630 },
                    { 48, 630 },
                    { 27, 631 },
                    { 20, 633 },
                    { 10, 634 },
                    { 3, 635 },
                    { 43, 636 },
                    { 36, 638 },
                    { 26, 639 },
                    { 16, 640 },
                    { 19, 640 },
                    { 9, 641 },
                    { 49, 642 },
                    { 2, 643 },
                    { 42, 644 },
                    { 32, 645 },
                    { 25, 646 },
                    { 14, 647 },
                    { 8, 649 },
                    { 47, 650 },
                    { 41, 651 },
                    { 30, 652 },
                    { 20, 653 },
                    { 24, 654 },
                    { 3, 655 },
                    { 13, 655 },
                    { 7, 656 },
                    { 46, 657 },
                    { 36, 658 },
                    { 40, 659 },
                    { 19, 660 },
                    { 29, 660 },
                    { 12, 662 },
                    { 2, 663 },
                    { 45, 664 },
                    { 35, 665 },
                    { 28, 667 },
                    { 18, 668 },
                    { 8, 669 },
                    { 11, 669 },
                    { 1, 670 },
                    { 40, 671 }
                });

            migrationBuilder.InsertData(
                table: "ProductProductCategory",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 44, 672 },
                    { 34, 673 },
                    { 23, 674 },
                    { 17, 675 },
                    { 6, 676 },
                    { 50, 678 },
                    { 39, 679 },
                    { 33, 680 },
                    { 22, 681 },
                    { 16, 683 },
                    { 5, 684 },
                    { 45, 684 },
                    { 48, 685 },
                    { 38, 686 },
                    { 28, 687 },
                    { 31, 688 },
                    { 11, 689 },
                    { 21, 689 },
                    { 4, 691 },
                    { 44, 692 },
                    { 27, 694 },
                    { 37, 694 },
                    { 20, 696 },
                    { 10, 697 },
                    { 49, 698 },
                    { 3, 699 },
                    { 43, 699 },
                    { 32, 700 },
                    { 36, 701 },
                    { 26, 702 },
                    { 15, 703 },
                    { 9, 704 },
                    { 19, 704 },
                    { 48, 705 },
                    { 42, 707 },
                    { 31, 708 },
                    { 25, 709 },
                    { 14, 710 },
                    { 7, 712 },
                    { 37, 713 },
                    { 47, 713 },
                    { 40, 714 }
                });

            migrationBuilder.InsertData(
                table: "ProductProductCategory",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 30, 715 },
                    { 20, 716 },
                    { 23, 717 },
                    { 3, 718 },
                    { 13, 718 },
                    { 46, 720 },
                    { 36, 721 },
                    { 19, 723 },
                    { 29, 723 },
                    { 12, 725 },
                    { 2, 726 },
                    { 35, 728 },
                    { 45, 728 },
                    { 24, 729 },
                    { 28, 730 },
                    { 18, 731 },
                    { 7, 732 },
                    { 1, 733 },
                    { 11, 733 },
                    { 40, 734 },
                    { 33, 736 },
                    { 23, 737 },
                    { 16, 738 },
                    { 6, 739 },
                    { 49, 741 },
                    { 39, 742 },
                    { 29, 743 },
                    { 32, 743 },
                    { 22, 744 },
                    { 12, 745 },
                    { 15, 746 },
                    { 5, 747 },
                    { 45, 748 },
                    { 48, 748 },
                    { 38, 749 },
                    { 28, 750 },
                    { 21, 752 },
                    { 11, 753 },
                    { 4, 754 },
                    { 44, 755 },
                    { 37, 757 },
                    { 16, 758 }
                });

            migrationBuilder.InsertData(
                table: "ProductProductCategory",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 27, 758 },
                    { 20, 759 },
                    { 9, 760 },
                    { 49, 761 },
                    { 3, 762 },
                    { 42, 762 },
                    { 32, 763 },
                    { 25, 765 },
                    { 15, 766 },
                    { 8, 767 },
                    { 48, 768 },
                    { 41, 770 },
                    { 31, 771 },
                    { 21, 772 },
                    { 24, 772 },
                    { 14, 773 },
                    { 4, 774 },
                    { 7, 775 },
                    { 47, 776 },
                    { 37, 777 },
                    { 40, 777 },
                    { 30, 778 },
                    { 20, 779 },
                    { 13, 781 },
                    { 3, 782 },
                    { 46, 783 },
                    { 35, 784 },
                    { 29, 786 },
                    { 8, 787 },
                    { 18, 787 },
                    { 12, 788 },
                    { 1, 789 },
                    { 41, 790 },
                    { 45, 791 },
                    { 24, 792 },
                    { 34, 792 },
                    { 28, 793 },
                    { 17, 794 },
                    { 7, 795 },
                    { 40, 797 },
                    { 50, 797 },
                    { 33, 799 }
                });

            migrationBuilder.InsertData(
                table: "ProductProductCategory",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 23, 800 },
                    { 6, 802 },
                    { 16, 802 },
                    { 46, 803 },
                    { 49, 804 },
                    { 39, 805 },
                    { 29, 806 },
                    { 22, 807 },
                    { 32, 807 },
                    { 11, 808 },
                    { 5, 810 },
                    { 44, 811 },
                    { 38, 812 },
                    { 27, 813 },
                    { 21, 815 },
                    { 10, 816 },
                    { 50, 816 },
                    { 4, 817 },
                    { 43, 818 },
                    { 33, 819 },
                    { 37, 820 },
                    { 16, 821 },
                    { 26, 821 },
                    { 19, 822 },
                    { 9, 823 },
                    { 49, 824 },
                    { 32, 826 },
                    { 42, 826 },
                    { 25, 828 },
                    { 15, 829 },
                    { 8, 831 },
                    { 48, 831 },
                    { 37, 832 },
                    { 41, 833 },
                    { 31, 834 },
                    { 20, 835 },
                    { 14, 836 },
                    { 24, 836 },
                    { 3, 837 },
                    { 7, 838 },
                    { 47, 839 },
                    { 36, 840 }
                });

            migrationBuilder.InsertData(
                table: "ProductProductCategory",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 30, 841 },
                    { 19, 842 },
                    { 13, 844 },
                    { 2, 845 },
                    { 45, 846 },
                    { 35, 847 },
                    { 25, 848 },
                    { 28, 849 },
                    { 18, 850 },
                    { 8, 851 },
                    { 11, 851 },
                    { 1, 852 },
                    { 41, 853 },
                    { 24, 855 },
                    { 34, 855 },
                    { 17, 857 },
                    { 7, 858 },
                    { 40, 860 },
                    { 50, 860 },
                    { 29, 861 },
                    { 33, 862 },
                    { 23, 863 },
                    { 12, 864 },
                    { 6, 865 },
                    { 16, 865 },
                    { 45, 866 },
                    { 49, 867 },
                    { 39, 868 },
                    { 28, 869 },
                    { 21, 870 },
                    { 11, 871 },
                    { 4, 873 },
                    { 44, 874 },
                    { 37, 875 },
                    { 27, 876 },
                    { 17, 877 },
                    { 20, 878 },
                    { 10, 879 },
                    { 3, 880 },
                    { 50, 880 },
                    { 43, 881 },
                    { 33, 882 }
                });

            migrationBuilder.InsertData(
                table: "ProductProductCategory",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 36, 883 },
                    { 26, 884 },
                    { 16, 885 },
                    { 9, 886 },
                    { 49, 887 },
                    { 42, 889 },
                    { 32, 890 },
                    { 25, 891 },
                    { 15, 892 },
                    { 4, 893 },
                    { 8, 894 },
                    { 37, 895 },
                    { 47, 895 },
                    { 41, 896 },
                    { 30, 897 },
                    { 20, 898 },
                    { 3, 900 },
                    { 13, 900 },
                    { 46, 902 },
                    { 36, 903 },
                    { 19, 905 },
                    { 29, 905 },
                    { 9, 906 },
                    { 12, 907 },
                    { 2, 908 },
                    { 42, 909 },
                    { 35, 910 },
                    { 45, 910 },
                    { 25, 911 },
                    { 28, 912 },
                    { 18, 913 },
                    { 8, 914 },
                    { 1, 915 },
                    { 41, 916 },
                    { 34, 918 },
                    { 23, 919 },
                    { 17, 920 },
                    { 6, 921 },
                    { 46, 922 },
                    { 50, 923 },
                    { 29, 924 },
                    { 39, 924 }
                });

            migrationBuilder.InsertData(
                table: "ProductProductCategory",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 33, 925 },
                    { 22, 926 },
                    { 12, 927 },
                    { 16, 928 },
                    { 5, 929 },
                    { 45, 929 },
                    { 38, 931 },
                    { 28, 932 },
                    { 11, 934 },
                    { 21, 934 },
                    { 4, 936 },
                    { 44, 937 },
                    { 34, 938 },
                    { 27, 939 },
                    { 37, 939 },
                    { 17, 940 },
                    { 20, 941 },
                    { 10, 942 },
                    { 50, 943 },
                    { 43, 944 },
                    { 32, 945 },
                    { 26, 947 },
                    { 15, 948 },
                    { 9, 949 },
                    { 48, 950 },
                    { 38, 951 },
                    { 42, 952 },
                    { 21, 953 },
                    { 31, 953 },
                    { 25, 954 },
                    { 14, 955 },
                    { 4, 956 },
                    { 7, 957 },
                    { 37, 958 },
                    { 47, 958 },
                    { 30, 960 },
                    { 20, 961 },
                    { 3, 963 },
                    { 13, 963 },
                    { 46, 965 },
                    { 36, 966 },
                    { 26, 967 }
                });

            migrationBuilder.InsertData(
                table: "ProductProductCategory",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 19, 968 },
                    { 29, 968 },
                    { 8, 969 },
                    { 12, 970 },
                    { 2, 971 },
                    { 41, 972 },
                    { 35, 973 },
                    { 45, 973 },
                    { 24, 974 },
                    { 18, 976 },
                    { 7, 977 },
                    { 1, 978 },
                    { 40, 979 },
                    { 34, 981 },
                    { 23, 982 },
                    { 13, 983 },
                    { 16, 983 },
                    { 6, 984 },
                    { 46, 985 },
                    { 49, 986 },
                    { 39, 987 },
                    { 29, 988 },
                    { 22, 989 },
                    { 12, 990 },
                    { 5, 992 },
                    { 45, 993 },
                    { 38, 994 },
                    { 28, 995 },
                    { 17, 996 },
                    { 21, 997 },
                    { 11, 998 },
                    { 50, 998 },
                    { 4, 999 },
                    { 44, 1000 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 99);

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
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 157);

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
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 260);

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
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 408);

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
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 500);

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
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 603);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 616);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 619);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 621);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 632);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 637);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 648);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 661);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 666);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 677);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 682);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 690);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 693);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 695);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 706);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 711);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 719);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 722);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 724);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 727);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 735);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 740);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 751);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 756);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 764);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 769);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 780);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 785);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 796);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 798);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 801);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 809);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 814);

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
                keyValue: 843);

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
                keyValue: 859);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 872);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 888);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 899);

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
                keyValue: 917);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 930);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 933);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 935);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 946);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 959);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 962);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 964);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 975);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 980);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 991);

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 33, 1 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 37, 2 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 16, 3 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 27, 3 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 10, 5 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 49, 6 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 32, 8 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 42, 8 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 25, 10 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 15, 11 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 12 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 8, 13 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 48, 13 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 38, 14 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 41, 15 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 31, 16 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 21, 17 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 14, 18 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 24, 18 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 19 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 47, 21 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 37, 22 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 30, 23 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 20, 24 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 13, 26 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 27 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 42, 27 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 46, 28 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 36, 29 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 25, 30 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 29, 31 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 8, 32 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 18, 32 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 34 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 41, 35 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 24, 37 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 34, 37 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 17, 39 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 7, 40 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 47, 41 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 40, 42 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 50, 42 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 30, 43 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 33, 44 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 23, 45 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 13, 46 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 6, 47 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 16, 47 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 46, 48 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 39, 50 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 29, 51 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 22, 52 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 53 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 55 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 34, 56 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 44, 56 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 38, 57 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 27, 58 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 17, 59 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 21, 60 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 10, 61 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 50, 61 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 62 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 43, 63 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 33, 64 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 16, 66 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 26, 66 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 9, 68 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 49, 69 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 32, 71 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 42, 71 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 22, 72 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 25, 73 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 15, 74 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 75 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 8, 76 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 48, 76 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 38, 77 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 31, 79 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 20, 80 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 14, 81 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 82 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 47, 84 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 36, 85 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 26, 86 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 30, 86 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 19, 87 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 9, 88 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 13, 89 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 90 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 42, 91 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 46, 91 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 35, 92 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 25, 93 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 18, 95 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 8, 96 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 97 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 41, 98 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 34, 100 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 14, 101 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 24, 101 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 17, 102 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 7, 103 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 46, 104 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 50, 105 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 29, 106 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 40, 106 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 33, 107 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 23, 108 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 109 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 6, 111 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 45, 111 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 39, 113 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 28, 114 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 11, 116 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 22, 116 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 117 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 118 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 44, 119 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 34, 120 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 37, 120 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 27, 121 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 17, 122 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 10, 124 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 50, 125 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 43, 126 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 33, 127 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 26, 129 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 130 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 16, 130 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 9, 131 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 49, 132 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 38, 133 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 42, 134 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 21, 135 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 32, 135 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 25, 136 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 15, 137 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 138 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 37, 140 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 48, 140 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 30, 142 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 20, 143 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 145 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 13, 145 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 43, 146 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 46, 147 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 36, 148 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 26, 149 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 19, 150 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 29, 150 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 9, 151 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 152 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 153 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 42, 154 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 35, 155 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 25, 156 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 18, 158 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 8, 159 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 160 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 41, 161 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 30, 162 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 34, 163 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 13, 164 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 24, 164 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 17, 165 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 6, 166 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 46, 167 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 29, 169 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 39, 169 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 22, 171 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 172 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 174 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 45, 174 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 35, 175 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 38, 176 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 28, 177 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 18, 178 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 11, 179 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 21, 179 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 180 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 181 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 44, 182 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 34, 183 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 27, 184 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 17, 185 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 10, 187 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 50, 188 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 43, 189 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 32, 190 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 22, 191 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 26, 192 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 15, 193 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 194 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 9, 194 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 48, 195 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 38, 196 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 31, 198 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 21, 199 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 14, 200 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 201 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 47, 203 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 37, 204 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 30, 205 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 20, 206 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 10, 207 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 13, 208 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 209 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 43, 209 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 46, 210 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 36, 211 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 26, 212 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 19, 213 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 9, 214 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 216 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 41, 217 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 35, 218 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 24, 219 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 14, 220 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 18, 221 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 7, 222 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 223 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 47, 223 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 40, 224 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 30, 225 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 34, 226 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 23, 227 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 13, 228 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 6, 229 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 46, 230 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 39, 232 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 29, 233 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 22, 234 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 235 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 236 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 237 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 35, 238 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 45, 238 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 38, 239 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 28, 240 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 17, 241 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 11, 243 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 50, 243 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 44, 245 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 33, 246 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 16, 248 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 27, 248 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 6, 249 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 10, 250 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 49, 251 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 39, 252 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 32, 253 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 43, 253 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 22, 254 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 25, 255 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 15, 256 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 257 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 48, 258 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 38, 259 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 31, 261 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 21, 262 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 14, 263 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 264 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 43, 265 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 47, 266 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 26, 267 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 37, 267 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 30, 268 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 20, 269 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 9, 270 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 13, 271 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 272 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 42, 272 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 36, 274 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 25, 275 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 8, 277 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 19, 277 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 279 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 41, 280 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 31, 281 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 24, 282 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 34, 282 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 14, 283 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 17, 284 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 7, 285 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 47, 286 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 40, 287 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 30, 288 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 23, 290 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 13, 291 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 6, 292 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 46, 293 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 35, 294 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 39, 295 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 29, 296 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 18, 297 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 22, 297 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 298 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 299 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 300 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 45, 301 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 34, 302 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 27, 303 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 17, 304 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 10, 306 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 50, 306 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 43, 308 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 33, 309 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 23, 310 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 16, 311 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 26, 311 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 6, 312 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 9, 313 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 49, 314 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 39, 315 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 32, 316 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 42, 316 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 22, 317 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 15, 319 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 320 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 48, 321 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 38, 322 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 31, 324 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 21, 325 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 10, 326 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 14, 326 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 327 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 43, 328 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 47, 329 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 36, 330 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 26, 331 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 19, 332 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 9, 333 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 335 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 42, 336 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 35, 337 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 25, 338 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 15, 339 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 18, 340 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 8, 341 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 48, 341 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 342 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 41, 343 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 31, 344 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 34, 345 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 14, 346 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 24, 346 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 7, 348 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 47, 349 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 29, 351 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 40, 351 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 23, 353 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 354 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 355 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 6, 356 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 45, 356 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 35, 357 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 39, 358 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 28, 359 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 18, 360 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 11, 361 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 22, 361 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 362 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 44, 364 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 34, 365 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 27, 366 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 17, 367 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 10, 369 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 40, 370 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 50, 370 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 43, 371 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 33, 372 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 23, 373 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 26, 374 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 375 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 16, 375 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 49, 377 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 38, 378 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 21, 380 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 32, 380 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 15, 382 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 383 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 44, 384 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 37, 385 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 48, 385 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 27, 386 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 31, 387 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 20, 388 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 10, 389 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 390 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 13, 390 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 43, 391 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 36, 393 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 26, 394 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 19, 395 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 9, 396 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 398 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 42, 399 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 31, 400 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 35, 400 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 25, 401 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 14, 402 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 18, 403 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 8, 404 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 47, 404 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 405 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 41, 406 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 30, 407 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 13, 409 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 24, 409 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 7, 411 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 46, 412 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 29, 414 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 39, 414 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 19, 415 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 22, 416 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 417 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 418 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 419 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 45, 419 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 35, 420 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 28, 422 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 18, 423 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 11, 424 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 425 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 44, 427 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 34, 428 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 23, 429 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 27, 429 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 17, 430 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 6, 431 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 10, 432 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 50, 433 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 39, 434 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 43, 434 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 33, 435 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 22, 436 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 15, 438 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 439 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 48, 440 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 38, 441 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 31, 443 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 11, 444 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 21, 444 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 14, 445 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 446 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 44, 447 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 47, 448 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 27, 449 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 37, 449 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 30, 450 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 20, 451 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 10, 452 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 454 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 43, 454 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 36, 456 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 26, 457 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 9, 459 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 19, 459 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 48, 460 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 461 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 42, 462 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 31, 463 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 24, 464 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 35, 464 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 14, 465 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 7, 467 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 47, 468 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 40, 469 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 30, 470 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 23, 472 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 473 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 13, 473 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 6, 474 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 46, 475 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 36, 476 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 39, 477 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 19, 478 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 29, 478 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 22, 479 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 480 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 481 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 35, 483 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 45, 483 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 28, 485 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 18, 486 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 11, 488 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 50, 488 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 40, 489 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 44, 490 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 33, 491 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 23, 492 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 16, 493 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 27, 493 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 6, 494 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 10, 495 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 49, 496 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 39, 497 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 32, 498 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 22, 499 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 15, 501 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 502 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 48, 503 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 38, 504 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 28, 505 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 31, 506 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 11, 507 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 21, 507 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 14, 508 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 509 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 44, 510 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 26, 512 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 37, 512 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 20, 514 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 9, 515 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 517 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 42, 517 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 32, 518 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 36, 519 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 25, 520 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 15, 521 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 8, 522 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 19, 522 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 48, 523 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 524 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 41, 525 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 31, 526 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 24, 527 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 14, 528 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 7, 530 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 47, 531 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 40, 532 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 30, 533 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 20, 534 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 23, 535 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 13, 536 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 537 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 6, 537 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 46, 538 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 35, 539 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 39, 540 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 29, 541 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 18, 542 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 543 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 544 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 45, 546 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 34, 547 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 28, 548 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 17, 549 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 7, 550 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 10, 551 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 40, 552 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 50, 552 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 43, 553 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 33, 554 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 23, 555 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 6, 557 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 16, 557 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 49, 559 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 39, 560 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 22, 562 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 32, 562 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 11, 563 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 15, 564 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 565 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 44, 566 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 38, 567 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 48, 567 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 27, 568 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 31, 569 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 21, 570 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 10, 571 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 572 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 43, 573 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 36, 575 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 26, 576 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 19, 577 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 9, 578 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 49, 579 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 580 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 32, 581 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 42, 581 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 35, 582 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 25, 583 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 15, 584 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 18, 585 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 8, 586 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 48, 586 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 41, 588 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 31, 589 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 14, 591 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 24, 591 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 7, 593 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 47, 594 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 36, 595 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 30, 596 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 40, 596 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 19, 597 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 23, 598 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 599 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 600 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 45, 601 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 35, 602 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 28, 604 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 18, 605 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 11, 606 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 607 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 41, 608 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 44, 609 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 24, 610 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 34, 610 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 27, 611 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 17, 612 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 7, 613 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 10, 614 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 40, 615 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 50, 615 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 33, 617 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 23, 618 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 6, 620 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 16, 620 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 49, 622 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 38, 623 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 28, 624 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 21, 625 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 32, 625 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 11, 626 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 15, 627 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 628 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 44, 629 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 37, 630 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 48, 630 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 27, 631 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 20, 633 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 10, 634 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 635 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 43, 636 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 36, 638 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 26, 639 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 16, 640 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 19, 640 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 9, 641 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 49, 642 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 643 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 42, 644 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 32, 645 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 25, 646 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 14, 647 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 8, 649 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 47, 650 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 41, 651 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 30, 652 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 20, 653 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 24, 654 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 655 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 13, 655 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 7, 656 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 46, 657 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 36, 658 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 40, 659 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 19, 660 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 29, 660 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 662 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 663 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 45, 664 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 35, 665 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 28, 667 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 18, 668 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 8, 669 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 11, 669 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 670 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 40, 671 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 44, 672 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 34, 673 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 23, 674 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 17, 675 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 6, 676 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 50, 678 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 39, 679 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 33, 680 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 22, 681 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 16, 683 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 684 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 45, 684 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 48, 685 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 38, 686 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 28, 687 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 31, 688 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 11, 689 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 21, 689 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 691 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 44, 692 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 27, 694 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 37, 694 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 20, 696 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 10, 697 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 49, 698 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 699 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 43, 699 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 32, 700 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 36, 701 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 26, 702 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 15, 703 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 9, 704 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 19, 704 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 48, 705 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 42, 707 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 31, 708 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 25, 709 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 14, 710 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 7, 712 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 37, 713 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 47, 713 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 40, 714 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 30, 715 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 20, 716 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 23, 717 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 718 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 13, 718 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 46, 720 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 36, 721 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 19, 723 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 29, 723 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 725 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 726 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 35, 728 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 45, 728 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 24, 729 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 28, 730 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 18, 731 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 7, 732 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 733 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 11, 733 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 40, 734 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 33, 736 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 23, 737 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 16, 738 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 6, 739 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 49, 741 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 39, 742 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 29, 743 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 32, 743 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 22, 744 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 745 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 15, 746 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 747 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 45, 748 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 48, 748 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 38, 749 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 28, 750 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 21, 752 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 11, 753 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 754 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 44, 755 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 37, 757 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 16, 758 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 27, 758 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 20, 759 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 9, 760 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 49, 761 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 762 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 42, 762 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 32, 763 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 25, 765 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 15, 766 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 8, 767 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 48, 768 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 41, 770 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 31, 771 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 21, 772 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 24, 772 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 14, 773 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 774 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 7, 775 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 47, 776 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 37, 777 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 40, 777 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 30, 778 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 20, 779 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 13, 781 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 782 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 46, 783 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 35, 784 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 29, 786 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 8, 787 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 18, 787 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 788 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 789 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 41, 790 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 45, 791 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 24, 792 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 34, 792 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 28, 793 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 17, 794 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 7, 795 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 40, 797 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 50, 797 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 33, 799 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 23, 800 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 6, 802 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 16, 802 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 46, 803 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 49, 804 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 39, 805 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 29, 806 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 22, 807 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 32, 807 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 11, 808 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 810 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 44, 811 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 38, 812 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 27, 813 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 21, 815 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 10, 816 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 50, 816 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 817 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 43, 818 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 33, 819 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 37, 820 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 16, 821 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 26, 821 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 19, 822 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 9, 823 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 49, 824 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 32, 826 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 42, 826 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 25, 828 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 15, 829 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 8, 831 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 48, 831 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 37, 832 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 41, 833 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 31, 834 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 20, 835 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 14, 836 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 24, 836 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 837 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 7, 838 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 47, 839 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 36, 840 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 30, 841 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 19, 842 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 13, 844 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 845 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 45, 846 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 35, 847 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 25, 848 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 28, 849 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 18, 850 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 8, 851 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 11, 851 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 852 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 41, 853 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 24, 855 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 34, 855 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 17, 857 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 7, 858 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 40, 860 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 50, 860 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 29, 861 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 33, 862 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 23, 863 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 864 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 6, 865 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 16, 865 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 45, 866 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 49, 867 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 39, 868 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 28, 869 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 21, 870 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 11, 871 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 873 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 44, 874 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 37, 875 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 27, 876 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 17, 877 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 20, 878 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 10, 879 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 880 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 50, 880 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 43, 881 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 33, 882 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 36, 883 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 26, 884 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 16, 885 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 9, 886 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 49, 887 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 42, 889 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 32, 890 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 25, 891 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 15, 892 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 893 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 8, 894 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 37, 895 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 47, 895 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 41, 896 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 30, 897 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 20, 898 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 900 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 13, 900 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 46, 902 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 36, 903 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 19, 905 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 29, 905 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 9, 906 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 907 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 908 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 42, 909 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 35, 910 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 45, 910 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 25, 911 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 28, 912 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 18, 913 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 8, 914 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 915 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 41, 916 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 34, 918 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 23, 919 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 17, 920 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 6, 921 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 46, 922 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 50, 923 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 29, 924 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 39, 924 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 33, 925 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 22, 926 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 927 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 16, 928 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 929 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 45, 929 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 38, 931 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 28, 932 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 11, 934 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 21, 934 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 936 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 44, 937 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 34, 938 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 27, 939 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 37, 939 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 17, 940 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 20, 941 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 10, 942 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 50, 943 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 43, 944 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 32, 945 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 26, 947 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 15, 948 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 9, 949 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 48, 950 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 38, 951 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 42, 952 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 21, 953 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 31, 953 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 25, 954 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 14, 955 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 956 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 7, 957 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 37, 958 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 47, 958 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 30, 960 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 20, 961 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 963 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 13, 963 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 46, 965 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 36, 966 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 26, 967 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 19, 968 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 29, 968 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 8, 969 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 970 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 971 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 41, 972 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 35, 973 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 45, 973 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 24, 974 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 18, 976 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 7, 977 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 978 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 40, 979 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 34, 981 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 23, 982 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 13, 983 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 16, 983 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 6, 984 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 46, 985 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 49, 986 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 39, 987 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 29, 988 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 22, 989 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 990 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 992 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 45, 993 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 38, 994 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 28, 995 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 17, 996 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 21, 997 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 11, 998 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 50, 998 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 999 });

            migrationBuilder.DeleteData(
                table: "ProductProductCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 44, 1000 });

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1);

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
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8);

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
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16);

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
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 27);

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
                keyValue: 30);

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
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 40);

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
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 45);

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
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 55);

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
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 61);

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
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 66);

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
                keyValue: 71);

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
                keyValue: 75);

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
                keyValue: 88);

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
                keyValue: 95);

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
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 100);

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
                keyValue: 103);

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
                keyValue: 111);

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
                keyValue: 125);

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
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 146);

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
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 165);

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
                keyValue: 169);

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
                keyValue: 182);

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
                keyValue: 185);

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
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 190);

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
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 196);

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
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 203);

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
                keyValue: 214);

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
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 220);

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
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 224);

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
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 233);

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
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 237);

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
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 246);

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
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 254);

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
                keyValue: 257);

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
                keyValue: 261);

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
                keyValue: 267);

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
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 284);

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
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 292);

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
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 301);

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
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 308);

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
                keyValue: 317);

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
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 325);

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
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 331);

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
                keyValue: 335);

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
                keyValue: 339);

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
                keyValue: 346);

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
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 353);

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
                keyValue: 360);

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
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 365);

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
                keyValue: 372);

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
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 382);

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
                keyValue: 386);

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
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 393);

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
                keyValue: 396);

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
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 402);

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
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 409);

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
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 422);

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
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 429);

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
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 436);

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
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 441);

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
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 450);

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
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 457);

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
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 465);

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
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 473);

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
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 478);

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
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 483);

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
                keyValue: 488);

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
                keyValue: 493);

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
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 498);

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
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 503);

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
                keyValue: 506);

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
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 512);

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
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 520);

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
                keyValue: 523);

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
                keyValue: 528);

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
                keyValue: 532);

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
                keyValue: 538);

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
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 551);

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
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 557);

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
                keyValue: 562);

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
                keyValue: 569);

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
                keyValue: 573);

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
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 578);

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
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 586);

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
                keyValue: 591);

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
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 596);

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
                keyValue: 604);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 605);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 606);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 607);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 608);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 609);

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
                keyValue: 612);

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
                keyValue: 615);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 617);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 618);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 620);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 622);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 623);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 624);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 625);

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
                keyValue: 633);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 634);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 635);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 636);

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
                keyValue: 656);

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
                keyValue: 660);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 662);

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
                keyValue: 671);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 672);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 673);

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
                keyValue: 678);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 679);

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
                keyValue: 683);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 684);

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
                keyValue: 691);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 692);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 694);

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
                keyValue: 710);

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
                keyValue: 714);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 715);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 716);

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
                keyValue: 720);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 721);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 723);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 725);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 726);

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
                keyValue: 730);

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
                keyValue: 733);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 734);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 736);

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
                keyValue: 741);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 742);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 743);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 744);

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
                keyValue: 753);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 754);

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
                keyValue: 761);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 762);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 763);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 765);

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
                keyValue: 768);

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
                keyValue: 784);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 786);

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
                keyValue: 789);

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
                keyValue: 792);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 793);

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
                keyValue: 797);

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
                keyValue: 802);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 803);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 804);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 805);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 806);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 807);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 808);

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
                keyValue: 812);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 813);

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
                keyValue: 817);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 818);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 819);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 820);

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
                keyValue: 845);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 846);

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
                keyValue: 849);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 850);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 851);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 852);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 853);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 855);

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
                keyValue: 867);

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
                keyValue: 873);

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
                keyValue: 877);

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
                keyValue: 884);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 885);

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
                keyValue: 890);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 891);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 892);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 893);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 894);

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
                keyValue: 900);

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
                keyValue: 905);

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
                keyValue: 910);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 911);

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
                keyValue: 915);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 916);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 918);

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
                keyValue: 923);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 924);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 925);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 926);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 927);

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
                keyValue: 931);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 932);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 934);

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
                keyValue: 938);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 939);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 940);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 941);

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
                keyValue: 944);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 945);

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
                keyValue: 950);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 951);

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
                keyValue: 954);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 955);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 956);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 957);

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
                keyValue: 961);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 963);

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
                keyValue: 969);

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
                keyValue: 972);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 973);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 974);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 976);

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
                keyValue: 981);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 982);

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
                keyValue: 987);

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
                keyValue: 990);

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
                keyValue: 996);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 997);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 998);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 999);

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
