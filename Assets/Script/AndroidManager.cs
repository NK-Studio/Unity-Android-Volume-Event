using System;
using UnityEngine;
using UnityEngine.UI;

public class AndroidManager : MonoBehaviour
{
    public Text CountText;

    private int _count;
    
    private MainControls _mainControls;

    private void Awake()
    {
        _mainControls = new MainControls();
        _mainControls.Player.ClickAction.performed += ctx => VolumeEvent("Up");
    }

    private void OnEnable()
    {
        _mainControls.Enable();

    }

    private void OnDisable()
    {
        _mainControls.Disable();
    }

    private void Start()
    {
        //중요 - 오브젝트 이름을 무조건 AndroidPlugin로 해주세요.
        gameObject.name = "AndroidPlugin";
    }

    private void Update()
    {
        CountText.text = _count.ToString();
    }

    //볼륨 이벤트를 받아 옵니다.
    public void VolumeEvent(string arg)
    {
        switch (arg)
        {
            case "Up":
                _count += 1;
                //원하는 내용을 넣으십시오.
                break;
            case "Down":
                _count -= 1;
                //원하는 내용을 넣으십시오.
                break;
        }
    }
}