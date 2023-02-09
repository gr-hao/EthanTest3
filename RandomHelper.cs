using System;
class RandomHelper {
    static string generateNewToken() {
        Random rnd = new Random();
        return rnd.Next().ToString();
    }
}
