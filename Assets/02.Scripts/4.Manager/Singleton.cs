using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    protected static T _instance;
    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                // 해당 컴포넌트 이름을 가져온다.
                string componentName = typeof(T).ToString();

                // 해당 컴포넌트 이름으로 게임 오브젝트 찾기
                GameObject findObject = GameObject.Find(componentName);

                // 없으면
                if (findObject == null)
                {
                    // 생성
                    findObject = new GameObject(componentName);
                }

                // 생성된 오브젝트에, 컴포넌트 추가
                _instance = findObject.AddComponent<T>();

                // 씬이 변경되어도 객체가 유지되도록 설정
                DontDestroyOnLoad(_instance);
            }
            return _instance;
        }
    }

}