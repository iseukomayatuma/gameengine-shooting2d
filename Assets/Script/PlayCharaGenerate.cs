using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class PlayCharaGenerate : MonoBehaviour
{
    public GameObject[] charaCters = new GameObject[3];
    GameObject playGunner; GameObject playMudMonster;
    GameObject playMomotarou; GameObject playPicher;
    Vector3 generatePos
    void Start()
    {
        switch (CharacterDate.charaCter)
        {
            case CharacterDate.CHARACTER.Gunner:  GameObject playGunner = Instantiate(charaCters[0]); break;
            case CharacterDate.CHARACTER.MudMonster: GameObject playMudMonster = Instantiate(charaCters[1]); break;
            case CharacterDate.CHARACTER.Momotarou: GameObject playMomotarou = Instantiate(charaCters[2]); break;
            case CharacterDate.CHARACTER.Picher: GameObject playPicher = Instantiate(charaCters[3]); break;
        }
    }
    void Update()
    {
        
    }
    Vector3 GeneratePos()
    {
       return 
    }
}
