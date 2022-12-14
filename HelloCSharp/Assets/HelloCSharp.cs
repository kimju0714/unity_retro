using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCSharp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        // 형변환 캐스팅
        int height = 170;
        float heightDetail = 170.3f;

        // 자동 형변환 (잃어버리는 정보가 없으면) 
        heightDetail = height;

        // 직접 명시해야 하는 경우 (잃어버리는 정보가 있으면)
        height = (int)heightDetail;


        // 조건문 if문
        bool isBoy = false;

        if(isBoy != true)
        {
            Debug.Log("나는 여자다");
        }
        
        if(isBoy != false)
        {
            Debug.Log("나는 남자다");
        }

        if(isBoy)
        {
            Debug.Log("나는 남자다");
        }

        if (!isBoy)
        {
            Debug.Log("나는 여자다");
        }



        // == != < > <= >=

        int love = 40;

        if(love > 50)
        {
            Debug.Log("베드엔딩");
        }
        else
        {
            Debug.Log("해피엔딩");
        }

        int age = 17;

        // or || 혹은
        // A || B, A 혹은 B 둘중에 하나라도 참이면 => 참
        if(age >= 60 || age <= 17)
        {
            Debug.Log("일을 하면 안된다");
        }


        // AND && 그리고
        // A && B, A 그리고 B, 두개가 모두 참 => 참
        if(age > 17 && age < 60)
        {
            Debug.Log("일할 나이");
        }


        if(age <= 7)
        {
            Debug.Log("유치원에 간다");
        }
        else if(age < 12)
        {
            Debug.Log("초등학교로 간다");
        } // age >= 12 그리고 age < 15
        else if(age < 15)
        {
            Debug.Log("중학교로 간다");
        }
        else if (age < 18)
        {
            Debug.Log("고등학교로 간다");
        }
        else
        {
            Debug.Log("성인");
        }

        Debug.Log("!true = " + (!true));


        // switch 분기문

        int year = 2017;

        switch (year)
        {
            case 2012:
                Debug.Log("레미제라블");
                break;
            case 2015:
                Debug.Log("러브라이브");
                break;
            case 2016:
                Debug.Log("곡성");
                break;
            case 2017:
                Debug.Log("트랜스포머5");
                break;
            default:
                Debug.Log("년도가 해당사항 없음");
                break;
        }

        // 루프문 Loop 반복문들

        // for문
        // 초기화; 조건; 업데이트
        // i > 0,1,2,3,4,5,6,7,8,9
       
        for(int i=0; i<10; i++)
        {
            Debug.Log("현재 순번: " + i);

        }
        Debug.Log("루프 끝");


        bool isShot = false;
        int index = 0;
        int luckyNumber = 4;

        while(isShot == false)
        {
            index = index + 1;
            Debug.Log("현재 시도: " + index);
            if(index == luckyNumber)
            {
                Debug.Log("총알에 맞았다!");
                isShot = true;
            }
            else
            {
                Debug.Log("총알에 맞지 않았다");
            }
        }

        do
        {
            Debug.Log("Do-While");
        } while (isShot == false);
    }

   
}
