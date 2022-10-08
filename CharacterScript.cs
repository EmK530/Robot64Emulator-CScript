using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class CharacterScript : MonoBehaviour
{
    public GameObject game;
    private errorlog errorlog;
    private Vector3 ms;
    public AudioSource sound;
    public AudioSource soundSFX;
    private float btntick = 0;
    public bool istitle = false;
    public int selt = 1;

    GameObject GetPathObject(string path, GameObject parent){
        if(parent!=null){
            return parent.transform.Find(path).gameObject;
        } else {
            return game.transform.Find(path).gameObject;
        }
    }
    Transform GetPathTransform(string path, GameObject parent){
        if(parent!=null){
            return parent.transform.Find(path);
        } else {
            return game.transform.Find(path);
        }
    }
    GameObject Clone(GameObject obj){
        GameObject temp = Instantiate(obj) as GameObject;
        temp.transform.name = obj.transform.name;
        return temp;
    }
    float tick()
    {
        return Time.realtimeSinceStartup;
    }

    void Start()
    {
        errorlog = gameObject.GetComponent<errorlog>();
        StartCoroutine(Main());
    }

    IEnumerator Main()
    {
        yield return new WaitForSecondsRealtime(0.25f);
        errorlog._G["loading"] = true;
        GameObject lp = GetPathObject("Players/LocalPlayer",null);
        GameObject rf = GetPathObject("ReplicatedFirst",null);
        GameObject Char = Clone(GetPathObject("char",rf));
        GameObject vis = Clone(GetPathObject("vis",rf));
        errorlog._G["loading"] = true;
        Debug.Log("game by zkevin");
        GameObject UI = GetPathObject("PlayerGui/UI",lp);
        UI.transform.Find("loop").gameObject.SetActive(true);
        bool saveloading=false;
        //missing lots of user input functions
        object u1 = 1;
        object u2 = false;
        object u3 = 1;
        object u4 = null;
        object u5 = null;
        object zoom = 2;
        object deadzone = 0.3f;
        //missing function MouseMove
        //missing skip UI event
        yield return new WaitForSecondsRealtime(0.5f);
        //function wt can be replaced with yield return 0;
        bool[] icedfound = new bool[64];
        bool[] icedfound2 = new bool[64];
        //missing icr
        string[] icrt = new string[] { "Hub", "Turtle Tops", "Knoddy's Resort", "The Hecklands", "Candy Aquarium", "New Neocity", "Tinyhuge Bedroom", "Planet Kebabulon", "Snozone Cave", "Buzz Factory", "Scramble in Time" };
        //missing lvlpacks
        string[] lvlpackssort = new string[] { "Basic Pack 1", "Basic Pack 2", "Basic Pack 3", "Basic Pack 4", "World Pack 1", "World Pack 2", "World Pack 3", "Texture Pack", "Texture Pack 2", "Misc Pack 1", "Misc Pack 2", "Misc Pack 3", "Dialogue Pack", "Bonus Pack 1", "Bonus Pack 2", "Eggy Pack" };
        object u6 = false;
        //missing function jump
        //missing function storeclick
        //missing function toattack
        //missing function dive
        //missing function tocrouch
        //missing function hitenemy
        //missing function torope
        //missing function showbis
        //missing function totext
        //missing function carry
        //missing function todance
        //missing function touched
        object timer = 0;
        int trdo = 1;
        bool trsing = false;
        bool trsdeb = false;
        bool earlystart = false;
        bool mapswitching = false;
        Vector3 anicam = new Vector3(-69999,-69999,-69999);
        float oldspeed = 0;
        float oldptime = 0;
        float transtimer = 0;
        bool dontsave = false;
        object speedrun = "";
        object speedrunRTA = "";
        //jump to line 5131

        IEnumerator transition(bool p31, bool p32, bool p33){
            if(p31==false && p33==false){
                //cut out speedrun
                //if(speedrun[2]=="" && p32==true && earlystart==false){speedrun[1] = oldspeed - (transtimer - tick());}
                //if(timer[2]=="" && p32==true && earlystart==false){timer[1] = oldptime - (transtimer - tick());}
                earlystart = false;
                trsing = false;
                if(p32==true){mapswitching=false;}
            }
            if(trsdeb==false){
                trsdeb=true;
                GameObject l__loop__520 = GetPathObject("loop",UI);
                if(p31==true){trdo = 0;} else {trdo = 1;}
                if(p31==true){
                    soundSFX.PlayOneShot(Resources.Load("SFX/load1") as AudioClip);
                    l__loop__520.SetActive(true);
                } else {
                    if((string)speedrun=="" && p32==true && earlystart==false){speedrun = oldspeed - (transtimer - tick());}
                    if((string)timer=="" && p32==true && earlystart==false){timer = oldptime - (transtimer - tick());}
                    earlystart = false;
                    trsing = false;
                    if(p32==true){mapswitching=false;}
                    soundSFX.PlayOneShot(Resources.Load("SFX/load2") as AudioClip);
                    l__loop__520.GetComponent<Image>().color = new Color(0f,0f,0f,0f);
                }
                float v522 = tick();
                float v523 = 0;
                while(true){
                    if(tick() - v522 >= 0.4){break;}
                    //if(UI.GetComponent<RectTransform>().sizeDelta.y<UI.GetComponent<RectTransform>().sizeDelta.x){
                        //l__loop__520.GetComponent<AspectRatioFitter>().aspectMode = UnityEngine.UI.AspectRatioFitter.AspectMode.WidthControlsHeight;
                        //l__loop__520.GetComponent<RectTransform>().localPosition = new Vector3(0,-((UI.GetComponent<RectTransform>().sizeDelta.y - UI.GetComponent<RectTransform>().sizeDelta.x) / 2),0);
                    //} else {
                        //l__loop__520.GetComponent<AspectRatioFitter>().aspectMode = UnityEngine.UI.AspectRatioFitter.AspectMode.HeightControlsWidth;
                        //l__loop__520.GetComponent<RectTransform>().localPosition = new Vector3(0,-((UI.GetComponent<RectTransform>().sizeDelta.y - UI.GetComponent<RectTransform>().sizeDelta.x) / 2),0);
                    //}
                    if(p31==true){
                        v523 = (1 - (tick() - v522) / 0.4f)*4;
                    } else {
                        v523 = ((tick() - v522) / 0.4f)*4;
                    }
                    GetPathTransform("center",l__loop__520).localScale = new Vector3(v523/2f,v523/2f,1);
                    GetPathTransform("l",l__loop__520).localScale = new Vector3(1f - v523 / 2f,1,1);
                    GetPathTransform("r",l__loop__520).localScale = new Vector3(1f - v523 / 2f,1,1);
                    GetPathTransform("u",l__loop__520).localScale = new Vector3(1,1f - v523 / 2f,1);
                    GetPathTransform("d",l__loop__520).localScale = new Vector3(1,1f - v523 / 2f,1);
                    yield return 0;
                }
                if(p31==true){
                    l__loop__520.GetComponent<Image>().color = new Color(0f,0f,0f,1f);
                    trsing = true;
                    if(p32==true){mapswitching=true;}
                    //cut out speedrun
                } else {
                    l__loop__520.SetActive(false);
                    if(anicam==new Vector3(-69999,-69999,-69999)){GetPathObject("UI",UI).SetActive(true);}
                }
                trsdeb=false;
            }
        }

        //missing function limit
        //missing function v2
        //missing function out
        //missing function cvt
        //missing function cast
        //missing function pause
        //missing function spawnice
        //missing function particle
        //missing function psound
        //missing function damage
        //missing function respawn
        void loadvis(GameObject p62)
        {
            if(p62.transform.name == "vis")
            {
                //hide the billboard
            } else {
                //set billboard text
            }
            //play slide sound
        }
        //missing function toskin
        object levelid = null;
        object infwater = null;
        object onrope = null;
        object pole = null;
        int eggs = 0;
        int maxeggs = 8;
        GameObject[] ignore = new GameObject[0];
        GameObject button = null;
        GameObject textbox = null;
        GameObject snapshotcam = null;
        void loadmap(GameObject p65)
        {
            errorlog._G["loading"] = true;
            //missing mapdebris clear
            p65.transform.SetParent(GetPathTransform("Workspace", null));
            ignore = new GameObject[] {Char, GetPathObject("Workspace/vis",game), GetPathObject("Workspace/debris", game), button, textbox, snapshotcam};
            levelid = null;
            infwater = null;
            onrope = null;
            pole = null;
            eggs = 0;
            maxeggs = 8;
        }
        //missing function loadlevel
        //missing variable u9
        //missing function base64encode
        //missing function base64decode
        //missing function formatlevel
        //missing function decodelevel
        //missing function olddecodelevel
        //missing function cfro
        //missing function trsCF
        Vector3 tscale = new Vector3(0, 0, 0);
        //missing function anim
        //missing function anim2
        //missing function tostr
        //missing function ag
        //missing function iceguide
        //missing function createguide
        //missing function hatpage
        int playsort = 1;
        object prevex = null;
        //missing function scrollex
        //GameObject textsel = GetPathObject("pause/bg/pause/close", UI);
        //missing textbuttons
        //missing pause descendants loop
        //missing pause button click detect
        //missing token buy click detect
        //missing editor button click events
        object uideb = null;
        GameObject map = null;
        GameObject plam = null;
        int hat = 0;
        bool bees = false;
        int[] lockhats = new int[] { };
        int[] lockskin = new int[] { };
        int[] starred = new int[] { };
        int icedcream = 0;
        int candy = 0;
        int scandy = 0;
        int tokens = 0;
        int prog = 0;
        bool nightmode = false;
        int skin = 1;
        bool candab = false;
        void savegame(){
            if(dontsave==false){
                //not implemented
            }
        }
        string passes = null;
        string[] gd = null;
        void givedata(GameObject p101, string[] p102, string p103){
            //not implemented
        }
        //save remote missing
        //canmove remote missing
        //givedata remote missing
        //devpro remote missing
        //playlevel remote missing
        //rawlevel remote missing
        //resettoken remote missing
        //givetoken remote missing
        //givedata request missing
        GetPathObject("loop",UI).SetActive(false);
        GetPathObject("title",UI).gameObject.SetActive(true);
        GameObject v1375 = Clone(GetPathObject("ReplicatedFirst/title",null));
        v1375.transform.SetParent(game.transform.Find("Workspace"));
        v1375.transform.name = "title";
        AudioClip mus = Resources.Load("Music/title") as AudioClip;
        sound.clip = mus;
        sound.Play();
        istitle = true;
        if(gd!=null) {
            selt=1;
        } else {
            selt=2;
        }
        btntick = tick();
        errorlog._G["loading"] = false;
        while(istitle){
            GetPathObject("title/continue/spin",UI).SetActive(selt==1);
            GetPathTransform("title/continue/spin",UI).rotation = Quaternion.Euler(0,0,(tick()-btntick)*-80);
            GetPathObject("title/continue/tx",UI).GetComponent<TextMeshProUGUI>().text = "Continue";
            GetPathObject("title/continue/outline",UI).GetComponent<TextMeshProUGUI>().text = "Continue";
            GetPathObject("title/new/spin",UI).SetActive(selt==2);
            GetPathTransform("title/new/spin",UI).rotation = Quaternion.Euler(0,0,(tick()-btntick)*-80);
            GetPathObject("title/new/tx",UI).GetComponent<TextMeshProUGUI>().text = "New Game";
            GetPathObject("title/new/outline",UI).GetComponent<TextMeshProUGUI>().text = "New Game";
            GetPathObject("title/speedrun/spin",UI).SetActive(selt==3);
            GetPathTransform("title/speedrun/spin",UI).rotation = Quaternion.Euler(0,0,(tick()-btntick)*-80);
            GetPathObject("title/speedrun/tx",UI).GetComponent<TextMeshProUGUI>().text = "Speedrun";
            GetPathObject("title/speedrun/outline",UI).GetComponent<TextMeshProUGUI>().text = "Speedrun";
            yield return 0;
        }
        if(gd==null){gd=new string[8];}
        gd[6]="1";
        switch(selt)
        {
            case 1:
                givedata(plam,gd,passes);
                break;
            case 2:
                string[] temp2 = {null, gd[1], gd[2], null, null, gd[5], gd[6]};
                givedata(plam, temp2, passes);
                break;
            case 3:
                speedrun = true;
                speedrunRTA = true;
                dontsave = true;
                string[] temp3 = {null, gd[1], gd[2], null, null, gd[5], gd[6]};
                givedata(plam, temp3, passes);
                break;
        }
        StartCoroutine(transition(true,false,false));
        while(trsdeb==false){yield return 0;}
        while(trsdeb==true){yield return 0;}
        sound.Stop();
        Destroy(v1375);
        GetPathObject("title",UI).SetActive(false); 
        vis.transform.SetParent(GetPathTransform("Workspace", null));
        Char.transform.SetParent(GetPathTransform("Workspace", null));
        loadvis(vis);
        if((int)icedcream == 0)
        {
            map = Clone(GetPathObject("maps/tutorial",rf));
        } else
        {
            map = Clone(GetPathObject("maps/hub", rf));
        }
        GameObject room = null;
        levelid = null;
        //missing rg3
        //missing spinCF
        //missing enemies
        loadmap(map);
        //to be continued
    }

    void Update()
    {
        ms = Input.mousePosition;
    }
}
