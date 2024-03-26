using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logoLoader : MonoBehaviour 
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Coutdown");
    }
    private IEnumerator Coutdown ()
    {
        yield return new WaitForSeconds(5);
        
    }
}
