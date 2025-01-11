using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(treeScript))]

public class TreeEditor : Editor
{

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        treeScript tree = (treeScript)target;

        if (GUILayout.Button("Generate Folliage"))
        {
            tree.ActivateFoliage();
        }
    }

}
