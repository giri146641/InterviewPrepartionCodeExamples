using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Arrays
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int totalLength = nums1.Length + nums2.Length;
            int[] merged = new int[totalLength];
            int i = 0, j = 0, k = 0;

            while (i < nums1.Length && j < nums2.Length)
            {
                if (nums1[i] < nums2[j])
                {
                    merged[k++] = nums1[i++];
                }
                else
                {
                    merged[k++] = nums2[j++];
                }
            }

            while (i < nums1.Length)
            {
                merged[k++] = nums1[i++];
            }

            while (j < nums2.Length)
            {
                merged[k++] = nums2[j++];
            }

            if (totalLength % 2 == 0)
            {
                return (merged[totalLength / 2 - 1] + merged[totalLength / 2]) / 2.0;
            }
            else
            {
                return merged[totalLength / 2];
            }
        }
    }
}
