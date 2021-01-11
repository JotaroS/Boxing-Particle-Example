using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunchingMitParticleController : MonoBehaviour
{
    // Start is called before the first frame update
    private ParticleSystem ps;
    void Start()
    {
        ps = GetComponent<ParticleSystem>();
        var emission = ps.emission;
        emission.rateOverTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A)){
            ps.Emit(15);
        }
    }
}
