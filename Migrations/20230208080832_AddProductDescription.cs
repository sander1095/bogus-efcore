using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bogus_efcore.Migrations
{
    public partial class AddProductDescription : Migration
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
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 19,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 21,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 22,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 23,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 24,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 25,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 26,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 27,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 28,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 29,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 30,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 31,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 32,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 33,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 34,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 35,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 36,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 37,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 38,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 39,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 40,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 41,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 42,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 43,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 44,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 45,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 46,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 47,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 48,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 49,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 50,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 51,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 52,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 53,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 54,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 55,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 56,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 57,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 58,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 59,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 60,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 61,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 62,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 63,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 64,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 65,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 66,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 67,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 68,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 69,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 70,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 71,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 72,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 73,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 74,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 75,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 76,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 77,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 78,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 79,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 80,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 81,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 82,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 83,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 84,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 85,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 86,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 87,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 88,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 89,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 90,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 91,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 92,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 93,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 94,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 95,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 96,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 97,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 98,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 99,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 100,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 101,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 102,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 103,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 104,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 105,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 106,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 107,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 108,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 109,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 110,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 111,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 112,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 113,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 114,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 115,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 116,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 117,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 118,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 119,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 120,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 121,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 122,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 123,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 124,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 125,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 126,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 127,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 128,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 129,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 130,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 131,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 132,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 133,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 134,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 135,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 136,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 137,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 138,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 139,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 140,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 141,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 142,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 143,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 144,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 145,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 146,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 147,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 148,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 149,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 150,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 151,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 152,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 153,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 154,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 155,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 156,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 157,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 158,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 159,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 160,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 161,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 162,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 163,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 164,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 165,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 166,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 167,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 168,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 169,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 170,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 171,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 172,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 173,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 174,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 175,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 176,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 177,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 178,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 179,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 180,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 181,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 182,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 183,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 184,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 185,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 186,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 187,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 188,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 189,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 190,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 191,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 192,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 193,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 194,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 195,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 196,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 197,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 198,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 199,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 200,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 201,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 202,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 203,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 204,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 205,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 206,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 207,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 208,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 209,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 210,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 211,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 212,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 213,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 214,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 215,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 216,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 217,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 218,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 219,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 220,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 221,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 222,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 223,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 224,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 225,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 226,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 227,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 228,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 229,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 230,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 231,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 232,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 233,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 234,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 235,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 236,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 237,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 238,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 239,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 240,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 241,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 242,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 243,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 244,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 245,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 246,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 247,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 248,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 249,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 250,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 251,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 252,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 253,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 254,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 255,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 256,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 257,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 258,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 259,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 260,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 261,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 262,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 263,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 264,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 265,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 266,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 267,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 268,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 269,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 270,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 271,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 272,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 273,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 274,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 275,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 276,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 277,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 278,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 279,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 280,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 281,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 282,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 283,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 284,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 285,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 286,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 287,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 288,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 289,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 290,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 291,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 292,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 293,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 294,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 295,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 296,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 297,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 298,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 299,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 300,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 301,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 302,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 303,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 304,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 305,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 306,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 307,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 308,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 309,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 310,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 311,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 312,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 313,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 314,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 315,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 316,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 317,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 318,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 319,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 320,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 321,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 322,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 323,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 324,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 325,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 326,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 327,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 328,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 329,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 330,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 331,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 332,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 333,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 334,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 335,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 336,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 337,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 338,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 339,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 340,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 341,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 342,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 343,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 344,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 345,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 346,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 347,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 348,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 349,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 350,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 351,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 352,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 353,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 354,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 355,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 356,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 357,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 358,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 359,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 360,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 361,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 362,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 363,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 364,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 365,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 366,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 367,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 368,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 369,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 370,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 371,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 372,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 373,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 374,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 375,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 376,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 377,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 378,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 379,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 380,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 381,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 382,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 383,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 384,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 385,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 386,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 387,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 388,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 389,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 390,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 391,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 392,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 393,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 394,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 395,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 396,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 397,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 398,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 399,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 400,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 401,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 402,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 403,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 404,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 405,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 406,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 407,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 408,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 409,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 410,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 411,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 412,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 413,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 414,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 415,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 416,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 417,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 418,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 419,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 420,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 421,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 422,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 423,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 424,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 425,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 426,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 427,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 428,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 429,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 430,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 431,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 432,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 433,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 434,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 435,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 436,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 437,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 438,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 439,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 440,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 441,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 442,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 443,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 444,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 445,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 446,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 447,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 448,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 449,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 450,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 451,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 452,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 453,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 454,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 455,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 456,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 457,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 458,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 459,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 460,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 461,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 462,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 463,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 464,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 465,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 466,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 467,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 468,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 469,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 470,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 471,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 472,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 473,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 474,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 475,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 476,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 477,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 478,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 479,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 480,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 481,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 482,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 483,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 484,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 485,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 486,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 487,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 488,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 489,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 490,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 491,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 492,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 493,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 494,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 495,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 496,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 497,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 498,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 499,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 500,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 501,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 502,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 503,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 504,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 505,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 506,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 507,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 508,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 509,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 510,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 511,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 512,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 513,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 514,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 515,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 516,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 517,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 518,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 519,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 520,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 521,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 522,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 523,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 524,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 525,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 526,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 527,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 528,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 529,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 530,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 531,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 532,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 533,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 534,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 535,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 536,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 537,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 538,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 539,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 540,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 541,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 542,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 543,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 544,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 545,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 546,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 547,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 548,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 549,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 550,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 551,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 552,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 553,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 554,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 555,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 556,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 557,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 558,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 559,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 560,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 561,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 562,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 563,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 564,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 565,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 566,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 567,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 568,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 569,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 570,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 571,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 572,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 573,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 574,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 575,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 576,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 577,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 578,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 579,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 580,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 581,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 582,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 583,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 584,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 585,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 586,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 587,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 588,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 589,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 590,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 591,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 592,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 593,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 594,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 595,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 596,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 597,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 598,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 599,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 600,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 601,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 602,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 603,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 604,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 605,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 606,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 607,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 608,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 609,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 610,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 611,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 612,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 613,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 614,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 615,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 616,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 617,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 618,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 619,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 620,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 621,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 622,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 623,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 624,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 625,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 626,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 627,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 628,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 629,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 630,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 631,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 632,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 633,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 634,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 635,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 636,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 637,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 638,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 639,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 640,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 641,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 642,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 643,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 644,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 645,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 646,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 647,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 648,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 649,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 650,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 651,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 652,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 653,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 654,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 655,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 656,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 657,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 658,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 659,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 660,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 661,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 662,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 663,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 664,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 665,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 666,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 667,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 668,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 669,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 670,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 671,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 672,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 673,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 674,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 675,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 676,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 677,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 678,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 679,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 680,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 681,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 682,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 683,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 684,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 685,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 686,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 687,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 688,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 689,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 690,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 691,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 692,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 693,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 694,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 695,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 696,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 697,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 698,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 699,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 700,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 701,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 702,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 703,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 704,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 705,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 706,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 707,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 708,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 709,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 710,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 711,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 712,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 713,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 714,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 715,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 716,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 717,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 718,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 719,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 720,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 721,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 722,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 723,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 724,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 725,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 726,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 727,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 728,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 729,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 730,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 731,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 732,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 733,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 734,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 735,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 736,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 737,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 738,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 739,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 740,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 741,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 742,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 743,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 744,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 745,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 746,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 747,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 748,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 749,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 750,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 751,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 752,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 753,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 754,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 755,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 756,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 757,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 758,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 759,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 760,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 761,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 762,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 763,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 764,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 765,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 766,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 767,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 768,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 769,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 770,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 771,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 772,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 773,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 774,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 775,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 776,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 777,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 778,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 779,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 780,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 781,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 782,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 783,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 784,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 785,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 786,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 787,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 788,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 789,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 790,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 791,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 792,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 793,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 794,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 795,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 796,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 797,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 798,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 799,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 800,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 801,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 802,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 803,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 804,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 805,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 806,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 807,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 808,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 809,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 810,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 811,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 812,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 813,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 814,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 815,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 816,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 817,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 818,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 819,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 820,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 821,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 822,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 823,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 824,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 825,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 826,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 827,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 828,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 829,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 830,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 831,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 832,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 833,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 834,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 835,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 836,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 837,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 838,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 839,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 840,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 841,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 842,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 843,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 844,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 845,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 846,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 847,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 848,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 849,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 850,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 851,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 852,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 853,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 854,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 855,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 856,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 857,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 858,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 859,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 860,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 861,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 862,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 863,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 864,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 865,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 866,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 867,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 868,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 869,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 870,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 871,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 872,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 873,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 874,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 875,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 876,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 877,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 878,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 879,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 880,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 881,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 882,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 883,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 884,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 885,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 886,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 887,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 888,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 889,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 890,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 891,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 892,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 893,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 894,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 895,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 896,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 897,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 898,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 899,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 900,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 901,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 902,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 903,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 904,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 905,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 906,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 907,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 908,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 909,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 910,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 911,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 912,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 913,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 914,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 915,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 916,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 917,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 918,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 919,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 920,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 921,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 922,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 923,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 924,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 925,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 926,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 927,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 928,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 929,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 930,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 931,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 932,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 933,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 934,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 935,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 936,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 937,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 938,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 939,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 940,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 941,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 942,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 943,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 944,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 945,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 946,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 947,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 948,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 949,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 950,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 951,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 952,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 953,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 954,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 955,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 956,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 957,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 958,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 959,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 960,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 961,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 962,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 963,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 964,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 965,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 966,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 967,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 968,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 969,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 970,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 971,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 972,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 973,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 974,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 975,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 976,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 977,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 978,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 979,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 980,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 981,
                column: "Description",
                value: "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 982,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 983,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 984,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 985,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 986,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 987,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 988,
                column: "Description",
                value: "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 989,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 990,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 991,
                column: "Description",
                value: "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 992,
                column: "Description",
                value: "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 993,
                column: "Description",
                value: "The Football Is Good For Training And Recreational Purposes");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 994,
                column: "Description",
                value: "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 995,
                column: "Description",
                value: "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 996,
                column: "Description",
                value: "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 997,
                column: "Description",
                value: "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 998,
                column: "Description",
                value: "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 999,
                column: "Description",
                value: "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1000,
                column: "Description",
                value: "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Product");
        }
    }
}
