using UnityEngine;

public class ReticleController : MonoBehaviour
{
    [SerializeField] private GameObject reticleScene;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private float ry;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        reticleScene.transform.Rotate(0f, Time.deltaTime * 30f, 0f);
    }
}

