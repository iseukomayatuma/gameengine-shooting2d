using UnityEngine;

public class PlayCharacterController : MonoBehaviour
{
    public Vector3 playerpos;
    float movex = 0.5f, movey = 0.5f;
    PlayCharaGenerate playcharactergenerate;
    void Start()
    {
        Invoke("GetPlayCharacterPos", 0.2f);
        GameObject character_generater = GameObject.Find("CharacterGenerater");
        playcharactergenerate = character_generater.GetComponent<PlayCharaGenerate>();
    }
    public void MoveLeft()
    {
        if (IsInStage(playerpos, -movex, true))
        {
            playerpos.x += -movex;
            playcharactergenerate.player.transform.position = playerpos;
        }
    }
    public void MoveRight()
    {
        if (IsInStage(playerpos, movex, true))
        {
            playerpos.x += movex;
            playcharactergenerate.player.transform.position = playerpos;
        }    
    }
    public void Moveup()
    {
        if (IsInStage(playerpos, movey, false))
        {
            playerpos.y += movey;
            playcharactergenerate.player.transform.position = playerpos;
        }
    }
    public void MoveDown()
    {
        if (IsInStage(playerpos, -movey, false))
        {
            playerpos.y += -movey;
            playcharactergenerate.player.transform.position = playerpos;
        }
    }
    void GetPlayCharacterPos()
    {
        playerpos = playcharactergenerate.player.transform.position;
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
