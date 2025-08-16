import java.util.Scanner;

class Main {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        System.out.println("Enter actual Length: ");
        int actualLength = sc.nextInt();

        System.out.println("Enter value: ");
        int val = sc.nextInt(); // Value to remove

        int[] nums = new int[actualLength]; // Input array
        System.out.println("Enter array elements: ");
        for (int i = 0; i < actualLength; i++) {
            nums[i] = sc.nextInt();
        }

        int k = removeElement(nums, val); // Calls your implementation
        System.out.println("k: " + k);

        int[] expectedNums = new int[k]; // The expected answer with correct length.
        // It is sorted with no values equaling val.

        assert k == expectedNums.length;
        sort(nums, 0, k); // Sort the first k elements of nums
        for (int i = 0; i < actualLength; i++) {
            assert nums[i] == expectedNums[i];
        }

        System.out.println();

        toString(expectedNums);
        System.out.println();
        toString(nums);

        sc.close();
    }

    public static void sort(int[] nums, int i, int k) {
        System.out.print("Sort: ");

        for (; i < k; i++) {
            if (nums[i] != -1) {
                System.out.print(nums[i] + " ");
            }
        }
    }

    public static int removeElement(int[] nums, int val) {
        int k = 0;
        for (int i = 0; i < nums.length; i++) {
            if (nums[i] != val) {
                nums[k] = nums[i];
                k++;
            }
        }
        return k;
    }

    public static void toString(int[] nums) {
        for (int i = 0; i < nums.length; i++) {
            System.out.print(nums[i] + " ");
        }
    }
}