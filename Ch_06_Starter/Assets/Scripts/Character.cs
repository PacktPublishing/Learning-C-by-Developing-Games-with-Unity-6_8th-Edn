using UnityEngine;

public class Character
{
    public string Name;
    public int Exp; 

    public Character()
    {
        Reset();
    }

    public Character(string name)
    {
        this.Name = name;
    }

    public virtual void PrintStatsInfo()
    {
      Debug.LogFormat("Hero: {0} - {1} EXP", this.Name, this.Exp);
    }

    private void Reset()
    {
        this.Name = "Not assigned";
        this.Exp = 0;
    }
}