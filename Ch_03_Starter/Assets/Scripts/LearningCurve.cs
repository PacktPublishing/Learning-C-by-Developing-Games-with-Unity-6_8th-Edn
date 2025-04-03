using UnityEngine;

public class LearningCurve : MonoBehaviour
{
 	public int CurrentAge = 30;
    public int YearsToAdd = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     	ComputeAge();
    }

    /// <summary>
    /// Computes a modified age by adding two variables together
    /// </summary>
	void ComputeAge() 
    {
        Debug.Log(CurrentAge + YearsToAdd);
    }
}