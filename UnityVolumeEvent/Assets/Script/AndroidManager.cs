using UnityEngine;
using UnityEngine.UI;

public class AndroidManager : MonoBehaviour {

    public Text CountTx;

    private int Count;

	void Start () {

        //중요 - 오브젝트 이름을 무조건 AndroidPlugin로 해주세요.
        gameObject.name = "AndroidPlugin";
    }

    private void Update()
    {
        CountTx.text = Count.ToString();
    }

    //볼륨 이벤트를 받아 옵니다.
    public void VolumeEvent(string arg)
    {
        switch (arg)
        {
            case "Up":
                Count += 1;
                //원하는 내용을 넣으십시오.
                break;
            case "Down":
                Count -= 1;
                //원하는 내용을 넣으십시오.
                break;
        }
    }
}
