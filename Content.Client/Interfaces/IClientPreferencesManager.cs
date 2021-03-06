using Content.Shared.Preferences;

namespace Content.Client.Interfaces
{
    public interface IClientPreferencesManager
    {
        GameSettings Settings { get; }
        PlayerPreferences Preferences { get; }
        void Initialize();
        void SelectCharacter(ICharacterProfile profile);
        void SelectCharacter(int slot);
        void UpdateCharacter(ICharacterProfile profile, int slot);
        void CreateCharacter(ICharacterProfile profile);
        void DeleteCharacter(ICharacterProfile profile);
        void DeleteCharacter(int slot);
    }
}
