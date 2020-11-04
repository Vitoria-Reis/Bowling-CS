using System;

namespace BowlingCore
{
    public class BowlingScore
    {
        private int[] rolls = new int[21];
        private int playcurrent = 0;
        
       public void roll(int pins)
       {
           rolls[this.playcurrent++] = pins;
       }
        public double Score()
        {
            int score = 0;
            int FrameIndex = 0;
            for(int Frame = 0; Frame < 10; Frame++)
            {
                    if(Strike(FrameIndex))
                    {
                        score += this.rolls[FrameIndex] + this.rolls[FrameIndex +1] + this.rolls[FrameIndex +2];
                        FrameIndex ++;
                    }
                    else if(Spare(FrameIndex))
                    {
                        score += 10 + this.rolls[FrameIndex +2];
                        FrameIndex ++;
                        FrameIndex ++;
                    }
                    else
                    {
                        score += this.rolls[FrameIndex] + this.rolls[FrameIndex + 1];
                        FrameIndex ++;
                        FrameIndex ++;
                    }
            }
            return score;
        }
        private Boolean Spare(int FrameIndex)
        {
            return this.rolls[FrameIndex] + this.rolls[FrameIndex + 1] == 10;
        }
        private Boolean Strike(int FrameIndex)
        {
            return this.rolls[FrameIndex] == 10;
        }
    }
}