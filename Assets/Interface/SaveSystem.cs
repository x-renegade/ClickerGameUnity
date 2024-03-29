using Newtonsoft.Json;
using UnityEngine;

public static class SaveSystem {
    private const string PATH_KEY = "save_path";

    public static void LocalSave(GameData gameData) {
        string dataString = JsonConvert.SerializeObject(gameData);
        PlayerPrefs.SetString(PATH_KEY, dataString);
    }

    public static GameData LoadLocalSave() {
        string dataString = PlayerPrefs.GetString(PATH_KEY);
        return JsonConvert.DeserializeObject<GameData>(dataString);
    }
}
