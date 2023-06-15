using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector : MonoBehaviour
{
    public struct Vector
    {
        public int x;
        public int y;

        public Vector(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static Vector operator +(Vector P1, Vector P2)
        {
            return new Vector(P1.x + P2.x, P1.y + P2.y);
        }

        public static Vector operator -(Vector P1, Vector P2)
        {
            return new Vector(P1.x - P2.x, P1.y - P2.y);
        }

        public static Vector operator *(Vector P1, int scalar)
        {
            return new Vector(P1.x * scalar, P1.y * scalar);
        }
         public static Vector operator /(Vector P1, int scalar)
        {
            return new Vector(P1.x / scalar, P1.y / scalar);
        }

        public string toString()
        {
            return "x: " + x + ", y: " + y;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Vector P1 = new Vector(5, 4);
        Vector P2 = new Vector(1, 2);

        Debug.Log(P1.toString());
        Debug.Log((P1 + P2).toString());
        Debug.Log((P1 - P2).toString());
        Debug.Log((P1 * 2).toString());
        Debug.Log((P1/ 2).toString());
    }

    // Update is called once per frame
    void Update()
    {

    }
}