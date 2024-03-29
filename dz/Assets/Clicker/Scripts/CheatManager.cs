using UnityEngine;

public class CheatManager : MonoBehaviour {
    private void Update() {
        if (Input.GetMouseButton(0)) {
            LevelBarModel.Instance.TryStartNextLevel(1000);
        }
    }
}