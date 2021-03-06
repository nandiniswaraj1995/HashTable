using System;

namespace HashTableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hash table demo"); //() []
            MyMapNode1<int, string> hash = new MyMapNode1<int, string>(5);
            hash.Add(0, "To be or not to be");
            hash.frequencyOfWords(0);
            hash.Add(1, "Paranoids are not Paranoids because they are Paranoids but because they keep putting themselves deliberatly into paranoids avoidable situations");
            hash.frequencyOfWords(1);

            string paragraph = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] para = paragraph.Split(" ");
            MyMapNode1<int, string> hash1 = new MyMapNode1<int, string>(para.Length);
            int key = 0;
            foreach (string word in para)
            {
                hash1.Add(key, word);
                key++;
            }

            hash.Remove(hash1, "avoidable");

            BinarySearchTree<int> binarySearch = new BinarySearchTree<int>();
            binarySearch.Insert(30);
            binarySearch.Insert(70);


        }
    }
}
