using UnityEngine;
public class SimpleIntData : Monobehaviour
{
    public int value;
    public void updateValue(int amount)
    {
        value += amount;
    }
    public void SetValue(int amount)
    {
        value = amount;
    }
}