using UnityEngine;

public class CodeStrage: MonoBehaviour 
{
    public SceneLoad sceneLoad;
    public void Start()
    {
        GameObject scene_manage = GameObject.Find("SceneManager");
        sceneLoad = scene_manage.GetComponent<SceneLoad>();
    }
}