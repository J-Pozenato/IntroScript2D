using UnityEngine;

public class FizzBuzz : MonoBehaviour
{
    public int maxNum = 100;
    private void OnEnable() => fizzBuzz(maxNum);



    void fizzBuzz(int max)
    {
        for (int i = 0; i < max; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Debug.Log("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                Debug.Log("Fizz ");
            }
            else if (i % 5 == 0)
            {
                Debug.Log("Buzz");
            }
            else if (i % 3 != 0 && i % 5 != 0)
            {
                Debug.Log(i);
            }
        }
    }
}
