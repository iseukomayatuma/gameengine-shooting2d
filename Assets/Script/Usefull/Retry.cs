using UnityEngine;
using UnityEngine.SceneManagement;
public class Retry : MonoBehaviour
{
 public void BackScene()
    {
        SceneManager.LoadScene("CharaSelectScene");
    }
}
