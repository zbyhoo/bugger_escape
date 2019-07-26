using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using TMPro;
using UnityEngine;

public class FinalScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TextMeshProUGUI label = gameObject.GetComponent<TextMeshProUGUI>();
        label.text = "SCORE: " + Scoring.GetPoints();
    }
}
