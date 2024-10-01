using UnityEngine;

public class MrGoustMove : MonoBehaviour
{
    Vector3 mrgoustpos;

    LifeManager lifemanager;
    void Start()
    {
        mrgoustpos = this.transform.position;
        GameObject life_manager = GameObject.Find("LifeManager");
        lifemanager = life_manager.GetComponent<LifeManager>();
    }
    void Update()
    {
        mrgoustpos.y += -0.01f;
        this.transform.position = mrgoustpos; ;
        if (IsinPosition.PosManage(this.transform.position) == false)
            Delete.DeleteObject(this.gameObject);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
            Destroy(gameObject);
        else if (collision.gameObject.CompareTag("PlayChara"))
        {
            lifemanager.NowPlayCharaHp--;
            lifemanager.IfLifeOver();
            if (lifemanager.NowPlayCharaHp != 0) 
            lifemanager.lifes[lifemanager.NowPlayCharaHp].SetActive(false);
            Destroy(gameObject);
        }
    }
}