using UnityEngine;

public class CompletedPipePositionRandomizer : MonoBehaviour
{
    public float range = 1;

    // Start is called before the first frame update
    void Start()
    {
        transform.Translate(0, Random.Range(-range, range), 0);
    }
}
