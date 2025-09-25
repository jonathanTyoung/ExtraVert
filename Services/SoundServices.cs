// Services/SoundService.cs
using System;
using System.Collections.Generic;
using ExtraVert.Models;

namespace ExtraVert.Services
{
    public class SoundService
    {
        // This method works with any object that implements ISoundMaker
        public void MakeSoundTwice(ISoundMaker soundMaker)
        {
            Console.WriteLine("Making sound twice:");
            soundMaker.MakeSound();
            soundMaker.MakeSound();
        }

        // This method works with a list of any objects that implement ISoundMaker
        public void MakeAllSounds(List<ISoundMaker> soundMakers)
        {
            Console.WriteLine("All sounds:");

            foreach (var soundMaker in soundMakers)
            {
                soundMaker.MakeSound();
            }
        }
    }
}