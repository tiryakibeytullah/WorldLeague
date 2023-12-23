using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WorldLeagure.Repository.Migrations
{
    /// <inheritdoc />
    public partial class Create_DataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0b687d88-a83d-41d4-bfd3-2fb40f690b5e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Fransa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3b2a9b8c-0c47-43dd-aece-7b7623ff098d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Almanya", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3ca6c4db-d8da-4892-a150-0ab9760cadea"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "İtalya", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3eaec5dd-22e0-4aa2-a6ec-1181f340fb11"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Türkiye", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("748bb8d7-5fb3-476c-a80c-518dcc3a2c7c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "İspanya", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7eac088f-7ec2-48ee-ae79-030bbd51b07d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Hollanda", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cc73cc28-7f01-45b9-8ca9-e911a31ec547"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Belçika", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e7f22b9a-96f3-4af8-be4a-0880ffbcbaee"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Portekiz", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("06469ba4-37d2-4162-b80e-4a7a58681d0c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "E Grubu", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0f230ffd-a78e-43fc-b40a-a8d5fe2a0b36"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "B Grubu", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("12c4ea55-92d5-4be1-bf54-bdfae3fbff33"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "H Grubu", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66788cd5-668d-458c-a238-bc63d41ba6ff"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "G Grubu", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6e57eaa2-bdc2-433f-8ff9-daa9f587c392"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "F Grubu", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("804a6958-0fb3-4ed8-9f90-df02b0f8e4df"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "C Grubu", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d9a3dced-e752-44d2-b330-b71e0ce4c8ea"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "A Grubu", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("eb63340f-5d3a-4059-90eb-22fc4bc2d0e4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "D Grubu", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "CountryId", "CreatedDate", "IsDeleted", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0343aa75-cd35-463d-9c08-ef4edaf2517d"), new Guid("748bb8d7-5fb3-476c-a80c-518dcc3a2c7c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Adesso Sevilla", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("07988729-ae3d-47c5-9645-93263367af7a"), new Guid("3eaec5dd-22e0-4aa2-a6ec-1181f340fb11"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Adesso Ankara", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0a795af3-8d9c-4fcb-b11e-271eeaa1464d"), new Guid("3b2a9b8c-0c47-43dd-aece-7b7623ff098d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Adesso Münih", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("131cc56b-67c7-4c6d-b187-9017946f335d"), new Guid("3ca6c4db-d8da-4892-a150-0ab9760cadea"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Adesso Roma", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("18028ea1-10d6-4542-bfae-77fd98d3d9f8"), new Guid("748bb8d7-5fb3-476c-a80c-518dcc3a2c7c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Adesso Madrid", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1e9aaa3a-8b69-4bb6-a41e-6575b807182d"), new Guid("3ca6c4db-d8da-4892-a150-0ab9760cadea"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Adesso Milano", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2409a026-86be-44fd-8e32-3648004cae75"), new Guid("cc73cc28-7f01-45b9-8ca9-e911a31ec547"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Adesso Anvers", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("26d0142e-3f67-4518-8935-2866edd54d62"), new Guid("7eac088f-7ec2-48ee-ae79-030bbd51b07d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Adesso Eindhoven", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2ddb01b1-dee3-4d83-843d-812f5ff1b5b0"), new Guid("3eaec5dd-22e0-4aa2-a6ec-1181f340fb11"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Adesso İzmir", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("327eb396-136c-46ca-8ffa-a661253637ef"), new Guid("3ca6c4db-d8da-4892-a150-0ab9760cadea"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Adesso Venedik", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("382ab411-ba97-42b3-906e-5b2a7f847520"), new Guid("3b2a9b8c-0c47-43dd-aece-7b7623ff098d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Adesso Berlin", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3acc9e46-f59e-441b-be70-ee4ad2fe12dd"), new Guid("3b2a9b8c-0c47-43dd-aece-7b7623ff098d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Adesso Frankfurt", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("442d25fa-bfb5-432f-80db-cab7fc15b2a0"), new Guid("0b687d88-a83d-41d4-bfd3-2fb40f690b5e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Adesso Paris", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("509dee1a-bf83-4c68-b81e-c38464b0e72b"), new Guid("0b687d88-a83d-41d4-bfd3-2fb40f690b5e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Adesso Marsilya", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("55b9a8ae-d662-4455-afc7-dda7e718c319"), new Guid("cc73cc28-7f01-45b9-8ca9-e911a31ec547"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Adesso Brugge", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("589fcb47-ad76-4d1b-995c-a4d90567fb0e"), new Guid("e7f22b9a-96f3-4af8-be4a-0880ffbcbaee"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Adesso Braga", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5b9cf05b-bc58-4c74-a88c-cf652c5e9aab"), new Guid("7eac088f-7ec2-48ee-ae79-030bbd51b07d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Adesso Amsterdam", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7170ea69-356a-4c15-917b-ab35d3a37d89"), new Guid("0b687d88-a83d-41d4-bfd3-2fb40f690b5e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Adesso Lyon", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7246b235-d272-4c6a-9ba3-cc3273e76d12"), new Guid("e7f22b9a-96f3-4af8-be4a-0880ffbcbaee"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Adesso Lisbon", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("77a01b26-c9be-40e7-82d5-262e09ea11f2"), new Guid("3b2a9b8c-0c47-43dd-aece-7b7623ff098d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Adesso Dortmund", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("77f04f01-518d-4487-8f57-4441aebdaf5f"), new Guid("3eaec5dd-22e0-4aa2-a6ec-1181f340fb11"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Adesso Antalya", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("80f41d77-60a3-4b7f-af15-8a74665ccf84"), new Guid("7eac088f-7ec2-48ee-ae79-030bbd51b07d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Adesso Lahey", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ad93ec76-71fa-4a59-a357-61c3cba20d81"), new Guid("0b687d88-a83d-41d4-bfd3-2fb40f690b5e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Adesso Nice", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b0db1af4-388c-4586-8011-bc7d4641a654"), new Guid("3eaec5dd-22e0-4aa2-a6ec-1181f340fb11"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Adesso İstanbul", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b64f7b64-aaf9-4e93-b087-312b0c99dffd"), new Guid("748bb8d7-5fb3-476c-a80c-518dcc3a2c7c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Adesso Barselona", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ba90cfc2-6ff0-407d-9c54-0d4938b52071"), new Guid("cc73cc28-7f01-45b9-8ca9-e911a31ec547"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Adesso Gent", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c6b370d8-3cc6-4450-8cee-2024355cfdaa"), new Guid("e7f22b9a-96f3-4af8-be4a-0880ffbcbaee"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Adesso Coimbra", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d04e131b-e460-4f75-be95-9ba82a8ff117"), new Guid("e7f22b9a-96f3-4af8-be4a-0880ffbcbaee"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Adesso Porto", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d39a72f4-5acc-40c3-af21-4494545d7fcf"), new Guid("3ca6c4db-d8da-4892-a150-0ab9760cadea"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Adesso Napoli", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d92145c9-e6ca-4679-88f1-1ca371b10f8d"), new Guid("7eac088f-7ec2-48ee-ae79-030bbd51b07d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Adesso Rotterdam", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("de6100e9-44a4-4229-b21a-636978ad8739"), new Guid("cc73cc28-7f01-45b9-8ca9-e911a31ec547"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Adesso Brüksel", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f7cca480-8f1d-4f4b-9046-7a646ed4fc54"), new Guid("748bb8d7-5fb3-476c-a80c-518dcc3a2c7c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Adesso Granada", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("06469ba4-37d2-4162-b80e-4a7a58681d0c"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("0f230ffd-a78e-43fc-b40a-a8d5fe2a0b36"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("12c4ea55-92d5-4be1-bf54-bdfae3fbff33"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("66788cd5-668d-458c-a238-bc63d41ba6ff"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("6e57eaa2-bdc2-433f-8ff9-daa9f587c392"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("804a6958-0fb3-4ed8-9f90-df02b0f8e4df"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("d9a3dced-e752-44d2-b330-b71e0ce4c8ea"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("eb63340f-5d3a-4059-90eb-22fc4bc2d0e4"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: new Guid("0343aa75-cd35-463d-9c08-ef4edaf2517d"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: new Guid("07988729-ae3d-47c5-9645-93263367af7a"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: new Guid("0a795af3-8d9c-4fcb-b11e-271eeaa1464d"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: new Guid("131cc56b-67c7-4c6d-b187-9017946f335d"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: new Guid("18028ea1-10d6-4542-bfae-77fd98d3d9f8"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: new Guid("1e9aaa3a-8b69-4bb6-a41e-6575b807182d"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: new Guid("2409a026-86be-44fd-8e32-3648004cae75"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: new Guid("26d0142e-3f67-4518-8935-2866edd54d62"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: new Guid("2ddb01b1-dee3-4d83-843d-812f5ff1b5b0"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: new Guid("327eb396-136c-46ca-8ffa-a661253637ef"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: new Guid("382ab411-ba97-42b3-906e-5b2a7f847520"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: new Guid("3acc9e46-f59e-441b-be70-ee4ad2fe12dd"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: new Guid("442d25fa-bfb5-432f-80db-cab7fc15b2a0"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: new Guid("509dee1a-bf83-4c68-b81e-c38464b0e72b"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: new Guid("55b9a8ae-d662-4455-afc7-dda7e718c319"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: new Guid("589fcb47-ad76-4d1b-995c-a4d90567fb0e"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: new Guid("5b9cf05b-bc58-4c74-a88c-cf652c5e9aab"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: new Guid("7170ea69-356a-4c15-917b-ab35d3a37d89"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: new Guid("7246b235-d272-4c6a-9ba3-cc3273e76d12"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: new Guid("77a01b26-c9be-40e7-82d5-262e09ea11f2"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: new Guid("77f04f01-518d-4487-8f57-4441aebdaf5f"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: new Guid("80f41d77-60a3-4b7f-af15-8a74665ccf84"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: new Guid("ad93ec76-71fa-4a59-a357-61c3cba20d81"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: new Guid("b0db1af4-388c-4586-8011-bc7d4641a654"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: new Guid("b64f7b64-aaf9-4e93-b087-312b0c99dffd"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: new Guid("ba90cfc2-6ff0-407d-9c54-0d4938b52071"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: new Guid("c6b370d8-3cc6-4450-8cee-2024355cfdaa"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: new Guid("d04e131b-e460-4f75-be95-9ba82a8ff117"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: new Guid("d39a72f4-5acc-40c3-af21-4494545d7fcf"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: new Guid("d92145c9-e6ca-4679-88f1-1ca371b10f8d"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: new Guid("de6100e9-44a4-4229-b21a-636978ad8739"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: new Guid("f7cca480-8f1d-4f4b-9046-7a646ed4fc54"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0b687d88-a83d-41d4-bfd3-2fb40f690b5e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3b2a9b8c-0c47-43dd-aece-7b7623ff098d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3ca6c4db-d8da-4892-a150-0ab9760cadea"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3eaec5dd-22e0-4aa2-a6ec-1181f340fb11"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("748bb8d7-5fb3-476c-a80c-518dcc3a2c7c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7eac088f-7ec2-48ee-ae79-030bbd51b07d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cc73cc28-7f01-45b9-8ca9-e911a31ec547"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e7f22b9a-96f3-4af8-be4a-0880ffbcbaee"));
        }
    }
}
