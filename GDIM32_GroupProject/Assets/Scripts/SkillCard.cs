using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Jasmine Chen

public class SkillCard : MonoBehaviour
{

    [SerializeField]
    private SOSkillCards skillData;

    // Start is called before the first frame update
    void Start()
    {
        skillData.GetDamage();
    }

    // Update is called once per frame

}
