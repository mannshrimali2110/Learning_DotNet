
namespace Learning_ASP.Dtos;

public record class GameDTO(
    int ID,
    string Name,
    string Genre,
    decimal Price,
    DateOnly ReleaseDate
    );
