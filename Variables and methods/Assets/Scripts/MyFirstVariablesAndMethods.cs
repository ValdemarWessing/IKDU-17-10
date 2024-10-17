using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstVariablesAndMethods : MonoBehaviour
{
    public int currentAge = 24;
    private int ageIncrease = 3;

    bool isFunny = true;
    string myName = "Valdemar";
    string mySecondName = "Wessing";
    public int a = 512;
    public int b = 731;


    
    // Start is called before the first frame update
    void Start()
    {

       /* Debug.LogFormat("My initial values are: a={0}, b{1}", a, b);
        int c = a;
        a = b;
        b = c;
        Debug.LogFormat("My swapped values are: a={0}, b{1}", a, b);

        int d0 = 10;
        int d1 = 20;

        (d0, d1) = Swap(d0,d1);
        Debug.LogFormat("My swapped values are: d0={0}, d1={1}", d0, d1);

        (float f1, float f2) = Swap (1.5f, 7.3f);
        Debug.LogFormat("My swapped values are: f1={0}, f2={1}", f1, f2);
        */


        int ageNextYear = IncreasedAge(currentAge);
        Debug.LogFormat("new age after increase: {0}", ageNextYear);

        int ageInNYears = IncreasedAge(currentAge,ageIncrease);
        Debug.LogFormat("Age after {0} years is {1}",ageIncrease, ageInNYears);
       
    }


    /// <summary>
    /// method that adds 1 to my age
    /// </summary>
    int IncreasedAge(int startAge)
    {
       return startAge+1;
    }
    
    /// <summary>
    /// method that adds 3 years to my age
    /// </summary>
    int IncreasedAge(int startAge,int yearNumber)
    {
        return startAge+yearNumber;

    }


    /// <summary>
    /// swaps two integers
    /// </summary>
    (int, int) Swap(int m, int n)
    {
        /*
        int temp = m;
        m = n;
        n = temp;
        */
        return (n,m);
    }
    
    /// <summary>
    /// swaps two floats
    /// </summary>
    (float, float) Swap(float m, float n)
    {
        float temp = m;
        m = n;
        n = temp;
        return (m,n);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
