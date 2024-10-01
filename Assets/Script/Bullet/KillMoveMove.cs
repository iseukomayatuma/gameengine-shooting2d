using UnityEngine;

public class KillMovemove : MonoBehaviour
{
    float movey = 0.025f;
    Vector3 bulletpos;
    void Start()
    {
        bulletpos = this.transform.position;
    }
    void Update()
    {
        bulletpos.y += movey;
        this.transform.position = bulletpos;
        if (IsinPosition.PosManage(this.transform.position) == false)
            Delete.DeleteObject(this.gameObject);
    }
}
