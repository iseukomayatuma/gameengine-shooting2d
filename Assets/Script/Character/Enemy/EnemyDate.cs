using UnityEngine;

public class Enemy : MonoBehaviour
{
    public static ENEMYCHARACTER enemyCharaCter;
    public static int[] FirstEnemyCharaHp = new int[3] { 3, 3, 2};
    public static Vector3[] FirstEnemyPos = new[] { new Vector3(3.0f, 0f, 0f), new Vector3(4f, 7.0f, 0f), new Vector3(1.0f, 10.0f, 0f), };
    public enum ENEMYCHARACTER
    {
        MrBullete,
        MrGoust,
        MrDemon,
    }
}
