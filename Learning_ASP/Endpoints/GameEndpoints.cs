
using Learning_ASP.Dtos;

namespace Learning_ASP.Entities;

public static class GameEndpoints
{


    private readonly static List<GameDTO> games =
   [
    new GameDTO(1, "The Legend of Zelda: Breath of the Wild", "Action-adventure", 59.99m, new DateOnly(2017, 3, 3)),
    new GameDTO(2, "God of War", "Action-adventure", 49.99m, new DateOnly(2018, 4, 20)),
    new GameDTO(3, "Minecraft", "Sandbox", 26.95m , new DateOnly(2011, 11, 18)),
    new GameDTO(4, "The Witcher 3: Wild Hunt", "RPG", 39.99m , new DateOnly(2015, 5, 19)),
    new GameDTO(5, "Among Us", "Party", 4.99m , new DateOnly(2018, 6, 15))
   ];

    public static RouteGroupBuilder MapGameEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("games").WithParameterValidation();


        var GetGameById = "GetGameById";

        group.MapGet("/", () => games);
        group.MapGet("/{id}", (int id) => games.Find(g => g.ID == id)).WithName(GetGameById);

        group.MapPost("/", (CreateGameDTO newGame) =>
        {
            var nextId = games.Max(g => g.ID) + 1;
            var gameToAdd = new GameDTO(nextId, newGame.Name, newGame.Genre, newGame.Price, newGame.ReleaseDate);
            games.Add(gameToAdd);
            return Results.CreatedAtRoute(GetGameById, new { id = gameToAdd.ID }, gameToAdd);
        });

        group.MapPut("/{id}", (int id, UpdateGameDTO updatedGame) =>
        {
            var index = games.FindIndex(g => g.ID == id);
            games[index] = new GameDTO(id, updatedGame.Name, updatedGame.Genre, updatedGame.Price, updatedGame.ReleaseDate);
            return Results.NoContent();

        });

        group.MapDelete("/{id}", (int id) =>
        {
            games.RemoveAll(g => g.ID == id);
            return Results.NoContent();
        });

        return group;

    }


}
