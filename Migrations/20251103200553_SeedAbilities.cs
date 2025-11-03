using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace W9_assignment_template.Migrations
{
    /// <inheritdoc />
    public partial class SeedAbilities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("SET IDENTITY_INSERT Abilities ON");

            migrationBuilder.Sql("INSERT INTO Abilities (Id, Name, Description, AbilityType, Shove, Taunt) VALUES (1, 'Shove', 'Player pushes the target back.', 'PlayerAbility', 1, 0)");
            migrationBuilder.Sql("INSERT INTO Abilities (Id, Name, Description, AbilityType, Shove, Taunt) VALUES (2, 'Taunt', 'Goblin taunts the player.', 'GoblinAbility', 0, 1)");

            migrationBuilder.Sql("SET IDENTITY_INSERT Abilities OFF");

            migrationBuilder.Sql("INSERT INTO CharacterAbilities (AbilitiesId, CharactersId) VALUES (1, 3)");
            migrationBuilder.Sql("INSERT INTO CharacterAbilities (AbilitiesId, CharactersId) VALUES (2, 1)");
            migrationBuilder.Sql("INSERT INTO CharacterAbilities (AbilitiesId, CharactersId) VALUES (2, 2)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM CharacterAbilities WHERE AbilitiesId IN (1, 2)");

            migrationBuilder.Sql("DELETE FROM Abilities WHERE Id IN (1, 2)");
        }
    }
}
