﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : Interactable
{
    public AudioClip audioClip;
    public AudioClip audioClip2;

    public override void Interact()
    {
        OnClick();
    }

    public void OnClick()
    {
        
        // 여기에 if문으로 열쇠합
        if(Inventory.Glue == true)
        {
            AudioSource.PlayClipAtPoint(audioClip2, transform.position, 0.7f);
            Debug.Log("Open");
        }
        else
        {
            Debug.Log("click!");
            Cursor.visible = true;
            Debug.Log("Door closed");

            AudioSource.PlayClipAtPoint(audioClip, transform.position, 0.7f);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
