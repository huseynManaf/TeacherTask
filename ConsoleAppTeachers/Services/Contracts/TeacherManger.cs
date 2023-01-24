using ConsoleAppTeachers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTeachers.Services.Contracts
{
    internal class TeacherManager : ICrudService, IPrintService
    {
        private Teacher[] _Teacher = new Teacher[100];
        private int _currentIndex = 0;

        public void Add(Entity entity)
        {
            if (_currentIndex > 99)
            {
                Console.WriteLine("Limiti kecdiniz! Sadece 100 telebe elave etmek olar");

                return;
            }

            _Teacher[_currentIndex++] = (Teacher)entity;
            Console.WriteLine("Student ugurla elave edildi!");
        }

        public void Delete(int id)
        {
            bool found = false;

            for (int i = 0; i < _Teacher.Length; i++)
            {
                if (_Teacher[i] == null)
                    continue;

                if (id == _Teacher[i].Id)
                {
                    found = true;

                    for (int j = i; j < _Teacher.Length - 1; j++)
                    {
                        _Teacher[j] = _Teacher[j + 1];
                    }
                    _currentIndex--;

                    Console.WriteLine($"{id}-li student silindi!");
                    return;
                }
            }

            if (!found)
                Console.WriteLine($"{id}-li student not found");
        }

        public Entity Get(int id)
        {
            for (int i = 0; i < _Teacher.Length; i++)
            {
                if (_Teacher[i] == null) continue;

                if (_Teacher    [i].Id == id)
                {
                    return _Teacher [i];
                }
            }

            Console.WriteLine("Not found!");

            return null;
        }

        public Entity[] GetAll()
        {
            return _Teacher;
        }

        public void Print()
        {
            foreach (var item in _Teacher)
            {
                if (item == null)
                    continue;

                Console.WriteLine(item);
            }
        }

        public void Update(int id, Entity entity)
        {
            for (int i = 0; i < _Teacher.Length; i++)
            {
                if (_Teacher[i] == null) continue;

                if (_Teacher[i].Id == id)
                {
                    _Teacher[i] = (Teacher)entity;
                    Console.WriteLine("Ugurla deyisdirildi!");

                    return;
                }
            }

            Console.WriteLine("Not found!");
        }

    }

}

