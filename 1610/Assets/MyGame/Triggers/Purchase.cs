using UnityEngine;

[CreateAssetMenu]
public class Purchase : ScriptableObject 
{
    public FloatData Data;

    public void OnPurchase(FloatData outsideData)
    {
        if (outsideData.Value >= Data.Value)
        {
            outsideData.Value -= Data.Value;
        }
    }

}
