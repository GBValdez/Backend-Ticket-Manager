using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace tickets.Migrations
{
    /// <inheritdoc />
    public partial class initialTrue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Entity",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nit = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    name = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    email = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    telephone = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entity", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Rol",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rol", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Section",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Section", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: true),
                    location = table.Column<string>(type: "text", nullable: true),
                    responsibleId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.id);
                    table.ForeignKey(
                        name: "FK_Events_Entity_responsibleId",
                        column: x => x.responsibleId,
                        principalTable: "Entity",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Responsible",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EntityId = table.Column<int>(type: "integer", nullable: false),
                    location = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responsible", x => x.id);
                    table.ForeignKey(
                        name: "FK_Responsible_Entity_EntityId",
                        column: x => x.EntityId,
                        principalTable: "Entity",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    clientId = table.Column<int>(type: "integer", nullable: false),
                    password = table.Column<string>(type: "text", nullable: true),
                    email = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.id);
                    table.ForeignKey(
                        name: "FK_User_Entity_clientId",
                        column: x => x.clientId,
                        principalTable: "Entity",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EventDate",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    initDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    finalDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    eventId = table.Column<int>(type: "integer", nullable: false),
                    Eventsid = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventDate", x => x.id);
                    table.ForeignKey(
                        name: "FK_EventDate_Events_Eventsid",
                        column: x => x.Eventsid,
                        principalTable: "Events",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "EventXSection",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SectionId = table.Column<int>(type: "integer", nullable: false),
                    EventId = table.Column<int>(type: "integer", nullable: false),
                    Eventsid = table.Column<int>(type: "integer", nullable: true),
                    price = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventXSection", x => x.id);
                    table.ForeignKey(
                        name: "FK_EventXSection_Events_Eventsid",
                        column: x => x.Eventsid,
                        principalTable: "Events",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_EventXSection_Section_SectionId",
                        column: x => x.SectionId,
                        principalTable: "Section",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RolUser",
                columns: table => new
                {
                    Rolesid = table.Column<int>(type: "integer", nullable: false),
                    Usersid = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolUser", x => new { x.Rolesid, x.Usersid });
                    table.ForeignKey(
                        name: "FK_RolUser_Rol_Rolesid",
                        column: x => x.Rolesid,
                        principalTable: "Rol",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RolUser_User_Usersid",
                        column: x => x.Usersid,
                        principalTable: "User",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    idClient = table.Column<int>(type: "integer", nullable: false),
                    idReceiver = table.Column<int>(type: "integer", nullable: false),
                    idEventDate = table.Column<int>(type: "integer", nullable: false),
                    EventDateid = table.Column<int>(type: "integer", nullable: true),
                    idSection = table.Column<int>(type: "integer", nullable: false),
                    Sectionid = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => x.id);
                    table.ForeignKey(
                        name: "FK_Ticket_Entity_idClient",
                        column: x => x.idClient,
                        principalTable: "Entity",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ticket_Entity_idReceiver",
                        column: x => x.idReceiver,
                        principalTable: "Entity",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ticket_EventDate_EventDateid",
                        column: x => x.EventDateid,
                        principalTable: "EventDate",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Ticket_Section_Sectionid",
                        column: x => x.Sectionid,
                        principalTable: "Section",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_EventDate_Eventsid",
                table: "EventDate",
                column: "Eventsid");

            migrationBuilder.CreateIndex(
                name: "IX_Events_responsibleId",
                table: "Events",
                column: "responsibleId");

            migrationBuilder.CreateIndex(
                name: "IX_EventXSection_Eventsid",
                table: "EventXSection",
                column: "Eventsid");

            migrationBuilder.CreateIndex(
                name: "IX_EventXSection_SectionId",
                table: "EventXSection",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Responsible_EntityId",
                table: "Responsible",
                column: "EntityId");

            migrationBuilder.CreateIndex(
                name: "IX_RolUser_Usersid",
                table: "RolUser",
                column: "Usersid");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_EventDateid",
                table: "Ticket",
                column: "EventDateid");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_idClient",
                table: "Ticket",
                column: "idClient");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_idReceiver",
                table: "Ticket",
                column: "idReceiver");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_Sectionid",
                table: "Ticket",
                column: "Sectionid");

            migrationBuilder.CreateIndex(
                name: "IX_User_clientId",
                table: "User",
                column: "clientId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventXSection");

            migrationBuilder.DropTable(
                name: "Responsible");

            migrationBuilder.DropTable(
                name: "RolUser");

            migrationBuilder.DropTable(
                name: "Ticket");

            migrationBuilder.DropTable(
                name: "Rol");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "EventDate");

            migrationBuilder.DropTable(
                name: "Section");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Entity");
        }
    }
}
