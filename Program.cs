using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public class Program
    {
        public static void Main(string[] args)
        {
            //Delegate method call
            //DelegateCodeExample.delegatefunction();

            //Encapsulation method call
            //Encapsulation encapsulation = new Encapsulation();
            //encapsulation.Experience = 5;
            //double a= encapsulation.CalculateSalary();
            //Console.WriteLine(a);

            //Single Inhertance call
            //Inheritance inheritance = new Inheritance();
            //inheritance.Experience = 5;
            //double b = inheritance.CalculateSalary();
            //Console.WriteLine(b);

            //Multiple Inhertitance call
            //MultipleInheritance inheritance = new MultipleInheritance();
            //inheritance.Experience = 5;
            //double b = inheritance.CalculateSalary();
            //inheritance.Fly();
            //Console.WriteLine(b);

            //MultiLevl Inheritance call
            //MultiLevlInheritance inheritance = new MultiLevlInheritance();
            //inheritance.Experience = 5;
            //double b = inheritance.CalculateSalary();
            //inheritance.Exam();
            //Console.WriteLine(b);


            //Abstarction using Abstract class
            //Abstraction abstraction = new Dog();
            //abstraction.Animal();

            ////Abstraction using Interface
            //IAbstraction abstraction1 = new Pet();
            //abstraction1.Animal();

            //IList,Icollection,Ienumerable code
            //I_List_Collection_Enumerable i_List_Collection_Enumerable = new I_List_Collection_Enumerable();
            //i_List_Collection_Enumoperable.List();

            //Revered String
            //StringCodingQuestions stringCodingQuestions = new StringCodingQuestions();
            //stringCodingQuestions.Reverse();

            //SingleTon example
            //Singleton singleton1 = Singleton.GetInstance();
            //Singleton singleton2 = Singleton.GetInstance();

            //Console.WriteLine(singleton1 == singleton2);

            //singleton1.SomeMethod();

            //SimpleFactoryExmaple
            //IProduct product = SimpleFactory.CreateProduct("A");
            //product.operation();
            //IProduct product1 = SimpleFactory.CreateProduct("B");
            //product1.operation();

            //FactoryMethod
            //Creator creatorA = new ConcreteCreatorA();
            //IProduct productA = creatorA.FactoryMethod();
            //productA.operation();

            //Creator creatorB = new ConcreteCreatorB();
            //IProduct productB = creatorB.FactoryMethod();
            //productB.operation();

            //ListNode
            //LinkedList linkedList = new LinkedList();
            //int[] arr1 = { 2, 4, 3 };
            //int[] arr2 = { 5, 6, 4 };
            //int[] head1 = { 1, 2, 3, 4, 5};
            //int n = 2;

            //ListNode l1 = linkedList.ArrayToListNodes(arr1);
            //ListNode l2 = linkedList.ArrayToListNodes(arr2);
            //ListNode  head= linkedList.ArrayToListNodes(head1);


            //ListNode result = linkedList.AddTwoNumbers(l1, l2);
            //ListNode result = linkedList.RemoveNthFromEnd(head, n);

            //while (result != null)
            //{
            //    Console.WriteLine(result.val + "");
            //    result = result.next;
            //}

            //TwoSum
            //TwoSum twoSum = new TwoSum();
            //int[] nums = { 2, 7, 11, 15 };
            //int target = 9;
            //twoSum.TwoSumofArray(nums, target);

            //TwoSum
            //TwoSum twoSum = new TwoSum();
            //int[] nums = { 2, 7, 11, 15 };
            //int target = 9;
            //twoSum.TwoSumofArrayList(nums, target);
            //Console.WriteLine(twoSum.TwoSumofArrayList(nums, target));
            //Console.WriteLine(twoSum.TwoSumofArrayList(nums, target));

            //Longest Substaring
            //StringCodingQuestions stringCodingQuestions = new StringCodingQuestions();
            //string s = "abcabcbb";
            //stringCodingQuestions.LengthOfLongestSubstring(s);

            //Arrays
            //int[] nums1 = { 1, 3 };
            //int[] nums2 = { 2 };
            //Arrays arrays = new Arrays();
            //arrays.FindMedianSortedArrays(nums1, nums2);
            //Console.WriteLine(arrays.FindMedianSortedArrays(nums1, nums2));

            //LongestPalindrome
            //Palindrome palindrome = new Palindrome();
            //string s = "dbabad";
            //int i = 121;
            ////string result = palindrome.LongestPalindrome(s);
            //bool result = palindrome.IsPalindrome(i);
            //Console.WriteLine(result);

            //ZigZag conversion 
            //StringCodingQuestions stringCodingQuestions = new StringCodingQuestions();
            //string input = "PAYPALISHIRING";
            //int numRows = 3;
            //string result = stringCodingQuestions.Convert(input, numRows);
            //Console.WriteLine($"Zigzag Conversion: {result}");

            //Reverse the Interger
            //Integer integer = new Integer();
            //int x = 1600222299;
            //integer.Reverse(x);
            //Console.WriteLine(integer.ToString());

            //String to Interger ATOI
            //StringCodingQuestions stringCodingQuestions = new StringCodingQuestions();
            //string input = "words +7c0d3";
            //int result = stringCodingQuestions.MyAtoi(input);
            //Console.WriteLine($"MyAtoi: {result}");

            //Regular Expressions
            //StringCodingQuestions stringCodingQuestions = new StringCodingQuestions();
            //string input = "aa", output = "a*" ;
            //bool result = stringCodingQuestions.IsMatch(input, output);
            //Console.WriteLine($"IsMatch: {result}");

            //Return the Max Are
            //Integer integer = new Integer();
            //int[] x = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            //integer.MaxArea(x);
            //Console.WriteLine(integer);

            //Interger to Roman
            //StringCodingQuestions stringCodingQuestions = new StringCodingQuestions();
            //int input = 3749;
            //string result = stringCodingQuestions.IntToRoman(input);
            //Console.WriteLine($"IntToRman: {result}");

            //Roman to Interger
            //StringCodingQuestions stringCodingQuestions = new StringCodingQuestions();
            //string s = "IX";
            //int result = stringCodingQuestions.RomanToInt(s);
            //Console.WriteLine($"IntToRman: {result}");

            //Longest Comman Prefix
            //StringCodingQuestions stringCodingQuestions = new StringCodingQuestions();
            //string[] s = { "flower", "flow", "flight" };
            //string result = stringCodingQuestions.LongestCommonPrefix(s);
            //Console.WriteLine($"IntToRman: {result}");

            //3Sum
            //Integer integer = new Integer();
            //int[] x = { -1, 0, 1, 2, -1, -4 };
            //IList<IList<int>>  r = integer.ThreeSum(x);
            //Console.WriteLine(r);

            //Letter Combinations of a Phone Number
            //StringCodingQuestions stringCodingQuestions = new StringCodingQuestions();
            //string digits = "23";
            //IList<string> result = stringCodingQuestions.LetterCombinations(digits);
            //Console.WriteLine($"Letter Combination: {result}");

            //Matcing Charcters
            //StringCodingQuestions stringCodingQuestions = new StringCodingQuestions();
            //string s = "()[]{}";
            //bool result = stringCodingQuestions.IsValid(s);
            //Console.WriteLine($"Result is: {result}");

            //String for first,last,middile name and suffic
            StringRegexExpression stringRegex = new StringRegexExpression();
            string s = "Sam Smith IV";
            string[] result = stringRegex.NameToParts(s);
            Console.WriteLine($"Result is:", result.ToString());
        }
    }
}
