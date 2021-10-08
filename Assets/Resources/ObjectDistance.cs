using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDistance : MonoBehaviour
{
    public GameObject object1;
    public GameObject object2;
    public float MinDistanceBetweenObjects;
    private float Distance = 100;
    public GUIStyle style;
    private Animator animatorObj1, animatorObj2;

    void Awake()
    {
        animatorObj1 = object1.GetComponent<Animator>();
        animatorObj2 = object2.GetComponent<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {
        style.fontSize = 26;
    }

    // Update is called once per frame
    void Update()
    {
        Distance = (int) (Vector3.Distance(object1.transform.position, object2.transform.position) * 100);

        if(Distance <= MinDistanceBetweenObjects)
        {
            animatorObj1.SetBool("isAttack", true);
            animatorObj2.SetBool("isAttack", true);
        } else
        {
            animatorObj1.SetBool("isAttack", false);
            animatorObj2.SetBool("isAttack", false);
        }
    }

    private void OnGUI()
    {
            GUI.Label(new Rect(5, 5, 200, 200), $"Distance between objects: {Distance}cm", style);
    }
}
