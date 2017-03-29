using UnityEngine;

public class MainSceneManager : MonoBehaviour {

    private GameObject paddlePrefab;
	private GameObject brickPrefab;



	/// <summary>
	/// Awake is called when the script instance is being loaded.
	/// </summary>
	void Awake()
	{
        string temp = SceneManagerConstants.PrefabPaths.prefabRoot;
        //paddlePrefab = AssetDatabase.LoadAssetAtPath<GameObject>("");
    }
    // Use this for initialization
    void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
}
