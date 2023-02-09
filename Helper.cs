using System;
class Helper {
    static string generateWeakToken() {
        Random rnd = new Random();
        return rnd.Next().ToString();
    }
}
