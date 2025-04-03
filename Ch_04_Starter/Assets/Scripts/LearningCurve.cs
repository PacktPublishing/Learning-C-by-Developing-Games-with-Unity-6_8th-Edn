using UnityEngine;

public class LearningCurve : MonoBehaviour
{
 	public int CurrentAge = 30;
    public int YearsToAdd = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int CharacterLevel = 35;
        int NextSkillLevel = GenerateCharacter("Spike", CharacterLevel);
        Debug.Log("Next skill level -> " + NextSkillLevel);
    }

    public int GenerateCharacter(string name, int level)
    {
        Debug.LogFormat("Character: {0} - Level: {1}", name, level);
        return level += 5;
    }

    /// <summary>
    /// Computes a modified age by adding two variables together
    /// </summary>
	void ComputeAge() 
    {
        Debug.Log(CurrentAge + YearsToAdd);
    }
}