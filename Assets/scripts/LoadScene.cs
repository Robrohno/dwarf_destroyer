using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    [SerializeField] private SceneAsset sceneToLoad;
    [SerializeField] private string spawnPointName;
    [SerializeField] private SpawnPointData spawnPointData;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collided with " + collision.gameObject.tag);
        if (collision.gameObject.CompareTag("player"))
        {
            var try1 = spawnPointData.setSpawnPointName(spawnPointName);
            if (try1)
            {
                SceneManager.LoadScene(sceneToLoad.name);
            } else {
                var try2 = spawnPointData.setSpawnPointName(spawnPointName);
                if (try2)
                {
                    SceneManager.LoadScene(sceneToLoad.name);
                } else {
                    Debug.LogError("Could not set spawn point name");
                }
            }
        }
    }
}
