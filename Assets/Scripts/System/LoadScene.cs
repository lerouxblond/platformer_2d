using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    [SerializeField] private string sceneName;

    public void LoadSelectedScene()
    {
        SceneManager.LoadScene(sceneName);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.CompareTag("Player"))
        {
            MoveAllToActiveScene();
            SceneManager.LoadScene(sceneName);
        }
    }

 public void MoveAllToActiveScene()
    {
        // Get the active scene
        Scene activeScene = SceneManager.GetActiveScene();

        // Find all objects in DontDestroyOnLoad
        var objects = Object.FindObjectsByType<GameObject>(FindObjectsSortMode.None);

        foreach (var obj in objects)
        {
            // Check if the object's scene is the "DontDestroyOnLoad" scene
            if (obj.scene.name == null || obj.scene.name == "DontDestroyOnLoad")
            {
                SceneManager.MoveGameObjectToScene(obj, activeScene); // Move the object back
            }
        }
    }
}
