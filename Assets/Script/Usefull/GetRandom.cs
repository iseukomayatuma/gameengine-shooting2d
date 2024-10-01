using UnityEngine;

public class GetRandom : MonoBehaviour
{
    public static int GetRandomValue(int min, int max)
    {
        return Random.Range(min, max + 1);
    }
    public static float GetRandomFloat(float min, float max)
    {
        return Random.Range(min, max + 1);
    }
}
