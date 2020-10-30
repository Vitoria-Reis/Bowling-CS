using System;

namespace BowlingCore
{
    public class BowlingScore
    {
        private int[] rolls = new int[21];
        private int JogadaAtual = 0;
        
       public void roll(int pins)
       {
           rolls[this.JogadaAtual++] = pins;
       }
        public double Score()
        {
            int score = 0;
            int Frames = 0;
            for(int Frame = 0; Frame < 10; Frame++)
            {
                    if(this.rolls[Frames] == 10)
                    {
                        score += 10 + this.rolls[Frames +1] + this.rolls[Frames +2];
                        Frames ++;
                    }
                    else if(this.rolls[Frames] + this.rolls[Frames + 1] == 10)
                    {
                        score += 10 + this.rolls[Frames +2];
                        Frames += 2;
                    }
                    else
                    {
                        score += this.rolls[Frames] + this.rolls[Frames + 1];
                        Frames += 2;
                    }
            }
            return score;
        }
    }
}