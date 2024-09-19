using UnityEngine;

public class PlayCharacterController : MonoBehaviour
{
    Vector2 playerpos;
    float movex = 0.5f, movey = 0.5f;
    void Start()
    {
        Invoke("GetPlayCharacterPos", 0.2f);
    }
    void Update()
    {

    }
    public void MoveLeft()
    {
        if (IsInStage(playerpos, -movex, true))
        {
            playerpos.x += -movex;
            PlayCharaGenerate.player.transform.position = playerpos;
        }
    }
    public void MoveRight()
    {
        if (IsInStage(playerpos, movex, true))
        {
            playerpos.x += movex;
            PlayCharaGenerate.player.transform.position = playerpos;
        }    
    }
    public void Moveup()
    {
        if (IsInStage(playerpos, movey, false))
        {
            playerpos.y += movey;
            PlayCharaGenerate.player.transform.position = playerpos;
        }
    }
    public void MoveDown()
    {
        if (IsInStage(playerpos, -movey, false))
        {
            playerpos.y += -movey;
            PlayCharaGenerate.player.transform.position = playerpos;
        }
    }
    void GetPlayCharacterPos()
    {
        playerpos = PlayCharaGenerate.player.transform.position;
    }
    bool IsInStage(Vector2 playerpos, float movevec, bool isx)
    {
        if (isx)
        {
            if (playerpos.x + movevec < -1.75f || playerpos.x + movevec > 2.25f)
                return false;
        }
        else if (playerpos.y + movevec < -4.25f || playerpos.y + movevec > 4.25f){
            return false;
        }
        return true;
    } 
}
