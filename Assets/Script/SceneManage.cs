using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoad: MonoBehaviour
{
    public void LoadSelectCharaScene()
    {
        SceneManager.LoadScene("CharaSelectScene");
    }
    public void LoadGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }
}
