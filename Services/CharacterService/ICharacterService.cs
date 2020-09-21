using System.Collections.Generic;
using System.Threading.Tasks;
using EFwebapi.Models;

namespace EFwebapi.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<List<Character>> GetAllCharacters();

        Task<Character> GetCharacterById(int id);

        Task<List<Character>> AddCharacter(Character newCharacter);
    }
}