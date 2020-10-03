using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class blue : MonoBehaviour
{
    float currentscor;
     [SerializeField] Text _scorepoint;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        _scorepoint.text = currentscor.ToString("0");
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.name == "Player")
        {
            currentscor += 500;
        }
    }
}
