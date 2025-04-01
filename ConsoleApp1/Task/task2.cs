using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Task
{
    class task2
    {
        public void Run()
        {
            Console.Write("Введіть тип документа (XML, TXT, DOC): ");
            string docType = Console.ReadLine().ToUpper();

            AbstractHandler handler;

            if (docType == "XML")
            {
                handler = new XMLHandler();
            }
            else if (docType == "TXT")
            {
                handler = new TXTHandler();
            }
            else if (docType == "DOC")
            {
                handler = new DOCHandler();
            }
            else
            {
                handler = null;
            }

            if (handler != null)
            {
                handler.Open();
                handler.Create();
                handler.Change();
                handler.Save();
            }
            else
            {
                Console.WriteLine("Невідомий тип документа.");
            }
        }
    }
    
    abstract class AbstractHandler
    {
        public abstract void Open();
        public abstract void Create();
        public abstract void Change();
        public abstract void Save();
    }

    class XMLHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Відкрито XML документ");
        }

        public override void Create()
        {
            Console.WriteLine("Створено XML документ");
        }

        public override void Change()
        {
            Console.WriteLine("Редаговано XML документ");
        }

        public override void Save()
        {
            Console.WriteLine("Збережено XML документ");
        }
    }

    class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Відкрито TXT документ");
        }

        public override void Create()
        {
            Console.WriteLine("Створено TXT документ");
        }

        public override void Change()
        {
            Console.WriteLine("Редаговано TXT документ");
        }

        public override void Save()
        {
            Console.WriteLine("Збережено TXT документ");
        }
    }

    class DOCHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Відкрито DOC документ");
        }

        public override void Create()
        {
            Console.WriteLine("Створено DOC документ");
        }

        public override void Change()
        {
            Console.WriteLine("Редаговано DOC документ");
        }

        public override void Save()
        {
            Console.WriteLine("Збережено DOC документ");
        }
    }

   
}
