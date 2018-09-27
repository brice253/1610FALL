using UnityEngine;

[CreateAssetMenu]
public class Ouch : ScriptableObject
{

    public FloatData Data;

    public void OnOuch(FloatData outsideData)
    {
        outsideData.Value -= Data.Value;
    }

}
