import java.util.Arrays;
import java.util.Scanner;

class Solution {

    public int findMaxK(int[] nums) {
        int maxk = -1;
        for (int i = 0; i <= nums.length - 1; i++) {
            for (int j = 0; j <= nums.length - 1; j++) {

                if (nums[i] == -1 * nums[j] && nums[i] > 0 && nums[i] > maxk) {
                    maxk = nums[i];
                }

            }
        }
        return maxk;
    }

    public int[] createArray() {

        Scanner sc = new Scanner(System.in);
        System.out.println("Enter len: ");
        int len = sc.nextInt();
        int[] arr = new int[len];

        System.out.println("Enter array: ");
        for (int i = 0; i < len; i++) {
            arr[i] = sc.nextInt();
            if (arr[i] == 0) {
                System.out.println("Exception");
            } else {
                System.out.println(Arrays.toString(arr));
            }
        }
        sc.close();
        return arr;
    }
}