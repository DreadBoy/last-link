using UnityEditor;
using UnityEngine;

public class CharacterStats : ScriptableObject {

    public float speed;


#if UNITY_EDITOR
    [MenuItem("Assets/Create/Last Link/Character stats")]
    public static void CreateCharacterStats()
    {
        string path = EditorUtility.SaveFilePanelInProject("Create Character stats", "Character stats", "asset", "Create Character stats", "Assets");

        if (string.IsNullOrEmpty(path))
            return;

        CharacterStats asset = CreateInstance<CharacterStats>();

        AssetDatabase.CreateAsset(asset, path);
        AssetDatabase.SaveAssets();

        EditorUtility.FocusProjectWindow();

        Selection.activeObject = asset;
    }
#endif
}
