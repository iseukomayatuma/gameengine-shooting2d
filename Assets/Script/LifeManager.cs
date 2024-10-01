using UnityEngine;
using UnityEngine.SceneManagement;

public class LifeManager : MonoBehaviour
{
    SceneLoad sceneload;
    public int NowPlayCharaHp;
    public GameObject[] lifes = new GameObject[3];

    void Start()
    {
        NowPlayCharaHp = CharacterManage.FirstCharaHp;
        GameObject scene_manager = GameObject.Find("SceneManager");
        sceneload = scene_manager.GetComponent<SceneLoad>();
    }
    void Heal()
    {
        if(IsMax() == false) NowPlayCharaHp++;
    }
    bool IsMax()
    {
        return NowPlayCharaHp == CharacterManage.FirstCharaHp;
    }
    public void IfLifeOver()
    {
        if (NowPlayCharaHp < 1) sceneload.LoadGameOverScene();
    }

}