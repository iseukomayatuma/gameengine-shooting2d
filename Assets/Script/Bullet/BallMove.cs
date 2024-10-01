using UnityEngine;

public class BallMove : MonoBehaviour
{
    float movey = 0.025f, movex = 0.01f;
    float lotatez = 5.0f;
    float diffusion = 0.2f, shirink = 0.1f;
    Vector3 bulletpos,bulletlotate;
    void Start()
    {
        bulletpos = this.transform.position; bulletlotate = this.transform.eulerAngles;
    }
    void Update()
    {
        if (GetRandom.GetRandomValue(0,1) == 0) movex *= -1;
        bulletpos.y += movey; bulletpos.x += movex;
        bulletlotate.z += lotatez;
        this.transform.position = bulletpos; this.transform.eulerAngles += bulletlotate;
        if(Input.GetMouseButtonDown(0)) DiffusionChange();
        if (IsinPosition.PosManage(this.transform.position) == false)
            Delete.DeleteObject(this.gameObject);
    }
    void DiffusionChange()
    {
        switch (GetRandom.GetRandomValue(0, 1))
        {
            case 0: movex += diffusion; break;
            case 1: movex -= shirink; break;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
            Destroy(gameObject);
    }
}
