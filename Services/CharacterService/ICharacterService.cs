using System.Collections.Generic;
using System.Threading.Tasks;
using EFwebapi.Models;

namespace EFwebapi.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<ServiceResponse<List<Character>>> GetAllCharacters();

        Task<ServiceResponse<Character>> GetCharacterById(int id);

        Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter);
    }
}