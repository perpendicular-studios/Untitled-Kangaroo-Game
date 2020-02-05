using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CustomTreeEditorWindow : EditorWindow {

    [Header("References")]
    public Terrain terrain;
    
    [MenuItem ("Tools/Terrain")]
    static void Init()
    {
        CustomTreeEditorWindow window = (CustomTreeEditorWindow)GetWindow(typeof(CustomTreeEditorWindow));
    }

    void OnGUI()
    {
        terrain = (Terrain)EditorGUILayout.ObjectField(terrain, typeof(Terrain), true);
        if (GUILayout.Button("Convert to objects"))
        {
            Convert();
        }
        if (GUILayout.Button("Clear generated trees"))
        {
            Clear();
        }
    }

    public void Convert()
    {
        TerrainData data = terrain.terrainData;
        float width = data.size.x;
        float height = data.size.z;
        float y = data.size.y;

        GameObject parent = GameObject.Find("Tree Generator");
        if(parent == null)
        {
            parent = new GameObject("Tree Generator");
        } 

        foreach(TreeInstance tree in data.treeInstances)
        {
            if (tree.prototypeIndex >= data.treePrototypes.Length) continue;
            var _tree = data.treePrototypes[tree.prototypeIndex].prefab;
            Vector3 position = new Vector3(tree.position.x * width, tree.position.y * y, tree.position.z * height) + terrain.transform.position;
            Vector3 scale = new Vector3(tree.widthScale, tree.heightScale, tree.widthScale);
            GameObject obj = Instantiate(_tree, position, Quaternion.Euler(0f, Mathf.Rad2Deg * tree.rotation, 0f), parent.transform) as GameObject;
            obj.tag = _tree.tag;
            obj.transform.localScale = scale;
        }

        TreeInstance[] tmpArray = new TreeInstance[0];
        Terrain.activeTerrain.terrainData.treeInstances = tmpArray;
    }

    public void Clear()
    {
        DestroyImmediate(GameObject.Find("Tree Generator"));
    }
}
