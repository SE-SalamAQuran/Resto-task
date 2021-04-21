using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Myserver.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Conversations",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    f_userid = table.Column<int>(type: "int", nullable: true),
                    s_userid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conversations", x => x.id);
                    table.ForeignKey(
                        name: "FK_Conversations_Users_f_userid",
                        column: x => x.f_userid,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Conversations_Users_s_userid",
                        column: x => x.s_userid,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    msg_status = table.Column<int>(type: "int", nullable: false),
                    conversationid = table.Column<int>(type: "int", nullable: true),
                    senderid = table.Column<int>(type: "int", nullable: true),
                    receiverid = table.Column<int>(type: "int", nullable: true),
                    msg_content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    msg_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    msg_time = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.id);
                    table.ForeignKey(
                        name: "FK_Messages_Conversations_conversationid",
                        column: x => x.conversationid,
                        principalTable: "Conversations",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Messages_Users_receiverid",
                        column: x => x.receiverid,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Messages_Users_senderid",
                        column: x => x.senderid,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Conversations_f_userid",
                table: "Conversations",
                column: "f_userid");

            migrationBuilder.CreateIndex(
                name: "IX_Conversations_s_userid",
                table: "Conversations",
                column: "s_userid");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_conversationid",
                table: "Messages",
                column: "conversationid");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_receiverid",
                table: "Messages",
                column: "receiverid");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_senderid",
                table: "Messages",
                column: "senderid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Conversations");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
