using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayer : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    [SerializeField] private List<GameObject> spawnPoints;
    [SerializeField] private SpawnPointData spawnPointData;
    // Start is called before the first frame update
    void Start()
    {   
        // var found = false;
        var spawnPointName = spawnPointData.spawnPointName;
        foreach (var spawnPoint in spawnPoints)
        {
            if (spawnPoint.name == spawnPointName)
            {
                Player.transform.position = spawnPoint.transform.position;
                // found = true;
                break;
            }
        }
        // if (!found)
        // {
        //     Debug.LogError("Could not find spawn point " + spawnPointName);
        //     Player.transform.position.Set(spawnPoints[0].transform.position.x, spawnPoints[0].transform.position.y, Player.transform.position.z);
        // }
    }
}
