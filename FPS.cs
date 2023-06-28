using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.iOS;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FPS : MonoBehaviour
{
    public InputField id; //사용자 아이디 변수
    public InputField password; //사용자 패스워드 변수
    public Text notify; //검사 텍스트 변수
    // Start is called before the first frame update
    void Start()
    {
        notify.text = ""; //검사 텍스트 창을 비운다.
    }
    public void SaveUserData() //아이디와 패스워드 저장함수
    {
        //같은 아이디가 존재하지 않다면
        if(!PlayerPrefs.HasKey(id.text))
        {
            //사용자 아이디는 키로 패스워드는 값으로 설정해 저장한다.
            PlayerPrefs.SetString(id.text, password.text);
            notify.text = "아이디 생성이 완료됐습니다";
        }
        else
        {
            notify.text = "이미 존재하는 아이디입니다.";
        }
        
    }
    public void CheckUserData() //로그인 함수
    {
        //사용자가 입력한 아이디를 키를 불러옴
        string pass = PlayerPrefs.GetString(id.text);
        //사용자가 입력한 패스워드와 같다면
        if(password.text == pass)
        {
            SceneManager.LoadScene(1); //MainScene을 불러옴
        }
        else
        {
            notify.text = "입력하신 아이디와 패스워드가 일치하지 않습니다.";
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}