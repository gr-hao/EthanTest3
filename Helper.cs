using System;
public class Helper {
    public static string generateToken() {
        Random rnd = new Random();
        return rnd.Next().ToString();
    }
}
