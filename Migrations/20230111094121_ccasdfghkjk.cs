using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TESTKUSUM.Migrations
{
    public partial class ccasdfghkjk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c7b013f0-5201-4317-abd8-c211f91b7330", "2", "Student", "Student" },
                    { "fab4fac1-c546-41de-aebc-a14da6895711", "1", "Teacher", "Teacher" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0b2b8ee3-ef48-41e9-9793-37f9364ba107", 0, "591e76c8-07a2-4e09-8bd7-591234860bef", "Sham@gmail.com", false, false, null, "SHAM@GMAIL.COM", null, "AQAAAAEAACcQAAAAEGbFgb+I5CzxJxZIeyVtgbaIJW1VINaaoR8byi7xiZ8i+RjHy7NZ2McOoAnuldimuw==", "1234567890", false, "081f055f-89d3-481b-9ce0-72baebd3498b", false, "Sham" },
                    { "11bef6cb-6c76-4e3b-a074-69dea565b837", 0, "fe7c24fc-da9c-4725-8e4d-367254dc9ba5", "Kajal@gmail.com", false, false, null, "KAJAL@GMAIL.COM", null, "AQAAAAEAACcQAAAAEGo2OLsO6Umuv2ioJn2Sf3Hf7wA01Sa67VGcicKTLWWCwOrFuCOBsU3GBMpzSREamA==", "1234567890", false, "9e36a63c-fb61-4414-979d-444b31fcb920", false, "Kajal" },
                    { "2d9d8997-bcb8-4ec9-8047-9562e0f75d22", 0, "39de9c07-7a98-4fec-b443-ccac34ef2084", "William@gmail.com", false, false, null, "WILLIAM@GMAIL.COM", null, "AQAAAAEAACcQAAAAEN2sQGWFfTFX1ApIoqXNwXGzIn0V+5pt8t3/YVbDXvhrvDg2aPVfodfoKX9b2hGSLg==", "1234567890", false, "e95f890b-e784-40ef-911d-93b5d0025d4a", false, "William" },
                    { "65223917-a64f-49b6-81c1-f54c88de0b21", 0, "77e54d3b-724e-489c-b252-aab7f1d0be3c", "Babita@gmail.com", false, false, null, "BABITA@GMAIL.COM", null, "AQAAAAEAACcQAAAAEGE3MONWxFaO+1FMw+cWhw/B+Q1KAP+USzzqYAE9Zvnfiemvqs6Gyn6U/XyYqscJuw==", "1234567890", false, "191781b6-1bec-4034-9421-03edf2f2167f", false, "Babita" },
                    { "6cc9459d-281c-4d85-b73b-b79fc0256043", 0, "902028d4-4406-4575-8bca-87a227899061", "Ram@gmail.com", false, false, null, "RAM@GMAIL.COM", null, "AQAAAAEAACcQAAAAEJd8lEoDqZKccyZA1r3M5fpTvtKqsg9or2GNr7EreHwdB6pRixfNXVI6E6n29wL2OQ==", "1234567890", false, "b9f95e01-7fb2-4893-ba51-cf41b5bca6ca", false, "Ram" },
                    { "a4dc1bd9-75c1-4a53-b616-42a9edfebba8", 0, "f76ce7d6-3387-4484-8cea-d518d79812a7", "Geta@gmail.com", false, false, null, "GETA@GMAIL.COM", null, "AQAAAAEAACcQAAAAEDtuadDp4uhwjNruM7QWh19oCiH+lRwmdpKSoU//B+1poBokbS8gT/7zjZxKuFtlpQ==", "1234567890", false, "0a019119-0ac6-4d20-b790-3ad28a999f9f", false, "Geta" },
                    { "b47d935c-0689-4112-9305-ae319fef394d", 0, "3d6f0ae4-6a9f-4bf7-a2c9-601b073e0560", "Niki@gmail.com", false, false, null, "NIKI@GMAIL.COM", null, "AQAAAAEAACcQAAAAEMnjRIksgSJES+hD87mKnxY4Xs3USFyQ1xEgxvYImve7DmuwVyW8+qJsHBxcO8gUUQ==", "1234567890", false, "35a57612-a51a-4905-828e-66e092d8d927", false, "Niki" },
                    { "ba3f2090-64de-48ee-9586-4aa2b02bfb68", 0, "156c4d35-fe88-49b9-8eee-0c699596859f", "Krina@gmail.com", false, false, null, "KRINA@GMAIL.COM", null, "AQAAAAEAACcQAAAAEJJ+7DdiD7XgscIbusaaluM1R4vtBGfUBFr/tmgAKrnGVSdKZ+l6A/OgRI+a5i81lw==", "1234567890", false, "e6fb0be1-5b42-4b12-a47d-96af82d86313", false, "Krina" },
                    { "c6a28bf5-090d-4ba3-8bdf-b494301a0a6d", 0, "55473201-4ce8-4a93-bd0a-8771ecc57f2e", "Isaan@gmail.com", false, false, null, "ISAAN@GMAIL.COM", null, "AQAAAAEAACcQAAAAEKEKmBkAsCSFngDD5jtb/kiq8kaZchvYeKVB3zflmhCW3ObMmeC03ujamepApo+tIA==", "1234567890", false, "2bd8030d-789f-4eb2-a336-56f6ea2866d2", false, "Isaan" },
                    { "dc98e0e3-f296-4f2a-aee3-45c0cc56dab2", 0, "8b274dbd-084e-4fd4-8599-133acf1c9603", "Kitu@gmail.com", false, false, null, "KITU@GMAIL.COM", null, "AQAAAAEAACcQAAAAEHw3+TTnPgH4msX3+a65j/GOz//mf/+btiCSoAvIyBhq6uSrrQizJF/7dG+D5fOi1Q==", "1234567890", false, "1f0e9c10-277a-4108-bd5d-e86a432b7b48", false, "Kitu" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "fab4fac1-c546-41de-aebc-a14da6895711", "0b2b8ee3-ef48-41e9-9793-37f9364ba107" },
                    { "fab4fac1-c546-41de-aebc-a14da6895711", "11bef6cb-6c76-4e3b-a074-69dea565b837" },
                    { "fab4fac1-c546-41de-aebc-a14da6895711", "2d9d8997-bcb8-4ec9-8047-9562e0f75d22" },
                    { "fab4fac1-c546-41de-aebc-a14da6895711", "65223917-a64f-49b6-81c1-f54c88de0b21" },
                    { "fab4fac1-c546-41de-aebc-a14da6895711", "6cc9459d-281c-4d85-b73b-b79fc0256043" },
                    { "fab4fac1-c546-41de-aebc-a14da6895711", "a4dc1bd9-75c1-4a53-b616-42a9edfebba8" },
                    { "fab4fac1-c546-41de-aebc-a14da6895711", "b47d935c-0689-4112-9305-ae319fef394d" },
                    { "fab4fac1-c546-41de-aebc-a14da6895711", "ba3f2090-64de-48ee-9586-4aa2b02bfb68" },
                    { "fab4fac1-c546-41de-aebc-a14da6895711", "c6a28bf5-090d-4ba3-8bdf-b494301a0a6d" },
                    { "fab4fac1-c546-41de-aebc-a14da6895711", "dc98e0e3-f296-4f2a-aee3-45c0cc56dab2" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
