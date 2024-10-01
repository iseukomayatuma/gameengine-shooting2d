using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class PlayCharaGenerate : MonoBehaviour
{
    public GameObject[] characters = new GameObject[4];
    public GameObject player;
    Vector2 generatePos = new Vector3(-0.02f, -2.85f);
    void Start()
    {
        GenerateCharaCter(CharacterManage.charaCter);
        GeneratePos(player);
    }
    void Update()
    {
        
    }
    void GenerateCharaCter(CharacterManage.CHARACTER choosecharacter)
    {
            player = Instantiate(characters[(int)choosecharacter]);
    }
    void GeneratePos(GameObject playchara)
    {
        playchara.transform.position = new Vector3(0.135f, -2.5f);
    }
}
