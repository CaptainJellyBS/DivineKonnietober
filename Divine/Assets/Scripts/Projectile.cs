using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float growSpeed, maxSize, startSize, moveSpeed, baseDamage, damageSizeMultiplier, curDamage;
    float curSize;
    bool flying = false;
        
    // Start is called before the first frame update
    void Start()
    {
        curSize = startSize;
    }

    // Update is called once per frame
    void Update()
    {
        if(!flying)
        {
            curSize = Mathf.Min(maxSize,curSize + growSpeed * Time.deltaTime);
            transform.localScale = new Vector3(curSize, curSize, curSize);
        }
        else
        {
            transform.position += transform.forward * moveSpeed * Time.deltaTime;
        }

        //Debug
    }

    public void SendFlying()
    {
        transform.parent = null;
        flying = true;
        curDamage = baseDamage + (damageSizeMultiplier * Mathf.Pow(curSize*10, 2));
        Debug.Log(curDamage);
    }


}
