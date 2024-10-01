using UnityEngine;

public class DemonMove : MonoBehaviour
{
    LifeManager lifemanager;
    void Start()
    {
        GameObject life_manager = GameObject.Find("LifeManager");
        lifemanager = life_manager.GetComponent<LifeManager>();  
    }
    void Update()
    {
        if (IsinPosition.PosManage(this.transform.position) == false)
            Delete.DeleteObject(this.gameObject);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
            Destroy(gameObject);
        {
            lifemanager.NowPlayCharaHp--;
            lifemanager.IfLifeOver();
            if (lifemanager.NowPlayCharaHp != 0)
                lifemanager.lifes[lifemanager.NowPlayCharaHp].SetActive(false);
            Destroy(gameObject);
        }
    }
}
