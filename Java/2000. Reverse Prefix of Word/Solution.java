class Solution {

    public String reversePrefix(String word, char ch) {
        char[] word2 = word.toCharArray();

        int index_ch = word.indexOf(ch);
        if (index_ch < 0) {
            System.out.println("" + ch + "" + " does not exist in word");
        } else {
            for (int i = 0; i <= index_ch / 2; i++) {
                char temp = word2[i];
                word2[i] = word2[index_ch - i];
                word2[index_ch - i] = temp;
            }
        }

        return new String(word2);
    }

}