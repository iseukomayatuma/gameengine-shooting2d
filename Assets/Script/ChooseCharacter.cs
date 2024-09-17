using UnityEngine;
public class ChooseCharacter : MonoBehaviour
{
    public void SelectGunnner()
    {
        CharacterDate.charaCter = CharacterDate.CHARACTER.Gunner;
    }
    public void SelectMudMonster()
    {
        CharacterDate.charaCter = CharacterDate.CHARACTER.MudMonster;
    }
    public void SelectMomotarou()
    {
        CharacterDate.charaCter = CharacterDate.CHARACTER.Momotarou;
    }
    public void SelectPicter()
    {
        CharacterDate.charaCter = CharacterDate.CHARACTER.Picher;
    }
}
