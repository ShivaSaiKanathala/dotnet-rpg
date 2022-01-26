using System.Collections.Generic;
using System.Threading.Tasks;
using dotnet_rpg.DTO.Character;
using dotnet_rpg.Models;

namespace dotnet_rpg.Services.CharacterService
{
    public interface ICharacterService
    {
         Task<ServiceResponse<List<GetCharacterDTO>>> GetAllCharacters();
         Task<ServiceResponse<GetCharacterDTO>> GetCharacterById(int id);
         Task<ServiceResponse<List<GetCharacterDTO>>> AddCharacter(AddCharacterDTO newCharacter);
    }
}