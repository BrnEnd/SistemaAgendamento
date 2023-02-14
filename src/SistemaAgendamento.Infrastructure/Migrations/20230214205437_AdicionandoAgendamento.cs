using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaAgendamento.Repository.Migrations
{
    public partial class AdicionandoAgendamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agendamento",
                columns: table => new
                {
                    IdAgendamento = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    AgendaIdAgenda = table.Column<int>(type: "int", nullable: true),
                    DiaHoraAgendamento = table.Column<DateTime>(type: "DateTime", nullable: false),
                    StatusAgendamento = table.Column<string>(type: "char", nullable: false),
                    ClienteIdCliente = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agendamento", x => x.IdAgendamento);
                    table.ForeignKey(
                        name: "FK_Agendamento_Agenda_AgendaIdAgenda",
                        column: x => x.AgendaIdAgenda,
                        principalTable: "Agenda",
                        principalColumn: "IdAgenda",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Agendamento_Cliente_ClienteIdCliente",
                        column: x => x.ClienteIdCliente,
                        principalTable: "Cliente",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Agendamento_AgendaIdAgenda",
                table: "Agendamento",
                column: "AgendaIdAgenda");

            migrationBuilder.CreateIndex(
                name: "IX_Agendamento_ClienteIdCliente",
                table: "Agendamento",
                column: "ClienteIdCliente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agendamento");
        }
    }
}
