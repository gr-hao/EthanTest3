using System;
class WeakRandom {
    static string generateWeakToken() {
        Random rnd = new Random();
        return rnd.Next().ToString();
    }
}
