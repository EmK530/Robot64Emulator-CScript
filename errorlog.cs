using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class errorlog : MonoBehaviour
{
    public Dictionary<string,bool> _G = new Dictionary<string,bool>();
    public GameObject game;
    private GameObject lp;
    private Vector3 ms;

    // Start is called before the first frame update
    void Start()
    {
        _G.Add("loading",false);
        lp = game.transform.Find("Players/LocalPlayer").gameObject;
        ms = Input.mousePosition;
    }

    // Update is called once per frame
    void Update()
    {
        ms = Input.mousePosition;
        if(lp.transform.Find("PlayerGui") && lp.transform.Find("PlayerGui/UI") && lp.transform.Find("PlayerGui/UI/load")){
            if(_G["loading"]){
                GameObject temp = lp.transform.Find("PlayerGui/UI/load").gameObject;
                Transform temp2 = temp.transform.Find("Image");
                Transform temp3 = temp.transform.Find("Image/BT");
                temp.SetActive(true);
                temp2.rotation = temp2.rotation * Quaternion.Euler(0,0,-Time.deltaTime*120);
                float rot = temp2.eulerAngles.z;
                if(rot<0){
                    rot=Mathf.Abs(rot)+180;
                }
                temp3.rotation = Quaternion.Euler(0,0,(-Mathf.Cos((rot*2)*Mathf.Deg2Rad)*20)+rot);
            } else {
                lp.transform.Find("PlayerGui/UI/load").gameObject.SetActive(false);
            }
            if(lp.transform.Find("PlayerGui/UI/cursor")){
                lp.transform.Find("PlayerGui/UI/cursor").transform.position = new Vector3(ms.x,ms.y,0);
            }
        }
    }
}
