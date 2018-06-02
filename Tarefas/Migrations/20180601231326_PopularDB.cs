using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Tarefas.Migrations {
    public partial class PopularDB : Migration {
        protected override void Up (MigrationBuilder migrationBuilder) {
            migrationBuilder.Sql ("INSERT INTO Tarefas (DataConclusao, isCompleta, Nome) VALUES ('20181010 08:00:00', 1, 'Tarefa 1')");
            migrationBuilder.Sql ("INSERT INTO Tarefas (DataConclusao, isCompleta, Nome) VALUES ('20181011 08:00:00', 0, 'Tarefa 2')");
            migrationBuilder.Sql ("INSERT INTO Tarefas (DataConclusao, isCompleta, Nome) VALUES ('20181012 08:00:00', 0, 'Tarefa 3')");

        }

        protected override void Down (MigrationBuilder migrationBuilder) {
            migrationBuilder.Sql ("DELETE FROM  Tarefas");

        }
    }
}