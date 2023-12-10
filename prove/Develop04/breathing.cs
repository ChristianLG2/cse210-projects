using System;
using System.Threading;

class Breathing : Activity {

    public Breathing(string or_name, string or_description) : base(or_name, or_description)
    {

    }
    public void breathStartActivity(){
        base.startActivity();

        Random rnd = new Random();
        int mb_totalTime = getDuration() * 1000;
        while(mb_totalTime > 0){
            int mb_breathIn = 4000;
            int mb_breathOut = 6000;

            if (mb_totalTime >= (mb_breathIn + mb_breathOut))
            {
                // Breathe in
                mb_totalTime -= mb_breathIn;
                Console.Write("\n\nBreathe in...");
                base.CountDown(mb_breathIn);

                // Breathe out
                mb_totalTime -= mb_breathOut;
                Console.Write("\nBreathe out...");
                base.CountDown(mb_breathOut);
                Console.WriteLine();
            }
            else{
                int mb_new_time = mb_totalTime / 2;
                Console.Write("\n\nBreathe in...");
                base.CountDown(mb_breathIn);

                Console.Write("\n\nBreathe out...");
                base.CountDown(mb_breathOut);
                Console.WriteLine();
                mb_totalTime = 0;
               }
        }
        
    }

    public void breathEndActivity(){
        base.EndActivity();
    }
    

    

}