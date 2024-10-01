using Mono.Cecil;
using UnityEngine;
using Unity.VisualScripting;
public class CharacterManage : MonoBehaviour
{
    public GameObject[] Bullets = new GameObject[5];
    public static CHARACTER charaCter;
    public static int FirstCharaHp = 3;
    public enum CHARACTER
    {
        Gunner,
        MudMonster,
        Momotarou,
        Picher,
    }
}

