import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

class Solution {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        System.out.println("M: ");
        int m = sc.nextInt();
        System.out.println("N: ");
        int n = sc.nextInt();

        System.out.println("Array1: ");
        int[] nums1 = createArray(m, sc);
        System.out.println("Array2: ");
        int[] nums2 = createArray(n, sc);
        // int[] nums3 = mergeArraysUsingArrayList(nums1, nums2);

        System.out.println(findMedianSortedArrays(nums1, nums2));

        sc.close();
    }

    public static int[] createArray(int a, Scanner sc) {
        int[] array = new int[a];
        for (int i = 0; i < a; i++) {
            array[i] = sc.nextInt();
            System.out.print(array[i] + " ");
        }
        System.out.println();

        return array;
    }

    public static double findMedianSortedArrays(int[] nums1, int[] nums2) {
        int[] nums3 = mergeArraysUsingArrayList(nums1, nums2);
        double med;

        for (int i = nums3.length - 1; i >= 1; i--) { // Внешний цикл
            for (int j = 0; j < i; j++) { // Внутренний цикл
                if (nums3[j] > nums3[j + 1]) // Если порядок элементов нарушен
                    toSwap(j, j + 1, nums3); // вызвать метод, меняющий местами
            }
        }

        if (nums3.length % 2 == 0) {
            med = (nums3[nums3.length / 2] + nums3[(nums3.length / 2) - 1]) / 2.0;
        } else {
            med = ((nums3[(nums3.length - 1) / 2]));
        }

        return med;
    }

    public static void toSwap(int first, int second, int[] nums) { // метод меняет местами пару чисел массива
        int dummy = nums[first]; // во временную переменную помещаем первый элемент
        nums[first] = nums[second]; // на место первого ставим второй элемент
        nums[second] = dummy; // вместо второго элемента пишем первый из временной памяти
    }

    public static int[] mergeArraysUsingArrayList(int[] nums1, int[] nums2) {
        List<Integer> resultList = new ArrayList<>();

        for (int num : nums1) {
            resultList.add(num);
        }

        for (int num : nums2) {
            resultList.add(num);
        }

        return resultList.stream()
                .mapToInt(Integer::intValue).toArray();
    }
}