using UnityEngine;

public class Starter : MonoBehaviour {
    [SerializeField] private SceneName _sceneName;
    [SerializeField] private int _frameRate = 60;
    private SceneService _sceneService;

    void Start() {
        DontDestroyOnLoad(gameObject);
        _sceneService = new SceneService(_sceneName.ToString());
    }

    private void OnValidate() {
        Application.targetFrameRate = _frameRate;
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Alpha1)) {
            _sceneService.LoadScene(SceneName.Example_1.ToString());
        }
        if (Input.GetKeyDown(KeyCode.Alpha2)) {
            _sceneService.LoadScene(SceneName.Example_2.ToString());
        }
        if (Input.GetKeyDown(KeyCode.Alpha3)) {
            _sceneService.LoadScene(SceneName.Example_3.ToString());
        }        
        if (Input.GetKeyDown(KeyCode.Alpha4)) {
            _sceneService.LoadScene(SceneName.Example_4.ToString());
        }        
        if (Input.GetKeyDown(KeyCode.Alpha5)) {
            _sceneService.LoadScene(SceneName.Example_5.ToString());
        }        
        if (Input.GetKeyDown(KeyCode.Alpha6)) {
            _sceneService.LoadScene(SceneName.Example_6.ToString());
        }
    }

    public enum SceneName {
        Example_1,
        Example_2,
        Example_3,
        Example_4,
        Example_5,
        Example_6,
    }
}