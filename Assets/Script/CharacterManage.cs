using Mono.Cecil;
using UnityEngine;
using Unity.VisualScripting;
public class CharacterDate : MonoBehaviour
{
    public static CHARACTER charaCter;
    public static int[] FirstCharaHp = new int[4] { 2000, 3000, 1000, 1700 };
    public enum CHARACTER
    {
        Gunner,
        MudMonster,
        Momotarou,
        Picher,
    }
}

