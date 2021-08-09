using System.Collections;
using System.Collections.Generic;
using Unity.FPS.Gameplay;
using UnityEngine;

public class LootBox : MonoBehaviour
{

    private Animation lootBoxAnimation;
    private Animation donutAnimation;
    private HealthPickup healthPickup;

    // Start is called before the first frame update
    void Start()
    {
        lootBoxAnimation = GetComponent<Animation>();
        donutAnimation = GameObject.Find("Donut").GetComponent<Animation>();
        healthPickup = GameObject.Find("Donut").GetComponent<HealthPickup>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("key down");
            lootBoxAnimation.Play();
            donutAnimation.Play();
            StartCoroutine("StopAnimation");
        }
    }

    IEnumerator StopAnimation()
    {
        yield return new WaitForSeconds(1);
        donutAnimation.Stop();
        healthPickup.enabled = true;
    }
}
