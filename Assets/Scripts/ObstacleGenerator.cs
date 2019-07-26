using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    [SerializeField] private GameObject[] _elements;
    [SerializeField] private int[] _wieghts;
    [SerializeField] private BlobSizeSwitcher _switcher;
    
    static System.Random Random = new System.Random();
    
    // Start is called before the first frame update
    void Start()
    {
        List<int> elems = new List<int>();
        for (int i = 0; i < _wieghts.Length; ++i)
        {
            for (int j = 0; j < _wieghts[i]; ++j)
            {
                elems.Add(i);
            }
        }

        int index = Random.Next(elems.Count - 1);

        GameObject created = Instantiate(_elements[index], transform, false);
        SizeModifier mod = created.GetComponent<SizeModifier>();
        if (mod != null)
        {
            mod._switcher = _switcher;
        }
        created.transform.localPosition = Vector3.zero;
        created.transform.localRotation = Quaternion.identity;
    }
}
