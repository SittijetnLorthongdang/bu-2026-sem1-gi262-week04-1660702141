using UnityEngine;
using System.Collections.Generic;
using System.Collections;

namespace Assignment
{
    public class Lecture : MonoBehaviour
    {
        public void Start()
        {
            // LCT01_SyntaxList();
            // LCT02_SyntaxLinkedList();
            // LCT03_SyntaxHashTable();
            // LCT04_SyntaxDictionary();
        }

        #region Lecture

        public void LCT01_SyntaxList()
        {
            LinkedList<string> list = new LinkedList<string>();
    
            // 1. Add Node 1, Node 2
            list.AddLast("Node 1");
            list.AddLast("Node 2");
    
            // 2. Add Node 0 at first
            list.AddFirst("Node 0");
    
            // 3. Display initial list
            foreach (var item in list)
            {
                Debug.Log(item);
            }
    
            // 4. Access First, Last and check Previous/Next null
            LinkedListNode<string> firstNode = list.First;
            LinkedListNode<string> lastNode = list.Last;
            Debug.Log($"First: {firstNode.Value}, Last: {lastNode.Value}");
            Debug.Log($"firstNode.Previous is null: {firstNode.Previous == null}");
            Debug.Log($"lastNode.Next is null: {lastNode.Next == null}");
    
            // 5. Find "Node 1" and add Before & After
            LinkedListNode<string> target = list.Find("Node 1");
            if (target != null)
            {
                list.AddBefore(target, "Before Node 1");
                list.AddAfter(target, "After Node 1");
            }
    
            // 6. RemoveFirst Node 0 and Remove Node 2
            list.RemoveFirst();
            list.Remove("Node 2");
    
            // Display final list
            foreach (var item in list)
            {
                Debug.Log(item);
            }
                }

        public void LCT02_SyntaxLinkedList()
        {
            Hashtable table = new Hashtable();
            table.Add(1, "Apple");
            table.Add(2, "Banana");
            table.Add("bad-fruit", "Rotten Tomato");
    
            string fruit1 = (string)table[1];
            string fruit2 = (string)table[2];
            string badFruit = (string)table["bad-fruit"];
            Debug.Log($"fruit1: {fruit1}, fruit2: {fruit2}, badFruit: {badFruit}");
    
            foreach (DictionaryEntry entry in table)
            {
                Debug.Log($"Key: {entry.Key}, Value: {entry.Value}");
            }
    
            if (table.ContainsKey(2))
            {   
                Debug.Log("found 2");
            }
    
            table.Remove(1);
    
            foreach (DictionaryEntry entry in table)
            {
                Debug.Log($"Key: {entry.Key}, Value: {entry.Value}");
            }
        }

        public void LCT03_SyntaxHashTable()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "Apple");
            dict.Add(2, "Banana");
            dict[3] = "Cherry";
    
            Debug.Log($"Dictionary has {dict.Count} keys");
    
            foreach (KeyValuePair<int, string> kvp in dict)
            {
                Debug.Log($"Key: {kvp.Key}, Value: {kvp.Value}");
            }
    
            Debug.Log($"has key 1 : {dict.ContainsKey(1)}");
            if (dict.ContainsKey(1))
            {
                Debug.Log($"value of key 1 : {dict[1]}");
            }   
    
            Debug.Log("All keys in dictionary:");
            foreach (int key in dict.Keys)
            {
                Debug.Log(key);
            }
    
            dict.Remove(3);
            Debug.Log($"Dictionary has {dict.Count} keys");
    
            dict.Clear();
        }

        public void LCT04_SyntaxDictionary()
        {
            // 1. สร้าง Dictionary<int, string>
            Dictionary<int, string> dict = new Dictionary<int, string>();

            // 2. เพิ่มข้อมูลด้วย Add() และ indexer []
            dict.Add(1, "Apple");
            dict.Add(2, "Banana");
            dict[3] = "Cherry";

            // 3. แสดงจำนวน Key ทั้งหมด
            Debug.Log($"Dictionary has {dict.Count} keys");

            // 4. แสดงคู่ Key-Value ทั้งหมด
            foreach (KeyValuePair<int, string> kvp in dict)
            {
                Debug.Log($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            // 5. ตรวจสอบ Key ด้วย ContainsKey() และอ่าน Value
            Debug.Log($"has key 1 : {dict.ContainsKey(1)}");
            if (dict.ContainsKey(1))
            {
                Debug.Log($"value of key 1 : {dict[1]}");
            }

            // 6. อ่าน Key ทั้งหมดออกมาวนลูปแสดงผล
            Debug.Log("All keys in dictionary:");
            foreach (int key in dict.Keys)
            {
                Debug.Log(key);
            }

            // 7. ลบ Key 3 และแสดงจำนวนที่เหลือ
            dict.Remove(3);
            Debug.Log($"Dictionary has {dict.Count} keys");

            // 8. ล้างข้อมูลทั้งหมด
            dict.Clear();
        }

        #endregion
    }
}
