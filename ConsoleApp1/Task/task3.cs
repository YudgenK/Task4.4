
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Task
{
    class task3
    {
        public void Run()
        {
            Player player = new Player();

            Console.WriteLine("Виберіть режим (1 - Відтворення, 2 - Запис): ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                IPlayable playable = player;
                playable.Play();
                playable.Pause();
                playable.Stop();
            }
            else if (choice == "2")
            {
                IRecodable recordable = player;
                recordable.Record();
                recordable.Pause();
                recordable.Stop();
            }
            else
            {
                Console.WriteLine("Невірний вибір.");
            }
        }


        interface IPlayable
        {
            void Play();
            void Pause();
            void Stop();
        }

        interface IRecodable
        {
            void Record();
            void Pause();
            void Stop();
        }

        class Player : IPlayable, IRecodable
        {
            public void Play()
            {
                Console.WriteLine("Відтворення розпочато.");
            }

            public void Pause()
            {
                Console.WriteLine("Програвач на паузі.");
            }

            public void Stop()
            {
                Console.WriteLine("Програвач зупинено.");
            }

            public void Record()
            {
                Console.WriteLine("Запис розпочато.");
            }

            void IRecodable.Pause()
            {
                Console.WriteLine("Запис призупинено.");
            }

            void IRecodable.Stop()
            {
                Console.WriteLine("Запис зупинено.");
            }
        }
    }
}
