using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication4.Migrations
{
    public partial class updateWorkFlow : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkFlows_skills_SkillId",
                table: "WorkFlows");

            migrationBuilder.AlterColumn<int>(
                name: "SkillId",
                table: "WorkFlows",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkFlows_skills_SkillId",
                table: "WorkFlows",
                column: "SkillId",
                principalTable: "skills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkFlows_skills_SkillId",
                table: "WorkFlows");

            migrationBuilder.AlterColumn<int>(
                name: "SkillId",
                table: "WorkFlows",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkFlows_skills_SkillId",
                table: "WorkFlows",
                column: "SkillId",
                principalTable: "skills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
