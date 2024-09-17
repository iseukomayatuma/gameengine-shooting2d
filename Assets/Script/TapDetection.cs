using UnityEngine;

public class TapDetection: MonoBehaviour
{
    CodeStrage codeStrage;
    private void Start()
    {
        GameObject code_strage = GameObject.Find("CodeStrage");
        codeStrage = code_strage.GetComponent<CodeStrage>();
        
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) codeStrage.sceneLoad.LoadSelectCharaScene();
    }
}
