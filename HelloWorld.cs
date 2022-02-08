using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public new string name = "untitled";
    public bool alive;
    public int age = 10;
    public int[] points = new int[5];
    public string[] names = new string[5];

    public float speed 
    {
        get
        {
            return sm.speed;
        }
        
    }

    private SpeedManager sm;


    // Start is called before the first frame update
    void Awake()
    {
        print("Awake");
        sm = gameObject.GetComponent<SpeedManager>();
    }

    void Start()
    {
        print("Start " + PosUtil.CalculateIndex(5, 3, 10));

       //print(name);
       //for (var i = 0; i < 10; i++)
       // {
       //     print(i);
            
       //     //if(i == 5)
       //     //{
       //     //    throw new UnityException("Something is wrong");
       //     //}
            
       //     if(i == 5)
       //     {
       //         print("Is 5");
       //     }
       // }
    }
    void FixedUpdate()  //usa pra fisica
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        var pos = transform.position;

        transform.position = new Vector3(pos.x + speed, pos.y, pos.z);
    }

    void LateUpdate()   //Roda depois dos outros updates
    {
        
    }
}
