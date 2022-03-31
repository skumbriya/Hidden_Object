using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HiddenObject : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI HiddenText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        Destroy(HiddenText);
        Destroy(gameObject);
    }
}
