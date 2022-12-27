using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class few_modifications_Movie_definition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Superheroes_SuperheroId",
                table: "Movies");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("0618aac8-9633-473b-8311-3a88a99af80a"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("0b7bbbd3-a96f-48a5-bc06-cd56400f063e"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("130b6262-0088-4b77-bffd-3f9dc547d862"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("63606716-3a37-42fd-a33e-bd43800ec439"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("86e65602-3c08-4620-bbec-491451581741"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("8ce89ebd-2e94-43ab-a4cf-423705c355d2"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("bb4cab25-c4c1-47d0-a179-09ada65cd1e8"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("0221bc98-3902-485f-b2dc-a9a45b355e4b"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("b992367a-19d3-49b0-b447-4748b5b8f399"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("c02cef06-606e-4660-b1c0-bd9f39065a1f"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("dc10a553-1f45-421d-b666-e9c32dba52c2"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("e22d9485-565f-4c66-8a69-da0d7e0e455d"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("e65a552a-06df-4ad4-b558-0f12187ad4f0"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("fc841e82-0692-4de2-8779-ec602e2b2a39"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("4ccfcc0b-1c16-4be0-83f2-2d5d9c3a19a8"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("81ef662e-2f8a-4e90-8adb-cc3f136a8dfd"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("b8b0401c-2eba-4bf9-b685-856e3b5cf3b7"));

            migrationBuilder.AlterColumn<Guid>(
                name: "SuperheroId",
                table: "Movies",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "Movies",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "Superheroes",
                columns: new[] { "Id", "Description", "Height", "Name" },
                values: new object[] { new Guid("309aeb2d-d566-4104-b581-5f99f5f517a0"), "Batman was originally introduced as a ruthless vigilante who frequently killed or maimed criminals, but evolved into a character with a stringent moral code and strong sense of justice. Unlike most superheroes, Batman does not possess any superpowers, instead relying on his intellect, fighting skills, and wealth.", 1.9299999999999999, "Batman" });

            migrationBuilder.InsertData(
                table: "Superheroes",
                columns: new[] { "Id", "Description", "Height", "Name" },
                values: new object[] { new Guid("37dfb143-571f-4da6-ae71-9fa523695129"), "Black Widow, real name Natasha Romanoff, is a trained female secret agent and superhero that appears in Marvel Comics. Associated with the superhero teams S.H.I.E.L.D. and the Avengers, Black Widow makes up for her lack of superpowers with world class training as an athlete, acrobat, and expert martial artist and weapon specialist.", 1.7, "Black Widow" });

            migrationBuilder.InsertData(
                table: "Superheroes",
                columns: new[] { "Id", "Description", "Height", "Name" },
                values: new object[] { new Guid("9e36254b-641f-4189-9b92-5be9f6633e62"), "Luke Skywalker was a Tatooine farmboy who rose from humble beginnings to become one of the greatest Jedi the galaxy has ever known. Along with his friends Princess Leia and Han Solo, Luke battled the evil Empire, discovered the truth of his parentage, and ended the tyranny of the Sith.", 1.7, "Luke Skywalker" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Instructor", "ReleaseDate", "SuperheroId", "Title" },
                values: new object[,]
                {
                    { new Guid("300273bd-6cf0-45e5-9453-1603b020f9f7"), "Black Widow is a 2021 American superhero film based on Marvel Comics featuring the character of the same name. Produced by Marvel Studios and distributed by Walt Disney Studios Motion Pictures, it is the 24th film in the Marvel Cinematic Universe (MCU).", "Cate Shortland", new DateTime(2021, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("37dfb143-571f-4da6-ae71-9fa523695129"), "Black Widow" },
                    { new Guid("5db94e48-6910-47cf-9def-f6c6b7c91ca6"), "Return of the Jedi (also known as Star Wars: Episode VI – Return of the Jedi) is a 1983 American epic space opera film directed by Richard Marquand. The screenplay is by Lawrence Kasdan and George Lucas from a story by Lucas, who was also the executive producer.", "Richard Marquand", new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9e36254b-641f-4189-9b92-5be9f6633e62"), "Star Wars: Episode VI – Return of the Jedi" },
                    { new Guid("b1703ac6-5ed0-40f9-ad8a-94ca3b22b39b"), "The Dark Knight Rises is a 2012 superhero film directed by Christopher Nolan, who co-wrote the screenplay with his brother Jonathan Nolan, and the story with David S. Goyer.", "Christopher Nolan", new DateTime(2012, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("309aeb2d-d566-4104-b581-5f99f5f517a0"), "The Dark Knight Rises" },
                    { new Guid("c6c2b4fe-b649-4bff-97c3-c1d8ac89c17a"), "Batman Begins is a 2005 superhero film directed by Christopher Nolan and written by Nolan and David S. Goyer. Based on the DC Comics character Batman, it stars Christian Bale as Bruce Wayne / Batman, with Michael Caine, Liam Neeson, Katie Holmes, Gary Oldman,", "Christopher Nolan", new DateTime(2005, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("309aeb2d-d566-4104-b581-5f99f5f517a0"), "Batman Begins" },
                    { new Guid("cbd55bdc-51ad-42f4-8df3-8bba095ca511"), "The Dark Knight is a 2008 superhero film directed, produced, and co-written by Christopher Nolan. Based on the DC Comics character Batman, the film is the second installment of Nolan's The Dark Knight Trilogy and a sequel to 2005's Batman Begins, starring Christian Bale and supported by Michael Caine, Heath Ledger, Gary Oldman, Aaron Eckhart, Maggie Gyllenhaal, and Morgan Freeman.", "Christopher Nolan", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("309aeb2d-d566-4104-b581-5f99f5f517a0"), "The Dark Knight" },
                    { new Guid("d7b1eb5b-726c-4a60-801c-d66f42c3163b"), "The Empire Strikes Back (also known as Star Wars: Episode V – The Empire Strikes Back) is a 1980 American epic space opera film directed by Irvin Kershner and written by Leigh Brackett and Lawrence Kasdan, based on a story by George Lucas.", "Irvin Kershner", new DateTime(1980, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9e36254b-641f-4189-9b92-5be9f6633e62"), "Star Wars: Episode V – The Empire Strikes Back" },
                    { new Guid("df5e4205-9d12-4fb4-b93b-ff1161103c96"), "Star Wars (retroactively titled Star Wars: Episode IV – A New Hope) is a 1977 American epic space opera film written and directed by George Lucas, produced by Lucasfilm and distributed by 20th Century Fox.", "George Lucas", new DateTime(1977, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9e36254b-641f-4189-9b92-5be9f6633e62"), "Star Wars: Episode IV – A New Hope" }
                });

            migrationBuilder.InsertData(
                table: "Superpowers",
                columns: new[] { "Id", "Description", "SuperPower", "SuperheroId" },
                values: new object[,]
                {
                    { new Guid("27696d6e-f430-4fe2-983d-3307ea50acbe"), "The knowledge of how to undermine others.", "Subterfuge", new Guid("37dfb143-571f-4da6-ae71-9fa523695129") },
                    { new Guid("40c1ae95-d7b3-45ca-b15e-4d0ed6a82f55"), "She knows how to infiltrate the enemy.", "Infiltration", new Guid("37dfb143-571f-4da6-ae71-9fa523695129") },
                    { new Guid("536b2b50-b89f-41eb-9ef3-9c91a061c105"), "He's always a step ahead.", "Intellect.", new Guid("309aeb2d-d566-4104-b581-5f99f5f517a0") },
                    { new Guid("7bdd09f1-e478-4acf-8cec-3fb1ece3c5ee"), "Skywalker is able to deflect fire from a blaster back at the opponent firing. This enables Luke to turn someone else's weapon against them.", "Deflect blaster power.", new Guid("9e36254b-641f-4189-9b92-5be9f6633e62") },
                    { new Guid("c71bd931-2b1a-475a-b132-222a160e90b0"), "Sublime fighting skills.", "Fighting", new Guid("309aeb2d-d566-4104-b581-5f99f5f517a0") },
                    { new Guid("caf0f3bc-5299-4466-8676-b1fb5d600739"), "He got a lot of money", "Wealth.", new Guid("309aeb2d-d566-4104-b581-5f99f5f517a0") },
                    { new Guid("ddb8643c-a667-4d78-8120-56865cfb5261"), "She's good at spying at people.", "Espionage", new Guid("37dfb143-571f-4da6-ae71-9fa523695129") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Superheroes_SuperheroId",
                table: "Movies",
                column: "SuperheroId",
                principalTable: "Superheroes",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Superheroes_SuperheroId",
                table: "Movies");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("300273bd-6cf0-45e5-9453-1603b020f9f7"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("5db94e48-6910-47cf-9def-f6c6b7c91ca6"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("b1703ac6-5ed0-40f9-ad8a-94ca3b22b39b"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("c6c2b4fe-b649-4bff-97c3-c1d8ac89c17a"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("cbd55bdc-51ad-42f4-8df3-8bba095ca511"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("d7b1eb5b-726c-4a60-801c-d66f42c3163b"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("df5e4205-9d12-4fb4-b93b-ff1161103c96"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("27696d6e-f430-4fe2-983d-3307ea50acbe"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("40c1ae95-d7b3-45ca-b15e-4d0ed6a82f55"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("536b2b50-b89f-41eb-9ef3-9c91a061c105"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("7bdd09f1-e478-4acf-8cec-3fb1ece3c5ee"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("c71bd931-2b1a-475a-b132-222a160e90b0"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("caf0f3bc-5299-4466-8676-b1fb5d600739"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("ddb8643c-a667-4d78-8120-56865cfb5261"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("309aeb2d-d566-4104-b581-5f99f5f517a0"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("37dfb143-571f-4da6-ae71-9fa523695129"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("9e36254b-641f-4189-9b92-5be9f6633e62"));

            migrationBuilder.AlterColumn<Guid>(
                name: "SuperheroId",
                table: "Movies",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "Movies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Superheroes",
                columns: new[] { "Id", "Description", "Height", "Name" },
                values: new object[] { new Guid("4ccfcc0b-1c16-4be0-83f2-2d5d9c3a19a8"), "Black Widow, real name Natasha Romanoff, is a trained female secret agent and superhero that appears in Marvel Comics. Associated with the superhero teams S.H.I.E.L.D. and the Avengers, Black Widow makes up for her lack of superpowers with world class training as an athlete, acrobat, and expert martial artist and weapon specialist.", 1.7, "Black Widow" });

            migrationBuilder.InsertData(
                table: "Superheroes",
                columns: new[] { "Id", "Description", "Height", "Name" },
                values: new object[] { new Guid("81ef662e-2f8a-4e90-8adb-cc3f136a8dfd"), "Batman was originally introduced as a ruthless vigilante who frequently killed or maimed criminals, but evolved into a character with a stringent moral code and strong sense of justice. Unlike most superheroes, Batman does not possess any superpowers, instead relying on his intellect, fighting skills, and wealth.", 1.9299999999999999, "Batman" });

            migrationBuilder.InsertData(
                table: "Superheroes",
                columns: new[] { "Id", "Description", "Height", "Name" },
                values: new object[] { new Guid("b8b0401c-2eba-4bf9-b685-856e3b5cf3b7"), "Luke Skywalker was a Tatooine farmboy who rose from humble beginnings to become one of the greatest Jedi the galaxy has ever known. Along with his friends Princess Leia and Han Solo, Luke battled the evil Empire, discovered the truth of his parentage, and ended the tyranny of the Sith.", 1.7, "Luke Skywalker" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Instructor", "ReleaseDate", "SuperheroId", "Title" },
                values: new object[,]
                {
                    { new Guid("0618aac8-9633-473b-8311-3a88a99af80a"), "Batman Begins is a 2005 superhero film directed by Christopher Nolan and written by Nolan and David S. Goyer. Based on the DC Comics character Batman, it stars Christian Bale as Bruce Wayne / Batman, with Michael Caine, Liam Neeson, Katie Holmes, Gary Oldman,", "Christopher Nolan", new DateTime(2005, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("81ef662e-2f8a-4e90-8adb-cc3f136a8dfd"), "Batman Begins" },
                    { new Guid("0b7bbbd3-a96f-48a5-bc06-cd56400f063e"), "Return of the Jedi (also known as Star Wars: Episode VI – Return of the Jedi) is a 1983 American epic space opera film directed by Richard Marquand. The screenplay is by Lawrence Kasdan and George Lucas from a story by Lucas, who was also the executive producer.", "Richard Marquand", new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8b0401c-2eba-4bf9-b685-856e3b5cf3b7"), "Star Wars: Episode VI – Return of the Jedi" },
                    { new Guid("130b6262-0088-4b77-bffd-3f9dc547d862"), "The Empire Strikes Back (also known as Star Wars: Episode V – The Empire Strikes Back) is a 1980 American epic space opera film directed by Irvin Kershner and written by Leigh Brackett and Lawrence Kasdan, based on a story by George Lucas.", "Irvin Kershner", new DateTime(1980, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8b0401c-2eba-4bf9-b685-856e3b5cf3b7"), "Star Wars: Episode V – The Empire Strikes Back" },
                    { new Guid("63606716-3a37-42fd-a33e-bd43800ec439"), "Star Wars (retroactively titled Star Wars: Episode IV – A New Hope) is a 1977 American epic space opera film written and directed by George Lucas, produced by Lucasfilm and distributed by 20th Century Fox.", "George Lucas", new DateTime(1977, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8b0401c-2eba-4bf9-b685-856e3b5cf3b7"), "Star Wars: Episode IV – A New Hope" },
                    { new Guid("86e65602-3c08-4620-bbec-491451581741"), "Black Widow is a 2021 American superhero film based on Marvel Comics featuring the character of the same name. Produced by Marvel Studios and distributed by Walt Disney Studios Motion Pictures, it is the 24th film in the Marvel Cinematic Universe (MCU).", "Cate Shortland", new DateTime(2021, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4ccfcc0b-1c16-4be0-83f2-2d5d9c3a19a8"), "Black Widow" },
                    { new Guid("8ce89ebd-2e94-43ab-a4cf-423705c355d2"), "The Dark Knight Rises is a 2012 superhero film directed by Christopher Nolan, who co-wrote the screenplay with his brother Jonathan Nolan, and the story with David S. Goyer.", "Christopher Nolan", new DateTime(2012, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("81ef662e-2f8a-4e90-8adb-cc3f136a8dfd"), "The Dark Knight Rises" },
                    { new Guid("bb4cab25-c4c1-47d0-a179-09ada65cd1e8"), "The Dark Knight is a 2008 superhero film directed, produced, and co-written by Christopher Nolan. Based on the DC Comics character Batman, the film is the second installment of Nolan's The Dark Knight Trilogy and a sequel to 2005's Batman Begins, starring Christian Bale and supported by Michael Caine, Heath Ledger, Gary Oldman, Aaron Eckhart, Maggie Gyllenhaal, and Morgan Freeman.", "Christopher Nolan", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("81ef662e-2f8a-4e90-8adb-cc3f136a8dfd"), "The Dark Knight" }
                });

            migrationBuilder.InsertData(
                table: "Superpowers",
                columns: new[] { "Id", "Description", "SuperPower", "SuperheroId" },
                values: new object[,]
                {
                    { new Guid("0221bc98-3902-485f-b2dc-a9a45b355e4b"), "He's always a step ahead.", "Intellect.", new Guid("81ef662e-2f8a-4e90-8adb-cc3f136a8dfd") },
                    { new Guid("b992367a-19d3-49b0-b447-4748b5b8f399"), "He got a lot of money", "Wealth.", new Guid("81ef662e-2f8a-4e90-8adb-cc3f136a8dfd") },
                    { new Guid("c02cef06-606e-4660-b1c0-bd9f39065a1f"), "Sublime fighting skills.", "Fighting", new Guid("81ef662e-2f8a-4e90-8adb-cc3f136a8dfd") },
                    { new Guid("dc10a553-1f45-421d-b666-e9c32dba52c2"), "The knowledge of how to undermine others.", "Subterfuge", new Guid("4ccfcc0b-1c16-4be0-83f2-2d5d9c3a19a8") },
                    { new Guid("e22d9485-565f-4c66-8a69-da0d7e0e455d"), "She knows how to infiltrate the enemy.", "Infiltration", new Guid("4ccfcc0b-1c16-4be0-83f2-2d5d9c3a19a8") },
                    { new Guid("e65a552a-06df-4ad4-b558-0f12187ad4f0"), "She's good at spying at people.", "Espionage", new Guid("4ccfcc0b-1c16-4be0-83f2-2d5d9c3a19a8") },
                    { new Guid("fc841e82-0692-4de2-8779-ec602e2b2a39"), "Skywalker is able to deflect fire from a blaster back at the opponent firing. This enables Luke to turn someone else's weapon against them.", "Deflect blaster power.", new Guid("b8b0401c-2eba-4bf9-b685-856e3b5cf3b7") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Superheroes_SuperheroId",
                table: "Movies",
                column: "SuperheroId",
                principalTable: "Superheroes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
