using UnityEngine;

public class MrBulletsBulletMove : MonoBehaviour
{
    float movey = -0.005f;
    Vector3 bulletpos;
    LifeManager lifemanager;
    void Start()
    {
        bulletpos = this.transform.position;
        GameObject life_manager = GameObject.Find("LifeManager");
        lifemanager = life_manager.GetComponent<LifeManager>();
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
        if (collision.gameObject.CompareTag("PlayChara"))
        {
            lifemanager.NowPlayCharaHp--;
            lifemanager.IfLifeOver();
            if (lifemanager.NowPlayCharaHp != 0)
                lifemanager.lifes[lifemanager.NowPlayCharaHp].SetActive(false);
            Destroy(gameObject);
        }
        else if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
        }
    }
}
