using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class PlayCharaGenerate : MonoBehaviour
{
    public GameObject[] charaCters = new GameObject[4];
    public static GameObject player;
    Vector2 generatePos = new Vector2(-0.02f, -2.85f);
    void Start()
    {
        GenerateCharaCter(CharacterDate.charaCter);
        GeneratePos(player);
    }
    void Update()
    {
        
    }
    void GenerateCharaCter(CharacterDate.CHARACTER choosecharacter)
    {
            player = Instantiate(charaCters[(int)choosecharacter]);
    }
    void GeneratePos(GameObject playchara)
    {
        playchara.transform.position = new Vector2(0.135f, -2.5f);
    }
}
