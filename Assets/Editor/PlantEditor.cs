using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(plantScript))]

public class PlantEditor : Editor
{

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        plantScript plant = (plantScript)target;

        if (GUILayout.Button("Generate Folliage"))
        {
            plant.ActivateFoliage();
        }
    }

}
