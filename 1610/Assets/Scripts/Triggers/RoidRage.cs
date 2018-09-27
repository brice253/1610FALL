using UnityEngine;

[CreateAssetMenu]
public class RoidRage : ScriptableObject
{

    public FloatData Data;

    public void OnRoidRage(FloatData outsideData)
    {
        outsideData.Value *= Data.Value;
    }

}