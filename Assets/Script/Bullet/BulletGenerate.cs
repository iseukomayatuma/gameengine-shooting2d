using Unity.VisualScripting;
using UnityEngine;

public class BulletGenerate : MonoBehaviour
{
    GameObject Bullet;
    CharacterManage charactermanage; PlayCharaGenerate playcharactergenerate;
    PlayCharacterController playcharactercontoroller;
    float cooltime = 10.0f,killmovetime = 0.0f;
    bool usedkillmove = false;
    GameObject kill_move_button;
    void Start()
    {
        GameObject character_manage = GameObject.Find("CharacterManager");   GameObject character_generater = GameObject.Find("CharacterGenerater"); GameObject character_contoroller = GameObject.Find("CharacterController");
        charactermanage = character_manage.GetComponent<CharacterManage>(); playcharactergenerate = character_generater.GetComponent<PlayCharaGenerate>();
        playcharactercontoroller = character_contoroller.GetComponent< PlayCharacterController>();
        kill_move_button = GameObject.Find("KillMoveButton");
    }
    void Update()
    {
     killmovetime = Time.deltaTime;
        if(cooltime < killmovetime)
        {
            usedkillmove = false;
        }
        if(usedkillmove == true)
        {
            kill_move_button.SetActive(false);
        }
        else if(usedkillmove == false)
        {
            kill_move_button.SetActive(true);
        }
    }
    public void CreateBullet()
    {
        Bullet = Instantiate(charactermanage.Bullets[(int)CharacterManage.charaCter]);
        GenerateBulletPos();
    }
    public void GenerateBulletPos()
    {
        Bullet.transform.position = playcharactercontoroller.playerpos;
    }
    public void KillMove()
    {
        Bullet = Instantiate(charactermanage.Bullets[(int)CharacterManage.charaCter]);
        GenerateKillMoveBulletPos();
    }
    public void GenerateKillMoveBulletPos()
    {
        Bullet = Instantiate(charactermanage.Bullets[4]);
        Bullet.transform.position = playcharactercontoroller.playerpos;
    }
    public void ChangeFlag()
    {
        usedkillmove = true;
    }
}
