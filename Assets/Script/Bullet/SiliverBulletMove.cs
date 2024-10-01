using Unity.VisualScripting;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    float movey = 0.05f;
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
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
            Destroy(gameObject);
    }
}