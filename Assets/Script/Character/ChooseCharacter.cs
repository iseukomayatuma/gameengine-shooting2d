using UnityEngine;
public class ChooseCharacter : MonoBehaviour
{
    public void SelectGunnner()
    {
        CharacterManage.charaCter = CharacterManage.CHARACTER.Gunner;
    }
    public void SelectMudMonster()
    {
        CharacterManage.charaCter = CharacterManage.CHARACTER.MudMonster;
    }
    public void SelectMomotarou()
    {
        CharacterManage.charaCter = CharacterManage.CHARACTER.Momotarou;
    }
    public void SelectPicter()
    {
        CharacterManage.charaCter = CharacterManage.CHARACTER.Picher;
    }
}
