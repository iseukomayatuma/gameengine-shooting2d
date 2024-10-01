using UnityEngine;
using UnityEngine.SceneManagement;

public class MrBulletsBulletGenerate : MonoBehaviour
{
    public GameObject[] enemyBullets = new GameObject[3];
    float mrbulleteshootspan = 0.05f, mrbullteshottime = 0.0f;
    BulletGenerate bulletegenerate;
    GameObject EnemyBullet;

    void Start()
    {
        GameObject bullete_generater = GameObject.Find("BulletGenerater");
        bulletegenerate = bullete_generater.GetComponent<BulletGenerate>();
    }

    void Update()
    {
        mrbullteshottime += Time.deltaTime;
        if (mrbullteshottime >= mrbulleteshootspan)
        {
            EnemyBullet = Instantiate(enemyBullets[0]);
            Generatepos(EnemyBullet);
            mrbullteshottime = 0.0f;
        }
    }
    void Generatepos(GameObject bulltes)
    {
        bulltes.transform.position = this.transform.position;
    }
}
