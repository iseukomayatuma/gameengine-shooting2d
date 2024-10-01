using System.Collections;
using UnityEngine;

public class OugiMove : MonoBehaviour
{
    float movey = 0.05f;
    float movex = 0.025f;
    int random;
    bool comebackflag = false;
    Vector3 bulletpos;
    public enum WHEREVECTLE
    {
        Plusx,
        Minusx,
        Plusy,
    }
    void Start()
    {
        bulletpos = this.transform.position;
    }
    void Update()
    {
        switch (Random.Range(0, 3))
        {
            case 0: bulletpos.y += movey; break;
            case 1: bulletpos.x += movex; break;
            case 2: bulletpos.x -= movex; break;
        }
        this.transform.position = bulletpos;
        if (comebackflag == false && IsinPosition.PosManage(this.transform.position) == false)
        {
            ComeBack(IsinPosition.BallPosManage(this.transform.position));
        }
        else if (comebackflag == true && (this.transform.position.y < -6.0f || this.transform.position.y > 10.0f))
            Delete.Destroy(this.gameObject);
    }
    void ComeBack(int wherevectle)
    {
        switch (wherevectle)
        {
            case 0: movex *= -1.0f;break; 
            case 1: movex *= 1.5f; break;
            case 2: movey *= -1.0f; break;
        }
        comebackflag = true;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
            Destroy(gameObject);
    }
}
