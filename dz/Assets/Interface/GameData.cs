using System;

[Serializable]
public class GameData
{
    public readonly static GameData Instance;
    static GameData()
    {
        Instance = new GameData();
    }
    private GameData() { }

    private int _score;
    public int Score
    {
        get => _score;
        set
        {
            _score = value;
            Save();
        }
    }

    private Score _levelValue;
    public Score LevelValue
    {
        get => _levelValue;
        set
        {
            _levelValue = value;
            Save();
        }
    }

    private int _level;
    public int Level
    {
        get => _level;
        set
        {
            _level = value;
            Save();
        }
    }

    private int _oneAutoClickValue = 1;
    public int OneAutoClickValue
    {
        get => _oneAutoClickValue;
        set
        {
            _oneAutoClickValue = value;
            Save();
        }
    }

    private int _oneSingleClickValue = 1;
    public int OneSingleClickValue
    {
        get => _oneSingleClickValue;
        set
        {
            _oneSingleClickValue = value;
            Save();
        }
    }

    public void Save()
    {
        SaveSystem.LocalSave(this);
    }

    public void Load()
    {
        GameData gameData = SaveSystem.LoadLocalSave();

        if (gameData == null)
        {
            return;
        }

        Score = gameData.Score;
        LevelValue = gameData.LevelValue;
        Level = gameData.Level;
        OneAutoClickValue = gameData.OneAutoClickValue;
        OneSingleClickValue = gameData.OneSingleClickValue;
    }
}
