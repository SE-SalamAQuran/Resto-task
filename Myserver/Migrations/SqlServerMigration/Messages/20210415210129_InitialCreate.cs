using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Myserver.Migrations.SqlServerMigration.Messages
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    usrName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Conversation",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    f_userid = table.Column<int>(type: "int", nullable: true),
                    s_userid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conversation", x => x.id);
                    table.ForeignKey(
                        name: "FK_Conversation_User_f_userid",
                        column: x => x.f_userid,
                        principalTable: "User",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Conversation_User_s_userid",
                        column: x => x.s_userid,
                        principalTable: "User",
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
                    senderID = table.Column<int>(type: "int", nullable: false),
                    receiverID = table.Column<int>(type: "int", nullable: false),
                    msg_content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    convid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.id);
                    table.ForeignKey(
                        name: "FK_Messages_Conversation_convid",
                        column: x => x.convid,
                        principalTable: "Conversation",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Conversation_f_userid",
                table: "Conversation",
                column: "f_userid");

            migrationBuilder.CreateIndex(
                name: "IX_Conversation_s_userid",
                table: "Conversation",
                column: "s_userid");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_convid",
                table: "Messages",
                column: "convid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Conversation");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
