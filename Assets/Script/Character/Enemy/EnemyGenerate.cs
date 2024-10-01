using UnityEngine;

public class EnemyGenerate : MonoBehaviour
{
    SceneLoad sceneload;
    public GameObject[] enemyCharacters = new GameObject[3];
    float [] span = { 5.0f, 1.0f, 10.0f };
    float[] time = new float[3];
    int kindofenemy = 3; 
    void Start()
    {
        for (int x = 0; x < kindofenemy; x++) time[x] = 0.0f;
        GameObject scene_manager = GameObject.Find("SceneManager");
        sceneload = scene_manager.GetComponent<SceneLoad>();
    }
    void Update()
    {
        TimeCount();
    }
    void TimeCount()
    {
        for (int x = 0; x < kindofenemy; x++) time[x] += Time.deltaTime;
        IfOverSpan();
    }
    void IfOverSpan()
    {
        for (int x = 0; x < kindofenemy; x++)
            if (time[x] >= span[x])
            {
                Debug.Log(222);
                CreateEnemy(x);
                time[x] = 0f; span[x] -= 0.02f;
            }
    }
    public void CreateEnemy(int x)
    {
        GameObject enemy = Instantiate(enemyCharacters[x]);
        GenerateEnemyPos(x,enemy);
    }
    public void GenerateEnemyPos(int x,GameObject enemy)
    {
           enemy.transform.position = GetEnemyVector(x);
    }
    Vector3 GetEnemyVector(int x)
    {
        Vector3 bornpos = Enemy.FirstEnemyPos[x];
        switch (x) {
            case 0: bornpos.y = GetRandom.GetRandomFloat(-3.0f, 4.0f); return bornpos;
            case 1: bornpos.x = GetRandom.GetRandomFloat(-2.0f, 2.0f); return bornpos;
            default : return bornpos;
        }
    }
    void IfSuvive(float span)
    {
     if(span == 0.0f) sceneload.LoadGameOverScene();
    }
}