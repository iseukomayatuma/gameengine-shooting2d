using UnityEngine;

public class IsinPosition : MonoBehaviour
{
    public static bool PosManage(Vector3 terget)
    {
        if (terget.x > 5.0f || terget.x < -5.0f || terget.y > 12.0f || terget.y < -12.0f)
            return false;
        return true;
    }
    public static int BallPosManage(Vector3 terget)
    {
        if (terget.x > 3.0f) return 0;
        else if (terget.x < -3.0f) return 1;
        else return 2;
    }
}
