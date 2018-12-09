using UnityEngine;

[CreateAssetMenu]
public class Curse : ScriptableObject
{

    public FloatData Data;

    public void OnCurse(FloatData outsideData)
    {
        outsideData.Value /= Data.Value;
    }

}
