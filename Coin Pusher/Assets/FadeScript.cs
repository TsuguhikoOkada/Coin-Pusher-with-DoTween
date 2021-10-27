using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class FadeScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Fade();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Fade() => GetComponent<MeshRenderer>().material.DOFade (0.0f, 5.0f).OnComplete(() => Debug.Log("ƒV[ƒ“‚ª•\¦‚³‚ê‚Ü‚µ‚½"));

     
}
