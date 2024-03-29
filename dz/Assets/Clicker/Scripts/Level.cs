using UnityEngine;

[CreateAssetMenu(fileName = "Level", menuName = "LevelMenu", order = 0)]
public class Level : ScriptableObject {
    [field: SerializeField] public Sprite LevelImage { get; private set; }
    [field: SerializeField] public int LevelScore { get; private set; }
}