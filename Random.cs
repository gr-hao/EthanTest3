using System;
class Random {
    static string generateToken() {
        Random rnd = new Random();
        return rnd.Next().ToString();
    }
}
