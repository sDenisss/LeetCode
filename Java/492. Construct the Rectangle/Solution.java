import java.util.Scanner;

class Solution {
    public static void main(String[] args) throws MyException {
        Scanner sc = new Scanner(System.in);

        System.out.println("Area: ");
        int area = sc.nextInt();
        Solution rectangle = new Solution(area);

        if (area <= 0) {
            throw new MyException("Err");
        }

        rectangle.constructRectangle(area);

        sc.close();
    }

    Solution(int area) {
    }

    public int[] constructRectangle(int area) {
        int w;

        int t = (int) Math.sqrt(area);
        if (Math.sqrt(area) % t != 0) {
            t++;
        }

        double rem = Math.floorMod(area, t);

        while (rem != 0.0) {
            t++;
            rem = Math.floorMod(area, (int) t);
        }

        int l = (int) t;
        w = area / l;

        System.out.println((l));
        System.out.println(w);
        int[] arr = new int[] { l, w };

        return arr;
    }
}