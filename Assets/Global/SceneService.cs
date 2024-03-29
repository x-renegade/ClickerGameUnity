using UnityEngine.SceneManagement;

public class SceneService {
    public SceneService(string sceneName) {
        SceneManager.LoadScene(sceneName);
    }

    public void LoadScene(string sceneName) {
        SceneManager.LoadScene(sceneName);
    }
}