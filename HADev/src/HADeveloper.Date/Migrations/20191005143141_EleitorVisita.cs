using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HADev.Delivery.Date.Migrations
{
    public partial class EleitorVisita : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
          

            migrationBuilder.CreateTable(
                name: "Eleitor",
                columns: table => new
                {
                    EleitorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 200, nullable: false),
                    Titulo = table.Column<string>(nullable: true),
                    Apelido = table.Column<string>(nullable: true),
                    EstadoId = table.Column<int>(nullable: false),
                    CidadeId = table.Column<int>(nullable: false),
                    BairroId = table.Column<int>(nullable: false),
                    Endereco = table.Column<string>(maxLength: 200, nullable: false),
                    Numero = table.Column<string>(maxLength: 20, nullable: true),
                    Complemento = table.Column<string>(nullable: true),
                    Celular = table.Column<string>(maxLength: 20, nullable: false),
                    Telefone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Sexo = table.Column<int>(nullable: false),
                    Cep = table.Column<string>(nullable: true),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    EstadoCivil = table.Column<int>(nullable: false),
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    Obs = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eleitor", x => x.EleitorId);
                    table.ForeignKey(
                        name: "FK_Eleitor_Bairro_BairroId",
                        column: x => x.BairroId,
                        principalTable: "Bairro",
                        principalColumn: "BairroId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Eleitor_Cidade_CidadeId",
                        column: x => x.CidadeId,
                        principalTable: "Cidade",
                        principalColumn: "CidadeId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Eleitor_Estado_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estado",
                        principalColumn: "EstadoId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Visista",
                columns: table => new
                {
                    VisitaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EleitorId = table.Column<int>(nullable: false),
                    DataVisita = table.Column<DateTime>(nullable: false),
                    Obs = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visista", x => x.VisitaId);
                    table.ForeignKey(
                        name: "FK_Visista_Eleitor_EleitorId",
                        column: x => x.EleitorId,
                        principalTable: "Eleitor",
                        principalColumn: "EleitorId",
                        onDelete: ReferentialAction.Cascade);
                });

           

            migrationBuilder.CreateIndex(
                name: "IX_Eleitor_BairroId",
                table: "Eleitor",
                column: "BairroId");

            migrationBuilder.CreateIndex(
                name: "IX_Eleitor_CidadeId",
                table: "Eleitor",
                column: "CidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Eleitor_EstadoId",
                table: "Eleitor",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Visista_EleitorId",
                table: "Visista",
                column: "EleitorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.DropTable(
                name: "Visista");

            migrationBuilder.DropTable(
                name: "Eleitor");
        }
    }
}
