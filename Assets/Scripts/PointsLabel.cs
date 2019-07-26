using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using TMPro;
using UnityEngine;

public class PointsLabel : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _label;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _label.text = Scoring.GetPoints().ToString();
    }
}
