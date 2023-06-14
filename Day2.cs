using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PrintByteSizes();
    }

    // Update is called once per frame
    void Update()
    {   
        
    }

    void PrintByteSizes()
    {
        string[] units = { "B", "KB", "MB", "GB", "TB", "PB", "EB" };
        ulong[] byteSizes = {
            0, 1, 1000,
            1024 + 512, 1024 * 512,
            1024 * 1024 + 1024 * 512,
            1024 * 1024 * 1024, 1610612736,
            1024UL * 1024 * 1024 * 1024, 1649267441664,
            1024UL * 1024 * 1024 * 1024 * 1024, 1688849860263936,
            1804322154709715500, ulong.MaxValue
        };

        for (int i = 0; i < byteSizes.Length; i++)
        {
            ulong size = byteSizes[i];
            int unitIndex = 0;

            while (size >= 1024 && unitIndex < units.Length - 1)
            {
                size /= 1024;
                unitIndex++;
            }

            string formattedSize = $"{size:0.##} {units[unitIndex]}";
            Debug.Log(formattedSize);
        }
    }
}