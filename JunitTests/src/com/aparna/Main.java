package com.aparna;

/**
 * Junit Test cases with different types of methods applied on the string
 */

public class Main {

    public static void main(String[] args) {
        Utilities util = new Utilities();
        String returnString = util.removePairs("AABCDDEFF");
        System.out.println(returnString);
    }
}
