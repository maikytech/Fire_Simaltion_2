using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] GameObject alarmaEvacuacion;

    private AudioSource audioAlarmaEvacuacion;

    private void Awake()
    {
        audioAlarmaEvacuacion = alarmaEvacuacion.GetComponent<AudioSource>();
    }

    // Start is called before the first frame update
    void Start()
    {
        audioAlarmaEvacuacion.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
