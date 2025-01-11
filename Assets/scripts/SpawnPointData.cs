using UnityEngine;

[CreateAssetMenu]
public class SpawnPointData : ScriptableObject
{
    public string spawnPointName;

    public bool setSpawnPointName(string name)
    {
        try
        {
            spawnPointName = name;
            return true;
        }
        catch (System.Exception)
        {
            return false;
        }
    }
}
