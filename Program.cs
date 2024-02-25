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

            //ListNode l1 = linkedList.ArrayToListNodes(arr1);
            //ListNode l2 = linkedList.ArrayToListNodes(arr2);

            //ListNode result = linkedList.AddTwoNumbers(l1, l2);
            //while(result != null)
            //{
            //    Console.WriteLine(result.val + "");
            //    result = result.next;
            //}

            //TwoSum
            //TwoSum twoSum = new TwoSum();
            //int[] nums = { 2, 7, 11, 15 };
            //int target = 9;
            //twoSum.TwoSumofArray(nums, target);

            //Longest Substaring
            //StringCodingQuestions stringCodingQuestions = new StringCodingQuestions();
            //string s = "abcabcbb";
            //stringCodingQuestions.LengthOfLongestSubstring(s);

            //Arrays
            int[] nums1 = { 1, 3 };
            int[] nums2 = { 2 };
            Arrays arrays = new Arrays();
            arrays.FindMedianSortedArrays(nums1, nums2);
            Console.WriteLine(arrays.FindMedianSortedArrays(nums1, nums2));
        }
    }
}
