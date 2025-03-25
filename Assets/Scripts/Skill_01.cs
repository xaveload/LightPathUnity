using System.Collections;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;


public class Skill_01 : MonoBehaviour
{

    public float skillTime;

    private ParticleSystem ps;

    int speed = 5;
    float timer = 0f;
    bool moveTrigger = false;
    bool activeTrigger = false;
    Vector3 resetPos;
    Quaternion resetRot;
    Vector3 resetScl;


    void Start()
    {
        
    }

    void Update()
    {
        if (gameObject.activeSelf == true && activeTrigger == false)
        {
            //gameobject[] list = gameobject.findgameobjectswithtag("_effect");
            //for (int i = 0; i < list.length; i++)
            //{
            //    var main = transform.getchild(i).getcomponent<particlesystem.mainmodule>();
            //    main.simulationspeed = 10;
            //} ------------- �ùķ��̼� ���ǵ尡 ��⿡ ������ �ִµ� �� �۵��� �� ��???
            activeTrigger = true;
            moveTrigger = true;
            resetPos = transform.localPosition;
            resetRot = transform.localRotation;
            resetScl = transform.localScale;
        }
        skillPosition();
        
    }

    void skillPosition()
    {
        if (moveTrigger == true)
        {
            timer = timer + Time.deltaTime;
            if (timer <= skillTime)
            {
                transform.SetParent(GameObject.Find("Effect").transform);
                transform.position = (transform.position + transform.TransformDirection(Vector3.forward) * speed * Time.deltaTime);
            }
            if (timer > skillTime)
            {
                timer = 0f;
                transform.SetParent(GameObject.Find("Char").transform);
                moveTrigger = false;
                activeTrigger = false;
                transform.localRotation = resetRot;
                transform.localPosition = resetPos;
                transform.localScale = resetScl;
                gameObject.SetActive(false);
            }
            

        }
        
    }

}
