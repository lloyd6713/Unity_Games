using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grow : MonoBehaviour
{

    public GameObject FinalEvolution;
    public int TimeTaken = 180;
    public string NameOfRef;
    private int TimeHappened;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.name != NameOfRef)
        {
            TimeHappened++;
            if (TimeHappened == TimeTaken)
            {
                GameObject Final = Instantiate(FinalEvolution);
                Final.transform.position = transform.position;
                Destroy(this.gameObject);
            }
        }
    }
}
