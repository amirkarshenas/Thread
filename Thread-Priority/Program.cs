using System;
using System.Threading;

namespace Thread_Priority {

    class Program {

        public static void ThreadMethod () {
            for (int i = 0; i < 10; i++) {
                Console.WriteLine (" ThreadMethod: {0}", i);
                Thread.Sleep (0);
            }
        }
        static void Main (string[] args) {
            Thread t = new Thread (new ThreadStart (ThreadMethod));
            t.Start ();

            for (int i = 0; i < 4; i++) {
                Console.WriteLine (" MainThread  ");
            }

            t.Join();
            
        }
    }
}