using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace MyProject.sc1
{
    public class NewBehaviourScript : MonoBehaviour
    {
        public enum Season
        {
            Spring = 1,
            Summer = 2,
            Autumn = 3,
            Winter = 4
        }
        public Season m_season;
        // Start is called before the first frame update
        void Start()
        {
            // int[] sclist = new int[5];

            // sclist[0] = 85;
            // sclist[1] = 95;
            // sclist[2] = 70;
            // sclist[3] = 75;
            // sclist[4] = 100;

            // int total = 0;

            // //총합과 평균을 구하는 반복문
            // for (int i = 0; i < 5; ++i)
            //     total += sclist[i];

            // float avg = total / 5;
            // print($"총점:{total} 평균:{avg}");



            // //min 과 max 를 구하는 반복문
            // int min = sclist[0];
            // int max = sclist[0];

            // for (int i = 1; i < sclist.Length; i++)
            // {
            //     if (sclist[i] < min)
            //         min = sclist[i];

            //     if (sclist[i] > max)
            //         max = sclist[i];
            // }


            // print($"최소:{min} 최대:{max}");


            // //여러 배열의 평균과 합 구하기
            // int[] aStudent = { 100, 100, 100 };
            // int[] bStudent = { 20, 20, 20 };
            // int[] cStudent = { 30, 30, 30 };
            // int[] dStudent = { 40, 40, 40 };
            // int[] eStudent = { 50, 50, 50};

            // int aTotal = aStudent[0] + aStudent[1] + aStudent[2];
            // int bTotal = bStudent[0] + bStudent[1] + bStudent[2];
            // int cTotal = cStudent[0] + cStudent[1] + cStudent[2];
            // int dTotal = dStudent[0] + dStudent[1] + dStudent[2];
            // int eTotal = eStudent[0] + eStudent[1] + eStudent[2];



            // float aAvg = aTotal / 3f;
            // float bAvg = bTotal / 3f;
            // float cAvg = cTotal / 3f;
            // float dAvg = dTotal / 3f;
            // float eAvg = eTotal / 3f;

            // print($"1번 학생 총점:{aTotal}, 평균:{aAvg}");
            // print($"2번 학생 총점:{bTotal}, 평균:{bAvg}");
            // print($"3번 학생 총점:{cTotal}, 평균:{cAvg}");
            // print($"4번 학생 총점:{dTotal}, 평균:{dAvg}");
            // print($"5번 학생 총점:{eTotal}, 평균:{eAvg}");


            // //다차원 배열
            // int[,] scoreList = { { 100, 100, 100 }, { 20, 20, 20 }, { 30, 30, 30 }, { 40, 40, 40 } };

            // for (int row = 0; row < scoreList.GetLength(0); ++ row)
            // {
            //     int total2 = 0;
            //     for (int col = 0; col < scoreList.GetLength(1); ++col)
            //     { total2 += scoreList[row, col];
            //     }

            //     float avg2 = total2 / scoreList.GetLength(1);

            //     print($"{row + 1}번 학생 총점 :{total2} 평균:{avg2}");

            // }
            // //다차원 배열(응용)
            // //                 0 ,   1 
            // int[,] arr2 = {{1,2,3}, {4,5,6}};
            // int[] arr1 = {1,2,3,4,5,6};

            // for (int i =0; i < arr1.Length; ++i)
            // {
            //     print(arr1[i]);
            //     print(arr2[i / arr2.GetLength(1), i % arr2.GetLength(1)]);
            // }                                   

            //노가다코드
            // print(arr1[0]);
            // print(arr1[1]);
            // print(arr1[2]);
            // print(arr1[3]);
            // print(arr1[4]);
            // print(arr1[5]);

            // print(arr2[0,0]);
            // print(arr2[0,1]);
            // print(arr2[0,2]);
            // print(arr2[1,0]);
            // print(arr2[1,1]);
            // print(arr2[1,2]);

            //나머지는 내가 가진수로 주어주진 수를 나누고 정말 남은수 
            // 예를 들어 28을 5로 나누면 5번이 나눠지고 3이 남으니 나머지는 3이다

            //enum
            Season season = Season.Spring;
            switch (season)
            {
                case Season.Spring:
                    print($"봄이 오다.{season}의 번호 :{(int)season}");
                    break;

                case Season.Summer:
                    print($"여름이 오다.{season}의 번호 :{(int)season}");
                    break;

                case Season.Autumn:
                    print($"가을이 오다.{season}의 번호 :{(int)season}");
                    break;

                case Season.Winter:
                    print($"겨울이 오다.{season}의 번호 :{(int)season}");
                    break;

            }


            //enum => foreach 문 사용하여 반복문으로 변경
            // int springValue = (int)Season.Spring;
            // int summerValue = (int)Season.Summer;
            // int autumnValue = (int)Season.Autumn;
            // int winterValue = (int)Season.Winter;

            // foreach (int seasonValue in new[] { autumnValue, springValue, summerValue, winterValue })
            // {
            //     string seasonName = "";
            //     int seasonNumber = 0;

            //     if (seasonValue == autumnValue)
            //     {
            //         seasonName = "가을";
            //         seasonNumber = autumnValue;
            //     }
            //     else if (seasonValue == springValue)
            //     {
            //         seasonName = "봄";
            //         seasonNumber = springValue;
            //     }
            //     else if (seasonValue == summerValue)
            //     {
            //         seasonName = "여름";
            //         seasonNumber = summerValue;
            //     }
            //     else if (seasonValue == winterValue)
            //     {
            //         seasonName = "겨울";
            //         seasonNumber = winterValue;
            //     }

            //     string message = $"{seasonName}이 오다. {seasonName}의 번호: {seasonNumber}";
            //     print(message);
            // }


            //캐스팅
            // int a = 5;
            // float b = 5.44f;
            // string c = "5";


            // print($"int{a} -> float {(float)a}");
            // print($"float{b} -> int{(int)b}");
            // print($"string{c} -> int{int.Parse(c)}");


            //string값 나누기 
            //string값

            const int CutLang = 3;
            

            string c2 = "abcdefhijklmnopq";
            string[] arr = new string[(c2.Length + 2) / CutLang];

           
            // 문자열을 3개씩 자르고 배열에 저장
            for (int i = 0; i < c2.Length; i += CutLang)
            {
                int length = (c2.Length - i >= CutLang) ? CutLang : c2.Length - i; // 마지막 조각은 3개 미만일 수도 있음
                arr[i / CutLang] = c2.Substring(i, length);
            }

            // 배열의 값을 반복문으로 출력
            foreach (string cut in arr)
            {
                print(cut);
            }
        }


        // Update is called once per frame
        void Update()
        {

        }

    }
}
